﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Me.btnAbrirVentana = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAbrirVentana
        '
        Me.btnAbrirVentana.Location = New System.Drawing.Point(85, 44)
        Me.btnAbrirVentana.Name = "btnAbrirVentana"
        Me.btnAbrirVentana.Size = New System.Drawing.Size(204, 23)
        Me.btnAbrirVentana.TabIndex = 0
        Me.btnAbrirVentana.Text = "Abrir ventana de chat"
        Me.btnAbrirVentana.UseVisualStyleBackColor = True
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 279)
        Me.Controls.Add(Me.btnAbrirVentana)
        Me.Name = "FormPrincipal"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAbrirVentana As Button
End Class
