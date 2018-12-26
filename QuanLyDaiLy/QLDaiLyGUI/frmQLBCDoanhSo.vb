Imports System.Configuration
Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility



Public Class frmQLBCDoanhSo
    Private baoCaoDoanhSoBus As BaoCaoDoanhSoBUS
    Dim listBaoCaoDoanhSo = New List(Of BaoCaoDoanhSoDTO)
    Dim listThang = New List(Of Integer)
    Dim SelectedMonth As Integer

    Private Sub frmBaoCaoDoanhSo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        baoCaoDoanhSoBus = New BaoCaoDoanhSoBUS()
        baoCaoDoanhSoBus.GetAllMonthHaveData(listThang)


        For i As Integer = 0 To listThang.Count - 1
            cbThang.Items.Add(listThang(i))
        Next



    End Sub

    Private Sub cbThang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbThang.SelectedIndexChanged
        baoCaoDoanhSoBus.GetDoanhSoByMonth(listBaoCaoDoanhSo, Int32.Parse(cbThang.SelectedItem))


        dgvBaoCao.Columns.Clear()
        dgvBaoCao.DataSource = Nothing

        dgvBaoCao.AutoGenerateColumns = False
        dgvBaoCao.AllowUserToAddRows = False
        dgvBaoCao.DataSource = listBaoCaoDoanhSo

        Dim clStt = New DataGridViewTextBoxColumn()
        clStt.Name = "stt"
        clStt.HeaderText = "STT"
        clStt.DataPropertyName = "Stt"
        dgvBaoCao.Columns.Add(clStt)

        Dim clTenDaiLy = New DataGridViewTextBoxColumn()
        clTenDaiLy.Name = "daiLy"
        clTenDaiLy.HeaderText = "Ð?i Lý"
        clTenDaiLy.DataPropertyName = "TenDaiLy"
        dgvBaoCao.Columns.Add(clTenDaiLy)

        Dim clSoPhieuXuat = New DataGridViewTextBoxColumn()
        clSoPhieuXuat.Name = "soPhieuXuat"
        clSoPhieuXuat.HeaderText = "Số phiếu xuất"
        clSoPhieuXuat.DataPropertyName = "SoPhieuXuat"
        dgvBaoCao.Columns.Add(clSoPhieuXuat)

        Dim clTongGiaTri = New DataGridViewTextBoxColumn()
        clTongGiaTri.Name = "tongTriGia"
        clTongGiaTri.HeaderText = "Tổng trị giá"
        clTongGiaTri.DataPropertyName = "TongTriGia"
        dgvBaoCao.Columns.Add(clTongGiaTri)

        Dim clTyLe = New DataGridViewTextBoxColumn()
        clTyLe.Name = "tyLe"
        clTyLe.HeaderText = "Tỉ lệ"
        clTyLe.DataPropertyName = "TyLe"
        dgvBaoCao.Columns.Add(clTyLe)


    End Sub
End Class