Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility


Public Class frmThemChiTietPhieuXuat
    Private ctPhieuXuatBus As ChiTietPhieuXuatBUS
    Private phieuxuat As PhieuXuatBUS
    Private mathang As MatHangBUS
    Private donvitinh As DonViTinhBUS
    Dim sotien As Integer

    Private Sub frmThemChiTietPhieuXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctPhieuXuatBus = New ChiTietPhieuXuatBUS()
        phieuxuat = New PhieuXuatBUS()
        mathang = New MatHangBUS()
        donvitinh = New DonViTinhBUS()
        'lay ma dai ly
        Dim resultPhieuXuat As Result
        Dim resultDonViTinh As Result
        Dim resultMatHang As Result
        Dim nextMaChiTiet As Integer


        resultPhieuXuat = ctPhieuXuatBus.buildMaChiTiet(nextMaChiTiet)
        If (resultPhieuXuat.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(resultPhieuXuat.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaChiTietPhieuXuat.Text = nextMaChiTiet

        'load combobox Phieu Xuat

        Dim listPhieuXuat = New List(Of PhieuXuatDTO)
        resultPhieuXuat = phieuxuat.selectAll(listPhieuXuat)
        If (resultPhieuXuat.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(resultPhieuXuat.SystemMessage)
            Return
        End If

        cbMaPhieuXuat.DataSource = New BindingSource(listPhieuXuat, String.Empty)
        cbMaPhieuXuat.DisplayMember = "TenPhieuXuat"
        'cbxMaLoaiDL.ValueMember = "NoDaiLy"
        cbMaPhieuXuat.ValueMember = "MaPhieuXuat"


        'load combobox mat hang
        Dim listMatHang = New List(Of MatHangDTO)
        resultMatHang = mathang.selectAll(listMatHang)
        If (resultMatHang.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách mặt hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(resultMatHang.SystemMessage)
            Return
        End If

        cbMaMatHang.DataSource = New BindingSource(listMatHang, String.Empty)
        cbMaMatHang.DisplayMember = "TenMatHang"
        cbMaMatHang.ValueMember = "MaMatHang"
        'load combobox don vi tinh
        Dim listDonViTinh = New List(Of DonViTinhDTO)
        resultDonViTinh = donvitinh.selectAll(listDonViTinh)
        If (resultDonViTinh.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách đơn vị tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(resultDonViTinh.SystemMessage)
            Return
        End If

        cbMaDonViTinh.DataSource = New BindingSource(listDonViTinh, String.Empty)
        cbMaDonViTinh.DisplayMember = "TenDonViTinh"
        cbMaDonViTinh.ValueMember = "MaDonViTinh"


    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim chitietpx As ChiTietPhieuXuatDTO
        chitietpx = New ChiTietPhieuXuatDTO()

        '1. Mapping data from GUI control
        'hocsinh.MSHS = txtMaSo.Text
        ' Dim a As Integer

        chitietpx.MaPhieuXuat = Convert.ToInt32(cbMaPhieuXuat.SelectedValue)
        chitietpx.MaMatHang = Convert.ToInt32(cbMaMatHang.SelectedValue)
        chitietpx.MaDonViTinh = Convert.ToInt32(cbMaDonViTinh.SelectedValue)
        chitietpx.SoLuongXuat = txtSoLuongXuat.Text
        ' a =
        chitietpx.DonGia = txtDonGia.Text

        sotien = chitietpx.SoLuongXuat * chitietpx.DonGia
        txtThanhTien.Text = sotien
        chitietpx.ThanhTien = sotien
        Me.Refresh()
        ' chitietpx.ThanhTien = txtThanhTien.Text
        'sotien = chitietpx.ThanhTien
        'me.Re
        ' Me.Controls .C
        '     chitietpx.ThanhTien
        'daily.NoCuaDaiLy = Convert.ToInt32(txtNoCuaDaiLy)
        'hocsinh.LoaiHS = Convert.ToInt32(cbLoaiHS.SELECTedValue)

        '2. Business .....


        '3. Insert to DB
        Dim result As Result
        result = ctPhieuXuatBus.insert(chitietpx)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm chi tiết phiếu xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMaChiTiet = "1"
            result = ctPhieuXuatBus.buildMaChiTiet(nextMaChiTiet)


        Else
            MessageBox.Show("Thêm chi tiết phiếu xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub txtThanhTien_Click(sender As Object, e As EventArgs) Handles txtThanhTien.Click
        '  txtThanhTien.Text = sotien
    End Sub

    Private Sub txtThanhTien_LocationChanged(sender As Object, e As EventArgs) Handles txtThanhTien.LocationChanged
        '  txtThanhTien.Text = sotien
    End Sub

    Private Sub txtDonGia_TextChanged(sender As Object, e As EventArgs) Handles txtDonGia.TextChanged
        '  sotien = chitietpx.SoLuongXuat * chitietpx.DonGia
        ' txtThanhTien.Text = sotien
        ' '  chitietpx.ThanhTien = sotien
        'Me.Refresh()
    End Sub

    Private Sub txtMaChiTietPhieuXuat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaChiTietPhieuXuat.KeyPress, txtSoLuongXuat.KeyPress, txtDonGia.KeyPress, cbMaPhieuXuat.KeyPress, cbMaMatHang.KeyPress, cbMaDonViTinh.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class