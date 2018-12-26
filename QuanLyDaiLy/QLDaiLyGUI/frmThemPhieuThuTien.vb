Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility


Public Class frmThemPhieuThuTien
    Private ptBus As PhieuThuTienBUS
    Private DaiLyBus As DaiLyBUS
    Dim lNoCuaDaiLy As Integer

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMaDL.SelectedIndexChanged

    End Sub
    Private Sub loadNoCuaDaiLy(maDL As Integer)


        Dim result As Result

        result = ptBus.selectNoCuaDaiLy_ByMaDaiLy(maDL, lNoCuaDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy no dai ly thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        txtNoCuaDaiLy.Text = lNoCuaDaiLy

    End Sub

    Private Sub cbMaDLT_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles cbMaDL.SelectedIndexChanged
        Try
            Dim madaily = Convert.ToInt32(cbMaDL.SelectedValue)
            loadNoCuaDaiLy(madaily)
            btnThem.Enabled = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub frmThemPhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbMaDL.ValueMember = " "
        ptBus = New PhieuThuTienBUS()
        DaiLyBus = New DaiLyBUS()
        btnThem.Enabled = False
        'QuanBUS = New QuanBUS()
        Dim result As Result
        Dim resultDaiLy As Result
        Dim nextMaPhieuThuTien As Integer


        result = ptBus.buildMaPhieuThuTien(nextMaPhieuThuTien)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã phiếu xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaPhieuThu.Text = nextMaPhieuThuTien

        'load combobox LoaiDL

        Dim listDaiLy = New List(Of DaiLyDTO)
        result = DaiLyBus.selectAll(listDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách đại lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbMaDL.DataSource = New BindingSource(listDaiLy, String.Empty)
        cbMaDL.DisplayMember = "TenDl"
        'cbxMaLoaiDL.ValueMember = "NoDaiLy"
        cbMaDL.ValueMember = "MaDL"

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim phieuThu As PhieuThuTienDTO
        phieuThu = New PhieuThuTienDTO()

        '1. Mapping data from GUI control
        'hocsinh.MSHS = txtMaSo.Text
        phieuThu.MaDaiLy = Convert.ToInt32(cbMaDL.SelectedValue)
        phieuThu.NgayThuTien = dtpNgayThuTien.Value

        phieuThu.SoTienThu = txtSoTienThu.Text

        '2. Business .....


        '3. Insert to DB
        If (phieuThu.SoTienThu < lNoCuaDaiLy) Then

            Dim result As Result
            result = ptBus.insert(phieuThu)
            If (result.FlagResult = True) Then
                MessageBox.Show("Thêm phieu xuat thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'set MaPhieuThuTien auto
                Dim nextMaPhieuThuTien = "1"
                result = ptBus.buildMaPhieuThuTien(nextMaPhieuThuTien)

            Else
                MessageBox.Show("Thêm phiếu xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("kiểm tra lại tiền thu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cbMaDL_MouseClick(sender As Object, e As MouseEventArgs) Handles cbMaDL.MouseClick

    End Sub

    Private Sub txtMaPhieuThu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaPhieuThu.KeyPress, txtSoTienThu.KeyPress, txtNoCuaDaiLy.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class