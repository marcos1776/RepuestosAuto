Public Class ModificarVenta
    Public nombreComprador As String
    Dim Carrito As New DataTable
    Private Sub ModificarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtMensajes As New DataTable
        Dim seguridad As New BLL.Seguridad("Passowrd")

        dtMensajes = seguridad.ObtenerMensajes(Login.ID_IDIOMA, 14)

        If (Login.ID_IDIOMA = 1) Then
            Me.Text = "Nueva Venta"
        Else
            Me.Text = "New sale"
        End If

        lblCliente.Text = dtMensajes.Rows(0).Item(5).ToString
        rbPersona.Text = dtMensajes.Rows(1).Item(5).ToString
        rbEmpresa.Text = dtMensajes.Rows(2).Item(5).ToString
        btnBusc.Text = dtMensajes.Rows(3).Item(5).ToString
        btnNuevo.Text = dtMensajes.Rows(4).Item(5).ToString
        lblCant.Text = dtMensajes.Rows(5).Item(5).ToString
        lblArt.Text = dtMensajes.Rows(6).Item(5).ToString
        lblCarro.Text = dtMensajes.Rows(7).Item(5).ToString
        btnNuev.Text = dtMensajes.Rows(8).Item(5).ToString
        lblTotal.Text = dtMensajes.Rows(9).Item(5).ToString
        btnCancel.Text = dtMensajes.Rows(10).Item(5).ToString





        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Carrito.Columns.Add("idArticulo", GetType(String))
        Carrito.Columns.Add("Descripcion", GetType(String))
        Carrito.Columns.Add("Cantidad", GetType(Integer))
        Carrito.Columns.Add("PrecioVenta", GetType(Double))
        Carrito.Columns.Add("Subtotal", GetType(Double))

        cargarDataGrid()

    End Sub

    'Añadir al carro
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim cliente As String
        cliente = TextBox1.Text

        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
            Dim rows As DataGridViewRow = DataGridView1.Rows(rowIndex)

            Dim nombreArticulo As String = rows.Cells(0).Value

            'Dim Articulo As New BLL.Articulo(nombreArticulo, cantidad)
            'dt = Articulo.mapearArticulosAobjeto(Proveedor, nombreArticulo, cantidad)


            Dim btn As New DataGridViewButtonColumn
            btn.HeaderText = "Click Data"
            btn.Text = "Quitar"
            btn.Name = "btn"
            btn.UseColumnTextForButtonValue = True


            DataGridView2.Rows.Add(rows.Cells(0).Value, rows.Cells(1).Value, rows.Cells(2).Value, TextBox2.Text, (rows.Cells(2).Value) * TextBox2.Text, btn.Text)
            Label5.Text = DataGridView2.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDouble(x.Cells("Subtotal").Value))

        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If rbPersona.Checked Then
            AltaCliente.Show()
        Else
            AltaEmpresa.Show()
        End If

    End Sub

    'Buscador de usuario
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnBusc.Click
        Dim tipo As New Char
        Dim dt As DataTable
        Dim listas As New BLL.Listas

        If rbPersona.Checked Then
            tipo = "c"
        Else
            tipo = "e"
        End If
        dt = listas.obtenerListadoClientes(tipo)

        Dim buscar As New BuscarCliente
        buscar.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        buscar.Show()
        buscar.DataGridView1.DataSource = dt
    End Sub


    Public Sub cargarDataGrid()
        Dim ds As New DataSet
        Dim listadoArticulos As New BLL.Listas
        ds = listadoArticulos.obtenerListadoArticulos()


        Dim articulosComprados As New DataTable
        If ds.Tables("ArticulosComprados").Rows.Count > 0 Then
            articulosComprados = ds.Tables("ArticulosComprados").Select().CopyToDataTable
        End If


        'DataGridView1.DataSource = articulosComprados

        Dim btn As New DataGridViewButtonColumn
        btn.HeaderText = "Click Data"
        btn.Text = "Agregar"
        btn.Name = "btn"
        btn.UseColumnTextForButtonValue = True

        For Each row As DataRow In articulosComprados.Rows
            DataGridView1.Rows.Add(row.Item(0).ToString, row.Item(1).ToString, row.Item(5).ToString, btn.Text)
        Next

        'Agregar los articulos comprados



        '''''''''''''''''''''''''''''''''

    End Sub

    'Cuando modifico la venta
    Private Sub btnNuev_Click(sender As Object, e As EventArgs) Handles btnNuev.Click

    End Sub
End Class