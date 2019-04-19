<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IzmjenaUcenika
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
        Me.TextBoxOdjeljenje = New System.Windows.Forms.TextBox()
        Me.TextBoxGodina = New System.Windows.Forms.TextBox()
        Me.TextBoxImeRod = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonNazad = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.TextBoxSifra = New System.Windows.Forms.TextBox()
        Me.TextBoxDatumR = New System.Windows.Forms.TextBox()
        Me.TextBoxAdresa = New System.Windows.Forms.TextBox()
        Me.TextBoxPrezime = New System.Windows.Forms.TextBox()
        Me.TextBoxIme = New System.Windows.Forms.TextBox()
        Me.TextBoxjmbg = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxOdjeljenje
        '
        Me.TextBoxOdjeljenje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxOdjeljenje.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxOdjeljenje.Location = New System.Drawing.Point(23, 180)
        Me.TextBoxOdjeljenje.Name = "TextBoxOdjeljenje"
        Me.TextBoxOdjeljenje.Size = New System.Drawing.Size(144, 21)
        Me.TextBoxOdjeljenje.TabIndex = 52
        Me.TextBoxOdjeljenje.Text = "Odjeljenje"
        '
        'TextBoxGodina
        '
        Me.TextBoxGodina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxGodina.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxGodina.Location = New System.Drawing.Point(183, 140)
        Me.TextBoxGodina.Name = "TextBoxGodina"
        Me.TextBoxGodina.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxGodina.TabIndex = 51
        Me.TextBoxGodina.Text = "Godina"
        '
        'TextBoxImeRod
        '
        Me.TextBoxImeRod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxImeRod.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxImeRod.Location = New System.Drawing.Point(22, 140)
        Me.TextBoxImeRod.Name = "TextBoxImeRod"
        Me.TextBoxImeRod.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxImeRod.TabIndex = 50
        Me.TextBoxImeRod.Text = "Ime roditelja"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.eDnevnik.My.Resources.Resources.student_128x128
        Me.PictureBox1.Location = New System.Drawing.Point(660, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'ButtonNazad
        '
        Me.ButtonNazad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNazad.Image = Global.eDnevnik.My.Resources.Resources.back_32x32
        Me.ButtonNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonNazad.Location = New System.Drawing.Point(704, 152)
        Me.ButtonNazad.Name = "ButtonNazad"
        Me.ButtonNazad.Size = New System.Drawing.Size(84, 36)
        Me.ButtonNazad.TabIndex = 48
        Me.ButtonNazad.Text = "Nazad"
        Me.ButtonNazad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNazad.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.Image = Global.eDnevnik.My.Resources.Resources.save_32x32
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSave.Location = New System.Drawing.Point(183, 167)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(168, 41)
        Me.ButtonSave.TabIndex = 47
        Me.ButtonSave.Text = "Spremi izmjene"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'TextBoxSifra
        '
        Me.TextBoxSifra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSifra.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxSifra.Location = New System.Drawing.Point(183, 103)
        Me.TextBoxSifra.Name = "TextBoxSifra"
        Me.TextBoxSifra.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxSifra.TabIndex = 46
        Me.TextBoxSifra.Text = "Šifra učenika"
        '
        'TextBoxDatumR
        '
        Me.TextBoxDatumR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDatumR.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxDatumR.Location = New System.Drawing.Point(183, 65)
        Me.TextBoxDatumR.Name = "TextBoxDatumR"
        Me.TextBoxDatumR.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxDatumR.TabIndex = 45
        Me.TextBoxDatumR.Text = "Datum rođenja"
        '
        'TextBoxAdresa
        '
        Me.TextBoxAdresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAdresa.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxAdresa.Location = New System.Drawing.Point(183, 24)
        Me.TextBoxAdresa.Name = "TextBoxAdresa"
        Me.TextBoxAdresa.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxAdresa.TabIndex = 44
        Me.TextBoxAdresa.Text = "Adresa"
        '
        'TextBoxPrezime
        '
        Me.TextBoxPrezime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrezime.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxPrezime.Location = New System.Drawing.Point(22, 103)
        Me.TextBoxPrezime.Name = "TextBoxPrezime"
        Me.TextBoxPrezime.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxPrezime.TabIndex = 43
        Me.TextBoxPrezime.Text = "Prezime učenika"
        '
        'TextBoxIme
        '
        Me.TextBoxIme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIme.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxIme.Location = New System.Drawing.Point(22, 65)
        Me.TextBoxIme.Name = "TextBoxIme"
        Me.TextBoxIme.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxIme.TabIndex = 42
        Me.TextBoxIme.Text = "Ime učenika"
        '
        'TextBoxjmbg
        '
        Me.TextBoxjmbg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxjmbg.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxjmbg.Location = New System.Drawing.Point(22, 24)
        Me.TextBoxjmbg.Name = "TextBoxjmbg"
        Me.TextBoxjmbg.Size = New System.Drawing.Size(145, 21)
        Me.TextBoxjmbg.TabIndex = 41
        Me.TextBoxjmbg.Text = "Jedinstveni matični broj"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 244)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(776, 194)
        Me.DataGridView1.TabIndex = 53
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(414, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 177)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ovdje postaviti filtere"
        '
        'IzmjenaUcenika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
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
        Me.Name = "IzmjenaUcenika"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Izmjena ucenika"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxOdjeljenje As TextBox
    Friend WithEvents TextBoxGodina As TextBox
    Friend WithEvents TextBoxImeRod As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonNazad As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents TextBoxSifra As TextBox
    Friend WithEvents TextBoxDatumR As TextBox
    Friend WithEvents TextBoxAdresa As TextBox
    Friend WithEvents TextBoxPrezime As TextBox
    Friend WithEvents TextBoxIme As TextBox
    Friend WithEvents TextBoxjmbg As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
End Class
