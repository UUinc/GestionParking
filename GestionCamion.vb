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
        Dim items() As String = New String() {immatriculation_TextBox.Text, chaufeur_TextBox.Text, tonnage_TextBox.Text, GetMarque(), datedentrer_DatePicker.Text, datedesortie_DatePicker.Text}
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
        Dim index = ListView.FocusedItem.Index
        Dim items() As String = New String() {immatriculation_TextBox.Text, chaufeur_TextBox.Text, tonnage_TextBox.Text, GetMarque(), datedentrer_DatePicker.Text, datedesortie_DatePicker.Text}
        itemGroup = New ListViewItem(items)
        ListView.Items.Remove(ListView.FocusedItem)
        ListView.Items.Insert(index, itemGroup)
    End Sub
End Class