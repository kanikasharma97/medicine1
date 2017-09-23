Public Class UpdateUser
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail.TextChanged

    End Sub

    Private Sub BtnUpdateUser_Click(sender As Object, e As EventArgs) Handles BtnUpdateUser.Click

        'validator

        Dim ContactNoErrorMessage = validateContacField(TxtMaskedContactNo.Text)
        Dim FirstNameErrorMessage = validateMandatoryField(TxtFirstName.Text, "FirstName")
        Dim addressErrorMessage = validateMandatoryField(TxtAddress.Text, "Address")
        Dim PasswordErrorMessage = validateMandatoryField(TxtPassword.Text, "Password")
        Dim emailErrorMessage = validateEmailField(TxtEmail.Text)

        If ContactNoErrorMessage.length <> 0 Then
            MsgBox(ContactNoErrorMessage)
            Return
        End If

        If FirstNameErrorMessage.Length <> 0 Then
            MsgBox(FirstNameErrorMessage)
            Return
        End If
        If addressErrorMessage.length <> 0 Then
            MsgBox(addressErrorMessage)
            Return
        End If
        If PasswordErrorMessage.length <> 0 Then
            MsgBox(addressErrorMessage)
            Return
        End If
        If emailErrorMessage.length <> 0 Then
            MsgBox(emailErrorMessage)
            Return
        End If


        Dim updateQuery As String = "update UserIdentity set ContactNo='" + TxtMaskedContactNo.Text + "', Password='" + TxtPassword.Text + "',FirstName='" + TxtFirstName.Text + "',LastName='" + TxtLastName.Text + "',Email='" + TxtEmail.Text + "', Address='" + TxtAddress.Text + "' where ContactNo='" + lblContactNo.Text + "'"
        executeUpdateQuery(updateQuery)
        MsgBox("User updated successfully")
        UpdateMedicine.ActiveForm.Close()
    End Sub

    Private Sub BtnCancelUpdateUser_Click(sender As Object, e As EventArgs) Handles BtnCancelUpdateUser.Click
        UpdateUser.ActiveForm.Close()
    End Sub
End Class
