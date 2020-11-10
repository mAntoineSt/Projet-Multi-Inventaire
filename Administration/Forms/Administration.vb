Imports System.ComponentModel

Public Class Administration
    'Création des objets pour les usercontrols
    Dim ucAccueilAdmin As New Accueil_Administration
    Dim ucGestionAdmin As New Gestion_Admins
    Dim ucGestionEmprunteurs As New Gestion_Emprunteurs
    Dim ucGestionPreteur As New Gestion_Preteurs
    Dim ucStatistiques As New Statistiques

    'Variables nécessaires
    Dim styleVisuel As Integer = 0

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

        If styleVisuel = 0 Then
            pHaut.BackColor = ColorTranslator.FromHtml("#4b6584")
            pBas.BackColor = ColorTranslator.FromHtml("#4b6584")
            Me.BackColor = ColorTranslator.FromHtml("#d1d8e0")
        Else
            pHaut.BackColor = ColorTranslator.FromHtml("#252926")
            pBas.BackColor = ColorTranslator.FromHtml("#252926")
            Me.BackColor = ColorTranslator.FromHtml("#3c403d")
        End If

    End Sub

    Private Sub lQuitter_Click(sender As Object, e As EventArgs) Handles lQuitter.Click
        Me.Close()
    End Sub

    Private Sub lAccueilAdministratif_Click(sender As Object, e As EventArgs) Handles lAccueilAdministratif.Click
        ucAccueilAdmin.BringToFront()
    End Sub

    Private Sub lGestionAdmins_Click(sender As Object, e As EventArgs) Handles lGestionAdmins.Click
        ucGestionAdmin.BringToFront()
    End Sub

    Private Sub lGestionEmpreuteurs_Click(sender As Object, e As EventArgs) Handles lGestionEmprunteurs.Click
        ucGestionEmprunteurs.BringToFront()
    End Sub

    Private Sub lGestionPreteurs_Click(sender As Object, e As EventArgs) Handles lGestionPreteurs.Click
        ucGestionPreteur.BringToFront()
    End Sub

    Private Sub lStatistiques_Click(sender As Object, e As EventArgs) Handles lStatistiques.Click
        If droits_administratif <> 2 Then
            MessageBox.Show("Vous n'avez pas accès à cette partie administrative.", "AVERTISSEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        ucStatistiques.BringToFront()
    End Sub
End Class