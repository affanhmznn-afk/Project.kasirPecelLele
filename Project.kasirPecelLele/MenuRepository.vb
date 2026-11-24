Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class MenuRepository

    Public Function AmbilSemua() As DataTable
        Dim dt As New DataTable()

        Using con As SqlConnection = Koneksi.BukaKoneksi()
            Using cmd As New SqlCommand(
                "SELECT id_menu, nama_menu, kategori, harga FROM tb_menu ORDER BY kategori, nama_menu", con)

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

    Public Sub Tambah(nama As String, kategori As String, harga As Decimal)
        Using con As SqlConnection = Koneksi.BukaKoneksi()
            Using cmd As New SqlCommand(
                "INSERT INTO tb_menu (nama_menu, kategori, harga) VALUES (@nama, @kategori, @harga)", con)

                cmd.Parameters.Add("@nama", SqlDbType.VarChar, 50).Value = nama
                cmd.Parameters.Add("@kategori", SqlDbType.VarChar, 10).Value = kategori
                TambahParameterDesimal(cmd, "@harga", harga)

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Ubah(idMenu As Integer, nama As String, kategori As String, harga As Decimal)
        Using con As SqlConnection = Koneksi.BukaKoneksi()
            Using cmd As New SqlCommand(
                "UPDATE tb_menu SET nama_menu = @nama, kategori = @kategori, harga = @harga WHERE id_menu = @id", con)

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = idMenu
                cmd.Parameters.Add("@nama", SqlDbType.VarChar, 50).Value = nama
                cmd.Parameters.Add("@kategori", SqlDbType.VarChar, 10).Value = kategori
                TambahParameterDesimal(cmd, "@harga", harga)

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Hapus(idMenu As Integer)
        Using con As SqlConnection = Koneksi.BukaKoneksi()
            Using cmd As New SqlCommand("DELETE FROM tb_menu WHERE id_menu = @id", con)
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = idMenu
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Shared Sub TambahParameterDesimal(cmd As SqlCommand, nama As String, nilai As Decimal)
        Dim p As SqlParameter = cmd.Parameters.Add(nama, SqlDbType.Decimal)
        p.Precision = 12
        p.Scale = 0
        p.Value = nilai
    End Sub

End Class
