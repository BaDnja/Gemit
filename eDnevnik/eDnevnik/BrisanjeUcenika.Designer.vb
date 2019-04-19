<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BrisanjeUcenika
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrisanjeUcenika))
        Me.ButtonTempDel = New System.Windows.Forms.Button()
        Me.ButtonPermDel = New System.Windows.Forms.Button()
        Me.ButtonNazad = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonTempDel
        '
        Me.ButtonTempDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTempDel.Image = Global.eDnevnik.My.Resources.Resources.recBin_32x32
        Me.ButtonTempDel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonTempDel.Location = New System.Drawing.Point(461, 143)
        Me.ButtonTempDel.Name = "ButtonTempDel"
        Me.ButtonTempDel.Size = New System.Drawing.Size(186, 47)
        Me.ButtonTempDel.TabIndex = 35
        Me.ButtonTempDel.Text = "Premjesti u košaricu"
        Me.ButtonTempDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTempDel.UseVisualStyleBackColor = True
        '
        'ButtonPermDel
        '
        Me.ButtonPermDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPermDel.Image = Global.eDnevnik.My.Resources.Resources.permDel_32x32
        Me.ButtonPermDel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonPermDel.Location = New System.Drawing.Point(12, 143)
        Me.ButtonPermDel.Name = "ButtonPermDel"
        Me.ButtonPermDel.Size = New System.Drawing.Size(139, 47)
        Me.ButtonPermDel.TabIndex = 34
        Me.ButtonPermDel.Text = "Trajno obriši"
        Me.ButtonPermDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPermDel.UseVisualStyleBackColor = True
        '
        'ButtonNazad
        '
        Me.ButtonNazad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNazad.Image = Global.eDnevnik.My.Resources.Resources.back_32x32
        Me.ButtonNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonNazad.Location = New System.Drawing.Point(704, 154)
        Me.ButtonNazad.Name = "ButtonNazad"
        Me.ButtonNazad.Size = New System.Drawing.Size(84, 36)
        Me.ButtonNazad.TabIndex = 33
        Me.ButtonNazad.Text = "Nazad"
        Me.ButtonNazad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNazad.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 214)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(776, 224)
        Me.DataGridView1.TabIndex = 36
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.eDnevnik.My.Resources.Resources.student_128x128
        Me.PictureBox1.Location = New System.Drawing.Point(660, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(190, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 177)
        Me.GroupBox1.TabIndex = 55
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
        'BrisanjeUcenika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonTempDel)
        Me.Controls.Add(Me.ButtonPermDel)
        Me.Controls.Add(Me.ButtonNazad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "BrisanjeUcenika"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brisanje ucenika"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonTempDel As Button
    Friend WithEvents ButtonPermDel As Button
    Friend WithEvents ButtonNazad As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
End Class
