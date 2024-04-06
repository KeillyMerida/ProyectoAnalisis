Imports Microsoft.VisualBasic.ApplicationServices
Imports Oracle.ManagedDataAccess.Client

Public Class Form1


    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Dim usuario As String = usertxt.Text
        Dim pass As String = passwordtxt.Text
        ' Cadena de conexión a la base de datos Oracle
        Using conn As New OracleConnection(My.Settings.Conexion)
            Try
                ' Abrir la conexión
                conn.Open()

                ' Consulta SQL para verificar las credenciales del usuario
                Dim query As String = "select * from login where usuario='" & usuario & "' and pass='" & pass & "'"

                ' Crear y ejecutar el comando SQL
                Dim command As New OracleCommand(query, conn)

                ' Ejecutar la consulta y obtener el resultado
                Dim reader As OracleDataReader = command.ExecuteReader()

                ' Verificar si se encontró algún registro
                If reader.Read() Then
                    ' Si se encontró un registro, significa que las credenciales son correctas
                    MessageBox.Show("Inicio de sesión exitoso.")
                    Me.Hide()
                    menuPrincipal.Show()
                    ' Aquí puedes redirigir al usuario a la página principal de tu aplicación
                Else
                    ' Si no se encontró ningún registro, las credenciales son incorrectas
                    MessageBox.Show("Usuario o contraseña incorrectos.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
            End Try
        End Using

    End Sub

End Class
