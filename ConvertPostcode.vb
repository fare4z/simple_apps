Public Class ConvertPostcode
    Public Function DoConvert(ByVal postcode As String) As String
        Dim ConvertPostcode As String
        ConvertPostcode = StrConv(postcode, VbStrConv.Uppercase)
        DoConvert = ConvertPostcode
    End Function

    Public Sub DoMessageBox()
        MsgBox("Accept", MsgBoxStyle.Information, "Successfully")
    End Sub
End Class
