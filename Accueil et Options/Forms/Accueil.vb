Public Class Accueil
    Private Sub FaireUnEmpruntToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FaireUnEmpruntToolStripMenuItem.Click
        'Dim emprunt As New PretAjout()
        'emprunt.Show()
    End Sub

    Private Sub buttonFaireEmprunt_Click(sender As Object, e As EventArgs) Handles buttonFaireEmprunt.Click
        'Dim emprunt As New PretAjout()
        'emprunt.Show()
    End Sub

    Private Sub HistoriqueDesEmpruntsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoriqueDesEmpruntsToolStripMenuItem.Click
        Dim hist As New Prets()
        hist.Show()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        End
    End Sub

    Private Sub FaireUnRetourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FaireUnRetourToolStripMenuItem.Click
        Dim retour As New RetourAjout()
        retour.Show()
    End Sub

    Private Sub buttonFaireRetour_Click(sender As Object, e As EventArgs) Handles buttonFaireRetour.Click
        Dim retour As New RetourAjout()
        retour.Show()
    End Sub

    Private Sub HistoriqueDesRetoursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoriqueDesRetoursToolStripMenuItem.Click
        Dim hist As New Retours()
        hist.Show()
    End Sub

    Private Sub buttonHistEmprunt_Click(sender As Object, e As EventArgs) Handles buttonHistEmprunt.Click
        Dim hist As New Prets()
        hist.Show()
    End Sub

    Private Sub buttonHistRetours_Click(sender As Object, e As EventArgs) Handles buttonHistRetours.Click
        Dim hist As New Retours()
        hist.ShowDialog()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        Options.ShowDialog()
    End Sub

    Private Sub DossiersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DossiersToolStripMenuItem.Click
        Administration.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Connexion.Show()
        Me.Close()
    End Sub
End Class