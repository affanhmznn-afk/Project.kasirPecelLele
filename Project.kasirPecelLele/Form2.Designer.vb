<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        btnUser = New Button()
        btnAdmin = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Firebrick
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1772, 200)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Algerian", 19.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Yellow
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1772, 200)
        Label1.TabIndex = 0
        Label1.Text = "KEDAI PECEL LELE SEDERHANA"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(636, 640)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(500, 260)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Firebrick
        Label2.Location = New Point(0, 245)
        Label2.Name = "Label2"
        Label2.Size = New Size(1772, 60)
        Label2.TabIndex = 1
        Label2.Text = "SELAMAT DATANG"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(0, 315)
        Label3.Name = "Label3"
        Label3.Size = New Size(1772, 40)
        Label3.TabIndex = 2
        Label3.Text = "Silakan pilih jenis pengguna untuk melanjutkan"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnUser
        ' 
        btnUser.BackColor = Color.Firebrick
        btnUser.Cursor = Cursors.Hand
        btnUser.FlatAppearance.BorderSize = 0
        btnUser.FlatStyle = FlatStyle.Flat
        btnUser.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUser.ForeColor = Color.White
        btnUser.Location = New Point(400, 390)
        btnUser.Name = "btnUser"
        btnUser.Size = New Size(440, 150)
        btnUser.TabIndex = 3
        btnUser.Text = "MASUK SEBAGAI USER"
        btnUser.UseVisualStyleBackColor = False
        ' 
        ' btnAdmin
        ' 
        btnAdmin.BackColor = Color.SteelBlue
        btnAdmin.Cursor = Cursors.Hand
        btnAdmin.FlatAppearance.BorderSize = 0
        btnAdmin.FlatStyle = FlatStyle.Flat
        btnAdmin.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdmin.ForeColor = Color.White
        btnAdmin.Location = New Point(932, 390)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(440, 150)
        btnAdmin.TabIndex = 4
        btnAdmin.Text = "MASUK SEBAGAI ADMIN"
        btnAdmin.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DimGray
        Label4.Location = New Point(400, 555)
        Label4.Name = "Label4"
        Label4.Size = New Size(440, 60)
        Label4.TabIndex = 5
        Label4.Text = "Tanpa password - Bisa memesan dan melihat menu"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DimGray
        Label5.Location = New Point(932, 555)
        Label5.Name = "Label5"
        Label5.Size = New Size(440, 60)
        Label5.TabIndex = 6
        Label5.Text = "Perlu password - Akses data lengkap"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1772, 958)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnAdmin)
        Controls.Add(btnUser)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pilih Pengguna - Kasir Pecel Lele"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUser As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
