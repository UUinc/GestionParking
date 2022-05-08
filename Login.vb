Public Class Login
    Private Sub connexion_Button_Click(sender As Object, e As EventArgs) Handles connexion_Button.Click
        If nomutilisateur_TextBox.Text = "admin" And motdepasse_TextBox.Text = "admin" Then
            Accueil.Show()
            Accueil.Location = Location
            Hide()
        Else
            erreursaisie_label.Visible = True
        End If
    End Sub

    Private Sub inscription_button_Click(sender As Object, e As EventArgs) Handles inscription_button.Click
        Inscription.Show()
        Inscription.Location = Location
        Hide()
    End Sub

    'hide the error message
    Private Sub nomutilisateur_TextBox_Enter(sender As Object, e As EventArgs) Handles nomutilisateur_TextBox.Enter
        erreursaisie_label.Visible = False
    End Sub
    Private Sub motdepasse_TextBox_Enter(sender As Object, e As EventArgs) Handles motdepasse_TextBox.Enter
        erreursaisie_label.Visible = False
    End Sub
    Private Sub Login_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        erreursaisie_label.Visible = False

        'wipe text boxes
        nomutilisateur_TextBox.Text = ""
        motdepasse_TextBox.Text = ""
    End Sub
End Class
