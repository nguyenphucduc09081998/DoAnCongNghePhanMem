Public Class PhieuXuatDTO
    Private iMaPhieuXuat As Integer
    Private iMaDaiLy As Integer
    Private dateNgayLapPhieu As DateTime
    Private iTongGiaTri As Integer
    Private iThang As Integer



    Public Sub New()
    End Sub

    ''
    Public Sub New(iThang As Integer)
        Me.iThang = iThang
    End Sub
    ''
    Public Sub New(iMaPhieuXuat As Integer, iMaDaiLy As Integer, dateNgayLapPhieu As DateTime, iTongGiaTri As Integer)
        Me.iMaPhieuXuat = iMaPhieuXuat
        Me.iMaDaiLy = iMaDaiLy
        Me.dateNgayLapPhieu = dateNgayLapPhieu
        Me.iTongGiaTri = iTongGiaTri
    End Sub


    Public Property MaPhieuXuat As Integer
        Get
            Return iMaPhieuXuat
        End Get
        Set(value As Integer)
            iMaPhieuXuat = value
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

    Public Property NgayLapPhieu As Date
        Get
            Return dateNgayLapPhieu
        End Get
        Set(value As Date)
            dateNgayLapPhieu = value
        End Set
    End Property

    Public Property TongGiaTri As Integer
        Get
            Return iTongGiaTri
        End Get
        Set(value As Integer)
            iTongGiaTri = value
        End Set
    End Property

    Public Property Thang As Integer
        Get
            Return iThang
        End Get
        Set(value As Integer)
            iThang = value
        End Set
    End Property
End Class
