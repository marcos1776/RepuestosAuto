Public Class Administrador

    Public _idUsuario As Integer
    Public _nombre As String
    Public _apellido As String
    Public _nick As String
    Public _contraseña As String
    Public _domicilio As String
    Public _mail As String
    Public _dni As String
    Public _esActivo As Char
    Public _loginFallos As Integer
    Public _DVH As Integer


    Public Sub New(n, a, dni, ni, mail, dom)
        Me._nombre = n
        Me._apellido = a
        Me._dni = dni
        Me._nick = ni
        Me._mail = mail
        Me._domicilio = dom
    End Sub

    'Usuario sin nick --> para hacer la modificacion de usuario
    Public Sub New(n, a, dni, mail, dom)
        Me._nombre = n
        Me._apellido = a
        Me._dni = dni
        Me._mail = mail
        Me._domicilio = dom
    End Sub

    Public Sub New()

    End Sub

    'Añadir Usuario
    Public Function añadirUsuario(usuario As Administrador) As Integer
        Dim user As New DAL.Administrador()
        Return user.altaUsuario(usuario._nombre, usuario._apellido, usuario._nick, usuario._contraseña, usuario._domicilio, usuario._mail, usuario._dni)
    End Function

    'Modificar Estado Usuario
    Public Sub ModificarEstadoUsuario(user As String, c As Char)
        Dim usuario As New DAL.Administrador()

        'HACER ---> Condicion que diga que si le paso "N" , vea si las  patentes estan asignadas a otro usuario

        usuario.ModificarEstadoUser(user, c)

        'Completar
        'usuario.ActualizarUsuarioEstado()
    End Sub

    'Buscar Usuario
    Public Function BuscarUsuario(user As String) As DataSet
        Dim usuario As New DAL.Usuario()
        Dim ds As New DataSet

        Dim seguridad As New BLL.Seguridad("Password")

        ds = usuario.buscarUsuario(user)
        'Desencriptar Datos Usuario y Telefono

        For Each row As DataRow In ds.Tables("DatosUsuario").Rows
            row.Item(1) = seguridad.Desencriptar(row.Item(1).ToString)
            row.Item(2) = seguridad.Desencriptar(row.Item(2).ToString)
            row.Item(3) = seguridad.Desencriptar(row.Item(3).ToString)
            row.Item(5) = seguridad.Desencriptar(row.Item(5).ToString)
            row.Item(6) = seguridad.Desencriptar(row.Item(6).ToString)
            row.Item(7) = seguridad.Desencriptar(row.Item(7).ToString)
        Next


        For Each row As DataRow In ds.Tables("DatosTelefono").Rows
            row.Item(0) = seguridad.Desencriptar(row.Item(0).ToString)
        Next

        Return ds
    End Function

    'Buscar Usuario Encriptado
    Public Function BuscarUsuarioEncriptado(user As Integer) As DataSet
        Dim usuario As New DAL.Usuario()
        Return usuario.buscarUsuarioEncriptado(user)
    End Function

    Public Function BuscarUsuarioEncriptado2(user As String) As DataSet
        Dim usuario As New DAL.Usuario()
        Return usuario.buscarUsuarioEncriptado2(user)
    End Function
    'Agregar Telefono con ID de usuario, esto lo hago cuando modifico
    Sub AgregarTelefono(listaTelefonos As List(Of String), IdUsuario As Integer)
        Dim usuario As New DAL.Usuario()
        Dim seguridad As New Seguridad("Password")

        If listaTelefonos.Count > 0 Then
            For Each tel As String In listaTelefonos
                usuario.agregarTelefono(IdUsuario, tel.ToString)
            Next
        End If
    End Sub

    Public Sub modificarUsuario(usuario As Administrador, id As Integer)
        Dim user As New DAL.Administrador()
        user.ModificarUsuario(id, usuario._nombre, usuario._apellido, usuario._nick, usuario._mail, usuario._dni, usuario._domicilio, usuario._esActivo)
        user.BorrarTelefonosUsuario(id)
    End Sub

    Public Sub ModificarDVH(idUser As Integer, dvh As Integer, tabla As String, tel As String)
        Dim user As New DAL.Administrador
        user.ModificarDVH(idUser, dvh, tabla, tel)
    End Sub

    'Se valida el usuario al Loguiarse
    Public Function ValidarUsuario(user As String, password As String) As Integer
        Dim seguridad As New Seguridad("Password")
        Dim adm As New DAL.Usuario()
        Dim dt As New DataTable
        Dim intento As Integer
        Dim us As New DataSet
        Dim usuario As New BLL.Administrador
        Dim str As String
        Dim dvh As Integer

        user = seguridad.Encriptar(Trim(user))
        password = seguridad.EncriptarPassword(Trim(password))

        dt = adm.ValidarUsuario(user, password)
        us = usuario.BuscarUsuarioEncriptado2(user)

        If dt.Rows.Count > 0 Then

            If Trim(us.Tables("DatosUsuario").Rows(0).Item("LoginFallos").ToString) = 3 Then
                Windows.Forms.MessageBox.Show("El usuario se encuentra bloqueado")
                Return -1
            Else
                'Poner el contador de logueo en 0
                adm.ReiniciarContador(user)

                '' Actualizar DVH
                us = usuario.BuscarUsuarioEncriptado(dt.Rows(0).Item(0).ToString)
                str = Trim(us.Tables("DatosUsuario").Rows(0).Item("IdUsuario").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Nombre").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Apellido").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Nick").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Contraseña").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Domicilio").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Mail").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Dni").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("EsActivo").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("LoginFallos").ToString)

                dvh = seguridad.calcularDVH(str)

                'usuario.ModificarDVH(idUsuario, dvh, "Usuario", 0)
                seguridad.ModificarDVH(dt.Rows(0).Item(0).ToString, dvh, "Usuario", "IdUsuario")


                '' Actualizar DVV
                seguridad.ActualizarDVV("Usuario")

                Return dt.Rows(0).Item(0)
                Return -1
            End If
        Else
            '' Actualizar DVH
            us = usuario.BuscarUsuarioEncriptado2(user)

            If (us.Tables("DatosUsuario").Rows.Count > 0) Then

                ' Sumarle 1 al contador de logueo
                intento = adm.IntentoFallido(user)

                str = Trim(us.Tables("DatosUsuario").Rows(0).Item("IdUsuario").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Nombre").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Apellido").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Nick").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Contraseña").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Domicilio").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Mail").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Dni").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("EsActivo").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("LoginFallos").ToString)

                dvh = seguridad.calcularDVH(str)

                'usuario.ModificarDVH(idUsuario, dvh, "Usuario", 0)
                seguridad.ModificarDVH(us.Tables("DatosUsuario").Rows(0).Item(0).ToString, dvh, "Usuario", "idUsuario")
                'seguridad.ModificarDVH(dt.Rows(0).Item(0).ToString, dvh, "Usuario", "IdUsuario")

                '' Actualizar DVV
                seguridad.ActualizarDVV("Usuario")

                'Registro en Bitacora
                seguridad.registrarBitacora(us.Tables("DatosUsuario").Rows(0).Item(0).ToString, "BAJA", DateTime.Now, "Error de Login", 0)

            End If

            If intento = 3 Then
                    Me.ModificarEstadoUsuario(user, "N")

                '' Actualizar DVH
                us = usuario.BuscarUsuarioEncriptado(us.Tables("DatosUsuario").Rows(0).Item(0).ToString)
                str = Trim(us.Tables("DatosUsuario").Rows(0).Item("IdUsuario").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Nombre").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Apellido").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Nick").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Contraseña").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Domicilio").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Mail").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Dni").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("EsActivo").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("LoginFallos").ToString)

                    dvh = seguridad.calcularDVH(str)

                'usuario.ModificarDVH(idUsuario, dvh, "Usuario", 0)
                seguridad.ModificarDVH(us.Tables("DatosUsuario").Rows(0).Item(0).ToString, dvh, "Usuario", "IdUsuario")
                '' Actualizar DVV
                seguridad.ActualizarDVV("Usuario")

                    'Registro en Bitacora
                    seguridad.registrarBitacora(us.Tables("DatosUsuario").Rows(0).Item(0).ToString, "ALTA", DateTime.Now, "El usuario ha sido bloqueado", 0)

                    MsgBox("El usuario ha sido bloqueado")
                End If

                Return -1
            End If
    End Function


    Public Sub EliminarTelefonos(idUsuario As Integer)
        Dim adm As New DAL.Usuario()
        adm.EliminarTelefonos(idUsuario)
    End Sub

End Class
