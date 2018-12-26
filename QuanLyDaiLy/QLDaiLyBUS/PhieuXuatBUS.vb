Imports QLDaiLyBUS
Imports QLDaiLyDAL
Imports QLDaiLyDTO
Imports Utility

Public Class PhieuXuatBUS
    Private pxDal As PhieuXuatDAL
    Public Sub New()
        pxDal = New PhieuXuatDAL()
    End Sub
    Public Sub New(connectionString As String)
        pxDal = New PhieuXuatDAL(connectionString)
    End Sub


    Public Function insert(px As PhieuXuatDTO) As Result
        '1. verify data here!!
        Return pxDal.insert(px)

        'Return New Result(False )
    End Function


    Public Function buildMaPhieuXuat(ByRef nextMaPhieuXuat As Integer) As Result
        Return pxDal.buildMaPhieuXuat(nextMaPhieuXuat)
    End Function
    Public Function selectAll(ByRef listMaDaiLy As List(Of PhieuXuatDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pxDal.selectALL(listMaDaiLy)
    End Function

    Public Function selectALL_ByMaDaiLy(madaili As Integer, ByRef listDL As List(Of PhieuXuatDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pxDal.selectALL_ByMaDaiLy(madaili, listDL)
    End Function


    Public Function delete(px As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pxDal.delete(px)
    End Function
    Public Function update(px As PhieuXuatDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pxDal.update(px)
    End Function

    ''them
    Public Function getthang(ByRef listthang As List(Of PhieuXuatDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return pxDal.getthang(listthang)
    End Function



End Class
