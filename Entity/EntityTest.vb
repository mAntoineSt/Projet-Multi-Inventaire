Public Class EntityTest
    Private Sub EntityTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim users = New testEntities().users

        Dim majeur = users.Where(Function(usr) usr.FirstName.Equals("Pierre")).Any(Function(usr) usr.BirthDate.Year.Equals(1997))

    End Sub
End Class