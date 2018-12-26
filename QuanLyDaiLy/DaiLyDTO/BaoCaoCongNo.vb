Public Class BaoCaoCongNo
    Private iMaBaoCaoCongNo As Integer
    Private iMaDaiLy As Integer
    Private iNoDau As Integer
    Private iNoCuoi As Integer
    Private iPhatSinh As Integer



    Public Sub New()

    End Sub

    Public Sub New(iMaBaoCaoCongNo As Integer, iMaDaiLy As Integer, iNoDau As Integer, iNoCuoi As Integer, iPhatSinh As Integer)
        Me.iMaBaoCaoCongNo = iMaBaoCaoCongNo
        Me.iMaDaiLy = iMaDaiLy
        Me.iNoDau = iNoDau
        Me.iNoCuoi = iNoCuoi
        Me.iPhatSinh = iPhatSinh
    End Sub
    Public Property MaBaoCaoCongNo As Integer
        Get
            Return iMaBaoCaoCongNo
        End Get
        Set(value As Integer)
            iMaBaoCaoCongNo = value
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

    Public Property NoDau As Integer
        Get
            Return iNoDau
        End Get
        Set(value As Integer)
            iNoDau = value
        End Set
    End Property

    Public Property NoCuoi As Integer
        Get
            Return iNoCuoi
        End Get
        Set(value As Integer)
            iNoCuoi = value
        End Set
    End Property

    Public Property PhatSinh As Integer
        Get
            Return iPhatSinh
        End Get
        Set(value As Integer)
            iPhatSinh = value
        End Set
    End Property
End Class
