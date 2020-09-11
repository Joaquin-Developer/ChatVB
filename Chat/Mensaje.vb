Public Class Mensaje
    Public Property nombreUsuario As String
    Public Property texto As String

    Public Sub New()
    End Sub

    Public Sub New(nombreUsuario As String, texto As String)
        Me.nombreUsuario = nombreUsuario
        Me.texto = texto
    End Sub


End Class
