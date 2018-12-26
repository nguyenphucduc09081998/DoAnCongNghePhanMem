Imports System.Configuration
Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility


Public Class frmQLQuan
    Private lqBus As QuanBUS
    Private Sub frmQLQuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lqBus = New QuanBUS()
        ' Load LoaiHocSinh list
        loadListQuan()

    End Sub

    Private Sub loadListQuan()
        ' Load LoaiHocSinh list
        Dim listQuan = New List(Of QuanDTO)
        Dim result As Result
        result = lqBus.selectAll(listQuan)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDoanhSachQuan.Columns.Clear()
        dgvDoanhSachQuan.DataSource = Nothing

        dgvDoanhSachQuan.AutoGenerateColumns = False
        dgvDoanhSachQuan.AllowUserToAddRows = False
        dgvDoanhSachQuan.DataSource = listQuan

        Dim clMaQuan = New DataGridViewTextBoxColumn()
        clMaQuan.Name = "MaQuan"
        clMaQuan.HeaderText = "Mã Quận"
        clMaQuan.DataPropertyName = "MaQuan"
        dgvDoanhSachQuan.Columns.Add(clMaQuan)

        Dim clTenQuan = New DataGridViewTextBoxColumn()
        clTenQuan.Name = "TenQuan"
        clTenQuan.HeaderText = "Tên Quận"
        clTenQuan.DataPropertyName = "TenQuan"
        dgvDoanhSachQuan.Columns.Add(clTenQuan)
    End Sub


    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim currentRowIndex As Integer = dgvDoanhSachQuan.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDoanhSachQuan.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa quận có mã: " + txtMaQuan.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = lqBus.delete(Convert.ToInt32(txtMaQuan.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListQuan()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDoanhSachQuan.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDoanhSachQuan.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim lq = CType(dgvDoanhSachQuan.Rows(currentRowIndex).DataBoundItem, QuanDTO)
                                    txtMaQuan.Text = lq.MaQuan
                                    txtTenQuan.Text = lq.TenQuan
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa Loại quận thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Loại quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Dim currentRowIndex As Integer = dgvDoanhSachQuan.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDoanhSachQuan.RowCount) Then
            Try
                Dim lq As QuanDTO
                lq = New QuanDTO()

                '1. Mapping data from GUI control
                lq.MaQuan = Convert.ToInt32(txtMaQuan.Text)
                lq.TenQuan = txtTenQuan.Text

                '2. Business .....
                'If (lhsBus.isValidName(lhs) = False) Then
                '    MessageBox.Show("Tên Loại học sinh không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    txtTenLoai.Focus()
                '    Return
                'End If

                '3. Insert to DB

                Dim result As Result
                result = lqBus.update(lq)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadListQuan()
                    ' Hightlight the row has been updated on table
                    dgvDoanhSachQuan.Rows(currentRowIndex).Selected = True
                    Try
                        lq = CType(dgvDoanhSachQuan.Rows(currentRowIndex).DataBoundItem, QuanDTO)
                        txtMaQuan.Text = lq.MaQuan
                        txtTenQuan.Text = lq.TenQuan
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật loại quận thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật loại quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
    Private Sub dgvDanhSachQuan_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvDoanhSachQuan.SelectionChanged

        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDoanhSachQuan.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDoanhSachQuan.RowCount) Then
            Try
                Dim lq = CType(dgvDoanhSachQuan.Rows(currentRowIndex).DataBoundItem, QuanDTO)
                txtMaQuan.Text = lq.MaQuan
                txtTenQuan.Text = lq.TenQuan
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub

    Private Sub dgvDoanhSachQuan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDoanhSachQuan.CellContentClick

    End Sub

    Private Sub txtMaQuan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaQuan.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class