Public Class ModificarPedido

    Public proveedor As String
    Public idPedido As Integer
    Public carrito As New DataTable

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub ModificarPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Label6.Text = DataGridView2.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDouble(x.Cells("SubTotal").Value))

        carrito.Columns.Add("idArticulo", GetType(String))
        carrito.Columns.Add("Descripcion", GetType(String))
        carrito.Columns.Add("Cantidad", GetType(Integer))
        carrito.Columns.Add("Precio", GetType(Double))
        carrito.Columns.Add("Subtotal", GetType(Double))
    End Sub

    'Borro del carrito de compras
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DataGridView2.Rows.RemoveAt(Me.DataGridView2.SelectedRows(0).Index)
        Label6.Text = DataGridView2.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDouble(x.Cells("SubTotal").Value))
    End Sub

    'Añado al carro
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim seguridad As New BLL.Seguridad("Password")
        Dim dt As New DataTable

        Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
        Dim rows As DataGridViewRow = DataGridView1.Rows(rowIndex)

        Dim nombreArticulo As String = rows.Cells(1).Value
        Dim idArticulo As String = rows.Cells(0).Value

        'Dim NombreArticulo As String = DataGridView1.SelectedCells(1).RowIndex.ToString
        Dim cantidad = TextBox1.Text

        'Verificar stock proveedor
        Dim pedido As New BLL.Pedido()

        Dim proveedorEncriptado = seguridad.Encriptar(proveedor)

        If (pedido.VerificarStockProveedor(proveedorEncriptado, nombreArticulo, cantidad)) Then
            'Verificar stock maximo

            If (pedido.VerificarStockMaximo(idArticulo, cantidad)) Then

                Dim Articulo As New BLL.Articulo(proveedor, nombreArticulo, cantidad)
                dt = Articulo.mapearArticulosAobjeto(proveedorEncriptado, nombreArticulo, cantidad)

                Dim btn As New DataGridViewButtonColumn
                btn.HeaderText = "Click Data"
                btn.Text = "Quitar"
                btn.Name = "btn"
                btn.UseColumnTextForButtonValue = True

                Dim dt2 As DataTable = DirectCast(DataGridView2.DataSource, DataTable)
                Dim row As DataRow = dt2.NewRow()

                row.Item(0) = dt.Rows(0).Item(0).ToString
                row.Item(1) = dt.Rows(0).Item(1).ToString
                row.Item(2) = dt.Rows(0).Item(2).ToString
                row.Item(3) = dt.Rows(0).Item(3).ToString
                row.Item(4) = dt.Rows(0).Item(4).ToString

                dt2.Rows.Add(row)

                DataGridView2.DataSource = dt2
            Else
                If Login.ID_IDIOMA = 1 Then
                    MessageBox.Show("Se ha superado el Stock Maximo permitido")
                Else
                    MessageBox.Show("You have exceed the maximum quantity for this item")
                End If

            End If
        Else
            MessageBox.Show("El Proveedor no posee el Stock suficiente para este articulo")
        End If


        Label6.Text = DataGridView2.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDouble(x.Cells("SubTotal").Value))

    End Sub


    'Realizo la modificacion del pedido
    'Elimino el detalle pedido , creo uno nuevo con el carrito , y actualizo el encabezado
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pedido As New BLL.Pedido

        pedido.eliminarPedido(Me.idPedido)


        Dim idPedido As Integer
        Dim datosPedido As DataSet
        'Inserto en la tabla Pedido y detalles Pedido

        Dim seguridad As New BLL.Seguridad("Password")


        Dim resul As Double = DataGridView2.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDouble(x.Cells("SubTotal").Value))
        'Dim rowtotal As DataGridViewRow = DataGridView2.Rows(DataGridView1.Rows.Count - 1)
        Dim i As Integer = 0

        For i = 0 To DataGridView2.Rows.Count - 1 Step 1

            Dim row As DataRow
            row = carrito.NewRow
            row(0) = DataGridView2.Rows(i).Cells(0).Value
            row(1) = DataGridView2.Rows(i).Cells(1).Value
            row(2) = DataGridView2.Rows(i).Cells(2).Value
            row(3) = DataGridView2.Rows(i).Cells(3).Value
            row(4) = DataGridView2.Rows(i).Cells(4).Value

            carrito.Rows.Add(row)
        Next

        'Que me traiga el Id del pedido
        idPedido = pedido.nuevoPedido(Carrito, resul.ToString, seguridad.Encriptar(Proveedor), Login.ID_USUARIO)


        ''''''''''''''''''''''''' DVH  TABLA PEDIDO ''''''''''''''''''''''''
        datosPedido = pedido.obtenerDatosPedidos(idPedido)
        Dim dvh As Integer
        Dim str As String


        str = datosPedido.Tables("cabeceraPedido").Rows(0).Item("IdPedido") & "" &
            datosPedido.Tables("cabeceraPedido").Rows(0).Item("IdProveedor") & "" &
            datosPedido.Tables("cabeceraPedido").Rows(0).Item("IdUsuario") & "" &
            datosPedido.Tables("cabeceraPedido").Rows(0).Item("Fecha") & "" &
            datosPedido.Tables("cabeceraPedido").Rows(0).Item("Total") & "" &
            datosPedido.Tables("cabeceraPedido").Rows(0).Item("Estado") & ""

        dvh = seguridad.calcularDVH(str)
        seguridad.ModificarDVH(idPedido, dvh, "Pedido", "idPedido")

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Calculo DVV
        seguridad.ActualizarDVV("Pedido")

        ''''''''''''''''''''''''' DVH  TABLA DETALLE_PEDIDO '''''''''''''''''''''''


        For Each ped As DataRow In datosPedido.Tables("detallePedido").Rows
            str = idPedido & "" & ped.Item("idArticulo") & "" & ped.Item("MontoArticulo") & "" & ped.Item("Cantidad")
            dvh = seguridad.calcularDVH(str)

            seguridad.ModificarDVH2(ped.Item("idArticulo"), idPedido, dvh, "detalle_pedido", "idArticulo", "idPedido")

            '' Calculo DVV
            seguridad.ActualizarDVV("Detalle_Pedido")
        Next



        seguridad.registrarBitacora(Login.ID_USUARIO, "MEDIA", DateTime.Now, "Pedido modificado al proveedor " & proveedor, 0)


        'Genero el Excel
        pedido.GenerarExcel(proveedor, carrito)
        'Envio de mail.

        If (Login.ID_IDIOMA = 1) Then
            MessageBox.Show("Pedido modificado Correctamente")
        Else
            MessageBox.Show("Order modified succesfully.")
        End If


        Me.Close()

    End Sub
End Class