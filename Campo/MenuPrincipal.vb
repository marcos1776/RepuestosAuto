
Public Class MenuPrincipal

    Public log As New Login
    Public altaVe As New AltaVenta


    Private Sub AdministrarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarUsuarioToolStripMenuItem.Click
        Dim admin As New AdministracionUsuarios
        admin.btnModificar.Enabled = False
        admin.ComboBox1.Enabled = False

        admin.MdiParent = Me
        admin.Show()

        'AdministracionUsuarios.MdiParent = Me
        'AdministracionUsuarios.Show()
    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        AltaUsuario.MdiParent = Me
        AltaUsuario.Show()
    End Sub

    Private Sub AsignarPatentesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AdministrarProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarProveedoresToolStripMenuItem.Click
        Dim admin As New AdministracionProveedores
        admin.btnModificarProveedor.Enabled = False
        admin.ComboBox1.Enabled = False

        admin.MdiParent = Me
        admin.Show()

        'AdministracionProveedores.MdiParent = Me
        'AdministracionProveedores.Show()
    End Sub

    Private Sub NuevoProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoProveedorToolStripMenuItem.Click
        AltaProveedor.MdiParent = Me
        AltaProveedor.Show()
    End Sub

    Private Sub AdministrarArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarArticulosToolStripMenuItem.Click
        Administrar_Articulos.MdiParent = Me
        Administrar_Articulos.Show()
    End Sub

    Private Sub NuevoArticuloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoArticuloToolStripMenuItem.Click
        AltaArticulo.MdiParent = Me
        AltaArticulo.Show()
    End Sub

    Private Sub AdministrarPedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarPedidosToolStripMenuItem.Click
        AdministracionPedidos.MdiParent = Me
        AdministracionPedidos.Show()
    End Sub

    Private Sub NuevoPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoPedidoToolStripMenuItem.Click
        AltaPedido.MdiParent = Me
        AltaPedido.Show()
    End Sub

    Private Sub AdministrarVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarVentasToolStripMenuItem.Click
        AdministrarVentas.MdiParent = Me
        AdministrarVentas.Show()
    End Sub

    Private Sub NuevaVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaVentaToolStripMenuItem.Click
        'Dim altaVe As New AltaVenta
        altaVe.MdiParent = Me
        altaVe.Show()
    End Sub

    Private Sub AdministrarPresupuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarPresupuestoToolStripMenuItem.Click
        AdministrarPresupuestos.MdiParent = Me
        AdministrarPresupuestos.Show()
    End Sub

    Private Sub NuevoPresupuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoPresupuestoToolStripMenuItem.Click
        AltaPresupuesto.MdiParent = Me
        AltaPresupuesto.Show()
    End Sub


    Private Sub ConsultarBitacoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarBitacoraToolStripMenuItem.Click
        ConsultarBitacora.MdiParent = Me
        ConsultarBitacora.Show()
    End Sub

    Private Sub ModificarContraseñarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarContraseñarToolStripMenuItem.Click
        ModificarContraseña.MdiParent = Me
        ModificarContraseña.Show()
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click
        RealizarBackup.MdiParent = Me
        RealizarBackup.Show()
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        RealizarRestore.MdiParent = Me
        RealizarRestore.Show()
    End Sub

    Private Sub CargarArticulosDeProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'CargarStockAProveedor.MdiParent = Me
        'Dim CargarStock As New CargarStockAProveedor()
        'CargarStock.Show()
        'CargarStockAProveedor.Show()
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Seleccione el archivo del Provedor..."

        'fd.InitialDirectory = "C:\Users\marcos.lampacrescia\Desktop\Marcos\Marce"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            'TextBox1.Text = strFileName
            Dim prov As New BLL.Proveedor
            prov.cargarArticuloProveedor(strFileName)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) 'Handles Timer1.Tick
        Me.ToolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString()

    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        Me.WindowState = FormWindowState.Maximized

        MenuToolStripMenuItem.Visible = True
        CerrarSesiónToolStripMenuItem.Visible = True

        UsuariosToolStripMenuItem.Visible = False
        AdministrarUsuarioToolStripMenuItem.Visible = False
        NuevoUsuarioToolStripMenuItem.Visible = False

        ProveedoresToolStripMenuItem.Visible = False
        AdministrarProveedoresToolStripMenuItem.Visible = False
        NuevoProveedorToolStripMenuItem.Visible = False

        ArticulosToolStripMenuItem.Visible = False
        AdministrarArticulosToolStripMenuItem.Visible = False
        NuevoArticuloToolStripMenuItem.Visible = False
        CargarArticulosDesdeArchivoToolStripMenuItem.Visible = False
        CorregirStockToolStripMenuItem.Visible = False

        ComprasToolStripMenuItem.Visible = False
        AdministrarPedidosToolStripMenuItem.Visible = False
        NuevoPedidoToolStripMenuItem.Visible = False

        VentaToolStripMenuItem.Visible = False
        AdministrarVentasToolStripMenuItem.Visible = False
        NuevaVentaToolStripMenuItem.Visible = False
        AdministrarPresupuestoToolStripMenuItem.Visible = False
        NuevoPresupuestoToolStripMenuItem.Visible = False

        ReporteToolStripMenuItem.Visible = False
        ReporteVentasToolStripMenuItem.Visible = False
        ReporteVentaSimpleToolStripMenuItem.Visible = False
        ReportePedidoEspecificoToolStripMenuItem.Visible = False
        ReporteListadoComprasToolStripMenuItem.Visible = False
        ReporteUsuariosToolStripMenuItem.Visible = False

        UtilidadesToolStripMenuItem.Visible = False
        ConsultarBitacoraToolStripMenuItem.Visible = False
        ModificarContraseñarToolStripMenuItem.Visible = False
        BackUpRestoreToolStripMenuItem.Visible = False
        BackupToolStripMenuItem.Visible = False
        RestoreToolStripMenuItem.Visible = False

        SeguridadToolStripMenuItem.Visible = False
        CrearFamiliaToolStripMenuItem.Visible = False
        AsignarPatentesToolStripMenuItem1.Visible = False


        Dim Login As New Login
        Login.ShowDialog(Me)
        Login.MdiParent = Me



        'Login.Show()


    End Sub

    Private Sub ReporteVentaSimpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteVentaSimpleToolStripMenuItem.Click
        ReporteVentaEspecifica.MdiParent = Me
        ReporteVentaEspecifica.Show()
    End Sub

    Private Sub CrearFamiliaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearFamiliaToolStripMenuItem.Click
        AdministracionFamilias.MdiParent = Me
        AdministracionFamilias.Show()
    End Sub

    Private Sub AdministrarUsuarioFamiliaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        UsuarioFamilia.MdiParent = Me
        UsuarioFamilia.Show()
    End Sub

    Private Sub AdministrarUsuarioPatenteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        UsuarioPatente.MdiParent = Me
        UsuarioPatente.Show()
    End Sub

    Private Sub ReportePedidoEspecificoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePedidoEspecificoToolStripMenuItem.Click
        Reporte.MdiParent = Me
        Reporte.Show()
    End Sub

    Private Sub ReporteListadoComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteListadoComprasToolStripMenuItem.Click
        ReportePedidoListado.MdiParent = Me
        ReportePedidoListado.Show()
    End Sub

    Private Sub ReporteUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteUsuariosToolStripMenuItem.Click
        ReporteListadoUsuarios.MdiParent = Me
        ReporteListadoUsuarios.Show()
    End Sub

    Private Sub AsignarPatentesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AsignarPatentesToolStripMenuItem1.Click
        AsignacionUsuarioPatentes.MdiParent = Me
        Dim usuarioPatentes As New AsignacionUsuarioPatentes
        usuarioPatentes.Show()
    End Sub

    Private Sub CargarArticulosDesdeArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarArticulosDesdeArchivoToolStripMenuItem.Click
        'CargarStockAProveedor.MdiParent = Me
        'Dim CargarStock As New CargarStockAProveedor()
        'CargarStock.Show()
        'CargarStockAProveedor.Show()
        Dim seguridad As New BLL.Seguridad("Password")
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Seleccione el archivo del Provedor..."

        'fd.InitialDirectory = "C:\Users\marcos.lampacrescia\Desktop\Marcos\Marce"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            'TextBox1.Text = strFileName
            Dim prov As New BLL.Proveedor
            prov.cargarArticuloProveedor(strFileName)


            Dim idBitacora As Integer = seguridad.registrarBitacora(Login.ID_USUARIO, "MEDIA", DateTime.Now, "Articulos cargados al sistema", 0)
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

            If Login.ID_IDIOMA = 1 Then
                MessageBox.Show("Articulos cargados correctamente")
            Else
                MessageBox.Show("Articles loaded succefully")

            End If
        End If
    End Sub

    Private Sub ReporteArticulosMásVendidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteArticulosMásVendidosToolStripMenuItem.Click
        ReporteArticuloMasVendidos.MdiParent = Me
        ReporteArticuloMasVendidos.Show()
    End Sub


    Private Sub ReporteVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteVentasToolStripMenuItem.Click

    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Application.Exit()
        End
    End Sub


    Private Sub ActualizarHora(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = DateTime.Now.ToLongTimeString()
    End Sub
End Class