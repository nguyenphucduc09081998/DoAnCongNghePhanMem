Imports QLDaiLyBUS
Imports QLDaiLyDAL
Imports QLDaiLyDTO
Imports Utility
Public Class BaoCaoCongNoBUS
    Private bccongnoDal As BaoCaoCongNoDAL
    Public Sub New()
        bccongnoDal = New BaoCaoCongNoDAL()
    End Sub
    Public Sub New(connectionString As String)
        bccongnoDal = New BaoCaoCongNoDAL(connectionString)
    End Sub


    Public Function insert(bc As BaoCaoCongNo) As Result
        '1. verify data here!!
        Return bccongnoDal.insert(bc)

        'Return New Result(False )
    End Function


    Public Function buildMaBaoCaoCongNo(ByRef nextMaBCCongNo As Integer) As Result
        Return bccongnoDal.buildMaBaoCaoCongNo(nextMaBCCongNo)
    End Function
    Public Function selectAll(ByRef listMaDaiLy As List(Of BaoCaoCongNo)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bccongnoDal.selectALL(listMaDaiLy)
    End Function

    Public Function selectALL_ByMaDaiLy(madaili As Integer, ByRef listDL As List(Of BaoCaoCongNo)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bccongnoDal.selectALL_ByMaDaiLy(madaili, listDL)
    End Function


    Public Function delete(px As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bccongnoDal.delete(px)
    End Function
    Public Function update(bc As BaoCaoCongNo) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bccongnoDal.update(bc)
    End Function
End Class
