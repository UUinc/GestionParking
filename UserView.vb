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

        For Each item As ListViewItem In GestionUtilisateur.ListView.Items
            ListView.Items.Add(item.Clone())
        Next
    End Sub
End Class