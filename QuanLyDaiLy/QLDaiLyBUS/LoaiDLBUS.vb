Imports QLDaiLyDAL
Imports QLDaiLyDTO
Imports Utility

Public Class LoaiDLBUS
    Private loaidlDAL As LoaiDlDAL
    Public Sub New()
        loaidlDAL = New LoaiDlDAL()
    End Sub
    Public Sub New(connectionString As String)
        loaidlDAL = New LoaiDlDAL(connectionString)
    End Sub
    Public Function builMaLoaiDL(ByRef nextMaLoaiDL As Integer) As Result
        Return loaidlDAL.builMaLoaiDL(nextMaLoaiDL)
    End Function
    Public Function insert(loaidl As LoaiDLDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return loaidlDAL.insert(loaidl)
    End Function
    Public Function selectAll(ByRef listdl As List(Of LoaiDLDTO)) As Result

        Return loaidlDAL.selectALL(listdl)
    End Function
    Public Function delete(loaidl As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return loaidlDAL.delete(loaidl)
    End Function
    Public Function Update(loaidl As LoaiDLDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return loaidlDAL.update(loaidl)
    End Function
    Public Function countsoluongloaidaily(ByRef soluong As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return loaidlDAL.countsoluongloaidaily(soluong)
    End Function
    Public Function selectSoloaidaily_thamso(ByRef soloaidaily As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return loaidlDAL.selectSoloaidaily_thamso(soloaidaily)
    End Function

End Class

