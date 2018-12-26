Imports QLDaiLyDAL
Imports QLDaiLyDTO
Imports Utility

Public Class QuanBUS
    Private quanDAL As QuanDAL
    Public Sub New()
        quanDAL = New QuanDAL()
    End Sub
    Public Sub New(connectionString As String)
        quanDAL = New QuanDAL(connectionString)
    End Sub

    Public Function insert(quan As QuanDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return quanDAL.insert(quan)
    End Function

    Public Function buildMaQuan(ByRef nextMaQuan As Integer) As Result
        Return quanDAL.buildMaQuan(nextMaQuan)
    End Function
    Public Function selectAll(ByRef listquan As List(Of QuanDTO)) As Result

        Return quanDAL.selectALL(listquan)
    End Function

    Public Function update(lq As QuanDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return quanDAL.update(lq)
    End Function
    Public Function delete(maquan As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return quanDAL.delete(maquan)
    End Function



    Public Function selectAll_no(ByRef listquan As List(Of QuanDTO)) As Result

        Return quanDAL.selectALL_no(listquan)
    End Function

End Class
