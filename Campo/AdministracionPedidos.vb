Public Class AdministracionPedidos

    Dim pendiente As New DataTable
    Dim confirmados As New DataTable

    Dim data As New DataTable



    'Boton Cancelar
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    'Boton alta pedido
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        AltaPedido.Show()
    End Sub

    Private Sub AdministracionPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Login.ID_IDIOMA = 1) Then
            Me.Text = "Administrar Pedidos"
        Else
            Me.Text = "Manage Orders"
        End If


        Dim seg As New BLL.Seguridad("Password")
        Dim dtMensajes As New DataTable
        '' Cargp el idioma
        dtMensajes = seg.ObtenerMensajes(Login.ID_IDIOMA, 15)


        lblBuscarDesde.Text = dtMensajes.Rows(0).Item(5).ToString
        btnBuscar.Text = dtMensajes.Rows(1).Item(5).ToString
        lblHasta.Text = dtMensajes.Rows(2).Item(5).ToString
        lblProv.Text = dtMensajes.Rows(3).Item(5).ToString
        lblPedReal.Text = dtMensajes.Rows(4).Item(5).ToString
        lblPedConfir.Text = dtMensajes.Rows(5).Item(5).ToString
        btnConfi.Text = dtMensajes.Rows(6).Item(5).ToString
        btnModif.Text = dtMensajes.Rows(7).Item(5).ToString
        btnConsul.Text = dtMensajes.Rows(8).Item(5).ToString
        btnCancelPedido.Text = dtMensajes.Rows(9).Item(5).ToString
        btnCancelar.Text = dtMensajes.Rows(10).Item(5).ToString









        ''''





        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        'asignar datatable
        'data.Columns.Add("N° Pedido")
        'data.Columns.Add("Proveedor")
        'data.Columns.Add("Usuario")
        'data.Columns.Add("Fecha")
        'data.Columns.Add("Total")
        'data.Columns.Add("Estado")
        cargarDataGrid()
    End Sub

    'Modificar un Pedido
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        Dim datosPedido As New DataSet
        Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)

        Dim proveedor As String = row.Cells(1).Value
        Dim idPedido As Integer = row.Cells(0).Value

        Dim pedido As New BLL.Pedido

        datosPedido = pedido.BuscarPedido(Trim(proveedor), idPedido)

        Dim modificarPedido As New ModificarPedido
        modificarPedido.Show()

        For Each carrito As DataRow In datosPedido.Tables("articulosProveedores").Rows
            modificarPedido.ListBox1.Items.Add(carrito(4).ToString)
        Next


        For Each art As DataRow In datosPedido.Tables("detallePedido").Rows
            modificarPedido.ListBox2.Items.Add(art(0).ToString)
        Next
    End Sub

    'Confirmar Pedidos
    'Private Sub Button1_Click(sender As Object, e As EventArgs)

    'End Sub

    Public Sub cargarDataGrid()
        DataGridView1.DataSource = data
        DataGridView2.DataSource = data
        Dim dt As New DataTable
        Dim pedidos As New BLL.Pedido()
        Dim seguridad As New BLL.Seguridad("Password")
        dt = pedidos.obtenerPedidos()


        Dim btn As New DataGridViewButtonColumn
        btn.HeaderText = "Click Data"
        btn.Text = "Confirmar"
        btn.Name = "btn"
        btn.UseColumnTextForButtonValue = True

        '' Dividir segun el estado
        ''If dt.Select("Estado = 'Pendiente'").Count > 0 Then
        'If dt.Select.Count > 0 Then
        '    'pendiente = dt.Select("Estado = 'Pendiente'").CopyToDataTable
        '    'DataGridView1.DataSource = pendiente
        '    For Each row As DataRow In dt.Rows
        '        'DataGridView1
        '        DataGridView1.Rows.Add(row(0), seguridad.Desencriptar(row(1)), seguridad.Desencriptar(row(2)), row(3), row(4), btn.Text)
        '    Next

        'End If
        If dt.Select("Estado = 'Pendiente'").Count > 0 Then
            pendiente = dt.Select("Estado = 'Pendiente'").CopyToDataTable
            'For Each row As DataRow In pendiente.Rows
            '    'DataGridView1
            '    DataGridView1.Rows.Add(row(0), seguridad.Desencriptar(row(1)), seguridad.Desencriptar(row(2)), row(3), row(4), btn.Text)
            'Next
            DataGridView1.DataSource = pendiente
        End If


        If dt.Select("Estado = 'Confirmado'").Count > 0 Then
            confirmados = dt.Select("Estado = 'Confirmado'").CopyToDataTable

            DataGridView2.DataSource = confirmados
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

            Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
            Dim rows As DataGridViewRow = DataGridView1.Rows(rowIndex)

            Dim idPedido As Integer = rows.Cells(0).Value

            Dim pedido As New BLL.Pedido
            pedido.ConfirmarPedido(idPedido)

            cargarDataGrid()

            '' Calculo de DVH

            '' Calculo de DVV

        End If
    End Sub

    'Cuando cancelo el pedido , lo elimino
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnCancelPedido.Click
        Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)
        Dim idPedido As Integer = row.Cells(0).Value
        Dim seguridad As New BLL.Seguridad("Password")

        'Elimino el detalle y el pedido
        Dim bll As New BLL.Pedido
        bll.eliminarPedido(idPedido)

        'Actualizo el DVV 
        seguridad.ActualizarDVV("Pedido")

        cargarDataGrid()
    End Sub

    'Cuando confirmo el pedido
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnConfi.Click
        Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)
        Dim datosPedido As New DataSet
        Dim seguridad As New BLL.Seguridad("Password")

        Dim idPedido As Integer = row.Cells(0).Value

        Dim pedido As New BLL.Pedido
        pedido.ConfirmarPedido(idPedido)

        datosPedido = pedido.obtenerDatosPedidos(idPedido)

        '' Calculo el DVH del pedido
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

        '' Actualizo el dvv
        seguridad.ActualizarDVV("Pedido")

        cargarDataGrid()
    End Sub




End Class