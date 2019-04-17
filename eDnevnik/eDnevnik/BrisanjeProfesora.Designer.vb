<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrisanjeProfesora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrisanjeProfesora))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonTempDel = New System.Windows.Forms.Button()
        Me.ButtonPermDel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonNazad = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 188)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(729, 279)
        Me.DataGridView1.TabIndex = 30
        '
        'ButtonTempDel
        '
        Me.ButtonTempDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTempDel.Image = Global.eDnevnik.My.Resources.Resources.recBin_32x32
        Me.ButtonTempDel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonTempDel.Location = New System.Drawing.Point(397, 135)
        Me.ButtonTempDel.Name = "ButtonTempDel"
        Me.ButtonTempDel.Size = New System.Drawing.Size(186, 47)
        Me.ButtonTempDel.TabIndex = 32
        Me.ButtonTempDel.Text = "Premjesti u košaricu"
        Me.ButtonTempDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTempDel.UseVisualStyleBackColor = True
        '
        'ButtonPermDel
        '
        Me.ButtonPermDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPermDel.Image = Global.eDnevnik.My.Resources.Resources.permDel_32x32
        Me.ButtonPermDel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonPermDel.Location = New System.Drawing.Point(12, 135)
        Me.ButtonPermDel.Name = "ButtonPermDel"
        Me.ButtonPermDel.Size = New System.Drawing.Size(139, 47)
        Me.ButtonPermDel.TabIndex = 31
        Me.ButtonPermDel.Text = "Trajno obriši"
        Me.ButtonPermDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPermDel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.eDnevnik.My.Resources.Resources.teacher
        Me.PictureBox1.Location = New System.Drawing.Point(589, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'ButtonNazad
        '
        Me.ButtonNazad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNazad.Image = Global.eDnevnik.My.Resources.Resources.back_32x32
        Me.ButtonNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonNazad.Location = New System.Drawing.Point(633, 146)
        Me.ButtonNazad.Name = "ButtonNazad"
        Me.ButtonNazad.Size = New System.Drawing.Size(84, 36)
        Me.ButtonNazad.TabIndex = 28
        Me.ButtonNazad.Text = "Nazad"
        Me.ButtonNazad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNazad.UseVisualStyleBackColor = True
        '
        'BrisanjeProfesora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(729, 467)
        Me.Controls.Add(Me.ButtonTempDel)
        Me.Controls.Add(Me.ButtonPermDel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonNazad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(749, 510)
        Me.MinimumSize = New System.Drawing.Size(749, 510)
        Me.Name = "BrisanjeProfesora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brisanje profesora"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonNazad As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonPermDel As Button
    Friend WithEvents ButtonTempDel As Button
End Class
