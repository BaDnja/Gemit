<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2Admin))
        Me.ButtonAddProf = New System.Windows.Forms.Button()
        Me.ButtonModProf = New System.Windows.Forms.Button()
        Me.ButtonDelProf = New System.Windows.Forms.Button()
        Me.ButtonAddStudent = New System.Windows.Forms.Button()
        Me.ButtonModStudent = New System.Windows.Forms.Button()
        Me.ButtonDelStudent = New System.Windows.Forms.Button()
        Me.ButtonAddAdmin = New System.Windows.Forms.Button()
        Me.ButtonModAdmin = New System.Windows.Forms.Button()
        Me.ButtonDelAdmin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonNazad = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonInboxAdmin = New System.Windows.Forms.Button()
        Me.ButtonInboxStud = New System.Windows.Forms.Button()
        Me.ButtonInboxProf = New System.Windows.Forms.Button()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonAddProf
        '
        Me.ButtonAddProf.Location = New System.Drawing.Point(12, 12)
        Me.ButtonAddProf.Name = "ButtonAddProf"
        Me.ButtonAddProf.Size = New System.Drawing.Size(152, 35)
        Me.ButtonAddProf.TabIndex = 3
        Me.ButtonAddProf.Text = "Spremi profesora"
        Me.ButtonAddProf.UseVisualStyleBackColor = True
        '
        'ButtonModProf
        '
        Me.ButtonModProf.Location = New System.Drawing.Point(12, 51)
        Me.ButtonModProf.Name = "ButtonModProf"
        Me.ButtonModProf.Size = New System.Drawing.Size(152, 35)
        Me.ButtonModProf.TabIndex = 4
        Me.ButtonModProf.Text = "Izmijeni profesora"
        Me.ButtonModProf.UseVisualStyleBackColor = True
        '
        'ButtonDelProf
        '
        Me.ButtonDelProf.Location = New System.Drawing.Point(12, 92)
        Me.ButtonDelProf.Name = "ButtonDelProf"
        Me.ButtonDelProf.Size = New System.Drawing.Size(152, 35)
        Me.ButtonDelProf.TabIndex = 5
        Me.ButtonDelProf.Text = "Obriši profesora"
        Me.ButtonDelProf.UseVisualStyleBackColor = True
        '
        'ButtonAddStudent
        '
        Me.ButtonAddStudent.Location = New System.Drawing.Point(12, 317)
        Me.ButtonAddStudent.Name = "ButtonAddStudent"
        Me.ButtonAddStudent.Size = New System.Drawing.Size(152, 35)
        Me.ButtonAddStudent.TabIndex = 6
        Me.ButtonAddStudent.Text = "Spremanje učenika"
        Me.ButtonAddStudent.UseVisualStyleBackColor = True
        '
        'ButtonModStudent
        '
        Me.ButtonModStudent.Location = New System.Drawing.Point(12, 361)
        Me.ButtonModStudent.Name = "ButtonModStudent"
        Me.ButtonModStudent.Size = New System.Drawing.Size(152, 35)
        Me.ButtonModStudent.TabIndex = 7
        Me.ButtonModStudent.Text = "Izmjena učenika"
        Me.ButtonModStudent.UseVisualStyleBackColor = True
        '
        'ButtonDelStudent
        '
        Me.ButtonDelStudent.Location = New System.Drawing.Point(12, 403)
        Me.ButtonDelStudent.Name = "ButtonDelStudent"
        Me.ButtonDelStudent.Size = New System.Drawing.Size(152, 35)
        Me.ButtonDelStudent.TabIndex = 8
        Me.ButtonDelStudent.Text = "Brisanje učenika"
        Me.ButtonDelStudent.UseVisualStyleBackColor = True
        '
        'ButtonAddAdmin
        '
        Me.ButtonAddAdmin.Location = New System.Drawing.Point(400, 12)
        Me.ButtonAddAdmin.Name = "ButtonAddAdmin"
        Me.ButtonAddAdmin.Size = New System.Drawing.Size(152, 35)
        Me.ButtonAddAdmin.TabIndex = 12
        Me.ButtonAddAdmin.Text = "Spremanje admina"
        Me.ButtonAddAdmin.UseVisualStyleBackColor = True
        '
        'ButtonModAdmin
        '
        Me.ButtonModAdmin.Location = New System.Drawing.Point(400, 53)
        Me.ButtonModAdmin.Name = "ButtonModAdmin"
        Me.ButtonModAdmin.Size = New System.Drawing.Size(152, 35)
        Me.ButtonModAdmin.TabIndex = 13
        Me.ButtonModAdmin.Text = "Izmjena admina"
        Me.ButtonModAdmin.UseVisualStyleBackColor = True
        '
        'ButtonDelAdmin
        '
        Me.ButtonDelAdmin.Location = New System.Drawing.Point(400, 96)
        Me.ButtonDelAdmin.Name = "ButtonDelAdmin"
        Me.ButtonDelAdmin.Size = New System.Drawing.Size(152, 35)
        Me.ButtonDelAdmin.TabIndex = 14
        Me.ButtonDelAdmin.Text = "Brisanje admina"
        Me.ButtonDelAdmin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(220, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Izaberi opciju!"
        '
        'ButtonNazad
        '
        Me.ButtonNazad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNazad.Image = Global.eDnevnik.My.Resources.Resources.back_32x32
        Me.ButtonNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonNazad.Location = New System.Drawing.Point(239, 396)
        Me.ButtonNazad.Name = "ButtonNazad"
        Me.ButtonNazad.Size = New System.Drawing.Size(84, 36)
        Me.ButtonNazad.TabIndex = 19
        Me.ButtonNazad.Text = "Nazad"
        Me.ButtonNazad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNazad.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.eDnevnik.My.Resources.Resources.inbox_64x64
        Me.PictureBox4.Location = New System.Drawing.Point(447, 250)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox4.TabIndex = 18
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.eDnevnik.My.Resources.Resources.admin_64x64
        Me.PictureBox3.Location = New System.Drawing.Point(447, 137)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.eDnevnik.My.Resources.Resources.student_64x64
        Me.PictureBox2.Location = New System.Drawing.Point(54, 247)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.eDnevnik.My.Resources.Resources.teacher_64x64
        Me.PictureBox1.Location = New System.Drawing.Point(54, 133)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'ButtonInboxAdmin
        '
        Me.ButtonInboxAdmin.Image = Global.eDnevnik.My.Resources.Resources.admin_32x32
        Me.ButtonInboxAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonInboxAdmin.Location = New System.Drawing.Point(400, 403)
        Me.ButtonInboxAdmin.Name = "ButtonInboxAdmin"
        Me.ButtonInboxAdmin.Size = New System.Drawing.Size(152, 35)
        Me.ButtonInboxAdmin.TabIndex = 11
        Me.ButtonInboxAdmin.Text = "Inbox admini"
        Me.ButtonInboxAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonInboxAdmin.UseVisualStyleBackColor = True
        '
        'ButtonInboxStud
        '
        Me.ButtonInboxStud.Image = Global.eDnevnik.My.Resources.Resources.student_32x321
        Me.ButtonInboxStud.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonInboxStud.Location = New System.Drawing.Point(400, 363)
        Me.ButtonInboxStud.Name = "ButtonInboxStud"
        Me.ButtonInboxStud.Size = New System.Drawing.Size(152, 35)
        Me.ButtonInboxStud.TabIndex = 10
        Me.ButtonInboxStud.Text = "Inbox učenici"
        Me.ButtonInboxStud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonInboxStud.UseVisualStyleBackColor = True
        '
        'ButtonInboxProf
        '
        Me.ButtonInboxProf.Image = Global.eDnevnik.My.Resources.Resources._32x321
        Me.ButtonInboxProf.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonInboxProf.Location = New System.Drawing.Point(400, 320)
        Me.ButtonInboxProf.Name = "ButtonInboxProf"
        Me.ButtonInboxProf.Size = New System.Drawing.Size(152, 35)
        Me.ButtonInboxProf.TabIndex = 9
        Me.ButtonInboxProf.Text = "Inbox profesori"
        Me.ButtonInboxProf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonInboxProf.UseVisualStyleBackColor = True
        '
        'Form2Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(570, 440)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonNazad)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonDelAdmin)
        Me.Controls.Add(Me.ButtonModAdmin)
        Me.Controls.Add(Me.ButtonAddAdmin)
        Me.Controls.Add(Me.ButtonInboxAdmin)
        Me.Controls.Add(Me.ButtonInboxStud)
        Me.Controls.Add(Me.ButtonInboxProf)
        Me.Controls.Add(Me.ButtonDelStudent)
        Me.Controls.Add(Me.ButtonModStudent)
        Me.Controls.Add(Me.ButtonAddStudent)
        Me.Controls.Add(Me.ButtonDelProf)
        Me.Controls.Add(Me.ButtonModProf)
        Me.Controls.Add(Me.ButtonAddProf)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(590, 483)
        Me.MinimumSize = New System.Drawing.Size(590, 483)
        Me.Name = "Form2Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administratoski panel"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonAddProf As Button
    Friend WithEvents ButtonModProf As Button
    Friend WithEvents ButtonDelProf As Button
    Friend WithEvents ButtonAddStudent As Button
    Friend WithEvents ButtonModStudent As Button
    Friend WithEvents ButtonDelStudent As Button
    Friend WithEvents ButtonInboxProf As Button
    Friend WithEvents ButtonInboxStud As Button
    Friend WithEvents ButtonInboxAdmin As Button
    Friend WithEvents ButtonAddAdmin As Button
    Friend WithEvents ButtonModAdmin As Button
    Friend WithEvents ButtonDelAdmin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ButtonNazad As Button
    Friend WithEvents Label1 As Label
End Class
