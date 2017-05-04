Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Administrador
    Dim bd As DAL.BaseDeDatos

    Public Function altaUsuario(nom As String, ape As String, nick As String, pass As String, dom As String, mail As String, dni As String) As Integer

        Dim idUsuario As New Integer

        Dim query As String = "Insert into usuario (nombre , apellido , nick, contraseña, domicilio,mail,dni, esActivo, LoginFallos)Values('" & nom & "','" & ape & "','" & nick & "','" & pass & "','" & dom & "','" & mail & "','" & dni & "','Y',0)"
        Dim query2 As String = "Select @@Identity"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()

        com.CommandText = query2
        idUsuario = com.ExecuteScalar()

        sqlCon.Close()
        Return idUsuario
    End Function

    Public Sub ModificarEstadoUser(user As String, tipo As Char)
        Dim query As String = "Update usuario set esActivo ='" & tipo & "'" & "where nick = '" & user & "'"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon


        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub

    Public Sub ModificarUsuario(id As Integer, nom As String, ape As String, nick As String, dni As String, mail As String, dom As String, esActivo As Char)
        Dim query As String = "Update usuario set Nombre ='" & nom & "', " +
        "Apellido= '" & ape & "', " +
        "Nick = '" & nick & "'," +
        "Dni= '" & dni & "', " +
        "Mail= '" & mail & "', " +
        "Domicilio= '" & dom & "', " +
        "EsActivo = '" & esActivo & "' " +
        "Where idUsuario =" & id


        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon


        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub

    Public Sub BorrarTelefonosUsuario(id As Integer)
        Dim query As String = "Delete from Telefono_Usuario where idUsuario =" & id

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon


        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub

    Public Sub ModificarDVH(id As Integer, dvh As Integer, tabla As String, telefono As String)
        Dim query As String
        If tabla = "Usuario" Then
            query = "Update Usuario set DVH = " & dvh & "where idUsuario =" & id
        Else
            query = "Update Telefono_Usuario set DVH = " & dvh & " where idUsuario =" & id & " and telefono = '" & telefono & "'"
        End If

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
        Dim query As String = "update usuario set loginfallos = 0 where Nick = '" & user & "'"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon


        com.ExecuteNonQuery()
        sqlCon.Close()

    End Sub

End Class
