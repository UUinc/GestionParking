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
End Class
