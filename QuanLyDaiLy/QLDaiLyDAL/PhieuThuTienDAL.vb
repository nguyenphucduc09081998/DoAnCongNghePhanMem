Imports System.Configuration
Imports System.Data.SqlClient
Imports QLDaiLyDTO
Imports Utility
Public Class PhieuThuTienDAL
    Private connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    ' lay ma phiue thu tien
    Public Function buildMaPhieuThuTien(ByRef nextMaPhieuThuTien As Integer) As Result 'ex: 18222229

        Dim msOnDB As Integer
        Dim query As String = String.Empty
        query &= "SELECT IDENT_CURRENT('PHIEUTHUTIEN')"


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
                    Return New Result(False, "Lấy tự động Mã số phieu xuat kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        query = String.Empty
        query &= "SELECT * FROM [PHIEUTHUTIEN]"

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
                    Return New Result(False, "Lấy tự động Mã số phieu xuat kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        query = String.Empty
        query &= "SELECT * FROM [PHIEUTHUTIEN]"
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
                        nextMaPhieuThuTien = 1 + msOnDB

                    Else
                        nextMaPhieuThuTien = 1
                    End If
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số phieu xuat kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        nextMaPhieuThuTien += 0
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(pt As PhieuThuTienDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [PHIEUTHUTIEN] ([MaDaiLy],[NgayThuTien],[SoTienThu])"
        query &= "VALUES (@MaDaiLy,@NgayThuTien,@SoTienThu)"





        'query &= "WHERE (PHIEUTHUTIEN.MaDaiLy = DAILY.MaDL) and (PHIEUTHUTIEN.SoTienThu < DAILY.NoCuaDaiLy)"


        'get MSDG
        Dim nextMaPhieuThuTien = "1"
        buildMaPhieuThuTien(nextMaPhieuThuTien)
        pt.MaPhieuThu = nextMaPhieuThuTien

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    '.Parameters.AddWithValue("@madg", dg.MaDG)
                    .Parameters.AddWithValue("@MaDaiLy", pt.MaDaiLy)
                    .Parameters.AddWithValue("@NgayThuTien", pt.NgayThuTien)
                    .Parameters.AddWithValue("@SoTienThu", pt.SoTienThu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm phieu xuat không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(pt As PhieuThuTienDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [PHIEUTHUTIEN] SET"
        'query &= " [MaPhieuXuat] = @MaPhieuXuat "
        query &= " [MaDaiLy] = @MaDaiLy "
        query &= " ,[NgayThuTien] = @NgayThuTien "
        query &= " ,[SoTienThu] = @SoTienThu "
        query &= " WHERE "
        query &= " [MaPhieuThu] = @MaPhieuThu "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@MaDaiLy", pt.MaDaiLy)
                    .Parameters.AddWithValue("@NgayThuTien", pt.NgayThuTien)
                    .Parameters.AddWithValue("@SoTienThu", pt.SoTienThu)
                    .Parameters.AddWithValue("@MaPhieuThu", pt.MaPhieuThu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật phieu xuat không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function delete(maPhieuThuTien As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [PHIEUTHUTIEN] "
        query &= " WHERE "
        query &= " [MaPhieuThu] = @MaPhieuThu "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuThu", maPhieuThuTien)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa phieu xuat không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function



    Public Function selectALL(ByRef listPhieuThuTien As List(Of PhieuThuTienDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaPhieuThu], [MaDaiLy], [NgayThuTien], [SoTienThu]"
        query &= "FROM [PHIEUTHUTIEN]"


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
                        listPhieuThuTien.Clear()
                        While reader.Read()
                            listPhieuThuTien.Add(New PhieuThuTienDTO(reader("MaPhieuThu"), reader("MaDaiLy"), reader("NgayThuTien"), reader("SoTienThu")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả phieu xuat không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function




    Public Function selectALL_ByMaDaiLy(madl As Integer, ByRef listPhieuThuTien As List(Of PhieuThuTienDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaPhieuThu], [MaDaiLy], [NgayThuTien], [SoTienThu]"
        query &= "FROM [PHIEUTHUTIEN] "
        query &= "WHERE [MaDaiLy] = @MaDaiLy "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDaiLy", madl)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listPhieuThuTien.Clear()
                        While reader.Read()
                            listPhieuThuTien.Add(New PhieuThuTienDTO(reader("MaPhieuThu"), reader("MaDaiLy"), reader("NgayThuTien"), reader("SoTienThu")))
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




    Public Function selectNoDaiLy_ByMaDaiLy(madl As Integer, ByRef NoCuaDaiLy As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT [NoCuaDaiLy]"
        query &= "FROM [DAILY] "
        query &= "WHERE [MaDL] = @MaDaiLy "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDaiLy", madl)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        'NoCuaDaiLy.Clear()
                        While reader.Read()
                            NoCuaDaiLy = reader("NoCuaDaiLy")
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
