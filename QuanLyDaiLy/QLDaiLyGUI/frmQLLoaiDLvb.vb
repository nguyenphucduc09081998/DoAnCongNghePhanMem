Imports System.Configuration
Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility
Public Class frmQLLoaiDLvb

    Private ldlBus As LoaiDLBUS
    '  Private LoaiDLBus As LoaiDLBUS
    Private Sub frmQLLoaiDLvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ldlBus = New LoaiDLBUS()
        ' Load LoaiHocSinh list
        loadListLoaiDL()


        Dim result As Result
        'load list loai DLư
        Dim listLoaiDl = New List(Of LoaiDLDTO)
        result = ldlBus.selectAll(listLoaiDl)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại đại lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbmTenLoaiDL.DataSource = New BindingSource(listLoaiDl, String.Empty)
        cbmTenLoaiDL.DisplayMember = "TenLoaiDL"
        'cbxMaLoaiDL.ValueMember = "NoDaiLy"
        cbmTenLoaiDL.ValueMember = "MaLoaiDL"

    End Sub

    Private Sub loadListLoaiDL()
        ' Load LoaiHocSinh list
        Dim listLoaiDL = New List(Of LoaiDLDTO)
        Dim result As Result
        result = ldlBus.selectAll(listLoaiDL)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách DL không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDoanhSachLoaiDL.Columns.Clear()
        dgvDoanhSachLoaiDL.DataSource = Nothing

        dgvDoanhSachLoaiDL.AutoGenerateColumns = False
        dgvDoanhSachLoaiDL.AllowUserToAddRows = False
        dgvDoanhSachLoaiDL.DataSource = listLoaiDL

        Dim clMaLoaiDL = New DataGridViewTextBoxColumn()
        clMaLoaiDL.Name = "MaLoaiDL"
        clMaLoaiDL.HeaderText = "Mã Loại Đại Lý"
        clMaLoaiDL.DataPropertyName = "MaLoaiDL"
        dgvDoanhSachLoaiDL.Columns.Add(clMaLoaiDL)

        Dim clTenLoaiDL = New DataGridViewTextBoxColumn()
        clTenLoaiDL.Name = "TenLoaiDL"
        clTenLoaiDL.HeaderText = "Tên Loại Đại Lý"
        clTenLoaiDL.DataPropertyName = "TenLoaiDL"
        dgvDoanhSachLoaiDL.Columns.Add(clTenLoaiDL)

        Dim clNoToiDa = New DataGridViewTextBoxColumn()
        clNoToiDa.Name = "NoToiDa"
        clNoToiDa.HeaderText = "Nợ Tối Đa"
        clNoToiDa.DataPropertyName = "NoToiDa"
        dgvDoanhSachLoaiDL.Columns.Add(clNoToiDa)





    End Sub
    Private Sub dgvDoanhSachLoaiDL_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvDoanhSachLoaiDL.SelectionChanged

        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDoanhSachLoaiDL.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDoanhSachLoaiDL.RowCount) Then
            Try
                Dim ldl = CType(dgvDoanhSachLoaiDL.Rows(currentRowIndex).DataBoundItem, LoaiDLDTO)
                txtMaLoaiDL.Text = ldl.MaLoaiDL
                cbmTenLoaiDL.SelectedValue = ldl.TenLoaiDL


                txtNoToiDa.Text = ldl.NoToiDa
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim currentRowIndex As Integer = dgvDoanhSachLoaiDL.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDoanhSachLoaiDL.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Loại Đại Lý có mã: " + txtMaLoaiDL.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = ldlBus.delete(txtMaLoaiDL.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListLoaiDL()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDoanhSachLoaiDL.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDoanhSachLoaiDL.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim ldl = CType(dgvDoanhSachLoaiDL.Rows(currentRowIndex).DataBoundItem, LoaiDLDTO)
                                    txtMaLoaiDL.Text = ldl.MaLoaiDL
                                    ''thieu ten quan
                                    cbmTenLoaiDL.SelectedValue = ldl.TenLoaiDL
                                    txtNoToiDa.Text = ldl.NoToiDa
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa Loại dl thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Loại dl không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Dim currentRowIndex As Integer = dgvDoanhSachLoaiDL.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDoanhSachLoaiDL.RowCount) Then
            Try
                Dim ldl As LoaiDLDTO
                ldl = New LoaiDLDTO()

                '1. Mapping data from GUI control
                ldl.MaLoaiDL = Convert.ToInt32(txtMaLoaiDL.Text)
                ldl.TenLoaiDL = cbmTenLoaiDL.Text
                ldl.NoToiDa = txtNoToiDa.Text
                '2. Business .....
                'If (lhsBus.isValidName(lhs) = False) Then
                '    MessageBox.Show("Tên Loại học sinh không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    txtTenLoai.Focus()
                '    Return
                'End If

                '3. Insert to DB

                Dim result As Result
                result = ldlBus.Update(ldl)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadListLoaiDL()
                    ' Hightlight the row has been updated on table
                    dgvDoanhSachLoaiDL.Rows(currentRowIndex).Selected = True
                    Try
                        ldl = CType(dgvDoanhSachLoaiDL.Rows(currentRowIndex).DataBoundItem, LoaiDLDTO)
                        txtMaLoaiDL.Text = ldl.MaLoaiDL
                        cbmTenLoaiDL.Text = ldl.TenLoaiDL
                        txtNoToiDa.Text = ldl.NoToiDa
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Loại Đại Lý thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Loại Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub dgvDoanhSachLoaiDL_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDoanhSachLoaiDL.CellContentClick

    End Sub
End Class