<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLDonViTinh
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
        Me.dgvDanhSachDonViTinh = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaDonViTinh = New System.Windows.Forms.TextBox()
        Me.txtTenDonViTinh = New System.Windows.Forms.TextBox()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvDanhSachDonViTinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Danh Sách Đơn Vị Tính"
        '
        'dgvDanhSachDonViTinh
        '
        Me.dgvDanhSachDonViTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachDonViTinh.Location = New System.Drawing.Point(9, 123)
        Me.dgvDanhSachDonViTinh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvDanhSachDonViTinh.Name = "dgvDanhSachDonViTinh"
        Me.dgvDanhSachDonViTinh.RowTemplate.Height = 24
        Me.dgvDanhSachDonViTinh.Size = New System.Drawing.Size(324, 136)
        Me.dgvDanhSachDonViTinh.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(352, 204)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mã Đơn Vị Tính"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(341, 241)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tên Đơn Vị Tính"
        '
        'txtMaDonViTinh
        '
        Me.txtMaDonViTinh.Enabled = False
        Me.txtMaDonViTinh.Location = New System.Drawing.Point(435, 200)
        Me.txtMaDonViTinh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMaDonViTinh.Name = "txtMaDonViTinh"
        Me.txtMaDonViTinh.Size = New System.Drawing.Size(146, 20)
        Me.txtMaDonViTinh.TabIndex = 4
        '
        'txtTenDonViTinh
        '
        Me.txtTenDonViTinh.Location = New System.Drawing.Point(435, 241)
        Me.txtTenDonViTinh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTenDonViTinh.Name = "txtTenDonViTinh"
        Me.txtTenDonViTinh.Size = New System.Drawing.Size(146, 20)
        Me.txtTenDonViTinh.TabIndex = 5
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(142, 280)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(82, 28)
        Me.btnCapNhat.TabIndex = 6
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(338, 280)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(82, 28)
        Me.btnXoa.TabIndex = 7
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(206, 40)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 26)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Quản Lí Đơn Vị Tính"
        '
        'frmQLDonViTinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 332)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtTenDonViTinh)
        Me.Controls.Add(Me.txtMaDonViTinh)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvDanhSachDonViTinh)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmQLDonViTinh"
        Me.Text = "frmQLDonViTinh"
        CType(Me.dgvDanhSachDonViTinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachDonViTinh As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaDonViTinh As TextBox
    Friend WithEvents txtTenDonViTinh As TextBox
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents Label4 As Label
End Class
