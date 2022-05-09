Public Class GestionCamion
    Dim itemGroup As ListViewItem
    Private Sub bmw_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles bmw_RadioButton.CheckedChanged
        autre_TextBox.Visible = False
        autre_underline_label.Visible = False
    End Sub

    Private Sub mercedes_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles mercedes_RadioButton.CheckedChanged
        autre_TextBox.Visible = False
        autre_underline_label.Visible = False
    End Sub

    Private Sub autre_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles autre_RadioButton.CheckedChanged
        autre_TextBox.Visible = True
        autre_underline_label.Visible = True
    End Sub

    Private Sub sortir_Button_Click(sender As Object, e As EventArgs) Handles sortir_Button.Click
        Accueil.Show()
        Accueil.Location = Location
        Hide()
    End Sub

    Private Sub entrer_Button_Click(sender As Object, e As EventArgs) Handles entrer_Button.Click
        Dim items() As String

        If Not CheckInputs() Then
            error_label.Visible = True
            Return
        End If

        items = New String() {immatriculation_TextBox.Text, chaufeur_TextBox.Text, tonnage_TextBox.Text, GetMarque(), datedentrer_DatePicker.Text, datedesortie_DatePicker.Text}
        itemGroup = New ListViewItem(items)

        ListView.Items.Add(itemGroup)
    End Sub

    Function GetMarque() As String
        If bmw_RadioButton.Checked Then
            Return bmw_RadioButton.Text
        ElseIf mercedes_RadioButton.Checked Then
            Return mercedes_RadioButton.Text
        Else
            Return autre_TextBox.Text
        End If
    End Function

    Private Sub supprimer_Button_Click(sender As Object, e As EventArgs) Handles supprimer_Button.Click

        ListView.Items.Remove(ListView.FocusedItem)
    End Sub

    Private Sub modifier_Button_Click(sender As Object, e As EventArgs) Handles modifier_Button.Click
        Dim index As Integer

        If ListView.FocusedItem Is Nothing Then
            Return
        End If

        index = ListView.FocusedItem.Index

        Dim items() As String

        If Not CheckInputs() Then
            error_label.Visible = True
            Return
        End If

        items = New String() {immatriculation_TextBox.Text, chaufeur_TextBox.Text, tonnage_TextBox.Text, GetMarque(), datedentrer_DatePicker.Text, datedesortie_DatePicker.Text}
        itemGroup = New ListViewItem(items)
        ListView.Items.Remove(ListView.FocusedItem)
        ListView.Items.Insert(index, itemGroup)
    End Sub

    Function CheckInputs() As Boolean
        Dim valid As Boolean = True

        If String.IsNullOrWhiteSpace(immatriculation_TextBox.Text) Then
            'nom
            valid = False

            immatriculation_underline_label.ForeColor = Color.Red
        End If

        If String.IsNullOrWhiteSpace(chaufeur_TextBox.Text) Then
            'email
            valid = False

            chauffeur_underline_label.ForeColor = Color.Red
        End If

        If Not IsNumeric(tonnage_TextBox.Text) Then
            'sexe
            valid = False

            tonnage_underline_label.ForeColor = Color.Red
        End If

        If datedentrer_DatePicker.Value < Date.Now Or datedentrer_DatePicker.Value > datedesortie_DatePicker.Value Then
            'date de naissance
            valid = False

            datedentree_Label.ForeColor = Color.Red
            datedesortie_Label.ForeColor = Color.Red

        End If

        If bmw_RadioButton.Checked = False And mercedes_RadioButton.Checked = False And autre_RadioButton.Checked = False Then

            'mot de passe
            valid = False

            marque_Label.ForeColor = Color.Red
        End If

        If autre_RadioButton.Checked And String.IsNullOrWhiteSpace(autre_TextBox.Text) Then
            'mot de passe
            valid = False

            autre_underline_label.ForeColor = Color.Red
            marque_Label.ForeColor = Color.Red
        End If

        Return valid
    End Function

    Sub ResetColor()
        immatriculation_underline_label.ForeColor = Color.FromArgb(73, 80, 87)
        chauffeur_underline_label.ForeColor = Color.FromArgb(73, 80, 87)
        tonnage_underline_label.ForeColor = Color.FromArgb(73, 80, 87)
        datedentree_Label.ForeColor = Color.FromArgb(73, 80, 87)
        datedesortie_Label.ForeColor = Color.FromArgb(73, 80, 87)
        marque_Label.ForeColor = Color.FromArgb(73, 80, 87)
        autre_underline_label.ForeColor = Color.FromArgb(73, 80, 87)
    End Sub

    'hide the error message
    Private Sub immatriculation_TextBox_Enter(sender As Object, e As EventArgs) Handles immatriculation_TextBox.Enter
        error_label.Visible = False
        ResetColor()
    End Sub

    Private Sub chaufeur_TextBox_Enter(sender As Object, e As EventArgs) Handles chaufeur_TextBox.Enter
        error_label.Visible = False
        ResetColor()
    End Sub

    Private Sub tonnage_TextBox_Enter(sender As Object, e As EventArgs) Handles tonnage_TextBox.Enter
        error_label.Visible = False
        ResetColor()
    End Sub

    Private Sub datedentrer_DatePicker_ValueChanged(sender As Object, e As EventArgs) Handles datedentrer_DatePicker.ValueChanged
        error_label.Visible = False
        ResetColor()
    End Sub

    Private Sub datedesortie_DatePicker_ValueChanged(sender As Object, e As EventArgs) Handles datedesortie_DatePicker.ValueChanged
        error_label.Visible = False
        ResetColor()
    End Sub

    Private Sub bmw_RadioButton_Enter(sender As Object, e As EventArgs) Handles bmw_RadioButton.Enter
        error_label.Visible = False
        ResetColor()
    End Sub

    Private Sub mercedes_RadioButton_Enter(sender As Object, e As EventArgs) Handles mercedes_RadioButton.Enter
        error_label.Visible = False
        ResetColor()
    End Sub

    Private Sub autre_RadioButton_Enter(sender As Object, e As EventArgs) Handles autre_RadioButton.Enter
        error_label.Visible = False
        ResetColor()
    End Sub
    Private Sub autre_TextBox_Enter(sender As Object, e As EventArgs) Handles autre_TextBox.Enter
        error_label.Visible = False
        ResetColor()
    End Sub

    Private Sub GestionCamion_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        error_label.Visible = False
        ResetColor()
    End Sub
End Class