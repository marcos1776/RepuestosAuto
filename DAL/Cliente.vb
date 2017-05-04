Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class Cliente

    Public Function altaCliente(n As String, a As String, d As String) As Integer
        Dim idCliente As Integer

        Dim query As String
        query = "insert into cliente (nombre,apellido,dni) values('" + n + "','" + a + "','" + d + "')"

        Dim query2 As String = "Select @@Identity"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()

        com.CommandText = query2
        idCliente = com.ExecuteScalar()

        Return idCliente
    End Function



    Public Sub altaEmpresa(idCliente As Integer, raz As String, cuit As String)
        Dim idEmpresa As Integer

        Dim query As String
        query = "insert into empresa (idCliente, razon_social,cuit) values( " & idCliente & ",'" + raz + "','" + cuit + "')"

        'Dim query2 As String = "Select @@Identity"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()

        'com.CommandText = query2
        'idEmpresa = com.ExecuteScalar()

    End Sub

    Public Function ObtenerCliente(id As Integer) As DataTable
        Dim queryFam As String = "select * from Cliente where idCliente = " & id

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryFam, sqlCon)

        com.CommandText = queryFam
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        Dim dr As SqlDataReader
        dr = com.ExecuteReader


        Dim t As DataTable = New DataTable
        t.Load(dr)

        sqlCon.Close()
        Return t
    End Function

    Public Function ObtenerEmpresa(id As Integer) As DataTable
        Dim queryFam As String = "select * from Empresa where idcliente = " & id

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryFam, sqlCon)

        com.CommandText = queryFam
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        Dim dr As SqlDataReader
        dr = com.ExecuteReader


        Dim t As DataTable = New DataTable
        t.Load(dr)

        sqlCon.Close()
        Return t
    End Function
End Class
