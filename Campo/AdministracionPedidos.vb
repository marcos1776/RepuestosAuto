﻿Public Class AdministracionPedidos

    Dim pendiente As New DataTable
    Dim confirmados As New DataTable

    Dim data As New DataTable



    'Boton Cancelar
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub

    'Boton alta pedido
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        AltaPedido.Show()
    End Sub

    Private Sub AdministracionPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
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





        ComboBox1.Items.Clear()

        Dim ds As New DataSet
        Dim listadoProveedores As New BLL.Listas
        ds = listadoProveedores.obtenerProveedores()

        Dim habilitados As DataTable = ds.Tables("DatosProveedores").Select().CopyToDataTable

        If ds.Tables("DatosProveedores").Select("esActivo = 'Y'").Count > 0 Then
            For Each h As DataRow In habilitados.Rows
                ComboBox1.Items.Add(h.Item("Nombre_Empresa"))
            Next
        End If



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
        Dim seguridad As New BLL.Seguridad("Password")

        Dim proveedor As String = row.Cells(1).Value
        Dim idPedido As Integer = row.Cells(0).Value

        Dim pedido As New BLL.Pedido

        datosPedido = pedido.BuscarPedido(seguridad.Encriptar(Trim(proveedor)), idPedido)

        Dim modificarPedido As New ModificarPedido

        modificarPedido.proveedor = proveedor
        modificarPedido.idPedido = idPedido

        'For Each carrito As DataRow In datosPedido.Tables("articulosProveedores").Rows
        '    modificarPedido.ListBox1.Items.Add(carrito(4).ToString)
        'Next



        modificarPedido.DataGridView1.DataSource = datosPedido.Tables("articulosProveedores")


        'For Each art As DataRow In datosPedido.Tables("detallePedido").Rows
        '    modificarPedido.ListBox2.Items.Add(art(0).ToString)
        'Next

        modificarPedido.DataGridView2.DataSource = datosPedido.Tables("detallePedido")

        modificarPedido.Show()
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

            If Login.ID_IDIOMA <> 1 Then
                DataGridView1.Columns(0).HeaderText = "Nº Order"
                DataGridView1.Columns(1).HeaderText = "Supplier"
                DataGridView1.Columns(2).HeaderText = "User"
                DataGridView1.Columns(3).HeaderText = "Date"
                DataGridView1.Columns(4).HeaderText = "Total"
                DataGridView1.Columns(5).HeaderText = "Status"
            End If

        End If


        If dt.Select("Estado = 'Confirmado'").Count > 0 Then
            confirmados = dt.Select("Estado = 'Confirmado'").CopyToDataTable

            DataGridView2.DataSource = confirmados

            If Login.ID_IDIOMA <> 1 Then
                DataGridView2.Columns(0).HeaderText = "Nº Order"
                DataGridView2.Columns(1).HeaderText = "Supplier"
                DataGridView2.Columns(2).HeaderText = "User"
                DataGridView2.Columns(3).HeaderText = "Date"
                DataGridView2.Columns(4).HeaderText = "Total"
                DataGridView2.Columns(5).HeaderText = "Status"
            End If
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

        seguridad.ActualizarDVV("Detalle_Pedido")

        Dim idBitacora As Integer = seguridad.registrarBitacora(Login.ID_USUARIO, "ALTA", DateTime.Now, "Cancelación de pedido", 0)
        Dim ds As New DataTable
        Dim str As String
        Dim dvh As Integer

        ''''''''''''''''''''''''''''''' Calculo el DVH ''''''''''''''''''''''''''''''' 
        ds = seguridad.buscarRegistroBitacora(idBitacora)
        'usuario.BuscarUsuarioEncriptado(idUsuario)
        Str = Trim(ds.Rows(0).Item("IdBitacora").ToString) + Trim(ds.Rows(0).Item("IdUsuario").ToString) + Trim(ds.Rows(0).Item("Criticidad").ToString) + Trim(ds.Rows(0).Item("Fecha").ToString) + Trim(ds.Rows(0).Item("Descripcion").ToString) + ds.Rows(0).Item("DVH").ToString

        dvh = seguridad.calcularDVH(Str)

        'usuario.ModificarDVH(idUsuario, dvh, "Usuario", 0)
        seguridad.ModificarDVH(idBitacora, dvh, "Bitacora", "IdBitacora")

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

        If Login.ID_IDIOMA = 1 Then
            MessageBox.Show("Pedido confirmado !")
        Else
            MessageBox.Show("Order confirmed !")
        End If

        '' Actualizo el dvv
        seguridad.ActualizarDVV("Pedido")

        Dim idBitacora As Integer = seguridad.registrarBitacora(Login.ID_USUARIO, "MEDIA", DateTime.Now, "Pedido Confirmado", 0)
        Dim ds As New DataTable


        ''''''''''''''''''''''''''''''' Calculo el DVH ''''''''''''''''''''''''''''''' 
        ds = seguridad.buscarRegistroBitacora(idBitacora)
        'usuario.BuscarUsuarioEncriptado(idUsuario)
        str = Trim(ds.Rows(0).Item("IdBitacora").ToString) + Trim(ds.Rows(0).Item("IdUsuario").ToString) + Trim(ds.Rows(0).Item("Criticidad").ToString) + Trim(ds.Rows(0).Item("Fecha").ToString) + Trim(ds.Rows(0).Item("Descripcion").ToString) + ds.Rows(0).Item("DVH").ToString

        dvh = seguridad.calcularDVH(str)

        'usuario.ModificarDVH(idUsuario, dvh, "Usuario", 0)
        seguridad.ModificarDVH(idBitacora, dvh, "Bitacora", "IdBitacora")
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        cargarDataGrid()
    End Sub

    Private Sub btnConsul_Click(sender As Object, e As EventArgs) Handles btnConsul.Click
        Dim datosPedido As New DataSet
        Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)
        Dim seguridad As New BLL.Seguridad("Password")

        Dim proveedor As String = row.Cells(1).Value
        Dim idPedido As Integer = row.Cells(0).Value

        Dim pedido As New BLL.Pedido

        datosPedido = pedido.BuscarPedido(seguridad.Encriptar(Trim(proveedor)), idPedido)

        Dim consultarPedido As New ModificarPedido

        consultarPedido.Button2.Hide()
        consultarPedido.Button5.Hide()
        consultarPedido.btnModif.Hide()

        consultarPedido.TextBox1.Hide()
        consultarPedido.lblBusc.Hide()
        consultarPedido.TextBox3.Hide()
        consultarPedido.lblCant.Hide()

        If Login.ID_IDIOMA = 1 Then
            consultarPedido.Text = "Consultar Pedido"
        Else
            consultarPedido.Text = "Check Order"
        End If

        consultarPedido.proveedor = proveedor
        consultarPedido.idPedido = idPedido

        consultarPedido.DataGridView1.DataSource = datosPedido.Tables("articulosProveedores")
        consultarPedido.DataGridView2.DataSource = datosPedido.Tables("detallePedido")

        consultarPedido.Show()
    End Sub

    'Buscar Pedidos por un rango
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dt As New DataTable
        Dim pedidos As New BLL.Pedido()
        Dim seguridad As New BLL.Seguridad("Password")
        dt = pedidos.obtenerPedidosFiltrados(DateTimePicker1.Value.ToString("yyyy-MM-dd"), DateTimePicker2.Value.ToString("yyyy-MM-dd"))

        DataGridView1.DataSource = dt
    End Sub
End Class