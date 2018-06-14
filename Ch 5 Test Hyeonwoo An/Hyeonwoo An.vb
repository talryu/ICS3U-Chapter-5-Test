Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim smallnumber As Integer
        Dim square As Integer
        Dim largenumber As Integer

        smallnumber = InputBox("Enter the number (small)")
        largenumber = InputBox("Enter the number")
        Me.lblmessage.Text = "The range is: "
        Do Until smallnumber = largenumber
            smallnumber += 1
            Me.lblnumber.Text = smallnumber
            square = smallnumber * smallnumber
            Me.lblfactor.Text = square
        Loop
    End Sub
End Class
