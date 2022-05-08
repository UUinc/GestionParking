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
        Me.carManagement_button = New System.Windows.Forms.Button()
        Me.truckManagement_button = New System.Windows.Forms.Button()
        Me.userManagement_button = New System.Windows.Forms.Button()
        Me.titlebar_panel = New System.Windows.Forms.Panel()
        Me.logout_button = New System.Windows.Forms.Button()
        Me.viewUsers_button = New System.Windows.Forms.Button()
        Me.titlebar_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Title_label
        '
        Me.Title_label.AutoSize = True
        Me.Title_label.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Title_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Title_label.Font = New System.Drawing.Font("Kanit Medium", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Title_label.ForeColor = System.Drawing.Color.White
        Me.Title_label.Location = New System.Drawing.Point(60, 20)
        Me.Title_label.Name = "Title_label"
        Me.Title_label.Size = New System.Drawing.Size(256, 68)
        Me.Title_label.TabIndex = 0
        Me.Title_label.Text = "Home page"
        '
        'carManagement_button
        '
        Me.carManagement_button.BackColor = System.Drawing.Color.Transparent
        Me.carManagement_button.BackgroundImage = Global.GestionParking.My.Resources.Resources.carManagement_btn
        Me.carManagement_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.carManagement_button.FlatAppearance.BorderSize = 0
        Me.carManagement_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.carManagement_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.carManagement_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.carManagement_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.carManagement_button.Location = New System.Drawing.Point(26, 101)
        Me.carManagement_button.Name = "carManagement_button"
        Me.carManagement_button.Size = New System.Drawing.Size(450, 280)
        Me.carManagement_button.TabIndex = 1
        Me.carManagement_button.UseVisualStyleBackColor = False
        '
        'truckManagement_button
        '
        Me.truckManagement_button.BackColor = System.Drawing.Color.Transparent
        Me.truckManagement_button.BackgroundImage = Global.GestionParking.My.Resources.Resources.truckManagement_btn
        Me.truckManagement_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.truckManagement_button.FlatAppearance.BorderSize = 0
        Me.truckManagement_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.truckManagement_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.truckManagement_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.truckManagement_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.truckManagement_button.Location = New System.Drawing.Point(26, 394)
        Me.truckManagement_button.Name = "truckManagement_button"
        Me.truckManagement_button.Size = New System.Drawing.Size(450, 280)
        Me.truckManagement_button.TabIndex = 2
        Me.truckManagement_button.UseVisualStyleBackColor = False
        '
        'userManagement_button
        '
        Me.userManagement_button.BackColor = System.Drawing.Color.Transparent
        Me.userManagement_button.BackgroundImage = Global.GestionParking.My.Resources.Resources.userManagement_btn
        Me.userManagement_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.userManagement_button.FlatAppearance.BorderSize = 0
        Me.userManagement_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.userManagement_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.userManagement_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.userManagement_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userManagement_button.Location = New System.Drawing.Point(491, 100)
        Me.userManagement_button.Name = "userManagement_button"
        Me.userManagement_button.Size = New System.Drawing.Size(370, 575)
        Me.userManagement_button.TabIndex = 3
        Me.userManagement_button.UseVisualStyleBackColor = False
        '
        'titlebar_panel
        '
        Me.titlebar_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.titlebar_panel.Controls.Add(Me.logout_button)
        Me.titlebar_panel.Location = New System.Drawing.Point(0, 0)
        Me.titlebar_panel.Name = "titlebar_panel"
        Me.titlebar_panel.Size = New System.Drawing.Size(1270, 90)
        Me.titlebar_panel.TabIndex = 4
        '
        'logout_button
        '
        Me.logout_button.BackColor = System.Drawing.Color.Transparent
        Me.logout_button.BackgroundImage = Global.GestionParking.My.Resources.Resources.logout
        Me.logout_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logout_button.FlatAppearance.BorderSize = 0
        Me.logout_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.logout_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logout_button.Location = New System.Drawing.Point(1176, 37)
        Me.logout_button.Name = "logout_button"
        Me.logout_button.Size = New System.Drawing.Size(50, 50)
        Me.logout_button.TabIndex = 1
        Me.logout_button.UseVisualStyleBackColor = False
        '
        'viewUsers_button
        '
        Me.viewUsers_button.BackColor = System.Drawing.Color.Transparent
        Me.viewUsers_button.BackgroundImage = Global.GestionParking.My.Resources.Resources.viewUsers_btn
        Me.viewUsers_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.viewUsers_button.FlatAppearance.BorderSize = 0
        Me.viewUsers_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.viewUsers_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.viewUsers_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.viewUsers_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewUsers_button.Location = New System.Drawing.Point(873, 100)
        Me.viewUsers_button.Name = "viewUsers_button"
        Me.viewUsers_button.Size = New System.Drawing.Size(370, 575)
        Me.viewUsers_button.TabIndex = 5
        Me.viewUsers_button.UseVisualStyleBackColor = False
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.viewUsers_button)
        Me.Controls.Add(Me.Title_label)
        Me.Controls.Add(Me.userManagement_button)
        Me.Controls.Add(Me.truckManagement_button)
        Me.Controls.Add(Me.carManagement_button)
        Me.Controls.Add(Me.titlebar_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Accueil"
        Me.Text = "Accueil"
        Me.titlebar_panel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title_label As Label
    Friend WithEvents carManagement_button As Button
    Friend WithEvents truckManagement_button As Button
    Friend WithEvents userManagement_button As Button
    Friend WithEvents titlebar_panel As Panel
    Friend WithEvents logout_button As Button
    Friend WithEvents viewUsers_button As Button
End Class
