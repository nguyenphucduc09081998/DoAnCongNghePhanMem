Imports QLDaiLyBUS
Imports QLDaiLyDTO

Public Class frmThamSo
    Dim tsBus As ThamSoBUS
    Dim thamso As ThamSoDTO

    Private Sub frmThamSo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsBus = New ThamSoBUS()
        Dim listThamSo = New List(Of ThamSoDTO)
        Dim result = tsBus.selectALL(listThamSo)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy thông tin Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
        End If
        thamso = listThamSo(0)
        txtSoDaiLyToiDa.Text = thamso.SoDaiLyToiDa
        txtSoLoaiDaiLy.Text = thamso.SoLoaiDaiLy
        txtSoMatHang.Text = thamso.SoMatHang
        txtSoDonViTinh.Text = thamso.SoDonViTinh
        ' txtSoHKToiDa.Text = quydinh.SoHocKyToiDa
    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Try
            thamso.SoDaiLyToiDa = Integer.Parse(txtSoDaiLyToiDa.Text)
            thamso.SoLoaiDaiLy = Integer.Parse(txtSoLoaiDaiLy.Text)
            thamso.SoMatHang = Integer.Parse(txtSoMatHang.Text)
            thamso.SoDonViTinh = Integer.Parse(txtSoDonViTinh.Text)
            'quydinh.SoHocKyToiDa = Integer.Parse(txtSoHKToiDa.Text)
            Dim result = tsBus.update(thamso)
            If (result.FlagResult = False) Then
                MessageBox.Show("Cập nhật Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
            MessageBox.Show("Cập nhật Quy Định thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
        End Try
    End Sub


    'Private Sub TextBox1_KeyPress(KeyAscii As Integer)
    '    If KeyAscii < 48 Or KeyAscii > 57 Then
    '        KeyAscii = 0
    '    End If
    'End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtSoDaiLyToiDa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoDaiLyToiDa.KeyPress, txtSoMatHang.KeyPress, txtSoLoaiDaiLy.KeyPress, txtSoDonViTinh.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class