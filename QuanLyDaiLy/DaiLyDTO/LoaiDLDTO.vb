Public Class LoaiDLDTO
    Private iMaLoaiDL As Integer
    Private strTenLoaiDL As String
    Private iNoToiDa As Integer
    Public Sub New()
    End Sub

    Public Sub New(iMaLoaiDL As Integer, strTenLoaiDL As String, iNoToiDa As Integer)
        Me.iMaLoaiDL = iMaLoaiDL
        Me.strTenLoaiDL = strTenLoaiDL
        Me.iNoToiDa = iNoToiDa
    End Sub

    Public Property MaLoaiDL As Integer
        Get
            Return iMaLoaiDL
        End Get
        Set(value As Integer)
            iMaLoaiDL = value
        End Set
    End Property

    Public Property TenLoaiDL As String
        Get
            Return strTenLoaiDL
        End Get
        Set(value As String)
            strTenLoaiDL = value
        End Set
    End Property

    Public Property NoToiDa As Integer
        Get
            Return iNoToiDa
        End Get
        Set(value As Integer)
            iNoToiDa = value
        End Set
    End Property
End Class
