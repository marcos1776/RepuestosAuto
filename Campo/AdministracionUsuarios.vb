Public Class AdministracionUsuarios

    Dim strHelp As String = Application.StartupPath & "\Ayuda\MenuUsuarios.chm"

    Dim _idUsuario As Integer
    Dim listaTelefonos As New List(Of String)
    Dim estadoUsuarioAnterior As String

    Private Property usuarios As DataTable
    Private Property inhabilitados As DataTable

    Private Sub AdministracionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Dim seguridad As New BLL.Seguridad("Password")
        Dim dtMensajes As New DataTable()
        dtMensajes = seguridad.ObtenerMensajes(Login.ID_IDIOMA, 2)

        If Login.ID_IDIOMA = 1 Then
            Me.Text = "Menu Usuarios"
        Else
            Me.Text = "User Menu"
            Me.LinkLabel1.Text = "Help"
            Button1.Text = "Print list"
        End If

        LblBuscar.Text = dtMensajes.Rows(0).Item(5).ToString
        lblUsuarios.Text = dtMensajes.Rows(1).Item(5).ToString
        lblDatosUsuario.Text = dtMensajes.Rows(2).Item(5).ToString
        lblNombre.Text = dtMensajes.Rows(3).Item(5).ToString
        lblApellido.Text = dtMensajes.Rows(4).Item(5).ToString
        lblNick.Text = dtMensajes.Rows(5).Item(5).ToString
        lblMail.Text = dtMensajes.Rows(6).Item(5).ToString
        lblDni.Text = dtMensajes.Rows(7).Item(5).ToString
        lblDomicilio.Text = dtMensajes.Rows(8).Item(5).ToString
        lblHabilitado.Text = dtMensajes.Rows(9).Item(5).ToString
        lblTelefonos.Text = dtMensajes.Rows(10).Item(5).ToString
        btnModificar.Text = dtMensajes.Rows(11).Item(5).ToString
        btnAplicar.Text = dtMensajes.Rows(12).Item(5).ToString
        btnCancelar.Text = dtMensajes.Rows(13).Item(5).ToString

        ' Si tiene la patente de modificar usuario que se habilite el combobox
        Dim dt As DataRow()
        dt = Login.dtPatentesUsuario.Select("Nombre='ModificarUsuario'")

        If (dt.Count > 0) Then
            btnModificar.Enabled = True
        End If

        cargarDataGrid()
    End Sub

    ' Boton Menu Principal
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub

    ' Boton alta Usuario
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'Me.Hide()
        AltaUsuario.Show()
    End Sub

    'Boton Inhabilitar Usuario
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Show()
        InhabilitacionUsuario.Show()
    End Sub

    'Llenado de grilla
    Public Sub cargarDataGrid()
        Dim ds As New DataSet
        Dim listadoUsuarios As New BLL.Listas
        ds = listadoUsuarios.obtenerUsuarios()

        If ds.Tables("DatosUsuario").Select().Count > 0 Then
            usuarios = ds.Tables("DatosUsuario").Select().CopyToDataTable
            DataGridView1.DataSource = usuarios

            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False

            If Login.ID_IDIOMA <> 1 Then
                DataGridView1.Columns(0).HeaderText = "Name"
                DataGridView1.Columns(1).HeaderText = "Surname"
                DataGridView1.Columns(2).HeaderText = "Nick"
            End If


        End If



        'If dt.Select("esActivo = 'N'").Count > 0 Then
        '    inhabilitados = dt.Select("esActivo = 'N'").CopyToDataTable
        'End If


        'DataGridView2.DataSource = inhabilitados




        'DataGridView2.Columns(3).Visible = False
        'DataGridView2.Columns(4).Visible = False
        'DataGridView2.Columns(5).Visible = False
        'DataGridView2.Columns(6).Visible = False

    End Sub

    'Boton Habilitar


    'Boton Modificar Usuario
    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    Dim datosUsuario As New DataSet
    '    Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
    '    Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)

    '    Dim seguridad As New BLL.Seguridad("Password")

    '    Dim user As String = row.Cells(2).Value
    '    Dim usuario As New BLL.Administrador

    '    'Traigo datos de usuario y telefonos.
    '    datosUsuario = usuario.BuscarUsuario(seguridad.Encriptar(Trim(user)))

    '    Dim ModificarUsuario As New ModificarUsuario
    '    ModificarUsuario.Show()
    '    'Me.Close()

    '    ModificarUsuario.idUsuario = datosUsuario.Tables("DatosUsuario").Rows(0).Item("idUsuario")

    '    ModificarUsuario.TextBox1.Text = datosUsuario.Tables("DatosUsuario").Rows(0).Item("Nombre")
    '    ModificarUsuario.TextBox2.Text = datosUsuario.Tables("DatosUsuario").Rows(0).Item("Apellido")
    '    ModificarUsuario.TextBox3.Text = datosUsuario.Tables("DatosUsuario").Rows(0).Item("Dni")
    '    ModificarUsuario.TextBox4.Text = datosUsuario.Tables("DatosUsuario").Rows(0).Item("Mail")
    '    ModificarUsuario.TextBox5.Text = datosUsuario.Tables("DatosUsuario").Rows(0).Item("Domicilio")

    '    For Each tel As DataRow In datosUsuario.Tables("DatosTelefono").Rows
    '        ModificarUsuario.ListBox1.Items.Add(tel(0).ToString)
    '    Next

    'End Sub

    'Filtrar por el texto HABILITADOS
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        Dim dataview As New DataView(usuarios)

        dataview.RowFilter = "Nombre like '%" + TextBox10.Text + "%'" +
        "OR Apellido like '%" + TextBox10.Text + "%'" +
        "OR Nick like '%" + TextBox10.Text + "%'"

        DataGridView1.DataSource = dataview
    End Sub


    'Cuando seleccione el usuario se me carga la data
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        ComboBox1.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        btnAplicar.Visible = False


        ListBox1.Items.Clear()
        Dim datosUsuario As New DataSet
        Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)

        Dim seguridad As New BLL.Seguridad("Password")

        Dim user As String = row.Cells(2).Value
        Dim usuario As New BLL.Administrador

        'Traigo datos de usuario y telefonos.
        datosUsuario = usuario.BuscarUsuario(seguridad.Encriptar(Trim(user)))

        TextBox6.Text = datosUsuario.Tables("DatosUsuario").Rows(0).Item("Domicilio")
        TextBox4.Text = datosUsuario.Tables("DatosUsuario").Rows(0).Item("Mail")
        TextBox5.Text = datosUsuario.Tables("DatosUsuario").Rows(0).Item("Dni")
        TextBox1.Text = datosUsuario.Tables("DatosUsuario").Rows(0).Item("Nombre")
        TextBox2.Text = datosUsuario.Tables("DatosUsuario").Rows(0).Item("Apellido")
        TextBox3.Text = datosUsuario.Tables("DatosUsuario").Rows(0).Item("Nick")
        ComboBox1.Text = datosUsuario.Tables("DatosUsuario").Rows(0).Item("EsActivo")

        For Each tel As DataRow In datosUsuario.Tables("DatosTelefono").Rows
            'ModificarUsuario.ListBox1.Items.Add(tel(0).ToString)
            ListBox1.Items.Add(tel(0).ToString)
        Next


        'For Each tel As DataRow In datosUsuario.Tables("DatosTelefono").Rows
        '    ModificarUsuario.ListBox1.Items.Add(tel(0).ToString)
        'Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If (TextBox1.Text = "") Then
            If (Login.ID_IDIOMA = 1) Then
                MessageBox.Show("Por favor seleccione un usuario")
            Else
                MessageBox.Show("Please select an user")
            End If

        Else
            Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex

            estadoUsuarioAnterior = ComboBox1.Text

            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            ComboBox1.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
            btnAplicar.Visible = True
            btnAplicar.Enabled = True
            ListBox1.Enabled = True
            btnModificar.Enabled = False
        End If
    End Sub

    'Modifico el User
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)

        If (validarConsistencia) Then

            Dim seguridad As New BLL.Seguridad("Password")
            Dim user As String = row.Cells(2).Value
            'If (seguridad.validarConsistencia(Me) And TextBox7.Text = "") Then
            Dim valid As Boolean = True
            If (Trim(ComboBox1.Text) = "N") Then
                valid = seguridad.ValidarPatentesUsuario(seguridad.Encriptar(Trim(user)))
            Else

            End If

            If (valid) Then
                Dim usuario As New BLL.Administrador

                Dim datosUsuario As New DataSet

                datosUsuario = usuario.BuscarUsuario(seguridad.Encriptar(Trim(user)))
                usuario._idUsuario = datosUsuario.Tables("DatosUsuario").Rows(0).Item("idUsuario")

                usuario._nombre = seguridad.Encriptar(TextBox1.Text)
                usuario._apellido = seguridad.Encriptar(TextBox2.Text)
                usuario._nick = seguridad.Encriptar(TextBox3.Text)
                usuario._mail = seguridad.Encriptar(TextBox4.Text)
                usuario._dni = seguridad.Encriptar(TextBox5.Text)
                usuario._domicilio = seguridad.Encriptar(TextBox6.Text)
                usuario._esActivo = ComboBox1.Text

                'Modifico el Usuario
                usuario.modificarUsuario(usuario, usuario._idUsuario)


                For Each tel As String In ListBox1.Items
                    listaTelefonos.Add(seguridad.Encriptar(tel))
                Next

                usuario.EliminarTelefonos(usuario._idUsuario)
                usuario.AgregarTelefono(listaTelefonos, usuario._idUsuario)
                '''''''''''''''''''''''''''''''''''''''

                'Busco usuario y Calculo DVH Usuarios
                Dim us As DataSet
                Dim str As String

                ''''''''''''''''''''''''''''''' Calculo el DVH ''''''''''''''''''''''''''''''' 
                us = usuario.BuscarUsuarioEncriptado(usuario._idUsuario)
                str = Trim(us.Tables("DatosUsuario").Rows(0).Item("IdUsuario").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Nombre").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Apellido").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Nick").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Contraseña").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Domicilio").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Mail").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Dni").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("EsActivo").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("LoginFallos").ToString)
                Dim dvh As Integer
                dvh = seguridad.calcularDVH(str)

                'usuario.ModificarDVH(idUsuario, dvh, "Usuario", 0)
                seguridad.ModificarDVH(usuario._idUsuario.ToString, dvh, "Usuario", "IdUsuario")
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                'Obtengo telefonos de usuarios
                For Each tel As DataRow In us.Tables("DatosTelefono").Rows
                    str = Trim(usuario._idUsuario.ToString) + Trim(tel.Item("Telefono").ToString) + Trim(tel.Item("EsActivo").ToString)
                    dvh = seguridad.calcularDVH(str)
                    'usuario.ModificarDVH(tel.Item("Telefono").ToString, dvh, "Telefono_Usuario", "IdTelefono")
                    seguridad.ModificarDVH(tel.Item("Telefono").ToString, dvh, "Telefono_Usuario", "telefono")
                Next
                ''''''''''



                '' Actualizo DVV usuario
                seguridad.ActualizarDVV("Usuario")

                ''Actualizo DVV telefono_usuario
                seguridad.ActualizarDVV("Telefono_Usuario")

                ' REGISTRO EN BITACORA
                If (ComboBox1.Text = estadoUsuarioAnterior) Then
                    seguridad.registrarBitacora(Login.ID_USUARIO, "BAJA", DateTime.Now, "Modificación Usuario", 0)
                Else
                    If ComboBox1.Text = "N" Then
                        seguridad.registrarBitacora(Login.ID_USUARIO, "ALTA", DateTime.Now, "Inhabilitacón de Usuario", 0)
                    Else
                        seguridad.registrarBitacora(Login.ID_USUARIO, "ALTA", DateTime.Now, "Habilitación de Usuario", 0)
                    End If

                    seguridad.registrarBitacora(Login.ID_USUARIO, "BAJA", DateTime.Now, "Modificación Usuario", 0)
                End If


                If Login.ID_IDIOMA = 1 Then
                    MessageBox.Show("Usuario modificado correctamente")
                Else
                    MessageBox.Show("User modified correctly")
                End If
            Else
                MessageBox.Show("El usuario no puede ser inhabilitado porque tiene patentes esenciales.")
                Return

            End If

        Else
            If Login.ID_IDIOMA = 1 Then
                MessageBox.Show("Por favor complete los campos.")
            Else
                MessageBox.Show("Please check blanck fields.")
            End If
        End If

    End Sub

    Private Function validarConsistencia() As Boolean
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Add(TextBox7.Text)
        TextBox7.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    'Ayuda
    Private Sub AdministracionUsuarios_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        HelpProvider1.HelpNamespace = strHelp

        If e.KeyValue = Keys.F1 Then
            Help.ShowHelp(Me, HelpProvider1.HelpNamespace, HelpNavigator.TableOfContents)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        HelpProvider1.HelpNamespace = strHelp
        Help.ShowHelp(Me, HelpProvider1.HelpNamespace, HelpNavigator.TableOfContents)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'e.Handled = aceptaLetras(e.KeyChar)
        Dim bll As New BLL.Seguridad("Password")
        e.Handled = bll.aceptaLetras(e.KeyChar)

        If (e.Handled) Then
            Dim tt As New ToolTip()
            Dim VisibleTime As Integer = 1000
            tt.Show(Login.tooltipLetra, TextBox1, 0, 0, VisibleTime)
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        'e.Handled = aceptaLetras(e.KeyChar)
        Dim bll As New BLL.Seguridad("Password")
        e.Handled = bll.aceptaLetras(e.KeyChar)

        If (e.Handled) Then
            Dim tt As New ToolTip()
            Dim VisibleTime As Integer = 1000
            tt.Show(Login.tooltipLetra, TextBox2, 0, 0, VisibleTime)
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        'e.Handled = aceptaLetras(e.KeyChar)
        Dim bll As New BLL.Seguridad("Password")
        e.Handled = bll.aceptaLetras(e.KeyChar)

        If (e.Handled) Then
            Dim tt As New ToolTip()
            Dim VisibleTime As Integer = 1000
            tt.Show(Login.tooltipLetra, TextBox3, 0, 0, VisibleTime)
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        'e.Handled = aceptaLetras(e.KeyChar)
        Dim bll As New BLL.Seguridad("Password")
        e.Handled = bll.aceptaLetras(e.KeyChar)

        If (e.Handled) Then
            Dim tt As New ToolTip()
            Dim VisibleTime As Integer = 1000
            tt.Show(Login.tooltipLetra, TextBox5, 0, 0, VisibleTime)
        End If
    End Sub

End Class