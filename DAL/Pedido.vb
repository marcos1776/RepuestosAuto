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

        Dim query As String =
        "Select  idArticulo , sum(cant) As cant from ( " +
        "Select idArticulo , sum(cantidad*-1) As cant from Detalle_Venta where idArticulo = '" & art & "' group by IdArticulo " +
        "UNION ALL Select idArticulo, sum(cantidad) as cant from detalle_Pedido where idArticulo = '" & art & "' group by IdArticulo   " +
        "UNION ALL Select idArticulo, sum(cantidad) as cant from Correccion_Stock where idArticulo = '" & art & "' group by IdArticulo  " +
        ") src " +
        "where src.IdArticulo = '" & art & "' " +
        "group by src.IdArticulo "

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
            stock = datar.Item("cant")


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


    Public Function obtenerPedidosFiltrados(dt1 As String, dt2 As String) As DataTable
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = "select p1.idPedido as 'N° Pedido', prov.Nombre_Empresa as 'Proveedor', usu.Nick as 'Usuario', p1.Fecha, p1.Total, p1.Estado from pedido p1 " +
        "join proveedor prov on prov.idProveedor = p1.IdProveedor " +
        "join usuario usu on usu.IdUsuario = p1.IdUsuario " +
        "where convert(date,p1.Fecha,106) >= '" & dt1 & "' " +
        "and convert(date,p1.Fecha,106) <= '" & dt2 & "' " +
        "and p1.Estado = 'Pendiente' "

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
        ",(select GETDATE()), " & total.ToString.Replace(",", ".") & ", NULL , 'Pendiente')"

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
        Dim query As String = "Insert into Detalle_Pedido (idPedido , idArticulo, montoArticulo, Cantidad, DVH)Values( " & idPedido & ", '" & registro.Item("IdArticulo").ToString & "',  " & CDbl(registro.Item("Precio")).ToString.Replace(",", ".") & ", " & registro.Item("Cantidad") & ", NULL)"

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


        Dim detallePedido As String = "Select a1.IdArticulo, a1.Descripcion, cantidad,MontoArticulo, cantidad * MontoArticulo as SubTotal from Detalle_Pedido d1 " +
        "join articulo a1 On d1.IdArticulo = a1.IdArticulo " +
        "where idPedido = " & idPedido & ""

        Dim articulosProveedores As String = "Select IdArticulo, Descripcion , StockProveedor, (100 + Margen_Ganancia)* Precio / 100  as Precio  from Articulo a1 join Proveedor p1 On p1.IdProveedor = a1.IdProveedor where p1.Nombre_Empresa ='" + prov + "'"

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
