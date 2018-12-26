Imports System.Configuration
Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility



Public Class frmQLDaiLy
    Private dlBus As DaiLyBUS
    Private ldlBus As LoaiDLBUS
    Private quanBus As QuanBUS

    Private Sub frmQLDaiLy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        quanBus = New QuanBUS()
        dlBus = New DaiLyBUS()
        ldlBus = New LoaiDLBUS()

        ' Load LoaiDaiLy list
        Dim listLoaiDaiLy = New List(Of LoaiDLDTO)
        Dim result As Result
        result = ldlBus.selectAll(listLoaiDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbmLoaiDaiLy.DataSource = New BindingSource(listLoaiDaiLy, String.Empty)
        cbmLoaiDaiLy.DisplayMember = "TenLoaiDl"
        cbmLoaiDaiLy.ValueMember = "MaLoaiDL"

        cbmMaLoaiDL.DataSource = New BindingSource(listLoaiDaiLy, String.Empty)
        cbmMaLoaiDL.DisplayMember = "TenLoaiDl"
        cbmMaLoaiDL.ValueMember = "MaLoaiDL"

        'load Quan list
        Dim resultQuan As Result
        Dim listQuan = New List(Of QuanDTO)
        resultQuan = quanBus.selectAll(listQuan)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh loại Quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If



        'cbmMaQuanTren.DataSource = New BindingSource(listQuan, String.Empty)
        'cbmMaQuanTren.DisplayMember = "TenQuan"
        'cbmMaQuanTren.ValueMember = "MaQuan"


        cbmMaQuan.DataSource = New BindingSource(listQuan, String.Empty)
        cbmMaQuan.DisplayMember = "TenQuan"
        cbmMaQuan.ValueMember = "MaQuan"
    End Sub
    Private Sub loadListDaiLy()
        Dim listDaiLy = New List(Of DaiLyDTO)
        Dim result As Result
        result = dlBus.selectAll(listDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại đai lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvListDL.Columns.Clear()
        dgvListDL.DataSource = Nothing

        dgvListDL.AutoGenerateColumns = False
        dgvListDL.AllowUserToAddRows = False
        dgvListDL.DataSource = listDaiLy

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaDL"
        clMa.HeaderText = "Mã Đại Lý"
        clMa.DataPropertyName = "MaDL"
        dgvListDL.Columns.Add(clMa)

        ' Dim clLoaiDL = New DataGridView()
        'clLoaiHS.Name = "LoaiHS"
        'clLoaiHS.HeaderText = "Tên Loại"
        'clLoaiHS.DataPropertyName = "LoaiHS"
        'dgvListHS.Columns.Add(clLoaiHS)

        Dim clTenDL = New DataGridViewTextBoxColumn()
        clTenDL.Name = "TenDL"
        clTenDL.HeaderText = "Tên Đại Lý"
        clTenDL.DataPropertyName = "TenDL"
        dgvListDL.Columns.Add(clTenDL)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvListDL.Columns.Add(clDiaChi)




        Dim clNgTiepNhan = New DataGridViewTextBoxColumn()
        clNgTiepNhan.Name = "NgTiepNhan"
        clNgTiepNhan.HeaderText = "Ngày Tiếp Nhận"
        clNgTiepNhan.DataPropertyName = "NgTiepNhan"
        dgvListDL.Columns.Add(clNgTiepNhan)
        'dgvListHS.ResumeLayout()
    End Sub
    'sdfa
    Private Sub loadListDaiLy(maLoai As String)
        Dim listDaiLy = New List(Of DaiLyDTO)
        Dim result As Result

        result = dlBus.selectALL_ByMaLoaiDL(maLoai, listDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách đai lý thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvListDL.Columns.Clear()
        dgvListDL.DataSource = Nothing

        dgvListDL.AutoGenerateColumns = False
        dgvListDL.AllowUserToAddRows = False
        dgvListDL.DataSource = listDaiLy

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaDL"
        clMa.HeaderText = "Mã Đại Lý"
        clMa.DataPropertyName = "MaDL"
        dgvListDL.Columns.Add(clMa)

        Dim clLoaiHS = New DataGridView()
        'clLoaiHS.Name = "LoaiHS"
        'clLoaiHS.HeaderText = "Tên Loại"
        'clLoaiHS.DataPropertyName = "LoaiHS"
        'dgvListHS.Columns.Add(clLoaiHS)

        Dim clTenDL = New DataGridViewTextBoxColumn()
        clTenDL.Name = "TenDL"
        clTenDL.HeaderText = "Tên Đại Lý"
        clTenDL.DataPropertyName = "TenDL"
        dgvListDL.Columns.Add(clTenDL)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvListDL.Columns.Add(clDiaChi)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        dgvListDL.Columns.Add(clEmail)
        'dgvListHS.ResumeLayout()


        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "DienThoai"
        clDienThoai.HeaderText = "Điện Thoại"
        clDienThoai.DataPropertyName = "DienThoai"
        dgvListDL.Columns.Add(clDienThoai)
        'dgvListHS.ResumeLayout()

        Dim clNgTiepNhan = New DataGridViewTextBoxColumn()
        clNgTiepNhan.Name = "NgTiepNhan"
        clNgTiepNhan.HeaderText = "Ngày Tiếp Nhận"
        clNgTiepNhan.DataPropertyName = "NgTiepNhan"
        dgvListDL.Columns.Add(clNgTiepNhan)

        Dim clNoCuaDaiLy = New DataGridViewTextBoxColumn()
        clNoCuaDaiLy.Name = "NoCuaDaiLy"
        clNoCuaDaiLy.HeaderText = "Nợ Của Đại Lý"
        clNoCuaDaiLy.DataPropertyName = "NoCuaDaiLy"
        dgvListDL.Columns.Add(clNoCuaDaiLy)



        'test
        Dim clMaQuan = New DataGridViewTextBoxColumn()
        clMaQuan.Name = "MaQuan"
        clMaQuan.HeaderText = "Ma Quan"
        clMaQuan.DataPropertyName = "MaQuan"
        dgvListDL.Columns.Add(clMaQuan)
        'test
        Dim clMaLoaiDL = New DataGridViewTextBoxColumn()
        clMaLoaiDL.Name = "MaLoaiDL"
        clMaLoaiDL.HeaderText = "Ma Loai Dai Ly"
        clMaLoaiDL.DataPropertyName = "MaLoaiDL"
        dgvListDL.Columns.Add(clMaLoaiDL)
        '
    End Sub


    Private Sub cbmLoaiDaiLy_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles cbmLoaiDaiLy.SelectedIndexChanged
        Try
            Dim maLoai = Convert.ToInt32(cbmLoaiDaiLy.SelectedValue)
            loadListDaiLy(maLoai)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvListDL_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvListDL.SelectionChanged

        Dim currentRowIndex As Integer = dgvListDL.CurrentCellAddress.Y 'current row selected

        If (-1 < currentRowIndex And currentRowIndex < dgvListDL.RowCount) Then
            Try
                Dim dl = CType(dgvListDL.Rows(currentRowIndex).DataBoundItem, DaiLyDTO)

                txtMaDaiLy.Text = dl.MaDL
                txtTenDaiLy.Text = dl.TenDL
                txtEmail.Text = dl.Email
                txtDiaChi.Text = dl.DiaChi
                dtpNgTiepNhan.Value = dl.NgTiepNhan
                txtDienThoai.Text = dl.DienThoai
                txtNoDaiLy.Text = dl.NoCuaDaiLy
                cbmMaQuan.SelectedValue = dl.MaQuan
                cbmMaLoaiDL.SelectedIndex = cbmLoaiDaiLy.SelectedIndex
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        '
        dlBus = New DaiLyBUS()
        '
        Dim currentRowIndex As Integer = dgvListDL.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListDL.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa dl có mã số: " + txtMaDaiLy.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes ' + txtMaDaiLy.Text
                    Try
                        '1. Delete from DB
                        Dim result As Result
                        'result = dlBus.delete(txtMaDaiLy.Text)
                        result = dlBus.delete((txtMaDaiLy.Text))
                        'CInt(Int(txtMaDaiLy.Text))
                        If (result.FlagResult = True) Then
                            'Convert.ToInt32(Convert.ToDecimal(txtPrice.Text))
                            ' Re-Load LoaiHocSinh list
                            loadListDaiLy(cbmLoaiDaiLy.SelectedValue)

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListDL.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListDL.Rows(currentRowIndex).Selected = True
                            End If

                            MessageBox.Show("Xóa đại lý thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa đại lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Dim currentRowIndex As Integer = dgvListDL.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListDL.RowCount) Then
            Try
                Dim daily As DaiLyDTO
                daily = New DaiLyDTO()

                '1. Mapping data from GUI control
                daily.MaDL = txtMaDaiLy.Text
                daily.TenDL = txtTenDaiLy.Text
                daily.DiaChi = txtDiaChi.Text
                daily.Email = txtEmail.Text
                daily.DienThoai = txtDienThoai.Text
                daily.NgTiepNhan = dtpNgTiepNhan.Value
                daily.MaQuan = Convert.ToInt32(cbmMaQuan.SelectedValue)
                daily.MaLoaiDL = Convert.ToInt32(cbmMaLoaiDL.SelectedValue)
                daily.NoCuaDaiLy = txtNoDaiLy.Text
                'hocsinh.DiaChi = txtDiaChi.Text
                'hocsinh.NgaySinh = dtpNgaySinh.Value
                'hocsinh.LoaiHS = Convert.ToInt32(cbLoaiHSCapNhat.SELECTedValue)
                '2. Business .....
                'If (dlBus.isValidName(hocsinh) = False) Then
                '    MessageBox.Show("Họ tên Học sinh không đúng.")
                '    txtHoTen.Focus()
                '    Return
                'End If
                '3. Insert to DB
                Dim result As Result
                result = dlBus.update(daily)
                If (result.FlagResult = True) Then
                    ' Re-Load HocSinh list
                    loadListDaiLy(cbmLoaiDaiLy.SelectedValue)
                    ' Hightlight the row has been updated on table
                    dgvListDL.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật đại lý thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật đại lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub dgvListDL_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListDL.CellContentClick

    End Sub
End Class