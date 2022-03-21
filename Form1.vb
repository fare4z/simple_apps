Public Class Form1
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        Dim strNama As String = txtName.Text
        Dim strOutput As String = "Hello " + strNama

        lblOutput.Text = strOutput

    End Sub
End Class
