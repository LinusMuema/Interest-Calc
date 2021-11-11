Public Class Form1
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click

        ' clear the list box if there were values before
        ListBox.Items.Clear()

        Dim Amount, Principal As Decimal
        Dim Rate As Double
        Dim Year As Integer

        Principal = 1000000
        Rate = 0.05

        For Year = 1 To 10
            Amount = Principal * (1 + Rate) ^ Year
            Dim Formatted As String = String.Format("{0:C2}", Amount)
            ListBox.Items.Add("Year " + Year.ToString + " amount is " + Formatted)
        Next
    End Sub
End Class
