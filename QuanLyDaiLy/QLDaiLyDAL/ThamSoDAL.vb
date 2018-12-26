Imports System.Configuration
Imports System.Data.SqlClient
Imports QLDaiLyDTO
Imports Utility

Public Class ThamSoDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function update(ts As ThamSoDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [THAMSO] SET"
        query &= " [SoDaiLyToiDa] = @SoDaiLyToiDa "
        query &= " ,[SoLoaiDaiLy] = @SoLoaiDaiLy "
        query &= " ,[SoMatHang] = @SoMatHang "
        query &= " ,[SoDonViTinh] = @SoDonViTinh "
        query &= "WHERE "
        query &= " [Id] = @Id "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@SoDaiLyToiDa", ts.SoDaiLyToiDa)
                    .Parameters.AddWithValue("@SoLoaiDaiLy", ts.SoLoaiDaiLy)
                    .Parameters.AddWithValue("@SoMatHang", ts.SoMatHang)
                    .Parameters.AddWithValue("@SoDonViTinh", ts.SoDonViTinh)

                    .Parameters.AddWithValue("@Id", ts.Id)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Quy Định không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function selectALL(ByRef thamso As List(Of ThamSoDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [Id], [SoDaiLyToiDa], [SoLoaiDaiLy], [SoMatHang],[SoDonViTinh]"
        query &= " FROM [THAMSO]"

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
                        thamso.Clear()
                        While reader.Read()
                            thamso.Add(New ThamSoDTO(reader("Id"), reader("SoDaiLyToiDa"), reader("SoLoaiDaiLy"), reader("SoMatHang"), reader("SoDonViTinh")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy Quy Định không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class

