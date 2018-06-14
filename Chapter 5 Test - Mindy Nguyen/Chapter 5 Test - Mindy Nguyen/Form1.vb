Public Class Form1

    Private Sub btnFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFact.Click
        Dim factorial As Double = 1
        Dim number As Integer

        number = Val(Me.txtNum.Text)
        For count As Integer = 1 To number
            factorial *= count

        Next count
        Me.lblOutput.Text = factorial
    End Sub
End Class
