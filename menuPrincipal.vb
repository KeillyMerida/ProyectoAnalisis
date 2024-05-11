Public Class menuPrincipal
    Private Sub logout_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub CrearUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearUsuarioToolStripMenuItem.Click

    End Sub

    Private Sub CrearUsuarioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CrearUsuarioToolStripMenuItem1.Click
        crearUsuario.Show()
    End Sub

    Private Sub ModificarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarUsuarioToolStripMenuItem.Click
        modificarUsuario.Show()
    End Sub

    Private Sub EliminarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarUsuarioToolStripMenuItem.Click
        EliminarUsuario.Show()
    End Sub
End Class