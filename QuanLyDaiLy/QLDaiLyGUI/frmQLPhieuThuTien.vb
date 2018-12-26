Imports System.Configuration
Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility
Public Class frmQLPhieuThuTien
    Private ptBus As PhieuThuTienBUS
    Private dlBus As DaiLyBUS

    Private Sub frmQLPhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'quanBus = New QuanBUS()
        ptBus = New PhieuThuTienBUS()
        dlBus = New DaiLyBUS()

        ' Load DaiLy list
        Dim listDaiLy = New List(Of DaiLyDTO)
        Dim result As Result
        result = dlBus.selectAll(listDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbMaDLT.DataSource = New BindingSource(listDaiLy, String.Empty)
        cbMaDLT.DisplayMember = "TenDl"
        cbMaDLT.ValueMember = "MaDL"

        cbMaDLD.DataSource = New BindingSource(listDaiLy, String.Empty)
        cbMaDLD.DisplayMember = "TenDl"
        cbMaDLD.ValueMember = "MaDL"
    End Sub
    Private Sub loadListPhieuThuTien(maDL As String)
        Dim listPhieuThuTien = New List(Of PhieuThuTienDTO)
        Dim result As Result

        result = ptBus.selectALL_ByMaDaiLy(maDL, listPhieuThuTien)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu xuất thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvDanhSachPhieuThuTien.Columns.Clear()
        dgvDanhSachPhieuThuTien.DataSource = Nothing
        dgvDanhSachPhieuThuTien.AutoGenerateColumns = False
        dgvDanhSachPhieuThuTien.AllowUserToAddRows = False
        dgvDanhSachPhieuThuTien.DataSource = listPhieuThuTien

        Dim clMaPhieuThu = New DataGridViewTextBoxColumn()
        clMaPhieuThu.Name = "MaPhieuThu"
        clMaPhieuThu.HeaderText = "Mã Phiếu Thu "
        clMaPhieuThu.DataPropertyName = "MaPhieuThu"
        dgvDanhSachPhieuThuTien.Columns.Add(clMaPhieuThu)

        'Dim clLoaiHS = New DataGridView()
        'clLoaiHS.Name = "LoaiHS"
        'clLoaiHS.HeaderText = "Tên Loại"
        'clLoaiHS.DataPropertyName = "LoaiHS"
        'dgvListHS.Columns.Add(clLoaiHS)

        Dim clMaDaiLy = New DataGridViewTextBoxColumn()
        clMaDaiLy.Name = "MaDaiLy"
        clMaDaiLy.HeaderText = "Tên Đại Lý"
        clMaDaiLy.DataPropertyName = "MaDaiLy"
        dgvDanhSachPhieuThuTien.Columns.Add(clMaDaiLy)

        Dim clNgayThuTien = New DataGridViewTextBoxColumn()
        clNgayThuTien.Name = "NgayThuTien"
        clNgayThuTien.HeaderText = "Ngày Thu Tiền"
        clNgayThuTien.DataPropertyName = "NgayThuTien"
        dgvDanhSachPhieuThuTien.Columns.Add(clNgayThuTien)

        Dim clSoTienThu = New DataGridViewTextBoxColumn()
        clSoTienThu.Name = "SoTienThu"
        clSoTienThu.HeaderText = "Số Tiền Thu"
        clSoTienThu.DataPropertyName = "SoTienThu"
        dgvDanhSachPhieuThuTien.Columns.Add(clSoTienThu)
        'dgvListHS.ResumeLayout()
    End Sub

    Private Sub cbMaDLT_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles cbMaDLT.SelectedIndexChanged
        Try
            Dim madaily = Convert.ToInt32(cbMaDLT.SelectedValue)
            loadListPhieuThuTien(madaily)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvDanhSachPhieuThuTien_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachPhieuThuTien.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachPhieuThuTien.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachPhieuThuTien.RowCount) Then
            Try
                Dim pt = CType(dgvDanhSachPhieuThuTien.Rows(currentRowIndex).DataBoundItem, PhieuThuTienDTO)

                txtMaPhieuThu.Text = pt.MaPhieuThu
                cbMaDLD.SelectedIndex = cbMaDLT.SelectedIndex
                dtpNgayThuTien.Value = pt.NgayThuTien
                txtSoTienThu.Text = pt.SoTienThu

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub dgvDanhSachPhieuThuTien_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachPhieuThuTien.CellContentClick

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        '
        ptBus = New PhieuThuTienBUS()
        '
        Dim currentRowIndex As Integer = dgvDanhSachPhieuThuTien.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachPhieuThuTien.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa phiếu xuất có mã số: " + txtMaPhieuThu.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes ' + txtMaDaiLy.Text
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        'result = dlBus.delete(txtMaDaiLy.Text)
                        result = ptBus.delete((txtMaPhieuThu.Text))
                        'CInt(Int(txtMaDaiLy.Text))
                        If (result.FlagResult = True) Then
                            'Convert.ToInt32(Convert.ToDecimal(txtPrice.Text))
                            ' Re-Load LoaiHocSinh list
                            loadListPhieuThuTien(cbMaDLT.SelectedValue)

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDanhSachPhieuThuTien.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachPhieuThuTien.Rows(currentRowIndex).Selected = True
                            End If

                            MessageBox.Show("Xóa phiếu xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa phieu xuat không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Dim currentRowIndex As Integer = dgvDanhSachPhieuThuTien.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachPhieuThuTien.RowCount) Then
            Try
                Dim phiethu As PhieuThuTienDTO
                phiethu = New PhieuThuTienDTO()

                '1. Mapping data from GUI control
                phiethu.MaPhieuThu = txtMaPhieuThu.Text
                phiethu.NgayThuTien = dtpNgayThuTien.Value
                phiethu.MaDaiLy = Convert.ToInt32(cbMaDLD.SelectedValue)
                phiethu.SoTienThu = txtSoTienThu.Text
                '3. Insert to DB
                Dim result As Result
                result = ptBus.update(phiethu)
                If (result.FlagResult = True) Then
                    ' Re-Load HocSinh list
                    loadListPhieuThuTien(cbMaDLT.SelectedValue)
                    ' Hightlight the row has been updated on table
                    dgvDanhSachPhieuThuTien.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật phiếu xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật phiếu xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
End Class