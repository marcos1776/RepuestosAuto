Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Familia

    'Alta Familia
    Public Function altaFamilia(nom As String) As Integer
        Dim idFamilia As Integer
        Dim query As String = "Insert into Familia (Nombre)Values('" & nom & "')"

        Dim query2 As String = "Select @@Identity"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon


        com.ExecuteNonQuery()

        com.CommandText = query2
        idFamilia = com.ExecuteScalar()

        sqlCon.Close()

        Return idFamilia
    End Function

    'Asignacion Patentes
    Public Sub AsignarPatentes(nom As String, patente As String)

        Dim query As String = "Insert into FamiliaPatente (IdFamilia, IdPatente)Values( " +
        "(select idFamilia from Familia where nombre = '" & nom & " ' )," +
        "(select idPatente from Patente where nombre ='" & patente & " '))"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon


        com.ExecuteNonQuery()
        sqlCon.Close()

    End Sub

    'Buscar las patentes de una familia
    Function buscarFamilia(nombre As String) As DataTable
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = "select pat.Nombre from FamiliaPatente fp " +
        "join familia fam on fam.IdFamilia = fp.IdFamilia " +
        "join patente pat on pat.IdPatente = fp.IdPatente " +
        "where fam.Nombre = '" & nombre & "'"

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandType = CommandType.Text
        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        com.ExecuteNonQuery()

        sqlCon.Close()
        Return t

    End Function

    'Buscar Familia x Id
    Function obtenerFamiliaXid(id As Integer) As DataTable
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = "select idFamilia, Nombre from Familia"

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandType = CommandType.Text
        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        com.ExecuteNonQuery()

        sqlCon.Close()
        Return t
    End Function

    Function validarFamilia(fam As String) As DataTable
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = "select distinct(nombre) from vistaPatentes " +
        "where idFamilia <> (select idFamilia from familia where nombre = '" + fam + "')"

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandType = CommandType.Text
        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        com.ExecuteNonQuery()

        sqlCon.Close()
        Return t
    End Function


    Public Sub eliminarFamilia(fam As String)
        Dim query As String =
        " delete from familiaPatente where idFamilia =(select idFamilia from familia where nombre = '" + fam + "')  " +
        " delete from usuarioFamilia where idFamilia = (select idFamilia from familia where nombre = '" + fam + "') " +
        " delete from familia where nombre ='" & fam & " ' "

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
