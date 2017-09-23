Imports System.Data.SqlClient


Public Class Login



    Function authenticatePassword(ByVal IPassword As String, Pwd As String) As Boolean
        If Pwd = IPassword Then
            Return True
        Else
            Return False
        End If
    End Function

    Function showFailureMessage()
        MsgBox("Username or Password is incorrect")
    End Function

    Private Sub UserContactNo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Pwdtxt_TextChanged(sender As Object, e As EventArgs) Handles Pwdtxt.TextChanged

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim ds As New DataSet
        Dim IContanctNo As String = TxtMaskedContactNo.Text
        Dim IPassword As String = Pwdtxt.Text
        ds = read("select Password , Type from UserIdentity where ContactNo = '" + IContanctNo + "'")


        If (ds.Tables(0).Rows.Count = 0) Then
            showFailureMessage()
        Else
            Dim Password As String = ds.Tables(0).Rows(0).Item(0)
            Dim UserType As String = ds.Tables(0).Rows(0).Item(1)
            If (authenticatePassword(IPassword, Password)) Then
                If (UserType = "normal") Then
                    AuthorizeNonAdmin()
                End If

                ADMIN.Show()
            Else
                showFailureMessage()
            End If
        End If


    End Sub
    Private Sub AuthorizeNonAdmin()
        ADMIN.TabControl1.TabPages.Remove(ADMIN.TabPage3)
        ADMIN.BtnAddCategory.Visible = False
        ADMIN.BtnAddMedicine.Visible = False
        ADMIN.BtnUpdateMedicine.Visible = False
        ADMIN.BtnDeleteMedicine.Visible = False
        ADMIN.BtnAddOffer.Visible = False
        ADMIN.BtnUpdateOffers.Visible = False
        ADMIN.BtnDeleteOffers.Visible = False

    End Sub

    Private Sub BtnCancel_Click_1(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Login.ActiveForm.Close()
    End Sub
End Class