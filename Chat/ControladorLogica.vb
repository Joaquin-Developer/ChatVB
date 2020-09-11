Public Class ControladorLogica

    Public Shared Property instancia As New ControladorLogica   ' variable estàtica
    Private Property mensajes As New List(Of Mensaje)

    Private Sub New()
    End Sub

    Public Function obtenerMensajes() As List(Of Mensaje)
        Return mensajes
    End Function

    Public Sub agregarMensaje(mensaje As Mensaje)
        If mensaje.nombreUsuario.Length = 0 Or mensaje.texto.Length = 0 Then
            Throw New Exception("Datos incompletos")
        Else
            mensajes.Add(mensaje)
        End If

    End Sub

End Class
