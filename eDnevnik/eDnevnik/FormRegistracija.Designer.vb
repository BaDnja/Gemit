<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistracija
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistracija))
        Me.GroupBoxKorisnici = New System.Windows.Forms.GroupBox()
        Me.RadioButtonProfesor = New System.Windows.Forms.RadioButton()
        Me.PictureBoxAdmin = New System.Windows.Forms.PictureBox()
        Me.RadioButtonUcenik = New System.Windows.Forms.RadioButton()
        Me.PictureBoxUcenik = New System.Windows.Forms.PictureBox()
        Me.RadioButtonAdmin = New System.Windows.Forms.RadioButton()
        Me.PictureBoxProfesor = New System.Windows.Forms.PictureBox()
        Me.TextBoxIme = New System.Windows.Forms.TextBox()
        Me.TextBoxPrezime = New System.Windows.Forms.TextBox()
        Me.TextBoxJmbg = New System.Windows.Forms.TextBox()
        Me.TextBoxKorIme = New System.Windows.Forms.TextBox()
        Me.TextBoxSifra = New System.Windows.Forms.TextBox()
        Me.TextBoxRod = New System.Windows.Forms.TextBox()
        Me.TextBoxAdresa = New System.Windows.Forms.TextBox()
        Me.TextBoxDatum = New System.Windows.Forms.TextBox()
        Me.GroupBoxObavezna = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonRegistracija = New System.Windows.Forms.Button()
        Me.ButtonNazad = New System.Windows.Forms.Button()
        Me.GroupBoxKorisnici.SuspendLayout()
        CType(Me.PictureBoxAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxUcenik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxProfesor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxObavezna.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBoxKorisnici.TabIndex = 13
        Me.GroupBoxKorisnici.TabStop = False
        Me.GroupBoxKorisnici.Text = "Odaberite tip računa"
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
        'PictureBoxAdmin
        '
        Me.PictureBoxAdmin.Image = Global.eDnevnik.My.Resources.Resources.administrator_32x32
        Me.PictureBoxAdmin.Location = New System.Drawing.Point(82, 161)
        Me.PictureBoxAdmin.Name = "PictureBoxAdmin"
        Me.PictureBoxAdmin.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxAdmin.TabIndex = 11
        Me.PictureBoxAdmin.TabStop = False
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
        'PictureBoxUcenik
        '
        Me.PictureBoxUcenik.Image = Global.eDnevnik.My.Resources.Resources.student_32x321
        Me.PictureBoxUcenik.Location = New System.Drawing.Point(82, 99)
        Me.PictureBoxUcenik.Name = "PictureBoxUcenik"
        Me.PictureBoxUcenik.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxUcenik.TabIndex = 10
        Me.PictureBoxUcenik.TabStop = False
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
        'TextBoxIme
        '
        Me.TextBoxIme.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxIme.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxIme.Name = "TextBoxIme"
        Me.TextBoxIme.Size = New System.Drawing.Size(254, 20)
        Me.TextBoxIme.TabIndex = 14
        Me.TextBoxIme.Text = "Unesite ime"
        '
        'TextBoxPrezime
        '
        Me.TextBoxPrezime.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxPrezime.Location = New System.Drawing.Point(6, 59)
        Me.TextBoxPrezime.Name = "TextBoxPrezime"
        Me.TextBoxPrezime.Size = New System.Drawing.Size(254, 20)
        Me.TextBoxPrezime.TabIndex = 15
        Me.TextBoxPrezime.Text = "Prezime"
        '
        'TextBoxJmbg
        '
        Me.TextBoxJmbg.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxJmbg.Location = New System.Drawing.Point(6, 94)
        Me.TextBoxJmbg.Name = "TextBoxJmbg"
        Me.TextBoxJmbg.Size = New System.Drawing.Size(254, 20)
        Me.TextBoxJmbg.TabIndex = 16
        Me.TextBoxJmbg.Text = "Matični broj"
        '
        'TextBoxKorIme
        '
        Me.TextBoxKorIme.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxKorIme.Location = New System.Drawing.Point(6, 135)
        Me.TextBoxKorIme.Name = "TextBoxKorIme"
        Me.TextBoxKorIme.Size = New System.Drawing.Size(254, 20)
        Me.TextBoxKorIme.TabIndex = 17
        Me.TextBoxKorIme.Text = "Korisničko ime"
        '
        'TextBoxSifra
        '
        Me.TextBoxSifra.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxSifra.Location = New System.Drawing.Point(6, 173)
        Me.TextBoxSifra.Name = "TextBoxSifra"
        Me.TextBoxSifra.Size = New System.Drawing.Size(254, 20)
        Me.TextBoxSifra.TabIndex = 18
        Me.TextBoxSifra.Text = "Šifra"
        '
        'TextBoxRod
        '
        Me.TextBoxRod.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxRod.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxRod.Name = "TextBoxRod"
        Me.TextBoxRod.Size = New System.Drawing.Size(235, 20)
        Me.TextBoxRod.TabIndex = 19
        Me.TextBoxRod.Text = "Ime roditelja"
        '
        'TextBoxAdresa
        '
        Me.TextBoxAdresa.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxAdresa.Location = New System.Drawing.Point(6, 57)
        Me.TextBoxAdresa.Name = "TextBoxAdresa"
        Me.TextBoxAdresa.Size = New System.Drawing.Size(235, 20)
        Me.TextBoxAdresa.TabIndex = 20
        Me.TextBoxAdresa.Text = "Adresa"
        '
        'TextBoxDatum
        '
        Me.TextBoxDatum.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxDatum.Location = New System.Drawing.Point(6, 93)
        Me.TextBoxDatum.Name = "TextBoxDatum"
        Me.TextBoxDatum.Size = New System.Drawing.Size(235, 20)
        Me.TextBoxDatum.TabIndex = 21
        Me.TextBoxDatum.Text = "Datum rođenja"
        '
        'GroupBoxObavezna
        '
        Me.GroupBoxObavezna.Controls.Add(Me.TextBoxIme)
        Me.GroupBoxObavezna.Controls.Add(Me.TextBoxPrezime)
        Me.GroupBoxObavezna.Controls.Add(Me.TextBoxJmbg)
        Me.GroupBoxObavezna.Controls.Add(Me.TextBoxKorIme)
        Me.GroupBoxObavezna.Controls.Add(Me.TextBoxSifra)
        Me.GroupBoxObavezna.Location = New System.Drawing.Point(185, 12)
        Me.GroupBoxObavezna.Name = "GroupBoxObavezna"
        Me.GroupBoxObavezna.Size = New System.Drawing.Size(266, 212)
        Me.GroupBoxObavezna.TabIndex = 22
        Me.GroupBoxObavezna.TabStop = False
        Me.GroupBoxObavezna.Text = "Obavezna polja!"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxRod)
        Me.GroupBox2.Controls.Add(Me.TextBoxAdresa)
        Me.GroupBox2.Controls.Add(Me.TextBoxDatum)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 255)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(247, 125)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'ButtonRegistracija
        '
        Me.ButtonRegistracija.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegistracija.Image = Global.eDnevnik.My.Resources.Resources.registration_32x32
        Me.ButtonRegistracija.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRegistracija.Location = New System.Drawing.Point(288, 255)
        Me.ButtonRegistracija.Name = "ButtonRegistracija"
        Me.ButtonRegistracija.Size = New System.Drawing.Size(157, 58)
        Me.ButtonRegistracija.TabIndex = 24
        Me.ButtonRegistracija.Text = "Pošalji zahtjev!"
        Me.ButtonRegistracija.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRegistracija.UseVisualStyleBackColor = True
        '
        'ButtonNazad
        '
        Me.ButtonNazad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNazad.Image = Global.eDnevnik.My.Resources.Resources.back_32x32
        Me.ButtonNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonNazad.Location = New System.Drawing.Point(361, 349)
        Me.ButtonNazad.Name = "ButtonNazad"
        Me.ButtonNazad.Size = New System.Drawing.Size(84, 36)
        Me.ButtonNazad.TabIndex = 25
        Me.ButtonNazad.Text = "Nazad"
        Me.ButtonNazad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNazad.UseVisualStyleBackColor = True
        '
        'FormRegistracija
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(460, 397)
        Me.Controls.Add(Me.ButtonNazad)
        Me.Controls.Add(Me.ButtonRegistracija)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBoxObavezna)
        Me.Controls.Add(Me.GroupBoxKorisnici)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(480, 440)
        Me.MinimumSize = New System.Drawing.Size(480, 440)
        Me.Name = "FormRegistracija"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRegistracija"
        Me.GroupBoxKorisnici.ResumeLayout(False)
        Me.GroupBoxKorisnici.PerformLayout()
        CType(Me.PictureBoxAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxUcenik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxProfesor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxObavezna.ResumeLayout(False)
        Me.GroupBoxObavezna.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxKorisnici As GroupBox
    Friend WithEvents RadioButtonProfesor As RadioButton
    Friend WithEvents PictureBoxAdmin As PictureBox
    Friend WithEvents RadioButtonUcenik As RadioButton
    Friend WithEvents PictureBoxUcenik As PictureBox
    Friend WithEvents RadioButtonAdmin As RadioButton
    Friend WithEvents PictureBoxProfesor As PictureBox
    Friend WithEvents TextBoxIme As TextBox
    Friend WithEvents TextBoxPrezime As TextBox
    Friend WithEvents TextBoxJmbg As TextBox
    Friend WithEvents TextBoxKorIme As TextBox
    Friend WithEvents TextBoxSifra As TextBox
    Friend WithEvents TextBoxRod As TextBox
    Friend WithEvents TextBoxAdresa As TextBox
    Friend WithEvents TextBoxDatum As TextBox
    Friend WithEvents GroupBoxObavezna As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonRegistracija As Button
    Friend WithEvents ButtonNazad As Button
End Class
