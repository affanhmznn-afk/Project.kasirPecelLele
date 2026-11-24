Imports System.Collections.Generic
Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class TransaksiRepository

    ''' <summary>
    ''' Menyimpan header dan detail transaksi dalam satu database transaction.
    ''' Mengembalikan id_transaksi yang baru dibuat.
    ''' </summary>
    Public Function Simpan(username As String, namaPembeli As String, bayar As Decimal, items As List(Of ItemKeranjang)) As Integer
        If items Is Nothing OrElse items.Count = 0 Then
            Throw New ArgumentException("Keranjang masih kosong.")
        End If

        If String.IsNullOrWhiteSpace(namaPembeli) Then
            Throw New ArgumentException("Nama pembeli harus diisi.")
        End If

        namaPembeli = namaPembeli.Trim()

        Dim total As Decimal = 0D
        For Each item As ItemKeranjang In items
            total += item.Subtotal
        Next

        If bayar < total Then
            Throw New ArgumentException("Uang bayar kurang dari total belanja.")
        End If

        Dim kembalian As Decimal = bayar - total
        Dim noTransaksi As String = "TRX-" & DateTime.Now.ToString("yyyyMMdd-HHmmssfff")

        Using con As SqlConnection = Koneksi.BukaKoneksi()
            Using trans As SqlTransaction = con.BeginTransaction()
                Try
                    Dim idTransaksi As Integer

                    Using cmd As New SqlCommand(
                        "INSERT INTO tb_transaksi (no_transaksi, tanggal, username, nama_pembeli, total, bayar, kembalian, metode_bayar) " &
                        "VALUES (@no, GETDATE(), @username, @nama_pembeli, @total, @bayar, @kembalian, 'Tunai'); " &
                        "SELECT CAST(SCOPE_IDENTITY() AS INT);", con, trans)

                        cmd.Parameters.Add("@no", SqlDbType.VarChar, 30).Value = noTransaksi
                        cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username
                        cmd.Parameters.Add("@nama_pembeli", SqlDbType.VarChar, 50).Value = namaPembeli
                        TambahParameterDesimal(cmd, "@total", total)
                        TambahParameterDesimal(cmd, "@bayar", bayar)
                        TambahParameterDesimal(cmd, "@kembalian", kembalian)

                        idTransaksi = Convert.ToInt32(cmd.ExecuteScalar())
                    End Using

                    For Each item As ItemKeranjang In items
                        Using cmd As New SqlCommand(
                            "INSERT INTO tb_detail_transaksi (id_transaksi, id_menu, nama_menu, kategori, harga, qty, subtotal) " &
                            "VALUES (@id, @id_menu, @nama, @kategori, @harga, @qty, @subtotal)", con, trans)

                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idTransaksi
                            cmd.Parameters.Add("@id_menu", SqlDbType.Int).Value = item.IdMenu
                            cmd.Parameters.Add("@nama", SqlDbType.VarChar, 50).Value = item.NamaMenu
                            cmd.Parameters.Add("@kategori", SqlDbType.VarChar, 10).Value = item.Kategori
                            TambahParameterDesimal(cmd, "@harga", item.Harga)
                            cmd.Parameters.Add("@qty", SqlDbType.Int).Value = item.Qty
                            TambahParameterDesimal(cmd, "@subtotal", item.Subtotal)

                            cmd.ExecuteNonQuery()
                        End Using
                    Next

                    trans.Commit()
                    Return idTransaksi
                Catch
                    trans.Rollback()
                    Throw
                End Try
            End Using
        End Using
    End Function

    Public Function AmbilRiwayat(awal As DateTime, akhir As DateTime) As DataTable
        Dim dt As New DataTable()

        Using con As SqlConnection = Koneksi.BukaKoneksi()
            Using cmd As New SqlCommand(
                "SELECT id_transaksi, no_transaksi, tanggal, username, ISNULL(nama_pembeli, '-') AS nama_pembeli, total, bayar, kembalian " &
                "FROM tb_transaksi " &
                "WHERE tanggal >= @awal AND tanggal < @akhir " &
                "ORDER BY tanggal DESC", con)

                cmd.Parameters.Add("@awal", SqlDbType.DateTime).Value = awal.Date
                cmd.Parameters.Add("@akhir", SqlDbType.DateTime).Value = akhir.Date.AddDays(1)

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

    Public Function AmbilRingkasan(awal As DateTime, akhir As DateTime) As DataTable
        Dim dt As New DataTable()

        Using con As SqlConnection = Koneksi.BukaKoneksi()
            Using cmd As New SqlCommand(
                "SELECT COUNT(*) AS jumlah_transaksi, ISNULL(SUM(total), 0) AS total_pendapatan " &
                "FROM tb_transaksi " &
                "WHERE tanggal >= @awal AND tanggal < @akhir", con)

                cmd.Parameters.Add("@awal", SqlDbType.DateTime).Value = awal.Date
                cmd.Parameters.Add("@akhir", SqlDbType.DateTime).Value = akhir.Date.AddDays(1)

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

    Public Function AmbilHeader(idTransaksi As Integer) As DataTable
        Dim dt As New DataTable()

        Using con As SqlConnection = Koneksi.BukaKoneksi()
            Using cmd As New SqlCommand(
                "SELECT id_transaksi, no_transaksi, tanggal, username, ISNULL(nama_pembeli, '-') AS nama_pembeli, total, bayar, kembalian, metode_bayar " &
                "FROM tb_transaksi WHERE id_transaksi = @id", con)

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = idTransaksi

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

    Public Function AmbilDetail(idTransaksi As Integer) As DataTable
        Dim dt As New DataTable()

        Using con As SqlConnection = Koneksi.BukaKoneksi()
            Using cmd As New SqlCommand(
                "SELECT nama_menu, kategori, harga, qty, subtotal " &
                "FROM tb_detail_transaksi WHERE id_transaksi = @id ORDER BY id_detail", con)

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = idTransaksi

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

    Private Shared Sub TambahParameterDesimal(cmd As SqlCommand, nama As String, nilai As Decimal)
        Dim p As SqlParameter = cmd.Parameters.Add(nama, SqlDbType.Decimal)
        p.Precision = 12
        p.Scale = 0
        p.Value = nilai
    End Sub

End Class
