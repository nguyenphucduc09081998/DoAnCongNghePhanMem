Imports System.Configuration
Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility
Public Class frmQLBCCongNo
    Private bcCongNoBus As BaoCaoCongNoBUS
    Private dlBus As DaiLyBUS
    Private Sub frmQLBCCongNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'quanBus = New QuanBUS()
        bcCongNoBus = New BaoCaoCongNoBUS()
        dlBus = New DaiLyBUS()

        ' Load DaiLy list
        'Dim listDaiLy = New List(Of DaiLyDTO)
        'Dim result As Result
        'result = dlBus.selectAll(listDaiLy)
        'If (result.FlagResult = False) Then
        '    MessageBox.Show("Lấy danh sách Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Return
        'End If

        'cbMaDLT.DataSource = New BindingSource(listDaiLy, String.Empty)
        'cbMaDLT.DisplayMember = "TenDl"
        'cbMaDLT.ValueMember = "MaDL"

        'cbMaDLD.DataSource = New BindingSource(listDaiLy, String.Empty)
        'cbMaDLD.DisplayMember = "TenDl"
        'cbMaDLD.ValueMember = "MaDL"
    End Sub

    'Private Sub btnXoa_Click(sender As Object, e As EventArgs)
    '    ' Get the current cell location.
    '    '
    '    bcCongNoBus = New BaoCaoCongNoBUS()
    '    '
    '    Dim currentRowIndex As Integer = dgvBaoCaoCongNo.CurrentCellAddress.Y 'current row selected
    '    'Verify that indexing OK
    '    If (-1 < currentRowIndex And currentRowIndex < dgvBaoCaoCongNo.RowCount) Then
    '        Select Case MsgBox("Bạn có thực sự muốn xóa phieu xuat có mã số: " + txtMaBaoCaoCongNo.Text, MsgBoxStyle.YesNo, "Information")
    '            Case MsgBoxResult.Yes ' + txtMaDaiLy.Text
    '                Try
    '                    '1. Delete from DB
    '                    Dim result As Result
    '                    'result = dlBus.delete(txtMaDaiLy.Text)
    '                    result = bcCongNoBus.delete((txtMaBaoCaoCongNo.Text))
    '                    'CInt(Int(txtMaDaiLy.Text))
    '                    If (result.FlagResult = True) Then
    '                        'Convert.ToInt32(Convert.ToDecimal(txtPrice.Text))
    '                        ' Re-Load LoaiHocSinh list
    '                        loadListBaoCaoCongNo(cbMaDLT.SelectedValue)

    '                        ' Hightlight the next row on table
    '                        If (currentRowIndex >= dgvBaoCaoCongNo.Rows.Count) Then
    '                            currentRowIndex = currentRowIndex - 1
    '                        End If
    '                        If (currentRowIndex >= 0) Then
    '                            dgvBaoCaoCongNo.Rows(currentRowIndex).Selected = True
    '                        End If

    '                        MessageBox.Show("Xóa phieu xuat thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    Else
    '                        MessageBox.Show("Xóa phieu xuat không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                        System.Console.WriteLine(result.SystemMessage)
    '                    End If
    '                Catch ex As Exception
    '                    Console.WriteLine(ex.StackTrace)
    '                End Try
    '            Case MsgBoxResult.No
    '                Return
    '        End Select
    '    End If
    'End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvBaoCaoCongNo.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvBaoCaoCongNo.RowCount) Then
            Try
                Dim baocao As BaoCaoCongNo
                baocao = New BaoCaoCongNo()

                '1. Mapping data from GUI control
                'baocao.MaBaoCaoCongNo = txtMaBaoCaoCongNo.Text
                'baocao.MaDaiLy = Convert.ToInt32(cbMaDLD.SelectedValue)
                'baocao.PhatSinh = txtPhatSinh.Text
                'baocao.NoCuoi = txtNoCuoi.Text
                'baocao.NoDau = txtNoDau.Text
                '3. Insert to DB
                Dim result As Result
                result = bcCongNoBus.update(baocao)
                If (result.FlagResult = True) Then
                    ' Re-Load HocSinh list
                    loadListBaoCaoCongNo(cbMaDLT.SelectedValue)
                    ' Hightlight the row has been updated on table
                    dgvBaoCaoCongNo.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật phieu xuat thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật phieu xuat không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub cbMaDLT_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles cbMaDLT.SelectedIndexChanged
        Try
            Dim madaily = Convert.ToInt32(cbMaDLT.SelectedValue)
            loadListBaoCaoCongNo(madaily)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvBaoCaoCongNo_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvBaoCaoCongNo.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvBaoCaoCongNo.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvBaoCaoCongNo.RowCount) Then
            Try
                Dim px = CType(dgvBaoCaoCongNo.Rows(currentRowIndex).DataBoundItem, BaoCaoCongNo)

                'txtMaBaoCaoCongNo.Text = px.MaBaoCaoCongNo
                'cbMaDLD.SelectedIndex = cbMaDLT.SelectedIndex

                'txtPhatSinh.Text = px.PhatSinh
                'txtNoDau.Text = px.NoDau
                'txtNoCuoi.Text = px.NoCuoi
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub loadListBaoCaoCongNo(maDL As String)
        Dim listBaoCao = New List(Of BaoCaoCongNo)
        Dim result As Result

        result = bcCongNoBus.selectALL_ByMaDaiLy(maDL, listBaoCao)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách phieu  xuat thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvBaoCaoCongNo.Columns.Clear()
        dgvBaoCaoCongNo.DataSource = Nothing
        dgvBaoCaoCongNo.AutoGenerateColumns = False
        dgvBaoCaoCongNo.AllowUserToAddRows = False
        dgvBaoCaoCongNo.DataSource = listBaoCao

        Dim clMaBaoCaoCongNo = New DataGridViewTextBoxColumn()
        clMaBaoCaoCongNo.Name = "MaBaoCaoCongNo"
        clMaBaoCaoCongNo.HeaderText = "Mã BC Công Nợ"
        clMaBaoCaoCongNo.DataPropertyName = "MaBaoCaoCongNo"
        dgvBaoCaoCongNo.Columns.Add(clMaBaoCaoCongNo)

        'Dim clLoaiHS = New DataGridView()
        'clLoaiHS.Name = "LoaiHS"
        'clLoaiHS.HeaderText = "Tên Loại"
        'clLoaiHS.DataPropertyName = "LoaiHS"
        'dgvListHS.Columns.Add(clLoaiHS)

        Dim clMaDaiLy = New DataGridViewTextBoxColumn()
        clMaDaiLy.Name = "MaDaiLy"
        clMaDaiLy.HeaderText = "Tên Đại Lý"
        clMaDaiLy.DataPropertyName = "MaDaiLy"
        dgvBaoCaoCongNo.Columns.Add(clMaDaiLy)

        Dim clPhatSinh = New DataGridViewTextBoxColumn()
        clPhatSinh.Name = "PhatSinh"
        clPhatSinh.HeaderText = "Phát Sinh"
        clPhatSinh.DataPropertyName = "PhatSinh"
        dgvBaoCaoCongNo.Columns.Add(clPhatSinh)

        Dim clNoDau = New DataGridViewTextBoxColumn()
        clNoDau.Name = "NoDau"
        clNoDau.HeaderText = "Nợ Đầu"
        clNoDau.DataPropertyName = "NoDau"
        dgvBaoCaoCongNo.Columns.Add(clNoDau)

        Dim clNoCuoi = New DataGridViewTextBoxColumn()
        clNoCuoi.Name = "NoCuoi"
        clNoCuoi.HeaderText = "Nợ Cuối"
        clNoCuoi.DataPropertyName = "NoCuoi"
        dgvBaoCaoCongNo.Columns.Add(clNoCuoi)
        'dgvListHS.ResumeLayout()

    End Sub
End Class