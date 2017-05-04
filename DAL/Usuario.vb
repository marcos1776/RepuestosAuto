Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Usuario


    Public Function obtenerUsuarios() As DataSet
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()
        Dim Datos As New DataSet()


        Dim query As String = "select Nombre, Apellido , Nick , Domicilio , mail , dni ,esActivo from usuario"
        Dim query2 As String = "select IdUsuario, Telefono, EsActivo,DVH from telefono_usuario"
        Dim com As New SqlCommand(query, sqlCon)


        Dim adapterUsuario As SqlDataAdapter = New SqlDataAdapter(query, sqlCon)
        Dim adapterTelefonos As SqlDataAdapter = New SqlDataAdapter(query2, sqlCon)

        adapterUsuario.Fill(Datos, "DatosUsuario")
        adapterTelefonos.Fill(Datos, "DatosTelefono")

        sqlCon.Close()
        Return Datos

    End Function

    Public Function buscarUsuario(user As String) As DataSet
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim queryUsuario As String = "Select idUsuario,Nombre, Apellido , Nick , Contraseña ,Domicilio , mail , dni, esActivo, loginFallos from usuario where nick = '" & user & "'"
        Dim queryTelefono As String = "Select t1.Telefono from Telefono_Usuario t1 " +
            "join usuario u1 on u1.IdUsuario = t1.IdUsuario " +
            "where u1.Nick= '" & user & "'"

        Dim Datos As New DataSet()

        Dim adapterUsuario As SqlDataAdapter = New SqlDataAdapter(queryUsuario, sqlCon)
        Dim adapterTelefonos As SqlDataAdapter = New SqlDataAdapter(queryTelefono, sqlCon)

        adapterUsuario.Fill(Datos, "DatosUsuario")
        adapterTelefonos.Fill(Datos, "DatosTelefono")

        sqlCon.Close()
        Return Datos
    End Function

    Public Function buscarUsuarioEncriptado(user As Integer) As DataSet
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim queryUsuario As String = "Select idUsuario,Nombre, Apellido , Nick ,Contraseña, Domicilio , mail , dni, esActivo, Loginfallos from usuario where idUsuario = " & user
        Dim queryTelefono As String = "Select t1.Idusuario,t1.Telefono, t1.EsActivo from Telefono_Usuario t1 " +
            "join usuario u1 on u1.IdUsuario = t1.IdUsuario " +
            "where u1.idUsuario = " & user

        Dim Datos As New DataSet()

        Dim adapterUsuario As SqlDataAdapter = New SqlDataAdapter(queryUsuario, sqlCon)
        Dim adapterTelefonos As SqlDataAdapter = New SqlDataAdapter(queryTelefono, sqlCon)

        adapterUsuario.Fill(Datos, "DatosUsuario")
        adapterTelefonos.Fill(Datos, "DatosTelefono")

        sqlCon.Close()
        Return Datos
    End Function



    Public Function buscarUsuarioEncriptado2(user As String) As DataSet
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim queryUsuario As String = "Select idUsuario,Nombre, Apellido , Nick ,Contraseña, Domicilio , mail , dni, esActivo, Loginfallos from usuario where nick = '" & user & "'"
        Dim queryTelefono As String = "Select t1.Idusuario,t1.Telefono, t1.EsActivo from Telefono_Usuario t1 " +
            "join usuario u1 on u1.IdUsuario = t1.IdUsuario " +
            "where u1.Nick = '" & user & "'"

        Dim Datos As New DataSet()

        Dim adapterUsuario As SqlDataAdapter = New SqlDataAdapter(queryUsuario, sqlCon)
        Dim adapterTelefonos As SqlDataAdapter = New SqlDataAdapter(queryTelefono, sqlCon)

        adapterUsuario.Fill(Datos, "DatosUsuario")
        adapterTelefonos.Fill(Datos, "DatosTelefono")

        sqlCon.Close()
        Return Datos
    End Function

    Public Sub agregarTelefono(idUsuario As Integer, telefono As String)
        Dim query As String = "Insert into Telefono_Usuario (idUsuario , Telefono, esActivo)Values(" & idUsuario & ",'" & telefono & "','Y')"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub

    Public Sub agregarTelefono(telefono As Integer, idUsuario As Integer)
        Dim query As String = "Insert into Telefono_Usuario (idUsuario , Telefono, esActivo)Values(" & idUsuario & ",'" & telefono & "','Y')"


        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon


        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub

    Public Sub actualizarContraseña(user As String, pass As String)
        Dim query As String = "Update usuario set Contraseña ='" & pass & "' where Nick = '" & user & "'"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()
        sqlCon.Close()

    End Sub

    'Valido el usuario cuando voy a iniciar sesion
    Public Function ValidarUsuario(user As String, pass As String) As DataTable
        Dim query As String = "Select * from usuario where Nick ='" & user & "' and contraseña = '" & pass & "'"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        Dim dr As SqlDataReader
        dr = com.ExecuteReader


        Dim t As DataTable = New DataTable
        t.Load(dr)

        sqlCon.Close()
        Return t
    End Function


    Public Function IntentoFallido(user As String) As Integer
        Dim query As String = "update usuario set LoginFallos = LoginFallos + 1 where Nick ='" & user & "' "
        Dim query2 As String = "Select LoginFallos from Usuario where nick ='" & user & "' "

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon
        com.ExecuteNonQuery()


        'Aca me traigo el numero
        Dim com2 As New SqlCommand(query2, sqlCon)

        com2.CommandText = query2
        com2.CommandType = CommandType.Text
        com2.Connection = sqlCon

        Dim intento As Integer
        intento = com2.ExecuteScalar

        sqlCon.Close()
        Return intento

    End Function



    Public Sub EliminarTelefonos(user As Integer)

        Dim query As String = "delete from Telefono_Usuario where idUsuario = " & user
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()
        sqlCon.Close()


    End Sub


    Public Sub ReiniciarContador(user As String)
        Dim dal As New DAL.Administrador
        dal.ReiniciarContador(user)
    End Sub
End Class
