Public Class ConvertPostcode
    Public Function DoConvert(ByVal postcode As String) As String
        Dim ConvertPostcode As String
        ConvertPostcode = StrConv(postcode, VbStrConv.Uppercase)
        DoConvert = ConvertPostcode
    End Function

    Public Sub DoMessageBox()
        MsgBox("Accept", MsgBoxStyle.Information, "Successfully")
    End Sub


    Public Function checkGender(ByVal nric As String)

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
End Class
