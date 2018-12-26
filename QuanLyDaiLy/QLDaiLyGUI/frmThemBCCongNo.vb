
Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility

Public Class frmThemBCCongNo
    Private BCCongNoBus As BaoCaoCongNoBUS
    Private DaiLyBus As DaiLyBUS
    Private Sub frmThemBCCongNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BCCongNoBus = New BaoCaoCongNoBUS()
        DaiLyBus = New DaiLyBUS()
        'QuanBUS = New QuanBUS()
        Dim result As Result
        Dim resultDaiLy As Result
        Dim nextMaBCCongNo As Integer
        result = BCCongNoBus.buildMaBaoCaoCongNo(nextMaBCCongNo)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã phiếu xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaBaoCaoCongNo.Text = nextMaBCCongNo

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
        Dim BCCongNo As BaoCaoCongNo
        BCCongNo = New BaoCaoCongNo()

        '1. Mapping data from GUI control
        'hocsinh.MSHS = txtMaSo.Text
        BCCongNo.MaDaiLy = Convert.ToInt32(cbMaDL.SelectedValue)
        ' phieuxuat.NgayLapPhieu = dtpNgayLapPhieu.Value

        BCCongNo.NoCuoi = txtNoCuoi.Text
        BCCongNo.NoDau = txtNoDau.Text
        BCCongNo.PhatSinh = txtPhatSinh.Text
        '2. Business .....


        '3. Insert to DB
        Dim result As Result
        result = BCCongNoBus.insert(BCCongNo)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm phiếu xuất thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMaBCCongNo = "1"
            result = BCCongNoBus.buildMaBaoCaoCongNo(nextMaBCCongNo)
            'If (result.FlagResult = True) Then
            '    MessageBox.Show("Lấy danh tự động mã Mã Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Me.Close()
            '    Return
            'End If




            'txtTenDL.Text = String.Empty
            'txtDiaChi.Text = String.Empty
            'txtEmail.Text = String.Empty
            'txtDienThoai.Text = String.Empty

        Else
            MessageBox.Show("Thêm phiếu xuất không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub txtMaBaoCaoCongNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaBaoCaoCongNo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class