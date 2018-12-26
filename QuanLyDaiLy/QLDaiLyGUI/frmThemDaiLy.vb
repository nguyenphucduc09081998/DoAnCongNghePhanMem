Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility

Public Class frmThemDaiLy
    Private dlBus As DaiLyBUS
    Private LoaiDLBus As LoaiDLBUS
    Private QuanBus As QuanBUS
    'Private lhsBus As LoaiHocSinhBUS

    Private Sub btnThemDaiLy_Click(sender As Object, e As EventArgs) Handles btnThemDaiLy.Click

        Dim daily As DaiLyDTO
        daily = New DaiLyDTO()

        '1. Mapping data from GUI control
        'hocsinh.MSHS = txtMaSo.Text
        daily.TenDL = txtTenDL.Text
        daily.DiaChi = txtDiaChi.Text
        daily.Email = txtEmail.Text
        daily.DienThoai = txtDienThoai.Text
        daily.NgTiepNhan = dtpNgTiepNhan.Value
        daily.NoCuaDaiLy = Convert.ToInt32(txtNoCuaDaiLy.Text)
        'daily.NoCuaDaiLy = txtNoCuaDaiLy.Text
        daily.MaQuan = Convert.ToInt32(cbxMaQuan.SelectedValue)
        daily.MaLoaiDL = Convert.ToInt32(cbxMaLoaiDL.SelectedValue)
        'daily.NoCuaDaiLy = Convert.ToInt32(txtNoCuaDaiLy)
        'hocsinh.LoaiHS = Convert.ToInt32(cbLoaiHS.SELECTedValue)

        '2. Business .....


        '3. Insert to DB
        Dim result As Result
        result = dlBus.insert(daily)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Đại Lý thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMaDL = "1"
            result = dlBus.buildMaDL(nextMaDL)
            'If (result.FlagResult = True) Then
            '    MessageBox.Show("Lấy danh tự động mã Mã Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Me.Close()
            '    Return
            'End If
            txtTenDL.Text = String.Empty
            txtDiaChi.Text = String.Empty
            txtEmail.Text = String.Empty
            txtDienThoai.Text = String.Empty

        Else
            MessageBox.Show("Thêm Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub frmThemDaiLy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dlBus = New DaiLyBUS()
        LoaiDLBus = New LoaiDLBUS()
        QuanBus = New QuanBUS()

        'lay ma dai ly
        Dim result As Result
        Dim resultQuan As Result
        Dim nextMaDL As Integer


        result = dlBus.buildMaDL(nextMaDL)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaDL.Text = nextMaDL

        'load combobox LoaiDL

        Dim listLoaiDl = New List(Of LoaiDLDTO)
        result = LoaiDLBus.selectAll(listLoaiDl)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại đại lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbxMaLoaiDL.DataSource = New BindingSource(listLoaiDl, String.Empty)
        cbxMaLoaiDL.DisplayMember = "TenLoaiDL"
        'cbxMaLoaiDL.ValueMember = "NoDaiLy"
        cbxMaLoaiDL.ValueMember = "MaLoaiDL"


        'load combobox ma quan
        Dim listQuan = New List(Of QuanDTO)
        resultQuan = QuanBus.selectAll(listQuan)
        If (resultQuan.FlagResult = False) Then
            MessageBox.Show("Lấy danh loại Quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbxMaQuan.DataSource = New BindingSource(listQuan, String.Empty)
        cbxMaQuan.DisplayMember = "TenQuan"
        cbxMaQuan.ValueMember = "MaQuan"

    End Sub

    Private Sub txtDienThoai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDienThoai.KeyPress, txtNoCuaDaiLy.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class