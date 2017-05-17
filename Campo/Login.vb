Public Class Login
    Public Shared ID_USUARIO As Integer
    ' 1 español --- 2 Ingles
    Public Shared ID_IDIOMA As Integer

    Public Shared dtPatentesUsuario As New DataTable
    Public Shared NombreUsuario As String



    'Recuperar Contraseña
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rec As New RecuperarContraseña
        rec.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        'TextBox1.Text = "ccc"
        'TextBox2.Text = "aaabbb123"
        TextBox1.Text = "test"
        TextBox2.Text = "testes123"
    End Sub

    'Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim seguridad As New BLL.Seguridad("Password")
        Dim interval As Integer = 3000

        Dim usuarioEncontrado As Boolean = False

        If (ComboBox1.Text = "Español") Then
            ID_IDIOMA = 1
        Else
            ID_IDIOMA = 2
        End If

        'Validar usuario y contraseña
        Dim admin As New BLL.Administrador
        ID_USUARIO = admin.ValidarUsuario(TextBox1.Text, TextBox2.Text)

        If ID_USUARIO <> -1 Then
            usuarioEncontrado = True

            cargarPatentesUsuario()
            If (seguridad.ValidarDVV) Then

                If (seguridad.validarDVH) Then

                    Me.NombreUsuario = TextBox1.Text

                    Dim idBitacora As Integer = seguridad.registrarBitacora(ID_USUARIO, "BAJA", DateTime.Now, "Logueo correcto", 0)
                    Dim ds As New DataTable
                    Dim str As String
                    ''''''''''''''''''''''''''''''' Calculo el DVH ''''''''''''''''''''''''''''''' 
                    ds = seguridad.buscarRegistroBitacora(idBitacora)
                    'usuario.BuscarUsuarioEncriptado(idUsuario)
                    str = Trim(ds.Rows(0).Item("IdBitacora").ToString) + Trim(ds.Rows(0).Item("IdUsuario").ToString) + Trim(ds.Rows(0).Item("Criticidad").ToString) + Trim(ds.Rows(0).Item("Fecha").ToString) + Trim(ds.Rows(0).Item("Descripcion").ToString) + ds.Rows(0).Item("DVH").ToString
                    Dim dvh As Integer
                    dvh = seguridad.calcularDVH(str)

                    'usuario.ModificarDVH(idUsuario, dvh, "Usuario", 0)
                    seguridad.ModificarDVH(idBitacora, dvh, "Bitacora", "IdBitacora")
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                    If (ComboBox1.Text = "Español") Then
                        'MessageBox.Show("¡ Bienvenido !")
                        MenuPrincipal.ToolStripStatusLabel2.Text = "Bienvenido " + TextBox1.Text + " !"
                    Else
                        'MessageBox.Show("¡ Welcome !")
                        MenuPrincipal.ToolStripStatusLabel2.Text = "Welcome " + TextBox1.Text + " !"
                    End If

                    Me.Hide()


                Else
                    'Si no valida los DVH entonces si tiene la patente de restore , que acceda al sistema.


                End If
            Else


            End If


        Else
                MessageBox.Show("Error de Login")

        End If

    End Sub


    Private Sub cargarPatentesUsuario()
        Dim seguridad As New BLL.Seguridad("Password")


        'validacionDVH = True
        'Se validan LOS DVH

        Dim men As New BLL.Seguridad("Password")


        '' Obtengo las patentes del usuario
        dtPatentesUsuario = seguridad.ObtenerPatentesDeUsuario(ID_USUARIO)


        '''
        '' Si no tiene ninguna patente de usuario deshabilito el boton
        For i = 0 To dtPatentesUsuario.Rows.Count - 1
            Dim enc As Integer
            MenuPrincipal.Show()
            MenuPrincipal.ModificarContraseñarToolStripMenuItem.Visible = True


            If dtPatentesUsuario.Rows(i).Item(3).ToString = "1" Then
                MenuPrincipal.UsuariosToolStripMenuItem.Visible = True
                MenuPrincipal.NuevoUsuarioToolStripMenuItem.Visible = True
            End If

            If dtPatentesUsuario.Rows(i).Item(3).ToString = "2" Or dtPatentesUsuario.Rows(i).Item(3).ToString = "3" Or dtPatentesUsuario.Rows(i).Item(3).ToString = "4" Then
                MenuPrincipal.UsuariosToolStripMenuItem.Visible = True
                MenuPrincipal.AdministrarUsuarioToolStripMenuItem.Visible = True
                MenuPrincipal.ReporteUsuariosToolStripMenuItem.Visible = True
            End If


            If dtPatentesUsuario.Rows(i).Item(3).ToString = "5" Then
                MenuPrincipal.ProveedoresToolStripMenuItem.Visible = True
                MenuPrincipal.NuevoProveedorToolStripMenuItem.Visible = True
            End If

            If dtPatentesUsuario.Rows(i).Item(3).ToString = "6" Or dtPatentesUsuario.Rows(i).Item(3).ToString = "7" Or dtPatentesUsuario.Rows(i).Item(3).ToString = "8" Then
                MenuPrincipal.ProveedoresToolStripMenuItem.Visible = True
                MenuPrincipal.AdministrarProveedoresToolStripMenuItem.Visible = True
            End If

            If dtPatentesUsuario.Rows(i).Item(3).ToString = "9" Or dtPatentesUsuario.Rows(i).Item(3).ToString = "10" Or dtPatentesUsuario.Rows(i).Item(3).ToString = "12" Then
                MenuPrincipal.SeguridadToolStripMenuItem.Visible = True
                MenuPrincipal.CrearFamiliaToolStripMenuItem.Visible = True
            End If


            If dtPatentesUsuario.Rows(i).Item(3).ToString = "13" Then
                MenuPrincipal.VentaToolStripMenuItem.Visible = True
                MenuPrincipal.AdministrarPresupuestoToolStripMenuItem.Visible = True
                MenuPrincipal.NuevoPresupuestoToolStripMenuItem.Visible = True
                MenuPrincipal.NuevaVentaToolStripMenuItem.Visible = True
            End If

            If dtPatentesUsuario.Rows(i).Item(3).ToString = "14" Or dtPatentesUsuario.Rows(i).Item(3).ToString = "15" Then
                MenuPrincipal.VentaToolStripMenuItem.Visible = True
                MenuPrincipal.AdministrarVentasToolStripMenuItem.Visible = True
            End If

            If dtPatentesUsuario.Rows(i).Item(3).ToString = "16" Then
                MenuPrincipal.VentaToolStripMenuItem.Visible = True
                MenuPrincipal.NuevaVentaToolStripMenuItem.Visible = True
            End If

            If dtPatentesUsuario.Rows(i).Item(3).ToString = "17" Then
                MenuPrincipal.ComprasToolStripMenuItem.Visible = True
                MenuPrincipal.AdministrarPedidosToolStripMenuItem.Visible = True
                MenuPrincipal.NuevoPedidoToolStripMenuItem.Visible = True
            End If

            If dtPatentesUsuario.Rows(i).Item(3).ToString = "18" Or dtPatentesUsuario.Rows(i).Item(3).ToString = "19" Or dtPatentesUsuario.Rows(i).Item(3).ToString = "20" Then
                MenuPrincipal.ComprasToolStripMenuItem.Visible = True
                MenuPrincipal.AdministrarPedidosToolStripMenuItem.Visible = True
            End If

            If dtPatentesUsuario.Rows(i).Item(3).ToString = "21" Then
                MenuPrincipal.ArticulosToolStripMenuItem.Visible = True
                MenuPrincipal.NuevoArticuloToolStripMenuItem.Visible = True
                MenuPrincipal.CargarArticulosDesdeArchivoToolStripMenuItem.Visible = True
            End If

            If dtPatentesUsuario.Rows(i).Item(3).ToString = "22" Then
                MenuPrincipal.ArticulosToolStripMenuItem.Visible = True
                MenuPrincipal.CorregirStockToolStripMenuItem.Visible = True
            End If


            If dtPatentesUsuario.Rows(i).Item(3).ToString = "23" Then
                MenuPrincipal.ArticulosToolStripMenuItem.Visible = True
                MenuPrincipal.AdministrarArticulosToolStripMenuItem.Visible = True
            End If


            If dtPatentesUsuario.Rows(i).Item(3).ToString = "24" Or dtPatentesUsuario.Rows(i).Item(3).ToString = "25" Then
                MenuPrincipal.UtilidadesToolStripMenuItem.Visible = True
                MenuPrincipal.BackUpRestoreToolStripMenuItem.Visible = True
            End If

            If dtPatentesUsuario.Rows(i).Item(3).ToString = "24" Then
                MenuPrincipal.BackupToolStripMenuItem.Visible = True
            End If

            If dtPatentesUsuario.Rows(i).Item(3).ToString = "25" Then
                MenuPrincipal.RestoreToolStripMenuItem.Visible = True
            End If


            If dtPatentesUsuario.Rows(i).Item(3).ToString = "26" Then
                MenuPrincipal.UtilidadesToolStripMenuItem.Visible = True
                MenuPrincipal.ConsultarBitacoraToolStripMenuItem.Visible = True
            End If

            If dtPatentesUsuario.Rows(i).Item(3).ToString = "27" Then
                MenuPrincipal.ReporteToolStripMenuItem.Visible = True
                MenuPrincipal.ReporteVentasToolStripMenuItem.Visible = True
                MenuPrincipal.ReporteVentaSimpleToolStripMenuItem.Visible = True
            End If

            If dtPatentesUsuario.Rows(i).Item(3).ToString = "28" Then
                MenuPrincipal.ReporteToolStripMenuItem.Visible = True
                MenuPrincipal.ReportePedidoEspecificoToolStripMenuItem.Visible = True
                MenuPrincipal.ReporteListadoComprasToolStripMenuItem.Visible = True
            End If

            If dtPatentesUsuario.Rows(i).Item(3).ToString = "29" Then
                MenuPrincipal.VentaToolStripMenuItem.Visible = True
                MenuPrincipal.AdministrarPresupuestoToolStripMenuItem.Visible = True
            End If

            If dtPatentesUsuario.Rows(i).Item(3).ToString = "30" Then
                MenuPrincipal.ArticulosToolStripMenuItem.Visible = True
                MenuPrincipal.CorregirStockToolStripMenuItem.Visible = True
            End If

            If dtPatentesUsuario.Rows(i).Item(3).ToString = "31" Then
                MenuPrincipal.SeguridadToolStripMenuItem.Visible = True
                MenuPrincipal.AsignarPatentesToolStripMenuItem1.Visible = True
            End If


        Next

        If Login.ID_IDIOMA <> 1 Then
            MenuPrincipal.MenuToolStripMenuItem.Text = "Menu"
            MenuPrincipal.CerrarSesiónToolStripMenuItem.Text = "Close Application"

            MenuPrincipal.UsuariosToolStripMenuItem.Text = "Users"
            MenuPrincipal.AdministrarUsuarioToolStripMenuItem.Text = "Users Menu"
            MenuPrincipal.NuevoUsuarioToolStripMenuItem.Text = "New User"

            MenuPrincipal.ProveedoresToolStripMenuItem.Text = "Suppliers"
            MenuPrincipal.AdministrarProveedoresToolStripMenuItem.Text = "Suppliers Menu"
            MenuPrincipal.NuevoProveedorToolStripMenuItem.Text = "New Supplier"

            MenuPrincipal.ArticulosToolStripMenuItem.Text = "Articles"
            MenuPrincipal.AdministrarArticulosToolStripMenuItem.Text = "Articles Menu"
            MenuPrincipal.NuevoArticuloToolStripMenuItem.Text = "New Article"
            MenuPrincipal.CargarArticulosDesdeArchivoToolStripMenuItem.Text = "Load articles from file"
            MenuPrincipal.CorregirStockToolStripMenuItem.Text = "Correct Stock"

            MenuPrincipal.ComprasToolStripMenuItem.Text = "Orders"
            MenuPrincipal.AdministrarPedidosToolStripMenuItem.Text = "Orders Menu"
            MenuPrincipal.NuevoPedidoToolStripMenuItem.Text = "New order"

            MenuPrincipal.VentaToolStripMenuItem.Text = "Sales"
            MenuPrincipal.AdministrarVentasToolStripMenuItem.Text = "Sales Menu"
            MenuPrincipal.NuevaVentaToolStripMenuItem.Text = "New Sale"
            MenuPrincipal.AdministrarPresupuestoToolStripMenuItem.Text = "Budget Menu"
            MenuPrincipal.NuevoPresupuestoToolStripMenuItem.Text = "New Budget"

            MenuPrincipal.ReporteToolStripMenuItem.Text = "Reports"
            MenuPrincipal.ReporteVentasToolStripMenuItem.Text = "Sales List"
            MenuPrincipal.ReporteVentaSimpleToolStripMenuItem.Text = "Specific Sale"
            MenuPrincipal.ReportePedidoEspecificoToolStripMenuItem.Text = "Specific Order"
            MenuPrincipal.ReporteListadoComprasToolStripMenuItem.Text = "Order List"
            MenuPrincipal.ReporteUsuariosToolStripMenuItem.Text = "User List"

            MenuPrincipal.UtilidadesToolStripMenuItem.Text = "Tools"
            MenuPrincipal.ConsultarBitacoraToolStripMenuItem.Text = "Binacle"
            MenuPrincipal.ModificarContraseñarToolStripMenuItem.Text = "Change Password"
            MenuPrincipal.BackUpRestoreToolStripMenuItem.Text = "Backup - Restore"
            MenuPrincipal.BackupToolStripMenuItem.Text = "Backup"
            MenuPrincipal.RestoreToolStripMenuItem.Text = "Restore"

            MenuPrincipal.SeguridadToolStripMenuItem.Text = "Security"
            MenuPrincipal.CrearFamiliaToolStripMenuItem.Text= "Create group of roles Menu"
            MenuPrincipal.AsignarPatentesToolStripMenuItem1.Text = "Assign Roles"

        End If



    End Sub

End Class