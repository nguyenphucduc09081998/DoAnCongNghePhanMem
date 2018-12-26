Imports QLDaiLyBUS
Imports QLDaiLyDAL
Imports QLDaiLyDTO
Imports Utility
Public Class PhieuThuTienBUS
    Private ptDal As PhieuThuTienDAL
    Public Sub New()
        ptDal = New PhieuThuTienDAL()
    End Sub
    Public Sub New(connectionString As String)
        ptDal = New PhieuThuTienDAL(connectionString)
    End Sub


    Public Function insert(px As PhieuThuTienDTO) As Result
        '1. verify data here!!
        Return ptDal.insert(px)

        'Return New Result(False )
    End Function


    Public Function buildMaPhieuThuTien(ByRef nextMaPhieuThuTien As Integer) As Result
        Return ptDal.buildMaPhieuThuTien(nextMaPhieuThuTien)
    End Function
    Public Function selectAll(ByRef listMaDaiLy As List(Of PhieuThuTienDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ptDal.selectALL(listMaDaiLy)
    End Function

    Public Function selectALL_ByMaDaiLy(madaili As Integer, ByRef listDL As List(Of PhieuThuTienDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ptDal.selectALL_ByMaDaiLy(madaili, listDL)
    End Function
    Public Function selectNoCuaDaiLy_ByMaDaiLy(madaili As Integer, ByRef NoCuaDaiLy As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ptDal.selectNoDaiLy_ByMaDaiLy(madaili, NoCuaDaiLy)
    End Function

    Public Function delete(px As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ptDal.delete(px)
    End Function
    Public Function update(px As PhieuThuTienDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ptDal.update(px)
    End Function

End Class
