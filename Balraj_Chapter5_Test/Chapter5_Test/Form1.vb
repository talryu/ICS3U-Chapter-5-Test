Public Class Form1

    Private Sub btnOutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOutput.Click
        Dim startval, endval, square As Integer


        startval = Val(txtStartVal.Text)
        endval = Val(txtEndVal.Text)


        For i As Integer = startval To endval

            square = i * i
            lblSquare.Text = lblSquare.Text & vbCrLf & square
            lblNumber.Text = lblNumber.Text & vbCrLf & i

        Next
    End Sub

    Private Sub lblComb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComb.Click
        Dim strng As String




        Do
            strng = InputBox("Enter a word and period seperately")



            lbltext3.Text = lbltext3.Text & " " & strng
        Loop Until (strng = ".")
    End Sub
End Class
