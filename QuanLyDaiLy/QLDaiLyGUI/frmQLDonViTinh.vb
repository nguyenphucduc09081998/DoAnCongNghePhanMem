Imports System.Configuration
Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility




Public Class frmQLDonViTinh
    Private ldonvitinhBus As DonViTinhBUS
    Private Sub frmQLDonViTinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ldonvitinhBus = New DonViTinhBUS()
        ' Load LoaiHocSinh list
        loadListDonViTinh()
    End Sub

    Private Sub loadListDonViTinh()
        ' Load LoaiHocSinh list
        Dim listDonViTinh = New List(Of DonViTinhDTO)
        Dim result As Result
        result = ldonvitinhBus.selectAll(listDonViTinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách đơn vị tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachDonViTinh.Columns.Clear()
        dgvDanhSachDonViTinh.DataSource = Nothing

        dgvDanhSachDonViTinh.AutoGenerateColumns = False
        dgvDanhSachDonViTinh.AllowUserToAddRows = False
        dgvDanhSachDonViTinh.DataSource = listDonViTinh

        Dim clMaDonViTinh = New DataGridViewTextBoxColumn()
        clMaDonViTinh.Name = "MaDonViTinh"
        clMaDonViTinh.HeaderText = "Mã Đơn Vị Tính"
        clMaDonViTinh.DataPropertyName = "MaDonViTinh"
        dgvDanhSachDonViTinh.Columns.Add(clMaDonViTinh)

        Dim clTenDonViTinh = New DataGridViewTextBoxColumn()
        clTenDonViTinh.Name = "TenDonViTinh"
        clTenDonViTinh.HeaderText = "Tên Đơn Vị Tính"
        clTenDonViTinh.DataPropertyName = "TenDonViTinh"
        dgvDanhSachDonViTinh.Columns.Add(clTenDonViTinh)
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim currentRowIndex As Integer = dgvDanhSachDonViTinh.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachDonViTinh.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa đơn vị tính có mã: " + txtMaDonViTinh.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = ldonvitinhBus.delete(Convert.ToInt32(txtMaDonViTinh.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListDonViTinh()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDanhSachDonViTinh.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachDonViTinh.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim lq = CType(dgvDanhSachDonViTinh.Rows(currentRowIndex).DataBoundItem, DonViTinhDTO)
                                    txtMaDonViTinh.Text = lq.MaDonViTinh
                                    txtTenDonViTinh.Text = lq.TenDonViTinh
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa đơn vị tính thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa đơn vị tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Dim currentRowIndex As Integer = dgvDanhSachDonViTinh.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachDonViTinh.RowCount) Then
            Try
                Dim lq As DonViTinhDTO
                lq = New DonViTinhDTO()

                '1. Mapping data from GUI control
                lq.MaDonViTinh = Convert.ToInt32(txtMaDonViTinh.Text)
                lq.TenDonViTinh = txtTenDonViTinh.Text

                '2. Business .....
                'If (lhsBus.isValidName(lhs) = False) Then
                '    MessageBox.Show("Tên Loại học sinh không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    txtTenLoai.Focus()
                '    Return
                'End If

                '3. Insert to DB

                Dim result As Result
                result = ldonvitinhBus.update(lq)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadListDonViTinh()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachDonViTinh.Rows(currentRowIndex).Selected = True
                    Try
                        lq = CType(dgvDanhSachDonViTinh.Rows(currentRowIndex).DataBoundItem, DonViTinhDTO)
                        txtMaDonViTinh.Text = lq.MaDonViTinh
                        txtTenDonViTinh.Text = lq.TenDonViTinh
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật đơn vị tính thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật đơn vị tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub dgvDanhSachDonViTinh_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachDonViTinh.CellContentClick

    End Sub
    Private Sub dgvDanhSachDonViTinh_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachDonViTinh.SelectionChanged

        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachDonViTinh.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachDonViTinh.RowCount) Then
            Try
                Dim lq = CType(dgvDanhSachDonViTinh.Rows(currentRowIndex).DataBoundItem, DonViTinhDTO)
                txtMaDonViTinh.Text = lq.MaDonViTinh
                txtTenDonViTinh.Text = lq.TenDonViTinh
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub
End Class