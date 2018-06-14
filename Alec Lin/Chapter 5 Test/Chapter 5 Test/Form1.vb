Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Start As Integer = TextBox1.Text
        Dim EndNum As Integer = TextBox2.Text
        Dim Count As Integer = 0
        Dim CurNum As Integer = Start
        If EndNum < Start Then
            MsgBox("Invalid Input. Enter smaller number first.")
            TextBox1.Clear()
            TextBox2.Clear()
        Else
            For i = Start To EndNum
                If Count Mod 3 <> 0 Or Count = 0 Then
                    Label3.Text += CurNum & " "
                    Label4.Text += CurNum ^ 2 & " "
                    Count += 1
                    CurNum += 1
                Else
                    Label3.Text += vbCrLf & CurNum & " "
                    Label4.Text += vbCrLf & CurNum ^ 2 & " "
                    Count += 1
                    CurNum += 1
                End If
            Next
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Label3.Text = ""
        Label4.Text = ""
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Label3.Text = ""
        Label4.Text = ""
    End Sub
End Class
