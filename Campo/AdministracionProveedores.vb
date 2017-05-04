Public Class AdministracionProveedores
    Dim strHelp As String = Application.StartupPath & "\Ayuda\AdminProveedores.chm"
    Dim inhabilitados As New DataTable
    Dim habilitados As New DataTable

    Dim listaTelefonos As New List(Of String)
    Dim listaDirecciones As New List(Of String)

    Dim estadoProveedorAnterior As String


    'Load Form
    Private Sub AdministracionProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Login.ID_IDIOMA = 1 Then
            Me.Text = "Menu Proveedores"
        Else
            Me.Text = "Suppliers Menu"
            Me.LinkLabel1.Text = "Help"
        End If



        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        'DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim seguridad As New BLL.Seguridad("Password")
        Dim dtMensajes As New DataTable()
        dtMensajes = seguridad.ObtenerMensajes(Login.ID_IDIOMA, 5)


        lblProveedorHabil.Text = dtMensajes.Rows(0).Item(5).ToString
        lblBuscar.Text = dtMensajes.Rows(1).Item(5).ToString
        lblDatosProveedor.Text = dtMensajes.Rows(2).Item(5).ToString
        lblNombreEmpresa.Text = dtMensajes.Rows(3).Item(5).ToString
        lblNombreContacto.Text = dtMensajes.Rows(4).Item(5).ToString
        lblApellidoContacto.Text = dtMensajes.Rows(5).Item(5).ToString
        lblMail.Text = dtMensajes.Rows(6).Item(5).ToString
        lblHabiliado.Text = dtMensajes.Rows(7).Item(5).ToString
        lblTelefonos.Text = dtMensajes.Rows(8).Item(5).ToString
        lblDirecciones.Text = dtMensajes.Rows(9).Item(5).ToString
        btnModificarProveedor.Text = dtMensajes.Rows(10).Item(5).ToString
        btnAplicarCambios.Text = dtMensajes.Rows(11).Item(5).ToString
        btnCancelar.Text = dtMensajes.Rows(12).Item(5).ToString

        ' Si tiene la patente de modificar usuario que se habilite el combobox
        Dim dt As DataRow()
        dt = Login.dtPatentesUsuario.Select("Nombre='ModificarProveedor'")

        If (dt.Count > 0) Then
            btnModificarProveedor.Enabled = True
        End If

        cargarDataGrid()
    End Sub

    'Boton Cancelar
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub

    'Alta Proveedor
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        AltaProveedor.Show()
        Me.Hide()
    End Sub

    'Modificar Proveedor
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim datosProveedor As New DataSet
        Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
        Dim seguridad As New BLL.Seguridad("Password")
        Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)

        Dim proveedorNombre As String = row.Cells(0).Value
        Dim proveedor As New BLL.Proveedor


        'Traigo datos de proveedor, telefonos , direcciones.
        'proveedor = proveedor.BuscarProveedor(Trim(proveedorNombre))

        'Me.Hide()
        Dim modificarProveedor As New ModificarProveedor
        modificarProveedor.Show()

        datosProveedor = proveedor.buscarProveedor(seguridad.Encriptar(Trim(proveedorNombre)))

        modificarProveedor.idProveedor = datosProveedor.Tables("datosProveedor").Rows(0).Item("IdProveedor")

        modificarProveedor.TextBox1.Text = datosProveedor.Tables("datosProveedor").Rows(0).Item("Nombre_Empresa")
        modificarProveedor.TextBox2.Text = datosProveedor.Tables("datosProveedor").Rows(0).Item("Nombre_Contacto")
        modificarProveedor.TextBox3.Text = datosProveedor.Tables("datosProveedor").Rows(0).Item("Apellido_Contacto")
        modificarProveedor.TextBox4.Text = datosProveedor.Tables("datosProveedor").Rows(0).Item("Mail")


        For Each tel As DataRow In datosProveedor.Tables("DatosTelefono").Rows
            modificarProveedor.ListBox1.Items.Add(tel(0).ToString)
        Next

        For Each dir As DataRow In datosProveedor.Tables("DatosDirecciones").Rows
            modificarProveedor.ListBox2.Items.Add(dir(0).ToString)
        Next
    End Sub

    'Cargar DataGrid
    Public Sub cargarDataGrid()
        Dim ds As New DataSet
        Dim listadoProveedores As New BLL.Listas
        ds = listadoProveedores.obtenerProveedores()

        If ds.Tables("DatosProveedores").Rows.Count > 0 Then
            habilitados = ds.Tables("DatosProveedores").Select.CopyToDataTable

            DataGridView1.DataSource = habilitados

            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            'DataGridView1.Columns(5).Visible = False
            'DataGridView1.Columns(6).Visible = False
        End If

        'If dt.Select("esActivo = 'N'").Count > 0 Then
        '    inhabilitados = dt.Select("esActivo = 'N'").CopyToDataTable
        'End If




        'DataGridView2.DataSource = inhabilitados
    End Sub

    'Filtro de proveedores habilitados
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        Dim dataview As New DataView(habilitados)

        dataview.RowFilter = "Nombre_Empresa like '%" + TextBox8.Text + "%'" +
        "OR Nombre_Contacto like '%" + TextBox8.Text + "%'" +
        "OR Apellido_Contacto like '%" + TextBox8.Text + "%'"

        DataGridView1.DataSource = dataview
    End Sub

    'Filtro de proveedores inhabilitados
    'Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
    '    Dim dataview As New DataView(inhabilitados)

    '    dataview.RowFilter = "Nombre_Empresa like '%" + TextBox2.Text + "%'" +
    '    "OR Nombre_Contacto like '%" + TextBox2.Text + "%'" +
    '    "OR Apellido_Contacto like '%" + TextBox2.Text + "%'" +
    '    "OR Mail like '%" + TextBox2.Text + "%'"

    '    DataGridView2.DataSource = dataview
    'End Sub

    ''Habilitar Proveedor
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim rowIndex As Integer = DataGridView2.CurrentCell.RowIndex
    '    Dim row As DataGridViewRow = DataGridView2.Rows(rowIndex)

    '    Dim Proveedor As String = row.Cells(0).Value

    '    'Validar Patentes

    '    '
    '    Dim prov As New BLL.Proveedor()
    '    prov.ModificarEstadoProveedor(Proveedor, "Y")

    '    cargarDataGrid()
    'End Sub

    ''Deshabiltar Proveedor
    'Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
    '    Dim rowIndex As Integer = DataGridView2.CurrentCell.RowIndex
    '    Dim row As DataGridViewRow = DataGridView2.Rows(rowIndex)

    '    Dim Proveedor As String = row.Cells(0).Value

    '    'Validar Patentes

    '    '
    '    Dim prov As New BLL.Proveedor()
    '    prov.ModificarEstadoProveedor(Proveedor, "N")

    '    cargarDataGrid()
    'End Sub

    'Cuando hago click en la celda me cambian los datos de los proveedores

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        estadoProveedorAnterior = ComboBox1.Text

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        ComboBox1.Enabled = False
        btnAplicarCambios.Enabled = False
        ListBox1.Enabled = False
        ListBox2.Enabled = False
        btnAplicarCambios.Visible = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False


        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Dim datosProveedores As New DataSet
        Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)

        Dim seguridad As New BLL.Seguridad("Password")

        Dim prov As String = row.Cells(0).Value
        Dim proveedor As New BLL.Proveedor

        datosProveedores = proveedor.buscarProveedor(seguridad.Encriptar(Trim(prov)))


        TextBox1.Text = datosProveedores.Tables("DatosProveedor").Rows(0).Item("Nombre_Empresa")
        TextBox2.Text = datosProveedores.Tables("DatosProveedor").Rows(0).Item("Nombre_Contacto")
        TextBox3.Text = datosProveedores.Tables("DatosProveedor").Rows(0).Item("Apellido_Contacto")
        TextBox4.Text = datosProveedores.Tables("DatosProveedor").Rows(0).Item("Mail")
        ComboBox1.Text = datosProveedores.Tables("DatosProveedor").Rows(0).Item("EsActivo")

        For Each tel As DataRow In datosProveedores.Tables("DatosTelefono").Rows
            'ModificarUsuario.ListBox1.Items.Add(tel(0).ToString)
            ListBox1.Items.Add(tel(0).ToString)
        Next

        For Each tel As DataRow In datosProveedores.Tables("DatosDirecciones").Rows
            'ModificarUsuario.ListBox1.Items.Add(tel(0).ToString)
            ListBox2.Items.Add(tel(0).ToString)
        Next
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnModificarProveedor.Click
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        ComboBox1.Enabled = True
        btnAplicarCambios.Enabled = True
        ListBox1.Enabled = True
        ListBox2.Enabled = True
        btnAplicarCambios.Visible = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button9.Enabled = True
        Button10.Enabled = True

        btnModificarProveedor.Enabled = False
    End Sub

    'Modifico el Proveedor
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btnAplicarCambios.Click
        Dim datosProveedor As DataSet
        Dim proveedor As New BLL.Proveedor
        Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)
        Dim proveedorNombre As String = row.Cells(0).Value

        Dim seguridad As New BLL.Seguridad("Password")

        Dim prov As String = row.Cells(2).Value

        datosProveedor = proveedor.buscarProveedor(seguridad.Encriptar(Trim(proveedorNombre)))

        proveedor.idProveedor = datosProveedor.Tables("datosProveedor").Rows(0).Item("IdProveedor")

        ' Modificar El proveedor


        For Each tel As String In ListBox1.Items
            listaTelefonos.Add(seguridad.Encriptar(tel))
        Next

        For Each dir As String In ListBox2.Items
            listaDirecciones.Add(seguridad.Encriptar(dir))
        Next

        proveedor.EliminarTelefonos(proveedor.idProveedor)
        proveedor.AgregarTelefono(listaTelefonos, proveedor.idProveedor)

        proveedor.EliminarDirecciones(proveedor.idProveedor)
        proveedor.agregarDirecciones(proveedor.idProveedor, listaDirecciones)

        '''''''''''''''''''''''''''''''''''''''



        ''''''''''''''''''''''''''''''' Calculo el DVH ''''''''''''''''''''''''''''''' 
        Dim str As String
        datosProveedor = proveedor.buscarProveedor(seguridad.Encriptar(Trim(proveedorNombre)))


        ' LAMPA ARREGLAR , TRAE EL DATO ENCRIPTADO

        str = Trim(datosProveedor.Tables("DatosProveedor").Rows(0).Item("IdProveedor").ToString) +
            Trim(datosProveedor.Tables("DatosProveedor").Rows(0).Item("Nombre_Empresa").ToString) +
            Trim(datosProveedor.Tables("DatosProveedor").Rows(0).Item("Nombre_Contacto").ToString) +
            Trim(datosProveedor.Tables("DatosProveedor").Rows(0).Item("Apellido_Contacto").ToString) +
            Trim(datosProveedor.Tables("DatosProveedor").Rows(0).Item("Mail").ToString) +
            Trim(datosProveedor.Tables("DatosProveedor").Rows(0).Item("EsActivo").ToString)
        '+ Trim(datosProveedor.Tables("DatosProveedor").Rows(0).Item("DVH").ToString)

        Dim dvh As Integer
        dvh = seguridad.calcularDVH(str)

        'usuario.ModificarDVH(idUsuario, dvh, "Usuario", 0)
        seguridad.ModificarDVH(proveedor.idProveedor.ToString, dvh, "Proveedor", "IdProveedor")

        '''''''''''''''''''''''''''''''''   DVH   TELEFONOS  '''''''''''''''''''''''''''''''''

        'Obtengo telefonos de proveedores
        For Each tel As DataRow In datosProveedor.Tables("DatosTelefono").Rows
            str = Trim(proveedor.idProveedor.ToString) + tel.Item("Telefono").ToString + tel.Item("EsActivo").ToString
            dvh = seguridad.calcularDVH(str)
            'usuario.ModificarDVH(tel.Item("Telefono").ToString, dvh, "Telefono_Usuario", "IdTelefono")
            seguridad.ModificarDVH(tel.Item("Telefono").ToString, dvh, "Telefono_Proveedor", "telefono")
        Next



        ''  COMPLETAR --> falta el dvh de direcciones

        For Each dir As DataRow In datosProveedor.Tables("DatosDirecciones").Rows
            str = Trim(proveedor.idProveedor.ToString) + dir.Item("Direccion").ToString
            dvh = seguridad.calcularDVH(str)
            'usuario.ModificarDVH(tel.Item("Telefono").ToString, dvh, "Telefono_Usuario", "IdTelefono")
            seguridad.ModificarDVH(dir.Item("Direccion").ToString, dvh, "DireccionProveedores", "Direccion")
        Next

        ''

        '' Actualizo DVV proveedor
        seguridad.ActualizarDVV("Proveedor")

        ''Actualizo DVV Telefono_Proveedor
        seguridad.ActualizarDVV("Telefono_Proveedor")

        ''Actualizo DVV DireccionProveedores
        seguridad.ActualizarDVV("DireccionProveedores")

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'If (ComboBox1.Text <> estadoProveedorAnterior) Then
        '    If ComboBox1.Text = "N" Then
        '        seguridad.registrarBitacora(Login.ID_USUARIO, "MEDIA", DateTime.Now, "Inhabilitacón de proveedor", 0)
        '    Else
        '        seguridad.registrarBitacora(Login.ID_USUARIO, "MEDIA", DateTime.Now, "Habilitación de proveedor", 0)
        '    End If
        'End If

        seguridad.registrarBitacora(Login.ID_USUARIO, "MEDIA", DateTime.Now, "Modificación de proveedor " & TextBox1.Text, 0)

        If Login.ID_IDIOMA = 1 Then
            MessageBox.Show("Proveedor modificado correctamente")
        Else
            MessageBox.Show("Supplier modified correctly")
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        HelpProvider1.HelpNamespace = strHelp
        Help.ShowHelp(Me, HelpProvider1.HelpNamespace, HelpNavigator.TableOfContents)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Add(TextBox5.Text)
        TextBox5.Text = ""
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ListBox2.Items.Add(TextBox6.Text)
        TextBox6.Text = ""
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ListBox2.Items.Remove(ListBox2.SelectedItem)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub
End Class