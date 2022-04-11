Public Class Form4
    Dim classConvertPostcode As ConvertPostcode = New ConvertPostcode
    Sub tellOperator(ByVal task As String)
        Dim stamp As Date
        stamp = TimeOfDay()
        MsgBox("Starting " & task & " at " & CStr(stamp))
    End Sub

    Function Hypotenuse(side1 As Double, side2 As Double) As Double
        Return Math.Sqrt((side1 ^ 2) + (side2 ^ 2))
    End Function





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tellOperator("file update")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objClassConvert As String = classConvertPostcode.checkGender(TextBox1.Text)

        Label2.Text = objClassConvert
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' variable initialized to 10
        Dim ref As Integer = 10
        PlusOnebyVal(ref)
        ListBox1.Items.Add("The number is now: " & ref)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ref As Integer = 10
        PlusOnebyRef(ref)
        ListBox2.Items.Add("The number is now: " & ref)
    End Sub

    Sub PlusOnebyVal(ByVal x As Integer)
        x += 1
        ListBox1.Items.Add("The number in the sub is: " & x)
    End Sub

    Sub PlusOnebyRef(ByRef x As Integer)
        x += 1
        ListBox2.Items.Add("The number in the sub is: " & x)
    End Sub

End Class