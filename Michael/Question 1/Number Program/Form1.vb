Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please Enter Numbers")
        Else
            Label1.Text = ""
            Label2.Text = ""
            Dim firstNumber As Integer = TextBox1.Text
            Dim secondNumber As Integer = TextBox2.Text
            Dim normalNumber As Integer
            Dim oldFirstNumber As Integer
            Dim oldSecondNumber As Integer
            If firstNumber > secondNumber Then
                oldFirstNumber = firstNumber
                oldSecondNumber = secondNumber
                firstNumber = oldSecondNumber
                secondNumber = oldFirstNumber
            End If
            For i As Integer = firstNumber To secondNumber - 1
                Label1.Text += firstNumber + i & vbCrLf
                normalNumber = firstNumber + i
                Label2.Text += (normalNumber * normalNumber) & vbCrLf
            Next
        End If
    End Sub
End Class
