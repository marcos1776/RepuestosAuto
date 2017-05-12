Public Class AdministrarVentas

    Private Sub AdministrarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim seg As New BLL.Seguridad("Password")
        Dim dtMensajes As New DataTable

        dtMensajes = seg.ObtenerMensajes(Login.ID_IDIOMA, 13)
        If (Login.ID_IDIOMA = 1) Then
            Me.Text = "Menu Ventas"
        Else
            Me.Text = "Sales Menu"
        End If



        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        lblBuscarDesde.Text = dtMensajes.Rows(0).Item(5).ToString
        lblBuscarHasta.Text = dtMensajes.Rows(1).Item(5).ToString
        lblCliente.Text = dtMensajes.Rows(2).Item(5).ToString
        btnBuscar.Text = dtMensajes.Rows(3).Item(5).ToString
        lblVentasRealizadas.Text = dtMensajes.Rows(4).Item(5).ToString
        lblVentasCancel.Text = dtMensajes.Rows(5).Item(5).ToString
        btnNueva.Text = dtMensajes.Rows(6).Item(5).ToString
        btnModif.Text = dtMensajes.Rows(7).Item(5).ToString
        btnConsul.Text = dtMensajes.Rows(8).Item(5).ToString
        btnCancelVenta.Text = dtMensajes.Rows(9).Item(5).ToString
        btnCancel.Text = dtMensajes.Rows(10).Item(5).ToString

        cargarGrid()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    'Nueva Venta
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNueva.Click
        Dim venta As New AltaVenta
        venta.Show()
    End Sub


    Private Sub cargarGrid()
        Dim venta As New BLL.Venta
        Dim dt As New DataTable
        Dim canceladas As New DataTable
        Dim realizadas As New DataTable


        dt = venta.ObtenerVentas()

        If (dt.Select("EsCancelada='N'").Count > 0) Then
            realizadas = dt.Select("esCancelada = 'N'").CopyToDataTable
            DataGridView1.DataSource = realizadas
        End If

        If (dt.Select("EsCancelada='Y'").Count > 0) Then
            canceladas = dt.Select("esCancelada = 'Y'").CopyToDataTable
            DataGridView2.DataSource = canceladas
        End If



    End Sub


    'Modificar Venta
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        Dim datosVenta As New DataSet
        Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)
        Dim seguridad As New BLL.Seguridad("Password")

        'Dim proveedor As String = row.Cells(1).Value
        Dim idVenta As Integer = row.Cells(0).Value

        Dim venta As New BLL.Venta
        Dim dt As New DataTable

        datosVenta = venta.ObtenerVentaXid(idVenta)


        dt = datosVenta.Tables("detalleVenta").Select.CopyToDataTable


        'Dim modificarVenta As New ModificarVenta(idVenta)
        Dim modificarVenta As New ModificarVenta()
        ModificarVenta.idVenta = idVenta
        modificarVenta.idCliente = datosVenta.Tables("cabeceraVenta").Rows(0).Item("IdVenta").ToString


        modificarVenta.Show()

        modificarVenta.DataGridView2.DataSource = dt
        modificarVenta.DataGridView2.Columns(0).Visible = False

        'modificarVenta.Label5.Text = dt.Compute("Sum()")



        'Dim btn As New DataGridViewButtonColumn
        'btn.HeaderText = "Click Data"
        'btn.Text = "Agregar"
        'btn.Name = "btn"
        'btn.UseColumnTextForButtonValue = True


        'For Each art As DataRow In datosVenta.Tables("detalleVenta").Rows
        'modificarVenta.DataGridView2.DataSource = datosVenta.Tables("detalleVenta")
        'DataGridView2.Rows.Add(art.Item(1).ToString, art.Item(2).ToString, art.Item(3).ToString)
        'Next

        'ModificarPedido.DataGridView2.DataSource = datosPedido.Tables("detallePedido")


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnConsul.Click

    End Sub

    'Cancelacion de venta
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnCancelVenta.Click
        Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)
        Dim venta As New BLL.Venta
        Dim seguridad As New BLL.Seguridad("Password")
        Dim datosVenta As DataSet

        Dim idVenta As Integer = row.Cells(0).Value

        venta.CancelarVenta(idVenta)



        '
        If (Login.ID_IDIOMA = 1) Then
            MessageBox.Show("Venta cancelada correctamente")
        Else
            MessageBox.Show("Sale canceled succesully")
        End If

        seguridad.registrarBitacora(Login.ID_USUARIO, "MEDIA", DateTime.Now, "Venta cancelada", 0)

        ''''''''''''''''' CALCULO DE DVH '''''''''''''''''''
        Dim str As String
        Dim dvh As Integer

        datosVenta = venta.ObtenerVentaXid(idVenta)

        str = Trim(datosVenta.Tables("cabeceraVenta").Rows(0).Item("IdVenta")) & "" &
        Trim(datosVenta.Tables("cabeceraVenta").Rows(0).Item("IdCliente")) & "" &
        Trim(datosVenta.Tables("cabeceraVenta").Rows(0).Item("IdUsuario")) & "" &
        Trim(datosVenta.Tables("cabeceraVenta").Rows(0).Item("Fecha")) & "" &
        Trim(datosVenta.Tables("cabeceraVenta").Rows(0).Item("Total")) & "" &
        Trim(datosVenta.Tables("cabeceraVenta").Rows(0).Item("EsCancelada")) & ""

        dvh = seguridad.calcularDVH(str)
        seguridad.ModificarDVH(idVenta, dvh, "Venta", "idVenta")

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''

        seguridad.ActualizarDVV("Venta")


        cargarGrid()

    End Sub
End Class