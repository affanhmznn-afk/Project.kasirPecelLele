Imports System.Data
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Text

Public Class Form6

    Private _idTransaksi As Integer
    Private ReadOnly printDoc As New PrintDocument()

    Public Sub New()
        InitializeComponent()
        AddHandler printDoc.PrintPage, AddressOf printDoc_PrintPage
    End Sub

    Public Sub New(idTransaksi As Integer)
        Me.New()
        _idTransaksi = idTransaksi
        MuatStruk()
    End Sub

    Private Sub MuatStruk()
        Try
            Dim repo As New TransaksiRepository()
            Dim header As DataTable = repo.AmbilHeader(_idTransaksi)
            Dim detail As DataTable = repo.AmbilDetail(_idTransaksi)

            If header.Rows.Count = 0 Then
                RichTextBox1.Text = "Transaksi tidak ditemukan."
                btnCetak.Enabled = False
                Return
            End If

            RichTextBox1.Text = BuatStruk(header.Rows(0), detail)
            printDoc.DocumentName = "Struk " & Convert.ToString(header.Rows(0)("no_transaksi"))
        Catch ex As Exception
            MessageBox.Show("Gagal memuat struk: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnCetak.Enabled = False
        End Try
    End Sub

    Private Function BuatStruk(header As DataRow, detail As DataTable) As String
        Const lebar As Integer = 44
        Dim budaya As New CultureInfo("id-ID")
        Dim sb As New StringBuilder()

        sb.AppendLine(New String("="c, lebar))
        sb.AppendLine("        KEDAI PECEL LELE SEDERHANA")
        sb.AppendLine(New String("="c, lebar))
        sb.AppendLine("No. Transaksi : " & Convert.ToString(header("no_transaksi")))
        sb.AppendLine("Tanggal       : " & Convert.ToDateTime(header("tanggal")).ToString("dd/MM/yyyy HH:mm", budaya))
        sb.AppendLine("Kasir         : " & Convert.ToString(header("username")))
        sb.AppendLine("Pembeli       : " & Convert.ToString(header("nama_pembeli")))
        sb.AppendLine("Metode        : " & Convert.ToString(header("metode_bayar")))
        sb.AppendLine(New String("-"c, lebar))
        sb.AppendLine("Menu".PadRight(20) & "Qty".PadLeft(4) & "Harga".PadLeft(10) & "Total".PadLeft(10))
        sb.AppendLine(New String("-"c, lebar))

        For Each baris As DataRow In detail.Rows
            Dim nama As String = Convert.ToString(baris("nama_menu"))
            If nama.Length > 19 Then nama = nama.Substring(0, 19)

            sb.AppendLine(nama.PadRight(20) &
                          Convert.ToInt32(baris("qty")).ToString().PadLeft(4) &
                          Convert.ToDecimal(baris("harga")).ToString("N0", budaya).PadLeft(10) &
                          Convert.ToDecimal(baris("subtotal")).ToString("N0", budaya).PadLeft(10))
        Next

        sb.AppendLine(New String("-"c, lebar))
        sb.AppendLine("TOTAL".PadRight(30) & ("Rp " & Convert.ToDecimal(header("total")).ToString("N0", budaya)).PadLeft(14))
        sb.AppendLine("BAYAR".PadRight(30) & ("Rp " & Convert.ToDecimal(header("bayar")).ToString("N0", budaya)).PadLeft(14))
        sb.AppendLine("KEMBALIAN".PadRight(30) & ("Rp " & Convert.ToDecimal(header("kembalian")).ToString("N0", budaya)).PadLeft(14))
        sb.AppendLine(New String("="c, lebar))
        sb.AppendLine("      Terima kasih atas kunjungan Anda")
        sb.AppendLine(New String("="c, lebar))

        Return sb.ToString()
    End Function

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Try
            Using preview As New PrintPreviewDialog()
                preview.Document = printDoc
                preview.WindowState = FormWindowState.Maximized
                preview.ShowDialog(Me)
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal membuka pratinjau cetak: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub printDoc_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim font As New Font("Consolas", 10F)
        Dim y As Single = e.MarginBounds.Top
        Dim tinggiBaris As Single = font.GetHeight(e.Graphics) + 2

        For Each baris As String In RichTextBox1.Lines
            e.Graphics.DrawString(baris, font, Brushes.Black, e.MarginBounds.Left, y)
            y += tinggiBaris
        Next

        e.HasMorePages = False
    End Sub

End Class
