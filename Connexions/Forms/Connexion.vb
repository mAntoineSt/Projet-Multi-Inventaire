﻿'Importation nécessaire
Imports MySql.Data.MySqlClient

Public Class Connexion
    'Variables nécessaires
    Dim con As MySqlConnection = New MySqlConnection("Server=localhost;Database=projet_multi;Uid=root;Pwd='';Port=3308;")
    Dim reader As MySqlDataReader
    Dim commande As New MySqlCommand
    Dim mdp As String
    Dim styleVisuel As Integer = 0

    'PARTIE FORM--------------------------------------------------------------------------------------------------------------------

    'Lors de l'ouverture de l'application
    Private Sub Connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Recherche dans les documents de l'ordi pour voir quel style visuel il avait avant sa fermeture
        '...

        If styleVisuel = 0 Then
            'Si le visuel choisie avant est le clair
            pHaut.BackColor = ColorTranslator.FromHtml("#4b6584")
            pBas.BackColor = ColorTranslator.FromHtml("#4b6584")
            Me.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            bConfirmer.ForeColor = Color.White
            bConfirmer.BackColor = ColorTranslator.FromHtml("#4d73a1")
            lMdpOublie.ForeColor = Color.Black
        Else
            'Si le visuel choisie avant est le sombre
            pHaut.BackColor = ColorTranslator.FromHtml("#252926")
            pBas.BackColor = ColorTranslator.FromHtml("#252926")
            Me.BackColor = ColorTranslator.FromHtml("#3c403d")
            bConfirmer.ForeColor = Color.White
            bConfirmer.BackColor = ColorTranslator.FromHtml("#747d8c")
            lMdpOublie.ForeColor = Color.White
        End If

        'Les objets à changer manuellement et qui seront toujours pareil même si le mode visuel change
        tbMatricule.AutoSize = False
        tbMatricule.Height = 30
        tbMdp.AutoSize = False
        tbMdp.Height = 30
        LCreationCompte.BackColor = ColorTranslator.FromHtml("#69db63")
    End Sub

    'PARTIE BOUTONS------------------------------------------------------------------------------------------------------------

    'Sert à vérifier si le matricule et le mot de passe est correct pour se connecter
    Private Sub bConfirmer_Click(sender As Object, e As EventArgs) Handles bConfirmer.Click

        'Vérifie si tous les champs ont étés remplis
        If (tbMatricule.Text = "Utilisateur" And tbMatricule.ForeColor = Color.LightGray) Or (tbMdp.Text = "Mot de passe" And tbMdp.ForeColor = Color.LightGray) Then
            MessageBox.Show("Vous devez remplir tous les champs demandés", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Vérifie si la taille des champs est de 7 caractères
        If tbMatricule.Text.Length < 7 Then
            MessageBox.Show("Le matricule n'est pas au bon format (7 chiffres)", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Recherche dans la BD pour voir si le prêteur ou l'administrateur est là.
        mdp = ""
        Try

            'Connexion et commande
            commande.Connection = con
            commande.CommandText = "Select motdepasse, statut from individus where id_individu='1843395';"
            con.Open()
            reader = commande.ExecuteReader
            MessageBox.Show("passe icit")
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
            Accueil.role(reader(1))

            'Referme la connexion pour que cela ne cause pas de problèmes pour la prochaine demande de connexion à la bd
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
            Return
        End Try


        'Si tout est correct
        Accueil.Show()
        Me.Close()
    End Sub


    'PARTIE DES TEXTBOXS DU FORM-------------------------------------------------------------------------------------------------

    'Quand on appuie sur le textbox de matricule
    Private Sub tbMatricule_Enter(sender As Object, e As EventArgs) Handles tbMatricule.Enter
        If tbMatricule.Text = "Utilisateur" And tbMatricule.ForeColor = Color.LightGray Then
            tbMatricule.ResetText()
            tbMatricule.ForeColor = Color.Black
        End If
    End Sub

    'Quand on déselectionne le textbox de mot de passe
    Private Sub tbMatricule_Leave(sender As Object, e As EventArgs) Handles tbMatricule.Leave
        If String.IsNullOrWhiteSpace(tbMatricule.Text) Then
            tbMatricule.Text = "Utilisateur"
            tbMatricule.ForeColor = Color.LightGray
        End If
    End Sub

    'Quand on appuie sur le textbox de mot de passe
    Private Sub tbMdp_Enter(sender As Object, e As EventArgs) Handles tbMdp.Enter
        If tbMdp.Text = "Mot de passe" And tbMdp.ForeColor = Color.LightGray Then
            tbMdp.ResetText()
            tbMdp.ForeColor = Color.Black
        End If
    End Sub

    'Quand on déselectionne le textbox de mot de passe
    Private Sub tbMdp_Leave(sender As Object, e As EventArgs) Handles tbMdp.Leave
        If String.IsNullOrWhiteSpace(tbMdp.Text) Then
            tbMdp.Text = "Mot de passe"
            tbMdp.ForeColor = Color.LightGray
        End If
    End Sub

    'PARTIE DES LABELS DU FORM---------------------------------------------------------------------------------------------------

    'Quand on appuie sur le X en haut à droite du form
    Private Sub LQuitter_Click(sender As Object, e As EventArgs) Handles LQuitter.Click
        End
    End Sub

    'Quand on appuie sur "Mot de passe oublié?" au centre
    Private Sub lMdpOublie_Click(sender As Object, e As EventArgs) Handles lMdpOublie.Click
        messageCommunicationAdmin()
    End Sub

    'Quand on appuie sur le label de création de comptes en bas à droite
    Private Sub LCreationCompte_Click(sender As Object, e As EventArgs) Handles LCreationCompte.Click
        messageCommunicationAdmin()
    End Sub

    Private Sub messageCommunicationAdmin()
        MessageBox.Show("Veuillez communiquer avec un prêteur ou un administrateur autorisé pour effectuer cette action.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
