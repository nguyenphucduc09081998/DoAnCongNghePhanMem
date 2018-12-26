<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemPhieuThuTien
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
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMaPhieuThu = New System.Windows.Forms.TextBox()
        Me.txtSoTienThu = New System.Windows.Forms.TextBox()
        Me.cbMaDL = New System.Windows.Forms.ComboBox()
        Me.dtpNgayThuTien = New System.Windows.Forms.DateTimePicker()
        Me.txtNoCuaDaiLy = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(390, 160)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(103, 33)
        Me.btnThem.TabIndex = 0
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Phiếu Thu Tiền"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mã Đại Lý"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ngày Thu Tiền"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(302, 126)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Số Tiền Thu"
        '
        'txtMaPhieuThu
        '
        Me.txtMaPhieuThu.Location = New System.Drawing.Point(118, 41)
        Me.txtMaPhieuThu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMaPhieuThu.Name = "txtMaPhieuThu"
        Me.txtMaPhieuThu.Size = New System.Drawing.Size(174, 20)
        Me.txtMaPhieuThu.TabIndex = 5
        '
        'txtSoTienThu
        '
        Me.txtSoTienThu.Location = New System.Drawing.Point(390, 122)
        Me.txtSoTienThu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSoTienThu.Name = "txtSoTienThu"
        Me.txtSoTienThu.Size = New System.Drawing.Size(174, 20)
        Me.txtSoTienThu.TabIndex = 6
        '
        'cbMaDL
        '
        Me.cbMaDL.FormattingEnabled = True
        Me.cbMaDL.Location = New System.Drawing.Point(118, 83)
        Me.cbMaDL.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbMaDL.Name = "cbMaDL"
        Me.cbMaDL.Size = New System.Drawing.Size(174, 21)
        Me.cbMaDL.TabIndex = 7
        '
        'dtpNgayThuTien
        '
        Me.dtpNgayThuTien.Location = New System.Drawing.Point(390, 81)
        Me.dtpNgayThuTien.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpNgayThuTien.Name = "dtpNgayThuTien"
        Me.dtpNgayThuTien.Size = New System.Drawing.Size(174, 20)
        Me.dtpNgayThuTien.TabIndex = 8
        '
        'txtNoCuaDaiLy
        '
        Me.txtNoCuaDaiLy.Enabled = False
        Me.txtNoCuaDaiLy.Location = New System.Drawing.Point(118, 124)
        Me.txtNoCuaDaiLy.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNoCuaDaiLy.Name = "txtNoCuaDaiLy"
        Me.txtNoCuaDaiLy.Size = New System.Drawing.Size(174, 20)
        Me.txtNoCuaDaiLy.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 126)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Nợ Của Đại Lý"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(164, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(218, 26)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Thêm Phiếu Thu Tiền"
        '
        'frmThemPhieuThuTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 240)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNoCuaDaiLy)
        Me.Controls.Add(Me.dtpNgayThuTien)
        Me.Controls.Add(Me.cbMaDL)
        Me.Controls.Add(Me.txtSoTienThu)
        Me.Controls.Add(Me.txtMaPhieuThu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnThem)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmThemPhieuThuTien"
        Me.Text = "frmThemPhieuThuTien"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnThem As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMaPhieuThu As TextBox
    Friend WithEvents txtSoTienThu As TextBox
    Friend WithEvents cbMaDL As ComboBox
    Friend WithEvents dtpNgayThuTien As DateTimePicker
    Friend WithEvents txtNoCuaDaiLy As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
