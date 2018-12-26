Imports QLDaiLyDAL
Imports QLDaiLyDTO
Imports Utility

Public Class BaoCaoDoanhSoBUS
    Private BaoCaoDoanhSoDAL As BaoCaoDoanhSoDAL

    Public Sub New()
        BaoCaoDoanhSoDAL = New BaoCaoDoanhSoDAL()
    End Sub
    Public Sub New(connectionString As String)
        BaoCaoDoanhSoDAL = New BaoCaoDoanhSoDAL(connectionString)
    End Sub

    Public Function GetDoanhSoByMonth(ByRef ListBaoCaoDoanhSo As List(Of BaoCaoDoanhSoDTO), thang As Integer) As Result
        Return BaoCaoDoanhSoDAL.GetDoanhSoByMonth(ListBaoCaoDoanhSo, thang)
    End Function
    Public Function GetAllMonthHaveData(ByRef listThang As List(Of Integer)) As Result
        Return BaoCaoDoanhSoDAL.GetAllMonthHaveData(listThang)
    End Function
End Class