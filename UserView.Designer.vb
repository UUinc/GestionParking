<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserView
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
        Me.sortir_Button = New System.Windows.Forms.Button()
        Me.title_label = New System.Windows.Forms.Label()
        CType(Me.usericon_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'usericon_img
        '
        Me.usericon_img.BackColor = System.Drawing.Color.Transparent
        Me.usericon_img.BackgroundImage = Global.GestionParking.My.Resources.Resources.userView_dark
        Me.usericon_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.usericon_img.InitialImage = Nothing
        Me.usericon_img.Location = New System.Drawing.Point(90, 178)
        Me.usericon_img.Name = "usericon_img"
        Me.usericon_img.Size = New System.Drawing.Size(350, 350)
        Me.usericon_img.TabIndex = 90
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
        Me.ListView.Size = New System.Drawing.Size(720, 682)
        Me.ListView.TabIndex = 89
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
        Me.sortir_Button.TabIndex = 86
        Me.sortir_Button.UseVisualStyleBackColor = False
        '
        'title_label
        '
        Me.title_label.AutoSize = True
        Me.title_label.Font = New System.Drawing.Font("Kanit", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.title_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.title_label.Location = New System.Drawing.Point(157, 18)
        Me.title_label.Name = "title_label"
        Me.title_label.Size = New System.Drawing.Size(213, 68)
        Me.title_label.TabIndex = 84
        Me.title_label.Text = "User view"
        '
        'UserView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.usericon_img)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.sortir_Button)
        Me.Controls.Add(Me.title_label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "UserView"
        Me.Text = "User view"
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
    Friend WithEvents motDePasse_c As ColumnHeader
    Friend WithEvents sortir_Button As Button
    Friend WithEvents title_label As Label
End Class
