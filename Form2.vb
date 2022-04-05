Public Class Form2
	Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
		Dim intCount As Integer = 0

		lstOutput.Items.Add("Do While Loop")

		Do While intCount < 10
			lstOutput.Items.Add("Hello".ToString + " " + intCount.ToString)
			intCount += 1
		Loop

	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Dim a As Integer = 0

		lstOutput.Items.Add("Do Loop While")

		Do
			'MsgBox("Value of a : " & a)
			lstOutput.Items.Add("Hello ".ToString + " " & a)
			a = a + 1
		Loop While (a < 10)


	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		lstOutput.Items.Clear()
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		Dim a As Integer = 0

		lstOutput.Items.Add("Do Loop Until")

		Do
			'MsgBox("Value of a : " & a)
			lstOutput.Items.Add("Hello ".ToString + " " & a)
			a = a + 1
		Loop Until (a = 10)

	End Sub
End Class