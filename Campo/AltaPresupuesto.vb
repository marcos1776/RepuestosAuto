Public Class AltaPresupuesto
    Public nombreComprador As String
    Dim Carrito As New DataTable

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombreCliente As String = TextBox1.Text
        Dim venta As New BLL.Venta()
        Dim idPresupuesto As Integer
        Dim datosVenta As New DataSet

        For i = 0 To DataGridView2.Rows.Count - 2 Step 1
            Dim row As DataRow
            row = Carrito.NewRow
            row(0) = DataGridView2.Item(0, i).Value
            row(1) = DataGridView2.Item(1, i).Value
            row(2) = DataGridView2.Item(2, i).Value
            row(3) = DataGridView2.Item(3, i).Value
            row(4) = DataGridView2.Item(4, i).Value

            Carrito.Rows.Add(row)
        Next

        'Que me traiga el Id del pedido
        'If rbPersona.Checked Then
        '    idVenta = venta.altaVenta(Login.ID_USUARIO, Carrito, Label5.Text, nombreCliente, "c")
        'Else
        'idVenta = venta.altaVenta(Login.ID_USUARIO, Carrito, Label5.Text, nombreCliente, "e")
        'End If

        idPresupuesto = venta.altaPresupuesto(Login.ID_USUARIO, Carrito, Label5.Text, nombreCliente, "c")


        ''''''''''''''''' CALCULO DE DVH '''''''''''''''''''
        Dim str As String
        Dim dvh As Integer
        Dim seguridad As New BLL.Seguridad("Password")
        datosVenta = venta.ObtenerVentaXid(idPresupuesto)

        str = Trim(datosVenta.Tables("cabeceraVenta").Rows(0).Item("IdVenta")) & "" &
            Trim(datosVenta.Tables("cabeceraVenta").Rows(0).Item("IdCliente")) & "" &
            Trim(datosVenta.Tables("cabeceraVenta").Rows(0).Item("IdUsuario")) & "" &
            Trim(datosVenta.Tables("cabeceraVenta").Rows(0).Item("Fecha")) & "" &
            Trim(datosVenta.Tables("cabeceraVenta").Rows(0).Item("Total")) & "" &
            Trim(datosVenta.Tables("cabeceraVenta").Rows(0).Item("EsCancelada")) & ""

        dvh = seguridad.calcularDVH(str)
        seguridad.ModificarDVH(idPresupuesto, dvh, "Venta", "idVenta")

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''



        '' Actualizo DVV usuario
        seguridad.ActualizarDVV("Venta")


        For Each vta As DataRow In datosVenta.Tables("detalleVenta").Rows
            str = idPresupuesto & "" & vta.Item("idArticulo") & "" & vta.Item("PrecioVenta") & "" & vta.Item("Cantidad")
            dvh = seguridad.calcularDVH(str)

            seguridad.ModificarDVH2(vta.Item("idArticulo"), idPresupuesto, dvh, "Detalle_Venta", "idArticulo", "idVenta")

            '' Calculo DVV
            seguridad.ActualizarDVV("Detalle_Venta")
        Next



        '' Bitacora
        'seguridad.registrarBitacora(Login.ID_USUARIO, "BAJA", DateTime.Now, "Venta Realizada", 0)

        If (Login.ID_IDIOMA = 1) Then
            MessageBox.Show("Venta realizada correctamente")
        Else
            MessageBox.Show("Sale made succesfully")
        End If

        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class