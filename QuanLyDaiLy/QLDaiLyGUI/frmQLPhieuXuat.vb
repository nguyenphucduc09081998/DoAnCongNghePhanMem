Imports System.Configuration
Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility

Public Class frmQLPhieuXuat
    Private pxBus As PhieuXuatBUS
    Private dlBus As DaiLyBUS
    'Private quanBus As QuanBUS
    Private Sub frmQLPhieuXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'quanBus = New QuanBUS()
        pxBus = New PhieuXuatBUS()
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

        cbMaDL.DataSource = New BindingSource(listDaiLy, String.Empty)
        cbMaDL.DisplayMember = "TenDl"
        cbMaDL.ValueMember = "MaDL"

        cbMaDaiLy.DataSource = New BindingSource(listDaiLy, String.Empty)
        cbMaDaiLy.DisplayMember = "TenDl"
        cbMaDaiLy.ValueMember = "MaDL"
    End Sub




    Private Sub loadListPhieuXuat(maDL As String)
        Dim listPhieuXuat = New List(Of PhieuXuatDTO)
        Dim result As Result

        result = pxBus.selectALL_ByMaDaiLy(maDL, listPhieuXuat)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phiếu xuất thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvlistPhieuXuat.Columns.Clear()
        dgvlistPhieuXuat.DataSource = Nothing
        dgvlistPhieuXuat.AutoGenerateColumns = False
        dgvlistPhieuXuat.AllowUserToAddRows = False
        dgvlistPhieuXuat.DataSource = listPhieuXuat

        Dim clMaPhieuXuat = New DataGridViewTextBoxColumn()
        clMaPhieuXuat.Name = "MaPhieuXuat"
        clMaPhieuXuat.HeaderText = "Mã Phiếu Xuất"
        clMaPhieuXuat.DataPropertyName = "MaPhieuXuat"
        dgvlistPhieuXuat.Columns.Add(clMaPhieuXuat)

        'Dim clLoaiHS = New DataGridView()
        'clLoaiHS.Name = "LoaiHS"
        'clLoaiHS.HeaderText = "Tên Loại"
        'clLoaiHS.DataPropertyName = "LoaiHS"
        'dgvListHS.Columns.Add(clLoaiHS)

        Dim clMaDaiLy = New DataGridViewTextBoxColumn()
        clMaDaiLy.Name = "MaDaiLy"
        clMaDaiLy.HeaderText = "Tên Đại Lý"
        clMaDaiLy.DataPropertyName = "MaDaiLy"
        dgvlistPhieuXuat.Columns.Add(clMaDaiLy)

        Dim clNgayLapPhieu = New DataGridViewTextBoxColumn()
        clNgayLapPhieu.Name = "NgayLapPhieu"
        clNgayLapPhieu.HeaderText = "Ngày Lập Phiếu"
        clNgayLapPhieu.DataPropertyName = "NgayLapPhieu"
        dgvlistPhieuXuat.Columns.Add(clNgayLapPhieu)

        Dim clTongGiaTri = New DataGridViewTextBoxColumn()
        clTongGiaTri.Name = "TongGiaTri"
        clTongGiaTri.HeaderText = "Tổng Giá Trị"
        clTongGiaTri.DataPropertyName = "TongGiaTri"
        dgvlistPhieuXuat.Columns.Add(clTongGiaTri)
        'dgvListHS.ResumeLayout()

    End Sub
    Private Sub cbMaDL_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles cbMaDL.SelectedIndexChanged
        Try
            Dim madaily = Convert.ToInt32(cbMaDL.SelectedValue)
            loadListPhieuXuat(madaily)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvlistPhieuXuat_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvlistPhieuXuat.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvlistPhieuXuat.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvlistPhieuXuat.RowCount) Then
            Try
                Dim px = CType(dgvlistPhieuXuat.Rows(currentRowIndex).DataBoundItem, PhieuXuatDTO)

                txtMaPhieuXuat.Text = px.MaPhieuXuat
                cbMaDaiLy.SelectedIndex = cbMaDL.SelectedIndex
                dtpNgayLapPhieu.Value = px.NgayLapPhieu
                txtTongGiaTri.Text = px.TongGiaTri

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub




    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvlistPhieuXuat.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvlistPhieuXuat.RowCount) Then
            Try
                Dim phieuxuat As PhieuXuatDTO
                phieuxuat = New PhieuXuatDTO()

                '1. Mapping data from GUI control
                phieuxuat.MaPhieuXuat = txtMaPhieuXuat.Text
                phieuxuat.NgayLapPhieu = dtpNgayLapPhieu.Value
                phieuxuat.MaDaiLy = Convert.ToInt32(cbMaDaiLy.SelectedValue)
                phieuxuat.TongGiaTri = txtTongGiaTri.Text
                '3. Insert to DB
                Dim result As Result
                result = pxBus.update(phieuxuat)
                If (result.FlagResult = True) Then
                    ' Re-Load HocSinh list
                    loadListPhieuXuat(cbMaDL.SelectedValue)
                    ' Hightlight the row has been updated on table
                    dgvlistPhieuXuat.Rows(currentRowIndex).Selected = True

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

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        '
        pxBus = New PhieuXuatBUS()
        '
        Dim currentRowIndex As Integer = dgvlistPhieuXuat.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvlistPhieuXuat.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa phiếu xuất có mã số: " + txtMaPhieuXuat.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes ' + txtMaDaiLy.Text
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        'result = dlBus.delete(txtMaDaiLy.Text)
                        result = pxBus.delete((txtMaPhieuXuat.Text))
                        'CInt(Int(txtMaDaiLy.Text))
                        If (result.FlagResult = True) Then
                            'Convert.ToInt32(Convert.ToDecimal(txtPrice.Text))
                            ' Re-Load LoaiHocSinh list
                            loadListPhieuXuat(cbMaDL.SelectedValue)

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvlistPhieuXuat.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvlistPhieuXuat.Rows(currentRowIndex).Selected = True
                            End If

                            MessageBox.Show("Xóa phiếu xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa phiếu xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
End Class