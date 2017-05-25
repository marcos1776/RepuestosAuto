Public Class ModificarVenta
    Public nombreComprador As String
    Dim Carrito As New DataTable
    Public Shared idVenta As Integer
    Public Shared idCliente As Integer


    Private Sub ModificarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtMensajes As New DataTable
        Dim seguridad As New BLL.Seguridad("Passowrd")

        dtMensajes = seguridad.ObtenerMensajes(Login.ID_IDIOMA, 14)

        If (Login.ID_IDIOMA = 1) Then
            Me.Text = "Modificar Venta"
            Me.btnNuev.Text = "Modificar Venta"
        Else
            Me.Text = "Modify sale"
            Me.btnNuev.Text = "Modify sale"
        End If


        lblCant.Text = dtMensajes.Rows(5).Item(5).ToString
        lblArt.Text = dtMensajes.Rows(6).Item(5).ToString
        lblCarro.Text = dtMensajes.Rows(7).Item(5).ToString
        'btnNuev.Text = dtMensajes.Rows(8).Item(5).ToString
        lblTotal.Text = dtMensajes.Rows(9).Item(5).ToString
        btnCancel.Text = dtMensajes.Rows(10).Item(5).ToString





        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        If Login.ID_IDIOMA = 1 Then
            Carrito.Columns.Add("idArticulo", GetType(String))
            Carrito.Columns.Add("Descripcion", GetType(String))
            Carrito.Columns.Add("Cantidad", GetType(String))
            Carrito.Columns.Add("PrecioVenta", GetType(String))
            Carrito.Columns.Add("Subtotal", GetType(String))
        Else
            Carrito.Columns.Add("Article Id", GetType(String))
            Carrito.Columns.Add("Description", GetType(String))
            Carrito.Columns.Add("Quantity", GetType(String))
            Carrito.Columns.Add("Sale Price", GetType(String))
            Carrito.Columns.Add("Subtotal", GetType(String))
        End If


        cargarDataGrid()

    End Sub


    Private Sub TextBox2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim bll As New BLL.Seguridad("Password")
        e.Handled = bll.aceptaNumeros(e.KeyChar)

        If (e.Handled) Then
            Dim tt As New ToolTip()
            Dim VisibleTime As Integer = 1000
            tt.Show(Login.tooltipNumero, TextBox2, 0, 0, VisibleTime)
        End If
    End Sub

    'Añadir al carro
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim cliente As String
        'cliente = TextBox1.Text

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
            Label5.Text = DataGridView2.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDouble(x.Cells(3).Value))

        End If
    End Sub



    Public Sub cargarDataGrid()
        Dim ds As New DataSet
        Dim listadoArticulos As New BLL.Listas
        ds = listadoArticulos.obtenerListadoArticulos()


        Dim articulosComprados As New DataTable
        If ds.Tables("ArticulosComprados").Rows.Count > 0 Then
            articulosComprados = ds.Tables("ArticulosComprados").Select().CopyToDataTable

        End If


        DataGridView1.DataSource = articulosComprados
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(3).Visible = False


        If Login.ID_IDIOMA <> 1 Then
            DataGridView1.Columns(0).HeaderText = "Article Id"
            DataGridView1.Columns(1).HeaderText = "Description"
            DataGridView1.Columns(4).HeaderText = "Price"
        End If

        'Dim btn As New DataGridViewButtonColumn
        'btn.HeaderText = "Click Data"
        'btn.Text = "Agregar"
        'btn.Name = "btn"
        'btn.UseColumnTextForButtonValue = True

        'For Each row As DataRow In articulosComprados.Rows
        '    DataGridView1.Rows.Add(row.Item(1).ToString, row.Item(2).ToString, row.Item(3).ToString)
        'Next

        'Agregar los articulos comprados

        'Dim sum As Double = 0
        'Dim i As Integer = 0
        'For i = 0 To DataGridView2.Rows.Count
        '    sum += Convert.ToDouble(DataGridView2.Rows(i).Cells(2).ToString)
        'Next

        'Label5.Text = sum.ToString()

        '''''''''''''''''''''''''''''''''
        'Label5.Text = DataGridView2.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDouble(x.Cells(3).Value))

    End Sub

    'Cuando modifico la venta
    Private Sub btnNuev_Click(sender As Object, e As EventArgs) Handles btnNuev.Click
        'Borro la venta anterior cabecera y detalle

        Dim venta As New BLL.Venta

        venta.EliminarVenta(Me.idVenta)


        'Inserto en la tabla Pedido y detalles Pedido

        Dim seguridad As New BLL.Seguridad("Password")


        'Añado la nueva cabecera  y el  carro de venta 
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


        idVenta = venta.modificarVenta(Login.ID_USUARIO, Carrito, Label5.Text, Me.idCliente)



    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
        Dim rows As DataGridViewRow = DataGridView1.Rows(rowIndex)

        Dim nombreArticulo As String = rows.Cells(0).Value

        Dim dt2 As DataTable = DirectCast(DataGridView2.DataSource, DataTable)
        Dim row As DataRow = dt2.NewRow()

        row.Item(1) = rows.Cells(0).Value
        row.Item(2) = rows.Cells(1).Value
        row.Item(3) = rows.Cells(4).Value
        row.Item(4) = Convert.ToInt32(TextBox2.Text)

        dt2.Rows.Add(row)

        DataGridView2.DataSource = dt2



        Label5.Text = DataGridView2.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDouble(x.Cells(3).Value))
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class