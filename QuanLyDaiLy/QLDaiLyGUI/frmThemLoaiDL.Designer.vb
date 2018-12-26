<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemLoaiDL
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
        Me.txtMaLoaiDL = New System.Windows.Forms.TextBox()
        Me.txtTenLoaiDL = New System.Windows.Forms.TextBox()
        Me.txtNoToiDa = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Loại Đại Lý"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Loại Đại Lý"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nợ Tối Đa"
        '
        'txtMaLoaiDL
        '
        Me.txtMaLoaiDL.Enabled = False
        Me.txtMaLoaiDL.Location = New System.Drawing.Point(177, 50)
        Me.txtMaLoaiDL.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMaLoaiDL.Name = "txtMaLoaiDL"
        Me.txtMaLoaiDL.Size = New System.Drawing.Size(167, 20)
        Me.txtMaLoaiDL.TabIndex = 3
        '
        'txtTenLoaiDL
        '
        Me.txtTenLoaiDL.Location = New System.Drawing.Point(177, 90)
        Me.txtTenLoaiDL.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTenLoaiDL.Name = "txtTenLoaiDL"
        Me.txtTenLoaiDL.Size = New System.Drawing.Size(167, 20)
        Me.txtTenLoaiDL.TabIndex = 4
        '
        'txtNoToiDa
        '
        Me.txtNoToiDa.Location = New System.Drawing.Point(177, 128)
        Me.txtNoToiDa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNoToiDa.Name = "txtNoToiDa"
        Me.txtNoToiDa.Size = New System.Drawing.Size(167, 20)
        Me.txtNoToiDa.TabIndex = 5
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(164, 169)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(67, 27)
        Me.btnThem.TabIndex = 6
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(96, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Thêm Loại Đại Lí"
        '
        'frmThemLoaiDL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 231)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtNoToiDa)
        Me.Controls.Add(Me.txtTenLoaiDL)
        Me.Controls.Add(Me.txtMaLoaiDL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmThemLoaiDL"
        Me.Text = "frmThemLoaiDL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaLoaiDL As TextBox
    Friend WithEvents txtTenLoaiDL As TextBox
    Friend WithEvents txtNoToiDa As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents Label4 As Label
End Class
