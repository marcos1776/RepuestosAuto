Public Class ModificarContraseña

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub

    'Modificar contraseña
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim seguridad As New BLL.Seguridad("Password")
        Dim usuario As New BLL.Administrador
        'Que compruebe que los campos no sean blancos
        Dim contraseñaAnterior As String
        contraseñaAnterior = seguridad.EncriptarPassword(TextBox1.Text)

        If validarConsistencia() Then
            'Que valide que la contraseña anterior sea la del usuario
            If seguridad.ValidarContraseña(Login.ID_USUARIO, contraseñaAnterior) Then
                Dim nuevaContraseña As String = seguridad.EncriptarPassword(TextBox2.Text)
                seguridad.ModificarContraseña(Login.ID_USUARIO, nuevaContraseña)


                'Busco usuario y Calculo DVH Usuarios
                Dim us As DataSet
                Dim str As String

                ''''''''''''''''''''''''''''''' Calculo el DVH ''''''''''''''''''''''''''''''' 
                us = usuario.BuscarUsuarioEncriptado(Login.ID_USUARIO)
                str = Trim(us.Tables("DatosUsuario").Rows(0).Item("IdUsuario").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Nombre").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Apellido").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Nick").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Contraseña").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Domicilio").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Mail").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Dni").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("EsActivo").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("LoginFallos").ToString)
                Dim dvh As Integer
                dvh = seguridad.calcularDVH(str)

                'usuario.ModificarDVH(idUsuario, dvh, "Usuario", 0)
                seguridad.ModificarDVH(Login.ID_USUARIO.ToString, dvh, "Usuario", "IdUsuario")
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


                seguridad.registrarBitacora(Login.ID_USUARIO, "MEDIA", DateTime.Now, "Contraseña modificada manualmente", 0)

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