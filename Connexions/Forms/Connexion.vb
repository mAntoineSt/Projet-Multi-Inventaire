'Importation nécessaire
Imports MySql.Data.MySqlClient

Public Class Connexion
    'Variables nécessaires
    Dim con As MySqlConnection = New MySqlConnection("Server=localhost;Database=projet_multi;Uid=root;Pwd='';Port=3308")
    Dim reader As MySqlDataReader
    Dim commande As New MySqlCommand
    Dim mdp As String


    'Sert à vérifier si le matricule et le mot de passe est correct pour se connecter
    Private Sub bConfirmer_Click(sender As Object, e As EventArgs) Handles bConfirmer.Click


        'Vérifie si tous les champs ont étés remplis
        If String.IsNullOrWhiteSpace(tbMatricule.Text) Or String.IsNullOrWhiteSpace(tbMdp.Text) Then
            MessageBox.Show("Vous devez remplir tous les champs demandés", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If tbMatricule.Text.Length <> 7 Then
            MessageBox.Show("Le matricule n'est pas au bon format (7 chiffres)", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Recherche dans la BD pour voir si le prêteur ou l'administrateur est là.
        mdp = ""
        Try
            'Connexion et commande
            commande.Connection = con
            commande.CommandText = "select motdepasse, statut from individus where id_individu='test';"
            con.Open()
            reader = commande.ExecuteReader
            While (reader.Read)
                mdp = reader(0)
            End While

            'Vérifie si la base de donnée a retourné quelque chose, si ce n'est pas le cas : ERREUR.
            If String.IsNullOrWhiteSpace(mdp) Then
                MessageBox.Show("Le matricule que vous avez entré n'existe pas.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
                Return
            End If

            'Vérifie si le mot de passe trouvé dans la base de donné est le bon.
            If mdp <> tbMdp.Text Then
                MessageBox.Show("Le mot de passe que vous avez entré n'est pas le bon", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
                Return
            End If

            'Appelle la fonction de la page d'accueil
            'Accueil.role(reader(1))

            'Referme la connexion pour que cela ne cause pas de problèmes pour la prochaine demande
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try


        'Si tout est correct
        Accueil.Show()
        Me.Close()
    End Sub
End Class
