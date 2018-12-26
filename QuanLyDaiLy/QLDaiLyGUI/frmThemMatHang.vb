Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility

Public Class frmThemMatHang

    Private MatHangBus As MatHangBUS
    Private Sub frmThemMatHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        MatHangBus = New MatHangBUS()
        ' LoaiDLBUS = New LoaiDLBUS()
        ' quanBus = New QuanBUS()

        'lay ma dai ly
        Dim result As Result
        ' Dim resultQuan As Result
        Dim nextMaMatHang As Integer


        result = MatHangBus.builMaMatHang(nextMaMatHang)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động  không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaMatHang.Text = nextMaMatHang
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim mathang As MatHangDTO
        mathang = New MatHangDTO()

        mathang.MaMatHang = txtMaMatHang.Text
        mathang.TenMatHang = txtTenMatHang.Text
        mathang.SoLuongTon = txtSoLuongTon.Text


        Dim countsomathang As Integer
        ' Dim resultsodonvitinh As Result
        Dim somathangotida As Integer

        MatHangBus.countsomathang(countsomathang)
        MatHangBus.selectSomathang_thamso(somathangotida)
        '3. Insert to DB
        If (countsomathang < somathangotida) Then

            Dim result As Result
            result = MatHangBus.insert(mathang)
            If (result.FlagResult = True) Then
                MessageBox.Show("Thêm mặt hàng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'set MSSH auto
                Dim nextMaMatHang = "1"
                result = MatHangBus.builMaMatHang(nextMaMatHang)

                txtTenMatHang.Text = String.Empty
                txtSoLuongTon.Text = String.Empty
            Else
                MessageBox.Show("Thêm mặt hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("số mặt hàng phải bé hơn số mặt hàng tối đa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtMaMatHang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaMatHang.KeyPress, txtSoLuongTon.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
