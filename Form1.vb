Public Class Form1
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
		'	Dim strNama As String = txtName.Text
		'Dim strOutput As String = "Hello " + strNama

		Dim intScore As Integer = txtName.Text
		Dim strGrade As String

		Select Case intScore
			Case 90 To 100
				strGrade = “A”
			Case 80 To 89
				strGrade = “B”
			Case 70 To 79
				strGrade = “C”
			Case 60 To 69
				strGrade = “D”
			Case 0 To 59
				strGrade = “F”
			Case Else
				MessageBox.Show(“Invalid Score”)
		End Select

		lblOutput.Text = strGrade

	End Sub

	Private Sub LoopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoopToolStripMenuItem.Click
		Form2.ShowDialog()
	End Sub

	Private Sub ArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrayToolStripMenuItem.Click
		Form3.ShowDialog()
	End Sub

	Private Sub ProcedureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcedureToolStripMenuItem.Click
		Form4.ShowDialog()
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim classConvert As ConvertPostcode
		classConvert = New ConvertPostcode()
		MsgBox(classConvert.DoConvert("fareez"))
		classConvert.DoMessageBox()
	End Sub
End Class
