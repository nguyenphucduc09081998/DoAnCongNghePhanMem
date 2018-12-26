Imports System.Configuration
Imports System.Data.SqlClient
Imports QLDaiLyDTO
Imports Utility


Public Class DonViTinhDAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")

    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildMaDonViTinh(ByRef nextMaDonViTinh As Integer) As Result 'ex: 18222229   
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaDonViTinh] "
        query &= "FROM [DONVITINH] "
        query &= "ORDER BY [MaDonViTinh] DESC "
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("MaDonViTinh")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextMaDonViTinh = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextMaDonViTinh = 1
                    Return New Result(False, "Lấy ID kế tiếp của don vi tinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(donvitinh As DonViTinhDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [DONVITINH] ([MaDonViTinh], [TenDonViTinh])"
        query &= "VALUES (@MaDonViTinh,@TenDonViTinh)"
        'query &= "WHERE (    (SELECT [SoDonViTinh]  FROM [THAMSO] )  >  ( SELECT count(*) FROM  [DONVITINH] )  )  "
        'query &= "SELECT [SoDonViTinh]"
        'query &= "FROM [THAMSO]"
        'query &= "WHERE (( SELECT count(*) FROM  [DONVITINH] ) < [SoDonViTinh] )"


        Dim nextID = 0
        Dim result As Result
        result = buildMaDonViTinh(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        donvitinh.MaDonViTinh = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDonViTinh", donvitinh.MaDonViTinh)
                    .Parameters.AddWithValue("@TenDonViTinh", donvitinh.TenDonViTinh)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm don vi tinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function selectALL(ByRef listdonvitinh As List(Of DonViTinhDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [MaDonViTinh], [TenDonViTinh]"
        query &= "FROM [DONVITINH]"
        'query &= "WHERE ( (SELECT [SoDaiLyToiDa] FROM [THAMSO]) > (SELECT count(*) FROM  [DAILY] where QUAN.MaQuan = DAILY.MaQuan) )"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listdonvitinh.Clear()
                        While reader.Read()
                            listdonvitinh.Add(New DonViTinhDTO(reader("MaDonViTinh"), reader("TenDonViTinh")))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả don vi tinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maDonViTinh As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [DONVITINH] "
        query &= " WHERE "
        query &= " [MaDonViTinh] = @MaDonViTinh "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDonViTinh", maDonViTinh)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa don vi tinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(ldonvitinh As DonViTinhDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [DONVITINH] SET"
        query &= " [TenDonViTinh] = @TenDonViTinh "
        query &= "WHERE "
        query &= " [MaDonViTinh] = @MaDonViTinh "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDonViTinh", ldonvitinh.MaDonViTinh)
                    .Parameters.AddWithValue("@TenDonViTinh", ldonvitinh.TenDonViTinh)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật don vi tinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function soluongdonvitinh(ByRef soluong As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT COUNT ([MaDonViTinh])"
        query &= "As [SoLuong] "
        query &= "FROM [DONVITINH] "


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim sqlReader As SqlDataReader = comm.ExecuteReader()
                    While sqlReader.Read()
                        soluong = sqlReader("SoLuong")
                    End While
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "lay so luong loai dai ly", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectSoDonVitinh_thamso(ByRef sodonvitinh As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT [SoDonViTinh]"
        query &= "FROM [THAMSO] "
        ' query &= "WHERE [MaDL] = @MaDaiLy "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    '.Parameters.AddWithValue("@MaDaiLy", madl)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        'NoCuaDaiLy.Clear()
                        While reader.Read()
                            sodonvitinh = reader("SoDonViTinh")
                            'listPhieuThuTien.Add(New PhieuThuTienDTO(reader("MaPhieuThu"), reader("MaDaiLy"), reader("NgayThuTien"), reader("SoTienThu")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả dai li theo ma dai ly không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class
