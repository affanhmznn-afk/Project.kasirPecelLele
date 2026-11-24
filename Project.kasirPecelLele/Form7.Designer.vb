<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim dataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        txtNama = New TextBox()
        Label3 = New Label()
        cboKategori = New ComboBox()
        Label4 = New Label()
        numHarga = New NumericUpDown()
        btnTambah = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBersih = New Button()
        btnKembali = New Button()
        DataGridView1 = New DataGridView()
        colId = New DataGridViewTextBoxColumn()
        colNama = New DataGridViewTextBoxColumn()
        colKategori = New DataGridViewTextBoxColumn()
        colHarga = New DataGridViewTextBoxColumn()
        lblInfo = New Label()
        Panel1.SuspendLayout()
        CType(numHarga, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Firebrick
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1000, 70)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1000, 70)
        Label1.TabIndex = 0
        Label1.Text = "KELOLA MENU"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(20, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 32)
        Label2.TabIndex = 1
        Label2.Text = "Nama Menu"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNama.Location = New Point(20, 130)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(300, 39)
        txtNama.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(340, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 32)
        Label3.TabIndex = 3
        Label3.Text = "Kategori"
        ' 
        ' cboKategori
        ' 
        cboKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cboKategori.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboKategori.FormattingEnabled = True
        cboKategori.Location = New Point(340, 130)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(200, 39)
        cboKategori.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(560, 95)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 32)
        Label4.TabIndex = 5
        Label4.Text = "Harga"
        ' 
        ' numHarga
        ' 
        numHarga.DecimalPlaces = 0
        numHarga.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        numHarga.Location = New Point(560, 130)
        numHarga.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        numHarga.Name = "numHarga"
        numHarga.Size = New Size(200, 39)
        numHarga.TabIndex = 6
        numHarga.TextAlign = HorizontalAlignment.Right
        numHarga.ThousandsSeparator = True
        ' 
        ' btnTambah
        ' 
        btnTambah.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambah.Location = New Point(20, 195)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(150, 45)
        btnTambah.TabIndex = 7
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUbah.Location = New Point(180, 195)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(150, 45)
        btnUbah.TabIndex = 8
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.Location = New Point(340, 195)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(150, 45)
        btnHapus.TabIndex = 9
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBersih
        ' 
        btnBersih.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBersih.Location = New Point(500, 195)
        btnBersih.Name = "btnBersih"
        btnBersih.Size = New Size(150, 45)
        btnBersih.TabIndex = 10
        btnBersih.Text = "Bersihkan"
        btnBersih.UseVisualStyleBackColor = True
        ' 
        ' btnKembali
        ' 
        btnKembali.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali.Location = New Point(820, 195)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(160, 45)
        btnKembali.TabIndex = 11
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.White
        colId.DataPropertyName = "id_menu"
        colId.HeaderText = "id"
        colId.Name = "colId"
        colId.ReadOnly = True
        colId.Visible = False
        colNama.DataPropertyName = "nama_menu"
        colNama.HeaderText = "Nama Menu"
        colNama.Name = "colNama"
        colNama.ReadOnly = True
        colKategori.DataPropertyName = "kategori"
        colKategori.HeaderText = "Kategori"
        colKategori.Name = "colKategori"
        colKategori.ReadOnly = True
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight
        dataGridViewCellStyle1.Format = "'Rp' #,##0"
        colHarga.DefaultCellStyle = dataGridViewCellStyle1
        colHarga.DataPropertyName = "harga"
        colHarga.HeaderText = "Harga"
        colHarga.Name = "colHarga"
        colHarga.ReadOnly = True
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {colId, colNama, colKategori, colHarga})
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(20, 265)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 82
        DataGridView1.RowTemplate.Height = 32
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(960, 380)
        DataGridView1.TabIndex = 12
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.ForeColor = Color.DimGray
        lblInfo.Location = New Point(20, 655)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(450, 32)
        lblInfo.TabIndex = 13
        lblInfo.Text = "Pilih data di tabel untuk mengubah atau menghapus."
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 700)
        Controls.Add(lblInfo)
        Controls.Add(DataGridView1)
        Controls.Add(btnKembali)
        Controls.Add(btnBersih)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnTambah)
        Controls.Add(numHarga)
        Controls.Add(Label4)
        Controls.Add(cboKategori)
        Controls.Add(Label3)
        Controls.Add(txtNama)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "Form7"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kelola Menu"
        Panel1.ResumeLayout(False)
        CType(numHarga, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboKategori As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents numHarga As NumericUpDown
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBersih As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colNama As DataGridViewTextBoxColumn
    Friend WithEvents colKategori As DataGridViewTextBoxColumn
    Friend WithEvents colHarga As DataGridViewTextBoxColumn
    Friend WithEvents lblInfo As Label
End Class
