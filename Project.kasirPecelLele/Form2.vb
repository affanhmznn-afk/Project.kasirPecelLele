Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sesi.Username = ""
        Sesi.Role = ""
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        ' User tidak perlu password.
        Sesi.Username = "User"
        Sesi.Role = "User"

        Navigasi.BukaTransaksi()
        Me.Hide()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Sesi.Username = ""
        Sesi.Role = ""

        Navigasi.BukaLoginAdmin()
        Me.Hide()
    End Sub

End Class
