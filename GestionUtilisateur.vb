Public Class GestionUtilisateur
    Dim itemGroup As ListViewItem
    Private Sub sortir_Button_Click(sender As Object, e As EventArgs) Handles sortir_Button.Click
        Accueil.Show()
        Accueil.Location = Location
        Hide()
    End Sub

    Private Sub entrer_Button_Click(sender As Object, e As EventArgs) Handles entrer_Button.Click
        Dim items() As String = New String() {nom_TextBox.Text, email_TextBox.Text, sexe_ComboBox.Text, datenaissance_datepicker.Text, motdepasse_TextBox.Text}
        itemGroup = New ListViewItem(items)

        ListView.Items.Add(itemGroup)
    End Sub

    Private Sub supprimer_Button_Click(sender As Object, e As EventArgs) Handles supprimer_Button.Click
        ListView.Items.Remove(ListView.FocusedItem)
    End Sub

    Private Sub modifier_Button_Click(sender As Object, e As EventArgs) Handles modifier_Button.Click
        Dim index = ListView.FocusedItem.Index
        Dim items() As String = New String() {nom_TextBox.Text, email_TextBox.Text, sexe_ComboBox.Text, datenaissance_datepicker.Text, motdepasse_TextBox.Text}
        itemGroup = New ListViewItem(items)
        ListView.Items.Remove(ListView.FocusedItem)
        ListView.Items.Insert(index, itemGroup)
    End Sub
End Class