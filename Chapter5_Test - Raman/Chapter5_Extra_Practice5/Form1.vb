Public Class Form1

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim count As Integer = 0
        Dim sum As Integer = 0
        Dim average As Decimal
        For i = 2 To 22
            Label1.Text = Label1.Text & "  " & i
            sum += i
            count = count + 1
            average = sum / count
        Next
        Label2.Text = "Average = " & "  " & average
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOdd.Click
        Dim count As Integer = 0
        Dim num As Integer

        Do While count < 10
            count = count + 1
            num = InputBox("enter the number")
            num = num
            If num Mod 2 <> 0 Then
                Label3.Text = Label3.Text & "  " & num
            End If

        Loop
    End Sub

    Private Sub btnOddAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOddAverage.Click
        Dim count As Integer = 0
        Dim num As Integer
        Dim sum As Integer = 0

        Do While count < 10
            count = count + 1
            num = InputBox("enter the number")


            If count Mod 2 = 1 Then
                sum += num

            End If
        Loop
        lblOddAverage.Text = lblOddAverage.Text & "  " & sum

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim count As Integer = 0
        Dim num As Integer


        Do While count < 10

            num = InputBox("enter the number")


            If num >= 65 Then
                count += 1

            End If
        Loop
        Label4.Text = Label4.Text & "  " & count
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim count As Integer = 0
        Dim num As Integer


        Do While count < 10

            num = InputBox("enter the number")


            If num >= 50 And num <= 65 Then
                count += 1

            End If
        Loop
        Label5.Text = Label5.Text & "  " & count
    End Sub
End Class
