Public Class Accueil
    Private Sub gestionVoiture_button_Click(sender As Object, e As EventArgs) Handles gestionVoiture_button.Click
        GestionVoiture.Show()
        GestionVoiture.Location = Location
        Hide()
    End Sub
End Class