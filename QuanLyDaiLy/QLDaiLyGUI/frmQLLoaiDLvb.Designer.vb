<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLLoaiDLvb
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
        Me.label = New System.Windows.Forms.Label()
        Me.dgvDoanhSachLoaiDL = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaLoaiDL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNoToiDa = New System.Windows.Forms.TextBox()
        Me.cbmTenLoaiDL = New System.Windows.Forms.ComboBox()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvDoanhSachLoaiDL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(172, 62)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(153, 17)
        Me.label.TabIndex = 0
        Me.label.Text = "Danh Sách Loại Đại Lý"
        '
        'dgvDoanhSachLoaiDL
        '
        Me.dgvDoanhSachLoaiDL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDoanhSachLoaiDL.Location = New System.Drawing.Point(35, 82)
        Me.dgvDoanhSachLoaiDL.Name = "dgvDoanhSachLoaiDL"
        Me.dgvDoanhSachLoaiDL.RowTemplate.Height = 24
        Me.dgvDoanhSachLoaiDL.Size = New System.Drawing.Size(420, 214)
        Me.dgvDoanhSachLoaiDL.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(497, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mã Loại Đại Lý"
        '
        'txtMaLoaiDL
        '
        Me.txtMaLoaiDL.Location = New System.Drawing.Point(621, 93)
        Me.txtMaLoaiDL.Name = "txtMaLoaiDL"
        Me.txtMaLoaiDL.Size = New System.Drawing.Size(235, 22)
        Me.txtMaLoaiDL.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(500, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tên Loại Đại Lý"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(497, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nợ Tối Đa"
        '
        'txtNoToiDa
        '
        Me.txtNoToiDa.Location = New System.Drawing.Point(621, 241)
        Me.txtNoToiDa.Name = "txtNoToiDa"
        Me.txtNoToiDa.Size = New System.Drawing.Size(235, 22)
        Me.txtNoToiDa.TabIndex = 7
        '
        'cbmTenLoaiDL
        '
        Me.cbmTenLoaiDL.FormattingEnabled = True
        Me.cbmTenLoaiDL.Location = New System.Drawing.Point(621, 168)
        Me.cbmTenLoaiDL.Name = "cbmTenLoaiDL"
        Me.cbmTenLoaiDL.Size = New System.Drawing.Size(235, 24)
        Me.cbmTenLoaiDL.TabIndex = 8
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(175, 341)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(150, 53)
        Me.btnCapNhat.TabIndex = 9
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(500, 341)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(150, 53)
        Me.btnXoa.TabIndex = 10
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(257, 32)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Quản Lí Loại Đại Lí"
        '
        'frmQLLoaiDLvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 417)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.cbmTenLoaiDL)
        Me.Controls.Add(Me.txtNoToiDa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMaLoaiDL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDoanhSachLoaiDL)
        Me.Controls.Add(Me.label)
        Me.Name = "frmQLLoaiDLvb"
        Me.Text = "frmQLLoaiDLvb"
        CType(Me.dgvDoanhSachLoaiDL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label As Label
    Friend WithEvents dgvDoanhSachLoaiDL As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaLoaiDL As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNoToiDa As TextBox
    Friend WithEvents cbmTenLoaiDL As ComboBox
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents Label4 As Label
End Class
