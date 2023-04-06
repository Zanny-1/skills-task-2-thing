Public Class Form1
    Dim count As Decimal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim randomize As New Random()

        count -= 40

        For i As Integer = 1 To 15     ' roll two dice 15 times


            Dim die1 As Integer = randomize.Next(1, 7) 'roll first

            Dim die2 As Integer = randomize.Next(1, 7) 'roll second


            Dim total As Integer = die1 + die2

            ListBox1.Items.Add("Roll " & i & ": " & die1 & " + " & die2 & " = " & total)

            If total = 12 Then
                count += 1

            End If
            count = TextBox1.Text
        Next


    End Sub
End Class
