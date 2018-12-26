Public Class PhieuThuTienDTO
    Private iMaPhieuThu As Integer
    Private iMaDaiLy As Integer
    Private dateNgayThuTien As DateTime
    Private iSoTienThu As Integer



    Public Sub New()

    End Sub

    Public Sub New(iMaPhieuThu As Integer, iMaDaiLy As Integer, dateNgayThuTien As Date, iSoTienThu As Integer)
        Me.iMaPhieuThu = iMaPhieuThu
        Me.iMaDaiLy = iMaDaiLy
        Me.dateNgayThuTien = dateNgayThuTien
        Me.iSoTienThu = iSoTienThu
    End Sub
    Public Property MaPhieuThu As Integer
        Get
            Return iMaPhieuThu
        End Get
        Set(value As Integer)
            iMaPhieuThu = value
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

    Public Property NgayThuTien As Date
        Get
            Return dateNgayThuTien
        End Get
        Set(value As Date)
            dateNgayThuTien = value
        End Set
    End Property

    Public Property SoTienThu As Integer
        Get
            Return iSoTienThu
        End Get
        Set(value As Integer)
            iSoTienThu = value
        End Set
    End Property
End Class
