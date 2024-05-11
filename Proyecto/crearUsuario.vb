Imports System.Data.SqlClient
Imports Oracle.ManagedDataAccess.Client

Public Class crearUsuario
    Private Sub txtContra_TextChanged(sender As Object, e As EventArgs) Handles txtContra.TextChanged
        txtContra.PasswordChar = "*"c
    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        Dim nombre As String = txtNombre.Text
        Dim correo As String = txtCorreo.Text
        Dim rol As String = txtRol.Text
        Dim usuario As String = txtUsuario.Text
        Dim contra As String = txtContra.Text

        Using conn As New OracleConnection(My.Settings.Conexion)
            Try
                conn.Open()

                ' Consultar si el usuario ya existe en la base de datos
                Dim queryExistencia As String = $"SELECT COUNT(*) FROM usuario WHERE Usuario = '{usuario}'"
                Dim commandExistencia As New OracleCommand(queryExistencia, conn)
                Dim count As Integer = Convert.ToInt32(commandExistencia.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("El usuario ya existe en la base de datos. Por favor, elija otro nombre de usuario.")
                    txtUsuario.Text = ""
                Else
                    ' Insertar el nuevo usuario en la base de datos
                    If MessageBox.Show("¿Está seguro de guardar el registro?", "Mensaje",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                        Dim queryInsertar As String = $"INSERT INTO usuario (Nombre, Correo, Rol, Usuario, Contra) VALUES ('{nombre}', '{correo}', '{rol}', '{usuario}', '{contra}')"
                        Dim commandInsertar As New OracleCommand(queryInsertar, conn)
                        commandInsertar.ExecuteNonQuery()

                        MessageBox.Show("Usuario guardado correctamente.")
                        txtNombre.Text = ""
                        txtCorreo.Text = ""
                        txtRol.Text = ""
                        txtUsuario.Text = ""
                        txtContra.Text = ""
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Error al guardar el usuario: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Me.Close()
    End Sub
End Class
