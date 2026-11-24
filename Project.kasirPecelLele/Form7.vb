Imports System.Globalization
Imports Microsoft.Data.SqlClient

Public Class Form7

    Private ReadOnly repo As New MenuRepository()
    Private idTerpilih As Integer = 0

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Sesi.Role <> "Admin" Then
            MessageBox.Show("Halaman kelola menu hanya dapat diakses oleh admin.", "Akses Ditolak",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Form2.Show()
            Me.Close()
            Return
        End If

        cboKategori.Items.Clear()
        cboKategori.Items.Add("Makanan")
        cboKategori.Items.Add("Minuman")
        cboKategori.SelectedIndex = 0

        DataGridView1.Columns("colHarga").DefaultCellStyle.FormatProvider = New CultureInfo("id-ID")
        numHarga.Maximum = 999999999999D

        MuatData()
    End Sub

    Private Sub MuatData()
        Try
            DataGridView1.DataSource = repo.AmbilSemua()

            If DataGridView1.Rows.Count > 0 Then
                DataGridView1.ClearSelection()
                DataGridView1.CurrentCell = Nothing
            End If

            BersihkanForm()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data menu: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.CurrentRow Is Nothing Then Return

        Dim id As Integer
        If Not Integer.TryParse(Convert.ToString(DataGridView1.CurrentRow.Cells("colId").Value), id) Then Return

        idTerpilih = id
        txtNama.Text = Convert.ToString(DataGridView1.CurrentRow.Cells("colNama").Value)
        cboKategori.SelectedItem = Convert.ToString(DataGridView1.CurrentRow.Cells("colKategori").Value)
        numHarga.Value = Convert.ToDecimal(DataGridView1.CurrentRow.Cells("colHarga").Value)
        lblInfo.Text = "Data terpilih: " & txtNama.Text
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not ValidasiInput() Then Return

        Try
            repo.Tambah(txtNama.Text.Trim(), Convert.ToString(cboKategori.SelectedItem), numHarga.Value)
            MessageBox.Show("Menu berhasil ditambahkan.", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            MuatData()
        Catch ex As SqlException When ex.Number = 2627 OrElse ex.Number = 2601
            MessageBox.Show("Nama menu tersebut sudah ada. Gunakan nama lain.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Gagal menambah menu: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If idTerpilih = 0 Then
            MessageBox.Show("Pilih data menu yang ingin diubah terlebih dahulu.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not ValidasiInput() Then Return

        Try
            repo.Ubah(idTerpilih, txtNama.Text.Trim(), Convert.ToString(cboKategori.SelectedItem), numHarga.Value)
            MessageBox.Show("Menu berhasil diubah.", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            MuatData()
        Catch ex As SqlException When ex.Number = 2627 OrElse ex.Number = 2601
            MessageBox.Show("Nama menu tersebut sudah ada. Gunakan nama lain.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah menu: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If idTerpilih = 0 Then
            MessageBox.Show("Pilih data menu yang ingin dihapus terlebih dahulu.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim jawab As DialogResult = MessageBox.Show(
            "Yakin ingin menghapus menu '" & txtNama.Text & "'?", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If jawab <> DialogResult.Yes Then Return

        Try
            repo.Hapus(idTerpilih)
            MessageBox.Show("Menu berhasil dihapus.", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            MuatData()
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus menu: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBersih_Click(sender As Object, e As EventArgs) Handles btnBersih.Click
        BersihkanForm()
    End Sub

    Private Sub BersihkanForm()
        idTerpilih = 0
        txtNama.Clear()
        cboKategori.SelectedIndex = 0
        numHarga.Value = 0
        lblInfo.Text = "Pilih data di tabel untuk mengubah atau menghapus."
        DataGridView1.ClearSelection()
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.CurrentCell = Nothing
        End If
    End Sub

    Private Function ValidasiInput() As Boolean
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Nama menu wajib diisi.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return False
        End If

        If cboKategori.SelectedIndex < 0 Then
            MessageBox.Show("Pilih kategori menu.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboKategori.Focus()
            Return False
        End If

        If numHarga.Value <= 0 Then
            MessageBox.Show("Harga menu harus lebih besar dari 0.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            numHarga.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Navigasi.BukaAdminDashboard()
        Me.Close()
    End Sub

    Private Sub Form7_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Sesi.Role = "Admin" Then
            If Not Navigasi.AdminDashboardVisible Then Navigasi.BukaAdminDashboard()
        Else
            If Not Form2.Visible Then Form2.Show()
        End If
    End Sub

End Class
