<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        lblTotal = New Label()
        Label3 = New Label()
        numBayar = New NumericUpDown()
        btnUangPas = New Button()
        Label4 = New Label()
        lblKembalian = New Label()
        btnBayar = New Button()
        btnBatal = New Button()
        Panel1.SuspendLayout()
        CType(numBayar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Firebrick
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(520, 70)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(520, 70)
        Label1.TabIndex = 0
        Label1.Text = "PEMBAYARAN"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(30, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 28)
        Label2.TabIndex = 1
        Label2.Text = "Total Belanja"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.ForeColor = Color.Firebrick
        lblTotal.Location = New Point(30, 118)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(200, 60)
        lblTotal.TabIndex = 2
        lblTotal.Text = "Rp 0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(30, 190)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 28)
        Label3.TabIndex = 3
        Label3.Text = "Uang Bayar"
        ' 
        ' numBayar
        ' 
        numBayar.DecimalPlaces = 0
        numBayar.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        numBayar.Location = New Point(30, 220)
        numBayar.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        numBayar.Name = "numBayar"
        numBayar.Size = New Size(440, 50)
        numBayar.TabIndex = 4
        numBayar.TextAlign = HorizontalAlignment.Right
        numBayar.ThousandsSeparator = True
        ' 
        ' btnUangPas
        ' 
        btnUangPas.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUangPas.Location = New Point(30, 278)
        btnUangPas.Name = "btnUangPas"
        btnUangPas.Size = New Size(140, 40)
        btnUangPas.TabIndex = 5
        btnUangPas.Text = "Uang Pas"
        btnUangPas.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(30, 330)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 28)
        Label4.TabIndex = 6
        Label4.Text = "Kembalian"
        ' 
        ' lblKembalian
        ' 
        lblKembalian.AutoSize = True
        lblKembalian.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKembalian.ForeColor = Color.ForestGreen
        lblKembalian.Location = New Point(30, 358)
        lblKembalian.Name = "lblKembalian"
        lblKembalian.Size = New Size(160, 48)
        lblKembalian.TabIndex = 7
        lblKembalian.Text = "Rp 0"
        ' 
        ' btnBayar
        ' 
        btnBayar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBayar.Location = New Point(200, 430)
        btnBayar.Name = "btnBayar"
        btnBayar.Size = New Size(150, 45)
        btnBayar.TabIndex = 8
        btnBayar.Text = "Bayar & Simpan"
        btnBayar.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.DialogResult = DialogResult.Cancel
        btnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBatal.Location = New Point(360, 430)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(130, 45)
        btnBatal.TabIndex = 9
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AcceptButton = btnBayar
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnBatal
        ClientSize = New Size(520, 505)
        Controls.Add(btnBatal)
        Controls.Add(btnBayar)
        Controls.Add(lblKembalian)
        Controls.Add(Label4)
        Controls.Add(btnUangPas)
        Controls.Add(numBayar)
        Controls.Add(Label3)
        Controls.Add(lblTotal)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form5"
        StartPosition = FormStartPosition.CenterParent
        Text = "Pembayaran"
        Panel1.ResumeLayout(False)
        CType(numBayar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents numBayar As NumericUpDown
    Friend WithEvents btnUangPas As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblKembalian As Label
    Friend WithEvents btnBayar As Button
    Friend WithEvents btnBatal As Button
End Class
