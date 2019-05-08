<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dnevnik
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dnevnik))
        Me.btnNazad = New System.Windows.Forms.Button()
        Me.cmbSubject = New System.Windows.Forms.ComboBox()
        Me.CBScore = New System.Windows.Forms.ComboBox()
        Me.lblOc = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBClass = New System.Windows.Forms.ComboBox()
        Me.CBYear = New System.Windows.Forms.ComboBox()
        Me.lblRaz = New System.Windows.Forms.Label()
        Me.lblOd = New System.Windows.Forms.Label()
        Me.StudentDataView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblSubjectID = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        CType(Me.StudentDataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNazad
        '
        Me.btnNazad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNazad.Image = Global.eDnevnik.My.Resources.Resources.back_32x32
        Me.btnNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNazad.Location = New System.Drawing.Point(387, 12)
        Me.btnNazad.Name = "btnNazad"
        Me.btnNazad.Size = New System.Drawing.Size(98, 42)
        Me.btnNazad.TabIndex = 49
        Me.btnNazad.Text = "Nazad"
        Me.btnNazad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNazad.UseVisualStyleBackColor = True
        '
        'cmbSubject
        '
        Me.cmbSubject.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmbSubject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubject.FormattingEnabled = True
        Me.cmbSubject.Location = New System.Drawing.Point(12, 50)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(265, 23)
        Me.cmbSubject.TabIndex = 50
        '
        'CBScore
        '
        Me.CBScore.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CBScore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CBScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBScore.FormattingEnabled = True
        Me.CBScore.Location = New System.Drawing.Point(367, 271)
        Me.CBScore.Name = "CBScore"
        Me.CBScore.Size = New System.Drawing.Size(121, 23)
        Me.CBScore.TabIndex = 51
        '
        'lblOc
        '
        Me.lblOc.AutoSize = True
        Me.lblOc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOc.Location = New System.Drawing.Point(364, 252)
        Me.lblOc.Name = "lblOc"
        Me.lblOc.Size = New System.Drawing.Size(51, 16)
        Me.lblOc.TabIndex = 53
        Me.lblOc.Text = "Ocjena"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Predmet"
        '
        'CBClass
        '
        Me.CBClass.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CBClass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CBClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBClass.FormattingEnabled = True
        Me.CBClass.Location = New System.Drawing.Point(12, 193)
        Me.CBClass.Name = "CBClass"
        Me.CBClass.Size = New System.Drawing.Size(121, 23)
        Me.CBClass.TabIndex = 56
        '
        'CBYear
        '
        Me.CBYear.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CBYear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CBYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBYear.FormattingEnabled = True
        Me.CBYear.Location = New System.Drawing.Point(12, 119)
        Me.CBYear.Name = "CBYear"
        Me.CBYear.Size = New System.Drawing.Size(121, 23)
        Me.CBYear.TabIndex = 57
        '
        'lblRaz
        '
        Me.lblRaz.AutoSize = True
        Me.lblRaz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaz.Location = New System.Drawing.Point(9, 100)
        Me.lblRaz.Name = "lblRaz"
        Me.lblRaz.Size = New System.Drawing.Size(52, 16)
        Me.lblRaz.TabIndex = 58
        Me.lblRaz.Text = "Razred"
        '
        'lblOd
        '
        Me.lblOd.AutoSize = True
        Me.lblOd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOd.Location = New System.Drawing.Point(9, 174)
        Me.lblOd.Name = "lblOd"
        Me.lblOd.Size = New System.Drawing.Size(69, 16)
        Me.lblOd.TabIndex = 59
        Me.lblOd.Text = "Odjeljenje"
        '
        'StudentDataView
        '
        Me.StudentDataView.AllowUserToAddRows = False
        Me.StudentDataView.AllowUserToDeleteRows = False
        Me.StudentDataView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.StudentDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataView.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.StudentDataView.Location = New System.Drawing.Point(12, 252)
        Me.StudentDataView.Name = "StudentDataView"
        Me.StudentDataView.ReadOnly = True
        Me.StudentDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.StudentDataView.Size = New System.Drawing.Size(349, 128)
        Me.StudentDataView.TabIndex = 60
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(367, 341)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 39)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Dodaj ocjenu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblSubjectID
        '
        Me.lblSubjectID.AutoSize = True
        Me.lblSubjectID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectID.Location = New System.Drawing.Point(78, 31)
        Me.lblSubjectID.Name = "lblSubjectID"
        Me.lblSubjectID.Size = New System.Drawing.Size(0, 13)
        Me.lblSubjectID.TabIndex = 62
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(12, 236)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(0, 13)
        Me.lblUserID.TabIndex = 63
        '
        'Dnevnik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(497, 397)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblSubjectID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StudentDataView)
        Me.Controls.Add(Me.lblOd)
        Me.Controls.Add(Me.lblRaz)
        Me.Controls.Add(Me.CBYear)
        Me.Controls.Add(Me.CBClass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblOc)
        Me.Controls.Add(Me.CBScore)
        Me.Controls.Add(Me.cmbSubject)
        Me.Controls.Add(Me.btnNazad)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(517, 440)
        Me.MinimumSize = New System.Drawing.Size(517, 440)
        Me.Name = "Dnevnik"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dnevnik"
        CType(Me.StudentDataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNazad As Button
    Friend WithEvents cmbSubject As ComboBox
    Friend WithEvents CBScore As ComboBox
    Friend WithEvents lblOc As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CBClass As ComboBox
    Friend WithEvents CBYear As ComboBox
    Friend WithEvents lblRaz As Label
    Friend WithEvents lblOd As Label
    Friend WithEvents StudentDataView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents lblSubjectID As Label
    Friend WithEvents lblUserID As Label
End Class
