Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Venta

    Public Function nuevaVenta(idUsuario As Integer, total As Double, cliente As String, tipo As Char) As Integer
        'Agregar el IdUsuario
        Dim idVenta As Integer

        Dim tipoCliente As String
        If tipo = "c" Then
            tipoCliente = "(select IdCliente from cliente where Dni = '" & cliente & "')"
        Else
            tipoCliente = "(select IdCliente from empresa where Cuit = '" & cliente & "')"
        End If

        Dim query As String = "Insert into Venta (IdCliente , idUsuario, fecha, total, esCancelada, dvh)Values(" & tipoCliente & "," & idUsuario & ",(select GETDATE()), " & total & ", 'N' , null)"

        Dim query2 As String = "Select @@Identity"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()

        com.CommandText = query2
        idVenta = com.ExecuteScalar()

        sqlCon.Close()

        Return idVenta
    End Function


    Public Function nuevoPresupuesto(idUsuario As Integer, total As Double, cliente As String, tipo As Char) As Integer
        'Agregar el IdUsuario
        Dim idVenta As Integer

        Dim tipoCliente As String
        If tipo = "c" Then
            tipoCliente = "(select IdCliente from cliente where Dni = '" & cliente & "')"
        Else
            tipoCliente = "(select IdCliente from empresa where Cuit = '" & cliente & "')"
        End If

        Dim query As String = "Insert into Presupuesto (IdCliente , idUsuario, fecha, total, dvh)Values(" & tipoCliente & "," & idUsuario & ",(select GETDATE()), " & total & ", null)"

        Dim query2 As String = "Select @@Identity"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()

        com.CommandText = query2
        idVenta = com.ExecuteScalar()

        sqlCon.Close()

        Return idVenta
    End Function


    Public Sub AgregarArticulosAVenta(registro As DataRow, idVenta As Integer)
        'Agregar el IdUsuario
        Dim query As String = "Insert into Detalle_Venta(idVenta , idArticulo, Cantidad , precioVenta, DVH)Values( " & idVenta & ", '" & registro.Item("IdArticulo").ToString & "',  " & CDbl(registro.Item("PrecioVenta")) & ", " & registro.Item("Cantidad") & ", NULL)"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon


        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub


    Public Function ObtenerVentaXid(id As Integer) As DataSet
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()


        Dim cabeceraVenta As String = "select idVenta, IdCliente, IdUsuario,Fecha,Total,EsCancelada from Venta where idVenta = " & id & ""

        Dim detalleVenta As String = "select idVenta, idArticulo, PrecioVenta,Cantidad from detalle_Venta where idVenta = " & id & ""
        Dim Datos As New DataSet()

        Dim cabVenta As SqlDataAdapter = New SqlDataAdapter(cabeceraVenta, sqlCon)
        Dim detVenta As SqlDataAdapter = New SqlDataAdapter(detalleVenta, sqlCon)

        cabVenta.Fill(Datos, "cabeceraVenta")
        detVenta.Fill(Datos, "detalleVenta")

        sqlCon.Close()



        Return Datos
    End Function

End Class
