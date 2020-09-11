Public Class VentanaChat

    Private Sub VentanaChat_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        eventoEnviar()
    End Sub

    Private Sub txtMensajeEnviar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMensajeEnviar.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            eventoEnviar()
        End If
    End Sub

    Private Sub eventoEnviar()
        Dim mensaje As New Mensaje(txtUsuario.Text, txtMensajeEnviar.Text)
        Try
            ControladorLogica.instancia.agregarMensaje(mensaje)
            'refrescarChat()
            txtMensajeEnviar.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'refrescarChat()
        Try
            Dim textoMensajes As String = ""
            Dim listaMensajes As New List(Of Mensaje)
            listaMensajes = ControladorLogica.instancia.obtenerMensajes()
            For Each mensaje As Mensaje In listaMensajes
                textoMensajes += mensaje.nombreUsuario & "> " & mensaje.texto & Environment.NewLine
            Next
            richTxtMensajes.Text = textoMensajes
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

End Class
