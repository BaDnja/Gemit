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
        Me.TextBoxIme = New System.Windows.Forms.TextBox()
        Me.TextBoxSifra = New System.Windows.Forms.TextBox()
        Me.RadioButtonProfesor = New System.Windows.Forms.RadioButton()
        Me.GroupBoxKorisnici = New System.Windows.Forms.GroupBox()
        Me.PictureBoxAdmin = New System.Windows.Forms.PictureBox()
        Me.PictureBoxUcenik = New System.Windows.Forms.PictureBox()
        Me.PictureBoxProfesor = New System.Windows.Forms.PictureBox()
        Me.ButtonEye = New System.Windows.Forms.Button()
        Me.PictureBoxGemit = New System.Windows.Forms.PictureBox()
        Me.ButtonRegistracija = New System.Windows.Forms.Button()
        Me.ButtonPrijava = New System.Windows.Forms.Button()
        Me.GroupBoxKorisnici.SuspendLayout()
        CType(Me.PictureBoxAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxUcenik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxProfesor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxGemit, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RadioButtonUcenik.Text = "Učenik"
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
        'TextBoxIme
        '
        Me.TextBoxIme.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxIme.Location = New System.Drawing.Point(173, 111)
        Me.TextBoxIme.Name = "TextBoxIme"
        Me.TextBoxIme.Size = New System.Drawing.Size(142, 20)
        Me.TextBoxIme.TabIndex = 5
        Me.TextBoxIme.Text = "Korisničko ime"
        '
        'TextBoxSifra
        '
        Me.TextBoxSifra.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxSifra.Location = New System.Drawing.Point(173, 146)
        Me.TextBoxSifra.Name = "TextBoxSifra"
        Me.TextBoxSifra.Size = New System.Drawing.Size(142, 20)
        Me.TextBoxSifra.TabIndex = 7
        Me.TextBoxSifra.Text = "Šifra"
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
        Me.GroupBoxKorisnici.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxKorisnici.Name = "GroupBoxKorisnici"
        Me.GroupBoxKorisnici.Size = New System.Drawing.Size(139, 212)
        Me.GroupBoxKorisnici.TabIndex = 12
        Me.GroupBoxKorisnici.TabStop = False
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
        'ButtonEye
        '
        Me.ButtonEye.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ButtonEye.BackgroundImage = Global.eDnevnik.My.Resources.Resources.eye_32x32
        Me.ButtonEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonEye.Location = New System.Drawing.Point(321, 136)
        Me.ButtonEye.Name = "ButtonEye"
        Me.ButtonEye.Size = New System.Drawing.Size(38, 38)
        Me.ButtonEye.TabIndex = 14
        Me.ButtonEye.UseVisualStyleBackColor = False
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
        'ButtonRegistracija
        '
        Me.ButtonRegistracija.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegistracija.Image = Global.eDnevnik.My.Resources.Resources.registration_32x32
        Me.ButtonRegistracija.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRegistracija.Location = New System.Drawing.Point(389, 189)
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
        Me.ButtonPrijava.Location = New System.Drawing.Point(192, 181)
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
        Me.ClientSize = New System.Drawing.Size(525, 237)
        Me.Controls.Add(Me.ButtonEye)
        Me.Controls.Add(Me.PictureBoxGemit)
        Me.Controls.Add(Me.GroupBoxKorisnici)
        Me.Controls.Add(Me.TextBoxSifra)
        Me.Controls.Add(Me.TextBoxIme)
        Me.Controls.Add(Me.ButtonRegistracija)
        Me.Controls.Add(Me.ButtonPrijava)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(545, 280)
        Me.MinimumSize = New System.Drawing.Size(545, 280)
        Me.Name = "Form1Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eDnevnik"
        Me.GroupBoxKorisnici.ResumeLayout(False)
        Me.GroupBoxKorisnici.PerformLayout()
        CType(Me.PictureBoxAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxUcenik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxProfesor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxGemit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonPrijava As Button
    Friend WithEvents ButtonRegistracija As Button
    Friend WithEvents RadioButtonProfesor As RadioButton
    Friend WithEvents RadioButtonUcenik As RadioButton
    Friend WithEvents RadioButtonAdmin As RadioButton
    Friend WithEvents TextBoxIme As TextBox
    Friend WithEvents TextBoxSifra As TextBox
    Friend WithEvents PictureBoxProfesor As PictureBox
    Friend WithEvents PictureBoxUcenik As PictureBox
    Friend WithEvents PictureBoxAdmin As PictureBox
    Friend WithEvents GroupBoxKorisnici As GroupBox
    Friend WithEvents PictureBoxGemit As PictureBox
    Friend WithEvents ButtonEye As Button
End Class
