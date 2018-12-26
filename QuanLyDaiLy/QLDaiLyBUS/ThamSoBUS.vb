Imports QLDaiLyDTO
Imports QLDaiLyDAL

Imports Utility

Public Class ThamSoBUS
    Private tsDAL As ThamSoDAL
    Public Sub New()
        tsDAL = New ThamSoDAL()
    End Sub
    Public Sub New(connectionString As String)
        tsDAL = New ThamSoDAL(connectionString)
    End Sub
    Public Function update(ts As ThamSoDTO) As Result
        Return tsDAL.update(ts)
    End Function

    Public Function selectALL(ByRef thamso As List(Of ThamSoDTO)) As Result
        Return tsDAL.selectALL(thamso)
    End Function
End Class
