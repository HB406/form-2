Imports System.Security.Cryptography.X509Certificates
Imports System.Data.SqlClient


Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtMaSV.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "[ghi tên connection string của database vào đây]"
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim connectionString As String = "[ghi tên connection string của database vào đây]"
        Dim conn As New SqlConnection(connectionString)
        Dim query As String = "INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, MaPhong) VALUES (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @MaPhong)"
        Dim cmd As New SqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)
        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text)
        cmd.Parameters.AddWithValue("@NgaySinh", txtNgaySinh.Text)
        cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text)
        cmd.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Thêm thành công!")
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim connectionString As String = "[ghi tên connection string của database vào đây]"
        Dim query As String = "UPDATE SinhVien SET HoTen=@HoTen, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, MaPhong=@MaPhong WHERE MaSV=@MaSV"
        Dim conn As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text)
        cmd.Parameters.AddWithValue("@NgaySinh", txtNgaySinh.Text)
        cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text)
        cmd.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text)
        cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)

        Try
            conn.Open()
            Dim rowsAffected = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Không tìm thấy mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi khi sửa: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim connectionString As String = "[ghi tên connection string của database vào đây]"
        Dim conn As New SqlConnection(connectionString)
        Dim result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then Exit Sub

        Dim query As String = "DELETE FROM SinhVien WHERE MaSV=@MaSV"
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)

        Try
            conn.Open()
            Dim rowsDeleted = cmd.ExecuteNonQuery()
            If rowsDeleted > 0 Then
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Không tìm thấy mã sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi khi xóa: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
