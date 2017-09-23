Imports System.Net.Mail
Module Validator

    Function validateContacField(no As String)
        If no.Length < 10 Then
            Return "Please provide a 10 digit contact no"
        End If

        Return ""
    End Function

    Function validateMandatoryField(fieldValue As String, name As String)
        If Trim(fieldValue).Length = 0 Then
            Return "Please enter value for " + name
        End If
        Return ""
    End Function



    Function validateEmailField(fieldValue As String)
        Try
            Dim mail As MailAddress = New MailAddress(fieldValue)
        Catch ex As Exception
            Return "Please enter a valid email address"
        End Try

        Return ""
    End Function


    Function validateNumericField(value As Int32, name As String)
        If value <= 0 Then
            Return "Please penter value greater than 0 for " + name
        End If
        Return ""
    End Function

    Function validateSelectionField(fieldValue As Object, name As String)
        If IsNothing(fieldValue) Then
            Return "Please select a value for " + name
        End If
        Return ""
    End Function
End Module
