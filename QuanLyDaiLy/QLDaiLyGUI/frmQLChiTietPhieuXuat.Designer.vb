<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLChiTietPhieuXuat
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
        Me.dgvdanhsachchitietpx = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.txtMaChiTietPhieu = New System.Windows.Forms.TextBox()
        Me.txtSoLuongXuat = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txtThanhTien = New System.Windows.Forms.TextBox()
        Me.cbMaPhieuXuatD = New System.Windows.Forms.ComboBox()
        Me.cbMaMatHang = New System.Windows.Forms.ComboBox()
        Me.cbMaDonViTinh = New System.Windows.Forms.ComboBox()
        Me.cbMaPhieuXuatT = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgvdanhsachchitietpx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Phiếu Xuất"
        '
        'dgvdanhsachchitietpx
        '
        Me.dgvdanhsachchitietpx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdanhsachchitietpx.Location = New System.Drawing.Point(9, 96)
        Me.dgvdanhsachchitietpx.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvdanhsachchitietpx.Name = "dgvdanhsachchitietpx"
        Me.dgvdanhsachchitietpx.RowTemplate.Height = 24
        Me.dgvdanhsachchitietpx.Size = New System.Drawing.Size(703, 122)
        Me.dgvdanhsachchitietpx.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 231)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mã Chi Tiết Phiếu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 288)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mã Phiếu Xuất"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 324)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Mã Mặt Hàng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(360, 280)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Số Lượng Xuất"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(374, 321)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Đơn Giá"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(367, 362)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Thành Tiền"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 361)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Mã Đơn Vị Tính"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(127, 407)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(105, 44)
        Me.btnCapNhat.TabIndex = 9
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(369, 407)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(105, 44)
        Me.btnXoa.TabIndex = 10
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'txtMaChiTietPhieu
        '
        Me.txtMaChiTietPhieu.Enabled = False
        Me.txtMaChiTietPhieu.Location = New System.Drawing.Point(127, 231)
        Me.txtMaChiTietPhieu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMaChiTietPhieu.Name = "txtMaChiTietPhieu"
        Me.txtMaChiTietPhieu.Size = New System.Drawing.Size(152, 20)
        Me.txtMaChiTietPhieu.TabIndex = 11
        '
        'txtSoLuongXuat
        '
        Me.txtSoLuongXuat.Location = New System.Drawing.Point(464, 275)
        Me.txtSoLuongXuat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSoLuongXuat.Name = "txtSoLuongXuat"
        Me.txtSoLuongXuat.Size = New System.Drawing.Size(152, 20)
        Me.txtSoLuongXuat.TabIndex = 12
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(464, 320)
        Me.txtDonGia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(152, 20)
        Me.txtDonGia.TabIndex = 13
        '
        'txtThanhTien
        '
        Me.txtThanhTien.Location = New System.Drawing.Point(464, 358)
        Me.txtThanhTien.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtThanhTien.Name = "txtThanhTien"
        Me.txtThanhTien.Size = New System.Drawing.Size(152, 20)
        Me.txtThanhTien.TabIndex = 14
        '
        'cbMaPhieuXuatD
        '
        Me.cbMaPhieuXuatD.FormattingEnabled = True
        Me.cbMaPhieuXuatD.Location = New System.Drawing.Point(127, 274)
        Me.cbMaPhieuXuatD.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbMaPhieuXuatD.Name = "cbMaPhieuXuatD"
        Me.cbMaPhieuXuatD.Size = New System.Drawing.Size(152, 21)
        Me.cbMaPhieuXuatD.TabIndex = 15
        '
        'cbMaMatHang
        '
        Me.cbMaMatHang.FormattingEnabled = True
        Me.cbMaMatHang.Location = New System.Drawing.Point(127, 318)
        Me.cbMaMatHang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbMaMatHang.Name = "cbMaMatHang"
        Me.cbMaMatHang.Size = New System.Drawing.Size(152, 21)
        Me.cbMaMatHang.TabIndex = 16
        '
        'cbMaDonViTinh
        '
        Me.cbMaDonViTinh.FormattingEnabled = True
        Me.cbMaDonViTinh.Location = New System.Drawing.Point(127, 358)
        Me.cbMaDonViTinh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbMaDonViTinh.Name = "cbMaDonViTinh"
        Me.cbMaDonViTinh.Size = New System.Drawing.Size(152, 21)
        Me.cbMaDonViTinh.TabIndex = 17
        '
        'cbMaPhieuXuatT
        '
        Me.cbMaPhieuXuatT.FormattingEnabled = True
        Me.cbMaPhieuXuatT.Location = New System.Drawing.Point(127, 64)
        Me.cbMaPhieuXuatT.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbMaPhieuXuatT.Name = "cbMaPhieuXuatT"
        Me.cbMaPhieuXuatT.Size = New System.Drawing.Size(152, 21)
        Me.cbMaPhieuXuatT.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(208, 20)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(281, 26)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Quản Lí Chi Tiết Phiếu Xuất"
        '
        'frmQLChiTietPhieuXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 472)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbMaPhieuXuatT)
        Me.Controls.Add(Me.cbMaDonViTinh)
        Me.Controls.Add(Me.cbMaMatHang)
        Me.Controls.Add(Me.cbMaPhieuXuatD)
        Me.Controls.Add(Me.txtThanhTien)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtSoLuongXuat)
        Me.Controls.Add(Me.txtMaChiTietPhieu)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvdanhsachchitietpx)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmQLChiTietPhieuXuat"
        Me.Text = "frmQLChiTietPhieuXuat"
        CType(Me.dgvdanhsachchitietpx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvdanhsachchitietpx As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents txtMaChiTietPhieu As TextBox
    Friend WithEvents txtSoLuongXuat As TextBox
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents txtThanhTien As TextBox
    Friend WithEvents cbMaPhieuXuatD As ComboBox
    Friend WithEvents cbMaMatHang As ComboBox
    Friend WithEvents cbMaDonViTinh As ComboBox
    Friend WithEvents cbMaPhieuXuatT As ComboBox
    Friend WithEvents Label9 As Label
End Class
