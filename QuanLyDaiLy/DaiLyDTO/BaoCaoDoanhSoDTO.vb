Public Class BaoCaoDoanhSoDTO
    Private iStt As Integer
    Private iMaPhieuDoanhSo As Integer
    Private iMaDaiLy As Integer
    Private dateThang As DateTime
    Private iSoPhieuXuat As Integer
    Private iTongTriGia As Integer
    Private dTyLe As Double

    Private strTenDaiLy As String


    Public Sub New()
    End Sub
    Public Sub New(iMaPhieuDoanhSo As Integer, iMaDaiLy As Integer, dateThang As DateTime, iSoPhieuXuat As Integer, iTongTriGia As Integer, dTyLe As Double)
        Me.iMaPhieuDoanhSo = iMaPhieuDoanhSo
        Me.iMaDaiLy = iMaDaiLy
        Me.dateThang = dateThang
        Me.iSoPhieuXuat = iSoPhieuXuat
        Me.iTongTriGia = iTongTriGia
        Me.dTyLe = dTyLe
    End Sub
    Public Sub New(iStt As Integer, strTenDaiLy As String, iSoPhieuXuat As Integer, iTongTriGia As Integer, dTyLe As Double)
        Me.iStt = iStt
        Me.strTenDaiLy = strTenDaiLy
        Me.iSoPhieuXuat = iSoPhieuXuat
        Me.iTongTriGia = iTongTriGia
        Me.iTongTriGia = iTongTriGia
        Me.dTyLe = dTyLe
    End Sub
    Public Property MaPhieuDoanhSo As Integer
        Get
            Return iMaPhieuDoanhSo
        End Get
        Set(value As Integer)
            iMaPhieuDoanhSo = value
        End Set
    End Property

    Public Property MaDaiLy As Integer
        Get
            Return iMaDaiLy
        End Get
        Set(value As Integer)
            iMaDaiLy = value
        End Set
    End Property

    Public Property Thang As Date
        Get
            Return dateThang
        End Get
        Set(value As Date)
            dateThang = value
        End Set
    End Property

    Public Property SoPhieuXuat As Integer
        Get
            Return iSoPhieuXuat
        End Get
        Set(value As Integer)
            iSoPhieuXuat = value
        End Set
    End Property

    Public Property TongTriGia As Integer
        Get
            Return iTongTriGia
        End Get
        Set(value As Integer)
            iTongTriGia = value
        End Set
    End Property

    Public Property TyLe As Double
        Get
            Return dTyLe
        End Get
        Set(value As Double)
            dTyLe = value
        End Set
    End Property

    Public Property TenDaiLy As String
        Get
            Return strTenDaiLy
        End Get
        Set(value As String)
            strTenDaiLy = value
        End Set
    End Property

    Public Property Stt As Integer
        Get
            Return iStt
        End Get
        Set(value As Integer)
            iStt = value
        End Set
    End Property
End Class