Public Class UserView
    Dim itemGroup As ListViewItem
    Private Sub sortir_Button_Click(sender As Object, e As EventArgs) Handles sortir_Button.Click
        Accueil.Show()
        Accueil.Location = Location
        Hide()
    End Sub

    Private Sub UserView_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        'wipe data in list view
        ListView.Items.Clear()

        'change the commented text with data from the database
        'Dim items() As String = New String() {nom_TextBox.Text, email_TextBox.Text, sexe_ComboBox.Text, datenaissance_datepicker.Text, motdepasse_TextBox.Text}
        Dim items() As String = New String() {"test1", "test2", "test3", "test4", "test5"}

        itemGroup = New ListViewItem(items)

        ListView.Items.Add(itemGroup)
    End Sub
End Class