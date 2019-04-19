<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpremanjeUcenika
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpremanjeUcenika))
        Me.TextBoxSifra = New System.Windows.Forms.TextBox()
        Me.TextBoxDatumR = New System.Windows.Forms.TextBox()
        Me.TextBoxAdresa = New System.Windows.Forms.TextBox()
        Me.TextBoxPrezime = New System.Windows.Forms.TextBox()
        Me.TextBoxIme = New System.Windows.Forms.TextBox()
        Me.TextBoxjmbg = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonNazad = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.TextBoxImeRod = New System.Windows.Forms.TextBox()
        Me.TextBoxGodina = New System.Windows.Forms.TextBox()
        Me.TextBoxOdjeljenje = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxSifra
        '
        Me.TextBoxSifra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSifra.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxSifra.Location = New System.Drawing.Point(213, 118)
        Me.TextBoxSifra.Name = "TextBoxSifra"
        Me.TextBoxSifra.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxSifra.TabIndex = 34
        Me.TextBoxSifra.Text = "Šifra učenika"
        '
        'TextBoxDatumR
        '
        Me.TextBoxDatumR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDatumR.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxDatumR.Location = New System.Drawing.Point(213, 80)
        Me.TextBoxDatumR.Name = "TextBoxDatumR"
        Me.TextBoxDatumR.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxDatumR.TabIndex = 33
        Me.TextBoxDatumR.Text = "Datum rođenja"
        '
        'TextBoxAdresa
        '
        Me.TextBoxAdresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAdresa.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxAdresa.Location = New System.Drawing.Point(213, 39)
        Me.TextBoxAdresa.Name = "TextBoxAdresa"
        Me.TextBoxAdresa.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxAdresa.TabIndex = 32
        Me.TextBoxAdresa.Text = "Adresa"
        '
        'TextBoxPrezime
        '
        Me.TextBoxPrezime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrezime.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxPrezime.Location = New System.Drawing.Point(12, 118)
        Me.TextBoxPrezime.Name = "TextBoxPrezime"
        Me.TextBoxPrezime.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxPrezime.TabIndex = 31
        Me.TextBoxPrezime.Text = "Prezime učenika"
        '
        'TextBoxIme
        '
        Me.TextBoxIme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIme.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxIme.Location = New System.Drawing.Point(12, 80)
        Me.TextBoxIme.Name = "TextBoxIme"
        Me.TextBoxIme.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxIme.TabIndex = 30
        Me.TextBoxIme.Text = "Ime učenika"
        '
        'TextBoxjmbg
        '
        Me.TextBoxjmbg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxjmbg.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxjmbg.Location = New System.Drawing.Point(12, 39)
        Me.TextBoxjmbg.Name = "TextBoxjmbg"
        Me.TextBoxjmbg.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxjmbg.TabIndex = 29
        Me.TextBoxjmbg.Text = "Jedinstveni matični broj"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.eDnevnik.My.Resources.Resources.student_128x128
        Me.PictureBox1.Location = New System.Drawing.Point(398, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'ButtonNazad
        '
        Me.ButtonNazad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNazad.Image = Global.eDnevnik.My.Resources.Resources.back_32x32
        Me.ButtonNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonNazad.Location = New System.Drawing.Point(442, 146)
        Me.ButtonNazad.Name = "ButtonNazad"
        Me.ButtonNazad.Size = New System.Drawing.Size(84, 36)
        Me.ButtonNazad.TabIndex = 36
        Me.ButtonNazad.Text = "Nazad"
        Me.ButtonNazad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNazad.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.Image = Global.eDnevnik.My.Resources.Resources.save_32x32
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSave.Location = New System.Drawing.Point(230, 183)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(111, 41)
        Me.ButtonSave.TabIndex = 35
        Me.ButtonSave.Text = "Spremi"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'TextBoxImeRod
        '
        Me.TextBoxImeRod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxImeRod.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxImeRod.Location = New System.Drawing.Point(12, 155)
        Me.TextBoxImeRod.Name = "TextBoxImeRod"
        Me.TextBoxImeRod.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxImeRod.TabIndex = 38
        Me.TextBoxImeRod.Text = "Ime roditelja"
        '
        'TextBoxGodina
        '
        Me.TextBoxGodina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxGodina.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxGodina.Location = New System.Drawing.Point(213, 155)
        Me.TextBoxGodina.Name = "TextBoxGodina"
        Me.TextBoxGodina.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxGodina.TabIndex = 39
        Me.TextBoxGodina.Text = "Godina"
        '
        'TextBoxOdjeljenje
        '
        Me.TextBoxOdjeljenje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxOdjeljenje.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxOdjeljenje.Location = New System.Drawing.Point(13, 195)
        Me.TextBoxOdjeljenje.Name = "TextBoxOdjeljenje"
        Me.TextBoxOdjeljenje.Size = New System.Drawing.Size(144, 21)
        Me.TextBoxOdjeljenje.TabIndex = 40
        Me.TextBoxOdjeljenje.Text = "Odjeljenje"
        '
        'SpremanjeUcenika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(532, 277)
        Me.Controls.Add(Me.TextBoxOdjeljenje)
        Me.Controls.Add(Me.TextBoxGodina)
        Me.Controls.Add(Me.TextBoxImeRod)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonNazad)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.TextBoxSifra)
        Me.Controls.Add(Me.TextBoxDatumR)
        Me.Controls.Add(Me.TextBoxAdresa)
        Me.Controls.Add(Me.TextBoxPrezime)
        Me.Controls.Add(Me.TextBoxIme)
        Me.Controls.Add(Me.TextBoxjmbg)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(552, 320)
        Me.MinimumSize = New System.Drawing.Size(552, 320)
        Me.Name = "SpremanjeUcenika"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spremanje ucenika"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonSave As Button
    Friend WithEvents TextBoxSifra As TextBox
    Friend WithEvents TextBoxDatumR As TextBox
    Friend WithEvents TextBoxAdresa As TextBox
    Friend WithEvents TextBoxPrezime As TextBox
    Friend WithEvents TextBoxIme As TextBox
    Friend WithEvents TextBoxjmbg As TextBox
    Friend WithEvents ButtonNazad As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBoxImeRod As TextBox
    Friend WithEvents TextBoxGodina As TextBox
    Friend WithEvents TextBoxOdjeljenje As TextBox
End Class
