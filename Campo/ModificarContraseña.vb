Public Class ModificarContraseña

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    'Modificar contraseña
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim seguridad As New BLL.Seguridad("Password")
        'Que compruebe que los campos no sean blancos
        Dim contraseñaAnterior As String
        contraseñaAnterior = seguridad.EncriptarPassword(TextBox1.Text)

        If validarConsistencia() Then
            'Que valide que la contraseña anterior sea la del usuario
            If seguridad.ValidarContraseña(Login.ID_USUARIO, contraseñaAnterior) Then
                Dim nuevaContraseña As String = seguridad.EncriptarPassword(TextBox2.Text)
                seguridad.ModificarContraseña(Login.ID_USUARIO, nuevaContraseña)

                MsgBox("Contraseña actualizada correctamente")
            Else
                MsgBox("La contraseña no coincide")
            End If

        End If


    End Sub

    Private Function validarConsistencia() As Boolean
        If TextBox3.Text = "" Or TextBox2.Text = "" Or TextBox1.Text = "" Then
            MsgBox("Complete los campos")
            Return False

            If TextBox2.Text <> TextBox3.Text Then
                MsgBox("Las nuevas contraseñas no coinciden")
                Return False
            End If
        Else
            Return True
        End If
    End Function
End Class