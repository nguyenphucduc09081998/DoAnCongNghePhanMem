<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLPhieuXuat
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
        Me.cbMaDL = New System.Windows.Forms.ComboBox()
        Me.dgvlistPhieuXuat = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaPhieuXuat = New System.Windows.Forms.TextBox()
        Me.cbMaDaiLy = New System.Windows.Forms.ComboBox()
        Me.dtpNgayLapPhieu = New System.Windows.Forms.DateTimePicker()
        Me.txtTongGiaTri = New System.Windows.Forms.TextBox()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvlistPhieuXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Đại Lý"
        '
        'cbMaDL
        '
        Me.cbMaDL.FormattingEnabled = True
        Me.cbMaDL.Location = New System.Drawing.Point(88, 72)
        Me.cbMaDL.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbMaDL.Name = "cbMaDL"
        Me.cbMaDL.Size = New System.Drawing.Size(160, 21)
        Me.cbMaDL.TabIndex = 1
        '
        'dgvlistPhieuXuat
        '
        Me.dgvlistPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlistPhieuXuat.Location = New System.Drawing.Point(11, 110)
        Me.dgvlistPhieuXuat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvlistPhieuXuat.Name = "dgvlistPhieuXuat"
        Me.dgvlistPhieuXuat.RowTemplate.Height = 24
        Me.dgvlistPhieuXuat.Size = New System.Drawing.Size(568, 145)
        Me.dgvlistPhieuXuat.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 264)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mã Phiếu Xuất"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 264)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ngày Lập Phiếu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 302)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Mã Đại Lý"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(288, 302)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tổng Giá Trị"
        '
        'txtMaPhieuXuat
        '
        Me.txtMaPhieuXuat.Enabled = False
        Me.txtMaPhieuXuat.Location = New System.Drawing.Point(88, 262)
        Me.txtMaPhieuXuat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMaPhieuXuat.Name = "txtMaPhieuXuat"
        Me.txtMaPhieuXuat.Size = New System.Drawing.Size(193, 20)
        Me.txtMaPhieuXuat.TabIndex = 7
        '
        'cbMaDaiLy
        '
        Me.cbMaDaiLy.FormattingEnabled = True
        Me.cbMaDaiLy.Location = New System.Drawing.Point(88, 302)
        Me.cbMaDaiLy.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbMaDaiLy.Name = "cbMaDaiLy"
        Me.cbMaDaiLy.Size = New System.Drawing.Size(193, 21)
        Me.cbMaDaiLy.TabIndex = 8
        '
        'dtpNgayLapPhieu
        '
        Me.dtpNgayLapPhieu.Location = New System.Drawing.Point(387, 260)
        Me.dtpNgayLapPhieu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu"
        Me.dtpNgayLapPhieu.Size = New System.Drawing.Size(193, 20)
        Me.dtpNgayLapPhieu.TabIndex = 9
        '
        'txtTongGiaTri
        '
        Me.txtTongGiaTri.Location = New System.Drawing.Point(387, 302)
        Me.txtTongGiaTri.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTongGiaTri.Name = "txtTongGiaTri"
        Me.txtTongGiaTri.Size = New System.Drawing.Size(193, 20)
        Me.txtTongGiaTri.TabIndex = 10
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(122, 325)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(92, 40)
        Me.btnCapNhat.TabIndex = 11
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(387, 325)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(92, 40)
        Me.btnXoa.TabIndex = 12
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(187, 29)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 26)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Quản Lí Phiếu Xuất"
        '
        'frmQLPhieuXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 375)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtTongGiaTri)
        Me.Controls.Add(Me.dtpNgayLapPhieu)
        Me.Controls.Add(Me.cbMaDaiLy)
        Me.Controls.Add(Me.txtMaPhieuXuat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvlistPhieuXuat)
        Me.Controls.Add(Me.cbMaDL)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmQLPhieuXuat"
        Me.Text = "frmQLPhieuXuat"
        CType(Me.dgvlistPhieuXuat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbMaDL As ComboBox
    Friend WithEvents dgvlistPhieuXuat As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMaPhieuXuat As TextBox
    Friend WithEvents cbMaDaiLy As ComboBox
    Friend WithEvents dtpNgayLapPhieu As DateTimePicker
    Friend WithEvents txtTongGiaTri As TextBox
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents Label6 As Label
End Class
