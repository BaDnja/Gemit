<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IzmjenaAdmina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IzmjenaAdmina))
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonNazad = New System.Windows.Forms.Button()
        Me.TextBoxSifra = New System.Windows.Forms.TextBox()
        Me.TextBoxIme = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonSave
        '
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.Image = Global.eDnevnik.My.Resources.Resources.save_32x32
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSave.Location = New System.Drawing.Point(49, 142)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(111, 41)
        Me.ButtonSave.TabIndex = 35
        Me.ButtonSave.Text = "Spremi"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonNazad
        '
        Me.ButtonNazad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNazad.Image = Global.eDnevnik.My.Resources.Resources.back_32x32
        Me.ButtonNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonNazad.Location = New System.Drawing.Point(288, 176)
        Me.ButtonNazad.Name = "ButtonNazad"
        Me.ButtonNazad.Size = New System.Drawing.Size(84, 36)
        Me.ButtonNazad.TabIndex = 34
        Me.ButtonNazad.Text = "Nazad"
        Me.ButtonNazad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNazad.UseVisualStyleBackColor = True
        '
        'TextBoxSifra
        '
        Me.TextBoxSifra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSifra.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxSifra.Location = New System.Drawing.Point(28, 96)
        Me.TextBoxSifra.Name = "TextBoxSifra"
        Me.TextBoxSifra.Size = New System.Drawing.Size(156, 21)
        Me.TextBoxSifra.TabIndex = 33
        Me.TextBoxSifra.Text = "Šifra"
        '
        'TextBoxIme
        '
        Me.TextBoxIme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIme.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBoxIme.Location = New System.Drawing.Point(28, 55)
        Me.TextBoxIme.Name = "TextBoxIme"
        Me.TextBoxIme.Size = New System.Drawing.Size(156, 21)
        Me.TextBoxIme.TabIndex = 32
        Me.TextBoxIme.Text = "Korisničko ime"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.eDnevnik.My.Resources.Resources.administrator
        Me.PictureBox1.Location = New System.Drawing.Point(244, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 218)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(360, 200)
        Me.DataGridView1.TabIndex = 36
        '
        'IzmjenaAdmina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(384, 431)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonNazad)
        Me.Controls.Add(Me.TextBoxSifra)
        Me.Controls.Add(Me.TextBoxIme)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 470)
        Me.MinimumSize = New System.Drawing.Size(400, 470)
        Me.Name = "IzmjenaAdmina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IzmjenaAdmina"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonNazad As Button
    Friend WithEvents TextBoxSifra As TextBox
    Friend WithEvents TextBoxIme As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
