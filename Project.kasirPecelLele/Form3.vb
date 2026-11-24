Imports System.Collections.Generic
Imports System.Data
Imports System.Globalization
Imports Microsoft.Data.SqlClient

Public Class Form3

    Private menuTable As DataTable
    Private isUpdating As Boolean

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.Columns("colHarga").DefaultCellStyle.FormatProvider = New CultureInfo("id-ID")
        DataGridView1.Columns("colTotal").DefaultCellStyle.FormatProvider = New CultureInfo("id-ID")

        MuatMenu()
        HitungTotal()
    End Sub

    Private Sub MuatMenu()
        Try
            Using con As SqlConnection = Koneksi.BukaKoneksi()
                Using cmd As New SqlCommand("SELECT id_menu, nama_menu, kategori, harga FROM tb_menu ORDER BY kategori, nama_menu", con)
                    Using da As New SqlDataAdapter(cmd)
                        menuTable = New DataTable()
                        da.Fill(menuTable)
                    End Using
                End Using
            End Using

            If menuTable.Rows.Count = 0 Then
                AturTombolTambah(False)
                MessageBox.Show("Data menu masih kosong. Silakan isi tabel tb_menu terlebih dahulu.",
                                "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ComboBox1.DataSource = New DataView(menuTable) With {.RowFilter = "kategori = 'Makanan'"}
            ComboBox1.DisplayMember = "nama_menu"
            ComboBox1.ValueMember = "id_menu"
            ComboBox1.SelectedIndex = -1

            ComboBox2.DataSource = New DataView(menuTable) With {.RowFilter = "kategori = 'Minuman'"}
            ComboBox2.DisplayMember = "nama_menu"
            ComboBox2.ValueMember = "id_menu"
            ComboBox2.SelectedIndex = -1

            AturTombolTambah(True)
        Catch ex As Exception
            AturTombolTambah(False)
            MessageBox.Show("Gagal memuat data menu: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AturTombolTambah(aktif As Boolean)
        Button1.Enabled = aktif
        Button2.Enabled = aktif
        NumericUpDown1.Enabled = aktif
        NumericUpDown2.Enabled = aktif
        btnHapus.Enabled = aktif
        Button3.Enabled = aktif
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TambahItem(ComboBox1, NumericUpDown1, "Makanan")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TambahItem(ComboBox2, NumericUpDown2, "Minuman")
    End Sub

    Private Sub TambahItem(cbo As ComboBox, numQty As NumericUpDown, kategori As String)
        If menuTable Is Nothing Then
            MessageBox.Show("Data menu belum tersedia.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cbo.SelectedIndex < 0 OrElse cbo.SelectedValue Is Nothing Then
            MessageBox.Show("Pilih menu " & kategori.ToLower() & " terlebih dahulu.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idMenu As Integer
        If Not Integer.TryParse(Convert.ToString(cbo.SelectedValue), idMenu) Then
            MessageBox.Show("Menu yang dipilih tidak valid.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim barisMenu As DataRow = Nothing
        For Each baris As DataRow In menuTable.Rows
            If Convert.ToInt32(baris("id_menu")) = idMenu Then
                barisMenu = baris
                Exit For
            End If
        Next

        If barisMenu Is Nothing Then
            MessageBox.Show("Data menu tidak ditemukan.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim nama As String = Convert.ToString(barisMenu("nama_menu"))
        Dim harga As Decimal = Convert.ToDecimal(barisMenu("harga"))
        Dim qty As Integer = Convert.ToInt32(numQty.Value)

        TambahAtauUpdateBaris(idMenu, nama, kategori, harga, qty)
        numQty.Value = 1
        HitungTotal()
    End Sub

    Private Sub TambahAtauUpdateBaris(idMenu As Integer, nama As String, kategori As String, harga As Decimal, qty As Integer)
        Dim namaPembeli As String = NamaPembeliTerisi()

        For Each baris As DataGridViewRow In DataGridView1.Rows
            If baris.IsNewRow OrElse baris.Cells("colIdMenu").Value Is Nothing Then Continue For

            If Convert.ToInt32(baris.Cells("colIdMenu").Value) = idMenu Then
                Dim qtyBaru As Integer = Convert.ToInt32(baris.Cells("colQty").Value) + qty

                isUpdating = True
                Try
                    baris.Cells("colQty").Value = qtyBaru
                    baris.Cells("colTotal").Value = harga * qtyBaru
                    baris.Cells("colPembeli").Value = namaPembeli
                Finally
                    isUpdating = False
                End Try
                Return
            End If
        Next

        isUpdating = True
        Try
            DataGridView1.Rows.Add(idMenu, nama, kategori, harga, qty, harga * qty, namaPembeli)
        Finally
            isUpdating = False
        End Try
    End Sub

    Private Function NamaPembeliTerisi() As String
        Return txtNamaPembeli.Text.Trim()
    End Function

    Private Sub txtNamaPembeli_TextChanged(sender As Object, e As EventArgs) Handles txtNamaPembeli.TextChanged
        Dim namaPembeli As String = NamaPembeliTerisi()

        For Each baris As DataGridViewRow In DataGridView1.Rows
            If baris.IsNewRow Then Continue For
            baris.Cells("colPembeli").Value = namaPembeli
        Next
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If isUpdating OrElse e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Return
        If DataGridView1.Columns(e.ColumnIndex).Name <> "colQty" Then Return

        Dim baris As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        If baris.IsNewRow Then Return

        Dim qty As Integer
        If Not Integer.TryParse(Convert.ToString(baris.Cells("colQty").Value), qty) OrElse qty < 1 Then
            isUpdating = True
            Try
                baris.Cells("colQty").Value = 1
            Finally
                isUpdating = False
            End Try
            qty = 1
        End If

        Dim harga As Decimal = Convert.ToDecimal(baris.Cells("colHarga").Value)
        baris.Cells("colTotal").Value = harga * qty
        HitungTotal()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If DataGridView1.CurrentRow Is Nothing OrElse DataGridView1.CurrentRow.IsNewRow Then
            MessageBox.Show("Pilih baris yang ingin dihapus terlebih dahulu.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        HitungTotal()
    End Sub

    Private Sub HitungTotal()
        Dim total As Decimal = 0D

        For Each baris As DataGridViewRow In DataGridView1.Rows
            If baris.IsNewRow OrElse baris.Cells("colTotal").Value Is Nothing Then Continue For
            total += Convert.ToDecimal(baris.Cells("colTotal").Value)
        Next

        lblTotal.Text = "TOTAL: Rp " & total.ToString("N0", New CultureInfo("id-ID"))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim items As New List(Of ItemKeranjang)
        Dim total As Decimal = 0D

        For Each baris As DataGridViewRow In DataGridView1.Rows
            If baris.IsNewRow Then Continue For

            Dim qty As Integer = Convert.ToInt32(baris.Cells("colQty").Value)
            If qty < 1 Then Continue For

            Dim item As New ItemKeranjang(
                Convert.ToInt32(baris.Cells("colIdMenu").Value),
                Convert.ToString(baris.Cells("colMenu").Value),
                Convert.ToString(baris.Cells("colKategori").Value),
                Convert.ToDecimal(baris.Cells("colHarga").Value),
                qty)

            items.Add(item)
            total += item.Subtotal
        Next

        If items.Count = 0 Then
            MessageBox.Show("Belum ada item yang dipilih.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim namaPembeli As String = NamaPembeliTerisi()
        If namaPembeli = "" Then
            MessageBox.Show("Isi nama pembeli terlebih dahulu.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNamaPembeli.Focus()
            Return
        End If

        Using pembayaran As New Form5(total)
            If pembayaran.ShowDialog(Me) <> DialogResult.OK Then Return

            Try
                Dim username As String = Sesi.Username
                If String.IsNullOrWhiteSpace(username) Then username = "Kasir"

                Dim repo As New TransaksiRepository()
                Dim idTransaksi As Integer = repo.Simpan(username, namaPembeli, pembayaran.UangBayar, items)

                Using struk As New Form6(idTransaksi)
                    struk.ShowDialog(Me)
                End Using

                DataGridView1.Rows.Clear()
                txtNamaPembeli.Clear()
                HitungTotal()
                txtNamaPembeli.Focus()
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan transaksi: " & ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        If Sesi.Role = "Admin" Then
            Navigasi.BukaAdminDashboard()
        Else
            Form2.Show()
        End If
        Me.Close()
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Sesi.Role = "Admin" Then
            If Not Navigasi.AdminDashboardVisible Then Navigasi.BukaAdminDashboard()
        Else
            If Not Form2.Visible Then Form2.Show()
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
