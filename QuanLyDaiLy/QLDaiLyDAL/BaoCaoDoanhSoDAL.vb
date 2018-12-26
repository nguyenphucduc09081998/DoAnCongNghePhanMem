Imports System.Configuration
Imports System.Data.SqlClient
Imports QLDaiLyDTO
Imports Utility

Public Class BaoCaoDoanhSoDAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")

    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function GetDoanhSoByMonth(ByRef ListBaoCaoDoanhSo As List(Of BaoCaoDoanhSoDTO), thang As Integer) As Result
        Dim query As String = String.Empty
        Dim tongGiaTri As Double = 0
        Dim stt As Integer = 1
        query &= "SELECT [dl].[TenDL], COUNT([px].[MaPhieuXuat]) AS [SoPhieuXuat], SUM([px].[TongGiatri]) AS [TongGiaTri] "
        query &= "FROM [PHIEUXUAT] AS [px], [DAILY] AS [dl] "
        'sua DAILY tu HOSODAILY
        query &= "WHERE MONTH([px].[NgayLapPhieu]) = @thang AND [dl].[MaDL] = [px].[MaDaiLy] "
        query &= "GROUP BY [dl].[TenDL]"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@thang", thang)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        ListBaoCaoDoanhSo.Clear()
                        While reader.Read()
                            ListBaoCaoDoanhSo.Add(New BaoCaoDoanhSoDTO(stt, reader("TenDL"), reader("SoPhieuXuat"), reader("TongGiaTri"), vbNull))
                            tongGiaTri += reader("TongGiaTri")
                            stt += 1
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "L?y Doanh S? không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Dim tyLe As Double
        For i As Integer = 0 To ListBaoCaoDoanhSo.Count - 1
            tyLe = (ListBaoCaoDoanhSo(i).TongTriGia / tongGiaTri) * 100
            ListBaoCaoDoanhSo(i).TyLe = Math.Round(tyLe, 2)
        Next



        Return New Result(True) ' thanh cong
    End Function

    Public Function GetAllMonthHaveData(ByRef listThang As List(Of Integer)) As Result
        Dim query As String = String.Empty
        query &= "SELECT DISTINCT MONTH([NgayLapPhieu]) AS [Thang] FROM [PHIEUXUAT]"

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
                        listThang.Clear()
                        While reader.Read()
                            listThang.Add(reader("Thang"))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "L?y Tháng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
