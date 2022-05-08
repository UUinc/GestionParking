Public Class Accueil
    Private Sub gestionVoiture_button_Click(sender As Object, e As EventArgs) Handles carManagement_button.Click
        GestionVoiture.Show()
        GestionVoiture.Location = Location
        Hide()
    End Sub

    Private Sub logout_button_Click(sender As Object, e As EventArgs) Handles logout_button.Click
        Login.Show()
        Login.Location = Location
        Hide()
    End Sub
End Class