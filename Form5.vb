Public Class Form5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strcharges(4, 3) As String
        strcharges(0, 0) = "1.00"
        strcharges(0, 1) = "1.50"
        strcharges(0, 2) = "1.65"
        strcharges(0, 3) = "1.85"
        strcharges(1, 0) = "1.58"
        strcharges(1, 1) = "2.00"
        strcharges(1, 2) = "2.40"
        strcharges(1, 3) = "3.05"
        strcharges(2, 0) = "1.71"
        strcharges(2, 1) = "2.52"
        strcharges(2, 2) = "3.10"
        strcharges(2, 3) = "4.00"
        strcharges(3, 0) = "2.04"
        strcharges(3, 1) = "3.12"
        strcharges(3, 2) = "4.00"
        strcharges(3, 3) = "5.01"
        strcharges(4, 0) = "2.52"
        strcharges(4, 1) = "3.75"
        strcharges(4, 2) = "5.10"
        strcharges(4, 3) = "7.25"

        TextBox1.Text = strcharges(ListBox1.SelectedIndex, ListBox2.SelectedIndex)

    End Sub
End Class