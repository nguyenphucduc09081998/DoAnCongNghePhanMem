Imports QLDaiLyBUS
Imports QLDaiLyDAL
Imports QLDaiLyDTO
Imports Utility

Public Class ChiTietPhieuXuatBUS
    Private ctpxDal As ChiTietPhieuXuatDAL
    Public Sub New()
        ctpxDal = New ChiTietPhieuXuatDAL()
    End Sub
    Public Sub New(connectionString As String)
        ctpxDal = New ChiTietPhieuXuatDAL(connectionString)
    End Sub


    Public Function insert(ct As ChiTietPhieuXuatDTO) As Result
        '1. verify data here!!
        Return ctpxDal.insert(ct)

        'Return New Result(False )
    End Function


    Public Function buildMaChiTiet(ByRef nextMaChiTiet As Integer) As Result
        Return ctpxDal.builMaChiTiet(nextMaChiTiet)
    End Function
    Public Function selectAll(ByRef listPhieuXuat As List(Of ChiTietPhieuXuatDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctpxDal.selectALL(listPhieuXuat)
    End Function

    Public Function selectALL_ByMaLoaiDL(PhieuXuat As Integer, ByRef listpx As List(Of ChiTietPhieuXuatDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctpxDal.selectALL_ByMaLoaiDL(PhieuXuat, listpx)
    End Function


    Public Function delete(ct As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctpxDal.delete(ct)
    End Function
    Public Function update(ct As ChiTietPhieuXuatDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ctpxDal.update(ct)
    End Function

End Class
