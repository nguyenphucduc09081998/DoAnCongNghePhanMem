<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemMatHang
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
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtMaMatHang = New System.Windows.Forms.TextBox()
        Me.txtTenMatHang = New System.Windows.Forms.TextBox()
        Me.txtSoLuongTon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Mặt Hàng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Mặt Hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 146)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Số Lượng Tồn"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(214, 197)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(104, 35)
        Me.btnThem.TabIndex = 3
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtMaMatHang
        '
        Me.txtMaMatHang.Location = New System.Drawing.Point(187, 73)
        Me.txtMaMatHang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMaMatHang.Name = "txtMaMatHang"
        Me.txtMaMatHang.Size = New System.Drawing.Size(201, 20)
        Me.txtMaMatHang.TabIndex = 4
        '
        'txtTenMatHang
        '
        Me.txtTenMatHang.Location = New System.Drawing.Point(187, 109)
        Me.txtTenMatHang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTenMatHang.Name = "txtTenMatHang"
        Me.txtTenMatHang.Size = New System.Drawing.Size(201, 20)
        Me.txtTenMatHang.TabIndex = 5
        '
        'txtSoLuongTon
        '
        Me.txtSoLuongTon.Location = New System.Drawing.Point(187, 142)
        Me.txtSoLuongTon.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSoLuongTon.Name = "txtSoLuongTon"
        Me.txtSoLuongTon.Size = New System.Drawing.Size(201, 20)
        Me.txtSoLuongTon.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(182, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Thêm Mặt Hàng"
        '
        'frmThemMatHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 285)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSoLuongTon)
        Me.Controls.Add(Me.txtTenMatHang)
        Me.Controls.Add(Me.txtMaMatHang)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmThemMatHang"
        Me.Text = "frmThemMatHang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents txtMaMatHang As TextBox
    Friend WithEvents txtTenMatHang As TextBox
    Friend WithEvents txtSoLuongTon As TextBox
    Friend WithEvents Label4 As Label
End Class
