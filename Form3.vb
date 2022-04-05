Public Class Form3
    Dim suhu() As Single
    Dim day As Short

    'Untuk 1D array
    Dim temperature(0 To 6) As Single

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click


        If txtDays.Text = "" Then
            MsgBox("Please define array size", MsgBoxStyle.Critical, "Alert")
        Else
            Dim prompt, title As String
            prompt = "Enter the day high temperature"
            Day = txtDays.Text

            Dim i As Short
            If Day > 0 Then ReDim suhu(Day - 1)
            For i = 0 To UBound(suhu)
                title = "Day " & (i + 1)
                suhu(i) = InputBox(prompt, title)

            Next

        End If
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If txtDays.Text = "" Then
            MsgBox("Insert value first", MsgBoxStyle.Critical, "Alert")
        Else
            Dim result As String
            Dim i As Short
            Dim total As Single = 0
            result = "High temperature of the week :" & vbCrLf & vbCrLf
            For i = 0 To UBound(suhu)
                result = result & "Day " & (i + 1) & vbTab & suhu(i) & vbCrLf
                total = total + suhu(i)
            Next
            result = result & vbCrLf &
              "Average temperature : " & Format(total / day, "0.0")
            txtDisplay.Text = result

        End If

    End Sub

    Private Sub btnEnter1D_Click(sender As Object, e As EventArgs) Handles btnEnter1D.Click
        Dim prompt, title As String
        Dim i1d As Short
        prompt = "Enter the day high temperature"

        For i1d = 0 To UBound(temperature)
            title = "Day " & (i1d + 1)
            temperature(i1d) = InputBox(prompt, title)

        Next
    End Sub

    Private Sub btnDisplay1D_Click(sender As Object, e As EventArgs) Handles btnDisplay1D.Click


        Dim result1d As String
        Dim i1d As Short
        Dim total As Single = 0
        result1d = "High temperature of the week :" & vbCrLf & vbCrLf
        For i1d = 0 To UBound(temperature)
            result1d = result1d & "Day " & (i1d + 1) & vbTab & temperature(i1d) & vbCrLf
            total = total + temperature(i1d)
        Next
        result1d = result1d & vbCrLf &
              "Average temperature : " & Format(total / 7, "0.0")
        txtDisplay1D.Text = result1d




    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strHari(,) As String = {{"31", "Jan"}, {"28 or 29", "Feb"}, {"31", "Mac"},
            {"30", "April"}, {"31", "May"}, {"30", "June"}, {"31", "July"}, {"31", "August"}, {"30", "Sept"},
            {"31", "Oct"}, {"30", "Nov"}, {"31", "Dec"}}

        Dim intBulan As Integer = ComboBox1.SelectedIndex
        lblOutput.Text = strHari(intBulan, 0) & " day in " & strHari(intBulan, 1)
    End Sub
End Class