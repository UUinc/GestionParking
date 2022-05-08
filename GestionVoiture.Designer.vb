<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionVoiture
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
        Me.title_label = New System.Windows.Forms.Label()
        Me.chaufeur_Label = New System.Windows.Forms.Label()
        Me.chaufeur_TextBox = New System.Windows.Forms.TextBox()
        Me.immatriculation_TextBox = New System.Windows.Forms.TextBox()
        Me.immatriculation_Label = New System.Windows.Forms.Label()
        Me.nbrplaces_TextBox = New System.Windows.Forms.TextBox()
        Me.nbrplace_label = New System.Windows.Forms.Label()
        Me.marque_Label = New System.Windows.Forms.Label()
        Me.bmw_RadioButton = New System.Windows.Forms.RadioButton()
        Me.mercedes_RadioButton = New System.Windows.Forms.RadioButton()
        Me.autre_RadioButton = New System.Windows.Forms.RadioButton()
        Me.autre_TextBox = New System.Windows.Forms.TextBox()
        Me.datedentree_Label = New System.Windows.Forms.Label()
        Me.datedesortie_Label = New System.Windows.Forms.Label()
        Me.datedentrer_DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.datedesortie_DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.supprimer_Button = New System.Windows.Forms.Button()
        Me.sortir_Button = New System.Windows.Forms.Button()
        Me.entrer_Button = New System.Windows.Forms.Button()
        Me.modifier_Button = New System.Windows.Forms.Button()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.matricul_c = New System.Windows.Forms.ColumnHeader()
        Me.chaufeur_c = New System.Windows.Forms.ColumnHeader()
        Me.marque_c = New System.Windows.Forms.ColumnHeader()
        Me.datedentrer_c = New System.Windows.Forms.ColumnHeader()
        Me.datedesortir_c = New System.Windows.Forms.ColumnHeader()
        Me.SuspendLayout()
        '
        'title_label
        '
        Me.title_label.AutoSize = True
        Me.title_label.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.title_label.Location = New System.Drawing.Point(35, 22)
        Me.title_label.Name = "title_label"
        Me.title_label.Size = New System.Drawing.Size(178, 32)
        Me.title_label.TabIndex = 0
        Me.title_label.Text = "Gestion Voiture"
        '
        'chaufeur_Label
        '
        Me.chaufeur_Label.AutoSize = True
        Me.chaufeur_Label.Location = New System.Drawing.Point(40, 85)
        Me.chaufeur_Label.Name = "chaufeur_Label"
        Me.chaufeur_Label.Size = New System.Drawing.Size(56, 15)
        Me.chaufeur_Label.TabIndex = 1
        Me.chaufeur_Label.Text = "Chaufeur"
        '
        'chaufeur_TextBox
        '
        Me.chaufeur_TextBox.Location = New System.Drawing.Point(144, 82)
        Me.chaufeur_TextBox.Name = "chaufeur_TextBox"
        Me.chaufeur_TextBox.Size = New System.Drawing.Size(115, 23)
        Me.chaufeur_TextBox.TabIndex = 2
        '
        'immatriculation_TextBox
        '
        Me.immatriculation_TextBox.Location = New System.Drawing.Point(144, 120)
        Me.immatriculation_TextBox.Name = "immatriculation_TextBox"
        Me.immatriculation_TextBox.Size = New System.Drawing.Size(115, 23)
        Me.immatriculation_TextBox.TabIndex = 4
        '
        'immatriculation_Label
        '
        Me.immatriculation_Label.AutoSize = True
        Me.immatriculation_Label.Location = New System.Drawing.Point(40, 123)
        Me.immatriculation_Label.Name = "immatriculation_Label"
        Me.immatriculation_Label.Size = New System.Drawing.Size(92, 15)
        Me.immatriculation_Label.TabIndex = 3
        Me.immatriculation_Label.Text = "Immatriculation"
        '
        'nbrplaces_TextBox
        '
        Me.nbrplaces_TextBox.Location = New System.Drawing.Point(144, 158)
        Me.nbrplaces_TextBox.Name = "nbrplaces_TextBox"
        Me.nbrplaces_TextBox.Size = New System.Drawing.Size(115, 23)
        Me.nbrplaces_TextBox.TabIndex = 6
        '
        'nbrplace_label
        '
        Me.nbrplace_label.AutoSize = True
        Me.nbrplace_label.Location = New System.Drawing.Point(40, 161)
        Me.nbrplace_label.Name = "nbrplace_label"
        Me.nbrplace_label.Size = New System.Drawing.Size(103, 15)
        Me.nbrplace_label.TabIndex = 5
        Me.nbrplace_label.Text = "Nombre de places"
        '
        'marque_Label
        '
        Me.marque_Label.AutoSize = True
        Me.marque_Label.Location = New System.Drawing.Point(40, 200)
        Me.marque_Label.Name = "marque_Label"
        Me.marque_Label.Size = New System.Drawing.Size(48, 15)
        Me.marque_Label.TabIndex = 7
        Me.marque_Label.Text = "Marque"
        '
        'bmw_RadioButton
        '
        Me.bmw_RadioButton.AutoSize = True
        Me.bmw_RadioButton.Location = New System.Drawing.Point(144, 200)
        Me.bmw_RadioButton.Name = "bmw_RadioButton"
        Me.bmw_RadioButton.Size = New System.Drawing.Size(54, 19)
        Me.bmw_RadioButton.TabIndex = 8
        Me.bmw_RadioButton.TabStop = True
        Me.bmw_RadioButton.Text = "BMW"
        Me.bmw_RadioButton.UseVisualStyleBackColor = True
        '
        'mercedes_RadioButton
        '
        Me.mercedes_RadioButton.AutoSize = True
        Me.mercedes_RadioButton.Location = New System.Drawing.Point(144, 225)
        Me.mercedes_RadioButton.Name = "mercedes_RadioButton"
        Me.mercedes_RadioButton.Size = New System.Drawing.Size(106, 19)
        Me.mercedes_RadioButton.TabIndex = 9
        Me.mercedes_RadioButton.TabStop = True
        Me.mercedes_RadioButton.Text = "Mercedes-Benz"
        Me.mercedes_RadioButton.UseVisualStyleBackColor = True
        '
        'autre_RadioButton
        '
        Me.autre_RadioButton.AutoSize = True
        Me.autre_RadioButton.Location = New System.Drawing.Point(144, 250)
        Me.autre_RadioButton.Name = "autre_RadioButton"
        Me.autre_RadioButton.Size = New System.Drawing.Size(54, 19)
        Me.autre_RadioButton.TabIndex = 10
        Me.autre_RadioButton.TabStop = True
        Me.autre_RadioButton.Text = "Autre"
        Me.autre_RadioButton.UseVisualStyleBackColor = True
        '
        'autre_TextBox
        '
        Me.autre_TextBox.Location = New System.Drawing.Point(144, 275)
        Me.autre_TextBox.Name = "autre_TextBox"
        Me.autre_TextBox.Size = New System.Drawing.Size(115, 23)
        Me.autre_TextBox.TabIndex = 11
        Me.autre_TextBox.Visible = False
        '
        'datedentree_Label
        '
        Me.datedentree_Label.AutoSize = True
        Me.datedentree_Label.Location = New System.Drawing.Point(40, 320)
        Me.datedentree_Label.Name = "datedentree_Label"
        Me.datedentree_Label.Size = New System.Drawing.Size(77, 15)
        Me.datedentree_Label.TabIndex = 12
        Me.datedentree_Label.Text = "Date d'entree"
        '
        'datedesortie_Label
        '
        Me.datedesortie_Label.AutoSize = True
        Me.datedesortie_Label.Location = New System.Drawing.Point(40, 361)
        Me.datedesortie_Label.Name = "datedesortie_Label"
        Me.datedesortie_Label.Size = New System.Drawing.Size(79, 15)
        Me.datedesortie_Label.TabIndex = 14
        Me.datedesortie_Label.Text = "Date de sortie"
        '
        'datedentrer_DatePicker
        '
        Me.datedentrer_DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datedentrer_DatePicker.Location = New System.Drawing.Point(144, 314)
        Me.datedentrer_DatePicker.Name = "datedentrer_DatePicker"
        Me.datedentrer_DatePicker.Size = New System.Drawing.Size(115, 23)
        Me.datedentrer_DatePicker.TabIndex = 16
        '
        'datedesortie_DatePicker
        '
        Me.datedesortie_DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datedesortie_DatePicker.Location = New System.Drawing.Point(144, 355)
        Me.datedesortie_DatePicker.Name = "datedesortie_DatePicker"
        Me.datedesortie_DatePicker.Size = New System.Drawing.Size(115, 23)
        Me.datedesortie_DatePicker.TabIndex = 17
        '
        'supprimer_Button
        '
        Me.supprimer_Button.Location = New System.Drawing.Point(12, 415)
        Me.supprimer_Button.Name = "supprimer_Button"
        Me.supprimer_Button.Size = New System.Drawing.Size(75, 23)
        Me.supprimer_Button.TabIndex = 18
        Me.supprimer_Button.Text = "Supprimer"
        Me.supprimer_Button.UseVisualStyleBackColor = True
        '
        'sortir_Button
        '
        Me.sortir_Button.Location = New System.Drawing.Point(119, 415)
        Me.sortir_Button.Name = "sortir_Button"
        Me.sortir_Button.Size = New System.Drawing.Size(75, 23)
        Me.sortir_Button.TabIndex = 19
        Me.sortir_Button.Text = "Sortir"
        Me.sortir_Button.UseVisualStyleBackColor = True
        '
        'entrer_Button
        '
        Me.entrer_Button.Location = New System.Drawing.Point(200, 415)
        Me.entrer_Button.Name = "entrer_Button"
        Me.entrer_Button.Size = New System.Drawing.Size(75, 23)
        Me.entrer_Button.TabIndex = 20
        Me.entrer_Button.Text = "Entrer"
        Me.entrer_Button.UseVisualStyleBackColor = True
        '
        'modifier_Button
        '
        Me.modifier_Button.Location = New System.Drawing.Point(305, 415)
        Me.modifier_Button.Name = "modifier_Button"
        Me.modifier_Button.Size = New System.Drawing.Size(75, 23)
        Me.modifier_Button.TabIndex = 21
        Me.modifier_Button.Text = "Modifier"
        Me.modifier_Button.UseVisualStyleBackColor = True
        '
        'ListView
        '
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.matricul_c, Me.chaufeur_c, Me.marque_c, Me.datedentrer_c, Me.datedesortir_c})
        Me.ListView.HideSelection = False
        Me.ListView.Location = New System.Drawing.Point(297, 23)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(497, 376)
        Me.ListView.TabIndex = 22
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'matricul_c
        '
        Me.matricul_c.Text = "Matricul"
        Me.matricul_c.Width = 65
        '
        'chaufeur_c
        '
        Me.chaufeur_c.Text = "Chaufeur"
        Me.chaufeur_c.Width = 90
        '
        'marque_c
        '
        Me.marque_c.Text = "Marque"
        Me.marque_c.Width = 100
        '
        'datedentrer_c
        '
        Me.datedentrer_c.Text = "Date d'entrer"
        Me.datedentrer_c.Width = 120
        '
        'datedesortir_c
        '
        Me.datedesortir_c.Text = "date de sortir"
        Me.datedesortir_c.Width = 120
        '
        'GestionVoiture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.modifier_Button)
        Me.Controls.Add(Me.entrer_Button)
        Me.Controls.Add(Me.sortir_Button)
        Me.Controls.Add(Me.supprimer_Button)
        Me.Controls.Add(Me.datedesortie_DatePicker)
        Me.Controls.Add(Me.datedentrer_DatePicker)
        Me.Controls.Add(Me.datedesortie_Label)
        Me.Controls.Add(Me.datedentree_Label)
        Me.Controls.Add(Me.autre_TextBox)
        Me.Controls.Add(Me.autre_RadioButton)
        Me.Controls.Add(Me.mercedes_RadioButton)
        Me.Controls.Add(Me.bmw_RadioButton)
        Me.Controls.Add(Me.marque_Label)
        Me.Controls.Add(Me.nbrplaces_TextBox)
        Me.Controls.Add(Me.nbrplace_label)
        Me.Controls.Add(Me.immatriculation_TextBox)
        Me.Controls.Add(Me.immatriculation_Label)
        Me.Controls.Add(Me.chaufeur_TextBox)
        Me.Controls.Add(Me.chaufeur_Label)
        Me.Controls.Add(Me.title_label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "GestionVoiture"
        Me.Text = "GestionVoiture"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title_label As Label
    Friend WithEvents chaufeur_Label As Label
    Friend WithEvents chaufeur_TextBox As TextBox
    Friend WithEvents immatriculation_TextBox As TextBox
    Friend WithEvents immatriculation_Label As Label
    Friend WithEvents nbrplaces_TextBox As TextBox
    Friend WithEvents nbrplace_label As Label
    Friend WithEvents marque_Label As Label
    Friend WithEvents bmw_RadioButton As RadioButton
    Friend WithEvents mercedes_RadioButton As RadioButton
    Friend WithEvents autre_RadioButton As RadioButton
    Friend WithEvents autre_TextBox As TextBox
    Friend WithEvents datedentree_Label As Label
    Friend WithEvents datedesortie_Label As Label
    Friend WithEvents datedentrer_DatePicker As DateTimePicker
    Friend WithEvents datedesortie_DatePicker As DateTimePicker
    Friend WithEvents supprimer_Button As Button
    Friend WithEvents sortir_Button As Button
    Friend WithEvents entrer_Button As Button
    Friend WithEvents modifier_Button As Button
    Friend WithEvents ListView As ListView
    Friend WithEvents matricul_c As ColumnHeader
    Friend WithEvents chaufeur_c As ColumnHeader
    Friend WithEvents marque_c As ColumnHeader
    Friend WithEvents datedentrer_c As ColumnHeader
    Friend WithEvents datedesortir_c As ColumnHeader
End Class
