<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inscription
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
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", ""}, -1)
        Me.title_label = New System.Windows.Forms.Label()
        Me.nom_TextBox = New System.Windows.Forms.TextBox()
        Me.email_TextBox = New System.Windows.Forms.TextBox()
        Me.motdepasse_TextBox = New System.Windows.Forms.TextBox()
        Me.confirmationmotdepasse_TextBox = New System.Windows.Forms.TextBox()
        Me.initialiser_button = New System.Windows.Forms.Button()
        Me.enregistrer_button = New System.Windows.Forms.Button()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.Nom_c = New System.Windows.Forms.ColumnHeader()
        Me.Email_c = New System.Windows.Forms.ColumnHeader()
        Me.Sexe_c = New System.Windows.Forms.ColumnHeader()
        Me.Datedenaissance_c = New System.Windows.Forms.ColumnHeader()
        Me.motdepasse_c = New System.Windows.Forms.ColumnHeader()
        Me.datenaissance_datepicker = New System.Windows.Forms.DateTimePicker()
        Me.sexe_ComboBox = New System.Windows.Forms.ComboBox()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.signin_l = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'title_label
        '
        Me.title_label.AutoSize = True
        Me.title_label.Font = New System.Drawing.Font("Kanit", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.title_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.title_label.Location = New System.Drawing.Point(379, 22)
        Me.title_label.Name = "title_label"
        Me.title_label.Size = New System.Drawing.Size(306, 59)
        Me.title_label.TabIndex = 0
        Me.title_label.Text = "Register Account"
        '
        'nom_TextBox
        '
        Me.nom_TextBox.BackColor = System.Drawing.Color.White
        Me.nom_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nom_TextBox.Font = New System.Drawing.Font("Kanit Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nom_TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.nom_TextBox.Location = New System.Drawing.Point(356, 110)
        Me.nom_TextBox.Name = "nom_TextBox"
        Me.nom_TextBox.PlaceholderText = "Full name"
        Me.nom_TextBox.Size = New System.Drawing.Size(350, 29)
        Me.nom_TextBox.TabIndex = 2
        '
        'email_TextBox
        '
        Me.email_TextBox.BackColor = System.Drawing.Color.White
        Me.email_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.email_TextBox.Font = New System.Drawing.Font("Kanit Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.email_TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.email_TextBox.Location = New System.Drawing.Point(356, 170)
        Me.email_TextBox.Name = "email_TextBox"
        Me.email_TextBox.PlaceholderText = "Email address"
        Me.email_TextBox.Size = New System.Drawing.Size(350, 29)
        Me.email_TextBox.TabIndex = 4
        '
        'motdepasse_TextBox
        '
        Me.motdepasse_TextBox.BackColor = System.Drawing.Color.White
        Me.motdepasse_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.motdepasse_TextBox.Font = New System.Drawing.Font("Kanit Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.motdepasse_TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.motdepasse_TextBox.Location = New System.Drawing.Point(356, 227)
        Me.motdepasse_TextBox.Name = "motdepasse_TextBox"
        Me.motdepasse_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.motdepasse_TextBox.PlaceholderText = "New password"
        Me.motdepasse_TextBox.Size = New System.Drawing.Size(350, 29)
        Me.motdepasse_TextBox.TabIndex = 5
        '
        'confirmationmotdepasse_TextBox
        '
        Me.confirmationmotdepasse_TextBox.BackColor = System.Drawing.Color.White
        Me.confirmationmotdepasse_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.confirmationmotdepasse_TextBox.Font = New System.Drawing.Font("Kanit Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.confirmationmotdepasse_TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.confirmationmotdepasse_TextBox.Location = New System.Drawing.Point(356, 286)
        Me.confirmationmotdepasse_TextBox.Name = "confirmationmotdepasse_TextBox"
        Me.confirmationmotdepasse_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.confirmationmotdepasse_TextBox.PlaceholderText = "Confirm password"
        Me.confirmationmotdepasse_TextBox.Size = New System.Drawing.Size(350, 29)
        Me.confirmationmotdepasse_TextBox.TabIndex = 6
        '
        'initialiser_button
        '
        Me.initialiser_button.BackColor = System.Drawing.Color.Transparent
        Me.initialiser_button.FlatAppearance.BorderSize = 0
        Me.initialiser_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.initialiser_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.initialiser_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.initialiser_button.Font = New System.Drawing.Font("Kanit Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.initialiser_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.initialiser_button.Location = New System.Drawing.Point(358, 454)
        Me.initialiser_button.Name = "initialiser_button"
        Me.initialiser_button.Size = New System.Drawing.Size(69, 36)
        Me.initialiser_button.TabIndex = 9
        Me.initialiser_button.Text = "Clear"
        Me.initialiser_button.UseVisualStyleBackColor = False
        '
        'enregistrer_button
        '
        Me.enregistrer_button.BackColor = System.Drawing.Color.Transparent
        Me.enregistrer_button.BackgroundImage = Global.GestionParking.My.Resources.Resources.btnBG
        Me.enregistrer_button.FlatAppearance.BorderSize = 0
        Me.enregistrer_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.enregistrer_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.enregistrer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.enregistrer_button.Font = New System.Drawing.Font("Kanit", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.enregistrer_button.ForeColor = System.Drawing.Color.White
        Me.enregistrer_button.Location = New System.Drawing.Point(440, 510)
        Me.enregistrer_button.Name = "enregistrer_button"
        Me.enregistrer_button.Size = New System.Drawing.Size(180, 50)
        Me.enregistrer_button.TabIndex = 10
        Me.enregistrer_button.Text = "Sign Up"
        Me.enregistrer_button.UseVisualStyleBackColor = False
        '
        'ListView
        '
        Me.ListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nom_c, Me.Email_c, Me.Sexe_c, Me.Datedenaissance_c, Me.motdepasse_c})
        Me.ListView.Font = New System.Drawing.Font("Kanit Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListView.ForeColor = System.Drawing.Color.White
        Me.ListView.HideSelection = False
        Me.ListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.ListView.Location = New System.Drawing.Point(756, 4)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(512, 686)
        Me.ListView.TabIndex = 15
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'Nom_c
        '
        Me.Nom_c.Text = "Nom"
        Me.Nom_c.Width = 90
        '
        'Email_c
        '
        Me.Email_c.Text = "Email"
        Me.Email_c.Width = 140
        '
        'Sexe_c
        '
        Me.Sexe_c.Text = "Sex"
        '
        'Datedenaissance_c
        '
        Me.Datedenaissance_c.Text = "Date de naissance"
        Me.Datedenaissance_c.Width = 115
        '
        'motdepasse_c
        '
        Me.motdepasse_c.Text = "Mot de passe"
        Me.motdepasse_c.Width = 100
        '
        'datenaissance_datepicker
        '
        Me.datenaissance_datepicker.CalendarFont = New System.Drawing.Font("Kanit Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.datenaissance_datepicker.Font = New System.Drawing.Font("Roboto Lt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.datenaissance_datepicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datenaissance_datepicker.Location = New System.Drawing.Point(358, 406)
        Me.datenaissance_datepicker.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.datenaissance_datepicker.Name = "datenaissance_datepicker"
        Me.datenaissance_datepicker.Size = New System.Drawing.Size(350, 30)
        Me.datenaissance_datepicker.TabIndex = 8
        '
        'sexe_ComboBox
        '
        Me.sexe_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sexe_ComboBox.Font = New System.Drawing.Font("Kanit Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.sexe_ComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.sexe_ComboBox.FormattingEnabled = True
        Me.sexe_ComboBox.ItemHeight = 30
        Me.sexe_ComboBox.Items.AddRange(New Object() {"Homme", "Femme"})
        Me.sexe_ComboBox.Location = New System.Drawing.Point(356, 335)
        Me.sexe_ComboBox.Name = "sexe_ComboBox"
        Me.sexe_ComboBox.Size = New System.Drawing.Size(350, 38)
        Me.sexe_ComboBox.TabIndex = 7
        Me.sexe_ComboBox.Text = "Homme"
        '
        'back_btn
        '
        Me.back_btn.BackColor = System.Drawing.Color.Transparent
        Me.back_btn.FlatAppearance.BorderSize = 0
        Me.back_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.back_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back_btn.Font = New System.Drawing.Font("Kanit", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.back_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.back_btn.Location = New System.Drawing.Point(587, 597)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(72, 34)
        Me.back_btn.TabIndex = 16
        Me.back_btn.Text = "Sign in"
        Me.back_btn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.GestionParking.My.Resources.Resources.parking_with_icon_thin
        Me.PictureBox1.Location = New System.Drawing.Point(0, -30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 720)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(354, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(357, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "______________________________________________________________________"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(354, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "______________________________________________________________________"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(354, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(357, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "______________________________________________________________________"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(354, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(357, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "______________________________________________________________________"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(356, 361)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(357, 15)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "______________________________________________________________________"
        '
        'signin_l
        '
        Me.signin_l.AutoSize = True
        Me.signin_l.Font = New System.Drawing.Font("Kanit Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.signin_l.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.signin_l.Location = New System.Drawing.Point(406, 602)
        Me.signin_l.Name = "signin_l"
        Me.signin_l.Size = New System.Drawing.Size(188, 25)
        Me.signin_l.TabIndex = 24
        Me.signin_l.Text = "Already have an account"
        Me.signin_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Inscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.signin_l)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.sexe_ComboBox)
        Me.Controls.Add(Me.datenaissance_datepicker)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.enregistrer_button)
        Me.Controls.Add(Me.initialiser_button)
        Me.Controls.Add(Me.confirmationmotdepasse_TextBox)
        Me.Controls.Add(Me.motdepasse_TextBox)
        Me.Controls.Add(Me.email_TextBox)
        Me.Controls.Add(Me.nom_TextBox)
        Me.Controls.Add(Me.title_label)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Inscription"
        Me.Text = "Sign up"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title_label As Label
    Friend WithEvents nom_TextBox As TextBox
    Friend WithEvents email_TextBox As TextBox
    Friend WithEvents motdepasse_TextBox As TextBox
    Friend WithEvents confirmationmotdepasse_TextBox As TextBox
    Friend WithEvents initialiser_button As Button
    Friend WithEvents enregistrer_button As Button
    Friend WithEvents ListView As ListView
    Friend WithEvents Nom_c As ColumnHeader
    Friend WithEvents Email_c As ColumnHeader
    Friend WithEvents Sexe_c As ColumnHeader
    Friend WithEvents Datedenaissance_c As ColumnHeader
    Friend WithEvents motdepasse_c As ColumnHeader
    Friend WithEvents datenaissance_datepicker As DateTimePicker
    Friend WithEvents sexe_ComboBox As ComboBox
    Friend WithEvents back_btn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents signin_l As Label
End Class
