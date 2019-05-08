<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ocjene
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ocjene))
        Me.btnNazad = New System.Windows.Forms.Button()
        Me.DataView = New System.Windows.Forms.DataGridView()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNazad
        '
        Me.btnNazad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNazad.Image = Global.eDnevnik.My.Resources.Resources.back_32x32
        Me.btnNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNazad.Location = New System.Drawing.Point(293, 339)
        Me.btnNazad.Name = "btnNazad"
        Me.btnNazad.Size = New System.Drawing.Size(84, 36)
        Me.btnNazad.TabIndex = 49
        Me.btnNazad.Text = "Nazad"
        Me.btnNazad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNazad.UseVisualStyleBackColor = True
        '
        'DataView
        '
        Me.DataView.AllowUserToAddRows = False
        Me.DataView.AllowUserToDeleteRows = False
        Me.DataView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataView.Location = New System.Drawing.Point(12, 52)
        Me.DataView.MaximumSize = New System.Drawing.Size(0, 262)
        Me.DataView.Name = "DataView"
        Me.DataView.ReadOnly = True
        Me.DataView.Size = New System.Drawing.Size(0, 262)
        Me.DataView.TabIndex = 50
        '
        'txtFilter
        '
        Me.txtFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilter.Location = New System.Drawing.Point(12, 346)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(275, 22)
        Me.txtFilter.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 16)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Pretraži predmete po imenu"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(358, 34)
        Me.RichTextBox1.TabIndex = 54
        Me.RichTextBox1.Text = "Prikaz predmeta ispod! Ako predmeta nema, nemate ocjene ili niste ispravno pretra" &
    "žili predmet!"
        '
        'Ocjene
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(379, 387)
        Me.ControlBox = False
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.DataView)
        Me.Controls.Add(Me.btnNazad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(399, 430)
        Me.MinimumSize = New System.Drawing.Size(399, 430)
        Me.Name = "Ocjene"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ocjene"
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNazad As Button
    Friend WithEvents DataView As DataGridView
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
