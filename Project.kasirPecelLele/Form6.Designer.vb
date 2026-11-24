<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        RichTextBox1 = New RichTextBox()
        btnCetak = New Button()
        btnTutup = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Firebrick
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(560, 70)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(560, 70)
        Label1.TabIndex = 0
        Label1.Text = "STRUK TRANSAKSI"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.White
        RichTextBox1.BorderStyle = BorderStyle.FixedSingle
        RichTextBox1.Font = New Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(20, 90)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(520, 520)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = ""
        RichTextBox1.WordWrap = False
        ' 
        ' btnCetak
        ' 
        btnCetak.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCetak.Location = New Point(20, 630)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(160, 45)
        btnCetak.TabIndex = 2
        btnCetak.Text = "Cetak Struk"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' btnTutup
        ' 
        btnTutup.DialogResult = DialogResult.Cancel
        btnTutup.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTutup.Location = New Point(380, 630)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(160, 45)
        btnTutup.TabIndex = 3
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = True
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnTutup
        ClientSize = New Size(560, 700)
        Controls.Add(btnTutup)
        Controls.Add(btnCetak)
        Controls.Add(RichTextBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form6"
        StartPosition = FormStartPosition.CenterParent
        Text = "Struk Transaksi"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnTutup As Button
End Class
