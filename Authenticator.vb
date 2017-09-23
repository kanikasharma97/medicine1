Module Authenticator
    Function authenticatePassword(ByVal IPassword As String, Pwd As String) As Boolean
        If Pwd = IPassword Then
            Return True
        Else
            showFailureMessage()
            Return False
        End If
    End Function


    Function showFailureMessage()
        MsgBox("Username or Password is incorrect")
    End Function

End Module
