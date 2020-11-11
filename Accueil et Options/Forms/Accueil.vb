Public Class Accueil
    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub role(role As String)
        If role = "preteurs" Then
            MessageBox.Show("Prêteurs")
        Else
            MessageBox.Show("Admins")
        End If
    End Sub


End Class