<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionCamion
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
        Me.truckicon_img = New System.Windows.Forms.PictureBox()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.matricul_c = New System.Windows.Forms.ColumnHeader()
        Me.chaufeur_c = New System.Windows.Forms.ColumnHeader()
        Me.tonnage_c = New System.Windows.Forms.ColumnHeader()
        Me.marque_c = New System.Windows.Forms.ColumnHeader()
        Me.datedentrer_c = New System.Windows.Forms.ColumnHeader()
        Me.datedesortir_c = New System.Windows.Forms.ColumnHeader()
        Me.modifier_Button = New System.Windows.Forms.Button()
        Me.entrer_Button = New System.Windows.Forms.Button()
        Me.sortir_Button = New System.Windows.Forms.Button()
        Me.supprimer_Button = New System.Windows.Forms.Button()
        Me.datedesortie_DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.datedentrer_DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.datedesortie_Label = New System.Windows.Forms.Label()
        Me.datedentree_Label = New System.Windows.Forms.Label()
        Me.autre_TextBox = New System.Windows.Forms.TextBox()
        Me.autre_RadioButton = New System.Windows.Forms.RadioButton()
        Me.mercedes_RadioButton = New System.Windows.Forms.RadioButton()
        Me.bmw_RadioButton = New System.Windows.Forms.RadioButton()
        Me.marque_Label = New System.Windows.Forms.Label()
        Me.tonnage_TextBox = New System.Windows.Forms.TextBox()
        Me.immatriculation_TextBox = New System.Windows.Forms.TextBox()
        Me.chaufeur_TextBox = New System.Windows.Forms.TextBox()
        Me.title_label = New System.Windows.Forms.Label()
        Me.immatriculation_underline_label = New System.Windows.Forms.Label()
        Me.chauffeur_underline_label = New System.Windows.Forms.Label()
        Me.tonnage_underline_label = New System.Windows.Forms.Label()
        Me.autre_underline_label = New System.Windows.Forms.Label()
        Me.error_label = New System.Windows.Forms.Label()
        CType(Me.truckicon_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'truckicon_img
        '
        Me.truckicon_img.BackColor = System.Drawing.Color.Transparent
        Me.truckicon_img.BackgroundImage = Global.GestionParking.My.Resources.Resources.van_dark
        Me.truckicon_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.truckicon_img.Location = New System.Drawing.Point(427, 28)
        Me.truckicon_img.Name = "truckicon_img"
        Me.truckicon_img.Size = New System.Drawing.Size(80, 80)
        Me.truckicon_img.TabIndex = 48
        Me.truckicon_img.TabStop = False
        '
        'ListView
        '
        Me.ListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.matricul_c, Me.chaufeur_c, Me.tonnage_c, Me.marque_c, Me.datedentrer_c, Me.datedesortir_c})
        Me.ListView.Font = New System.Drawing.Font("Kanit Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListView.ForeColor = System.Drawing.Color.White
        Me.ListView.HideSelection = False
        Me.ListView.Location = New System.Drawing.Point(548, -1)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(718, 682)
        Me.ListView.TabIndex = 47
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'matricul_c
        '
        Me.matricul_c.Text = "Matricul"
        Me.matricul_c.Width = 110
        '
        'chaufeur_c
        '
        Me.chaufeur_c.Text = "Chaufeur"
        Me.chaufeur_c.Width = 110
        '
        'tonnage_c
        '
        Me.tonnage_c.Text = "Tonnage"
        Me.tonnage_c.Width = 120
        '
        'marque_c
        '
        Me.marque_c.Text = "Marque"
        Me.marque_c.Width = 150
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
        Me.modifier_Button.Location = New System.Drawing.Point(204, 625)
        Me.modifier_Button.Name = "modifier_Button"
        Me.modifier_Button.Size = New System.Drawing.Size(130, 40)
        Me.modifier_Button.TabIndex = 46
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
        Me.entrer_Button.Location = New System.Drawing.Point(39, 625)
        Me.entrer_Button.Name = "entrer_Button"
        Me.entrer_Button.Size = New System.Drawing.Size(130, 40)
        Me.entrer_Button.TabIndex = 45
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
        Me.sortir_Button.TabIndex = 44
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
        Me.supprimer_Button.Location = New System.Drawing.Point(368, 625)
        Me.supprimer_Button.Name = "supprimer_Button"
        Me.supprimer_Button.Size = New System.Drawing.Size(130, 40)
        Me.supprimer_Button.TabIndex = 43
        Me.supprimer_Button.Text = "Remove"
        Me.supprimer_Button.UseVisualStyleBackColor = False
        '
        'datedesortie_DatePicker
        '
        Me.datedesortie_DatePicker.Font = New System.Drawing.Font("Roboto Lt", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.datedesortie_DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datedesortie_DatePicker.Location = New System.Drawing.Point(276, 366)
        Me.datedesortie_DatePicker.Name = "datedesortie_DatePicker"
        Me.datedesortie_DatePicker.Size = New System.Drawing.Size(153, 33)
        Me.datedesortie_DatePicker.TabIndex = 42
        '
        'datedentrer_DatePicker
        '
        Me.datedentrer_DatePicker.Font = New System.Drawing.Font("Roboto Lt", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.datedentrer_DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datedentrer_DatePicker.Location = New System.Drawing.Point(276, 315)
        Me.datedentrer_DatePicker.Name = "datedentrer_DatePicker"
        Me.datedentrer_DatePicker.Size = New System.Drawing.Size(153, 33)
        Me.datedentrer_DatePicker.TabIndex = 41
        '
        'datedesortie_Label
        '
        Me.datedesortie_Label.AutoSize = True
        Me.datedesortie_Label.Font = New System.Drawing.Font("Kanit Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.datedesortie_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.datedesortie_Label.Location = New System.Drawing.Point(80, 367)
        Me.datedesortie_Label.Name = "datedesortie_Label"
        Me.datedesortie_Label.Size = New System.Drawing.Size(153, 35)
        Me.datedesortie_Label.TabIndex = 40
        Me.datedesortie_Label.Text = "Date de sortie"
        '
        'datedentree_Label
        '
        Me.datedentree_Label.AutoSize = True
        Me.datedentree_Label.Font = New System.Drawing.Font("Kanit Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.datedentree_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.datedentree_Label.Location = New System.Drawing.Point(80, 314)
        Me.datedentree_Label.Name = "datedentree_Label"
        Me.datedentree_Label.Size = New System.Drawing.Size(147, 35)
        Me.datedentree_Label.TabIndex = 39
        Me.datedentree_Label.Text = "Date d'entree"
        '
        'autre_TextBox
        '
        Me.autre_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.autre_TextBox.Font = New System.Drawing.Font("Kanit ExtraLight", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.autre_TextBox.Location = New System.Drawing.Point(359, 530)
        Me.autre_TextBox.Name = "autre_TextBox"
        Me.autre_TextBox.PlaceholderText = "marque name.."
        Me.autre_TextBox.Size = New System.Drawing.Size(153, 26)
        Me.autre_TextBox.TabIndex = 38
        Me.autre_TextBox.Visible = False
        '
        'autre_RadioButton
        '
        Me.autre_RadioButton.AutoSize = True
        Me.autre_RadioButton.Font = New System.Drawing.Font("Kanit Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.autre_RadioButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.autre_RadioButton.Location = New System.Drawing.Point(276, 528)
        Me.autre_RadioButton.Name = "autre_RadioButton"
        Me.autre_RadioButton.Size = New System.Drawing.Size(78, 34)
        Me.autre_RadioButton.TabIndex = 37
        Me.autre_RadioButton.TabStop = True
        Me.autre_RadioButton.Text = "Autre"
        Me.autre_RadioButton.UseVisualStyleBackColor = True
        '
        'mercedes_RadioButton
        '
        Me.mercedes_RadioButton.AutoSize = True
        Me.mercedes_RadioButton.Font = New System.Drawing.Font("Kanit Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mercedes_RadioButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mercedes_RadioButton.Location = New System.Drawing.Point(276, 491)
        Me.mercedes_RadioButton.Name = "mercedes_RadioButton"
        Me.mercedes_RadioButton.Size = New System.Drawing.Size(162, 34)
        Me.mercedes_RadioButton.TabIndex = 36
        Me.mercedes_RadioButton.TabStop = True
        Me.mercedes_RadioButton.Text = "Mercedes-Benz"
        Me.mercedes_RadioButton.UseVisualStyleBackColor = True
        '
        'bmw_RadioButton
        '
        Me.bmw_RadioButton.AutoSize = True
        Me.bmw_RadioButton.Font = New System.Drawing.Font("Kanit Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bmw_RadioButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bmw_RadioButton.Location = New System.Drawing.Point(276, 455)
        Me.bmw_RadioButton.Name = "bmw_RadioButton"
        Me.bmw_RadioButton.Size = New System.Drawing.Size(73, 34)
        Me.bmw_RadioButton.TabIndex = 35
        Me.bmw_RadioButton.TabStop = True
        Me.bmw_RadioButton.Text = "BMW"
        Me.bmw_RadioButton.UseVisualStyleBackColor = True
        '
        'marque_Label
        '
        Me.marque_Label.AutoSize = True
        Me.marque_Label.Font = New System.Drawing.Font("Kanit Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.marque_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.marque_Label.Location = New System.Drawing.Point(80, 435)
        Me.marque_Label.Name = "marque_Label"
        Me.marque_Label.Size = New System.Drawing.Size(98, 35)
        Me.marque_Label.TabIndex = 34
        Me.marque_Label.Text = "Marque :"
        '
        'tonnage_TextBox
        '
        Me.tonnage_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tonnage_TextBox.Font = New System.Drawing.Font("Kanit Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tonnage_TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.tonnage_TextBox.Location = New System.Drawing.Point(84, 249)
        Me.tonnage_TextBox.Name = "tonnage_TextBox"
        Me.tonnage_TextBox.PlaceholderText = "Tonnage"
        Me.tonnage_TextBox.Size = New System.Drawing.Size(345, 29)
        Me.tonnage_TextBox.TabIndex = 33
        '
        'immatriculation_TextBox
        '
        Me.immatriculation_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.immatriculation_TextBox.Font = New System.Drawing.Font("Kanit Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.immatriculation_TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.immatriculation_TextBox.Location = New System.Drawing.Point(84, 128)
        Me.immatriculation_TextBox.Name = "immatriculation_TextBox"
        Me.immatriculation_TextBox.PlaceholderText = "Immatriculation"
        Me.immatriculation_TextBox.Size = New System.Drawing.Size(345, 29)
        Me.immatriculation_TextBox.TabIndex = 31
        '
        'chaufeur_TextBox
        '
        Me.chaufeur_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chaufeur_TextBox.Font = New System.Drawing.Font("Kanit Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chaufeur_TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.chaufeur_TextBox.Location = New System.Drawing.Point(84, 188)
        Me.chaufeur_TextBox.Name = "chaufeur_TextBox"
        Me.chaufeur_TextBox.PlaceholderText = "Chauffeur"
        Me.chaufeur_TextBox.Size = New System.Drawing.Size(345, 29)
        Me.chaufeur_TextBox.TabIndex = 32
        '
        'title_label
        '
        Me.title_label.AutoSize = True
        Me.title_label.Font = New System.Drawing.Font("Kanit", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.title_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.title_label.Location = New System.Drawing.Point(35, 28)
        Me.title_label.Name = "title_label"
        Me.title_label.Size = New System.Drawing.Size(397, 68)
        Me.title_label.TabIndex = 30
        Me.title_label.Text = "Truck management"
        '
        'immatriculation_underline_label
        '
        Me.immatriculation_underline_label.AutoSize = True
        Me.immatriculation_underline_label.BackColor = System.Drawing.Color.Transparent
        Me.immatriculation_underline_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.immatriculation_underline_label.Location = New System.Drawing.Point(79, 145)
        Me.immatriculation_underline_label.Name = "immatriculation_underline_label"
        Me.immatriculation_underline_label.Size = New System.Drawing.Size(357, 15)
        Me.immatriculation_underline_label.TabIndex = 49
        Me.immatriculation_underline_label.Text = "______________________________________________________________________"
        '
        'chauffeur_underline_label
        '
        Me.chauffeur_underline_label.AutoSize = True
        Me.chauffeur_underline_label.BackColor = System.Drawing.Color.Transparent
        Me.chauffeur_underline_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.chauffeur_underline_label.Location = New System.Drawing.Point(79, 205)
        Me.chauffeur_underline_label.Name = "chauffeur_underline_label"
        Me.chauffeur_underline_label.Size = New System.Drawing.Size(357, 15)
        Me.chauffeur_underline_label.TabIndex = 50
        Me.chauffeur_underline_label.Text = "______________________________________________________________________"
        '
        'tonnage_underline_label
        '
        Me.tonnage_underline_label.AutoSize = True
        Me.tonnage_underline_label.BackColor = System.Drawing.Color.Transparent
        Me.tonnage_underline_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.tonnage_underline_label.Location = New System.Drawing.Point(79, 265)
        Me.tonnage_underline_label.Name = "tonnage_underline_label"
        Me.tonnage_underline_label.Size = New System.Drawing.Size(357, 15)
        Me.tonnage_underline_label.TabIndex = 51
        Me.tonnage_underline_label.Text = "______________________________________________________________________"
        '
        'autre_underline_label
        '
        Me.autre_underline_label.AutoSize = True
        Me.autre_underline_label.BackColor = System.Drawing.Color.Transparent
        Me.autre_underline_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.autre_underline_label.Location = New System.Drawing.Point(355, 546)
        Me.autre_underline_label.Name = "autre_underline_label"
        Me.autre_underline_label.Size = New System.Drawing.Size(162, 15)
        Me.autre_underline_label.TabIndex = 52
        Me.autre_underline_label.Text = "_______________________________"
        Me.autre_underline_label.Visible = False
        '
        'error_label
        '
        Me.error_label.AutoSize = True
        Me.error_label.Font = New System.Drawing.Font("Kanit ExtraLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.error_label.ForeColor = System.Drawing.Color.Red
        Me.error_label.Location = New System.Drawing.Point(110, 578)
        Me.error_label.Name = "error_label"
        Me.error_label.Size = New System.Drawing.Size(326, 25)
        Me.error_label.TabIndex = 86
        Me.error_label.Text = "wrong inputs, double check your information"
        Me.error_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.error_label.Visible = False
        '
        'GestionCamion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.error_label)
        Me.Controls.Add(Me.truckicon_img)
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
        Me.Controls.Add(Me.tonnage_TextBox)
        Me.Controls.Add(Me.immatriculation_TextBox)
        Me.Controls.Add(Me.chaufeur_TextBox)
        Me.Controls.Add(Me.title_label)
        Me.Controls.Add(Me.immatriculation_underline_label)
        Me.Controls.Add(Me.chauffeur_underline_label)
        Me.Controls.Add(Me.tonnage_underline_label)
        Me.Controls.Add(Me.autre_underline_label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "GestionCamion"
        Me.Text = "Truck management"
        CType(Me.truckicon_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents truckicon_img As PictureBox
    Friend WithEvents ListView As ListView
    Friend WithEvents matricul_c As ColumnHeader
    Friend WithEvents chaufeur_c As ColumnHeader
    Friend WithEvents tonnage_c As ColumnHeader
    Friend WithEvents marque_c As ColumnHeader
    Friend WithEvents datedentrer_c As ColumnHeader
    Friend WithEvents datedesortir_c As ColumnHeader
    Friend WithEvents modifier_Button As Button
    Friend WithEvents entrer_Button As Button
    Friend WithEvents sortir_Button As Button
    Friend WithEvents supprimer_Button As Button
    Friend WithEvents datedesortie_DatePicker As DateTimePicker
    Friend WithEvents datedentrer_DatePicker As DateTimePicker
    Friend WithEvents datedesortie_Label As Label
    Friend WithEvents datedentree_Label As Label
    Friend WithEvents autre_TextBox As TextBox
    Friend WithEvents autre_RadioButton As RadioButton
    Friend WithEvents mercedes_RadioButton As RadioButton
    Friend WithEvents bmw_RadioButton As RadioButton
    Friend WithEvents marque_Label As Label
    Friend WithEvents tonnage_TextBox As TextBox
    Friend WithEvents immatriculation_TextBox As TextBox
    Friend WithEvents chaufeur_TextBox As TextBox
    Friend WithEvents title_label As Label
    Friend WithEvents immatriculation_underline_label As Label
    Friend WithEvents chauffeur_underline_label As Label
    Friend WithEvents tonnage_underline_label As Label
    Friend WithEvents autre_underline_label As Label
    Friend WithEvents error_label As Label
End Class
