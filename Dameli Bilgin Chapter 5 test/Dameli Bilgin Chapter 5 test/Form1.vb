Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name As String
        name = InputBox("Enter your name")
        Label1.Text = "How are you today" & " " & name
        If name = Nothing Then
            Label1.Text = "canceled"
        End If
    End Sub
End Class
