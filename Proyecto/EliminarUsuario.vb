Imports System.Data.SqlClient
Imports Oracle.ManagedDataAccess.Client

Public Class EliminarUsuario
    Private Sub txtContra_TextChanged(sender As Object, e As EventArgs) Handles txtContra.TextChanged
        txtContra.PasswordChar = "*"c
    End Sub

    Private Sub buscarUsuario_Click(sender As Object, e As EventArgs) Handles buscarUsuario.Click
        Dim idUsuario As Integer

        ' Verificar si el ID del usuario ingresado es un número válido
        If Integer.TryParse(txtIdUsuario.Text, idUsuario) Then
            Using conn As New OracleConnection(My.Settings.Conexion)
                Try
                    conn.Open()

                    ' Consultar si el usuario existe en la base de datos
                    Dim queryExistencia As String = $"SELECT COUNT(*) FROM usuario WHERE Id_Usuario = {idUsuario}"
                    Dim commandExistencia As New OracleCommand(queryExistencia, conn)
                    Dim count As Integer = Convert.ToInt32(commandExistencia.ExecuteScalar())

                    If count > 0 Then
                        ' El usuario existe, por lo que se carga su información en los TextBox correspondientes
                        Dim queryUsuario As String = $"SELECT Nombre, Correo, Rol, Usuario, Contra FROM usuario WHERE Id_Usuario = {idUsuario}"
                        Dim commandUsuario As New OracleCommand(queryUsuario, conn)
                        Dim reader As OracleDataReader = commandUsuario.ExecuteReader()

                        If reader.Read() Then
                            txtNombre.Text = reader("Nombre").ToString()
                            txtCorreo.Text = reader("Correo").ToString()
                            txtRol.Text = reader("Rol").ToString()
                            txtUsuario.Text = reader("Usuario").ToString()
                            txtContra.Text = reader("Contra").ToString()
                        End If

                        reader.Close()
                    Else
                        ' El usuario no existe en la base de datos
                        MessageBox.Show("El usuario no fue encontrado en la base de datos.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al buscar el usuario: " & ex.Message)
                End Try
            End Using
        Else
            ' El ID del usuario ingresado no es un número válido
            MessageBox.Show("Por favor, ingrese un ID de usuario válido.")
        End If
    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Dim idUsuario As Integer

        ' Verificar si el ID del usuario ingresado es un número válido
        If Integer.TryParse(txtIdUsuario.Text, idUsuario) Then
            Using conn As New OracleConnection(My.Settings.Conexion)
                Try
                    conn.Open()

                    ' Verificar si el usuario ya existe en otro registro
                    Dim queryExistenciaUsuario As String = $"SELECT COUNT(*) FROM usuario WHERE Usuario = '{txtUsuario.Text}' AND Id_Usuario <> {idUsuario}"
                    Dim commandExistenciaUsuario As New OracleCommand(queryExistenciaUsuario, conn)
                    Dim countUsuario As Integer = Convert.ToInt32(commandExistenciaUsuario.ExecuteScalar())

                    If countUsuario > 0 Then
                        ' El usuario ya existe en otro registro
                        MessageBox.Show("El usuario ya existe en otro registro. No se puede eliminar.")
                    Else
                        ' Eliminar el usuario de la base de datos
                        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            Dim queryEliminar As String = $"DELETE FROM usuario WHERE Id_Usuario = {idUsuario}"
                            Dim commandEliminar As New OracleCommand(queryEliminar, conn)
                            commandEliminar.ExecuteNonQuery()

                            MessageBox.Show("Usuario eliminado correctamente.")
                            ' Limpiar los campos después de eliminar
                            txtIdUsuario.Text = ""
                            txtNombre.Text = ""
                            txtCorreo.Text = ""
                            txtRol.Text = ""
                            txtUsuario.Text = ""
                            txtContra.Text = ""
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el usuario: " & ex.Message)
                End Try
            End Using
        Else
            ' El ID del usuario ingresado no es un número válido
            MessageBox.Show("Por favor, ingrese un ID de usuario válido.")
        End If
    End Sub
    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Me.Close()
    End Sub
End Class