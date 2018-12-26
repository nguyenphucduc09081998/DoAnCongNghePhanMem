<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLBCCongNo
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
        Me.dgvBaoCaoCongNo = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.cbMaDLT = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvBaoCaoCongNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBaoCaoCongNo
        '
        Me.dgvBaoCaoCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBaoCaoCongNo.Location = New System.Drawing.Point(12, 91)
        Me.dgvBaoCaoCongNo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvBaoCaoCongNo.Name = "dgvBaoCaoCongNo"
        Me.dgvBaoCaoCongNo.RowTemplate.Height = 24
        Me.dgvBaoCaoCongNo.Size = New System.Drawing.Size(547, 167)
        Me.dgvBaoCaoCongNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tháng"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(241, 294)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(84, 35)
        Me.btnCapNhat.TabIndex = 7
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'cbMaDLT
        '
        Me.cbMaDLT.FormattingEnabled = True
        Me.cbMaDLT.Location = New System.Drawing.Point(95, 58)
        Me.cbMaDLT.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbMaDLT.Name = "cbMaDLT"
        Me.cbMaDLT.Size = New System.Drawing.Size(123, 21)
        Me.cbMaDLT.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(134, 19)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(271, 26)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Quản Lí Báo Cáo Công Nợ"
        '
        'frmQLBCCongNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 335)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbMaDLT)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.dgvBaoCaoCongNo)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmQLBCCongNo"
        Me.Text = "frmQLBCCongNo"
        CType(Me.dgvBaoCaoCongNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBaoCaoCongNo As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents cbMaDLT As ComboBox
    Friend WithEvents Label7 As Label
End Class
