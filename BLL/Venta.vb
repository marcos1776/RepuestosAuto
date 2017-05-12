Public Class Venta

    Public Function altaVenta(idUsuario As Integer, carrito As DataTable, total As Double, cliente As String, tipo As Char) As Integer
        Dim venta As New DAL.Venta
        Dim idVenta As Integer
        If tipo = "c" Then
            idVenta = venta.nuevaVenta(idUsuario, total, cliente, "c")
        Else
            idVenta = venta.nuevaVenta(idUsuario, total, cliente, "e")
        End If

        ''Agrego al detalle Pedido
        For Each row As DataRow In carrito.Rows
            venta.AgregarArticulosAVenta(row, idVenta)
        Next

        Return idVenta
    End Function


    Public Function modificarVenta(idUsuario As Integer, carrito As DataTable, total As Double, Idcliente As Integer) As Integer
        Dim venta As New DAL.Venta
        Dim idVenta As Integer

        idVenta = venta.modificarVenta(idUsuario, total, Idcliente)

        ''Agrego al detalle Pedido
        For Each row As DataRow In carrito.Rows
            venta.AgregarArticulosAVenta(row, idVenta)
        Next

        Return idVenta
    End Function


    Public Function altaPresupuesto(idUsuario As Integer, carrito As DataTable, total As Double, cliente As String, tipo As Char) As Integer
        Dim venta As New DAL.Venta
        Dim idVenta As Integer
        If tipo = "c" Then
            idVenta = venta.nuevoPresupuesto(idUsuario, total, cliente, "c")
        Else
            idVenta = venta.nuevoPresupuesto(idUsuario, total, cliente, "e")
        End If

        ''Agrego al detalle Pedido
        For Each row As DataRow In carrito.Rows
            venta.AgregarArticulosAPresupuesto(row, idVenta)
        Next

        Return idVenta
    End Function



    Public Function ObtenerVentaXid(id As Integer) As DataSet
        Dim venta As New DAL.Venta
        Return venta.ObtenerVentaXid(id)
    End Function

    Public Function ObtenerVentas() As DataTable
        Dim venta As New DAL.Venta
        Dim dt As New DataTable
        Dim seg As New BLL.Seguridad("Password")

        dt = venta.ObtenerVentas

        For Each r As DataRow In dt.Rows
            r.Item(1) = seg.Desencriptar(r.Item(1).ToString)
        Next

        Return dt
    End Function


    Public Sub cancelarVenta(idVenta)
        Dim venta As New DAL.Venta
        venta.CancelarVenta(idVenta)
    End Sub

    Public Sub eliminarVenta(idVenta As Integer)
        Dim venta As New DAL.Venta
        venta.eliminarVenta(idVenta)
    End Sub
End Class
