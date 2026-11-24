Imports System.Data
Imports System.Globalization

Public Class Form4

    Private ReadOnly repo As New TransaksiRepository()

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Sesi.Role <> "Admin" Then
            MessageBox.Show("Halaman riwayat transaksi hanya dapat diakses oleh admin.", "Akses Ditolak",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Form2.Show()
            Me.Close()
            Return
        End If

        DateTimePicker1.Value = DateTime.Today
        DateTimePicker2.Value = DateTime.Today
        AturFormatGrid()
        TampilkanData()
    End Sub

    Private Sub AturFormatGrid()
        Dim budaya As New CultureInfo("id-ID")

        DataGridView1.Columns("colTanggal").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
        DataGridView1.Columns("colTotal").DefaultCellStyle.FormatProvider = budaya
        DataGridView1.Columns("colBayar").DefaultCellStyle.FormatProvider = budaya
        DataGridView1.Columns("colKembalian").DefaultCellStyle.FormatProvider = budaya

        DataGridView2.Columns("colHarga").DefaultCellStyle.FormatProvider = budaya
        DataGridView2.Columns("colSubtotal").DefaultCellStyle.FormatProvider = budaya
    End Sub

    Private Sub TampilkanData()
        Try
            Dim awal As DateTime = DateTimePicker1.Value.Date
            Dim akhir As DateTime = DateTimePicker2.Value.Date

            If awal > akhir Then
                MessageBox.Show("Tanggal awal tidak boleh lebih besar dari tanggal akhir.", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            DataGridView1.DataSource = repo.AmbilRiwayat(awal, akhir)
            DataGridView2.DataSource = Nothing

            Dim ringkasan As DataTable = repo.AmbilRingkasan(awal, akhir)
            If ringkasan.Rows.Count > 0 Then
                Dim jumlah As Integer = Convert.ToInt32(ringkasan.Rows(0)("jumlah_transaksi"))
                Dim pendapatan As Decimal = Convert.ToDecimal(ringkasan.Rows(0)("total_pendapatan"))

                lblJumlah.Text = "Jumlah transaksi: " & jumlah
                lblPendapatan.Text = "Total pendapatan: Rp " &
                    pendapatan.ToString("N0", New CultureInfo("id-ID"))
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat riwayat transaksi: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.CurrentRow Is Nothing Then Return

        Dim idTransaksi As Integer
        If Not Integer.TryParse(Convert.ToString(DataGridView1.CurrentRow.Cells("colId").Value), idTransaksi) Then Return

        Try
            DataGridView2.DataSource = repo.AmbilDetail(idTransaksi)
            lblInfo.Text = "Menampilkan detail untuk transaksi " &
                Convert.ToString(DataGridView1.CurrentRow.Cells("colNo").Value) &
                " (Pembeli: " & Convert.ToString(DataGridView1.CurrentRow.Cells("colPembeli").Value) & ")"
        Catch ex As Exception
            MessageBox.Show("Gagal memuat detail transaksi: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        TampilkanData()
    End Sub

    Private Sub btnHariIni_Click(sender As Object, e As EventArgs) Handles btnHariIni.Click
        DateTimePicker1.Value = DateTime.Today
        DateTimePicker2.Value = DateTime.Today
        TampilkanData()
    End Sub

    Private Sub btnLihatStruk_Click(sender As Object, e As EventArgs) Handles btnLihatStruk.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih transaksi terlebih dahulu.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idTransaksi As Integer
        If Not Integer.TryParse(Convert.ToString(DataGridView1.CurrentRow.Cells("colId").Value), idTransaksi) Then Return

        Using struk As New Form6(idTransaksi)
            struk.ShowDialog(Me)
        End Using
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Navigasi.BukaAdminDashboard()
        Me.Close()
    End Sub

    Private Sub Form4_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Sesi.Role = "Admin" Then
            If Not Navigasi.AdminDashboardVisible Then Navigasi.BukaAdminDashboard()
        Else
            If Not Form2.Visible Then Form2.Show()
        End If
    End Sub

End Class
