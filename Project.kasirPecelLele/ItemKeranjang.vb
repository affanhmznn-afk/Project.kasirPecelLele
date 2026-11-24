Public Class ItemKeranjang
    Public Property IdMenu As Integer
    Public Property NamaMenu As String
    Public Property Kategori As String
    Public Property Harga As Decimal
    Public Property Qty As Integer

    Public ReadOnly Property Subtotal As Decimal
        Get
            Return Harga * Qty
        End Get
    End Property

    Public Sub New(idMenu As Integer, namaMenu As String, kategori As String, harga As Decimal, qty As Integer)
        Me.IdMenu = idMenu
        Me.NamaMenu = namaMenu
        Me.Kategori = kategori
        Me.Harga = harga
        Me.Qty = qty
    End Sub
End Class
