Public Class ThamSoDTO
    Private iId As Integer
    Private iSoDaiLyToiDa As Integer
    Private iSoLoaiDaiLy As Integer
    Private iSoMatHang As Integer
    Private iSoDonViTinh As Integer

    Public Sub New()
        iId = 0
        iSoDaiLyToiDa = 0
        iSoLoaiDaiLy = 0
        iSoMatHang = 0
        iSoDonViTinh = 0
    End Sub

    Public Sub New(iId As Integer, iSoDaiLyToiDa As Integer, iSoLoaiDaiLy As Integer, iSoMatHang As Integer, iSoDonViTinh As Integer)
        Me.iId = iId
        Me.iSoDaiLyToiDa = iSoDaiLyToiDa
        Me.iSoLoaiDaiLy = iSoLoaiDaiLy
        Me.iSoMatHang = iSoMatHang
        Me.iSoDonViTinh = iSoDonViTinh
    End Sub

    Public Property Id As Integer
        Get
            Return iId
        End Get
        Set(value As Integer)
            iId = value
        End Set
    End Property

    Public Property SoDaiLyToiDa As Integer
        Get
            Return iSoDaiLyToiDa
        End Get
        Set(value As Integer)
            iSoDaiLyToiDa = value
        End Set
    End Property

    Public Property SoLoaiDaiLy As Integer
        Get
            Return iSoLoaiDaiLy
        End Get
        Set(value As Integer)
            iSoLoaiDaiLy = value
        End Set
    End Property

    Public Property SoMatHang As Integer
        Get
            Return iSoMatHang
        End Get
        Set(value As Integer)
            iSoMatHang = value
        End Set
    End Property

    Public Property SoDonViTinh As Integer
        Get
            Return iSoDonViTinh
        End Get
        Set(value As Integer)
            iSoDonViTinh = value
        End Set
    End Property




End Class
