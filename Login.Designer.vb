<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.email_TextBox = New System.Windows.Forms.TextBox()
        Me.motdepasse_TextBox = New System.Windows.Forms.TextBox()
        Me.inscription_button = New System.Windows.Forms.Button()
        Me.connexion_Button = New System.Windows.Forms.Button()
        Me.erreursaisie_label = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.email_underline_label = New System.Windows.Forms.Label()
        Me.password_underline_label = New System.Windows.Forms.Label()
        Me.signin_l = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'email_TextBox
        '
        Me.email_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.email_TextBox.Font = New System.Drawing.Font("Kanit Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.email_TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.email_TextBox.Location = New System.Drawing.Point(725, 192)
        Me.email_TextBox.Name = "email_TextBox"
        Me.email_TextBox.PlaceholderText = "Enter your email"
        Me.email_TextBox.Size = New System.Drawing.Size(347, 26)
        Me.email_TextBox.TabIndex = 2
        '
        'motdepasse_TextBox
        '
        Me.motdepasse_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.motdepasse_TextBox.Font = New System.Drawing.Font("Kanit Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.motdepasse_TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.motdepasse_TextBox.Location = New System.Drawing.Point(725, 263)
        Me.motdepasse_TextBox.Name = "motdepasse_TextBox"
        Me.motdepasse_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.motdepasse_TextBox.PlaceholderText = "Enter your password"
        Me.motdepasse_TextBox.Size = New System.Drawing.Size(347, 26)
        Me.motdepasse_TextBox.TabIndex = 3
        '
        'inscription_button
        '
        Me.inscription_button.BackColor = System.Drawing.Color.Transparent
        Me.inscription_button.FlatAppearance.BorderSize = 0
        Me.inscription_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.inscription_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.inscription_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inscription_button.Font = New System.Drawing.Font("Kanit", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.inscription_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.inscription_button.Location = New System.Drawing.Point(948, 414)
        Me.inscription_button.Name = "inscription_button"
        Me.inscription_button.Size = New System.Drawing.Size(77, 33)
        Me.inscription_button.TabIndex = 1
        Me.inscription_button.Text = "Sign up"
        Me.inscription_button.UseVisualStyleBackColor = False
        '
        'connexion_Button
        '
        Me.connexion_Button.FlatAppearance.BorderSize = 0
        Me.connexion_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.connexion_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.connexion_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.connexion_Button.Font = New System.Drawing.Font("Kanit", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.connexion_Button.ForeColor = System.Drawing.Color.White
        Me.connexion_Button.Image = Global.GestionParking.My.Resources.Resources.btnBG
        Me.connexion_Button.Location = New System.Drawing.Point(809, 348)
        Me.connexion_Button.Name = "connexion_Button"
        Me.connexion_Button.Size = New System.Drawing.Size(182, 52)
        Me.connexion_Button.TabIndex = 4
        Me.connexion_Button.Text = "Sign In"
        Me.connexion_Button.UseVisualStyleBackColor = True
        '
        'erreursaisie_label
        '
        Me.erreursaisie_label.AutoSize = True
        Me.erreursaisie_label.Font = New System.Drawing.Font("Kanit ExtraLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.erreursaisie_label.ForeColor = System.Drawing.Color.Red
        Me.erreursaisie_label.Location = New System.Drawing.Point(686, 479)
        Me.erreursaisie_label.Name = "erreursaisie_label"
        Me.erreursaisie_label.Size = New System.Drawing.Size(435, 25)
        Me.erreursaisie_label.TabIndex = 6
        Me.erreursaisie_label.Text = "Unable to login. Please check your credentials and try again."
        Me.erreursaisie_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.erreursaisie_label.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.GestionParking.My.Resources.Resources.parking_with_icon
        Me.PictureBox1.Location = New System.Drawing.Point(0, -30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(514, 720)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(693, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(414, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Log into Lazrek Parking"
        '
        'email_underline_label
        '
        Me.email_underline_label.AutoSize = True
        Me.email_underline_label.BackColor = System.Drawing.Color.Transparent
        Me.email_underline_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.email_underline_label.Location = New System.Drawing.Point(721, 209)
        Me.email_underline_label.Name = "email_underline_label"
        Me.email_underline_label.Size = New System.Drawing.Size(357, 15)
        Me.email_underline_label.TabIndex = 9
        Me.email_underline_label.Text = "______________________________________________________________________"
        '
        'password_underline_label
        '
        Me.password_underline_label.AutoSize = True
        Me.password_underline_label.BackColor = System.Drawing.Color.Transparent
        Me.password_underline_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.password_underline_label.Location = New System.Drawing.Point(721, 280)
        Me.password_underline_label.Name = "password_underline_label"
        Me.password_underline_label.Size = New System.Drawing.Size(357, 15)
        Me.password_underline_label.TabIndex = 10
        Me.password_underline_label.Text = "______________________________________________________________________"
        '
        'signin_l
        '
        Me.signin_l.AutoSize = True
        Me.signin_l.Font = New System.Drawing.Font("Kanit Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.signin_l.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.signin_l.Location = New System.Drawing.Point(779, 419)
        Me.signin_l.Name = "signin_l"
        Me.signin_l.Size = New System.Drawing.Size(176, 25)
        Me.signin_l.TabIndex = 11
        Me.signin_l.Text = "Don't have an account?"
        Me.signin_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.signin_l)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.erreursaisie_label)
        Me.Controls.Add(Me.connexion_Button)
        Me.Controls.Add(Me.inscription_button)
        Me.Controls.Add(Me.motdepasse_TextBox)
        Me.Controls.Add(Me.email_TextBox)
        Me.Controls.Add(Me.email_underline_label)
        Me.Controls.Add(Me.password_underline_label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Text = "Gestion parking"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents email_TextBox As TextBox
    Friend WithEvents motdepasse_TextBox As TextBox
    Friend WithEvents inscription_button As Button
    Friend WithEvents connexion_Button As Button
    Friend WithEvents erreursaisie_label As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents email_underline_label As Label
    Friend WithEvents password_underline_label As Label
    Friend WithEvents signin_l As Label
End Class
