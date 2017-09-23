Public Class AddUser
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userdata As New List(Of Object)
        Dim ds As New DataSet
        Dim validatequery As String = "Select * from UserIdentity where ContactNo= '" + TxtMaskedContactNo.Text + "'"
        ds = read(validatequery)

        If (ds.Tables(0).Rows.Count = 1) Then
            MsgBox("User with this Contact Number is already present.")
        Else

            'validation

            Dim ContactNoErrorMessage = validateContacField(TxtMaskedContactNo.Text)
            Dim FirstNameErrorMessage = validateMandatoryField(txtfname.Text, "FirstName")
            Dim addressErrorMessage = validateMandatoryField(txtaddress.Text, "Address")
            Dim PasswordErrorMessage = validateMandatoryField(txtpassword.Text, "Password")
            Dim emailErrorMessage = validateEmailField(txtemail.Text)
            Dim TypeErrorMessage = validateSelectionField(CmbType.SelectedItem, "Type")

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

            If TypeErrorMessage.length <> 0 Then
                MsgBox(TypeErrorMessage)
                Return
            End If




            userdata.Add(TxtMaskedContactNo.Text)
                userdata.Add(txtpassword.Text)
                userdata.Add(txtfname.Text)
                userdata.Add(txtlname.Text)
                userdata.Add(txtemail.Text)
                userdata.Add(txtaddress.Text)
                userdata.Add(CmbType.SelectedItem)
                userdata.Add(1)
                userdata.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                If (write("UserIdentity", userdata)) = 1 Then
                    MsgBox("User Added")
                    AddUser.ActiveForm.Close()
                Else
                    MsgBox("Something went wrong")
                End If
            End If
    End Sub

    Private Sub BtnCancelUser_Click(sender As Object, e As EventArgs) Handles BtnCancelUser.Click
        AddUser.ActiveForm.Close()
    End Sub
End Class
