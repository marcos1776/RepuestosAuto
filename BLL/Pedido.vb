Public Class Pedido

    Public Sub New()
    End Sub

    Public Function VerificarStockProveedor(prov As String, art As String, cant As Integer) As Boolean
        Dim ped As New DAL.Pedido()
        Dim stockProvedor As Integer = ped.VerificarStockProveedor(prov, art)

        If stockProvedor < cant Then
            Return False
        Else
            Return True
        End If
    End Function


    Public Function VerificarStockMaximo(art As String, cant As Integer) As Boolean
        Dim ped As New DAL.Pedido()
        Dim articulo As New DAL.Articulo()

        'Me traigo el maximo permitido ' Validarlo
        Dim artDs As New DataSet()
        artDs = articulo.BuscarArticulo(art)

        Dim maxPermitido = Convert.ToInt32(artDs.Tables("DatosArticulo").Rows(0).Item("StockMaximo"))
        'Me traigo el stock actual
        Dim stockActual As Integer = ped.obtenerStockActual(art)

        If (stockActual + cant) <= maxPermitido Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function obtenerPedidos() As DataTable
        Dim dt As New DataTable
        Dim seg As New BLL.Seguridad("Password")

        Dim ped As New DAL.Pedido()
        dt = ped.obtenerPedidos()

        ''
        For Each row As DataRow In dt.Rows
            row.Item(1) = seg.Desencriptar(row.Item(1).ToString)
            row.Item(2) = seg.Desencriptar(row.Item(2).ToString)
        Next


        ''

        Return dt
    End Function

    Public Function nuevoPedido(carrito As DataTable, total As Double, proveedor As String, idUsuario As Integer) As Integer
        Dim pedido As New DAL.Pedido
        Dim idPedido As Integer = pedido.nuevoPedido(total, proveedor, idUsuario)

        For Each row As DataRow In carrito.Rows
            pedido.AgregarArticulosAPedido(row, idPedido)
        Next

        'Agrego al detalle Pedido
        Return idPedido

    End Function

    'Buscar Pedido
    Public Function BuscarPedido(prov As String, idPedido As String) As DataSet
        Dim pedido As New DAL.Pedido

        Return pedido.BuscarPedido(prov, idPedido)
    End Function

    'Confirmar Pedido
    Public Sub ConfirmarPedido(pedido As Integer)
        Dim ped As New DAL.Pedido
        ped.ConfirmarPedido(pedido)
    End Sub

    Public Function obtenerDatosPedidos(idPedido) As DataSet
        Dim pedido As New DAL.Pedido
        Return pedido.obtenerDatosPedido(idPedido)
    End Function

    Public Sub eliminarPedido(idPedido As Integer)
        Dim pedido As New DAL.Pedido
        pedido.eliminarPedido(idPedido)
    End Sub

End Class

