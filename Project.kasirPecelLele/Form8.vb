Public Class Form8

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Sesi.Role <> "Admin" Then
            MessageBox.Show("Halaman ini hanya dapat diakses oleh admin.", "Akses Ditolak",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Form2.Show()
            Me.Close()
            Return
        End If

        Dim nama As String = Sesi.Username
        If String.IsNullOrWhiteSpace(nama) Then nama = "Admin"
        lblKasir.Text = "Admin: " & nama
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Navigasi.BukaTransaksi()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Navigasi.BukaRiwayat()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Navigasi.BukaKelolaMenu()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim jawab As DialogResult = MessageBox.Show(
            "Yakin ingin logout dari akun admin?", "Konfirmasi Logout",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If jawab <> DialogResult.Yes Then Return

        Me.Close()
    End Sub

    Private Sub Form8_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Sesi.Username = ""
        Sesi.Role = ""

        If Not Form2.Visible Then Form2.Show()
    End Sub

End Class
