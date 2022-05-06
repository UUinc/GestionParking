<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.nomUtilisateur_label = New System.Windows.Forms.Label()
        Me.motdepasse_label = New System.Windows.Forms.Label()
        Me.nomutilisateur_TextBox = New System.Windows.Forms.TextBox()
        Me.motdepasse_TextBox = New System.Windows.Forms.TextBox()
        Me.inscription_button = New System.Windows.Forms.Button()
        Me.connexion_Button = New System.Windows.Forms.Button()
        Me.erreursaisie_label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'nomUtilisateur_label
        '
        Me.nomUtilisateur_label.AutoSize = True
        Me.nomUtilisateur_label.Location = New System.Drawing.Point(228, 123)
        Me.nomUtilisateur_label.Name = "nomUtilisateur_label"
        Me.nomUtilisateur_label.Size = New System.Drawing.Size(99, 15)
        Me.nomUtilisateur_label.TabIndex = 0
        Me.nomUtilisateur_label.Text = "Nom Utilisateur : "
        '
        'motdepasse_label
        '
        Me.motdepasse_label.AutoSize = True
        Me.motdepasse_label.Location = New System.Drawing.Point(228, 194)
        Me.motdepasse_label.Name = "motdepasse_label"
        Me.motdepasse_label.Size = New System.Drawing.Size(86, 15)
        Me.motdepasse_label.TabIndex = 1
        Me.motdepasse_label.Text = "Mot de passe : "
        '
        'nomutilisateur_TextBox
        '
        Me.nomutilisateur_TextBox.Location = New System.Drawing.Point(360, 120)
        Me.nomutilisateur_TextBox.Name = "nomutilisateur_TextBox"
        Me.nomutilisateur_TextBox.Size = New System.Drawing.Size(200, 23)
        Me.nomutilisateur_TextBox.TabIndex = 2
        '
        'motdepasse_TextBox
        '
        Me.motdepasse_TextBox.Location = New System.Drawing.Point(360, 194)
        Me.motdepasse_TextBox.Name = "motdepasse_TextBox"
        Me.motdepasse_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.motdepasse_TextBox.Size = New System.Drawing.Size(200, 23)
        Me.motdepasse_TextBox.TabIndex = 3
        '
        'inscription_button
        '
        Me.inscription_button.Location = New System.Drawing.Point(360, 280)
        Me.inscription_button.Name = "inscription_button"
        Me.inscription_button.Size = New System.Drawing.Size(75, 23)
        Me.inscription_button.TabIndex = 4
        Me.inscription_button.Text = "Inscription"
        Me.inscription_button.UseVisualStyleBackColor = True
        '
        'connexion_Button
        '
        Me.connexion_Button.Location = New System.Drawing.Point(485, 280)
        Me.connexion_Button.Name = "connexion_Button"
        Me.connexion_Button.Size = New System.Drawing.Size(75, 23)
        Me.connexion_Button.TabIndex = 5
        Me.connexion_Button.Text = "Connexion"
        Me.connexion_Button.UseVisualStyleBackColor = True
        '
        'erreursaisie_label
        '
        Me.erreursaisie_label.AutoSize = True
        Me.erreursaisie_label.ForeColor = System.Drawing.Color.Red
        Me.erreursaisie_label.Location = New System.Drawing.Point(360, 244)
        Me.erreursaisie_label.Name = "erreursaisie_label"
        Me.erreursaisie_label.Size = New System.Drawing.Size(85, 15)
        Me.erreursaisie_label.TabIndex = 6
        Me.erreursaisie_label.Text = "Erreur de saisie"
        Me.erreursaisie_label.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.erreursaisie_label)
        Me.Controls.Add(Me.connexion_Button)
        Me.Controls.Add(Me.inscription_button)
        Me.Controls.Add(Me.motdepasse_TextBox)
        Me.Controls.Add(Me.nomutilisateur_TextBox)
        Me.Controls.Add(Me.motdepasse_label)
        Me.Controls.Add(Me.nomUtilisateur_label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Text = "Gestion parking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nomUtilisateur_label As Label
    Friend WithEvents motdepasse_label As Label
    Friend WithEvents nomutilisateur_TextBox As TextBox
    Friend WithEvents motdepasse_TextBox As TextBox
    Friend WithEvents inscription_button As Button
    Friend WithEvents connexion_Button As Button
    Friend WithEvents erreursaisie_label As Label
End Class
