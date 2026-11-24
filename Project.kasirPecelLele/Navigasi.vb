''' <summary>
''' Pusat navigasi aplikasi. Form sekunder dibuat baru setiap kali dibuka
''' agar tidak bermasalah setelah form ditutup/dispose.
''' </summary>
Public Module Navigasi

    Private _adminDashboard As Form8

    Public ReadOnly Property AdminDashboardVisible As Boolean
        Get
            Return _adminDashboard IsNot Nothing AndAlso
                   Not _adminDashboard.IsDisposed AndAlso
                   _adminDashboard.Visible
        End Get
    End Property

    Public Sub BukaLoginAdmin()
        Dim login As New Form1()
        login.ResetLogin()
        login.Show()
    End Sub

    Public Sub BukaTransaksi()
        Dim form As New Form3()
        form.Show()
    End Sub

    Public Sub BukaRiwayat()
        Dim form As New Form4()
        form.Show()
    End Sub

    Public Sub BukaKelolaMenu()
        Dim form As New Form7()
        form.Show()
    End Sub

    Public Sub BukaAdminDashboard()
        If _adminDashboard Is Nothing OrElse _adminDashboard.IsDisposed Then
            _adminDashboard = New Form8()
        End If

        _adminDashboard.Show()
        _adminDashboard.Activate()
    End Sub

End Module
