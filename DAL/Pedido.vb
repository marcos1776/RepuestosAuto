Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Pedido

    Public Function VerificarStockProveedor(prov As String, art As String) As Integer
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = "select stockProveedor from articulo a1 join proveedor p1 on a1.IdProveedor = p1.IdProveedor where p1.Nombre_Empresa = '" + prov + "' and a1.descripcion = '" + art + "'"
        Dim com As New SqlCommand(query, sqlCon)

        com.CommandType = CommandType.Text
        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        Dim datar As SqlDataReader
        datar = com.ExecuteReader

        Dim stock As Integer

        While datar.Read
            stock = datar.Item("stockProveedor")

            sqlCon.Close()
            Return stock

        End While

        Return stock
    End Function

    Public Function obtenerStockActual(art As String) As Integer
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = "select idArticulo , sum(cant) from " +
        "( " +
            "select idArticulo , sum(cantidad*-1) from Detalle_Venta where idArticulo = '" & art & "' UNION ALL " +
            "select idArticulo, sum(cantidad) from detalle_Pedido where idArticulo = '" & art & "'   UNION ALL " +
            "select idArticulo, sum(cantidad) from Correccion_Stock where idArticulo = '" & art & "' +   
	    )"

        'LAMPA ARMAR LA QUERY
        Dim com As New SqlCommand(query, sqlCon)

        com.CommandType = CommandType.Text
        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        Dim datar As SqlDataReader
        datar = com.ExecuteReader

        Dim stock As Integer

        While datar.Read
            stock = datar.Item("stockProveedor")

            sqlCon.Close()
            Return stock

        End While

        Return stock
    End Function

    Public Function obtenerPedidos() As DataTable
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = "select p1.idPedido as 'N° Pedido', prov.Nombre_Empresa as 'Proveedor', usu.Nick as 'Usuario', p1.Fecha, p1.Total, p1.Estado from pedido p1 " +
        "join proveedor prov on prov.idProveedor = p1.IdProveedor " +
        "join usuario usu on usu.IdUsuario = p1.IdUsuario "

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

    Public Function nuevoPedido(total As Double, prov As String, idUsuario As Integer) As Integer
        'Agregar el IdUsuario

        Dim idPedido As Integer

        Dim query As String = "Insert into Pedido (idProveedor , idUsuario, fecha, total, dvh, estado)Values( " +
        "(select idProveedor from proveedor where nombre_Empresa = '" & prov & " '), " &
        idUsuario &
        ",(select GETDATE()), " & total & ", NULL , 'Pendiente')"

        Dim query2 As String = "Select @@Identity"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()


        com.CommandText = query2
        idPedido = com.ExecuteScalar()


        sqlCon.Close()

        Return idPedido

    End Function

    Public Sub AgregarArticulosAPedido(registro As DataRow, idPedido As Integer)
        'Agregar el IdUsuario
        Dim query As String = "Insert into Detalle_Pedido (idPedido , idArticulo, montoArticulo, Cantidad, DVH)Values( " & idPedido & ", '" & registro.Item("IdArticulo").ToString & "',  " & CDbl(registro.Item("Precio")) & ", " & registro.Item("Cantidad") & ", NULL)"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon


        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub

    Public Sub eliminarPedido(idPedido As Integer)
        'Agregar el IdUsuario
        Dim query As String = "delete from detalle_pedido where idPedido =" & idPedido & " delete from pedido where idPedido =" & idPedido

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon


        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub

    'Modifico el Pedido , me traigo los datos del proveedor, y el detalle del pedido
    Public Function BuscarPedido(prov As String, idPedido As String) As DataSet
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()


        Dim detallePedido As String = "Select a1.Descripcion from Detalle_Pedido d1 " +
        "join articulo a1 On d1.IdArticulo = a1.IdArticulo " +
        "where idPedido = " & idPedido & ""

        Dim articulosProveedores As String = "Select a1.* from articulo a1 " +
        "join proveedor p1 On a1.IdProveedor = P1.IdProveedor " +
        "WHERE p1.Nombre_Empresa = '" & prov & "'"

        Dim Datos As New DataSet()

        Dim adapterPedido As SqlDataAdapter = New SqlDataAdapter(detallePedido, sqlCon)
        Dim adapterArticulosProveedores As SqlDataAdapter = New SqlDataAdapter(articulosProveedores, sqlCon)

        adapterPedido.Fill(Datos, "detallePedido")
        adapterArticulosProveedores.Fill(Datos, "articulosProveedores")

        sqlCon.Close()

        Return Datos
    End Function

    'Confirmar Pedido
    Public Sub ConfirmarPedido(idPedido As Integer)
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = "Update Pedido set " +
            "estado = 'Confirmado' " +
            "where idPedido = " & idPedido

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandType = CommandType.Text

        com.ExecuteNonQuery()

        sqlCon.Close()
    End Sub

    'Obtener Datos Pedido segun el id Pedido
    Public Function obtenerDatosPedido(idPedido As Integer) As DataSet
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()


        Dim cabeceraPedido As String = "select idPedido, idProveedor, idUsuario,Fecha,Total,Estado from Pedido where idPedido = " & idPedido & ""

        Dim detallePedido As String = "select idPedido, idArticulo, MontoArticulo,Cantidad from detalle_Pedido where idPedido = " & idPedido & ""
        Dim Datos As New DataSet()

        Dim cabPedido As SqlDataAdapter = New SqlDataAdapter(cabeceraPedido, sqlCon)
        Dim detPedido As SqlDataAdapter = New SqlDataAdapter(detallePedido, sqlCon)

        cabPedido.Fill(Datos, "cabeceraPedido")
        detPedido.Fill(Datos, "detallePedido")

        sqlCon.Close()

        Return Datos
    End Function


End Class
