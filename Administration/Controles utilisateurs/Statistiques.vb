Public Class Statistiques

    'Fait disparaitre les autres groupBox et fait apparaitre celui de la partie globale
    Private Sub bPartieGlobale_Click(sender As Object, e As EventArgs) Handles bPartieGlobale.Click
        visibleFalseEverything()
        gbGlobale.Visible = True
    End Sub

    'Fait disparaitre les autres groupBox et fait apparaitre celui de la partie emprunteurs
    Private Sub bEmprunteurs_Click(sender As Object, e As EventArgs) Handles bEmprunteurs.Click
        visibleFalseEverything()
        gbPartieEmprunteurs.Visible = True
    End Sub

    'Fait disparaitre les autres groupBox et fait apparaitre celui de la partie prêteurs
    Private Sub bPreteurs_Click(sender As Object, e As EventArgs) Handles bPreteurs.Click
        visibleFalseEverything()
        gbPartiePreteurs.Visible = True
    End Sub

    'Fait disparaitre les autres groupBox et fait apparaitre celui de la partie administrateurs
    Private Sub bAdministrateurs_Click(sender As Object, e As EventArgs) Handles bAdministrateurs.Click
        visibleFalseEverything()
        gbPartieAdministrateur.Visible = True
    End Sub

    'Fonction privée servant à faire disparaître toutes les groupBox
    Private Sub visibleFalseEverything()
        gbGlobale.Visible = False
        gbPartieEmprunteurs.Visible = False
        gbPartiePreteurs.Visible = False
        gbPartieAdministrateur.Visible = False
    End Sub

    Private Sub Statistiques_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
