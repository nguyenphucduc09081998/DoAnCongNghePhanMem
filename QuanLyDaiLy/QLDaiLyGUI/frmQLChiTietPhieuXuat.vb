Imports System.Configuration
Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility


Public Class frmQLChiTietPhieuXuat
    Private ctphieuxuatBus As ChiTietPhieuXuatBUS
    Private pxuatBus As PhieuXuatBUS
    Private mathangBus As MatHangBUS
    Private donvitinhBus As DonViTinhBUS
    'Private quanBus As QuanBUS
    Private Sub frmQLChiTietPhieuXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'quanBus = New QuanBUS()
        ctphieuxuatBus = New ChiTietPhieuXuatBUS()
        pxuatBus = New PhieuXuatBUS()
        mathangBus = New MatHangBUS()
        donvitinhBus = New DonViTinhBUS()

        ' Load phieu xuat list
        Dim listPhieuXuat = New List(Of PhieuXuatDTO)
        Dim result As Result
        result = pxuatBus.selectAll(listPhieuXuat)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbMaPhieuXuatT.DataSource = New BindingSource(listPhieuXuat, String.Empty)
        cbMaPhieuXuatT.DisplayMember = "TenPhieuXuat"
        cbMaPhieuXuatT.ValueMember = "MaPhieuXuat"

        cbMaPhieuXuatD.DataSource = New BindingSource(listPhieuXuat, String.Empty)
        cbMaPhieuXuatD.DisplayMember = "TenPhieuXuat"
        cbMaPhieuXuatD.ValueMember = "MaPhieuXuat"

        'load  mat hagn
        Dim resultMatHang As Result
        Dim listMatHang = New List(Of MatHangDTO)
        resultMatHang = mathangBus.selectAll(listMatHang)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách mặt hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(resultMatHang.SystemMessage)
            Return
        End If




        cbMaMatHang.DataSource = New BindingSource(listMatHang, String.Empty)
        cbMaMatHang.DisplayMember = "TenMatHang"
        cbMaMatHang.ValueMember = "MaMatHang"

        'load Quan list
        Dim resultDonViTinh As Result
        Dim listDonViTinh = New List(Of DonViTinhDTO)
        resultDonViTinh = donvitinhBus.selectAll(listDonViTinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh don vi tinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(resultDonViTinh.SystemMessage)
            Return
        End If



        cbMaDonViTinh.DataSource = New BindingSource(listDonViTinh, String.Empty)
        cbMaDonViTinh.DisplayMember = "TenDonViTinh"
        cbMaDonViTinh.ValueMember = "MaDonViTinh"


        'cbmMaQuan.DataSource = New BindingSource(listQuan, String.Empty)
        'cbmMaQuan.DisplayMember = "TenQuan"
        'cbmMaQuan.ValueMember = "MaQuan"
    End Sub


    Private Sub loadListctphieuxuat(maphieuxuat As String)
        Dim listPhieuXuat = New List(Of ChiTietPhieuXuatDTO)
        Dim result As Result

        result = ctphieuxuatBus.selectALL_ByMaLoaiDL(maphieuxuat, listPhieuXuat)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách chi teit phieu xuat thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvdanhsachchitietpx.Columns.Clear()
        dgvdanhsachchitietpx.DataSource = Nothing

        dgvdanhsachchitietpx.AutoGenerateColumns = False
        dgvdanhsachchitietpx.AllowUserToAddRows = False
        dgvdanhsachchitietpx.DataSource = listPhieuXuat
        '' them colume
        Dim clMaChiTietPhieu = New DataGridViewTextBoxColumn()
        clMaChiTietPhieu.Name = "MaChiTietPhieu"
        clMaChiTietPhieu.HeaderText = "Mã Chi Tiết Phiếu Xuất"
        clMaChiTietPhieu.DataPropertyName = "MaChiTietPhieu"
        dgvdanhsachchitietpx.Columns.Add(clMaChiTietPhieu)



        Dim clMaPhieuXuat = New DataGridViewTextBoxColumn()
        clMaPhieuXuat.Name = "MaPhieuXuat"
        clMaPhieuXuat.HeaderText = "Mã Phiếu Xuất"
        clMaPhieuXuat.DataPropertyName = "MaPhieuXuat"
        dgvdanhsachchitietpx.Columns.Add(clMaPhieuXuat)

        Dim clMaMatHang = New DataGridViewTextBoxColumn()
        clMaMatHang.Name = "MaMatHang"
        clMaMatHang.HeaderText = "Mã Mặt Hàng"
        clMaMatHang.DataPropertyName = "MaMatHang"
        dgvdanhsachchitietpx.Columns.Add(clMaMatHang)

        Dim clMaDonViTinh = New DataGridViewTextBoxColumn()
        clMaDonViTinh.Name = "MaDonViTinh"
        clMaDonViTinh.HeaderText = "Mã Đợn Vị Tính"
        clMaDonViTinh.DataPropertyName = "MaDonViTinh"
        dgvdanhsachchitietpx.Columns.Add(clMaDonViTinh)
        'dgvListHS.ResumeLayout()


        Dim clSoLuongXuat = New DataGridViewTextBoxColumn()
        clSoLuongXuat.Name = "SoLuongXuat"
        clSoLuongXuat.HeaderText = "Số Lượng Xuất"
        clSoLuongXuat.DataPropertyName = "SoLuongXuat"
        dgvdanhsachchitietpx.Columns.Add(clSoLuongXuat)
        'dgvListHS.ResumeLayout()

        Dim clDonGia = New DataGridViewTextBoxColumn()
        clDonGia.Name = "DonGia"
        clDonGia.HeaderText = "Đơn Giá"
        clDonGia.DataPropertyName = "DonGia"
        dgvdanhsachchitietpx.Columns.Add(clDonGia)

        Dim clThanhTien = New DataGridViewTextBoxColumn()
        clThanhTien.Name = "ThanhTien"
        clThanhTien.HeaderText = "Thành Tiền"
        clThanhTien.DataPropertyName = "ThanhTien"
        dgvdanhsachchitietpx.Columns.Add(clThanhTien)



        '
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        '
        ctphieuxuatBus = New ChiTietPhieuXuatBUS()
        '
        Dim currentRowIndex As Integer = dgvdanhsachchitietpx.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvdanhsachchitietpx.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa dl có mã số: " + txtMaChiTietPhieu.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes ' + txtMaDaiLy.Text
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        'result = dlBus.delete(txtMaDaiLy.Text)
                        result = ctphieuxuatBus.delete((txtMaChiTietPhieu.Text))
                        'CInt(Int(txtMaDaiLy.Text))
                        If (result.FlagResult = True) Then
                            'Convert.ToInt32(Convert.ToDecimal(txtPrice.Text))
                            ' Re-Load LoaiHocSinh list
                            loadListctphieuxuat(cbMaPhieuXuatT.SelectedValue)

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvdanhsachchitietpx.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvdanhsachchitietpx.Rows(currentRowIndex).Selected = True
                            End If

                            MessageBox.Show("Xóa chi tiết phiếu xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa chi tiet phieu xuat không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select


        End If
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvdanhsachchitietpx.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvdanhsachchitietpx.RowCount) Then
            Try
                Dim ctphieuxuat As ChiTietPhieuXuatDTO
                ctphieuxuat = New ChiTietPhieuXuatDTO()

                '1. Mapping data from GUI control
                ctphieuxuat.MaChiTietPhieu = txtMaChiTietPhieu.Text
                ctphieuxuat.MaPhieuXuat = Convert.ToInt32(cbMaPhieuXuatD.SelectedValue)
                ctphieuxuat.MaMatHang = Convert.ToInt32(cbMaMatHang.SelectedValue)
                ctphieuxuat.MaDonViTinh = Convert.ToInt32(cbMaDonViTinh.SelectedValue)

                ctphieuxuat.SoLuongXuat = txtSoLuongXuat.Text
                ctphieuxuat.DonGia = txtDonGia.Text
                ctphieuxuat.ThanhTien = txtThanhTien.Text

                Dim result As Result
                result = ctphieuxuatBus.update(ctphieuxuat)
                If (result.FlagResult = True) Then
                    ' Re-Load HocSinh list
                    loadListctphieuxuat(cbMaPhieuXuatT.SelectedValue)
                    ' Hightlight the row has been updated on table
                    dgvdanhsachchitietpx.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật chi tiết phiếu xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật chi tiết phiếu xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub cbmLoaiDaiLy_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles cbMaPhieuXuatT.SelectedIndexChanged
        Try
            Dim maLoai = Convert.ToInt32(cbMaPhieuXuatT.SelectedValue)
            loadListctphieuxuat(maLoai)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvdanhsachchitietpx_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvdanhsachchitietpx.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvdanhsachchitietpx.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvdanhsachchitietpx.RowCount) Then
            Try
                Dim dl = CType(dgvdanhsachchitietpx.Rows(currentRowIndex).DataBoundItem, ChiTietPhieuXuatDTO)

                txtMaChiTietPhieu.Text = dl.MaChiTietPhieu
                cbMaPhieuXuatD.SelectedIndex = cbMaPhieuXuatT.SelectedIndex
                cbMaMatHang.SelectedValue = dl.MaMatHang
                cbMaDonViTinh.SelectedValue = dl.MaDonViTinh
                txtSoLuongXuat.Text = dl.SoLuongXuat
                txtDonGia.Text = dl.DonGia
                txtThanhTien.Text = dl.ThanhTien


            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
End Class