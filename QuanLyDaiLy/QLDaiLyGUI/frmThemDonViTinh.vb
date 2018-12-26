Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility

Public Class frmThemDonViTinh
    Private donvitinhBus As DonViTinhBUS

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click

        Dim countsodonvitinh As Integer
        ' Dim resultsodonvitinh As Result
        Dim soluongdonvitinh As Integer

        donvitinhBus.soluongdonvitinh(countsodonvitinh)
        donvitinhBus.selectSoDonVitinh_thamso(soluongdonvitinh)

        Dim donvitinh As DonViTinhDTO
        donvitinh = New DonViTinhDTO()
        donvitinh.MaDonViTinh = txtMaDonViTinh.Text
        donvitinh.TenDonViTinh = txtTenDonViTinh.Text


        If (countsodonvitinh < soluongdonvitinh) Then
            '3. Insert to DB
            Dim result As Result
            result = donvitinhBus.insert(donvitinh)
            If (result.FlagResult = True) Then
                MessageBox.Show("Thêm đơn vị tính thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'set MSSH auto
                Dim nextMaDonViTinh = "1"
                result = donvitinhBus.buildMaDonViTinh(nextMaDonViTinh)

                txtTenDonViTinh.Text = String.Empty
            Else
                MessageBox.Show("Thêm đơn vị tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("không thỏa số đơn vị tính tối đa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub frmThemDonViTinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        donvitinhBus = New DonViTinhBUS()
        ' LoaiDLBUS = New LoaiDLBUS()
        ' quanBus = New QuanBUS()

        'lay ma dai ly
        Dim result As Result
        ' Dim resultQuan As Result
        Dim nextMaDonViTinh As Integer


        result = donvitinhBus.buildMaDonViTinh(nextMaDonViTinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã đơn vị tính không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaDonViTinh.Text = nextMaDonViTinh
    End Sub

    Private Sub txtMaDonViTinh_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaDonViTinh.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class