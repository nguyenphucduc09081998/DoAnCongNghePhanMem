Imports System.Configuration
Imports System.Data.SqlClient
Imports QLDaiLyDTO
Imports Utility


Public Class ChiTietPhieuXuatDAL
    Private connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")

    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    'Public Function builMaChiTiet(ByRef nextID As Integer) As Result

    '    Dim query As String = String.Empty
    '    query &= "SELECT TOP 1 [MaChiTietPhieu] "
    '    query &= "FROM [CHITIETPHIEUXUAT] "
    '    query &= "ORDER BY [MaChiTietPhieu] DESC "

    '    Using conn As New SqlConnection(connectionString)
    '        Using comm As New SqlCommand()
    '            With comm
    '                .Connection = conn
    '                .CommandType = CommandType.Text
    '                .CommandText = query
    '            End With
    '            Try
    '                conn.Open()
    '                Dim reader As SqlDataReader
    '                reader = comm.ExecuteReader()
    '                Dim idOnDB As Integer
    '                idOnDB = Nothing
    '                If reader.HasRows = True Then
    '                    While reader.Read()
    '                        idOnDB = reader("MaChiTietPhieu")
    '                    End While
    '                End If
    '                ' new ID = current ID + 1
    '                nextID = idOnDB + 1
    '            Catch ex As Exception
    '                conn.Close()
    '                ' them that bai!!!
    '                nextID = 1
    '                Return New Result(False, "Lấy ID kế tiếp của chi tiet phieu không thành công", ex.StackTrace)
    '            End Try
    '        End Using
    '    End Using
    '    Return New Result(True) ' thanh cong
    'End Function
    Public Function builMaChiTiet(ByRef nextMact As Integer) As Result 'ex: 18222229

        Dim msOnDB As Integer
        Dim query As String = String.Empty
        query &= "SELECT IDENT_CURRENT('CHITIETPHIEUXUAT')"


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
                    'Dim msOnDB As String
                    'msOnDB = Nothing

                    If reader.HasRows = True Then
                        While reader.Read()
                            'msOnDB = reader("madg")
                            msOnDB = Convert.ToInt32(reader.GetValue(0))

                        End While
                    End If
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số Học sinh kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        query = String.Empty
        query &= "SELECT * FROM [CHITIETPHIEUXUAT]"

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
                        While reader.Read()
                            msOnDB = Convert.ToInt32(reader.GetValue(0))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số Học sinh kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        query = String.Empty
        query &= "SELECT * FROM [CHITIETPHIEUXUAT]"
        'neu has row thi nextMsdg = "SELECT IDENT_CURRENT('DOCGIA')" + 1
        'neu khong co row thì next Msdg = 1;
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
                        nextMact = 1 + msOnDB

                    Else
                        nextMact = 1
                    End If
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số Học sinh kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        nextMact += 0
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(ct As ChiTietPhieuXuatDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [CHITIETPHIEUXUAT] ([MaPhieuXuat],[MaMatHang],[MaDonViTinh],[SoLuongXuat],[DonGia],[ThanhTien])"
        query &= "VALUES (@MaPhieuXuat,@MaMatHang,@MaDonViTinh,@SoLuongXuat,@DonGia,@ThanhTien)"
        'get MSDG
        Dim nextMaCT = "1"
        builMaChiTiet(nextMaCT)
        ct.MaChiTietPhieu = nextMaCT

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    '.Parameters.AddWithValue("@madg", dg.MaDG)
                    .Parameters.AddWithValue("@MaPhieuXuat", ct.MaPhieuXuat)
                    .Parameters.AddWithValue("@MaMatHang", ct.MaMatHang)
                    .Parameters.AddWithValue("@MaDonViTinh", ct.MaDonViTinh)
                    .Parameters.AddWithValue("@SoLuongXuat", ct.SoLuongXuat)
                    .Parameters.AddWithValue("@DonGia", ct.DonGia)
                    .Parameters.AddWithValue("@ThanhTien", ct.ThanhTien)


                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm chi tiet phieu xuat không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(ct As ChiTietPhieuXuatDTO) As Result


        Dim query As String = String.Empty
        query &= " UPDATE [CHITIETPHIEUXUAT] SET"
        '  query &= " [MaDL] = @MaDL "
        query &= " [MaPhieuXuat] = @MaPhieuXuat "
        query &= " ,[MaMatHang] = @MaMatHang "
        query &= " ,[MaDonViTinh] = @MaDonViTinh "
        query &= " ,[SoLuongXuat] = @SoLuongXuat "
        query &= " ,[DonGia] = @DonGia "
        query &= " ,[ThanhTien] = @ThanhTien "
        query &= " WHERE "
        query &= " [MaChiTietPhieu] = @MaChiTietPhieu "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    '.Parameters.AddWithValue("@MaDL", dl.MaDL)
                    .Parameters.AddWithValue("@MaPhieuXuat", ct.MaPhieuXuat)
                    .Parameters.AddWithValue("@MaMatHang", ct.MaMatHang)
                    .Parameters.AddWithValue("@MaDonViTinh", ct.MaDonViTinh)
                    .Parameters.AddWithValue("@SoLuongXuat", ct.SoLuongXuat)
                    .Parameters.AddWithValue("@DonGia", ct.DonGia)
                    .Parameters.AddWithValue("@ThanhTien", ct.ThanhTien)
                    .Parameters.AddWithValue("@MaChiTietPhieu", ct.MaChiTietPhieu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật chi tiet phieu xuat không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function delete(maChiTiet As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [CHITIETPHIEUXUAT] "
        query &= " WHERE "
        query &= " [MaChiTietPhieu] = @MaChiTietPhieu "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaChiTietPhieu", maChiTiet)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa chi tiet phieu xuat không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function



    Public Function selectALL(ByRef listChiTiet As List(Of ChiTietPhieuXuatDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaChiTietPhieu],[MaPhieuXuat], [MaMatHang], [MaDonViTinh], [SoLuongXuat],[DonGia],[ThanhTien]"
        query &= "FROM [CHITIETPHIEUXUAT]"


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
                        listChiTiet.Clear()
                        While reader.Read()
                            listChiTiet.Add(New ChiTietPhieuXuatDTO(reader("MaChiTietPhieu"), reader("MaPhieuXuat"), reader("MaMatHang"), reader("MaDonViTinh"), reader("SoLuongXuat"), reader("DonGia"), reader("ThanhTien")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả chi tiet phieu xuat không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function




    Public Function selectALL_ByMaLoaiDL(maPhieuxuat As Integer, ByRef listDaiLy As List(Of ChiTietPhieuXuatDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaChiTietPhieu],[MaPhieuXuat], [MaMatHang], [MaDonViTinh], [SoLuongXuat],[DonGia],[ThanhTien]"
        query &= "FROM [CHITIETPHIEUXUAT] "
        query &= "WHERE [MaPhieuXuat] = @MaPhieuXuat "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuXuat", maPhieuxuat)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listDaiLy.Clear()
                        While reader.Read()
                            listDaiLy.Add(New ChiTietPhieuXuatDTO(reader("MaChiTietPhieu"), reader("MaPhieuXuat"), reader("MaMatHang"), reader("MaDonViTinh"), reader("SoLuongXuat"), reader("DonGia"), reader("ThanhTien")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả phieu xuat theo ma không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class
