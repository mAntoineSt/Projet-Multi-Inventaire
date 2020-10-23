Public Class GestionMateriel

    Dim ctrlEnrMat As New EnregistrementMateriel()
    Dim ctrlFicheMat As New FicheMateriel()
    Dim ctrlListeMat As New ListeMateriel()
    Dim ctrlStatMat As New StatistiquesMateriel()
    Dim ctrlAccueil As New PanneauAccueil()


    Private Sub GestionMateriel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.pnlControleMat.Controls.Add(ctrlEnrMat)
        Me.pnlControleMat.Controls.Add(ctrlFicheMat)
        Me.pnlControleMat.Controls.Add(ctrlListeMat)
        Me.pnlControleMat.Controls.Add(ctrlStatMat)
        Me.pnlControleMat.Controls.Add(ctrlAccueil)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnStat_Click(sender As Object, e As EventArgs) Handles btnStat.Click
        If Me.Enabled Then
            ctrlEnrMat.Hide()
            ctrlFicheMat.Hide()
            ctrlListeMat.Hide()
            ctrlStatMat.Show()
            ctrlAccueil.Hide()
        End If
    End Sub

    Private Sub BtnListe_Materiel_Click(sender As Object, e As EventArgs) Handles btnListe_Materiel.Click
        If Me.Enabled Then
            ctrlEnrMat.Hide()
            ctrlFicheMat.Hide()
            ctrlListeMat.Show()
            ctrlStatMat.Hide()
            ctrlAccueil.Hide()
        End If
    End Sub

    Private Sub BtnFiche_Materiel_Click(sender As Object, e As EventArgs) Handles btnFiche_Materiel.Click
        If Me.Enabled Then
            ctrlEnrMat.Hide()
            ctrlFicheMat.Show()
            ctrlListeMat.Hide()
            ctrlStatMat.Hide()
            ctrlAccueil.Hide()
        End If
    End Sub



    Private Sub BtnAccueil_Materiel_Click(sender As Object, e As EventArgs) Handles btnAccueil_Materiel.Click
        If Me.Enabled Then
            ctrlEnrMat.Hide()
            ctrlFicheMat.Hide()
            ctrlListeMat.Hide()
            ctrlStatMat.Hide()
            ctrlAccueil.Show()
        End If
    End Sub

    Private Sub BtnEnrModif_Materiel_Click(sender As Object, e As EventArgs) Handles btnEnrModif_Materiel.Click
        If Me.Enabled Then
            ctrlEnrMat.Show()
            ctrlFicheMat.Hide()
            ctrlListeMat.Hide()
            ctrlStatMat.Hide()
            ctrlAccueil.Hide()
        End If
    End Sub
End Class