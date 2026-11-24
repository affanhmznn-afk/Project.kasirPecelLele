Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class Form1

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        ResetLogin()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username As String = txtusername.Text.Trim()
        Dim password As String = txtpassword.Text

        If username = "" Then
            MessageBox.Show("Masukkan username.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtusername.Focus()
            Return
        End If

        If password = "" Then
            MessageBox.Show("Masukkan password.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpassword.Focus()
            Return
        End If

        Try
            Using con As SqlConnection = Koneksi.BukaKoneksi()
                Dim storedPassword As String = Nothing

                Using cmd As New SqlCommand(
                    "SELECT TOP 1 password FROM tb_login WHERE username = @username", con)

                    cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username
                    Dim hasil As Object = cmd.ExecuteScalar()

                    If hasil Is Nothing OrElse hasil Is DBNull.Value Then
                        TampilkanLoginGagal()
                        Return
                    End If

                    storedPassword = Convert.ToString(hasil)
                End Using

                If Not PasswordHelper.VerifikasiPassword(password, storedPassword) Then
                    TampilkanLoginGagal()
                    Return
                End If

                ' Upgrade password lama (teks biasa) menjadi hash PBKDF2.
                If Not storedPassword.StartsWith("PBKDF2-SHA256:", StringComparison.Ordinal) Then
                    Using cmd As New SqlCommand(
                        "UPDATE tb_login SET password = @passwordBaru " &
                        "WHERE username = @username AND password = @passwordLama", con)

                        cmd.Parameters.Add("@passwordBaru", SqlDbType.VarChar, 255).Value =
                            PasswordHelper.HashPassword(password)
                        cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username
                        cmd.Parameters.Add("@passwordLama", SqlDbType.VarChar, 255).Value = storedPassword
                        cmd.ExecuteNonQuery()
                    End Using
                End If

                Sesi.Username = username
                Sesi.Role = "Admin"
                txtpassword.Clear()

                Navigasi.BukaAdminDashboard()
                Me.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal login: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Not Form2.Visible AndAlso Not Navigasi.AdminDashboardVisible Then
            Form2.Show()
        End If
    End Sub

    Private Sub TampilkanLoginGagal()
        MessageBox.Show("Username atau password salah.", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
        txtpassword.Clear()
        txtpassword.Focus()
    End Sub

    Public Sub ResetLogin()
        txtusername.Clear()
        txtpassword.Clear()
        txtusername.Focus()
    End Sub

End Class
