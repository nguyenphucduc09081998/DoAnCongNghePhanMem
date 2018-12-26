Imports System.Configuration
Imports System.Data.SqlClient
Imports QLDaiLyDTO
Imports Utility


Public Class QuanDAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")

    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildMaQuan(ByRef nextMaQuan As Integer) As Result 'ex: 18222229   
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaQuan] "
        query &= "FROM [QUAN] "
        query &= "ORDER BY [MaQuan] DESC "
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
                            idOnDB = reader("MaQuan")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextMaQuan = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextMaQuan = 1
                    Return New Result(False, "Lấy ID kế tiếp của Loại năm học không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(quan As QuanDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [QUAN] ([MaQuan], [TenQuan])"
        query &= "VALUES (@MaQuan,@TenQuan)"

        Dim nextID = 0
        Dim result As Result
        result = buildMaQuan(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        quan.MaQuan = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaQuan", quan.MaQuan)
                    .Parameters.AddWithValue("@TenQuan", quan.TenQuan)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm Quan không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function selectALL(ByRef listQuan As List(Of QuanDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [MaQuan], [TenQuan]"
        query &= "FROM [QUAN]"
        query &= "WHERE ( (SELECT [SoDaiLyToiDa] FROM [THAMSO]  ) > (SELECT count(*) FROM  [DAILY] where QUAN.MaQuan = DAILY.MaQuan) )"

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
                        listQuan.Clear()
                        While reader.Read()
                            listQuan.Add(New QuanDTO(reader("MaQuan"), reader("TenQuan")))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Quận không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maQuan As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [QUAN] "
        query &= " WHERE "
        query &= " [MaQuan] = @MaQuan "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maQuan", maQuan)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa Quan không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(lq As QuanDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [QUAN] SET"
        query &= " [TenQuan] = @TenQuan "
        query &= "WHERE "
        query &= " [MaQuan] = @MaQuan "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaQuan", lq.MaQuan)
                    .Parameters.AddWithValue("@TenQuan", lq.TenQuan)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật quan không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function selectALL_no(ByRef listQuan As List(Of QuanDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT DISTINCT [QUAN].[MaQuan], [TenQuan]"
        query &= "FROM [QUAN], [DAILY]"
        query &= "WHERE [QUAN].[MaQuan] = [DAILY].[MaQuan] "

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
                        listQuan.Clear()
                        While reader.Read()
                            listQuan.Add(New QuanDTO(reader("MaQuan"), reader("TenQuan")))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Quận không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class
