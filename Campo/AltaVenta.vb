Public Class AltaVenta
    Public nombreComprador As String
    Dim Carrito As New DataTable


    'Public Sub altaVenta()
    '    InitializeComponent()
    '    Alt = Me
    'End Sub

    Public Property texto() As TextBox
        Get
            Return TextBox1
        End Get
        Set(ByVal Value As TextBox)
            TextBox1 = Value
        End Set
    End Property

    Public Sub mensaje(msg As String)
        TextBox1.Text = msg
    End Sub

    Private Sub AltaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        DataGridView2.DataSource = Nothing
        MenuPrincipal.Show()
    End Sub

    'Quitar del carro
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            Dim art As New BLL.Articulo
            Dim rowIndex As Integer = DataGridView2.CurrentCell.RowIndex
            Dim rows As DataGridViewRow = DataGridView2.Rows(rowIndex)
            'DataGridView1.Rows.Insert(rowIndex)


            DataGridView2.Rows.RemoveAt(rowIndex)
            'Label6.Text = DataGridView2.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDouble(x.Cells("SubTotal").Value))
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


        'DataGridView1.DataSource = articulosComprados

        Dim btn As New DataGridViewButtonColumn
        btn.HeaderText = "Click Data"
        btn.Text = "Agregar"
        btn.Name = "btn"
        btn.UseColumnTextForButtonValue = True

        For Each row As DataRow In articulosComprados.Rows
            DataGridView1.Rows.Add(row.Item(0).ToString, row.Item(1).ToString, row.Item(3).ToString, btn.Text)
        Next
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

    'Cuando le doy añadir
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dt As DataTable
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


    'Doy de alta un cliente (Empresa o Persona)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If rbPersona.Checked Then
            AltaCliente.Show()
        Else
            AltaEmpresa.Show()
        End If

    End Sub


    'Cuando doy de alta una venta
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuev.Click
        Dim nombreCliente As String = TextBox1.Text
        Dim venta As New BLL.Venta()
        Dim idVenta As Integer
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
        If rbPersona.Checked Then
            idVenta = venta.altaVenta(Login.ID_USUARIO, Carrito, Label5.Text, nombreCliente, "c")
        Else
            idVenta = venta.altaVenta(Login.ID_USUARIO, Carrito, Label5.Text, nombreCliente, "e")
        End If


        ''''''''''''''''' CALCULO DE DVH '''''''''''''''''''
        Dim str As String
        Dim dvh As Integer
        Dim seguridad As New BLL.Seguridad("Password")
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



        '' Actualizo DVV usuario
        seguridad.ActualizarDVV("Venta")


        For Each vta As DataRow In datosVenta.Tables("detalleVenta").Rows
            str = idVenta & "" & vta.Item("idArticulo") & "" & vta.Item("PrecioVenta") & "" & vta.Item("Cantidad")
            dvh = seguridad.calcularDVH(str)

            seguridad.ModificarDVH2(vta.Item("idArticulo"), idVenta, dvh, "Detalle_Venta", "idArticulo", "idVenta")

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
End Class