Imports QLDaiLyBUS
Imports QLDaiLyDAL
Imports QLDaiLyDTO
Imports Utility

Public Class DaiLyBUS
    Private dlDAL As DaiLyDAL
    Public Sub New()
        dlDAL = New DaiLyDAL()
    End Sub
    Public Sub New(connectionString As String)
        dlDAL = New DaiLyDAL(connectionString)
    End Sub


    Public Function insert(dl As DaiLyDTO) As Result
        '1. verify data here!!
        Return dlDAL.insert(dl)

        'Return New Result(False )
    End Function

    Public Function isValidName(dl As DaiLyDTO) As Boolean

        If (dl.TenDL.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function buildMaDL(ByRef nextMaDL As Integer) As Result
        Return dlDAL.buildMaDL(nextMaDL)
    End Function
    Public Function selectAll(ByRef listLoaiDL As List(Of DaiLyDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.selectALL(listLoaiDL)
    End Function

    Public Function selectALL_ByMaLoaiDL(iMaLoaiDL As Integer, ByRef listDL As List(Of DaiLyDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.selectALL_ByMaLoaiDL(iMaLoaiDL, listDL)
    End Function


    Public Function delete(dl As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.delete(dl)
    End Function
    Public Function update(dl As DaiLyDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.update(dl)
    End Function



    Public Function selectAll_Search(ten As String, ByRef listLoaiDL As List(Of DaiLyDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.selectALL_Search(ten, listLoaiDL)
    End Function




    'tra cuu       '''''''''''''''''


    Public Function selectmaquan_ByMaDaiLy(madaili As Integer, ByRef maquan As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.selectmaquan_ByMaDaiLy(madaili, maquan)
    End Function


    Public Function search_ten_quan(ten As String, maquan As Integer, ByRef listLoaiDL As List(Of DaiLyDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.selectALL_ten_quan(ten, maquan, listLoaiDL)
    End Function

    Public Function search_ten_loaidl(ten As String, loaidl As Integer, ByRef listLoaiDL As List(Of DaiLyDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.selectALL_ten_loaidl(ten, loaidl, listLoaiDL)
    End Function

    Public Function search_maquan(maquan As Integer, ByRef listDaiLy As List(Of DaiLyDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.search_maquan(maquan, listDaiLy)
    End Function

    Public Function search_ten_loaidl_quan(ten As String, loaidl As Integer, quan As Integer, ByRef listLoaiDL As List(Of DaiLyDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.selectALL_ten_loaidl_quan(ten, loaidl, quan, listLoaiDL)
    End Function


    Public Function search_maloaidl_maquan(maloaidl As Integer, maquan As Integer, ByRef listDaiLy As List(Of DaiLyDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.search_maloaidl_maquan(maloaidl, maquan, listDaiLy)
    End Function

    Public Function search_loaimadl(loaimadl As Integer, ByRef listDaiLy As List(Of DaiLyDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dlDAL.search_loaimadl(loaimadl, listDaiLy)
    End Function

End Class