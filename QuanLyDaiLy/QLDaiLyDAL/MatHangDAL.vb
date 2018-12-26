Imports System.Configuration
Imports System.Data.SqlClient
Imports QLDaiLyDTO
Imports Utility



Public Class MatHangDAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")

    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function builMaMatHang(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaMatHang] "
        query &= "FROM [MATHANG] "
        query &= "ORDER BY [MaMatHang] DESC "

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
                            idOnDB = reader("MaMatHang")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của Mat Hang không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function insert(mathang As MatHangDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [MATHANG] ([MaMatHang], [TenMatHang],[SoLuongTon])"
        query &= "VALUES (@MaMatHang,@TenMatHang,@SoLuongTon)"

        Dim nextID = 0
        Dim result As Result
        result = builMaMatHang(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        mathang.MaMatHang = nextID
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaMatHang", mathang.MaMatHang)
                    .Parameters.AddWithValue("@TenMatHang", mathang.TenMatHang)
                    .Parameters.AddWithValue("@SoLuongTon", mathang.SoLuongTon)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm mat hang không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listmathang As List(Of MatHangDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaMatHang], [TenMatHang],[SoLuongTon]"
        query &= "FROM [MATHANG]"
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
                        listmathang.Clear()
                        While reader.Read()
                            listmathang.Add(New MatHangDTO(reader("MaMatHang"), reader("TenMatHang"), reader("SoLuongTon")))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả ma mat hang không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maMatHang As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [MATHANG] "
        query &= " WHERE "
        query &= " [MaMatHang] = @MaMatHang "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaMatHang", maMatHang)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa mat hang không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(mathang As MatHangDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [MATHANG] SET"
        query &= " [TenMatHang] = @TenMatHang "
        query &= ", [SoLuongTon] = @SoLuongTon "
        query &= "WHERE "
        query &= " [MaMatHang]= @MaMatHang "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaMatHang", mathang.MaMatHang)
                    .Parameters.AddWithValue("@TenMatHang", mathang.TenMatHang)
                    .Parameters.AddWithValue("@SoLuongTon", mathang.SoLuongTon)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật mat hang không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function countsomathang(ByRef soluongmathang As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT COUNT ([MaMatHang])"
        query &= "As [SoLuong] "
        query &= "FROM [MATHANG] "


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
                        soluongmathang = sqlReader("SoLuong")
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
    Public Function selectSomathang_thamso(ByRef somathangtoida As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT [SoMatHang]"
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
                            somathangtoida = reader("SoMatHang")
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
