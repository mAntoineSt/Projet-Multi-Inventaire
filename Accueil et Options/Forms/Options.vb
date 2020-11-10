Public Class Options

    'PARTIE FORM--------------------------------------------------------------------------------------------------------------------

    'Quand la form de charge
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changementVisuel()
    End Sub

    'PARTIE DES RADIO-BUTTONS-------------------------------------------------------------------------------------------------------

    'Quand le mode clair est sélectionné
    Private Sub RbClair_CheckedChanged(sender As Object, e As EventArgs) Handles RbClair.CheckedChanged
        changementVisuel()
    End Sub

    'Quand le mode sombre est sélectionné
    Private Sub rbSombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbSombre.CheckedChanged
        changementVisuel()
    End Sub

    'PARTIE DES LABELS---------------------------------------------------------------------------------------------------------------

    'Permet de fermer les options
    Private Sub lQuitter_Click(sender As Object, e As EventArgs) Handles lQuitter.Click
        Me.Close()
    End Sub

    'PARTIE DES FONCTIONS------------------------------------------------------------------------------------------------------------

    'Fait changer le visuel selon la radio-button qui a été sélectionné
    Private Sub changementVisuel()
        If RbClair.Checked = True Then
            pHaut.BackColor = ColorTranslator.FromHtml("#4b6584")
            pBas.BackColor = ColorTranslator.FromHtml("#4b6584")
            Me.BackColor = ColorTranslator.FromHtml("#d1d8e0")
            pVisuel.BackColor = ColorTranslator.FromHtml("#4d73a1")
            pLangue.BackColor = ColorTranslator.FromHtml("#4d73a1")
        Else
            pHaut.BackColor = ColorTranslator.FromHtml("#252926")
            pBas.BackColor = ColorTranslator.FromHtml("#252926")
            Me.BackColor = ColorTranslator.FromHtml("#3c403d")
            pVisuel.BackColor = ColorTranslator.FromHtml("#747d8c")
            pLangue.BackColor = ColorTranslator.FromHtml("#747d8c")
        End If
    End Sub
End Class