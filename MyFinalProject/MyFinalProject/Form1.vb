Public Class Form1
    Dim strNumbers(4) As String 'Initial array
    Dim intNumbers(4) As Integer 'Array converted from the original array

    Private Sub btnNumbers_Click(sender As Object, e As EventArgs) Handles btnNumbers.Click
        Me.BackColor = Color.Lavender
        lstNumbers.BackColor = Color.LightCyan
        pctReaction.BackColor = Color.GhostWhite
        'Clears out the label and listbox
        lstNumbers.Items.Clear()
        lblInfo.Text = " "
        'Calls two subs
        getInput()
        funFun()
    End Sub

    Private Sub getInput()
        For i As Integer = 0 To strNumbers.Length - 1
            strNumbers(i) = InputBox("Please enter a number", "Number " & i + 1)  'Input for the 5 numbers

            Do While Int32.TryParse(strNumbers(i), intNumbers(i)) = False 'Makes sure you enter correct user input
                MessageBox.Show("*Numeric values please!")
                strNumbers(i) = InputBox("Please enter a number", "Number " & i + 1)
            Loop

            lstNumbers.Items.Add("Number " & i + 1 & ": " & strNumbers(i)) 'Displays the numbers entered in a listbox
        Next i

        lblInfo.Text = "You have successfully entered the 5 numbers."

    End Sub

    Private Sub funFun()
        Dim strFilePath As String = "C:/users/samay/source/repos/MyFinalProject" 'The file destination for the images
        Array.Sort(intNumbers) 'Purpose is to get the highest number

        If intNumbers(4) >= 100 Then
            pctReaction.ImageLocation = strFilePath & "/thums.png"
        ElseIf intNumbers(4) >= 50 AndAlso intNumbers(4) < 100 Then
            pctReaction.ImageLocation = strFilePath & "/meh.jpg"
        Else
            pctReaction.ImageLocation = strFilePath & "/MyFinalProject/thomas.png"
        End If
    End Sub

    Private Sub btnMean_Click(sender As Object, e As EventArgs) Handles btnMean.Click

        lblInfo.Text = "The mean is " & (intNumbers(0) + intNumbers(1) + intNumbers(2) + intNumbers(3) + intNumbers(4)) / 5 'Displays the average
    End Sub

    Private Sub btnMedian_Click(sender As Object, e As EventArgs) Handles btnMedian.Click
        Array.Sort(intNumbers)

        lblInfo.Text = "The median is " & intNumbers(2) 'Displays the value of the middle number
    End Sub
End Class
