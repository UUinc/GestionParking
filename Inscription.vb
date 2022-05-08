Public Class Inscription
    Dim itemGroup As ListViewItem

    Private Sub initialiser_button_Click(sender As Object, e As EventArgs) Handles initialiser_button.Click
        nom_TextBox.Text = ""
        email_TextBox.Text = ""
        sexe_ComboBox.SelectedIndex = 0
        datenaissance_datepicker.Value = Date.Now
        motdepasse_TextBox.Text = ""
        confirmationmotdepasse_TextBox.Text = ""
    End Sub

    Private Sub enregistrer_button_Click(sender As Object, e As EventArgs) Handles enregistrer_button.Click
        Dim items() As String

        If Not CheckInputs() Then
            error_label.Visible = True
            Return
        End If

        items = New String() {nom_TextBox.Text, email_TextBox.Text, sexe_ComboBox.Text, datenaissance_datepicker.Text, motdepasse_TextBox.Text, confirmationmotdepasse_TextBox.Text}
        itemGroup = New ListViewItem(items)

        ListView.Items.Add(itemGroup)

    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Login.Location = Location
        Login.Show()
        Hide()
    End Sub

    Function CheckInputs() As Boolean
        Dim valid As Boolean = True

        If String.IsNullOrWhiteSpace(nom_TextBox.Text) Then
            'nom
            valid = False

            nom_underline_label.ForeColor = Color.Red
        End If

        If String.IsNullOrWhiteSpace(email_TextBox.Text) Then
            'email
            valid = False

            email_underline_label.ForeColor = Color.Red
        End If

        If sexe_ComboBox.Text <> "Homme" And sexe_ComboBox.Text <> "Femme" Then
            'sexe
            valid = False

            sexe_underline_label.ForeColor = Color.Red
        End If

        If datenaissance_datepicker.Value > DateAdd(DateInterval.Year, -10, Date.Now) Then
            'date de naissance
            valid = False

            DateOfBirth_label.ForeColor = Color.Red
        End If

        If String.IsNullOrWhiteSpace(motdepasse_TextBox.Text) Or motdepasse_TextBox.Text <> confirmationmotdepasse_TextBox.Text Then
            'mot de passe
            valid = False

            motdepasse_underline_label.ForeColor = Color.Red
            confirmMotDePasse_underline_label.ForeColor = Color.Red
        End If

        Return valid
    End Function

    Sub ResetColor()
        nom_underline_label.ForeColor = Color.FromArgb(73, 80, 87)
        email_underline_label.ForeColor = Color.FromArgb(73, 80, 87)
        sexe_underline_label.ForeColor = Color.FromArgb(73, 80, 87)
        motdepasse_underline_label.ForeColor = Color.FromArgb(73, 80, 87)
        confirmMotDePasse_underline_label.ForeColor = Color.FromArgb(73, 80, 87)
        DateOfBirth_label.ForeColor = Color.FromArgb(73, 80, 87)
    End Sub

    'hide the error message
    Private Sub nom_TextBox_Enter(sender As Object, e As EventArgs) Handles nom_TextBox.Enter
        error_label.Visible = False
        ResetColor()
    End Sub

    Private Sub email_TextBox_Enter(sender As Object, e As EventArgs) Handles email_TextBox.Enter
        error_label.Visible = False
        ResetColor()
    End Sub

    Private Sub motdepasse_TextBox_Enter(sender As Object, e As EventArgs) Handles motdepasse_TextBox.Enter
        error_label.Visible = False
        ResetColor()
    End Sub

    Private Sub confirmationmotdepasse_TextBox_Enter(sender As Object, e As EventArgs) Handles confirmationmotdepasse_TextBox.Enter
        error_label.Visible = False
        ResetColor()
    End Sub

    Private Sub sexe_ComboBox_TextChanged(sender As Object, e As EventArgs) Handles sexe_ComboBox.TextChanged
        error_label.Visible = False
        ResetColor()
    End Sub

    Private Sub datenaissance_datepicker_ValueChanged(sender As Object, e As EventArgs) Handles datenaissance_datepicker.ValueChanged
        error_label.Visible = False
        ResetColor()
    End Sub

    Private Sub Inscription_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        error_label.Visible = False
        ResetColor()

        ListView.Items.Clear()
    End Sub
End Class