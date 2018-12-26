Imports QLDaiLyBUS
Imports QLDaiLyDTO
Imports Utility

Public Class frmThemLoaiDL
    Private loaiDLBus As LoaiDLBUS
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtTenLoaiDL.TextChanged

    End Sub

    Private Sub frmThemLoaiDL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaiDLBus = New LoaiDLBUS()
        ' LoaiDLBUS = New LoaiDLBUS()
        ' quanBus = New QuanBUS()

        'lay ma dai ly
        Dim result As Result
        ' Dim resultQuan As Result
        Dim nextMaLoaiDL As Integer


        result = loaiDLBus.builMaLoaiDL(nextMaLoaiDL)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã quận không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaLoaiDL.Text = nextMaLoaiDL

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim loaidl As LoaiDLDTO
        loaidl = New LoaiDLDTO()

        loaidl.MaLoaiDL = txtMaLoaiDL.Text
        loaidl.TenLoaiDL = txtTenLoaiDL.Text
        loaidl.NoToiDa = txtNoToiDa.Text

        Dim countsolaoidailu As Integer
        ' Dim resultsodonvitinh As Result
        Dim soloaidailytoida As Integer

        loaiDLBus.countsoluongloaidaily(countsolaoidailu)
        loaiDLBus.selectSoloaidaily_thamso(soloaidailytoida)
        '3. Insert to DB
        If (countsolaoidailu < soloaidailytoida) Then

            Dim result As Result
            result = loaiDLBus.insert(loaidl)
            If (result.FlagResult = True) Then
                MessageBox.Show("Thêm loai dl thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'set MSSH auto
                Dim nextMaQuan = "1"
                result = loaiDLBus.builMaLoaiDL(nextMaQuan)

                txtTenLoaiDL.Text = String.Empty
                txtNoToiDa.Text = String.Empty
            Else
                MessageBox.Show("Thêm loai dl không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
        Else
            MessageBox.Show("số loại đại lý phải bé hơn số loại đại lý tối đa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'khong cho phep nhap ki tu vao texbox
    Private Sub txtMaLoaiDL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaLoaiDL.KeyPress, txtNoToiDa.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class