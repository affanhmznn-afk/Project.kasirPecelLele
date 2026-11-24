Imports System.Globalization

Public Class Form5

    Private _total As Decimal

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(total As Decimal)
        Me.New()
        _total = total
        lblTotal.Text = "Rp " & total.ToString("N0", New CultureInfo("id-ID"))
        numBayar.Maximum = 999999999999D
        numBayar.Value = total
        HitungKembalian()
    End Sub

    Public ReadOnly Property UangBayar As Decimal
        Get
            Return numBayar.Value
        End Get
    End Property

    Public ReadOnly Property Kembalian As Decimal
        Get
            If numBayar.Value > _total Then
                Return numBayar.Value - _total
            End If
            Return 0D
        End Get
    End Property

    Private Sub numBayar_ValueChanged(sender As Object, e As EventArgs) Handles numBayar.ValueChanged
        HitungKembalian()
    End Sub

    Private Sub btnUangPas_Click(sender As Object, e As EventArgs) Handles btnUangPas.Click
        numBayar.Value = _total
    End Sub

    Private Sub HitungKembalian()
        Dim kembali As Decimal = numBayar.Value - _total

        If kembali < 0 Then
            lblKembalian.Text = "Kurang Rp " & Math.Abs(kembali).ToString("N0", New CultureInfo("id-ID"))
            lblKembalian.ForeColor = Color.Firebrick
            btnBayar.Enabled = False
        Else
            lblKembalian.Text = "Rp " & kembali.ToString("N0", New CultureInfo("id-ID"))
            lblKembalian.ForeColor = Color.ForestGreen
            btnBayar.Enabled = True
        End If
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        If numBayar.Value < _total Then
            MessageBox.Show("Uang bayar masih kurang dari total belanja.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        DialogResult = DialogResult.OK
        Close()
    End Sub

End Class
