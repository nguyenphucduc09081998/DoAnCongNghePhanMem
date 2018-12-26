<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemDonViTinh
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
        Me.txtMaDonViTinh = New System.Windows.Forms.TextBox()
        Me.txtTenDonViTinh = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Đơn Vị Tính"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Đơn Vị Tính"
        '
        'txtMaDonViTinh
        '
        Me.txtMaDonViTinh.Location = New System.Drawing.Point(165, 54)
        Me.txtMaDonViTinh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMaDonViTinh.Name = "txtMaDonViTinh"
        Me.txtMaDonViTinh.Size = New System.Drawing.Size(192, 20)
        Me.txtMaDonViTinh.TabIndex = 2
        '
        'txtTenDonViTinh
        '
        Me.txtTenDonViTinh.Location = New System.Drawing.Point(165, 87)
        Me.txtTenDonViTinh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTenDonViTinh.Name = "txtTenDonViTinh"
        Me.txtTenDonViTinh.Size = New System.Drawing.Size(192, 20)
        Me.txtTenDonViTinh.TabIndex = 3
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(165, 144)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 27)
        Me.btnThem.TabIndex = 4
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(178, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 26)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Thêm Đơn Vị Tính"
        '
        'frmThemDonViTinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 194)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtTenDonViTinh)
        Me.Controls.Add(Me.txtMaDonViTinh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmThemDonViTinh"
        Me.Text = "frmThemDonViTinh"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaDonViTinh As TextBox
    Friend WithEvents txtTenDonViTinh As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents Label3 As Label
End Class
