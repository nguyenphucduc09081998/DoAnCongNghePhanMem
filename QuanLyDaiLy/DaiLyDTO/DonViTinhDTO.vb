Public Class DonViTinhDTO
    Private iMaDonViTinh As Integer
    Private strTenDonViTinh As String
    Public Sub New()

    End Sub

    Public Sub New(iMaDonViTinh As Integer, strTenDonViTinh As String)
        Me.iMaDonViTinh = iMaDonViTinh
        Me.strTenDonViTinh = strTenDonViTinh
    End Sub

    Public Property MaDonViTinh As Integer
        Get
            Return iMaDonViTinh
        End Get
        Set(value As Integer)
            iMaDonViTinh = value
        End Set
    End Property

    Public Property TenDonViTinh As String
        Get
            Return strTenDonViTinh
        End Get
        Set(value As String)
            strTenDonViTinh = value
        End Set
    End Property
End Class
