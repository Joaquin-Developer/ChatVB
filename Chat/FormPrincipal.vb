Public Class FormPrincipal

    Private Sub btnAbrirVentana_Click(sender As Object, e As EventArgs) Handles btnAbrirVentana.Click
        Dim ventana1 As New VentanaChat()
        Dim ventana2 As New VentanaChat()
        ventana1.Show()
        ventana2.Show()
    End Sub

End Class
