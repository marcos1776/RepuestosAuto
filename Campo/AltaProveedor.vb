Public Class AltaProveedor

    Dim strHelp As String = Application.StartupPath & "\Ayuda\AltaProveedor.chm"
    Dim listaTelefonos As New List(Of String)
    Dim listaDirecciones As New List(Of String)


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    'Alta Proveedor 
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnAgregarProv.Click
        If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "") Then
            If Login.ID_IDIOMA = 1 Then
                MessageBox.Show("Por favor complete los campos")
            Else
                MessageBox.Show("Please complete black fields")
            End If
            Return
        End If

            Dim idProveedor As New Integer
        Dim seguridad As New BLL.Seguridad("Password")

        Dim proveedor As New BLL.Proveedor(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)


        proveedor.nombre_empresa = seguridad.Encriptar(TextBox1.Text)
        proveedor.nombre_contacto = seguridad.Encriptar(TextBox2.Text)
        proveedor.apellido_contacto = seguridad.Encriptar(TextBox3.Text)
        proveedor.email = seguridad.Encriptar(TextBox4.Text)


        idProveedor = proveedor.altaProveedor(proveedor)

        For Each numero As String In ListBox1.Items
            listaTelefonos.Add(seguridad.Encriptar(numero))
        Next

        For Each dir As String In ListBox2.Items
            listaDirecciones.Add(seguridad.Encriptar(dir))
        Next

        'Agrego Telefonos
        If listaTelefonos.Count > 0 Then
            proveedor.AgregarTelefono(idProveedor, listaTelefonos)
        End If

        If listaDirecciones.Count > 0 Then
            proveedor.agregarDirecciones(idProveedor, listaDirecciones)
        End If



        'Calculo el DVH
        Dim pr As DataSet
        pr = proveedor.BuscarProveedorEncriptado(idProveedor)

        Dim str As String
        str = Trim(pr.Tables("DatosProveedor").Rows(0).Item("IdProveedor").ToString) + Trim(pr.Tables("DatosProveedor").Rows(0).Item("Nombre_Empresa").ToString) + Trim(pr.Tables("DatosProveedor").Rows(0).Item("Nombre_Contacto").ToString) + Trim(pr.Tables("DatosProveedor").Rows(0).Item("Apellido_Contacto").ToString) + Trim(pr.Tables("DatosProveedor").Rows(0).Item("Mail").ToString) + Trim(pr.Tables("DatosProveedor").Rows(0).Item("EsActivo").ToString)
        Dim dvh As Integer
        dvh = seguridad.calcularDVH(str)


        seguridad.ModificarDVH(idProveedor, dvh, "Proveedor", "IdProveedor")

        '' Actualizo DVV proveedor
        seguridad.ActualizarDVV("Proveedor")
        '''''''''''''''''''''''''''''''''

        'Calcular DVH de telefonos

        For Each tel As DataRow In pr.Tables("DatosTelefono").Rows
            str = Trim(idProveedor.ToString) + tel.Item("Telefono").ToString + tel.Item("EsActivo").ToString
            dvh = seguridad.calcularDVH(str)
            seguridad.ModificarDVH(tel.Item("Telefono").ToString, dvh, "Telefono_Proveedor", "telefono")

            ''Actualizo DVV Telefono_Proveedor
            seguridad.ActualizarDVV("Telefono_Proveedor")
        Next

        '''''''''''''''''''''''''''''''''''''''

        'Calculo los DVH de las direcciones
        For Each dir As DataRow In pr.Tables("DatosDireccion").Rows
            str = Trim(idProveedor.ToString) + dir.Item("Direccion").ToString
            dvh = seguridad.calcularDVH(str)
            seguridad.ModificarDVH(dir.Item("Direccion").ToString, dvh, "direccionProveedores", "Direccion")

            ''Actualizo DVV DireccionProveedores
            seguridad.ActualizarDVV("DireccionProveedores")
        Next


        seguridad.registrarBitacora(Login.ID_USUARIO, "BAJA", DateTime.Now, "Alta de proveedor " + TextBox1.Text, 0)

        If Login.ID_IDIOMA = 1 Then
            MessageBox.Show("Proveedor creado correctamente")
        Else
            MessageBox.Show("Supplier added correctly")
        End If

        Me.Close()
        Dim form As New AdministracionProveedores
        form.Show()
    End Sub


    'Agrego Telefonos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAñadirTel.Click
        ListBox1.Items.Add(TextBox5.Text)
    End Sub

    'Borro Telefonos  
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnQuitarTel.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    'Agrego Direccion
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAñadirDirec.Click
        ListBox2.Items.Add(TextBox6.Text)
    End Sub

    'Borro Direccion 
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnBorrarDirec.Click
        ListBox2.Items.Remove(ListBox2.SelectedItem)
    End Sub

    Private Sub AltaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle

        If Login.ID_IDIOMA = 1 Then
            Me.Text = "Nuevo Proveedor"
        Else
            Me.Text = "New Supplier"
            Me.LinkLabel1.Text = "Help"
        End If


        Dim seguridad As New BLL.Seguridad("Password")
        Dim dtMensajes As New DataTable()
        dtMensajes = seguridad.ObtenerMensajes(Login.ID_IDIOMA, 6)


        lblNombreEmpresa.Text = dtMensajes.Rows(0).Item(5).ToString
        lblNombreContacto.Text = dtMensajes.Rows(1).Item(5).ToString
        lblApellidoContacto.Text = dtMensajes.Rows(2).Item(5).ToString
        lblMail.Text = dtMensajes.Rows(3).Item(5).ToString
        lblTelefonos.Text = dtMensajes.Rows(4).Item(5).ToString
        'btnAñadirTel.Text = dtMensajes.Rows(5).Item(5).ToString
        'btnQuitarTel.Text = dtMensajes.Rows(6).Item(5).ToString
        lblDirecc.Text = dtMensajes.Rows(7).Item(5).ToString
        'btnAñadirDirec.Text = dtMensajes.Rows(8).Item(5).ToString
        'btnBorrarDirec.Text = dtMensajes.Rows(9).Item(5).ToString
        btnCancel.Text = dtMensajes.Rows(10).Item(5).ToString
        btnAgregarProv.Text = dtMensajes.Rows(11).Item(5).ToString



    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim bll As New BLL.Seguridad("Password")
        e.Handled = bll.aceptaLetras(e.KeyChar)

        If (e.Handled) Then
            Dim tt As New ToolTip()
            Dim VisibleTime As Integer = 1000
            tt.Show(Login.tooltipLetra, TextBox2, 0, 0, VisibleTime)
        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        Dim bll As New BLL.Seguridad("Password")
        e.Handled = bll.aceptaLetras(e.KeyChar)

        If (e.Handled) Then
            Dim tt As New ToolTip()
            Dim VisibleTime As Integer = 1000
            tt.Show(Login.tooltipLetra, TextBox3, 0, 0, VisibleTime)
        End If
    End Sub




    'Actualizar listbox
    'Public Sub actualizarListBox()
    '    ListBox1.Items.Clear()
    '    For Each numero As Integer In listaTelefonos
    '        ListBox1.Items.Add(numero)
    '    Next

    '    ListBox2.Items.Clear()
    '    For Each dir As String In listaDirecciones
    '        ListBox2.Items.Add(dir)
    '    Next
    'End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        HelpProvider1.HelpNamespace = strHelp
        Help.ShowHelp(Me, HelpProvider1.HelpNamespace, HelpNavigator.TableOfContents)
    End Sub
End Class