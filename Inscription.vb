Public Class Inscription
    Dim itemGroup As ListViewItem
    Private Sub Inscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView.Items.Clear()
    End Sub
    Private Sub initialiser_button_Click(sender As Object, e As EventArgs) Handles initialiser_button.Click
        nom_TextBox.Text = ""
        email_TextBox.Text = ""
        sexe_ComboBox.SelectedIndex = 0
        datenaissance_datepicker.Value = Date.Now
        motdepasse_TextBox.Text = ""
        confirmationmotdepasse_TextBox.Text = ""
    End Sub

    Private Sub enregistrer_button_Click(sender As Object, e As EventArgs) Handles enregistrer_button.Click
        Dim items() As String = New String() {nom_TextBox.Text, email_TextBox.Text, sexe_ComboBox.Text, datenaissance_datepicker.Text, motdepasse_TextBox.Text, confirmationmotdepasse_TextBox.Text}
        itemGroup = New ListViewItem(items)

        ListView.Items.Add(itemGroup)
    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Login.Location = Location
        Login.Show()
        Hide()
    End Sub
End Class