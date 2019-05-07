<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpitProfesor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpitProfesor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.DataView = New System.Windows.Forms.DataGridView()
        Me.btnOpenProfile = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Odaberi predmet"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(284, 31)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(101, 42)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Dodaj predmet"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtSubject
        '
        Me.txtSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.Location = New System.Drawing.Point(15, 41)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.ReadOnly = True
        Me.txtSubject.Size = New System.Drawing.Size(256, 22)
        Me.txtSubject.TabIndex = 2
        '
        'DataView
        '
        Me.DataView.AllowUserToAddRows = False
        Me.DataView.AllowUserToDeleteRows = False
        Me.DataView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataView.Location = New System.Drawing.Point(12, 93)
        Me.DataView.Name = "DataView"
        Me.DataView.ReadOnly = True
        Me.DataView.Size = New System.Drawing.Size(159, 307)
        Me.DataView.TabIndex = 3
        '
        'btnOpenProfile
        '
        Me.btnOpenProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenProfile.Location = New System.Drawing.Point(284, 370)
        Me.btnOpenProfile.Name = "btnOpenProfile"
        Me.btnOpenProfile.Size = New System.Drawing.Size(97, 30)
        Me.btnOpenProfile.TabIndex = 4
        Me.btnOpenProfile.Text = "Otvori profil"
        Me.btnOpenProfile.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(177, 103)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(189, 20)
        Me.txtSearch.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.eDnevnik.My.Resources.Resources.search_32x32
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.Location = New System.Drawing.Point(225, 129)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(141, 38)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Traži predmet"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'UpitProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(390, 409)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnOpenProfile)
        Me.Controls.Add(Me.DataView)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "UpitProfesor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Upit Profesora"
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents DataView As DataGridView
    Friend WithEvents btnOpenProfile As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
End Class
