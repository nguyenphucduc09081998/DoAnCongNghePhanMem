<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLDaiLy
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbmLoaiDaiLy = New System.Windows.Forms.ComboBox()
        Me.dgvListDL = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.txtMaDaiLy = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.txtTenDaiLy = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtNoDaiLy = New System.Windows.Forms.TextBox()
        Me.cbmMaLoaiDL = New System.Windows.Forms.ComboBox()
        Me.cbmMaQuan = New System.Windows.Forms.ComboBox()
        Me.dtpNgTiepNhan = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvListDL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Loại Đại Lý"
        '
        'cbmLoaiDaiLy
        '
        Me.cbmLoaiDaiLy.FormattingEnabled = True
        Me.cbmLoaiDaiLy.Location = New System.Drawing.Point(108, 102)
        Me.cbmLoaiDaiLy.Name = "cbmLoaiDaiLy"
        Me.cbmLoaiDaiLy.Size = New System.Drawing.Size(237, 24)
        Me.cbmLoaiDaiLy.TabIndex = 2
        '
        'dgvListDL
        '
        Me.dgvListDL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListDL.Location = New System.Drawing.Point(108, 151)
        Me.dgvListDL.Name = "dgvListDL"
        Me.dgvListDL.RowTemplate.Height = 24
        Me.dgvListDL.Size = New System.Drawing.Size(870, 186)
        Me.dgvListDL.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 362)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mã Đại Lý"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(346, 362)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 404)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tên Đại Lý"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 446)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Loại Đại Lý"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(346, 404)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Địa Chỉ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(346, 446)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Quận"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(641, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Điện Thoại"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(648, 406)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 17)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Nợ Đại Lý"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(641, 442)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 17)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Ngày Tiếp Nhận"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(229, 477)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(161, 71)
        Me.btnCapNhat.TabIndex = 14
        Me.btnCapNhat.Text = "Cập Nhật Đại Lý"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(629, 477)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(161, 71)
        Me.btnXoa.TabIndex = 15
        Me.btnXoa.Text = "Xóa Đại Lý"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'txtMaDaiLy
        '
        Me.txtMaDaiLy.Location = New System.Drawing.Point(108, 357)
        Me.txtMaDaiLy.Name = "txtMaDaiLy"
        Me.txtMaDaiLy.Size = New System.Drawing.Size(219, 22)
        Me.txtMaDaiLy.TabIndex = 16
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(405, 357)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(219, 22)
        Me.txtEmail.TabIndex = 17
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(759, 357)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(219, 22)
        Me.txtDienThoai.TabIndex = 18
        '
        'txtTenDaiLy
        '
        Me.txtTenDaiLy.Location = New System.Drawing.Point(108, 401)
        Me.txtTenDaiLy.Name = "txtTenDaiLy"
        Me.txtTenDaiLy.Size = New System.Drawing.Size(219, 22)
        Me.txtTenDaiLy.TabIndex = 19
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(405, 399)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(219, 22)
        Me.txtDiaChi.TabIndex = 20
        '
        'txtNoDaiLy
        '
        Me.txtNoDaiLy.Location = New System.Drawing.Point(759, 399)
        Me.txtNoDaiLy.Name = "txtNoDaiLy"
        Me.txtNoDaiLy.Size = New System.Drawing.Size(219, 22)
        Me.txtNoDaiLy.TabIndex = 21
        '
        'cbmMaLoaiDL
        '
        Me.cbmMaLoaiDL.FormattingEnabled = True
        Me.cbmMaLoaiDL.Location = New System.Drawing.Point(108, 443)
        Me.cbmMaLoaiDL.Name = "cbmMaLoaiDL"
        Me.cbmMaLoaiDL.Size = New System.Drawing.Size(219, 24)
        Me.cbmMaLoaiDL.TabIndex = 22
        '
        'cbmMaQuan
        '
        Me.cbmMaQuan.FormattingEnabled = True
        Me.cbmMaQuan.Location = New System.Drawing.Point(405, 439)
        Me.cbmMaQuan.Name = "cbmMaQuan"
        Me.cbmMaQuan.Size = New System.Drawing.Size(219, 24)
        Me.cbmMaQuan.TabIndex = 23
        '
        'dtpNgTiepNhan
        '
        Me.dtpNgTiepNhan.Location = New System.Drawing.Point(759, 437)
        Me.dtpNgTiepNhan.Name = "dtpNgTiepNhan"
        Me.dtpNgTiepNhan.Size = New System.Drawing.Size(219, 22)
        Me.dtpNgTiepNhan.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(429, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 32)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Quản Lí Đại Lí"
        '
        'frmQLDaiLy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 560)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpNgTiepNhan)
        Me.Controls.Add(Me.cbmMaQuan)
        Me.Controls.Add(Me.cbmMaLoaiDL)
        Me.Controls.Add(Me.txtNoDaiLy)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtTenDaiLy)
        Me.Controls.Add(Me.txtDienThoai)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtMaDaiLy)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvListDL)
        Me.Controls.Add(Me.cbmLoaiDaiLy)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQLDaiLy"
        Me.Text = "frmQLDaiLy"
        CType(Me.dgvListDL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbmLoaiDaiLy As ComboBox
    Friend WithEvents dgvListDL As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents txtMaDaiLy As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDienThoai As TextBox
    Friend WithEvents txtTenDaiLy As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtNoDaiLy As TextBox
    Friend WithEvents cbmMaLoaiDL As ComboBox
    Friend WithEvents cbmMaQuan As ComboBox
    Friend WithEvents dtpNgTiepNhan As DateTimePicker
    Friend WithEvents Label2 As Label
End Class
