<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaChat
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.richTxtMensajes = New System.Windows.Forms.RichTextBox()
        Me.txtMensajeEnviar = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(64, 16)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(150, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario:"
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(319, 304)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 3
        Me.btnEnviar.Text = "Enviar mensaje"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'richTxtMensajes
        '
        Me.richTxtMensajes.Location = New System.Drawing.Point(12, 42)
        Me.richTxtMensajes.Name = "richTxtMensajes"
        Me.richTxtMensajes.Size = New System.Drawing.Size(382, 258)
        Me.richTxtMensajes.TabIndex = 4
        Me.richTxtMensajes.Text = ""
        '
        'txtMensajeEnviar
        '
        Me.txtMensajeEnviar.Location = New System.Drawing.Point(15, 306)
        Me.txtMensajeEnviar.Name = "txtMensajeEnviar"
        Me.txtMensajeEnviar.Size = New System.Drawing.Size(298, 20)
        Me.txtMensajeEnviar.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'VentanaChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 341)
        Me.Controls.Add(Me.txtMensajeEnviar)
        Me.Controls.Add(Me.richTxtMensajes)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Name = "VentanaChat"
        Me.Text = "VentanaChat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEnviar As Button
    Friend WithEvents richTxtMensajes As RichTextBox
    Friend WithEvents txtMensajeEnviar As TextBox
    Friend WithEvents Timer1 As Timer
End Class
