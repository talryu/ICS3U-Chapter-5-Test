Public Class Form1

    Private Sub btnRange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRange.Click
        Dim start As Integer = Val(txtstart.Text)
        Dim endnum As Integer = Val(txtend.Text)
        Dim square As Integer
        For i As Integer = start To endnum
            square = i * i
            lblRange.Text = lblRange.Text & "  " & square
        Next

    End Sub

    Private Sub btnconcaternate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconcaternate.Click
        Dim word1 As String = InputBox("enter a word")
        Dim word2 As String = InputBox("enter a word")
        Dim wordNew As String
        wordNew = word1 & "  " & vbTab & word2 & " "
        lblconcaternate.Text = wordNew
    End Sub
End Class
