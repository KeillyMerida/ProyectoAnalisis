Public Class menuPrincipal
    Private Sub logout_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class