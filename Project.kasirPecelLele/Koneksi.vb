Imports Microsoft.Data.SqlClient

Public Module Koneksi
    Public Const ConnectionString As String = "Data Source=LAPTOP-5641CBJO\SQLEXPRESS;Initial Catalog=db_pecel_lele;Integrated Security=True;Encrypt=False"

    Public Function BukaKoneksi() As SqlConnection
        Dim con As New SqlConnection(ConnectionString)
        con.Open()
        Return con
    End Function
End Module
