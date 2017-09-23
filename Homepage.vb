Public Class Homepage
    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox2.Width += 5
        If PictureBox2.Width >= 428 Then
            Login.Show()
            Me.Close()
        End If

    End Sub
End Class