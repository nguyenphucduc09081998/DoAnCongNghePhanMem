Imports System.Configuration
Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility

Public Class frmQLMatHang
    Private mathangBus As MatHangBUS

    Private Sub frmQLMatHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mathangBus = New MatHangBUS()
        ' Load LoaiHocSinh list
        loadlistMatHang()


        Dim result As Result
        'load list loai DLư
        Dim listMatHang = New List(Of MatHangDTO)
        result = mathangBus.selectAll(listMatHang)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách mặt hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbTenMatHang.DataSource = New BindingSource(listMatHang, String.Empty)
        cbTenMatHang.DisplayMember = "TenMatHang"
        'cbxMaLoaiDL.ValueMember = "NoDaiLy"
        cbTenMatHang.ValueMember = "MaMathang"
    End Sub


    Private Sub dgvDanhSachMatHang_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachMatHang.SelectionChanged

        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachMatHang.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachMatHang.RowCount) Then
            Try
                Dim ldl = CType(dgvDanhSachMatHang.Rows(currentRowIndex).DataBoundItem, MatHangDTO)
                txtMaMatHang.Text = ldl.MaMatHang
                cbTenMatHang.SelectedValue = ldl.TenMatHang


                txtSoLuongTon.Text = ldl.SoLuongTon
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub
    Private Sub loadlistMatHang()
        ' Load LoaiHocSinh list
        Dim listMatHang = New List(Of MatHangDTO)
        Dim result As Result
        result = mathangBus.selectAll(listMatHang)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách mặt hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachMatHang.Columns.Clear()
        dgvDanhSachMatHang.DataSource = Nothing
        dgvDanhSachMatHang.AutoGenerateColumns = False
        dgvDanhSachMatHang.AllowUserToAddRows = False
        dgvDanhSachMatHang.DataSource = listMatHang

        Dim clMaMatHang = New DataGridViewTextBoxColumn()
        clMaMatHang.Name = "MaMatHang"
        clMaMatHang.HeaderText = "Mã Mặt Hàng"
        clMaMatHang.DataPropertyName = "MaMatHang"
        dgvDanhSachMatHang.Columns.Add(clMaMatHang)

        Dim clTenMatHang = New DataGridViewTextBoxColumn()
        clTenMatHang.Name = "TenMatHang"
        clTenMatHang.HeaderText = "Tên Mặt Hàng"
        clTenMatHang.DataPropertyName = "TenMatHang"
        dgvDanhSachMatHang.Columns.Add(clTenMatHang)

        Dim clSoLuongTon = New DataGridViewTextBoxColumn()
        clSoLuongTon.Name = "SoLuongTon"
        clSoLuongTon.HeaderText = "Số Lượng Tồn"
        clSoLuongTon.DataPropertyName = "SoLuongTon"
        dgvDanhSachMatHang.Columns.Add(clSoLuongTon)
    End Sub

    Private Sub dgvDanhSachMatHang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachMatHang.CellContentClick

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim currentRowIndex As Integer = dgvDanhSachMatHang.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachMatHang.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa mặt hàng có mã: " + txtMaMatHang.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = mathangBus.delete(txtMaMatHang.Text)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadlistMatHang()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDanhSachMatHang.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachMatHang.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim ldl = CType(dgvDanhSachMatHang.Rows(currentRowIndex).DataBoundItem, MatHangDTO)
                                    txtMaMatHang.Text = ldl.MaMatHang
                                    ''thieu ten quan
                                    cbTenMatHang.SelectedValue = ldl.TenMatHang
                                    txtSoLuongTon.Text = ldl.SoLuongTon
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa mặt hàng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa mặt hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Dim currentRowIndex As Integer = dgvDanhSachMatHang.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachMatHang.RowCount) Then
            Try
                Dim ldl As MatHangDTO
                ldl = New MatHangDTO()

                '1. Mapping data from GUI control
                ldl.MaMatHang = Convert.ToInt32(txtMaMatHang.Text)
                ldl.TenMatHang = cbTenMatHang.Text
                ldl.SoLuongTon = txtSoLuongTon.Text
                '2. Business .....
                'If (lhsBus.isValidName(lhs) = False) Then
                '    MessageBox.Show("Tên Loại học sinh không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    txtTenLoai.Focus()
                '    Return
                'End If

                '3. Insert to DB

                Dim result As Result
                result = mathangBus.Update(ldl)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadlistMatHang()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachMatHang.Rows(currentRowIndex).Selected = True
                    Try
                        ldl = CType(dgvDanhSachMatHang.Rows(currentRowIndex).DataBoundItem, MatHangDTO)
                        txtMaMatHang.Text = ldl.MaMatHang
                        cbTenMatHang.Text = ldl.TenMatHang
                        txtSoLuongTon.Text = ldl.SoLuongTon
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật mặt hàng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật mặt hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub
End Class