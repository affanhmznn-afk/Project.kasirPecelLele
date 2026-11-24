Imports System.Globalization
Imports System.Security.Cryptography
Imports System.Text

''' <summary>
''' Helper untuk hash dan verifikasi password.
''' Password lama (teks biasa) tetap dapat diverifikasi agar pengguna
''' tidak terkunci setelah aplikasi diperbarui.
''' </summary>
Public Module PasswordHelper

    Private Const Prefix As String = "PBKDF2-SHA256"
    Private Const Iterasi As Integer = 100000
    Private Const UkuranSalt As Integer = 16
    Private Const UkuranHash As Integer = 32

    Public Function HashPassword(password As String) As String
        Dim salt(UkuranSalt - 1) As Byte
        Using rng As RandomNumberGenerator = RandomNumberGenerator.Create()
            rng.GetBytes(salt)
        End Using

        Dim hash As Byte() = Rfc2898DeriveBytes.Pbkdf2(
            password, salt, Iterasi, HashAlgorithmName.SHA256, UkuranHash)

        Return Prefix & ":" &
               Iterasi.ToString(CultureInfo.InvariantCulture) & ":" &
               Convert.ToBase64String(salt) & ":" &
               Convert.ToBase64String(hash)
    End Function

    Public Function VerifikasiPassword(password As String, storedPassword As String) As Boolean
        If String.IsNullOrEmpty(storedPassword) Then Return False

        ' Password lama yang belum di-hash.
        If Not storedPassword.StartsWith(Prefix & ":", StringComparison.Ordinal) Then
            Return String.Equals(password, storedPassword, StringComparison.Ordinal)
        End If

        Try
            Dim bagian As String() = storedPassword.Split(":"c)
            If bagian.Length <> 4 Then Return False

            Dim iterasiTersimpan As Integer
            If Not Integer.TryParse(bagian(1), NumberStyles.Integer, CultureInfo.InvariantCulture, iterasiTersimpan) Then
                Return False
            End If

            Dim salt As Byte() = Convert.FromBase64String(bagian(2))
            Dim hashTersimpan As Byte() = Convert.FromBase64String(bagian(3))
            Dim hashInput As Byte() = Rfc2898DeriveBytes.Pbkdf2(
                password, salt, iterasiTersimpan, HashAlgorithmName.SHA256, hashTersimpan.Length)

            Return BandingkanKonstan(hashInput, hashTersimpan)
        Catch
            Return False
        End Try
    End Function

    Private Function BandingkanKonstan(a As Byte(), b As Byte()) As Boolean
        If a Is Nothing OrElse b Is Nothing OrElse a.Length <> b.Length Then Return False

        Dim beda As Integer = 0
        For i As Integer = 0 To a.Length - 1
            beda = beda Or (a(i) Xor b(i))
        Next

        Return beda = 0
    End Function

End Module
