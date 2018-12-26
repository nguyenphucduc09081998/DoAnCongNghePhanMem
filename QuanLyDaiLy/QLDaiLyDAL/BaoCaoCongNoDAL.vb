Imports System.Configuration
Imports System.Data.SqlClient
Imports QLDaiLyDTO
Imports Utility
Public Class BaoCaoCongNoDAL
    Private connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    ' lay ma dai ly
    Public Function buildMaBaoCaoCongNo(ByRef nextMaBCCongNo As Integer) As Result 'ex: 18222229

        Dim msOnDB As Integer
        Dim query As String = String.Empty
        query &= "SELECT IDENT_CURRENT('BAOCAOCONGNO')"


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
        query &= "SELECT * FROM [BAOCAOCONGNO]"

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
        query &= "SELECT * FROM [BAOCAOCONGNO]"
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
                        nextMaBCCongNo = 1 + msOnDB

                    Else
                        nextMaBCCongNo = 1
                    End If
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số phieu xuat kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        nextMaBCCongNo += 0
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(bc As BaoCaoCongNo) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [BAOCAOCONGNO] ([MaDaiLy],[NoDau],[NoCuoi],[PhatSinh])"
        query &= "VALUES (@MaDaiLy,@NoDau,@NoCuoi,@PhatSinh)"
        'get MSDG
        Dim nextMaBCCongNo = "1"
        buildMaBaoCaoCongNo(nextMaBCCongNo)
        bc.MaBaoCaoCongNo = nextMaBCCongNo

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    '.Parameters.AddWithValue("@madg", dg.MaDG)
                    .Parameters.AddWithValue("@MaDaiLy", bc.MaDaiLy)
                    .Parameters.AddWithValue("@NoDau", bc.NoDau)
                    .Parameters.AddWithValue("@NoCuoi", bc.NoCuoi)
                    .Parameters.AddWithValue("@PhatSinh", bc.PhatSinh)
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
    Public Function update(bc As BaoCaoCongNo) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [BAOCAOCONGNO] SET"
        'query &= " [MaPhieuXuat] = @MaPhieuXuat "
        query &= " [MaDaiLy] = @MaDaiLy "
        query &= " ,[NoDau] = @NoDau "
        query &= " ,[NoCuoi] = @NoCuoi "
        query &= " ,[PhatSinh] = @PhatSinh "
        query &= " WHERE "
        query &= " [MaBaoCaoCongNo] = @MaBaoCaoCongNo "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@MaDaiLy", bc.MaDaiLy)
                    .Parameters.AddWithValue("@NoDau", bc.NoDau)
                    .Parameters.AddWithValue("@NoCuoi", bc.NoCuoi)
                    .Parameters.AddWithValue("@PhatSinh", bc.PhatSinh)
                    .Parameters.AddWithValue("@MaBaoCaoCongNo", bc.MaBaoCaoCongNo)
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


    Public Function delete(maBCCongNo As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [BAOCAOCONGNO] "
        query &= " WHERE "
        query &= " [MaBaoCaoCongNo] = @MaBaoCaoCongNo "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaBaoCaoCongNo", maBCCongNo)
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

    Public Function selectALL(ByRef listBCCongNo As List(Of BaoCaoCongNo)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaBaoCaoCongNo], [MaDaiLy], [NoDau], [NoCuoi], [PhatSinh]"
        query &= "FROM [BAOCAOCONGNO]"


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
                        listBCCongNo.Clear()
                        While reader.Read()
                            listBCCongNo.Add(New BaoCaoCongNo(reader("MaBaoCaoCongNo"), reader("MaDaiLy"), reader("NoDau"), reader("NoCuoi"), reader("PhatSinh")))
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




    Public Function selectALL_ByMaDaiLy(madl As Integer, ByRef listBCCongNo As List(Of BaoCaoCongNo)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaBaoCaoCongNo], [MaDaiLy], [NoDau], [NoCuoi], [PhatSinh]"
        query &= "FROM [BAOCAOCONGNO] "
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
                        listBCCongNo.Clear()
                        While reader.Read()
                            listBCCongNo.Add(New BaoCaoCongNo(reader("MaBaoCaoCongNo"), reader("MaDaiLy"), reader("NoDau"), reader("NoCuoi"), reader("PhatSinh")))
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
