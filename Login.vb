Imports System.Data.OleDb
Public Class Login

    Private Sub connexion_Button_Click(sender As Object, e As EventArgs) Handles connexion_Button.Click
        Login()
    End Sub
    Sub Login()
        Dim isValid As Boolean = False

        For Each item As ListViewItem In GestionUtilisateur.ListView.Items

            If email_TextBox.Text = item.SubItems.Item(1).Text And motdepasse_TextBox.Text = item.SubItems.Item(4).Text Then
                isValid = True
                Exit For
            End If
        Next

        If isValid Or (email_TextBox.Text = "admin" And motdepasse_TextBox.Text = "admin") Then
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
    Private Sub nomutilisateur_TextBox_Enter(sender As Object, e As EventArgs) Handles email_TextBox.Enter
        erreursaisie_label.Visible = False
    End Sub
    Private Sub motdepasse_TextBox_Enter(sender As Object, e As EventArgs) Handles motdepasse_TextBox.Enter
        erreursaisie_label.Visible = False
    End Sub
    Private Sub Login_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        erreursaisie_label.Visible = False

        'wipe text boxes
        email_TextBox.Text = ""
        motdepasse_TextBox.Text = ""
    End Sub
End Class
