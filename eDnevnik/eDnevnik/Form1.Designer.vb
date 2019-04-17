<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1Login))
        Me.RadioButtonUcenik = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAdmin = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.RadioButtonProfesor = New System.Windows.Forms.RadioButton()
        Me.GroupBoxKorisnici = New System.Windows.Forms.GroupBox()
        Me.PictureBoxGemit = New System.Windows.Forms.PictureBox()
        Me.PictureBoxAdmin = New System.Windows.Forms.PictureBox()
        Me.PictureBoxUcenik = New System.Windows.Forms.PictureBox()
        Me.PictureBoxProfesor = New System.Windows.Forms.PictureBox()
        Me.ButtonRegistracija = New System.Windows.Forms.Button()
        Me.ButtonPrijava = New System.Windows.Forms.Button()
        Me.GroupBoxKorisnici.SuspendLayout()
        CType(Me.PictureBoxGemit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxUcenik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxProfesor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadioButtonUcenik
        '
        Me.RadioButtonUcenik.AutoSize = True
        Me.RadioButtonUcenik.Location = New System.Drawing.Point(12, 114)
        Me.RadioButtonUcenik.Name = "RadioButtonUcenik"
        Me.RadioButtonUcenik.Size = New System.Drawing.Size(59, 17)
        Me.RadioButtonUcenik.TabIndex = 3
        Me.RadioButtonUcenik.TabStop = True
        Me.RadioButtonUcenik.Text = "Ucenik"
        Me.RadioButtonUcenik.UseVisualStyleBackColor = True
        '
        'RadioButtonAdmin
        '
        Me.RadioButtonAdmin.AutoSize = True
        Me.RadioButtonAdmin.Location = New System.Drawing.Point(12, 173)
        Me.RadioButtonAdmin.Name = "RadioButtonAdmin"
        Me.RadioButtonAdmin.Size = New System.Drawing.Size(54, 17)
        Me.RadioButtonAdmin.TabIndex = 4
        Me.RadioButtonAdmin.TabStop = True
        Me.RadioButtonAdmin.Text = "Admin"
        Me.RadioButtonAdmin.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(220, 112)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(142, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(220, 154)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(142, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(220, 198)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(142, 20)
        Me.TextBox3.TabIndex = 7
        '
        'RadioButtonProfesor
        '
        Me.RadioButtonProfesor.AutoSize = True
        Me.RadioButtonProfesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonProfesor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButtonProfesor.Location = New System.Drawing.Point(12, 47)
        Me.RadioButtonProfesor.Name = "RadioButtonProfesor"
        Me.RadioButtonProfesor.Size = New System.Drawing.Size(64, 17)
        Me.RadioButtonProfesor.TabIndex = 2
        Me.RadioButtonProfesor.TabStop = True
        Me.RadioButtonProfesor.Text = "Profesor"
        Me.RadioButtonProfesor.UseVisualStyleBackColor = True
        '
        'GroupBoxKorisnici
        '
        Me.GroupBoxKorisnici.Controls.Add(Me.RadioButtonProfesor)
        Me.GroupBoxKorisnici.Controls.Add(Me.PictureBoxAdmin)
        Me.GroupBoxKorisnici.Controls.Add(Me.RadioButtonUcenik)
        Me.GroupBoxKorisnici.Controls.Add(Me.PictureBoxUcenik)
        Me.GroupBoxKorisnici.Controls.Add(Me.RadioButtonAdmin)
        Me.GroupBoxKorisnici.Controls.Add(Me.PictureBoxProfesor)
        Me.GroupBoxKorisnici.Location = New System.Drawing.Point(12, 94)
        Me.GroupBoxKorisnici.Name = "GroupBoxKorisnici"
        Me.GroupBoxKorisnici.Size = New System.Drawing.Size(139, 212)
        Me.GroupBoxKorisnici.TabIndex = 12
        Me.GroupBoxKorisnici.TabStop = False
        '
        'PictureBoxGemit
        '
        Me.PictureBoxGemit.Image = Global.eDnevnik.My.Resources.Resources.book_128x128
        Me.PictureBoxGemit.Location = New System.Drawing.Point(385, 12)
        Me.PictureBoxGemit.Name = "PictureBoxGemit"
        Me.PictureBoxGemit.Size = New System.Drawing.Size(134, 130)
        Me.PictureBoxGemit.TabIndex = 13
        Me.PictureBoxGemit.TabStop = False
        '
        'PictureBoxAdmin
        '
        Me.PictureBoxAdmin.Image = Global.eDnevnik.My.Resources.Resources.administrator_32x32
        Me.PictureBoxAdmin.Location = New System.Drawing.Point(82, 161)
        Me.PictureBoxAdmin.Name = "PictureBoxAdmin"
        Me.PictureBoxAdmin.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxAdmin.TabIndex = 11
        Me.PictureBoxAdmin.TabStop = False
        '
        'PictureBoxUcenik
        '
        Me.PictureBoxUcenik.Image = Global.eDnevnik.My.Resources.Resources.student_32x321
        Me.PictureBoxUcenik.Location = New System.Drawing.Point(82, 99)
        Me.PictureBoxUcenik.Name = "PictureBoxUcenik"
        Me.PictureBoxUcenik.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxUcenik.TabIndex = 10
        Me.PictureBoxUcenik.TabStop = False
        '
        'PictureBoxProfesor
        '
        Me.PictureBoxProfesor.Image = Global.eDnevnik.My.Resources.Resources._32x32
        Me.PictureBoxProfesor.Location = New System.Drawing.Point(82, 32)
        Me.PictureBoxProfesor.Name = "PictureBoxProfesor"
        Me.PictureBoxProfesor.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxProfesor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxProfesor.TabIndex = 8
        Me.PictureBoxProfesor.TabStop = False
        '
        'ButtonRegistracija
        '
        Me.ButtonRegistracija.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegistracija.Image = Global.eDnevnik.My.Resources.Resources.registration_32x32
        Me.ButtonRegistracija.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRegistracija.Location = New System.Drawing.Point(297, 242)
        Me.ButtonRegistracija.Name = "ButtonRegistracija"
        Me.ButtonRegistracija.Size = New System.Drawing.Size(130, 35)
        Me.ButtonRegistracija.TabIndex = 1
        Me.ButtonRegistracija.Text = "Registracija"
        Me.ButtonRegistracija.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRegistracija.UseVisualStyleBackColor = True
        '
        'ButtonPrijava
        '
        Me.ButtonPrijava.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrijava.Image = Global.eDnevnik.My.Resources.Resources.login_32x32
        Me.ButtonPrijava.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonPrijava.Location = New System.Drawing.Point(167, 242)
        Me.ButtonPrijava.Name = "ButtonPrijava"
        Me.ButtonPrijava.Size = New System.Drawing.Size(100, 35)
        Me.ButtonPrijava.TabIndex = 0
        Me.ButtonPrijava.Text = "Prijava"
        Me.ButtonPrijava.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPrijava.UseVisualStyleBackColor = True
        '
        'Form1Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(531, 316)
        Me.Controls.Add(Me.PictureBoxGemit)
        Me.Controls.Add(Me.GroupBoxKorisnici)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ButtonRegistracija)
        Me.Controls.Add(Me.ButtonPrijava)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(547, 355)
        Me.MinimumSize = New System.Drawing.Size(547, 355)
        Me.Name = "Form1Login"
        Me.Text = "eDnevnik"
        Me.GroupBoxKorisnici.ResumeLayout(False)
        Me.GroupBoxKorisnici.PerformLayout()
        CType(Me.PictureBoxGemit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxUcenik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxProfesor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonPrijava As Button
    Friend WithEvents ButtonRegistracija As Button
    Friend WithEvents RadioButtonProfesor As RadioButton
    Friend WithEvents RadioButtonUcenik As RadioButton
    Friend WithEvents RadioButtonAdmin As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBoxProfesor As PictureBox
    Friend WithEvents PictureBoxUcenik As PictureBox
    Friend WithEvents PictureBoxAdmin As PictureBox
    Friend WithEvents GroupBoxKorisnici As GroupBox
    Friend WithEvents PictureBoxGemit As PictureBox
End Class
