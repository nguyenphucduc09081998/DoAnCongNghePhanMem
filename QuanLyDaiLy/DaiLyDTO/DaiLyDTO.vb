Public Class DaiLyDTO
    Private iMaDL As Integer
    Private strTenDL As String
    Private strDiaChi As String
    Private strEmail As String
    Private strDienThoai As String
    Private dateNgTiepNhan As DateTime
    Private iNoCuaDaiLy As Integer
    Private iMaQuan As Integer
    Private iMaLoaiDL As Integer

    Public Sub New()
    End Sub

    Public Sub New(iMaDL As Integer, strTenDL As String, strDiaChi As String, strEmail As String, strDienThoai As String, dateNgTiepNhan As Date, iNoCuaDaiLy As Integer, iMaQuan As Integer, iMaLoaiDL As Integer)
        Me.iMaDL = iMaDL
        Me.strTenDL = strTenDL
        Me.strDiaChi = strDiaChi
        Me.strEmail = strEmail
        Me.strDienThoai = strDienThoai
        Me.dateNgTiepNhan = dateNgTiepNhan
        Me.iNoCuaDaiLy = iNoCuaDaiLy
        Me.iMaQuan = iMaQuan
        Me.iMaLoaiDL = iMaLoaiDL
    End Sub

    Public Property MaDL As Integer
        Get
            Return iMaDL
        End Get
        Set(value As Integer)
            iMaDL = value
        End Set
    End Property

    Public Property TenDL As String
        Get
            Return strTenDL
        End Get
        Set(value As String)
            strTenDL = value
        End Set
    End Property

    Public Property DienThoai As String
        Get
            Return strDienThoai
        End Get
        Set(value As String)
            strDienThoai = value
        End Set
    End Property

    Public Property MaQuan As Integer
        Get
            Return iMaQuan
        End Get
        Set(value As Integer)
            iMaQuan = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return strEmail
        End Get
        Set(value As String)
            strEmail = value
        End Set
    End Property

    Public Property MaLoaiDL As Integer
        Get
            Return iMaLoaiDL
        End Get
        Set(value As Integer)
            iMaLoaiDL = value
        End Set
    End Property

    Public Property DiaChi As String
        Get
            Return strDiaChi
        End Get
        Set(value As String)
            strDiaChi = value
        End Set
    End Property

    Public Property NgTiepNhan As Date
        Get
            Return dateNgTiepNhan
        End Get
        Set(value As Date)
            dateNgTiepNhan = value
        End Set
    End Property

    Public Property NoCuaDaiLy As Integer
        Get
            Return iNoCuaDaiLy
        End Get
        Set(value As Integer)
            iNoCuaDaiLy = value
        End Set
    End Property
End Class
