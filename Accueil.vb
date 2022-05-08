Public Class Accueil
    Private Sub logout_button_Click(sender As Object, e As EventArgs) Handles logout_button.Click
        Login.Show()
        Login.Location = Location
        Hide()
    End Sub
    Private Sub gestionVoiture_button_Click(sender As Object, e As EventArgs) Handles carManagement_button.Click
        GestionVoiture.Show()
        GestionVoiture.Location = Location
        Hide()
    End Sub

    Private Sub truckManagement_button_Click(sender As Object, e As EventArgs) Handles truckManagement_button.Click
        GestionCamion.Show()
        GestionCamion.Location = Location
        Hide()
    End Sub

    Private Sub userManagement_button_Click(sender As Object, e As EventArgs) Handles userManagement_button.Click
        GestionUtilisateur.Show()
        GestionUtilisateur.Location = Location
        Hide()
    End Sub

    Private Sub viewUsers_button_Click(sender As Object, e As EventArgs) Handles viewUsers_button.Click
        viewUsers_button.Show()
        viewUsers_button.Location = Location
        Hide()
    End Sub
End Class