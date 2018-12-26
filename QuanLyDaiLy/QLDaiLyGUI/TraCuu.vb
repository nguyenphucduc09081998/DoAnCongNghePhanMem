Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility

Public Class TraCuu
    Private QuanBus As QuanBUS
    Private dlBus As DaiLyBUS
    Private ldlBus As LoaiDLBUS
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TraCuu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cbQuan.Items.Add("Text ")
        cbQuan.DisplayMember = ""
        cbLoaiDaiLy.DisplayMember = ""
        QuanBus = New QuanBUS()
        dlBus = New DaiLyBUS()
        ldlBus = New LoaiDLBUS()

    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click

        Try

            ' Dim madl = txtMaDL.Text
            Dim tendl = txtTenDL.Text
            Dim maquan = cbQuan.SelectedValue
        Dim maLoaidl = cbLoaiDaiLy.SelectedValue

            If (maquan And tendl = Nothing And maLoaidl = Nothing) Then
                loadmaquan(maquan)
                Return
            End If

            If (maLoaidl And tendl = Nothing And maquan = Nothing) Then
                loadloaidl(maLoaidl)
                Return
            End If
            If (maLoaidl And maquan) Then
                load_maloaidl_maquan(maLoaidl, maquan)
                Return
            End If

            If ((tendl = Nothing) = False And maquan = Nothing And maLoaidl = Nothing) Then
                load(tendl)
                Return
            End If

            'If (tendl) Then
            '    load(tendl)
            'End If
            If ((tendl = Nothing) = False And maquan And maLoaidl = Nothing) Then
                load_ten_quan(tendl, maquan)
                Return
            End If

            If ((tendl = Nothing) = False And maquan = Nothing And maLoaidl) Then
                load_ten_loaidl(tendl, maLoaidl)
                Return
            End If

            If ((tendl = Nothing) = False And maquan And maLoaidl) Then
                load_ten_quan_loaidl(tendl, maLoaidl, maquan)
                Return
            End If


        Catch ex As Exception
        End Try
    End Sub
    'load laoidl va quna
    Private Sub load_maloaidl_maquan(maloaidl As Integer, maquan As Integer) 'madaily As Integer, tendl As String,
        Dim listDaiLy = New List(Of DaiLyDTO)
        Dim result As Result
        result = dlBus.search_maloaidl_maquan(maloaidl, maquan, listDaiLy)
        ' result = dlBus.nhap(madaily, tendl, maquan, maloaidl, listDaiLy)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách dai ly ko thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvTraCuu.Columns.Clear()
        dgvTraCuu.DataSource = Nothing

        dgvTraCuu.AutoGenerateColumns = False
        dgvTraCuu.AllowUserToAddRows = False
        dgvTraCuu.DataSource = listDaiLy

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaDL"
        clMa.HeaderText = "Mã Đại Lý"
        clMa.DataPropertyName = "MaDL"
        dgvTraCuu.Columns.Add(clMa)

        Dim clLoaiHS = New DataGridView()


        Dim clTenDL = New DataGridViewTextBoxColumn()
        clTenDL.Name = "TenDL"
        clTenDL.HeaderText = "Tên Đại Lý"
        clTenDL.DataPropertyName = "TenDL"
        dgvTraCuu.Columns.Add(clTenDL)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvTraCuu.Columns.Add(clDiaChi)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        dgvTraCuu.Columns.Add(clEmail)
        'dgvListHS.ResumeLayout()


        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "DienThoai"
        clDienThoai.HeaderText = "Điện Thoại"
        clDienThoai.DataPropertyName = "DienThoai"
        dgvTraCuu.Columns.Add(clDienThoai)
        'dgvListHS.ResumeLayout()

        Dim clNgTiepNhan = New DataGridViewTextBoxColumn()
        clNgTiepNhan.Name = "NgTiepNhan"
        clNgTiepNhan.HeaderText = "Ngày Tiếp Nhận"
        clNgTiepNhan.DataPropertyName = "NgTiepNhan"
        dgvTraCuu.Columns.Add(clNgTiepNhan)

        Dim clNoCuaDaiLy = New DataGridViewTextBoxColumn()
        clNoCuaDaiLy.Name = "NoCuaDaiLy"
        clNoCuaDaiLy.HeaderText = "Nợ Của Đại Lý"
        clNoCuaDaiLy.DataPropertyName = "NoCuaDaiLy"
        dgvTraCuu.Columns.Add(clNoCuaDaiLy)



        'test
        Dim clMaQuan = New DataGridViewTextBoxColumn()
        clMaQuan.Name = "MaQuan"
        clMaQuan.HeaderText = "Ma Quan"
        clMaQuan.DataPropertyName = "MaQuan"
        dgvTraCuu.Columns.Add(clMaQuan)
        'test
        Dim clMaLoaiDL = New DataGridViewTextBoxColumn()
        clMaLoaiDL.Name = "MaLoaiDL"
        clMaLoaiDL.HeaderText = "Ma Loai Dai Ly"
        clMaLoaiDL.DataPropertyName = "MaLoaiDL"
        dgvTraCuu.Columns.Add(clMaLoaiDL)
        '
    End Sub


    'load ten
    Private Sub load(ten As String) 'madaily As Integer, tendl As String,
        Dim listDaiLy = New List(Of DaiLyDTO)
        Dim result As Result
        result = dlBus.selectAll_Search(ten, listDaiLy)
        ' result = dlBus.nhap(madaily, tendl, maquan, maloaidl, listDaiLy)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách dai ly ko thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If


        dgvTraCuu.Columns.Clear()
        dgvTraCuu.DataSource = Nothing

        dgvTraCuu.AutoGenerateColumns = False
        dgvTraCuu.AllowUserToAddRows = False
        dgvTraCuu.DataSource = listDaiLy

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaDL"
        clMa.HeaderText = "Mã Đại Lý"
        clMa.DataPropertyName = "MaDL"
        dgvTraCuu.Columns.Add(clMa)

        Dim clLoaiHS = New DataGridView()


        Dim clTenDL = New DataGridViewTextBoxColumn()
        clTenDL.Name = "TenDL"
        clTenDL.HeaderText = "Tên Đại Lý"
        clTenDL.DataPropertyName = "TenDL"
        dgvTraCuu.Columns.Add(clTenDL)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvTraCuu.Columns.Add(clDiaChi)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        dgvTraCuu.Columns.Add(clEmail)



        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "DienThoai"
        clDienThoai.HeaderText = "Điện Thoại"
        clDienThoai.DataPropertyName = "DienThoai"
        dgvTraCuu.Columns.Add(clDienThoai)


        Dim clNgTiepNhan = New DataGridViewTextBoxColumn()
        clNgTiepNhan.Name = "NgTiepNhan"
        clNgTiepNhan.HeaderText = "Ngày Tiếp Nhận"
        clNgTiepNhan.DataPropertyName = "NgTiepNhan"
        dgvTraCuu.Columns.Add(clNgTiepNhan)

        Dim clNoCuaDaiLy = New DataGridViewTextBoxColumn()
        clNoCuaDaiLy.Name = "NoCuaDaiLy"
        clNoCuaDaiLy.HeaderText = "Nợ Của Đại Lý"
        clNoCuaDaiLy.DataPropertyName = "NoCuaDaiLy"
        dgvTraCuu.Columns.Add(clNoCuaDaiLy)



        'test
        Dim clMaQuan = New DataGridViewTextBoxColumn()
        clMaQuan.Name = "MaQuan"
        clMaQuan.HeaderText = "Ma Quan"
        clMaQuan.DataPropertyName = "MaQuan"
        dgvTraCuu.Columns.Add(clMaQuan)
        'test
        Dim clMaLoaiDL = New DataGridViewTextBoxColumn()
        clMaLoaiDL.Name = "MaLoaiDL"
        clMaLoaiDL.HeaderText = "Ma Loai Dai Ly"
        clMaLoaiDL.DataPropertyName = "MaLoaiDL"
        dgvTraCuu.Columns.Add(clMaLoaiDL)
        '
    End Sub
    'load maquan
    Private Sub loadmaquan(maquan As Integer) 'madaily As Integer, tendl As String,
        Dim listDaiLy = New List(Of DaiLyDTO)
        Dim result As Result
        result = dlBus.search_maquan(maquan, listDaiLy)
        ' result = dlBus.nhap(madaily, tendl, maquan, maloaidl, listDaiLy)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách dai ly ko thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If


        dgvTraCuu.Columns.Clear()
        dgvTraCuu.DataSource = Nothing

        dgvTraCuu.AutoGenerateColumns = False
        dgvTraCuu.AllowUserToAddRows = False
        dgvTraCuu.DataSource = listDaiLy

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaDL"
        clMa.HeaderText = "Mã Đại Lý"
        clMa.DataPropertyName = "MaDL"
        dgvTraCuu.Columns.Add(clMa)

        Dim clLoaiHS = New DataGridView()

        Dim clTenDL = New DataGridViewTextBoxColumn()
        clTenDL.Name = "TenDL"
        clTenDL.HeaderText = "Tên Đại Lý"
        clTenDL.DataPropertyName = "TenDL"
        dgvTraCuu.Columns.Add(clTenDL)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvTraCuu.Columns.Add(clDiaChi)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        dgvTraCuu.Columns.Add(clEmail)

        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "DienThoai"
        clDienThoai.HeaderText = "Điện Thoại"
        clDienThoai.DataPropertyName = "DienThoai"
        dgvTraCuu.Columns.Add(clDienThoai)

        Dim clNgTiepNhan = New DataGridViewTextBoxColumn()
        clNgTiepNhan.Name = "NgTiepNhan"
        clNgTiepNhan.HeaderText = "Ngày Tiếp Nhận"
        clNgTiepNhan.DataPropertyName = "NgTiepNhan"
        dgvTraCuu.Columns.Add(clNgTiepNhan)

        Dim clNoCuaDaiLy = New DataGridViewTextBoxColumn()
        clNoCuaDaiLy.Name = "NoCuaDaiLy"
        clNoCuaDaiLy.HeaderText = "Nợ Của Đại Lý"
        clNoCuaDaiLy.DataPropertyName = "NoCuaDaiLy"
        dgvTraCuu.Columns.Add(clNoCuaDaiLy)



        'test
        Dim clMaQuan = New DataGridViewTextBoxColumn()
        clMaQuan.Name = "MaQuan"
        clMaQuan.HeaderText = "Ma Quan"
        clMaQuan.DataPropertyName = "MaQuan"
        dgvTraCuu.Columns.Add(clMaQuan)
        'test
        Dim clMaLoaiDL = New DataGridViewTextBoxColumn()
        clMaLoaiDL.Name = "MaLoaiDL"
        clMaLoaiDL.HeaderText = "Ma Loai Dai Ly"
        clMaLoaiDL.DataPropertyName = "MaLoaiDL"
        dgvTraCuu.Columns.Add(clMaLoaiDL)
        '
    End Sub

    'load laoi dl
    Private Sub loadloaidl(loaidl As String) 'madaily As Integer, tendl As String,
        Dim listDaiLy = New List(Of DaiLyDTO)
        Dim result As Result
        result = dlBus.search_loaimadl(loaidl, listDaiLy)
        ' result = dlBus.nhap(madaily, tendl, maquan, maloaidl, listDaiLy)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách dai ly ko thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvTraCuu.Columns.Clear()
        dgvTraCuu.DataSource = Nothing

        dgvTraCuu.AutoGenerateColumns = False
        dgvTraCuu.AllowUserToAddRows = False
        dgvTraCuu.DataSource = listDaiLy

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaDL"
        clMa.HeaderText = "Mã Đại Lý"
        clMa.DataPropertyName = "MaDL"
        dgvTraCuu.Columns.Add(clMa)

        Dim clLoaiHS = New DataGridView()
        'clLoaiHS.Name = "LoaiHS"
        'clLoaiHS.HeaderText = "Tên Loại"
        'clLoaiHS.DataPropertyName = "LoaiHS"
        'dgvListHS.Columns.Add(clLoaiHS)

        Dim clTenDL = New DataGridViewTextBoxColumn()
        clTenDL.Name = "TenDL"
        clTenDL.HeaderText = "Tên Đại Lý"
        clTenDL.DataPropertyName = "TenDL"
        dgvTraCuu.Columns.Add(clTenDL)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvTraCuu.Columns.Add(clDiaChi)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        dgvTraCuu.Columns.Add(clEmail)
        'dgvListHS.ResumeLayout()


        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "DienThoai"
        clDienThoai.HeaderText = "Điện Thoại"
        clDienThoai.DataPropertyName = "DienThoai"
        dgvTraCuu.Columns.Add(clDienThoai)
        'dgvListHS.ResumeLayout()

        Dim clNgTiepNhan = New DataGridViewTextBoxColumn()
        clNgTiepNhan.Name = "NgTiepNhan"
        clNgTiepNhan.HeaderText = "Ngày Tiếp Nhận"
        clNgTiepNhan.DataPropertyName = "NgTiepNhan"
        dgvTraCuu.Columns.Add(clNgTiepNhan)

        Dim clNoCuaDaiLy = New DataGridViewTextBoxColumn()
        clNoCuaDaiLy.Name = "NoCuaDaiLy"
        clNoCuaDaiLy.HeaderText = "Nợ Của Đại Lý"
        clNoCuaDaiLy.DataPropertyName = "NoCuaDaiLy"
        dgvTraCuu.Columns.Add(clNoCuaDaiLy)



        'test
        Dim clMaQuan = New DataGridViewTextBoxColumn()
        clMaQuan.Name = "MaQuan"
        clMaQuan.HeaderText = "Ma Quan"
        clMaQuan.DataPropertyName = "MaQuan"
        dgvTraCuu.Columns.Add(clMaQuan)
        'test
        Dim clMaLoaiDL = New DataGridViewTextBoxColumn()
        clMaLoaiDL.Name = "MaLoaiDL"
        clMaLoaiDL.HeaderText = "Ma Loai Dai Ly"
        clMaLoaiDL.DataPropertyName = "MaLoaiDL"
        dgvTraCuu.Columns.Add(clMaLoaiDL)
        '
    End Sub

    'load ten va quan

    Private Sub load_ten_quan(ten As String, quan As Integer) 'madaily As Integer, tendl As String,
        Dim listDaiLy = New List(Of DaiLyDTO)
        Dim result As Result
        result = dlBus.search_ten_quan(ten, quan, listDaiLy)
        ' result = dlBus.nhap(madaily, tendl, maquan, maloaidl, listDaiLy)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách dai ly ko thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvTraCuu.Columns.Clear()
        dgvTraCuu.DataSource = Nothing

        dgvTraCuu.AutoGenerateColumns = False
        dgvTraCuu.AllowUserToAddRows = False
        dgvTraCuu.DataSource = listDaiLy

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaDL"
        clMa.HeaderText = "Mã Đại Lý"
        clMa.DataPropertyName = "MaDL"
        dgvTraCuu.Columns.Add(clMa)

        Dim clLoaiHS = New DataGridView()
        'clLoaiHS.Name = "LoaiHS"
        'clLoaiHS.HeaderText = "Tên Loại"
        'clLoaiHS.DataPropertyName = "LoaiHS"
        'dgvListHS.Columns.Add(clLoaiHS)

        Dim clTenDL = New DataGridViewTextBoxColumn()
        clTenDL.Name = "TenDL"
        clTenDL.HeaderText = "Tên Đại Lý"
        clTenDL.DataPropertyName = "TenDL"
        dgvTraCuu.Columns.Add(clTenDL)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvTraCuu.Columns.Add(clDiaChi)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        dgvTraCuu.Columns.Add(clEmail)
        'dgvListHS.ResumeLayout()


        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "DienThoai"
        clDienThoai.HeaderText = "Điện Thoại"
        clDienThoai.DataPropertyName = "DienThoai"
        dgvTraCuu.Columns.Add(clDienThoai)
        'dgvListHS.ResumeLayout()

        Dim clNgTiepNhan = New DataGridViewTextBoxColumn()
        clNgTiepNhan.Name = "NgTiepNhan"
        clNgTiepNhan.HeaderText = "Ngày Tiếp Nhận"
        clNgTiepNhan.DataPropertyName = "NgTiepNhan"
        dgvTraCuu.Columns.Add(clNgTiepNhan)

        Dim clNoCuaDaiLy = New DataGridViewTextBoxColumn()
        clNoCuaDaiLy.Name = "NoCuaDaiLy"
        clNoCuaDaiLy.HeaderText = "Nợ Của Đại Lý"
        clNoCuaDaiLy.DataPropertyName = "NoCuaDaiLy"
        dgvTraCuu.Columns.Add(clNoCuaDaiLy)



        'test
        Dim clMaQuan = New DataGridViewTextBoxColumn()
        clMaQuan.Name = "MaQuan"
        clMaQuan.HeaderText = "Ma Quan"
        clMaQuan.DataPropertyName = "MaQuan"
        dgvTraCuu.Columns.Add(clMaQuan)
        'test
        Dim clMaLoaiDL = New DataGridViewTextBoxColumn()
        clMaLoaiDL.Name = "MaLoaiDL"
        clMaLoaiDL.HeaderText = "Ma Loai Dai Ly"
        clMaLoaiDL.DataPropertyName = "MaLoaiDL"
        dgvTraCuu.Columns.Add(clMaLoaiDL)
        '
    End Sub
    'load ten va loai dl
    Private Sub load_ten_loaidl(ten As String, loaidl As Integer) 'madaily As Integer, tendl As String,
        Dim listDaiLy = New List(Of DaiLyDTO)
        Dim result As Result
        result = dlBus.search_ten_loaidl(ten, loaidl, listDaiLy)
        ' result = dlBus.nhap(madaily, tendl, maquan, maloaidl, listDaiLy)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách dai ly ko thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvTraCuu.Columns.Clear()
        dgvTraCuu.DataSource = Nothing

        dgvTraCuu.AutoGenerateColumns = False
        dgvTraCuu.AllowUserToAddRows = False
        dgvTraCuu.DataSource = listDaiLy

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaDL"
        clMa.HeaderText = "Mã Đại Lý"
        clMa.DataPropertyName = "MaDL"
        dgvTraCuu.Columns.Add(clMa)

        Dim clLoaiHS = New DataGridView()
        'clLoaiHS.Name = "LoaiHS"
        'clLoaiHS.HeaderText = "Tên Loại"
        'clLoaiHS.DataPropertyName = "LoaiHS"
        'dgvListHS.Columns.Add(clLoaiHS)

        Dim clTenDL = New DataGridViewTextBoxColumn()
        clTenDL.Name = "TenDL"
        clTenDL.HeaderText = "Tên Đại Lý"
        clTenDL.DataPropertyName = "TenDL"
        dgvTraCuu.Columns.Add(clTenDL)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvTraCuu.Columns.Add(clDiaChi)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        dgvTraCuu.Columns.Add(clEmail)
        'dgvListHS.ResumeLayout()


        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "DienThoai"
        clDienThoai.HeaderText = "Điện Thoại"
        clDienThoai.DataPropertyName = "DienThoai"
        dgvTraCuu.Columns.Add(clDienThoai)
        'dgvListHS.ResumeLayout()

        Dim clNgTiepNhan = New DataGridViewTextBoxColumn()
        clNgTiepNhan.Name = "NgTiepNhan"
        clNgTiepNhan.HeaderText = "Ngày Tiếp Nhận"
        clNgTiepNhan.DataPropertyName = "NgTiepNhan"
        dgvTraCuu.Columns.Add(clNgTiepNhan)

        Dim clNoCuaDaiLy = New DataGridViewTextBoxColumn()
        clNoCuaDaiLy.Name = "NoCuaDaiLy"
        clNoCuaDaiLy.HeaderText = "Nợ Của Đại Lý"
        clNoCuaDaiLy.DataPropertyName = "NoCuaDaiLy"
        dgvTraCuu.Columns.Add(clNoCuaDaiLy)



        'test
        Dim clMaQuan = New DataGridViewTextBoxColumn()
        clMaQuan.Name = "MaQuan"
        clMaQuan.HeaderText = "Ma Quan"
        clMaQuan.DataPropertyName = "MaQuan"
        dgvTraCuu.Columns.Add(clMaQuan)
        'test
        Dim clMaLoaiDL = New DataGridViewTextBoxColumn()
        clMaLoaiDL.Name = "MaLoaiDL"
        clMaLoaiDL.HeaderText = "Ma Loai Dai Ly"
        clMaLoaiDL.DataPropertyName = "MaLoaiDL"
        dgvTraCuu.Columns.Add(clMaLoaiDL)
        '
    End Sub

    Private Sub load_ten_quan_loaidl(ten As String, loaidl As Integer, quan As Integer) 'madaily As Integer, tendl As String,
        Dim listDaiLy = New List(Of DaiLyDTO)
        Dim result As Result
        result = dlBus.search_ten_loaidl_quan(ten, loaidl, quan, listDaiLy)
        ' result = dlBus.nhap(madaily, tendl, maquan, maloaidl, listDaiLy)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách dai ly ko thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvTraCuu.Columns.Clear()
        dgvTraCuu.DataSource = Nothing

        dgvTraCuu.AutoGenerateColumns = False
        dgvTraCuu.AllowUserToAddRows = False
        dgvTraCuu.DataSource = listDaiLy

        Dim clMa = New DataGridViewTextBoxColumn()
        clMa.Name = "MaDL"
        clMa.HeaderText = "Mã Đại Lý"
        clMa.DataPropertyName = "MaDL"
        dgvTraCuu.Columns.Add(clMa)

        Dim clLoaiHS = New DataGridView()
        'clLoaiHS.Name = "LoaiHS"
        'clLoaiHS.HeaderText = "Tên Loại"
        'clLoaiHS.DataPropertyName = "LoaiHS"
        'dgvListHS.Columns.Add(clLoaiHS)

        Dim clTenDL = New DataGridViewTextBoxColumn()
        clTenDL.Name = "TenDL"
        clTenDL.HeaderText = "Tên Đại Lý"
        clTenDL.DataPropertyName = "TenDL"
        dgvTraCuu.Columns.Add(clTenDL)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvTraCuu.Columns.Add(clDiaChi)

        Dim clEmail = New DataGridViewTextBoxColumn()
        clEmail.Name = "Email"
        clEmail.HeaderText = "Email"
        clEmail.DataPropertyName = "Email"
        dgvTraCuu.Columns.Add(clEmail)
        'dgvListHS.ResumeLayout()


        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "DienThoai"
        clDienThoai.HeaderText = "Điện Thoại"
        clDienThoai.DataPropertyName = "DienThoai"
        dgvTraCuu.Columns.Add(clDienThoai)
        'dgvListHS.ResumeLayout()

        Dim clNgTiepNhan = New DataGridViewTextBoxColumn()
        clNgTiepNhan.Name = "NgTiepNhan"
        clNgTiepNhan.HeaderText = "Ngày Tiếp Nhận"
        clNgTiepNhan.DataPropertyName = "NgTiepNhan"
        dgvTraCuu.Columns.Add(clNgTiepNhan)

        Dim clNoCuaDaiLy = New DataGridViewTextBoxColumn()
        clNoCuaDaiLy.Name = "NoCuaDaiLy"
        clNoCuaDaiLy.HeaderText = "Nợ Của Đại Lý"
        clNoCuaDaiLy.DataPropertyName = "NoCuaDaiLy"
        dgvTraCuu.Columns.Add(clNoCuaDaiLy)



        'test
        Dim clMaQuan = New DataGridViewTextBoxColumn()
        clMaQuan.Name = "MaQuan"
        clMaQuan.HeaderText = "Ma Quan"
        clMaQuan.DataPropertyName = "MaQuan"
        dgvTraCuu.Columns.Add(clMaQuan)
        'test
        Dim clMaLoaiDL = New DataGridViewTextBoxColumn()
        clMaLoaiDL.Name = "MaLoaiDL"
        clMaLoaiDL.HeaderText = "Ma Loai Dai Ly"
        clMaLoaiDL.DataPropertyName = "MaLoaiDL"
        dgvTraCuu.Columns.Add(clMaLoaiDL)
        '
    End Sub



























    Private Sub cbQuan_MouseClick(sender As Object, e As MouseEventArgs) Handles cbQuan.MouseClick
        Dim resultQuan As Result
        Dim listQuan = New List(Of QuanDTO)
        resultQuan = QuanBus.selectAll_no(listQuan)
        If (resultQuan.FlagResult = False) Then
            MessageBox.Show("Lấy danh loại Quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(resultQuan.SystemMessage)
            Return
        End If

        cbQuan.DataSource = New BindingSource(listQuan, String.Empty)
        cbQuan.DisplayMember = "TenQuan"
        cbQuan.ValueMember = "MaQuan"

    End Sub

    Private Sub cbQuan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbQuan.SelectedIndexChanged

    End Sub

    Private Sub cbLoaiDaiLy_MouseClick(sender As Object, e As MouseEventArgs) Handles cbLoaiDaiLy.MouseClick

        ' Load LoaiDaiLy list
        Dim listLoaiDaiLy = New List(Of LoaiDLDTO)
        Dim result As Result
        result = ldlBus.selectAll(listLoaiDaiLy)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại Đại Lý không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbLoaiDaiLy.DataSource = New BindingSource(listLoaiDaiLy, String.Empty)
        cbLoaiDaiLy.DisplayMember = "TenLoaiDl"
        cbLoaiDaiLy.ValueMember = "MaLoaiDL"
    End Sub




End Class