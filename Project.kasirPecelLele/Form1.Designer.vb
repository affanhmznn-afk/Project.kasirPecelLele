<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtusername = New TextBox()
        txtpassword = New TextBox()
        btnlogin = New Button()
        btnkeluar = New Button()
        btnKembali = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 28.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(460, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(445, 89)
        Label1.TabIndex = 0
        Label1.Text = "Pecel Lele"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(199, 327)
        Label2.Name = "Label2"
        Label2.Size = New Size(164, 32)
        Label2.TabIndex = 1
        Label2.Text = "USERNAME :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(199, 427)
        Label3.Name = "Label3"
        Label3.Size = New Size(168, 32)
        Label3.TabIndex = 2
        Label3.Text = "PASSWORD :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Firebrick
        Label4.Location = New Point(460, 220)
        Label4.Name = "Label4"
        Label4.Size = New Size(190, 38)
        Label4.TabIndex = 7
        Label4.Text = "LOGIN ADMIN"
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(419, 320)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(486, 39)
        txtusername.TabIndex = 3
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(419, 424)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(486, 39)
        txtpassword.TabIndex = 4
        txtpassword.UseSystemPasswordChar = True
        ' 
        ' btnlogin
        ' 
        btnlogin.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnlogin.Location = New Point(381, 613)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(150, 46)
        btnlogin.TabIndex = 5
        btnlogin.Text = "Login"
        btnlogin.UseVisualStyleBackColor = True
        ' 
        ' btnkeluar
        ' 
        btnkeluar.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnkeluar.Location = New Point(659, 613)
        btnkeluar.Name = "btnkeluar"
        btnkeluar.Size = New Size(150, 46)
        btnkeluar.TabIndex = 6
        btnkeluar.Text = "Bersihkan"
        btnkeluar.UseVisualStyleBackColor = True
        ' 
        ' btnKembali
        ' 
        btnKembali.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali.Location = New Point(850, 613)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(150, 46)
        btnKembali.TabIndex = 8
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AcceptButton = btnlogin
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnKembali
        ClientSize = New Size(1292, 888)
        Controls.Add(btnKembali)
        Controls.Add(btnkeluar)
        Controls.Add(btnlogin)
        Controls.Add(txtpassword)
        Controls.Add(txtusername)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Admin - Kasir Pecel Lele"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents btnKembali As Button

End Class
