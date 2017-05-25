<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministracionProveedores
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblProveedorHabil = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.btnAplicarCambios = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblHabiliado = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.lblDirecciones = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblNombreContacto = New System.Windows.Forms.Label()
        Me.lblApellidoContacto = New System.Windows.Forms.Label()
        Me.lblNombreEmpresa = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnModificarProveedor = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lblTelefonos = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblDatosProveedor = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(763, 542)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 40
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 67)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(422, 470)
        Me.DataGridView1.TabIndex = 34
        '
        'lblProveedorHabil
        '
        Me.lblProveedorHabil.AutoSize = True
        Me.lblProveedorHabil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedorHabil.Location = New System.Drawing.Point(9, 11)
        Me.lblProveedorHabil.Name = "lblProveedorHabil"
        Me.lblProveedorHabil.Size = New System.Drawing.Size(164, 15)
        Me.lblProveedorHabil.TabIndex = 32
        Me.lblProveedorHabil.Text = "Proveedores Habilitados"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(87, 41)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(169, 20)
        Me.TextBox8.TabIndex = 30
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(12, 46)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(51, 15)
        Me.lblBuscar.TabIndex = 29
        Me.lblBuscar.Text = "Buscar"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.btnAplicarCambios)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.lblHabiliado)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.ListBox2)
        Me.GroupBox1.Controls.Add(Me.lblDirecciones)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.lblNombreContacto)
        Me.GroupBox1.Controls.Add(Me.lblApellidoContacto)
        Me.GroupBox1.Controls.Add(Me.lblNombreEmpresa)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.btnModificarProveedor)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.lblTelefonos)
        Me.GroupBox1.Controls.Add(Me.lblMail)
        Me.GroupBox1.Location = New System.Drawing.Point(485, 63)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(348, 474)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(147, 294)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(170, 20)
        Me.TextBox6.TabIndex = 60
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(147, 161)
        Me.TextBox5.MaxLength = 40
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(170, 20)
        Me.TextBox5.TabIndex = 59
        '
        'btnAplicarCambios
        '
        Me.btnAplicarCambios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicarCambios.Location = New System.Drawing.Point(191, 436)
        Me.btnAplicarCambios.Name = "btnAplicarCambios"
        Me.btnAplicarCambios.Size = New System.Drawing.Size(141, 23)
        Me.btnAplicarCambios.TabIndex = 58
        Me.btnAplicarCambios.Text = "Aplicar Cambios"
        Me.btnAplicarCambios.UseVisualStyleBackColor = True
        Me.btnAplicarCambios.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Y", "N"})
        Me.ComboBox1.Location = New System.Drawing.Point(147, 129)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(69, 21)
        Me.ComboBox1.TabIndex = 57
        '
        'lblHabiliado
        '
        Me.lblHabiliado.AutoSize = True
        Me.lblHabiliado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblHabiliado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHabiliado.Location = New System.Drawing.Point(23, 129)
        Me.lblHabiliado.Name = "lblHabiliado"
        Me.lblHabiliado.Size = New System.Drawing.Size(81, 15)
        Me.lblHabiliado.TabIndex = 56
        Me.lblHabiliado.Text = "Habilitado: "
        '
        'Button9
        '
        Me.Button9.Enabled = False
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button9.Location = New System.Drawing.Point(57, 368)
        Me.Button9.Margin = New System.Windows.Forms.Padding(2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(50, 21)
        Me.Button9.TabIndex = 55
        Me.Button9.Text = "-"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Enabled = False
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button10.Location = New System.Drawing.Point(57, 336)
        Me.Button10.Margin = New System.Windows.Forms.Padding(2)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(50, 19)
        Me.Button10.TabIndex = 54
        Me.Button10.Text = "+"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.Enabled = False
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(147, 336)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(185, 82)
        Me.ListBox2.TabIndex = 52
        '
        'lblDirecciones
        '
        Me.lblDirecciones.AutoSize = True
        Me.lblDirecciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDirecciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDirecciones.Location = New System.Drawing.Point(23, 299)
        Me.lblDirecciones.Name = "lblDirecciones"
        Me.lblDirecciones.Size = New System.Drawing.Size(87, 15)
        Me.lblDirecciones.TabIndex = 51
        Me.lblDirecciones.Text = "Direcciones:"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(147, 66)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.MaxLength = 40
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(170, 20)
        Me.TextBox3.TabIndex = 49
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(147, 38)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.MaxLength = 40
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(170, 20)
        Me.TextBox2.TabIndex = 48
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(147, 10)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.MaxLength = 40
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(170, 20)
        Me.TextBox1.TabIndex = 47
        '
        'lblNombreContacto
        '
        Me.lblNombreContacto.AutoSize = True
        Me.lblNombreContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombreContacto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNombreContacto.Location = New System.Drawing.Point(19, 43)
        Me.lblNombreContacto.Name = "lblNombreContacto"
        Me.lblNombreContacto.Size = New System.Drawing.Size(126, 15)
        Me.lblNombreContacto.TabIndex = 46
        Me.lblNombreContacto.Text = "Nombre Contacto: "
        '
        'lblApellidoContacto
        '
        Me.lblApellidoContacto.AutoSize = True
        Me.lblApellidoContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblApellidoContacto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblApellidoContacto.Location = New System.Drawing.Point(19, 71)
        Me.lblApellidoContacto.Name = "lblApellidoContacto"
        Me.lblApellidoContacto.Size = New System.Drawing.Size(123, 15)
        Me.lblApellidoContacto.TabIndex = 45
        Me.lblApellidoContacto.Text = "Apellido Contacto:"
        '
        'lblNombreEmpresa
        '
        Me.lblNombreEmpresa.AutoSize = True
        Me.lblNombreEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombreEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNombreEmpresa.Location = New System.Drawing.Point(19, 15)
        Me.lblNombreEmpresa.Name = "lblNombreEmpresa"
        Me.lblNombreEmpresa.Size = New System.Drawing.Size(123, 15)
        Me.lblNombreEmpresa.TabIndex = 44
        Me.lblNombreEmpresa.Text = "Nombre Empresa:"
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button5.Location = New System.Drawing.Point(57, 227)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 21)
        Me.Button5.TabIndex = 43
        Me.Button5.Text = "-"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button4.Location = New System.Drawing.Point(57, 195)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 19)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "+"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnModificarProveedor
        '
        Me.btnModificarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnModificarProveedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnModificarProveedor.Location = New System.Drawing.Point(22, 436)
        Me.btnModificarProveedor.Name = "btnModificarProveedor"
        Me.btnModificarProveedor.Size = New System.Drawing.Size(159, 23)
        Me.btnModificarProveedor.TabIndex = 4
        Me.btnModificarProveedor.Text = "Modificar Proveedor"
        Me.btnModificarProveedor.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Enabled = False
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(147, 195)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(185, 82)
        Me.ListBox1.TabIndex = 36
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(147, 94)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.MaxLength = 120
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(170, 20)
        Me.TextBox4.TabIndex = 38
        '
        'lblTelefonos
        '
        Me.lblTelefonos.AutoSize = True
        Me.lblTelefonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTelefonos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTelefonos.Location = New System.Drawing.Point(23, 161)
        Me.lblTelefonos.Name = "lblTelefonos"
        Me.lblTelefonos.Size = New System.Drawing.Size(74, 15)
        Me.lblTelefonos.TabIndex = 35
        Me.lblTelefonos.Text = "Telefonos:"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMail.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMail.Location = New System.Drawing.Point(23, 99)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(39, 15)
        Me.lblMail.TabIndex = 32
        Me.lblMail.Text = "Mail:"
        '
        'lblDatosProveedor
        '
        Me.lblDatosProveedor.AutoSize = True
        Me.lblDatosProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDatosProveedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDatosProveedor.Location = New System.Drawing.Point(493, 46)
        Me.lblDatosProveedor.Name = "lblDatosProveedor"
        Me.lblDatosProveedor.Size = New System.Drawing.Size(113, 15)
        Me.lblDatosProveedor.TabIndex = 42
        Me.lblDatosProveedor.Text = "Datos Proveedor"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(326, 38)
        Me.Button1.Name = "Button1"
        Me.HelpProvider1.SetShowHelp(Me.Button1, True)
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Imprimir Listado"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 552)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(37, 13)
        Me.LinkLabel1.TabIndex = 44
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Ayuda"
        '
        'AdministracionProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(850, 574)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblDatosProveedor)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblProveedorHabil)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.lblBuscar)
        Me.Name = "AdministracionProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Proveedores"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblProveedorHabil As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents lblDirecciones As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreContacto As System.Windows.Forms.Label
    Friend WithEvents lblApellidoContacto As System.Windows.Forms.Label
    Friend WithEvents lblNombreEmpresa As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnModificarProveedor As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefonos As System.Windows.Forms.Label
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblDatosProveedor As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblHabiliado As System.Windows.Forms.Label
    Friend WithEvents btnAplicarCambios As System.Windows.Forms.Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
End Class
