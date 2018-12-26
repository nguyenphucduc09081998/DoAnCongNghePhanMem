<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuXuat
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtMaPhieuXuat = New System.Windows.Forms.TextBox()
        Me.cbMaDL = New System.Windows.Forms.ComboBox()
        Me.txtTongGiaTri = New System.Windows.Forms.TextBox()
        Me.dtpNgayLapPhieu = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phiếu Xuất"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Đại Lý"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(398, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ngày Lập Phiếu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(398, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tổng Giá Trị"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(320, 165)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(126, 50)
        Me.btnThem.TabIndex = 4
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtMaPhieuXuat
        '
        Me.txtMaPhieuXuat.Enabled = False
        Me.txtMaPhieuXuat.Location = New System.Drawing.Point(136, 57)
        Me.txtMaPhieuXuat.Name = "txtMaPhieuXuat"
        Me.txtMaPhieuXuat.Size = New System.Drawing.Size(244, 22)
        Me.txtMaPhieuXuat.TabIndex = 5
        '
        'cbMaDL
        '
        Me.cbMaDL.FormattingEnabled = True
        Me.cbMaDL.Location = New System.Drawing.Point(136, 118)
        Me.cbMaDL.Name = "cbMaDL"
        Me.cbMaDL.Size = New System.Drawing.Size(244, 24)
        Me.cbMaDL.TabIndex = 6
        '
        'txtTongGiaTri
        '
        Me.txtTongGiaTri.Location = New System.Drawing.Point(529, 122)
        Me.txtTongGiaTri.Name = "txtTongGiaTri"
        Me.txtTongGiaTri.Size = New System.Drawing.Size(244, 22)
        Me.txtTongGiaTri.TabIndex = 7
        '
        'dtpNgayLapPhieu
        '
        Me.dtpNgayLapPhieu.Location = New System.Drawing.Point(529, 62)
        Me.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu"
        Me.dtpNgayLapPhieu.Size = New System.Drawing.Size(244, 22)
        Me.dtpNgayLapPhieu.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(273, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(234, 32)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Thêm Phiếu Xuất"
        '
        'frmPhieuXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 275)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpNgayLapPhieu)
        Me.Controls.Add(Me.txtTongGiaTri)
        Me.Controls.Add(Me.cbMaDL)
        Me.Controls.Add(Me.txtMaPhieuXuat)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPhieuXuat"
        Me.Text = "frmPhieuXuat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents txtMaPhieuXuat As TextBox
    Friend WithEvents cbMaDL As ComboBox
    Friend WithEvents txtTongGiaTri As TextBox
    Friend WithEvents dtpNgayLapPhieu As DateTimePicker
    Friend WithEvents Label5 As Label
End Class
