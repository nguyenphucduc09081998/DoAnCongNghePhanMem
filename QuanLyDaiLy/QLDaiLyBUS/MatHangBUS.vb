Imports QLDaiLyDAL
Imports QLDaiLyDTO
Imports Utility

Public Class MatHangBUS

    Private mathangDAL As MatHangDAL

    Public Sub New()
        mathangDAL = New MatHangDAL()
    End Sub
    Public Sub New(connectionString As String)
        mathangDAL = New MatHangDAL(connectionString)
    End Sub


    Public Function builMaMatHang(ByRef nextMaMatHang As Integer) As Result
        Return mathangDAL.builMaMatHang(nextMaMatHang)
    End Function
    Public Function insert(mathang As MatHangDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return mathangDAL.insert(mathang)
    End Function
    Public Function selectAll(ByRef listmathang As List(Of MatHangDTO)) As Result

        Return mathangDAL.selectALL(listmathang)
    End Function
    Public Function delete(mathang As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return mathangDAL.delete(mathang)
    End Function
    Public Function Update(mathang As MatHangDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return mathangDAL.update(mathang)
    End Function
    Public Function countsomathang(ByRef sdf As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return mathangDAL.countsomathang(sdf)
    End Function
    Public Function selectSomathang_thamso(ByRef somathangtoida As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return mathangDAL.selectSomathang_thamso(somathangtoida)
    End Function

End Class
