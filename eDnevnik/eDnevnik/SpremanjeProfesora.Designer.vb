<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpremanjeProfesora
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
        Me.TextBoxjmbg = New System.Windows.Forms.TextBox()
        Me.TextBoxIme = New System.Windows.Forms.TextBox()
        Me.TextBoxPrezime = New System.Windows.Forms.TextBox()
        Me.TextBoxAdresa = New System.Windows.Forms.TextBox()
        Me.TextBoxDatumR = New System.Windows.Forms.TextBox()
        Me.TextBoxSifra = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonNazad = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxjmbg
        '
        Me.TextBoxjmbg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxjmbg.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxjmbg.Location = New System.Drawing.Point(12, 35)
        Me.TextBoxjmbg.Name = "TextBoxjmbg"
        Me.TextBoxjmbg.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxjmbg.TabIndex = 21
        Me.TextBoxjmbg.Text = "Jedinstveni matični broj"
        '
        'TextBoxIme
        '
        Me.TextBoxIme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIme.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxIme.Location = New System.Drawing.Point(12, 76)
        Me.TextBoxIme.Name = "TextBoxIme"
        Me.TextBoxIme.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxIme.TabIndex = 22
        Me.TextBoxIme.Text = "Ime profesora"
        '
        'TextBoxPrezime
        '
        Me.TextBoxPrezime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrezime.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxPrezime.Location = New System.Drawing.Point(12, 114)
        Me.TextBoxPrezime.Name = "TextBoxPrezime"
        Me.TextBoxPrezime.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxPrezime.TabIndex = 23
        Me.TextBoxPrezime.Text = "Prezime profesora"
        '
        'TextBoxAdresa
        '
        Me.TextBoxAdresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAdresa.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxAdresa.Location = New System.Drawing.Point(213, 35)
        Me.TextBoxAdresa.Name = "TextBoxAdresa"
        Me.TextBoxAdresa.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxAdresa.TabIndex = 24
        Me.TextBoxAdresa.Text = "Adresa"
        '
        'TextBoxDatumR
        '
        Me.TextBoxDatumR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDatumR.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxDatumR.Location = New System.Drawing.Point(213, 76)
        Me.TextBoxDatumR.Name = "TextBoxDatumR"
        Me.TextBoxDatumR.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxDatumR.TabIndex = 25
        Me.TextBoxDatumR.Text = "Datum rođenja"
        '
        'TextBoxSifra
        '
        Me.TextBoxSifra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSifra.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxSifra.Location = New System.Drawing.Point(213, 114)
        Me.TextBoxSifra.Name = "TextBoxSifra"
        Me.TextBoxSifra.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxSifra.TabIndex = 26
        Me.TextBoxSifra.Text = "Šifra profesora"
        '
        'ButtonSave
        '
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.Image = Global.eDnevnik.My.Resources.Resources.save_32x32
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSave.Location = New System.Drawing.Point(128, 161)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(111, 41)
        Me.ButtonSave.TabIndex = 28
        Me.ButtonSave.Text = "Spremi"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.eDnevnik.My.Resources.Resources.teacher
        Me.PictureBox1.Location = New System.Drawing.Point(401, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'ButtonNazad
        '
        Me.ButtonNazad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNazad.Image = Global.eDnevnik.My.Resources.Resources.back_32x32
        Me.ButtonNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonNazad.Location = New System.Drawing.Point(445, 146)
        Me.ButtonNazad.Name = "ButtonNazad"
        Me.ButtonNazad.Size = New System.Drawing.Size(84, 36)
        Me.ButtonNazad.TabIndex = 20
        Me.ButtonNazad.Text = "Nazad"
        Me.ButtonNazad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNazad.UseVisualStyleBackColor = True
        '
        'SpremanjeProfesora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(532, 207)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBoxSifra)
        Me.Controls.Add(Me.TextBoxDatumR)
        Me.Controls.Add(Me.TextBoxAdresa)
        Me.Controls.Add(Me.TextBoxPrezime)
        Me.Controls.Add(Me.TextBoxIme)
        Me.Controls.Add(Me.TextBoxjmbg)
        Me.Controls.Add(Me.ButtonNazad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(552, 250)
        Me.MinimumSize = New System.Drawing.Size(552, 250)
        Me.Name = "SpremanjeProfesora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spremanje novog profesora"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonNazad As Button
    Friend WithEvents TextBoxjmbg As TextBox
    Friend WithEvents TextBoxIme As TextBox
    Friend WithEvents TextBoxPrezime As TextBox
    Friend WithEvents TextBoxAdresa As TextBox
    Friend WithEvents TextBoxDatumR As TextBox
    Friend WithEvents TextBoxSifra As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonSave As Button
End Class
