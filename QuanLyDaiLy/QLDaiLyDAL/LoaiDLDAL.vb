Imports System.Configuration
Imports System.Data.SqlClient
Imports QLDaiLyDTO

Imports Utility


Public Class LoaiDlDAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")

    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function builMaLoaiDL(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaLoaiDL] "
        query &= "FROM [LOAIDL] "
        query &= "ORDER BY [MaLoaiDL] DESC "

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
                            idOnDB = reader("MaLoaiDL")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của loai dai ly không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function insert(loaiDL As LoaiDLDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [LOAIDL] ([MaLoaiDL], [TenLoaiDL],[NoToiDa])"
        query &= "VALUES (@MaLoaiDL,@TenLoaiDL,@NoToiDa)"

        Dim nextID = 0
        Dim result As Result
        result = builMaLoaiDL(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        loaiDL.MaLoaiDL = nextID
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiDL", loaiDL.MaLoaiDL)
                    .Parameters.AddWithValue("@TenLoaiDL", loaiDL.TenLoaiDL)
                    .Parameters.AddWithValue("@NoToiDa", loaiDL.NoToiDa)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm loai dai ly không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listDaiLy As List(Of LoaiDLDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaLoaiDL], [TenLoaiDL],[NoToiDa]"
        query &= "FROM [LOAIDL]"
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
                        listDaiLy.Clear()
                        While reader.Read()
                            listDaiLy.Add(New LoaiDLDTO(reader("MaLoaiDL"), reader("TenLoaiDL"), reader("NoToiDa")))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả loai dl không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maLoaiDL As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [LOAIDL] "
        query &= " WHERE "
        query &= " [MaLoaiDL] = @MaLoaiDL "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiDL", maLoaiDL)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa loai DL không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(lloaidl As LoaiDLDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [LOAIDL] SET"
        query &= " [TenLoaiDL] = @TenLoaiDL "
        query &= ", [NoToiDa] = @NoToiDa "
        query &= "WHERE "
        query &= " [MaLoaiDL]= @MaLoaiDL "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiDL", lloaidl.MaLoaiDL)
                    .Parameters.AddWithValue("@TenLoaiDL", lloaidl.TenLoaiDL)
                    .Parameters.AddWithValue("@NoToiDa", lloaidl.NoToiDa)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật loai DL không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function










    Public Function countsoluongloaidaily(ByRef soluongldl As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT COUNT ([MaLoaiDL])"
        query &= "As [SoLuong] "
        query &= "FROM [LOAIDL] "


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
                        soluongldl = sqlReader("SoLuong")
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
    Public Function selectSoloaidaily_thamso(ByRef soloaidailytoida As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT [SoLoaiDaiLy]"
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
                            soloaidailytoida = reader("SoLoaiDaiLy")
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
