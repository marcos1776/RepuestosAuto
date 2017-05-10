<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoArticuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarArticulosDesdeArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorregirStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarPresupuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoPresupuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteVentaSimpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteListadoComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportePedidoEspecificoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteArticulosMásVendidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarBitacoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarContraseñarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackUpRestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearFamiliaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarPatentesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MainMenu.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ArticulosToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.VentaToolStripMenuItem, Me.ReporteToolStripMenuItem, Me.UtilidadesToolStripMenuItem, Me.SeguridadToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(913, 28)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarUsuarioToolStripMenuItem, Me.NuevoUsuarioToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'AdministrarUsuarioToolStripMenuItem
        '
        Me.AdministrarUsuarioToolStripMenuItem.Name = "AdministrarUsuarioToolStripMenuItem"
        Me.AdministrarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.AdministrarUsuarioToolStripMenuItem.Text = "Administrar Usuario"
        '
        'NuevoUsuarioToolStripMenuItem
        '
        Me.NuevoUsuarioToolStripMenuItem.Name = "NuevoUsuarioToolStripMenuItem"
        Me.NuevoUsuarioToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.NuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarProveedoresToolStripMenuItem, Me.NuevoProveedorToolStripMenuItem})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(103, 24)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'AdministrarProveedoresToolStripMenuItem
        '
        Me.AdministrarProveedoresToolStripMenuItem.Name = "AdministrarProveedoresToolStripMenuItem"
        Me.AdministrarProveedoresToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.AdministrarProveedoresToolStripMenuItem.Text = "Administrar Proveedores"
        '
        'NuevoProveedorToolStripMenuItem
        '
        Me.NuevoProveedorToolStripMenuItem.Name = "NuevoProveedorToolStripMenuItem"
        Me.NuevoProveedorToolStripMenuItem.Size = New System.Drawing.Size(241, 24)
        Me.NuevoProveedorToolStripMenuItem.Text = "Nuevo Proveedor"
        '
        'ArticulosToolStripMenuItem
        '
        Me.ArticulosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarArticulosToolStripMenuItem, Me.NuevoArticuloToolStripMenuItem, Me.CargarArticulosDesdeArchivoToolStripMenuItem, Me.CorregirStockToolStripMenuItem})
        Me.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem"
        Me.ArticulosToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.ArticulosToolStripMenuItem.Text = "Articulos"
        '
        'AdministrarArticulosToolStripMenuItem
        '
        Me.AdministrarArticulosToolStripMenuItem.Name = "AdministrarArticulosToolStripMenuItem"
        Me.AdministrarArticulosToolStripMenuItem.Size = New System.Drawing.Size(280, 24)
        Me.AdministrarArticulosToolStripMenuItem.Text = "Administrar Articulos"
        '
        'NuevoArticuloToolStripMenuItem
        '
        Me.NuevoArticuloToolStripMenuItem.Name = "NuevoArticuloToolStripMenuItem"
        Me.NuevoArticuloToolStripMenuItem.Size = New System.Drawing.Size(280, 24)
        Me.NuevoArticuloToolStripMenuItem.Text = "Nuevo Articulo"
        '
        'CargarArticulosDesdeArchivoToolStripMenuItem
        '
        Me.CargarArticulosDesdeArchivoToolStripMenuItem.Name = "CargarArticulosDesdeArchivoToolStripMenuItem"
        Me.CargarArticulosDesdeArchivoToolStripMenuItem.Size = New System.Drawing.Size(280, 24)
        Me.CargarArticulosDesdeArchivoToolStripMenuItem.Text = "Cargar Articulos desde archivo"
        '
        'CorregirStockToolStripMenuItem
        '
        Me.CorregirStockToolStripMenuItem.Name = "CorregirStockToolStripMenuItem"
        Me.CorregirStockToolStripMenuItem.Size = New System.Drawing.Size(280, 24)
        Me.CorregirStockToolStripMenuItem.Text = "Corregir Stock"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarPedidosToolStripMenuItem, Me.NuevoPedidoToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.ComprasToolStripMenuItem.Text = "Pedidos"
        '
        'AdministrarPedidosToolStripMenuItem
        '
        Me.AdministrarPedidosToolStripMenuItem.Name = "AdministrarPedidosToolStripMenuItem"
        Me.AdministrarPedidosToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.AdministrarPedidosToolStripMenuItem.Text = "Administrar Pedidos"
        '
        'NuevoPedidoToolStripMenuItem
        '
        Me.NuevoPedidoToolStripMenuItem.Name = "NuevoPedidoToolStripMenuItem"
        Me.NuevoPedidoToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.NuevoPedidoToolStripMenuItem.Text = "Nuevo Pedido"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarVentasToolStripMenuItem, Me.NuevaVentaToolStripMenuItem, Me.AdministrarPresupuestoToolStripMenuItem, Me.NuevoPresupuestoToolStripMenuItem})
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.VentaToolStripMenuItem.Text = "Ventas"
        '
        'AdministrarVentasToolStripMenuItem
        '
        Me.AdministrarVentasToolStripMenuItem.Name = "AdministrarVentasToolStripMenuItem"
        Me.AdministrarVentasToolStripMenuItem.Size = New System.Drawing.Size(239, 24)
        Me.AdministrarVentasToolStripMenuItem.Text = "Administrar Ventas"
        '
        'NuevaVentaToolStripMenuItem
        '
        Me.NuevaVentaToolStripMenuItem.Name = "NuevaVentaToolStripMenuItem"
        Me.NuevaVentaToolStripMenuItem.Size = New System.Drawing.Size(239, 24)
        Me.NuevaVentaToolStripMenuItem.Text = "Nueva Venta"
        '
        'AdministrarPresupuestoToolStripMenuItem
        '
        Me.AdministrarPresupuestoToolStripMenuItem.Name = "AdministrarPresupuestoToolStripMenuItem"
        Me.AdministrarPresupuestoToolStripMenuItem.Size = New System.Drawing.Size(239, 24)
        Me.AdministrarPresupuestoToolStripMenuItem.Text = "Administrar Presupuesto"
        '
        'NuevoPresupuestoToolStripMenuItem
        '
        Me.NuevoPresupuestoToolStripMenuItem.Name = "NuevoPresupuestoToolStripMenuItem"
        Me.NuevoPresupuestoToolStripMenuItem.Size = New System.Drawing.Size(239, 24)
        Me.NuevoPresupuestoToolStripMenuItem.Text = "Nuevo Presupuesto"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteVentasToolStripMenuItem, Me.ReporteVentaSimpleToolStripMenuItem, Me.ReporteListadoComprasToolStripMenuItem, Me.ReportePedidoEspecificoToolStripMenuItem, Me.ReporteUsuariosToolStripMenuItem, Me.ReporteArticulosMásVendidosToolStripMenuItem})
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ReporteToolStripMenuItem.Text = "Reportes"
        '
        'ReporteVentasToolStripMenuItem
        '
        Me.ReporteVentasToolStripMenuItem.Name = "ReporteVentasToolStripMenuItem"
        Me.ReporteVentasToolStripMenuItem.Size = New System.Drawing.Size(289, 24)
        Me.ReporteVentasToolStripMenuItem.Text = "Reporte Listado Ventas"
        '
        'ReporteVentaSimpleToolStripMenuItem
        '
        Me.ReporteVentaSimpleToolStripMenuItem.Name = "ReporteVentaSimpleToolStripMenuItem"
        Me.ReporteVentaSimpleToolStripMenuItem.Size = New System.Drawing.Size(289, 24)
        Me.ReporteVentaSimpleToolStripMenuItem.Text = "Reporte Venta Específica"
        '
        'ReporteListadoComprasToolStripMenuItem
        '
        Me.ReporteListadoComprasToolStripMenuItem.Name = "ReporteListadoComprasToolStripMenuItem"
        Me.ReporteListadoComprasToolStripMenuItem.Size = New System.Drawing.Size(289, 24)
        Me.ReporteListadoComprasToolStripMenuItem.Text = "Reporte Listado Pedidos"
        '
        'ReportePedidoEspecificoToolStripMenuItem
        '
        Me.ReportePedidoEspecificoToolStripMenuItem.Name = "ReportePedidoEspecificoToolStripMenuItem"
        Me.ReportePedidoEspecificoToolStripMenuItem.Size = New System.Drawing.Size(289, 24)
        Me.ReportePedidoEspecificoToolStripMenuItem.Text = "Reporte Pedido Especifico"
        '
        'ReporteUsuariosToolStripMenuItem
        '
        Me.ReporteUsuariosToolStripMenuItem.Name = "ReporteUsuariosToolStripMenuItem"
        Me.ReporteUsuariosToolStripMenuItem.Size = New System.Drawing.Size(289, 24)
        Me.ReporteUsuariosToolStripMenuItem.Text = "Reporte Usuarios"
        '
        'ReporteArticulosMásVendidosToolStripMenuItem
        '
        Me.ReporteArticulosMásVendidosToolStripMenuItem.Name = "ReporteArticulosMásVendidosToolStripMenuItem"
        Me.ReporteArticulosMásVendidosToolStripMenuItem.Size = New System.Drawing.Size(289, 24)
        Me.ReporteArticulosMásVendidosToolStripMenuItem.Text = "Reporte Artículos Más Vendidos"
        '
        'UtilidadesToolStripMenuItem
        '
        Me.UtilidadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarBitacoraToolStripMenuItem, Me.ModificarContraseñarToolStripMenuItem, Me.BackUpRestoreToolStripMenuItem})
        Me.UtilidadesToolStripMenuItem.Name = "UtilidadesToolStripMenuItem"
        Me.UtilidadesToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.UtilidadesToolStripMenuItem.Text = "Utilidades"
        '
        'ConsultarBitacoraToolStripMenuItem
        '
        Me.ConsultarBitacoraToolStripMenuItem.Name = "ConsultarBitacoraToolStripMenuItem"
        Me.ConsultarBitacoraToolStripMenuItem.Size = New System.Drawing.Size(220, 24)
        Me.ConsultarBitacoraToolStripMenuItem.Text = "Consultar Bitacora"
        '
        'ModificarContraseñarToolStripMenuItem
        '
        Me.ModificarContraseñarToolStripMenuItem.Name = "ModificarContraseñarToolStripMenuItem"
        Me.ModificarContraseñarToolStripMenuItem.Size = New System.Drawing.Size(220, 24)
        Me.ModificarContraseñarToolStripMenuItem.Text = "Modificar Contraseña"
        '
        'BackUpRestoreToolStripMenuItem
        '
        Me.BackUpRestoreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupToolStripMenuItem, Me.RestoreToolStripMenuItem})
        Me.BackUpRestoreToolStripMenuItem.Name = "BackUpRestoreToolStripMenuItem"
        Me.BackUpRestoreToolStripMenuItem.Size = New System.Drawing.Size(220, 24)
        Me.BackUpRestoreToolStripMenuItem.Text = "Backup - Restore"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(128, 24)
        Me.BackupToolStripMenuItem.Text = "Backup"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(128, 24)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'SeguridadToolStripMenuItem
        '
        Me.SeguridadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearFamiliaToolStripMenuItem, Me.AsignarPatentesToolStripMenuItem1})
        Me.SeguridadToolStripMenuItem.Name = "SeguridadToolStripMenuItem"
        Me.SeguridadToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.SeguridadToolStripMenuItem.Text = "Seguridad"
        '
        'CrearFamiliaToolStripMenuItem
        '
        Me.CrearFamiliaToolStripMenuItem.Name = "CrearFamiliaToolStripMenuItem"
        Me.CrearFamiliaToolStripMenuItem.Size = New System.Drawing.Size(294, 24)
        Me.CrearFamiliaToolStripMenuItem.Text = "Administrar Familias de patentes"
        '
        'AsignarPatentesToolStripMenuItem1
        '
        Me.AsignarPatentesToolStripMenuItem1.Name = "AsignarPatentesToolStripMenuItem1"
        Me.AsignarPatentesToolStripMenuItem1.Size = New System.Drawing.Size(294, 24)
        Me.AsignarPatentesToolStripMenuItem1.Text = "Asignar Patentes"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 465)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(913, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(449, 17)
        Me.ToolStripStatusLabel2.Spring = True
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(449, 17)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'Timer1
        '
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(913, 487)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MainMenu)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "MenuPrincipal"
        Me.Text = "Administracion Autopartes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarArticulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoArticuloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarPedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoPedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarPresupuestoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoPresupuestoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilidadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarBitacoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarContraseñarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackUpRestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteVentaSimpleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeguridadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearFamiliaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportePedidoEspecificoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteListadoComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignarPatentesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CargarArticulosDesdeArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorregirStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ReporteArticulosMásVendidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
