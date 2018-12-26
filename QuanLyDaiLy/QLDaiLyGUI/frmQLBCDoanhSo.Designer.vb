<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLBCDoanhSo
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
        Me.dgvBaoCao = New System.Windows.Forms.DataGridView()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.cbthang = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvBaoCao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 91)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tháng"
        '
        'dgvBaoCao
        '
        Me.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBaoCao.Location = New System.Drawing.Point(12, 125)
        Me.dgvBaoCao.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvBaoCao.Name = "dgvBaoCao"
        Me.dgvBaoCao.RowTemplate.Height = 24
        Me.dgvBaoCao.Size = New System.Drawing.Size(471, 158)
        Me.dgvBaoCao.TabIndex = 2
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(209, 296)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(85, 38)
        Me.btnCapNhat.TabIndex = 7
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'cbthang
        '
        Me.cbthang.FormattingEnabled = True
        Me.cbthang.Location = New System.Drawing.Point(118, 89)
        Me.cbthang.Margin = New System.Windows.Forms.Padding(2)
        Me.cbthang.Name = "cbthang"
        Me.cbthang.Size = New System.Drawing.Size(138, 21)
        Me.cbthang.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(110, 32)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(282, 26)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Quản Lí Báo Cáo Doanh Sô"
        '
        'frmQLBCDoanhSo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 361)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbthang)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.dgvBaoCao)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmQLBCDoanhSo"
        Me.Text = "frmQLBCDoanhSo"
        CType(Me.dgvBaoCao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvBaoCao As DataGridView
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents cbthang As ComboBox
    Friend WithEvents Label7 As Label
End Class
