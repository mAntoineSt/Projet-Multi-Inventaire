Public Class Connexion

    'Sert à vérifier si le matricule et le mot de passe est correct pour se connecter
    Private Sub bConfirmer_Click(sender As Object, e As EventArgs) Handles bConfirmer.Click


        'Vérifie si tous les champs ont étés remplis
        If String.IsNullOrWhiteSpace(tbMatricule.Text) Or String.IsNullOrWhiteSpace(tbMdp.Text) Then
            MessageBox.Show("Vous devez remplir tous les champs demandés", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Recherche dans la BD pour voir si le prêteur ou l'administrateur est là.
        '...


        'Si tout est correct
        Accueil.Show()
        Me.Close()
    End Sub
End Class
