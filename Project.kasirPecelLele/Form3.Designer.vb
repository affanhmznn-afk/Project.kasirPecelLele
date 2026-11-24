<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        Button2 = New Button()
        ComboBox2 = New ComboBox()
        Panel1 = New Panel()
        btnKembali = New Button()
        btnHapus = New Button()
        lblTotal = New Label()
        Label3 = New Label()
        Label2 = New Label()
        NumericUpDown2 = New NumericUpDown()
        NumericUpDown1 = New NumericUpDown()
        Button3 = New Button()
        DataGridView1 = New DataGridView()
        colIdMenu = New DataGridViewTextBoxColumn()
        colMenu = New DataGridViewTextBoxColumn()
        colKategori = New DataGridViewTextBoxColumn()
        colHarga = New DataGridViewTextBoxColumn()
        colQty = New DataGridViewTextBoxColumn()
        colTotal = New DataGridViewTextBoxColumn()
        colPembeli = New DataGridViewTextBoxColumn()
        txtNamaPembeli = New TextBox()
        Label4 = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(111, 307)
        Button1.Name = "Button1"
        Button1.Size = New Size(203, 57)
        Button1.TabIndex = 0
        Button1.Text = "Tambah Makanan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(377, 321)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(242, 40)
        ComboBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(482, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(537, 59)
        Label1.TabIndex = 2
        Label1.Text = "Silakan Pilih Menu Anda"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(858, 307)
        Button2.Name = "Button2"
        Button2.Size = New Size(203, 59)
        Button2.TabIndex = 3
        Button2.Text = "Tambah Minuman"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(1152, 321)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(242, 40)
        ComboBox2.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Panel1.Controls.Add(btnKembali)
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(lblTotal)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(NumericUpDown2)
        Panel1.Controls.Add(NumericUpDown1)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(ComboBox2)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtNamaPembeli)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(69, 49)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1507, 817)
        Panel1.TabIndex = 5
        ' 
        ' btnKembali
        ' 
        btnKembali.Font = New Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali.Location = New Point(1223, 393)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(187, 58)
        btnKembali.TabIndex = 13
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.Location = New Point(1223, 705)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(187, 58)
        btnHapus.TabIndex = 12
        btnHapus.Text = "Hapus Item"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.ForeColor = Color.White
        lblTotal.Location = New Point(1094, 624)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(193, 59)
        lblTotal.TabIndex = 11
        lblTotal.Text = "TOTAL :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(1415, 284)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 32)
        Label3.TabIndex = 10
        Label3.Text = "Qty"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(640, 284)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 32)
        Label2.TabIndex = 9
        Label2.Text = "Qty"
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NumericUpDown2.Location = New Point(1415, 321)
        NumericUpDown2.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(80, 50)
        NumericUpDown2.TabIndex = 8
        NumericUpDown2.TextAlign = HorizontalAlignment.Center
        NumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NumericUpDown1.Location = New Point(640, 321)
        NumericUpDown1.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(80, 50)
        NumericUpDown1.TabIndex = 7
        NumericUpDown1.TextAlign = HorizontalAlignment.Center
        NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(1223, 552)
        Button3.Name = "Button3"
        Button3.Size = New Size(187, 58)
        Button3.TabIndex = 6
        Button3.Text = "Bayar & Simpan"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {colIdMenu, colMenu, colKategori, colHarga, colQty, colTotal, colPembeli})
        DataGridView1.Location = New Point(58, 393)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 82
        DataGridView1.RowTemplate.Height = 32
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1030, 381)
        DataGridView1.TabIndex = 5
        ' 
        ' colIdMenu
        ' 
        colIdMenu.HeaderText = "id_menu"
        colIdMenu.MinimumWidth = 10
        colIdMenu.Name = "colIdMenu"
        colIdMenu.ReadOnly = True
        colIdMenu.Visible = False
        ' 
        ' colMenu
        ' 
        colMenu.HeaderText = "Menu"
        colMenu.MinimumWidth = 10
        colMenu.Name = "colMenu"
        colMenu.ReadOnly = True
        ' 
        ' colKategori
        ' 
        colKategori.HeaderText = "Kategori"
        colKategori.MinimumWidth = 10
        colKategori.Name = "colKategori"
        colKategori.ReadOnly = True
        ' 
        ' colHarga
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "'Rp' #,##0"
        DataGridViewCellStyle1.NullValue = "0"
        colHarga.DefaultCellStyle = DataGridViewCellStyle1
        colHarga.HeaderText = "Harga"
        colHarga.MinimumWidth = 10
        colHarga.Name = "colHarga"
        colHarga.ReadOnly = True
        ' 
        ' colQty
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        colQty.DefaultCellStyle = DataGridViewCellStyle2
        colQty.HeaderText = "Qty"
        colQty.MinimumWidth = 10
        colQty.Name = "colQty"
        ' 
        ' colTotal
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "'Rp' #,##0"
        DataGridViewCellStyle3.NullValue = "0"
        colTotal.DefaultCellStyle = DataGridViewCellStyle3
        colTotal.HeaderText = "Total"
        colTotal.MinimumWidth = 10
        colTotal.Name = "colTotal"
        colTotal.ReadOnly = True
        ' 
        ' colPembeli
        ' 
        colPembeli.HeaderText = "Pembeli"
        colPembeli.MinimumWidth = 10
        colPembeli.Name = "colPembeli"
        colPembeli.ReadOnly = True
        ' 
        ' txtNamaPembeli
        ' 
        txtNamaPembeli.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNamaPembeli.Location = New Point(300, 202)
        txtNamaPembeli.MaxLength = 50
        txtNamaPembeli.Name = "txtNamaPembeli"
        txtNamaPembeli.PlaceholderText = "Masukkan nama pembeli"
        txtNamaPembeli.Size = New Size(420, 50)
        txtNamaPembeli.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(39, 205)
        Label4.Name = "Label4"
        Label4.Size = New Size(246, 45)
        Label4.TabIndex = 14
        Label4.Text = "Nama Pembeli:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Location = New Point(1, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1852, 988)
        Panel2.TabIndex = 0
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1632, 955)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Transaksi Kasir"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents colIdMenu As DataGridViewTextBoxColumn
    Friend WithEvents colMenu As DataGridViewTextBoxColumn
    Friend WithEvents colKategori As DataGridViewTextBoxColumn
    Friend WithEvents colHarga As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents colPembeli As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNamaPembeli As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnKembali As Button
End Class
