Public Class Form1

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        Dim startingvalue, endingvalue, square As Integer

        startingvalue = Val(Me.txtStarting.Text)
        endingvalue = Val(Me.txtEnding.Text)

        For i As Integer = startingvalue To endingvalue
            square = i * i
            lblNumber.Text = lblNumber.Text & vbCrLf & i
            lblSquare.Text = lblSquare.Text & vbCrLf & square
        Next
    End Sub

    Private Sub btnCombine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCombine.Click
        Dim text, oldtext, newtext, textspace As String

        text = InputBox("Type a word", "Word Concatenation")
        Do While text <> "."
            text = InputBox("Type a word", "Word Concatenation")
            oldtext = text
            textspace = oldtext.Insert(oldtext.Length, " ")
            newtext = textspace.Insert(textspace.Length, oldtext)
            lblText.Text = newtext
        Loop

    End Sub
End Class
