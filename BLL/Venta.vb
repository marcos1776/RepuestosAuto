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
            venta.AgregarArticulosAVenta(row, idVenta)
        Next

        Return idVenta
    End Function



    Public Function ObtenerVentaXid(id As Integer) As DataSet
        Dim venta As New DAL.Venta
        Return venta.ObtenerVentaXid(id)
    End Function

End Class
