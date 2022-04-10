Public Class Form4

    Sub tellOperator(ByVal task As String)
        Dim stamp As Date
        stamp = TimeOfDay()
        MsgBox("Starting " & task & " at " & CStr(stamp))
    End Sub

    Function Hypotenuse(side1 As Double, side2 As Double) As Double
        Return Math.Sqrt((side1 ^ 2) + (side2 ^ 2))
    End Function



    Function checkGender(ByVal nric As String)

        Dim st As String = nric
        Dim jantina As String

        Dim subst As String = st.Substring(11, 1)

        If subst Mod 2 = 0 Then
            jantina = "Perempuan"
        Else
            jantina = "Lelaki"
        End If

        Return jantina

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tellOperator("file update")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = checkGender(TextBox1.Text)
    End Sub
End Class