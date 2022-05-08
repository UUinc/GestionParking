<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Me.Title_label = New System.Windows.Forms.Label()
        Me.gestionVoiture_button = New System.Windows.Forms.Button()
        Me.gestionCamions_button = New System.Windows.Forms.Button()
        Me.GestionUtilisateurs_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Title_label
        '
        Me.Title_label.AutoSize = True
        Me.Title_label.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Title_label.Location = New System.Drawing.Point(152, 45)
        Me.Title_label.Name = "Title_label"
        Me.Title_label.Size = New System.Drawing.Size(500, 32)
        Me.Title_label.TabIndex = 0
        Me.Title_label.Text = "Bienvenue dans l' application gestion parking"
        '
        'gestionVoiture_button
        '
        Me.gestionVoiture_button.Location = New System.Drawing.Point(12, 154)
        Me.gestionVoiture_button.Name = "gestionVoiture_button"
        Me.gestionVoiture_button.Size = New System.Drawing.Size(209, 125)
        Me.gestionVoiture_button.TabIndex = 1
        Me.gestionVoiture_button.Text = "Gestion Voitures"
        Me.gestionVoiture_button.UseVisualStyleBackColor = True
        '
        'gestionCamions_button
        '
        Me.gestionCamions_button.Location = New System.Drawing.Point(297, 154)
        Me.gestionCamions_button.Name = "gestionCamions_button"
        Me.gestionCamions_button.Size = New System.Drawing.Size(209, 125)
        Me.gestionCamions_button.TabIndex = 2
        Me.gestionCamions_button.Text = "Gestion Camions"
        Me.gestionCamions_button.UseVisualStyleBackColor = True
        '
        'GestionUtilisateurs_button
        '
        Me.GestionUtilisateurs_button.Location = New System.Drawing.Point(579, 154)
        Me.GestionUtilisateurs_button.Name = "GestionUtilisateurs_button"
        Me.GestionUtilisateurs_button.Size = New System.Drawing.Size(209, 125)
        Me.GestionUtilisateurs_button.TabIndex = 3
        Me.GestionUtilisateurs_button.Text = "Gestion Utilisateurs"
        Me.GestionUtilisateurs_button.UseVisualStyleBackColor = True
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 690)
        Me.Controls.Add(Me.GestionUtilisateurs_button)
        Me.Controls.Add(Me.gestionCamions_button)
        Me.Controls.Add(Me.gestionVoiture_button)
        Me.Controls.Add(Me.Title_label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Accueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title_label As Label
    Friend WithEvents gestionVoiture_button As Button
    Friend WithEvents gestionCamions_button As Button
    Friend WithEvents GestionUtilisateurs_button As Button
End Class
