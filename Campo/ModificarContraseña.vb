Public Class ModificarContraseña

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
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


                If Login.ID_IDIOMA = 1 Then
                    MessageBox.Show("Contraseña actualizada correctamente")
                Else
                    MessageBox.Show("Password changed succesfully")
                End If
            Else
                If Login.ID_IDIOMA = 1 Then
                    MessageBox.Show("La contraseña insertada no es correcta")
                Else
                    MessageBox.Show("You have not entered the correct password.")
                End If
            End If
        End If

        'LAMPA ACTUALIZAR DVH Y DVV

        'BITACORA

    End Sub

    Private Function validarConsistencia() As Boolean
        If TextBox3.Text = "" Or TextBox2.Text = "" Or TextBox1.Text = "" Then
            If Login.ID_IDIOMA = 1 Then
                MessageBox.Show("Por favor complete los campos")
            Else
                MessageBox.Show("Please complete blank fields.")
            End If
            Return False

            If TextBox2.Text <> TextBox3.Text Then
                If Login.ID_IDIOMA = 1 Then
                    MessageBox.Show("Las nuevas contraseñas no coinciden")
                Else
                    MessageBox.Show("Please complete blank fields.")
                End If
                Return False
            End If
        Else
            Return True
        End If
    End Function
End Class