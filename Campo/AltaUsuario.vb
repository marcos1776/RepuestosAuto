Imports System.Text.RegularExpressions

Public Class AltaUsuario
    Dim strHelp As String = Application.StartupPath & "\Ayuda\AltaUsuario.chm"

    Dim listaTelefonos As New List(Of String)

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    ' Agregar Usuario
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAgregarUsu.Click
        Dim seguridad As New BLL.Seguridad("Password")

        If (validarConsistencia) Then
            Dim usuario As New BLL.Administrador(TextBox1.Text, TextBox2.Text, TextBox4.Text, TextBox3.Text, TextBox5.Text, TextBox6.Text)

            'Generar Archivo Txt Con contraseña y Actualizar  Contraseña
            usuario._contraseña = seguridad.generarContraseñaAleatoria(TextBox1.Text, TextBox2.Text, TextBox3.Text)

            ''''''''''''''''''''''''
            usuario._nombre = seguridad.Encriptar(Trim(TextBox1.Text))
            usuario._apellido = seguridad.Encriptar(Trim(TextBox2.Text))
            usuario._nick = seguridad.Encriptar(Trim(TextBox3.Text))
            usuario._dni = seguridad.Encriptar(Trim(TextBox4.Text))
            usuario._mail = seguridad.Encriptar(Trim(TextBox5.Text))
            usuario._domicilio = seguridad.Encriptar(Trim(TextBox6.Text))

            For Each tel As String In ListBox1.Items
                listaTelefonos.Add(seguridad.Encriptar(tel))
            Next

            'Añado el usuario en la base de datos
            Dim idUsuario As New Integer
            idUsuario = usuario.añadirUsuario(usuario)

            ' Añadir Telefonos
            usuario.AgregarTelefono(listaTelefonos, idUsuario)
            listaTelefonos.Clear()

            'Busco usuario y Calculo DVH Usuarios
            Dim us As DataSet
            Dim str As String

            ''''''''''''''''''''''''''''''' Calculo el DVH ''''''''''''''''''''''''''''''' 
            us = usuario.BuscarUsuarioEncriptado(idUsuario)
            str = Trim(us.Tables("DatosUsuario").Rows(0).Item("IdUsuario").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Nombre").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Apellido").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Nick").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Contraseña").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Domicilio").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Mail").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Dni").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("EsActivo").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("LoginFallos").ToString)
            Dim dvh As Integer
            dvh = seguridad.calcularDVH(str)

            'usuario.ModificarDVH(idUsuario, dvh, "Usuario", 0)
            seguridad.ModificarDVH(idUsuario.ToString, dvh, "Usuario", "IdUsuario")
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '' Actualizo DVV usuario
            seguridad.ActualizarDVV("Usuario")

            'Obtengo telefonos de usuarios
            For Each tel As DataRow In us.Tables("DatosTelefono").Rows
                str = Trim(idUsuario.ToString) + tel.Item("Telefono").ToString + tel.Item("EsActivo").ToString
                dvh = seguridad.calcularDVH(str)
                'usuario.ModificarDVH(tel.Item("Telefono").ToString, dvh, "Telefono_Usuario", "IdTelefono")
                seguridad.ModificarDVH(tel.Item("Telefono").ToString, dvh, "Telefono_Usuario", "telefono")

                ''Actualizo DVV telefono_usuario
                seguridad.ActualizarDVV("Telefono_Usuario")
            Next
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''





            'Registro en Bitacora
            seguridad.registrarBitacora(Login.ID_USUARIO, "MEDIA", DateTime.Now, "Alta de usuario", 0)

            '

            If Login.ID_IDIOMA = 1 Then
                MessageBox.Show("Usuario creado correctamente")
            Else
                MessageBox.Show("User added correctly")
            End If

            Dim form As New AdministracionUsuarios
            form.Show()
            Me.Close()
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

    'Agrego Telefonos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAñadirTel.Click
        ListBox1.Items.Add(TextBox7.Text)
    End Sub

    'Borro Telefonos
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBorrarTel.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub AltaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim seguridad As New BLL.Seguridad("Password")
        Dim dtMensajes As New DataTable()
        dtMensajes = seguridad.ObtenerMensajes(Login.ID_IDIOMA, 3)

        If Login.ID_IDIOMA = 1 Then
            Me.Text = "Alta Usuario"
        Else
            Me.Text = "Add User"
            Me.LinkLabel1.Text = "Help"
        End If


        lblNombre.Text = dtMensajes.Rows(0).Item(5).ToString
        lblApellido.Text = dtMensajes.Rows(1).Item(5).ToString
        lblUsuario.Text = dtMensajes.Rows(2).Item(5).ToString
        lblDni.Text = dtMensajes.Rows(3).Item(5).ToString
        lblMail.Text = dtMensajes.Rows(4).Item(5).ToString
        lblDireccion.Text = dtMensajes.Rows(5).Item(5).ToString
        lblTelefonos.Text = dtMensajes.Rows(6).Item(5).ToString
        'btnAñadirTel.Text = dtMensajes.Rows(7).Item(5).ToString
        'btnBorrarTel.Text = dtMensajes.Rows(8).Item(5).ToString
        btnAgregarUsu.Text = dtMensajes.Rows(9).Item(5).ToString
        btnCancel.Text = dtMensajes.Rows(10).Item(5).ToString

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'e.Handled = aceptaLetras(e.KeyChar)
        Dim bll As New BLL.Seguridad("Password")
        e.Handled = bll.aceptaLetras(e.KeyChar)
        Dim msj As String

        If Login.ID_IDIOMA = 1 Then
            msj = "Ingrese solo letras"
        Else
            msj = "Insert only letters"
        End If

        If (e.Handled) Then
            Dim tt As New ToolTip()
            Dim VisibleTime As Integer = 1000
            tt.Show(msj, TextBox1, 0, 0, VisibleTime)
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim bll As New BLL.Seguridad("Password")
        e.Handled = bll.aceptaLetras(e.KeyChar)

        Dim msj As String

        If Login.ID_IDIOMA = 1 Then
            msj = "Ingrese solo letras"
        Else
            msj = "Insert only letters"
        End If

        If (e.Handled) Then
            Dim tt As New ToolTip()
            Dim VisibleTime As Integer = 1000
            tt.Show("Ingrese solo letras", TextBox2, 0, 0, VisibleTime)
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        Dim bll As New BLL.Seguridad("Password")
        e.Handled = bll.aceptaLetras(e.KeyChar)

        Dim msj As String

        If Login.ID_IDIOMA = 1 Then
            msj = "Ingrese solo letras"
        Else
            msj = "Insert only letters"
        End If

        If (e.Handled) Then
            Dim tt As New ToolTip()
            Dim VisibleTime As Integer = 1000
            tt.Show("Ingrese solo letras", TextBox3, 0, 0, VisibleTime)
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        Dim bll As New BLL.Seguridad("Password")
        e.Handled = bll.aceptaNumeros(e.KeyChar)

        Dim msj As String

        If Login.ID_IDIOMA = 1 Then
            msj = "Ingrese solo numeros"
        Else
            msj = "Insert only numbers"
        End If

        If (e.Handled) Then
            Dim tt As New ToolTip()
            Dim VisibleTime As Integer = 1000
            tt.Show("Ingrese solo numeros", TextBox4, 0, 0, VisibleTime)
        End If
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


End Class
