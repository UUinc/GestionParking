<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionUtilisateur
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
        Me.usericon_img = New System.Windows.Forms.PictureBox()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.nom_c = New System.Windows.Forms.ColumnHeader()
        Me.email_c = New System.Windows.Forms.ColumnHeader()
        Me.sex_c = New System.Windows.Forms.ColumnHeader()
        Me.dateDeNaissance_c = New System.Windows.Forms.ColumnHeader()
        Me.motDePasse_c = New System.Windows.Forms.ColumnHeader()
        Me.modifier_Button = New System.Windows.Forms.Button()
        Me.entrer_Button = New System.Windows.Forms.Button()
        Me.sortir_Button = New System.Windows.Forms.Button()
        Me.supprimer_Button = New System.Windows.Forms.Button()
        Me.title_label = New System.Windows.Forms.Label()
        Me.sexe_ComboBox = New System.Windows.Forms.ComboBox()
        Me.datenaissance_datepicker = New System.Windows.Forms.DateTimePicker()
        Me.confirmationmotdepasse_TextBox = New System.Windows.Forms.TextBox()
        Me.motdepasse_TextBox = New System.Windows.Forms.TextBox()
        Me.email_TextBox = New System.Windows.Forms.TextBox()
        Me.nom_TextBox = New System.Windows.Forms.TextBox()
        Me.nom_underline_label = New System.Windows.Forms.Label()
        Me.email_underline_label = New System.Windows.Forms.Label()
        Me.confirmMotDePasse_underline_label = New System.Windows.Forms.Label()
        Me.motDePasse_underline_label = New System.Windows.Forms.Label()
        Me.sexe_underline_label = New System.Windows.Forms.Label()
        Me.DateOfBirth_label = New System.Windows.Forms.Label()
        Me.error_label = New System.Windows.Forms.Label()
        CType(Me.usericon_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'usericon_img
        '
        Me.usericon_img.BackColor = System.Drawing.Color.Transparent
        Me.usericon_img.BackgroundImage = Global.GestionParking.My.Resources.Resources.userMangement_dark
        Me.usericon_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.usericon_img.Location = New System.Drawing.Point(427, 28)
        Me.usericon_img.Name = "usericon_img"
        Me.usericon_img.Size = New System.Drawing.Size(80, 80)
        Me.usericon_img.TabIndex = 71
        Me.usericon_img.TabStop = False
        '
        'ListView
        '
        Me.ListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nom_c, Me.email_c, Me.sex_c, Me.dateDeNaissance_c, Me.motDePasse_c})
        Me.ListView.Font = New System.Drawing.Font("Kanit Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListView.ForeColor = System.Drawing.Color.White
        Me.ListView.HideSelection = False
        Me.ListView.Location = New System.Drawing.Point(548, -1)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(722, 682)
        Me.ListView.TabIndex = 70
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'nom_c
        '
        Me.nom_c.Text = "Nom"
        Me.nom_c.Width = 140
        '
        'email_c
        '
        Me.email_c.Text = "Email"
        Me.email_c.Width = 160
        '
        'sex_c
        '
        Me.sex_c.Text = "Sexe"
        Me.sex_c.Width = 120
        '
        'dateDeNaissance_c
        '
        Me.dateDeNaissance_c.Text = "Date de naissance"
        Me.dateDeNaissance_c.Width = 150
        '
        'motDePasse_c
        '
        Me.motDePasse_c.Text = "Mot de passe"
        Me.motDePasse_c.Width = 150
        '
        'modifier_Button
        '
        Me.modifier_Button.BackColor = System.Drawing.Color.Transparent
        Me.modifier_Button.BackgroundImage = Global.GestionParking.My.Resources.Resources.btnBG
        Me.modifier_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.modifier_Button.FlatAppearance.BorderSize = 0
        Me.modifier_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.modifier_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.modifier_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.modifier_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modifier_Button.Font = New System.Drawing.Font("Kanit", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.modifier_Button.ForeColor = System.Drawing.Color.White
        Me.modifier_Button.Location = New System.Drawing.Point(204, 620)
        Me.modifier_Button.Name = "modifier_Button"
        Me.modifier_Button.Size = New System.Drawing.Size(130, 40)
        Me.modifier_Button.TabIndex = 69
        Me.modifier_Button.Text = "Change"
        Me.modifier_Button.UseVisualStyleBackColor = False
        '
        'entrer_Button
        '
        Me.entrer_Button.BackColor = System.Drawing.Color.Transparent
        Me.entrer_Button.BackgroundImage = Global.GestionParking.My.Resources.Resources.btnBG
        Me.entrer_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.entrer_Button.FlatAppearance.BorderSize = 0
        Me.entrer_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.entrer_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.entrer_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.entrer_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.entrer_Button.Font = New System.Drawing.Font("Kanit", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.entrer_Button.ForeColor = System.Drawing.Color.White
        Me.entrer_Button.Location = New System.Drawing.Point(39, 620)
        Me.entrer_Button.Name = "entrer_Button"
        Me.entrer_Button.Size = New System.Drawing.Size(130, 40)
        Me.entrer_Button.TabIndex = 68
        Me.entrer_Button.Text = "Save"
        Me.entrer_Button.UseVisualStyleBackColor = False
        '
        'sortir_Button
        '
        Me.sortir_Button.BackColor = System.Drawing.Color.Transparent
        Me.sortir_Button.BackgroundImage = Global.GestionParking.My.Resources.Resources.back
        Me.sortir_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sortir_Button.FlatAppearance.BorderSize = 0
        Me.sortir_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.sortir_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.sortir_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sortir_Button.Font = New System.Drawing.Font("Kanit", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.sortir_Button.Location = New System.Drawing.Point(4, 8)
        Me.sortir_Button.Name = "sortir_Button"
        Me.sortir_Button.Size = New System.Drawing.Size(40, 40)
        Me.sortir_Button.TabIndex = 67
        Me.sortir_Button.UseVisualStyleBackColor = False
        '
        'supprimer_Button
        '
        Me.supprimer_Button.BackColor = System.Drawing.Color.Transparent
        Me.supprimer_Button.BackgroundImage = Global.GestionParking.My.Resources.Resources.btnBG
        Me.supprimer_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.supprimer_Button.FlatAppearance.BorderSize = 0
        Me.supprimer_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.supprimer_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.supprimer_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.supprimer_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.supprimer_Button.Font = New System.Drawing.Font("Kanit", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.supprimer_Button.ForeColor = System.Drawing.Color.White
        Me.supprimer_Button.Location = New System.Drawing.Point(368, 620)
        Me.supprimer_Button.Name = "supprimer_Button"
        Me.supprimer_Button.Size = New System.Drawing.Size(130, 40)
        Me.supprimer_Button.TabIndex = 66
        Me.supprimer_Button.Text = "Remove"
        Me.supprimer_Button.UseVisualStyleBackColor = False
        '
        'title_label
        '
        Me.title_label.AutoSize = True
        Me.title_label.Font = New System.Drawing.Font("Kanit", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.title_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.title_label.Location = New System.Drawing.Point(44, 28)
        Me.title_label.Name = "title_label"
        Me.title_label.Size = New System.Drawing.Size(380, 68)
        Me.title_label.TabIndex = 53
        Me.title_label.Text = "User management"
        '
        'sexe_ComboBox
        '
        Me.sexe_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sexe_ComboBox.Font = New System.Drawing.Font("Kanit Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.sexe_ComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.sexe_ComboBox.FormattingEnabled = True
        Me.sexe_ComboBox.ItemHeight = 30
        Me.sexe_ComboBox.Items.AddRange(New Object() {"Homme", "Femme"})
        Me.sexe_ComboBox.Location = New System.Drawing.Point(86, 399)
        Me.sexe_ComboBox.Name = "sexe_ComboBox"
        Me.sexe_ComboBox.Size = New System.Drawing.Size(350, 38)
        Me.sexe_ComboBox.TabIndex = 76
        Me.sexe_ComboBox.Text = "Homme"
        '
        'datenaissance_datepicker
        '
        Me.datenaissance_datepicker.CalendarFont = New System.Drawing.Font("Kanit Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.datenaissance_datepicker.Font = New System.Drawing.Font("Roboto Lt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.datenaissance_datepicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datenaissance_datepicker.Location = New System.Drawing.Point(88, 491)
        Me.datenaissance_datepicker.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.datenaissance_datepicker.Name = "datenaissance_datepicker"
        Me.datenaissance_datepicker.Size = New System.Drawing.Size(350, 30)
        Me.datenaissance_datepicker.TabIndex = 77
        Me.datenaissance_datepicker.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'confirmationmotdepasse_TextBox
        '
        Me.confirmationmotdepasse_TextBox.BackColor = System.Drawing.Color.White
        Me.confirmationmotdepasse_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.confirmationmotdepasse_TextBox.Font = New System.Drawing.Font("Kanit Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.confirmationmotdepasse_TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.confirmationmotdepasse_TextBox.Location = New System.Drawing.Point(86, 350)
        Me.confirmationmotdepasse_TextBox.Name = "confirmationmotdepasse_TextBox"
        Me.confirmationmotdepasse_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.confirmationmotdepasse_TextBox.PlaceholderText = "Confirm password"
        Me.confirmationmotdepasse_TextBox.Size = New System.Drawing.Size(350, 29)
        Me.confirmationmotdepasse_TextBox.TabIndex = 75
        '
        'motdepasse_TextBox
        '
        Me.motdepasse_TextBox.BackColor = System.Drawing.Color.White
        Me.motdepasse_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.motdepasse_TextBox.Font = New System.Drawing.Font("Kanit Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.motdepasse_TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.motdepasse_TextBox.Location = New System.Drawing.Point(86, 291)
        Me.motdepasse_TextBox.Name = "motdepasse_TextBox"
        Me.motdepasse_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.motdepasse_TextBox.PlaceholderText = "New password"
        Me.motdepasse_TextBox.Size = New System.Drawing.Size(350, 29)
        Me.motdepasse_TextBox.TabIndex = 74
        '
        'email_TextBox
        '
        Me.email_TextBox.BackColor = System.Drawing.Color.White
        Me.email_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.email_TextBox.Font = New System.Drawing.Font("Kanit Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.email_TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.email_TextBox.Location = New System.Drawing.Point(86, 234)
        Me.email_TextBox.Name = "email_TextBox"
        Me.email_TextBox.PlaceholderText = "Email address"
        Me.email_TextBox.Size = New System.Drawing.Size(350, 29)
        Me.email_TextBox.TabIndex = 73
        '
        'nom_TextBox
        '
        Me.nom_TextBox.BackColor = System.Drawing.Color.White
        Me.nom_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nom_TextBox.Font = New System.Drawing.Font("Kanit Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nom_TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.nom_TextBox.Location = New System.Drawing.Point(86, 174)
        Me.nom_TextBox.Name = "nom_TextBox"
        Me.nom_TextBox.PlaceholderText = "Full name"
        Me.nom_TextBox.Size = New System.Drawing.Size(350, 29)
        Me.nom_TextBox.TabIndex = 72
        '
        'nom_underline_label
        '
        Me.nom_underline_label.AutoSize = True
        Me.nom_underline_label.BackColor = System.Drawing.Color.Transparent
        Me.nom_underline_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.nom_underline_label.Location = New System.Drawing.Point(84, 193)
        Me.nom_underline_label.Name = "nom_underline_label"
        Me.nom_underline_label.Size = New System.Drawing.Size(357, 15)
        Me.nom_underline_label.TabIndex = 78
        Me.nom_underline_label.Text = "______________________________________________________________________"
        '
        'email_underline_label
        '
        Me.email_underline_label.AutoSize = True
        Me.email_underline_label.BackColor = System.Drawing.Color.Transparent
        Me.email_underline_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.email_underline_label.Location = New System.Drawing.Point(84, 251)
        Me.email_underline_label.Name = "email_underline_label"
        Me.email_underline_label.Size = New System.Drawing.Size(357, 15)
        Me.email_underline_label.TabIndex = 79
        Me.email_underline_label.Text = "______________________________________________________________________"
        '
        'confirmMotDePasse_underline_label
        '
        Me.confirmMotDePasse_underline_label.AutoSize = True
        Me.confirmMotDePasse_underline_label.BackColor = System.Drawing.Color.Transparent
        Me.confirmMotDePasse_underline_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.confirmMotDePasse_underline_label.Location = New System.Drawing.Point(84, 367)
        Me.confirmMotDePasse_underline_label.Name = "confirmMotDePasse_underline_label"
        Me.confirmMotDePasse_underline_label.Size = New System.Drawing.Size(357, 15)
        Me.confirmMotDePasse_underline_label.TabIndex = 81
        Me.confirmMotDePasse_underline_label.Text = "______________________________________________________________________"
        '
        'motDePasse_underline_label
        '
        Me.motDePasse_underline_label.AutoSize = True
        Me.motDePasse_underline_label.BackColor = System.Drawing.Color.Transparent
        Me.motDePasse_underline_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.motDePasse_underline_label.Location = New System.Drawing.Point(84, 309)
        Me.motDePasse_underline_label.Name = "motDePasse_underline_label"
        Me.motDePasse_underline_label.Size = New System.Drawing.Size(357, 15)
        Me.motDePasse_underline_label.TabIndex = 80
        Me.motDePasse_underline_label.Text = "______________________________________________________________________"
        '
        'sexe_underline_label
        '
        Me.sexe_underline_label.AutoSize = True
        Me.sexe_underline_label.BackColor = System.Drawing.Color.Transparent
        Me.sexe_underline_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.sexe_underline_label.Location = New System.Drawing.Point(86, 425)
        Me.sexe_underline_label.Name = "sexe_underline_label"
        Me.sexe_underline_label.Size = New System.Drawing.Size(357, 15)
        Me.sexe_underline_label.TabIndex = 82
        Me.sexe_underline_label.Text = "______________________________________________________________________"
        '
        'DateOfBirth_label
        '
        Me.DateOfBirth_label.AutoSize = True
        Me.DateOfBirth_label.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateOfBirth_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.DateOfBirth_label.Location = New System.Drawing.Point(84, 463)
        Me.DateOfBirth_label.Name = "DateOfBirth_label"
        Me.DateOfBirth_label.Size = New System.Drawing.Size(111, 25)
        Me.DateOfBirth_label.TabIndex = 83
        Me.DateOfBirth_label.Text = "Date of birth :"
        '
        'error_label
        '
        Me.error_label.AutoSize = True
        Me.error_label.Font = New System.Drawing.Font("Kanit ExtraLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.error_label.ForeColor = System.Drawing.Color.Red
        Me.error_label.Location = New System.Drawing.Point(98, 556)
        Me.error_label.Name = "error_label"
        Me.error_label.Size = New System.Drawing.Size(326, 25)
        Me.error_label.TabIndex = 84
        Me.error_label.Text = "wrong inputs, double check your information"
        Me.error_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.error_label.Visible = False
        '
        'GestionUtilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.error_label)
        Me.Controls.Add(Me.DateOfBirth_label)
        Me.Controls.Add(Me.sexe_ComboBox)
        Me.Controls.Add(Me.datenaissance_datepicker)
        Me.Controls.Add(Me.confirmationmotdepasse_TextBox)
        Me.Controls.Add(Me.motdepasse_TextBox)
        Me.Controls.Add(Me.email_TextBox)
        Me.Controls.Add(Me.nom_TextBox)
        Me.Controls.Add(Me.nom_underline_label)
        Me.Controls.Add(Me.email_underline_label)
        Me.Controls.Add(Me.confirmMotDePasse_underline_label)
        Me.Controls.Add(Me.motDePasse_underline_label)
        Me.Controls.Add(Me.sexe_underline_label)
        Me.Controls.Add(Me.usericon_img)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.modifier_Button)
        Me.Controls.Add(Me.entrer_Button)
        Me.Controls.Add(Me.sortir_Button)
        Me.Controls.Add(Me.supprimer_Button)
        Me.Controls.Add(Me.title_label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "GestionUtilisateur"
        Me.Text = "User management"
        CType(Me.usericon_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents usericon_img As PictureBox
    Friend WithEvents ListView As ListView
    Friend WithEvents nom_c As ColumnHeader
    Friend WithEvents email_c As ColumnHeader
    Friend WithEvents sex_c As ColumnHeader
    Friend WithEvents dateDeNaissance_c As ColumnHeader
    Friend WithEvents modifier_Button As Button
    Friend WithEvents entrer_Button As Button
    Friend WithEvents sortir_Button As Button
    Friend WithEvents supprimer_Button As Button
    Friend WithEvents title_label As Label
    Friend WithEvents sexe_ComboBox As ComboBox
    Friend WithEvents datenaissance_datepicker As DateTimePicker
    Friend WithEvents confirmationmotdepasse_TextBox As TextBox
    Friend WithEvents motdepasse_TextBox As TextBox
    Friend WithEvents email_TextBox As TextBox
    Friend WithEvents nom_TextBox As TextBox
    Friend WithEvents nom_underline_label As Label
    Friend WithEvents email_underline_label As Label
    Friend WithEvents confirmMotDePasse_underline_label As Label
    Friend WithEvents motDePasse_underline_label As Label
    Friend WithEvents sexe_underline_label As Label
    Friend WithEvents motDePasse_c As ColumnHeader
    Friend WithEvents DateOfBirth_label As Label
    Friend WithEvents error_label As Label
End Class
