Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim newWord As String
        Dim wordLength As Integer
        Do
            newWord = InputBox("Enter New Word, Enter period at end of word to stop.", "Enter Words")
            wordLength = newWord.Length
            Label1.Text += newWord & Space(1)
        Loop Until newWord.Chars(wordLength - 1) = "."
    End Sub
End Class
