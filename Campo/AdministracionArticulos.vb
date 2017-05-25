Public Class Administrar_Articulos

    Private Property articulosComprados As DataTable
    Private Property articulosProveedores As DataTable
    Private Property ds As DataSet


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    'Cargo los articulos de Proveedores en el grid
    Private Sub Administrar_Articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        If (Login.ID_IDIOMA = 1) Then
            Me.Text = "Menu Articulos"
        Else
            Me.Text = "Articles Menu"
            lblDatosArticulos.Text = "Articles Data"
            LinkLabel1.Text = "Help"
        End If



        'TextBox5.Visible = False
        DataGridView2.Visible = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        Dim seguridad As New BLL.Seguridad("Password")
        Dim dtMensajes As New DataTable()
        dtMensajes = seguridad.ObtenerMensajes(Login.ID_IDIOMA, 7)


        btnMisArticulos.Text = dtMensajes.Rows(0).Item(5).ToString
        lblArticDispon.Text = dtMensajes.Rows(1).Item(5).ToString
        btnArticulosProv.Text = dtMensajes.Rows(2).Item(5).ToString
        lblBuscar.Text = dtMensajes.Rows(3).Item(5).ToString
        lblAuto.Text = dtMensajes.Rows(4).Item(5).ToString
        lblMinimo.Text = dtMensajes.Rows(5).Item(5).ToString
        lblMax.Text = dtMensajes.Rows(6).Item(5).ToString
        lblMargen.Text = dtMensajes.Rows(7).Item(5).ToString
        btnModifArtic.Text = dtMensajes.Rows(8).Item(5).ToString

        Label1.Text = dtMensajes.Rows(2).Item(5).ToString

        lblMinimo.Visible = False
        lblMax.Visible = False
        lblMargen.Visible = False

        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False


        btnModifArtic.Visible = False

        cargarDataGrid()
    End Sub

    'Que se carguen los articulos comprados y los articulos de los proveedores.
    Public Sub cargarDataGrid()
        ListBox1.Items.Clear()
        Dim listadoArticulos As New BLL.Listas
        ds = listadoArticulos.obtenerListadoArticulos()

        'Dim articulosComprados As New DataTable

        If ds.Tables("ArticulosComprados").Select().Count > 0 Then
            articulosComprados = ds.Tables("ArticulosComprados").Select().CopyToDataTable
            DataGridView1.DataSource = articulosComprados

            If Login.ID_IDIOMA <> 1 Then
                DataGridView1.Columns(0).HeaderText = "Article ID"
                DataGridView1.Columns(1).HeaderText = "Description"
                DataGridView1.Columns(2).HeaderText = "Minimum stock"
                DataGridView1.Columns(3).HeaderText = "Maximum stock"
                DataGridView1.Columns(4).HeaderText = "Price"
            End If

        End If


        If ds.Tables("ArticulosProveedores").Select().Count > 0 Then
            articulosProveedores = ds.Tables("ArticulosProveedores").Select().CopyToDataTable
            DataGridView2.DataSource = articulosProveedores

            If Login.ID_IDIOMA <> 1 Then
                DataGridView2.Columns(0).HeaderText = "Company Name"
                DataGridView2.Columns(1).HeaderText = "Article Id"
                DataGridView2.Columns(2).HeaderText = "Description"
                DataGridView2.Columns(3).HeaderText = "Price"
            End If
        End If

        'DataGridView1.Columns(2).Visible = False
        'DataGridView1.Columns(3).Visible = False
        'DataGridView2.Columns(3).Visible = False

        'TextBox1.Enabled = False
        'TextBox2.Enabled = False
        'TextBox3.Enabled = False

    End Sub

    'Alta Articulo
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim altaArticulo As New AltaArticulo
        altaArticulo.Show()
    End Sub

    'Modificar Articulo
    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    '    Dim datosArticulos As New DataSet
    '    Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
    '    Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)

    '    Dim idArticulo As String = row.Cells(0).Value
    '    Dim articulo As New BLL.Articulo


    '    Dim modificarArticulo As New ModificarArticulo
    '    modificarArticulo.Show()

    '    datosArticulos = articulo.buscarArticulo(Trim(idArticulo))

    '    'modificarArticulo.idProveedor = datosArticulos.Tables("DatosArticulo").Rows(0).Item("Id")

    '    modificarArticulo.TextBox1.Text = datosArticulos.Tables("DatosArticulo").Rows(0).Item("IdArticulo")
    '    modificarArticulo.TextBox2.Text = datosArticulos.Tables("DatosArticulo").Rows(0).Item("Descripcion")
    '    modificarArticulo.TextBox3.Text = datosArticulos.Tables("DatosArticulo").Rows(0).Item("StockMinimo")
    '    modificarArticulo.TextBox4.Text = datosArticulos.Tables("DatosArticulo").Rows(0).Item("Margen_Ganancia")


    '    For Each auto As DataRow In datosArticulos.Tables("ListadoAutos").Rows
    '        modificarArticulo.ListBox1.Items.Add(auto(0).ToString + " - " + (auto(1).ToString + " - " + auto(2).ToString))
    '    Next

    '    For Each auto As DataRow In datosArticulos.Tables("DatosAutos").Rows
    '        modificarArticulo.ListBox2.Items.Add(auto(1).ToString + " - " + (auto(2).ToString + " - " + auto(3).ToString))
    '    Next



    'End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnArticulosProv.Click
        DataGridView1.Visible = False
        DataGridView2.Visible = True
        lblArticDispon.Visible = False
        Label1.Visible = True

        lblMinimo.Visible = True
        lblMax.Visible = True
        lblMargen.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = True

        btnModifArtic.Visible = True
        btnAplicCam.Visible = False

        TextBox5.Visible = True
        TextBox4.Visible = False


    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnMisArticulos.Click
        DataGridView2.Visible = False
        DataGridView1.Visible = True

        Label1.Visible = False
        lblArticDispon.Visible = True

        lblMinimo.Visible = False
        lblMax.Visible = False
        lblMargen.Visible = False

        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False

        TextBox4.Visible = False
        TextBox5.Enabled = True

        btnModifArtic.Visible = False

    End Sub

    'Cuando cambio el articulo del primer grid de mis articulos
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        ListBox1.Items.Clear()
        Dim datosArticulos As New DataSet
        Dim rowIndex As Integer = DataGridView2.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataGridView2.Rows(rowIndex)

        Dim idArt As String = row.Cells(1).Value
        Dim articulo As New BLL.Articulo


        'Dim modificarArticulo As New ModificarArticulo
        'modificarArticulo.Show()

        datosArticulos = articulo.buscarArticulo(Trim(idArt))

        TextBox1.Text = datosArticulos.Tables("DatosArticulo").Rows(0).Item("StockMinimo")
        TextBox2.Text = datosArticulos.Tables("DatosArticulo").Rows(0).Item("StockMaximo")
        TextBox3.Text = datosArticulos.Tables("DatosArticulo").Rows(0).Item("Margen_Ganancia")

        ModificarArticulo.TextBox1.Text = datosArticulos.Tables("DatosArticulo").Rows(0).Item("IdArticulo")
        ''''''''''''''''''' Cargo los autos
        Dim listadoAutos As DataTable = ds.Tables("AutosArticulos").Select("idArticulo = '" & idArt & "'").CopyToDataTable
        'DataGridView3.DataSource = listadoAutos
        Dim str As String
        If listadoAutos.Rows.Count > 0 Then
            For Each item As DataRow In listadoAutos.Rows
                str = item(1).ToString + " - " + item(2).ToString + " - " + item(3).ToString + " "
                ListBox1.Items.Add(str)
            Next
        End If
        ''''''''''''''''''''
    End Sub


    'Cuando cambio el articulo del segundo grid
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ListBox1.Items.Clear()
        Dim datosArticulos As New DataSet
        Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)

        Dim idArt As String = row.Cells(0).Value
        Dim articulo As New BLL.Articulo


        'Dim modificarArticulo As New ModificarArticulo
        'modificarArticulo.Show()

        datosArticulos = articulo.buscarArticulo(Trim(idArt))

        'TextBox1.Text = datosArticulos.Tables("DatosArticulo").Rows(0).Item("StockMinimo")
        'TextBox2.Text = datosArticulos.Tables("DatosArticulo").Rows(0).Item("StockMaximo")
        'TextBox3.Text = datosArticulos.Tables("DatosArticulo").Rows(0).Item("Margen_Ganancia")

        'ModificarArticulo.TextBox1.Text = datosArticulos.Tables("DatosArticulo").Rows(0).Item("IdArticulo")
        ''''''''''''''''''' Cargo los autos
        Dim listadoAutos As DataTable = ds.Tables("AutosArticulos").Select("idArticulo = '" & idArt & "'").CopyToDataTable
        'DataGridView3.DataSource = listadoAutos
        Dim str As String
        If listadoAutos.Rows.Count > 0 Then
            For Each item As DataRow In listadoAutos.Rows
                str = item(1).ToString + " - " + item(2).ToString + " - " + item(3).ToString + " "
                ListBox1.Items.Add(str)
            Next
        End If

        ''''''''''''''''''''
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnModifArtic.Click
        btnAplicCam.Visible = True
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
    End Sub


    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim dataview As New DataView(articulosComprados)

        dataview.RowFilter = "idArticulo like '%" + TextBox4.Text + "%' " +
        "OR Descripcion like '%" + TextBox4.Text + "%'"

        DataGridView1.DataSource = dataview
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Dim dataview As New DataView(articulosProveedores)

        dataview.RowFilter = "Nombre_Empresa like '%" + TextBox5.Text + "%' " +
        "OR idArticulo like '%" + TextBox5.Text + "%' " +
        "OR Descripcion like '%" + TextBox5.Text + "%'"

        DataGridView2.DataSource = dataview
    End Sub

    'Falta Logica de Modificar
    Private Sub btnAplicCam_Click(sender As Object, e As EventArgs) Handles btnAplicCam.Click
        Dim rowIndex As Integer = DataGridView2.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataGridView2.Rows(rowIndex)
        Dim art As New BLL.Articulo
        Dim dvh As Integer
        Dim seg As New BLL.Seguridad("Password")
        Dim articuloNombre As String = row.Cells(1).Value

        art.ActualizarArticulo(articuloNombre, TextBox1.Text, TextBox2.Text, TextBox3.Text)
        Dim datosArticulo As New DataSet

        datosArticulo = art.buscarArticulo(articuloNombre)

        Dim CadenaDVH As String = Trim(datosArticulo.Tables(3).Rows(0).Item(0).ToString) +
        Trim(datosArticulo.Tables(3).Rows(0).Item(1).ToString) +
        Trim(datosArticulo.Tables(3).Rows(0).Item(2).ToString) +
        Trim(datosArticulo.Tables(3).Rows(0).Item(3).ToString) +
        Trim(datosArticulo.Tables(3).Rows(0).Item(4).ToString) +
        Trim(datosArticulo.Tables(3).Rows(0).Item(5).ToString) +
        Trim(datosArticulo.Tables(3).Rows(0).Item(6).ToString) +
        Trim(datosArticulo.Tables(3).Rows(0).Item(7).ToString) +
        Trim(datosArticulo.Tables(3).Rows(0).Item(8).ToString)

        'Trim(articulo._idArticulo) & Trim(idProveedor) & Trim(articulo._Stock) & Trim(articulo._Descripcion) & "000Y" & Trim(articulo._Precio)
        'articulo.CargarArticuloProveedor(seguridad.Encriptar(proveedor), articulo)

        dvh = seg.calcularDVH(CadenaDVH)
        seg.ModificarDVH(articuloNombre, dvh, "articulo", "idArticulo")

        '' Calculo DVV
        seg.ActualizarDVV("articulo")

        Dim seguridad As New BLL.Seguridad("Password")
        Dim idBitacora As Integer = seguridad.registrarBitacora(Login.ID_USUARIO, "MEDIA", DateTime.Now, "Se modificaron los datos del articulo", 0)

        Dim ds As New DataTable
        Dim str As String
        ''''''''''''''''''''''''''''''' Calculo el DVH ''''''''''''''''''''''''''''''' 
        ds = seguridad.buscarRegistroBitacora(idBitacora)
        'usuario.BuscarUsuarioEncriptado(idUsuario)
        str = Trim(ds.Rows(0).Item("IdBitacora").ToString) + Trim(ds.Rows(0).Item("IdUsuario").ToString) + Trim(ds.Rows(0).Item("Criticidad").ToString) + Trim(ds.Rows(0).Item("Fecha").ToString) + Trim(ds.Rows(0).Item("Descripcion").ToString) + ds.Rows(0).Item("DVH").ToString

        dvh = seguridad.calcularDVH(str)

        'usuario.ModificarDVH(idUsuario, dvh, "Usuario", 0)
        seguridad.ModificarDVH(idBitacora, dvh, "Bitacora", "IdBitacora")

        If Login.ID_IDIOMA = 1 Then
            MessageBox.Show("Articulo modificado correctamente !")
        Else
            MessageBox.Show("Article modified correctly !")
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim bll As New BLL.Seguridad("Password")
        e.Handled = bll.aceptaNumeros(e.KeyChar)

        If (e.Handled) Then
            Dim tt As New ToolTip()
            Dim VisibleTime As Integer = 1000
            tt.Show(Login.tooltipNumero, TextBox1, 0, 0, VisibleTime)
        End If
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

    Private Sub TextBox3_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        Dim bll As New BLL.Seguridad("Password")
        e.Handled = bll.aceptaNumeros(e.KeyChar)

        If (e.Handled) Then
            Dim tt As New ToolTip()
            Dim VisibleTime As Integer = 1000
            tt.Show(Login.tooltipNumero, TextBox3, 0, 0, VisibleTime)
        End If
    End Sub
End Class