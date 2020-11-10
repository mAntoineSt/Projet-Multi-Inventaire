Public Class Ajout_Modif_Admin
    'Variables nécessaires
    Dim styleVisuel As Integer = 0


    'PARTIE FORM------------------------------------------------------------------------------------------
    Private Sub Ajout_Modif_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If styleVisuel = 0 Then
            pHaut.BackColor = ColorTranslator.FromHtml("#4b6584")
            pBas.BackColor = ColorTranslator.FromHtml("#4b6584")
            Me.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            bConfirmer.ForeColor = Color.White
            bConfirmer.BackColor = ColorTranslator.FromHtml("#4d73a1")
        Else
            pHaut.BackColor = ColorTranslator.FromHtml("#252926")
            pBas.BackColor = ColorTranslator.FromHtml("#252926")
            Me.BackColor = ColorTranslator.FromHtml("#3c403d")
            bConfirmer.ForeColor = Color.White
            bConfirmer.BackColor = ColorTranslator.FromHtml("#747d8c")
        End If
    End Sub

    'PARTIE DES TEXTBOXS----------------------------------------------------------------------------------

    'LES ENTER----------------------------------------
    Private Sub tbMatricule_Enter(sender As Object, e As EventArgs) Handles tbMatricule.Enter
        If tbMatricule.Text = "Matricule" And tbMatricule.ForeColor = Color.LightGray Then
            tbMatricule.ResetText()
            tbMatricule.ForeColor = Color.Black
        End If
    End Sub
    Private Sub tbMdp_Enter(sender As Object, e As EventArgs) Handles tbMdp.Enter
        If tbMdp.Text = "Mot de passe" And tbMdp.ForeColor = Color.LightGray Then
            tbMdp.ResetText()
            tbMdp.ForeColor = Color.Black
            tbMdp.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub tbConfirmationMdp_Enter(sender As Object, e As EventArgs) Handles tbConfirmationMdp.Enter
        If tbConfirmationMdp.Text = "Confirmation du mot de passe" And tbConfirmationMdp.ForeColor = Color.LightGray Then
            tbConfirmationMdp.ResetText()
            tbConfirmationMdp.ForeColor = Color.Black
            tbConfirmationMdp.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub tbNom_Enter(sender As Object, e As EventArgs) Handles tbNom.Enter
        If tbNom.Text = "Nom" And tbNom.ForeColor = Color.LightGray Then
            tbNom.ResetText()
            tbNom.ForeColor = Color.Black
        End If
    End Sub
    Private Sub tbPrenom_Enter(sender As Object, e As EventArgs) Handles tbPrenom.Enter
        If tbPrenom.Text = "Prénom" And tbPrenom.ForeColor = Color.LightGray Then
            tbPrenom.ResetText()
            tbPrenom.ForeColor = Color.Black
        End If
    End Sub
    Private Sub tbDepartementService_Enter(sender As Object, e As EventArgs) Handles tbDepartementService.Enter
        If tbDepartementService.Text = "Département/Service/Programme" And tbDepartementService.ForeColor = Color.LightGray Then
            tbDepartementService.ResetText()
            tbDepartementService.ForeColor = Color.Black
        End If
    End Sub
    Private Sub tbNumeroBureau_Enter(sender As Object, e As EventArgs) Handles tbNumeroBureau.Enter
        If tbNumeroBureau.Text = "Numéro de bureau (optionnel)" And tbNumeroBureau.ForeColor = Color.LightGray Then
            tbNumeroBureau.ResetText()
            tbNumeroBureau.ForeColor = Color.Black
        End If
    End Sub
    Private Sub tbTelephoneBureau_Enter(sender As Object, e As EventArgs) Handles tbTelephoneBureau.Enter
        If tbTelephoneBureau.Text = "Téléphone de bureau (optionnel)" And tbTelephoneBureau.ForeColor = Color.LightGray Then
            tbTelephoneBureau.ResetText()
            tbTelephoneBureau.ForeColor = Color.Black
        End If
    End Sub
    Private Sub tbPosteTelephonique_Enter(sender As Object, e As EventArgs) Handles tbPosteTelephonique.Enter
        If tbPosteTelephonique.Text = "Poste téléphonique (Optionnel)" And tbPosteTelephonique.ForeColor = Color.LightGray Then
            tbPosteTelephonique.ResetText()
            tbPosteTelephonique.ForeColor = Color.Black
        End If
    End Sub
    Private Sub tbCellulaire_Enter(sender As Object, e As EventArgs) Handles tbCellulaire.Enter
        If tbCellulaire.Text = "Cellulaire (Optionnel)" And tbCellulaire.ForeColor = Color.LightGray Then
            tbCellulaire.ResetText()
            tbCellulaire.ForeColor = Color.Black
        End If
    End Sub
    Private Sub tbCourriel_Enter(sender As Object, e As EventArgs) Handles tbCourriel.Enter
        If tbCourriel.Text = "Courriel (Optionnel)" And tbCourriel.ForeColor = Color.LightGray Then
            tbCourriel.ResetText()
            tbCourriel.ForeColor = Color.Black
        End If
    End Sub


    'LES LEAVE----------------------------------------
    Private Sub tbMatricule_Leave(sender As Object, e As EventArgs) Handles tbMatricule.Leave
        If String.IsNullOrWhiteSpace(tbMatricule.Text) Then
            tbMatricule.Text = "Matricule"
            tbMatricule.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub tbMdp_Leave(sender As Object, e As EventArgs) Handles tbMdp.Leave
        If String.IsNullOrWhiteSpace(tbMdp.Text) Then
            tbMdp.Text = "Mot de passe"
            tbMdp.ForeColor = Color.LightGray
            tbMdp.UseSystemPasswordChar = False
        End If
    End Sub
    Private Sub tbConfirmationMdp_Leave(sender As Object, e As EventArgs) Handles tbConfirmationMdp.Leave
        If String.IsNullOrWhiteSpace(tbConfirmationMdp.Text) Then
            tbConfirmationMdp.Text = "Confirmation du mot de passe"
            tbConfirmationMdp.ForeColor = Color.LightGray
            tbConfirmationMdp.UseSystemPasswordChar = False
        End If
    End Sub
    Private Sub tbNom_Leave(sender As Object, e As EventArgs) Handles tbNom.Leave
        If String.IsNullOrWhiteSpace(tbNom.Text) Then
            tbNom.Text = "Nom"
            tbNom.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub tbPrenom_Leave(sender As Object, e As EventArgs) Handles tbPrenom.Leave
        If String.IsNullOrWhiteSpace(tbPrenom.Text) Then
            tbPrenom.Text = "Prénom"
            tbPrenom.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub tbDepartementService_Leave(sender As Object, e As EventArgs) Handles tbDepartementService.Leave
        If String.IsNullOrWhiteSpace(tbDepartementService.Text) Then
            tbDepartementService.Text = "Département/Service/Programme"
            tbDepartementService.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub tbNumeroBureau_Leave(sender As Object, e As EventArgs) Handles tbNumeroBureau.Leave
        If String.IsNullOrWhiteSpace(tbNumeroBureau.Text) Then
            tbNumeroBureau.Text = "Numéro de bureau (optionnel)"
            tbNumeroBureau.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub tbTelephoneBureau_Leave(sender As Object, e As EventArgs) Handles tbTelephoneBureau.Leave
        If String.IsNullOrWhiteSpace(tbTelephoneBureau.Text) Then
            tbTelephoneBureau.Text = "Téléphone de bureau (optionnel)"
            tbTelephoneBureau.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub tbPosteTelephonique_Leave(sender As Object, e As EventArgs) Handles tbPosteTelephonique.Leave
        If String.IsNullOrWhiteSpace(tbPosteTelephonique.Text) Then
            tbPosteTelephonique.Text = "Poste téléphonique (Optionnel)"
            tbPosteTelephonique.ForeColor = Color.LightGray
        End If
    End Sub
    Private Sub tbCellulaire_Leave(sender As Object, e As EventArgs) Handles tbCellulaire.Leave
        If String.IsNullOrWhiteSpace(tbCellulaire.Text) Then
            tbCellulaire.Text = "Cellulaire (Optionnel)"
            tbCellulaire.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub tbCourriel_Leave(sender As Object, e As EventArgs) Handles tbCourriel.Leave
        If String.IsNullOrWhiteSpace(tbCourriel.Text) Then
            tbCourriel.Text = "Courriel (Optionnel)"
            tbCourriel.ForeColor = Color.LightGray
        End If
    End Sub

    'PARTIE DES LABELS-------------------------------------------------------------------------------------------

    'Permet de fermer cette fenêtre
    Private Sub lQuitter_Click(sender As Object, e As EventArgs) Handles lQuitter.Click
        Me.Close()
    End Sub
End Class