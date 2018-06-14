Public Class Form1

    Private Sub btnComputeFactorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComputeFactorial.Click
        Dim factorial As Double = 1
        Dim number As Integer

        number = Val(Me.txtNumber.Text) 'get number from user
        For count As Integer = 1 To number
            factorial *= count
        Next count

        Me.lblFactorialMessage.Text = "Factorial is:"
        Me.lblFactorial.Text = factorial

    End Sub
End Class
