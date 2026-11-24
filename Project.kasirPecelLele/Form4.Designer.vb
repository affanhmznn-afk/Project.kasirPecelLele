<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim dataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim dataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim dataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim dataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        DateTimePicker2 = New DateTimePicker()
        btnTampilkan = New Button()
        btnHariIni = New Button()
        btnKembali = New Button()
        lblJumlah = New Label()
        lblPendapatan = New Label()
        Label4 = New Label()
        btnLihatStruk = New Button()
        DataGridView1 = New DataGridView()
        colId = New DataGridViewTextBoxColumn()
        colNo = New DataGridViewTextBoxColumn()
        colTanggal = New DataGridViewTextBoxColumn()
        colKasir = New DataGridViewTextBoxColumn()
        colPembeli = New DataGridViewTextBoxColumn()
        colTotal = New DataGridViewTextBoxColumn()
        colBayar = New DataGridViewTextBoxColumn()
        colKembalian = New DataGridViewTextBoxColumn()
        Label5 = New Label()
        DataGridView2 = New DataGridView()
        colMenu = New DataGridViewTextBoxColumn()
        colKategori = New DataGridViewTextBoxColumn()
        colHarga = New DataGridViewTextBoxColumn()
        colQty = New DataGridViewTextBoxColumn()
        colSubtotal = New DataGridViewTextBoxColumn()
        lblInfo = New Label()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Firebrick
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1200, 80)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1200, 80)
        Label1.TabIndex = 0
        Label1.Text = "RIWAYAT TRANSAKSI"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(20, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 32)
        Label2.TabIndex = 1
        Label2.Text = "Dari"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(80, 100)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(150, 39)
        DateTimePicker1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(250, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 32)
        Label3.TabIndex = 3
        Label3.Text = "Sampai"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.Location = New Point(338, 100)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(150, 39)
        DateTimePicker2.TabIndex = 4
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTampilkan.Location = New Point(510, 96)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(130, 42)
        btnTampilkan.TabIndex = 5
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' btnHariIni
        ' 
        btnHariIni.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHariIni.Location = New Point(650, 96)
        btnHariIni.Name = "btnHariIni"
        btnHariIni.Size = New Size(110, 42)
        btnHariIni.TabIndex = 6
        btnHariIni.Text = "Hari Ini"
        btnHariIni.UseVisualStyleBackColor = True
        ' 
        ' btnKembali
        ' 
        btnKembali.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali.Location = New Point(1040, 96)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(140, 42)
        btnKembali.TabIndex = 7
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJumlah.Location = New Point(20, 155)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(230, 32)
        lblJumlah.TabIndex = 8
        lblJumlah.Text = "Jumlah transaksi: 0"
        ' 
        ' lblPendapatan
        ' 
        lblPendapatan.AutoSize = True
        lblPendapatan.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPendapatan.ForeColor = Color.ForestGreen
        lblPendapatan.Location = New Point(350, 155)
        lblPendapatan.Name = "lblPendapatan"
        lblPendapatan.Size = New Size(300, 32)
        lblPendapatan.TabIndex = 9
        lblPendapatan.Text = "Total pendapatan: Rp 0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(20, 190)
        Label4.Name = "Label4"
        Label4.Size = New Size(210, 32)
        Label4.TabIndex = 10
        Label4.Text = "Daftar Transaksi"
        ' 
        ' btnLihatStruk
        ' 
        btnLihatStruk.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLihatStruk.Location = New Point(1000, 182)
        btnLihatStruk.Name = "btnLihatStruk"
        btnLihatStruk.Size = New Size(180, 38)
        btnLihatStruk.TabIndex = 11
        btnLihatStruk.Text = "Lihat Struk"
        btnLihatStruk.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.White
        colId.DataPropertyName = "id_transaksi"
        colId.HeaderText = "id"
        colId.Name = "colId"
        colId.ReadOnly = True
        colId.Visible = False
        colNo.DataPropertyName = "no_transaksi"
        colNo.HeaderText = "No. Transaksi"
        colNo.Name = "colNo"
        colNo.ReadOnly = True
        colTanggal.DataPropertyName = "tanggal"
        colTanggal.HeaderText = "Tanggal"
        colTanggal.Name = "colTanggal"
        colTanggal.ReadOnly = True
        colKasir.DataPropertyName = "username"
        colKasir.HeaderText = "Kasir"
        colKasir.Name = "colKasir"
        colKasir.ReadOnly = True
        colPembeli.DataPropertyName = "nama_pembeli"
        colPembeli.HeaderText = "Pembeli"
        colPembeli.Name = "colPembeli"
        colPembeli.ReadOnly = True
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight
        dataGridViewCellStyle1.Format = "'Rp' #,##0"
        colTotal.DefaultCellStyle = dataGridViewCellStyle1
        colTotal.DataPropertyName = "total"
        colTotal.HeaderText = "Total"
        colTotal.Name = "colTotal"
        colTotal.ReadOnly = True
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight
        dataGridViewCellStyle2.Format = "'Rp' #,##0"
        colBayar.DefaultCellStyle = dataGridViewCellStyle2
        colBayar.DataPropertyName = "bayar"
        colBayar.HeaderText = "Bayar"
        colBayar.Name = "colBayar"
        colBayar.ReadOnly = True
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight
        dataGridViewCellStyle3.Format = "'Rp' #,##0"
        colKembalian.DefaultCellStyle = dataGridViewCellStyle3
        colKembalian.DataPropertyName = "kembalian"
        colKembalian.HeaderText = "Kembalian"
        colKembalian.Name = "colKembalian"
        colKembalian.ReadOnly = True
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {colId, colNo, colTanggal, colKasir, colPembeli, colTotal, colBayar, colKembalian})
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(20, 225)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 82
        DataGridView1.RowTemplate.Height = 32
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1160, 230)
        DataGridView1.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(20, 470)
        Label5.Name = "Label5"
        Label5.Size = New Size(200, 32)
        Label5.TabIndex = 13
        Label5.Text = "Detail Transaksi"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.AllowUserToResizeRows = False
        DataGridView2.AutoGenerateColumns = False
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.BackgroundColor = Color.White
        colMenu.DataPropertyName = "nama_menu"
        colMenu.HeaderText = "Menu"
        colMenu.Name = "colMenu"
        colMenu.ReadOnly = True
        colKategori.DataPropertyName = "kategori"
        colKategori.HeaderText = "Kategori"
        colKategori.Name = "colKategori"
        colKategori.ReadOnly = True
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight
        dataGridViewCellStyle4.Format = "'Rp' #,##0"
        colHarga.DefaultCellStyle = dataGridViewCellStyle4
        colHarga.DataPropertyName = "harga"
        colHarga.HeaderText = "Harga"
        colHarga.Name = "colHarga"
        colHarga.ReadOnly = True
        dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        colQty.DefaultCellStyle = dataGridViewCellStyle5
        colQty.DataPropertyName = "qty"
        colQty.HeaderText = "Qty"
        colQty.Name = "colQty"
        colQty.ReadOnly = True
        colSubtotal.DataPropertyName = "subtotal"
        colSubtotal.HeaderText = "Subtotal"
        colSubtotal.Name = "colSubtotal"
        colSubtotal.ReadOnly = True
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {colMenu, colKategori, colHarga, colQty, colSubtotal})
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(20, 505)
        DataGridView2.MultiSelect = False
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersWidth = 82
        DataGridView2.RowTemplate.Height = 32
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.Size = New Size(1160, 155)
        DataGridView2.TabIndex = 14
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.ForeColor = Color.DimGray
        lblInfo.Location = New Point(20, 675)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(400, 32)
        lblInfo.TabIndex = 15
        lblInfo.Text = "Pilih baris transaksi untuk melihat detail."
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1200, 760)
        Controls.Add(lblInfo)
        Controls.Add(DataGridView2)
        Controls.Add(Label5)
        Controls.Add(DataGridView1)
        Controls.Add(btnLihatStruk)
        Controls.Add(Label4)
        Controls.Add(lblPendapatan)
        Controls.Add(lblJumlah)
        Controls.Add(btnKembali)
        Controls.Add(btnHariIni)
        Controls.Add(btnTampilkan)
        Controls.Add(DateTimePicker2)
        Controls.Add(Label3)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Riwayat Transaksi"
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnHariIni As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblPendapatan As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLihatStruk As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colNo As DataGridViewTextBoxColumn
    Friend WithEvents colTanggal As DataGridViewTextBoxColumn
    Friend WithEvents colKasir As DataGridViewTextBoxColumn
    Friend WithEvents colPembeli As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents colBayar As DataGridViewTextBoxColumn
    Friend WithEvents colKembalian As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents colMenu As DataGridViewTextBoxColumn
    Friend WithEvents colKategori As DataGridViewTextBoxColumn
    Friend WithEvents colHarga As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents lblInfo As Label
End Class
