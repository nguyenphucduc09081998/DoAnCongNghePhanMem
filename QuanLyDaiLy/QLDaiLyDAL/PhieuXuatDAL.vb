Imports System.Configuration
Imports System.Data.SqlClient
Imports QLDaiLyDTO
Imports Utility
Public Class PhieuXuatDAL
    Private connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    ' lay ma dai ly
    Public Function buildMaPhieuXuat(ByRef nextMaPhieuXuat As Integer) As Result 'ex: 18222229

        Dim msOnDB As Integer
        Dim query As String = String.Empty
        query &= "SELECT IDENT_CURRENT('PHIEUXUAT')"


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
        query &= "SELECT * FROM [PHIEUXUAT]"

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
        query &= "SELECT * FROM [PHIEUXUAT]"
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
                        nextMaPhieuXuat = 1 + msOnDB

                    Else
                        nextMaPhieuXuat = 1
                    End If
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số phieu xuat kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        nextMaPhieuXuat += 0
        Return New Result(True) ' thanh cong
    End Function



    Public Function insert(px As PhieuXuatDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [PHIEUXUAT] ([MaDaiLy],[NgayLapPhieu],[TongGiaTri])"
        query &= "VALUES (@MaDaiLy,@NgayLapPhieu,@TongGiaTri)"
        'get MSDG
        Dim nextMaPhieuXuat = "1"
        buildMaPhieuXuat(nextMaPhieuXuat)
        px.MaPhieuXuat = nextMaPhieuXuat

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    '.Parameters.AddWithValue("@madg", dg.MaDG)
                    .Parameters.AddWithValue("@MaDaiLy", px.MaDaiLy)
                    .Parameters.AddWithValue("@NgayLapPhieu", px.NgayLapPhieu)
                    .Parameters.AddWithValue("@TongGiaTri", px.TongGiaTri)
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
    Public Function update(px As PhieuXuatDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [PHIEUXUAT] SET"
        'query &= " [MaPhieuXuat] = @MaPhieuXuat "
        query &= " [MaDaiLy] = @MaDaiLy "
        query &= " ,[NgayLapPhieu] = @NgayLapPhieu "
        query &= " ,[TongGiaTri] = @TongGiaTri "
        query &= " WHERE "
        query &= " [MaPhieuXuat] = @MaPhieuXuat "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@MaDaiLy", px.MaDaiLy)
                    .Parameters.AddWithValue("@NgayLapPhieu", px.NgayLapPhieu)
                    .Parameters.AddWithValue("@TongGiaTri", px.TongGiaTri)
                    .Parameters.AddWithValue("@MaPhieuXuat", px.MaPhieuXuat)
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

    Public Function delete(maPhieuXuat As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [PHIEUXUAT] "
        query &= " WHERE "
        query &= " [MaPhieuXuat] = @MaPhieuXuat "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuXuat", maPhieuXuat)
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

    Public Function selectALL(ByRef listPhieuXuat As List(Of PhieuXuatDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaPhieuXuat], [MaDaiLy], [NgayLapPhieu], [TongGiaTri]"
        query &= "FROM [PHIEUXUAT]"


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
                        listPhieuXuat.Clear()
                        While reader.Read()
                            listPhieuXuat.Add(New PhieuXuatDTO(reader("MaPhieuXuat"), reader("MaDaiLy"), reader("NgayLapPhieu"), reader("TongGiaTri")))
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

    Public Function selectALL_ByMaDaiLy(madl As Integer, ByRef listPhieuXuat As List(Of PhieuXuatDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaPhieuXuat], [MaDaiLy], [NgayLapPhieu], [TongGiaTri]"
        query &= "FROM [PHIEUXUAT] "
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
                        listPhieuXuat.Clear()
                        While reader.Read()
                            listPhieuXuat.Add(New PhieuXuatDTO(reader("MaPhieuXuat"), reader("MaDaiLy"), reader("NgayLapPhieu"), reader("TongGiaTri")))
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

    ''

    Public Function getthang(ByRef listthang As List(Of PhieuXuatDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT DISTINCT MONTH(NgayLapPhieu) AS Ngay "
        query &= "FROM [PHIEUXUAT]"


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
                        listthang.Clear()
                        While reader.Read()
                            listthang.Add(New PhieuXuatDTO(reader("Ngay")))
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




End Class
