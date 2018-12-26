<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQLPhieuThuTien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDanhSachPhieuThuTien = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.cbMaDLT = New System.Windows.Forms.ComboBox()
        Me.cbMaDLD = New System.Windows.Forms.ComboBox()
        Me.txtMaPhieuThu = New System.Windows.Forms.TextBox()
        Me.txtSoTienThu = New System.Windows.Forms.TextBox()
        Me.dtpNgayThuTien = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvDanhSachPhieuThuTien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Đại Lý"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Phiếu Thu Tiền"
        '
        'dgvDanhSachPhieuThuTien
        '
        Me.dgvDanhSachPhieuThuTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachPhieuThuTien.Location = New System.Drawing.Point(16, 122)
        Me.dgvDanhSachPhieuThuTien.Name = "dgvDanhSachPhieuThuTien"
        Me.dgvDanhSachPhieuThuTien.RowTemplate.Height = 24
        Me.dgvDanhSachPhieuThuTien.Size = New System.Drawing.Size(827, 172)
        Me.dgvDanhSachPhieuThuTien.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 363)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mã Đại Lý"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(444, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Ngày Thu Tiền"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(444, 363)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Số Tiền Thu"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(180, 390)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(122, 50)
        Me.btnCapNhat.TabIndex = 6
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(558, 390)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(122, 50)
        Me.btnXoa.TabIndex = 7
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'cbMaDLT
        '
        Me.cbMaDLT.FormattingEnabled = True
        Me.cbMaDLT.Location = New System.Drawing.Point(151, 92)
        Me.cbMaDLT.Name = "cbMaDLT"
        Me.cbMaDLT.Size = New System.Drawing.Size(217, 24)
        Me.cbMaDLT.TabIndex = 8
        '
        'cbMaDLD
        '
        Me.cbMaDLD.FormattingEnabled = True
        Me.cbMaDLD.Location = New System.Drawing.Point(151, 360)
        Me.cbMaDLD.Name = "cbMaDLD"
        Me.cbMaDLD.Size = New System.Drawing.Size(247, 24)
        Me.cbMaDLD.TabIndex = 9
        '
        'txtMaPhieuThu
        '
        Me.txtMaPhieuThu.Location = New System.Drawing.Point(151, 316)
        Me.txtMaPhieuThu.Name = "txtMaPhieuThu"
        Me.txtMaPhieuThu.Size = New System.Drawing.Size(247, 22)
        Me.txtMaPhieuThu.TabIndex = 10
        '
        'txtSoTienThu
        '
        Me.txtSoTienThu.Location = New System.Drawing.Point(558, 360)
        Me.txtSoTienThu.Name = "txtSoTienThu"
        Me.txtSoTienThu.Size = New System.Drawing.Size(247, 22)
        Me.txtSoTienThu.TabIndex = 11
        '
        'dtpNgayThuTien
        '
        Me.dtpNgayThuTien.Location = New System.Drawing.Point(558, 316)
        Me.dtpNgayThuTien.Name = "dtpNgayThuTien"
        Me.dtpNgayThuTien.Size = New System.Drawing.Size(247, 22)
        Me.dtpNgayThuTien.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(265, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(315, 32)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Quản Lí Phiếu Thu Tiền"
        '
        'frmQLPhieuThuTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 452)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpNgayThuTien)
        Me.Controls.Add(Me.txtSoTienThu)
        Me.Controls.Add(Me.txtMaPhieuThu)
        Me.Controls.Add(Me.cbMaDLD)
        Me.Controls.Add(Me.cbMaDLT)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvDanhSachPhieuThuTien)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQLPhieuThuTien"
        Me.Text = "frmQLPhieuThuTien"
        CType(Me.dgvDanhSachPhieuThuTien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvDanhSachPhieuThuTien As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents cbMaDLT As ComboBox
    Friend WithEvents cbMaDLD As ComboBox
    Friend WithEvents txtMaPhieuThu As TextBox
    Friend WithEvents txtSoTienThu As TextBox
    Friend WithEvents dtpNgayThuTien As DateTimePicker
    Friend WithEvents Label6 As Label
End Class
