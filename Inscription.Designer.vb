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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", ""}, -1)
        Me.title_label = New System.Windows.Forms.Label()
        Me.nom_label = New System.Windows.Forms.Label()
        Me.nom_TextBox = New System.Windows.Forms.TextBox()
        Me.email_TextBox = New System.Windows.Forms.TextBox()
        Me.email_label = New System.Windows.Forms.Label()
        Me.sexe_label = New System.Windows.Forms.Label()
        Me.datedenaissance_label = New System.Windows.Forms.Label()
        Me.motdepasse_TextBox = New System.Windows.Forms.TextBox()
        Me.motdepasse_label = New System.Windows.Forms.Label()
        Me.confirmationmotdepasse_TextBox = New System.Windows.Forms.TextBox()
        Me.confirmationmotdepasse_label = New System.Windows.Forms.Label()
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
        Me.SuspendLayout()
        '
        'title_label
        '
        Me.title_label.AutoSize = True
        Me.title_label.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.title_label.Location = New System.Drawing.Point(128, 31)
        Me.title_label.Name = "title_label"
        Me.title_label.Size = New System.Drawing.Size(125, 32)
        Me.title_label.TabIndex = 0
        Me.title_label.Text = "Inscription"
        '
        'nom_label
        '
        Me.nom_label.AutoSize = True
        Me.nom_label.Location = New System.Drawing.Point(73, 89)
        Me.nom_label.Name = "nom_label"
        Me.nom_label.Size = New System.Drawing.Size(34, 15)
        Me.nom_label.TabIndex = 1
        Me.nom_label.Text = "Nom"
        '
        'nom_TextBox
        '
        Me.nom_TextBox.Location = New System.Drawing.Point(195, 86)
        Me.nom_TextBox.Name = "nom_TextBox"
        Me.nom_TextBox.Size = New System.Drawing.Size(125, 23)
        Me.nom_TextBox.TabIndex = 2
        '
        'email_TextBox
        '
        Me.email_TextBox.Location = New System.Drawing.Point(195, 129)
        Me.email_TextBox.Name = "email_TextBox"
        Me.email_TextBox.Size = New System.Drawing.Size(125, 23)
        Me.email_TextBox.TabIndex = 4
        '
        'email_label
        '
        Me.email_label.AutoSize = True
        Me.email_label.Location = New System.Drawing.Point(73, 132)
        Me.email_label.Name = "email_label"
        Me.email_label.Size = New System.Drawing.Size(36, 15)
        Me.email_label.TabIndex = 3
        Me.email_label.Text = "Email"
        '
        'sexe_label
        '
        Me.sexe_label.AutoSize = True
        Me.sexe_label.Location = New System.Drawing.Point(73, 174)
        Me.sexe_label.Name = "sexe_label"
        Me.sexe_label.Size = New System.Drawing.Size(31, 15)
        Me.sexe_label.TabIndex = 5
        Me.sexe_label.Text = "Sexe"
        '
        'datedenaissance_label
        '
        Me.datedenaissance_label.AutoSize = True
        Me.datedenaissance_label.Location = New System.Drawing.Point(73, 216)
        Me.datedenaissance_label.Name = "datedenaissance_label"
        Me.datedenaissance_label.Size = New System.Drawing.Size(101, 15)
        Me.datedenaissance_label.TabIndex = 7
        Me.datedenaissance_label.Text = "Date de naissance"
        '
        'motdepasse_TextBox
        '
        Me.motdepasse_TextBox.Location = New System.Drawing.Point(195, 256)
        Me.motdepasse_TextBox.Name = "motdepasse_TextBox"
        Me.motdepasse_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.motdepasse_TextBox.Size = New System.Drawing.Size(125, 23)
        Me.motdepasse_TextBox.TabIndex = 7
        '
        'motdepasse_label
        '
        Me.motdepasse_label.AutoSize = True
        Me.motdepasse_label.Location = New System.Drawing.Point(73, 259)
        Me.motdepasse_label.Name = "motdepasse_label"
        Me.motdepasse_label.Size = New System.Drawing.Size(77, 15)
        Me.motdepasse_label.TabIndex = 9
        Me.motdepasse_label.Text = "Mot de passe"
        '
        'confirmationmotdepasse_TextBox
        '
        Me.confirmationmotdepasse_TextBox.Location = New System.Drawing.Point(195, 302)
        Me.confirmationmotdepasse_TextBox.Name = "confirmationmotdepasse_TextBox"
        Me.confirmationmotdepasse_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.confirmationmotdepasse_TextBox.Size = New System.Drawing.Size(125, 23)
        Me.confirmationmotdepasse_TextBox.TabIndex = 8
        '
        'confirmationmotdepasse_label
        '
        Me.confirmationmotdepasse_label.AutoSize = True
        Me.confirmationmotdepasse_label.Location = New System.Drawing.Point(73, 305)
        Me.confirmationmotdepasse_label.Name = "confirmationmotdepasse_label"
        Me.confirmationmotdepasse_label.Size = New System.Drawing.Size(78, 15)
        Me.confirmationmotdepasse_label.TabIndex = 11
        Me.confirmationmotdepasse_label.Text = "Confirmation"
        '
        'initialiser_button
        '
        Me.initialiser_button.Location = New System.Drawing.Point(76, 389)
        Me.initialiser_button.Name = "initialiser_button"
        Me.initialiser_button.Size = New System.Drawing.Size(75, 23)
        Me.initialiser_button.TabIndex = 10
        Me.initialiser_button.Text = "Initialiser"
        Me.initialiser_button.UseVisualStyleBackColor = True
        '
        'enregistrer_button
        '
        Me.enregistrer_button.Location = New System.Drawing.Point(195, 389)
        Me.enregistrer_button.Name = "enregistrer_button"
        Me.enregistrer_button.Size = New System.Drawing.Size(125, 23)
        Me.enregistrer_button.TabIndex = 9
        Me.enregistrer_button.Text = "Enregistrer"
        Me.enregistrer_button.UseVisualStyleBackColor = True
        '
        'ListView
        '
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nom_c, Me.Email_c, Me.Sexe_c, Me.Datedenaissance_c, Me.motdepasse_c})
        Me.ListView.HideSelection = False
        Me.ListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListView.Location = New System.Drawing.Point(381, 60)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(407, 352)
        Me.ListView.TabIndex = 15
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'Nom_c
        '
        Me.Nom_c.Text = "Nom"
        Me.Nom_c.Width = 70
        '
        'Email_c
        '
        Me.Email_c.Text = "Email"
        Me.Email_c.Width = 100
        '
        'Sexe_c
        '
        Me.Sexe_c.Text = "Sex"
        Me.Sexe_c.Width = 40
        '
        'Datedenaissance_c
        '
        Me.Datedenaissance_c.Text = "Date de naissance"
        Me.Datedenaissance_c.Width = 100
        '
        'motdepasse_c
        '
        Me.motdepasse_c.Text = "Mot de passe"
        Me.motdepasse_c.Width = 90
        '
        'datenaissance_datepicker
        '
        Me.datenaissance_datepicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datenaissance_datepicker.Location = New System.Drawing.Point(195, 216)
        Me.datenaissance_datepicker.Name = "datenaissance_datepicker"
        Me.datenaissance_datepicker.Size = New System.Drawing.Size(125, 23)
        Me.datenaissance_datepicker.TabIndex = 6
        '
        'sexe_ComboBox
        '
        Me.sexe_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sexe_ComboBox.FormattingEnabled = True
        Me.sexe_ComboBox.ItemHeight = 15
        Me.sexe_ComboBox.Items.AddRange(New Object() {"Homme", "Femme"})
        Me.sexe_ComboBox.Location = New System.Drawing.Point(195, 171)
        Me.sexe_ComboBox.Name = "sexe_ComboBox"
        Me.sexe_ComboBox.Size = New System.Drawing.Size(125, 23)
        Me.sexe_ComboBox.TabIndex = 5
        '
        'back_btn
        '
        Me.back_btn.Location = New System.Drawing.Point(12, 12)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(27, 23)
        Me.back_btn.TabIndex = 16
        Me.back_btn.Text = "<"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'Inscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.sexe_ComboBox)
        Me.Controls.Add(Me.datenaissance_datepicker)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.enregistrer_button)
        Me.Controls.Add(Me.initialiser_button)
        Me.Controls.Add(Me.confirmationmotdepasse_TextBox)
        Me.Controls.Add(Me.confirmationmotdepasse_label)
        Me.Controls.Add(Me.motdepasse_TextBox)
        Me.Controls.Add(Me.motdepasse_label)
        Me.Controls.Add(Me.datedenaissance_label)
        Me.Controls.Add(Me.sexe_label)
        Me.Controls.Add(Me.email_TextBox)
        Me.Controls.Add(Me.email_label)
        Me.Controls.Add(Me.nom_TextBox)
        Me.Controls.Add(Me.nom_label)
        Me.Controls.Add(Me.title_label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Inscription"
        Me.Text = "Inscription"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title_label As Label
    Friend WithEvents nom_label As Label
    Friend WithEvents nom_TextBox As TextBox
    Friend WithEvents email_TextBox As TextBox
    Friend WithEvents email_label As Label
    Friend WithEvents sexe_label As Label
    Friend WithEvents datedenaissance_label As Label
    Friend WithEvents motdepasse_TextBox As TextBox
    Friend WithEvents motdepasse_label As Label
    Friend WithEvents confirmationmotdepasse_TextBox As TextBox
    Friend WithEvents confirmationmotdepasse_label As Label
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
End Class
