Imports System.ComponentModel

Public Class Administration
    'Création des objets pour les usercontrols
    Dim ucAccueilAdmin As New Accueil_Administration
    Dim ucGestionAdmin As New Gestion_Admins
    Dim ucGestionEmprunteurs As New Gestion_Emprunteurs
    Dim ucGestionPreteur As New Gestion_Preteurs
    Dim ucStatistiques As New Statistiques

    'Variables utiles pour la Form
    Dim droits_administratif As Integer = 2

    Private Sub Administration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pUserControls.Controls.Add(ucAccueilAdmin)
        pUserControls.Controls.Add(ucGestionAdmin)
        pUserControls.Controls.Add(ucGestionEmprunteurs)
        pUserControls.Controls.Add(ucGestionPreteur)
        pUserControls.Controls.Add(ucStatistiques)
        ucAccueilAdmin.BringToFront()

        If droits_administratif = 1 Then
            ucAccueilAdmin.lAccesGestionAdmins.Visible = False
            ucAccueilAdmin.lAccesStatistiques.Visible = False
            ucAccueilAdmin.lPasAccesGestionAdmins.Visible = True
            ucAccueilAdmin.lPasAccesGestionStats.Visible = True
        Else
            ucAccueilAdmin.lPasAccesGestionAdmins.Visible = False
            ucAccueilAdmin.lPasAccesGestionStats.Visible = False
        End If

    End Sub

    'Quand la partie administration se ferme
    Private Sub Administration_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'NE FONCTIONNE PAS ENCORE
        'Accueil.ShowDialog()
        'Me.Close()
    End Sub

    'Fermeture de la partie administration et retour à l'accueil
    Private Sub msRetourAccueil_Click(sender As Object, e As EventArgs) Handles msRetourAccueil.Click
        Me.Close()
    End Sub

    'Sert à ouvrir le userControl de l'accueil de l'administration (Tout le monde peut y avoir accès)
    Private Sub msAccueilAdmin_Click(sender As Object, e As EventArgs) Handles msAccueilAdmin.Click
        ucAccueilAdmin.BringToFront()
    End Sub

    'Sert à ouvrir le userControl de la gestion des administrateurs (Seul les administrateurs y ont accès)
    Private Sub msGestionAdmins_Click(sender As Object, e As EventArgs) Handles msGestionAdmins.Click
        If droits_administratif <> 2 Then
            MessageBox.Show("Vous n'avez pas accès à cette partie administrative.", "AVERTISSEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        ucGestionAdmin.BringToFront()
    End Sub

    'Sert à ouvrir le userControl de la gestion des emprunteurs (Tout le monde peut y avoir accès)

    Private Sub msGestionEmprunteurs_Click(sender As Object, e As EventArgs) Handles msGestionEmprunteurs.Click
        ucGestionEmprunteurs.BringToFront()
    End Sub

    'Sert à ouvrir le userControl de la gestion des prêteurs (Tout le monde peut y avoir accès)
    Private Sub msGestionPreteurs_Click(sender As Object, e As EventArgs) Handles msGestionPreteurs.Click
        ucGestionPreteur.BringToFront()
    End Sub

    'Sert à ouvrir le userControl des statistiques (Seul les administrateurs y ont accès)
    Private Sub msStatistiques_Click(sender As Object, e As EventArgs) Handles msStatistiques.Click
        If droits_administratif <> 2 Then
            MessageBox.Show("Vous n'avez pas accès à cette partie administrative.", "AVERTISSEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        ucStatistiques.BringToFront()
    End Sub
End Class