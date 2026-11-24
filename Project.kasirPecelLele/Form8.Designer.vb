<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Panel2 = New Panel()
        lblKasir = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Panel3 = New Panel()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Firebrick
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1400, 110)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1400, 110)
        Label1.TabIndex = 0
        Label1.Text = "DASHBOARD ADMIN"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Panel2.BackColor = Color.Firebrick
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(lblKasir)
        Panel2.Location = New Point(0, 110)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(360, 740)
        Panel2.TabIndex = 1
        ' 
        ' lblKasir
        ' 
        lblKasir.AutoSize = True
        lblKasir.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKasir.ForeColor = Color.Yellow
        lblKasir.Location = New Point(30, 30)
        lblKasir.Name = "lblKasir"
        lblKasir.Size = New Size(150, 32)
        lblKasir.TabIndex = 0
        lblKasir.Text = "Admin: -"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Yellow
        Label3.Location = New Point(30, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(180, 38)
        Label3.TabIndex = 1
        Label3.Text = "MENU ADMIN"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Firebrick
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(30, 140)
        Button1.Name = "Button1"
        Button1.Size = New Size(300, 60)
        Button1.TabIndex = 2
        Button1.Text = "Transaksi"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Firebrick
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(30, 230)
        Button2.Name = "Button2"
        Button2.Size = New Size(300, 60)
        Button2.TabIndex = 3
        Button2.Text = "Riwayat Transaksi"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Firebrick
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(30, 320)
        Button3.Name = "Button3"
        Button3.Size = New Size(300, 60)
        Button3.TabIndex = 4
        Button3.Text = "Kelola Menu"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Firebrick
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(30, 650)
        Button4.Name = "Button4"
        Button4.Size = New Size(300, 55)
        Button4.TabIndex = 5
        Button4.Text = "Logout"
        Button4.TextAlign = ContentAlignment.MiddleLeft
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(400, 150)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(950, 620)
        Panel3.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Firebrick
        Label2.Location = New Point(30, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(890, 50)
        Label2.TabIndex = 0
        Label2.Text = "Selamat datang di Dashboard Admin"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DimGray
        Label4.Location = New Point(30, 100)
        Label4.Name = "Label4"
        Label4.Size = New Size(890, 60)
        Label4.TabIndex = 1
        Label4.Text = "Gunakan menu di sebelah kiri untuk mengakses transaksi, riwayat, dan pengelolaan menu."
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DimGray
        Label5.Location = New Point(30, 200)
        Label5.Name = "Label5"
        Label5.Size = New Size(890, 220)
        Label5.TabIndex = 2
        Label5.Text = "Hak akses admin:" & vbCrLf &
            "- Melihat riwayat transaksi dan ringkasan pendapatan" & vbCrLf &
            "- Mengelola data menu (tambah, ubah, hapus)" & vbCrLf &
            "- Melakukan transaksi kasir"
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1400, 850)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form8"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard Admin - Kasir Pecel Lele"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblKasir As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
