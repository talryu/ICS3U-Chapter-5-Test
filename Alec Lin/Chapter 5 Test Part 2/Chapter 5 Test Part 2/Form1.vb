Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Word As String
        Word = InputBox("Enter a word to be combined. Enter a period to stop,", "Word Combiner")
        If Word.IndexOf(".") = "-1" Then
            Label1.Text = Word
            Do Until Word.IndexOf(".") <> "-1"
                Word = InputBox("Enter a word to be combined. Enter a period to stop,", "Word Combiner")
                Label1.Text += Word & " "
            Loop
        Else
            Label1.Text = Word
        End If
    End Sub
End Class
