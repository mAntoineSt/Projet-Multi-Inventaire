Imports System.ComponentModel

Public Class Administration
    'Création des objets pour les usercontrols
    Dim ucAccueilAdmin As New Accueil_Administration
    Dim ucGestionAdmin As New Gestion_Admins
    Dim ucGestionEmprunteurs As New Gestion_Emprunteurs
    Dim ucGestionPreteur As New Gestion_Preteurs
    Dim ucStatistiques As New Statistiques

    'Variables nécessaires
    Dim styleVisuel As Integer = 1

    'Variables utiles pour la Form
    Dim droits_administratif As Integer = 2

    'LE FORM---------------------------------------------------------------------------------------------
    Private Sub Administration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pUserControls.Controls.Add(ucAccueilAdmin)
        pUserControls.Controls.Add(ucGestionAdmin)
        pUserControls.Controls.Add(ucGestionEmprunteurs)
        pUserControls.Controls.Add(ucGestionPreteur)
        pUserControls.Controls.Add(ucStatistiques)
        ucAccueilAdmin.BringToFront()

        If droits_administratif = 1 Then
            ucAccueilAdmin.lRole.Text = "Prêteur"
            ucAccueilAdmin.lAccesGestionAdmins.Visible = False
            ucAccueilAdmin.lAccesStatistiques.Visible = False
            ucAccueilAdmin.lPasAccesGestionAdmins.Visible = True
            ucAccueilAdmin.lPasAccesGestionStats.Visible = True
        Else
            ucAccueilAdmin.lRole.Text = "Admin"
            ucAccueilAdmin.lPasAccesGestionAdmins.Visible = False
            ucAccueilAdmin.lPasAccesGestionStats.Visible = False
        End If

        If styleVisuel = 0 Then
            pHaut.BackColor = ColorTranslator.FromHtml("#4b6584")
            pBas.BackColor = ColorTranslator.FromHtml("#4b6584")
            Me.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucAccueilAdmin.pRole.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucAccueilAdmin.pAcces.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucAccueilAdmin.pPasAcces.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionAdmin.pTitre.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionEmprunteurs.pTitre.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionPreteur.pTitre.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionAdmin.bAjoutAdmin.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionAdmin.bModifAdmin.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionAdmin.bSuppressionAdmin.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionAdmin.bDroitsAdmins.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionPreteur.bAjoutAdmin.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionPreteur.bModifAdmin.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionPreteur.bSuppressionAdmin.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionPreteur.bDroitsAdmins.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionEmprunteurs.bAjoutAdmin.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionEmprunteurs.bModifAdmin.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionEmprunteurs.bSuppressionAdmin.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucGestionEmprunteurs.bDroitsAdmins.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucStatistiques.bPartieGlobale.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucStatistiques.bEmprunteurs.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucStatistiques.bPreteurs.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucStatistiques.bAdministrateurs.BackColor = ColorTranslator.FromHtml("#4d73a1")
            ucStatistiques.bAdminsDOCS.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bEmprunteursDOCS.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bGlobaleDOCS.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bPreteursDOCS.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bAdminsPDF.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bEmprunteursPDF.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bGlobalePDF.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bPreteursPDF.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bAdminsXLSX.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bEmprunteursXLSX.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bGlobaleXLSX.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.bPreteursXLSX.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            ucStatistiques.pCategories.BackColor = ColorTranslator.FromHtml("#4d73a1")

            ucStatistiques.bPartieGlobale.ForeColor = Color.Black
            ucStatistiques.bEmprunteurs.ForeColor = Color.Black
            ucStatistiques.bPreteurs.ForeColor = Color.Black
            ucStatistiques.bAdministrateurs.ForeColor = Color.Black
            ucStatistiques.bAdminsDOCS.ForeColor = Color.Black
            ucStatistiques.bEmprunteursDOCS.ForeColor = Color.Black
            ucStatistiques.bGlobaleDOCS.ForeColor = Color.Black
            ucStatistiques.bPreteursDOCS.ForeColor = Color.Black
            ucStatistiques.bAdminsPDF.ForeColor = Color.Black
            ucStatistiques.bEmprunteursPDF.ForeColor = Color.Black
            ucStatistiques.bGlobalePDF.ForeColor = Color.Black
            ucStatistiques.bPreteursPDF.ForeColor = Color.Black
            ucStatistiques.bAdminsXLSX.ForeColor = Color.Black
            ucStatistiques.bEmprunteursXLSX.ForeColor = Color.Black
            ucStatistiques.bGlobaleXLSX.ForeColor = Color.Black
            ucStatistiques.bPreteursXLSX.ForeColor = Color.Black
            ucStatistiques.pCategories.ForeColor = Color.Black
        Else
            pHaut.BackColor = ColorTranslator.FromHtml("#252926")
            pBas.BackColor = ColorTranslator.FromHtml("#252926")
            Me.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucAccueilAdmin.pRole.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucAccueilAdmin.pAcces.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucAccueilAdmin.pPasAcces.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionAdmin.pTitre.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionEmprunteurs.pTitre.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionPreteur.pTitre.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionAdmin.bAjoutAdmin.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionAdmin.bModifAdmin.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionAdmin.bSuppressionAdmin.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionAdmin.bDroitsAdmins.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionPreteur.bAjoutAdmin.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionPreteur.bModifAdmin.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionPreteur.bSuppressionAdmin.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionPreteur.bDroitsAdmins.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionEmprunteurs.bAjoutAdmin.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionEmprunteurs.bModifAdmin.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionEmprunteurs.bSuppressionAdmin.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucGestionEmprunteurs.bDroitsAdmins.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucStatistiques.bPartieGlobale.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucStatistiques.bEmprunteurs.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucStatistiques.bPreteurs.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucStatistiques.bAdministrateurs.BackColor = ColorTranslator.FromHtml("#747d8c")
            ucStatistiques.bAdminsDOCS.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bEmprunteursDOCS.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bGlobaleDOCS.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bPreteursDOCS.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bAdminsPDF.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bEmprunteursPDF.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bGlobalePDF.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bPreteursPDF.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bAdminsXLSX.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bEmprunteursXLSX.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bGlobaleXLSX.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.bPreteursXLSX.BackColor = ColorTranslator.FromHtml("#3c403d")
            ucStatistiques.pCategories.BackColor = ColorTranslator.FromHtml("#747d8c")

            ucStatistiques.bPartieGlobale.ForeColor = Color.White
            ucStatistiques.bEmprunteurs.ForeColor = Color.White
            ucStatistiques.bPreteurs.ForeColor = Color.White
            ucStatistiques.bAdministrateurs.ForeColor = Color.White
            ucStatistiques.bAdminsDOCS.ForeColor = Color.White
            ucStatistiques.bEmprunteursDOCS.ForeColor = Color.White
            ucStatistiques.bGlobaleDOCS.ForeColor = Color.White
            ucStatistiques.bPreteursDOCS.ForeColor = Color.White
            ucStatistiques.bAdminsPDF.ForeColor = Color.White
            ucStatistiques.bEmprunteursPDF.ForeColor = Color.White
            ucStatistiques.bGlobalePDF.ForeColor = Color.White
            ucStatistiques.bPreteursPDF.ForeColor = Color.White
            ucStatistiques.bAdminsXLSX.ForeColor = Color.White
            ucStatistiques.bEmprunteursXLSX.ForeColor = Color.White
            ucStatistiques.bGlobaleXLSX.ForeColor = Color.White
            ucStatistiques.bPreteursXLSX.ForeColor = Color.White
            ucStatistiques.pCategories.ForeColor = Color.White
        End If

    End Sub

    'LES LABELS------------------------------------------------------------------------------------------------------

    Private Sub lQuitter_Click(sender As Object, e As EventArgs) Handles lQuitter.Click
        Me.Close()
    End Sub

    Private Sub lAccueilAdministratif_Click(sender As Object, e As EventArgs) Handles lAccueilAdministratif.Click
        ucAccueilAdmin.BringToFront()
    End Sub

    Private Sub lGestionAdmins_Click(sender As Object, e As EventArgs) Handles lGestionAdmins.Click
        If droits_administratif <> 2 Then
            MessageBox.Show("Vous n'avez pas accès à cette partie administrative.", "AVERTISSEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
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