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
        Me.DataView = New System.Windows.Forms.DataGridView()
        Me.txtIme = New System.Windows.Forms.TextBox()
        Me.txtPrezime = New System.Windows.Forms.TextBox()
        Me.txtRod = New System.Windows.Forms.TextBox()
        Me.txtAdresa = New System.Windows.Forms.TextBox()
        Me.txtDatumR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAcceptReg = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBKorIme = New System.Windows.Forms.RadioButton()
        Me.RBJmbg = New System.Windows.Forms.RadioButton()
        Me.RBPrezime = New System.Windows.Forms.RadioButton()
        Me.RBIme = New System.Windows.Forms.RadioButton()
        Me.BtnKorisnici = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnRegReq = New System.Windows.Forms.Button()
        Me.ButtonOdjava = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblJmbg = New System.Windows.Forms.Label()
        Me.lblKorIme = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataView
        '
        Me.DataView.AllowUserToAddRows = False
        Me.DataView.AllowUserToDeleteRows = False
        Me.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataView.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.DataView.Location = New System.Drawing.Point(12, 236)
        Me.DataView.Name = "DataView"
        Me.DataView.ReadOnly = True
        Me.DataView.Size = New System.Drawing.Size(770, 266)
        Me.DataView.TabIndex = 21
        '
        'txtIme
        '
        Me.txtIme.Location = New System.Drawing.Point(180, 12)
        Me.txtIme.Name = "txtIme"
        Me.txtIme.Size = New System.Drawing.Size(213, 20)
        Me.txtIme.TabIndex = 24
        '
        'txtPrezime
        '
        Me.txtPrezime.Location = New System.Drawing.Point(180, 39)
        Me.txtPrezime.Name = "txtPrezime"
        Me.txtPrezime.Size = New System.Drawing.Size(213, 20)
        Me.txtPrezime.TabIndex = 25
        '
        'txtRod
        '
        Me.txtRod.Location = New System.Drawing.Point(180, 69)
        Me.txtRod.Name = "txtRod"
        Me.txtRod.Size = New System.Drawing.Size(213, 20)
        Me.txtRod.TabIndex = 26
        '
        'txtAdresa
        '
        Me.txtAdresa.Location = New System.Drawing.Point(180, 102)
        Me.txtAdresa.Name = "txtAdresa"
        Me.txtAdresa.Size = New System.Drawing.Size(213, 20)
        Me.txtAdresa.TabIndex = 28
        '
        'txtDatumR
        '
        Me.txtDatumR.Location = New System.Drawing.Point(180, 131)
        Me.txtDatumR.Name = "txtDatumR"
        Me.txtDatumR.Size = New System.Drawing.Size(213, 20)
        Me.txtDatumR.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Ime"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Prezime"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(93, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Ime roditelja"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(117, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Adresa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(82, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Datum rođenja"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnAcceptReg)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Location = New System.Drawing.Point(399, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 98)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Image = Global.eDnevnik.My.Resources.Resources.update_32x32
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.Location = New System.Drawing.Point(4, 12)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 35)
        Me.btnUpdate.TabIndex = 26
        Me.btnUpdate.Text = "Ažuriraj"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAcceptReg
        '
        Me.btnAcceptReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcceptReg.Image = Global.eDnevnik.My.Resources.Resources.accept_32x32
        Me.btnAcceptReg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAcceptReg.Location = New System.Drawing.Point(6, 52)
        Me.btnAcceptReg.Name = "btnAcceptReg"
        Me.btnAcceptReg.Size = New System.Drawing.Size(196, 37)
        Me.btnAcceptReg.TabIndex = 24
        Me.btnAcceptReg.Text = "Odobri registraciju"
        Me.btnAcceptReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAcceptReg.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.eDnevnik.My.Resources.Resources.permDel_32x32
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.Location = New System.Drawing.Point(110, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 35)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "Obriši"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBKorIme)
        Me.GroupBox2.Controls.Add(Me.RBJmbg)
        Me.GroupBox2.Controls.Add(Me.RBPrezime)
        Me.GroupBox2.Controls.Add(Me.RBIme)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(204, 70)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filteri"
        '
        'RBKorIme
        '
        Me.RBKorIme.AutoSize = True
        Me.RBKorIme.Location = New System.Drawing.Point(103, 42)
        Me.RBKorIme.Name = "RBKorIme"
        Me.RBKorIme.Size = New System.Drawing.Size(93, 17)
        Me.RBKorIme.TabIndex = 3
        Me.RBKorIme.TabStop = True
        Me.RBKorIme.Text = "Korisničko ime"
        Me.RBKorIme.UseVisualStyleBackColor = True
        '
        'RBJmbg
        '
        Me.RBJmbg.AutoSize = True
        Me.RBJmbg.Location = New System.Drawing.Point(104, 19)
        Me.RBJmbg.Name = "RBJmbg"
        Me.RBJmbg.Size = New System.Drawing.Size(79, 17)
        Me.RBJmbg.TabIndex = 2
        Me.RBJmbg.TabStop = True
        Me.RBJmbg.Text = "Matični broj"
        Me.RBJmbg.UseVisualStyleBackColor = True
        '
        'RBPrezime
        '
        Me.RBPrezime.AutoSize = True
        Me.RBPrezime.Location = New System.Drawing.Point(7, 44)
        Me.RBPrezime.Name = "RBPrezime"
        Me.RBPrezime.Size = New System.Drawing.Size(62, 17)
        Me.RBPrezime.TabIndex = 1
        Me.RBPrezime.TabStop = True
        Me.RBPrezime.Text = "Prezime"
        Me.RBPrezime.UseVisualStyleBackColor = True
        '
        'RBIme
        '
        Me.RBIme.AutoSize = True
        Me.RBIme.Location = New System.Drawing.Point(7, 20)
        Me.RBIme.Name = "RBIme"
        Me.RBIme.Size = New System.Drawing.Size(42, 17)
        Me.RBIme.TabIndex = 0
        Me.RBIme.TabStop = True
        Me.RBIme.Text = "Ime"
        Me.RBIme.UseVisualStyleBackColor = True
        '
        'BtnKorisnici
        '
        Me.BtnKorisnici.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKorisnici.Image = Global.eDnevnik.My.Resources.Resources.user_32x32
        Me.BtnKorisnici.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnKorisnici.Location = New System.Drawing.Point(621, 89)
        Me.BtnKorisnici.Name = "BtnKorisnici"
        Me.BtnKorisnici.Size = New System.Drawing.Size(161, 33)
        Me.BtnKorisnici.TabIndex = 41
        Me.BtnKorisnici.Text = "Pregled korisnika"
        Me.BtnKorisnici.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKorisnici.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Global.eDnevnik.My.Resources.Resources.refresh_32x32
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.Location = New System.Drawing.Point(405, 117)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 35)
        Me.btnRefresh.TabIndex = 24
        Me.btnRefresh.Text = "Osvježi"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.eDnevnik.My.Resources.Resources.search_32x32
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.Location = New System.Drawing.Point(225, 195)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 35)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Pretraži"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnRegReq
        '
        Me.btnRegReq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegReq.Image = Global.eDnevnik.My.Resources.Resources.registration_32x32
        Me.btnRegReq.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnRegReq.Location = New System.Drawing.Point(621, 12)
        Me.btnRegReq.Name = "btnRegReq"
        Me.btnRegReq.Size = New System.Drawing.Size(161, 70)
        Me.btnRegReq.TabIndex = 20
        Me.btnRegReq.Text = "Pregled zahtjeva za registraciju"
        Me.btnRegReq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegReq.UseVisualStyleBackColor = True
        '
        'ButtonOdjava
        '
        Me.ButtonOdjava.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOdjava.Image = Global.eDnevnik.My.Resources.Resources.back_32x32
        Me.ButtonOdjava.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonOdjava.Location = New System.Drawing.Point(698, 128)
        Me.ButtonOdjava.Name = "ButtonOdjava"
        Me.ButtonOdjava.Size = New System.Drawing.Size(84, 36)
        Me.ButtonOdjava.TabIndex = 19
        Me.ButtonOdjava.Text = "Odjava"
        Me.ButtonOdjava.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonOdjava.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.eDnevnik.My.Resources.Resources.admin_64x64
        Me.PictureBox3.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(12, 97)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(0, 13)
        Me.lblType.TabIndex = 42
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(15, 160)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(0, 13)
        Me.lblPassword.TabIndex = 43
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(225, 169)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(232, 20)
        Me.txtSearch.TabIndex = 44
        '
        'lblJmbg
        '
        Me.lblJmbg.AutoSize = True
        Me.lblJmbg.Location = New System.Drawing.Point(733, 306)
        Me.lblJmbg.Name = "lblJmbg"
        Me.lblJmbg.Size = New System.Drawing.Size(0, 13)
        Me.lblJmbg.TabIndex = 45
        '
        'lblKorIme
        '
        Me.lblKorIme.AutoSize = True
        Me.lblKorIme.Location = New System.Drawing.Point(736, 85)
        Me.lblKorIme.Name = "lblKorIme"
        Me.lblKorIme.Size = New System.Drawing.Size(0, 13)
        Me.lblKorIme.TabIndex = 46
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(698, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 43)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Nazad na profil"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(792, 507)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblKorIme)
        Me.Controls.Add(Me.lblJmbg)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.BtnKorisnici)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDatumR)
        Me.Controls.Add(Me.txtAdresa)
        Me.Controls.Add(Me.txtRod)
        Me.Controls.Add(Me.txtPrezime)
        Me.Controls.Add(Me.txtIme)
        Me.Controls.Add(Me.DataView)
        Me.Controls.Add(Me.btnRegReq)
        Me.Controls.Add(Me.ButtonOdjava)
        Me.Controls.Add(Me.PictureBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(812, 550)
        Me.MinimumSize = New System.Drawing.Size(812, 550)
        Me.Name = "Form2Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administratoski panel"
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ButtonOdjava As Button
    Friend WithEvents btnRegReq As Button
    Friend WithEvents DataView As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtIme As TextBox
    Friend WithEvents txtPrezime As TextBox
    Friend WithEvents txtRod As TextBox
    Friend WithEvents txtAdresa As TextBox
    Friend WithEvents txtDatumR As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnAcceptReg As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RBKorIme As RadioButton
    Friend WithEvents RBJmbg As RadioButton
    Friend WithEvents RBPrezime As RadioButton
    Friend WithEvents RBIme As RadioButton
    Friend WithEvents btnUpdate As Button
    Friend WithEvents BtnKorisnici As Button
    Friend WithEvents lblType As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblJmbg As Label
    Friend WithEvents lblKorIme As Label
    Friend WithEvents Button1 As Button
End Class
