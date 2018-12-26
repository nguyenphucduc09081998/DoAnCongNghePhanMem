<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TraCuu
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
        Me.dgvTraCuu = New System.Windows.Forms.DataGridView()
        Me.cbQuan = New System.Windows.Forms.ComboBox()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbLoaiDaiLy = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTenDL = New System.Windows.Forms.TextBox()
        CType(Me.dgvTraCuu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(340, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tra Cứu Đại Lý"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quận"
        '
        'dgvTraCuu
        '
        Me.dgvTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTraCuu.Location = New System.Drawing.Point(12, 182)
        Me.dgvTraCuu.Name = "dgvTraCuu"
        Me.dgvTraCuu.RowTemplate.Height = 24
        Me.dgvTraCuu.Size = New System.Drawing.Size(921, 203)
        Me.dgvTraCuu.TabIndex = 3
        '
        'cbQuan
        '
        Me.cbQuan.FormattingEnabled = True
        Me.cbQuan.Location = New System.Drawing.Point(114, 110)
        Me.cbQuan.Name = "cbQuan"
        Me.cbQuan.Size = New System.Drawing.Size(167, 24)
        Me.cbQuan.TabIndex = 4
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(379, 391)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(174, 70)
        Me.btnTimKiem.TabIndex = 5
        Me.btnTimKiem.Text = "Tìm Kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(373, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Loại Đại Lý"
        '
        'cbLoaiDaiLy
        '
        Me.cbLoaiDaiLy.FormattingEnabled = True
        Me.cbLoaiDaiLy.Location = New System.Drawing.Point(496, 110)
        Me.cbLoaiDaiLy.Name = "cbLoaiDaiLy"
        Me.cbLoaiDaiLy.Size = New System.Drawing.Size(173, 24)
        Me.cbLoaiDaiLy.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(204, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tên Đại Lý"
        '
        'txtTenDL
        '
        Me.txtTenDL.Location = New System.Drawing.Point(346, 62)
        Me.txtTenDL.Name = "txtTenDL"
        Me.txtTenDL.Size = New System.Drawing.Size(219, 22)
        Me.txtTenDL.TabIndex = 11
        '
        'TraCuu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 473)
        Me.Controls.Add(Me.txtTenDL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbLoaiDaiLy)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.cbQuan)
        Me.Controls.Add(Me.dgvTraCuu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TraCuu"
        Me.Text = "TraCuu"
        CType(Me.dgvTraCuu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvTraCuu As DataGridView
    Friend WithEvents cbQuan As ComboBox
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cbLoaiDaiLy As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTenDL As TextBox
End Class
