Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility

Public Class frmPhieuXuat
    Private pxBus As PhieuXuatBUS
    Private DaiLyBus As DaiLyBUS
    'Private QuanBus As QuanBUS
    Private Sub frmPhieuXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pxBus = New PhieuXuatBUS()
        DaiLyBus = New DaiLyBUS()
        'QuanBUS = New QuanBUS()
        Dim result As Result
        Dim resultDaiLy As Result
        Dim nextMaPhieuXuat As Integer


        result = pxBus.buildMaPhieuXuat(nextMaPhieuXuat)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã phieu xuat không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaPhieuXuat.Text = nextMaPhieuXuat

        'load combobox LoaiDL

        Dim listDaiLy = New List(Of DaiLyDTO)
        result = DaiLyBus.selectAll(listDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách đại lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbMaDL.DataSource = New BindingSource(listDaiLy, String.Empty)
        cbMaDL.DisplayMember = "TenDl"
        'cbxMaLoaiDL.ValueMember = "NoDaiLy"
        cbMaDL.ValueMember = "MaDL"


        'load combobox ma quan
        'Dim listQuan = New List(Of QuanDTO)
        'resultDaiLy = QuanBUS.selectAll(listQuan)
        'If (resultQuan.FlagResult = False) Then
        '    MessageBox.Show("Lấy danh loại Quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Return
        'End If

        'cbxMaQuan.DataSource = New BindingSource(listQuan, String.Empty)
        'cbxMaQuan.DisplayMember = "TenQuan"
        'cbxMaQuan.ValueMember = "MaQuan"
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim phieuxuat As PhieuXuatDTO
        phieuxuat = New PhieuXuatDTO()

        '1. Mapping data from GUI control
        'hocsinh.MSHS = txtMaSo.Text
        phieuxuat.MaDaiLy = Convert.ToInt32(cbMaDL.SelectedValue)
        phieuxuat.NgayLapPhieu = dtpNgayLapPhieu.Value

        phieuxuat.TongGiaTri = txtTongGiaTri.Text

        '2. Business .....


        '3. Insert to DB
        Dim result As Result
        result = pxBus.insert(phieuxuat)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm phieu xuat thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMaPhieuXuat = "1"
            result = pxBus.buildMaPhieuXuat(nextMaPhieuXuat)
            'If (result.FlagResult = True) Then
            '    MessageBox.Show("Lấy danh tự động mã Mã Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Me.Close()
            '    Return
            'End If




            'txtTenDL.Text = String.Empty
            'txtDiaChi.Text = String.Empty
            'txtEmail.Text = String.Empty
            'txtDienThoai.Text = String.Empty

        Else
            MessageBox.Show("Thêm phiếu xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class