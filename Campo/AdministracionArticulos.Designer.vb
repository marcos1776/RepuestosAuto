<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrar_Articulos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lblArticDispon = New System.Windows.Forms.Label()
        Me.btnMisArticulos = New System.Windows.Forms.Button()
        Me.btnArticulosProv = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblMinimo = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblMargen = New System.Windows.Forms.Label()
        Me.lblAuto = New System.Windows.Forms.Label()
        Me.btnModifArtic = New System.Windows.Forms.Button()
        Me.btnAplicCam = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDatosArticulos = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Articulos Proveedores"
        Me.Label1.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightSalmon
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(936, 578)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 52
        Me.Button6.Text = "Cancelar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 129)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(648, 390)
        Me.DataGridView1.TabIndex = 53
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 129)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(648, 390)
        Me.DataGridView2.TabIndex = 57
        Me.DataGridView2.Visible = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(6, 70)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(51, 15)
        Me.lblBuscar.TabIndex = 56
        Me.lblBuscar.Text = "Buscar"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(63, 65)
        Me.TextBox4.MaxLength = 20
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(194, 20)
        Me.TextBox4.TabIndex = 55
        '
        'lblArticDispon
        '
        Me.lblArticDispon.AutoSize = True
        Me.lblArticDispon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArticDispon.Location = New System.Drawing.Point(9, 99)
        Me.lblArticDispon.Name = "lblArticDispon"
        Me.lblArticDispon.Size = New System.Drawing.Size(142, 15)
        Me.lblArticDispon.TabIndex = 54
        Me.lblArticDispon.Text = "Articulos Disponibles"
        '
        'btnMisArticulos
        '
        Me.btnMisArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMisArticulos.Location = New System.Drawing.Point(12, 13)
        Me.btnMisArticulos.Name = "btnMisArticulos"
        Me.btnMisArticulos.Size = New System.Drawing.Size(143, 43)
        Me.btnMisArticulos.TabIndex = 58
        Me.btnMisArticulos.Text = "Mis Articulos"
        Me.btnMisArticulos.UseVisualStyleBackColor = True
        '
        'btnArticulosProv
        '
        Me.btnArticulosProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArticulosProv.Location = New System.Drawing.Point(680, 13)
        Me.btnArticulosProv.Name = "btnArticulosProv"
        Me.btnArticulosProv.Size = New System.Drawing.Size(143, 43)
        Me.btnArticulosProv.TabIndex = 59
        Me.btnArticulosProv.Text = "Artículos Proveedores"
        Me.btnArticulosProv.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(161, 245)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(101, 20)
        Me.TextBox1.TabIndex = 60
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(162, 282)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 61
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(162, 320)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 62
        '
        'lblMinimo
        '
        Me.lblMinimo.AutoSize = True
        Me.lblMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimo.Location = New System.Drawing.Point(26, 250)
        Me.lblMinimo.Name = "lblMinimo"
        Me.lblMinimo.Size = New System.Drawing.Size(94, 15)
        Me.lblMinimo.TabIndex = 63
        Me.lblMinimo.Text = "Stock Minimo"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMax.Location = New System.Drawing.Point(26, 287)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(97, 15)
        Me.lblMax.TabIndex = 64
        Me.lblMax.Text = "Stock Máximo"
        '
        'lblMargen
        '
        Me.lblMargen.AutoSize = True
        Me.lblMargen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMargen.Location = New System.Drawing.Point(26, 325)
        Me.lblMargen.Name = "lblMargen"
        Me.lblMargen.Size = New System.Drawing.Size(121, 15)
        Me.lblMargen.TabIndex = 65
        Me.lblMargen.Text = "Margen Ganancia"
        '
        'lblAuto
        '
        Me.lblAuto.AutoSize = True
        Me.lblAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuto.Location = New System.Drawing.Point(9, 13)
        Me.lblAuto.Name = "lblAuto"
        Me.lblAuto.Size = New System.Drawing.Size(42, 15)
        Me.lblAuto.TabIndex = 66
        Me.lblAuto.Text = "Autos"
        '
        'btnModifArtic
        '
        Me.btnModifArtic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifArtic.Location = New System.Drawing.Point(15, 365)
        Me.btnModifArtic.Name = "btnModifArtic"
        Me.btnModifArtic.Size = New System.Drawing.Size(132, 32)
        Me.btnModifArtic.TabIndex = 68
        Me.btnModifArtic.Text = "Modificar Articulo"
        Me.btnModifArtic.UseVisualStyleBackColor = True
        '
        'btnAplicCam
        '
        Me.btnAplicCam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicCam.Location = New System.Drawing.Point(161, 365)
        Me.btnAplicCam.Name = "btnAplicCam"
        Me.btnAplicCam.Size = New System.Drawing.Size(132, 32)
        Me.btnAplicCam.TabIndex = 69
        Me.btnAplicCam.Text = "Aplicar Cambios"
        Me.btnAplicCam.UseVisualStyleBackColor = True
        Me.btnAplicCam.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(14, 31)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(271, 184)
        Me.ListBox1.TabIndex = 70
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(63, 65)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(194, 20)
        Me.TextBox5.TabIndex = 71
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(906, 525)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 72
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 531)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(37, 13)
        Me.LinkLabel1.TabIndex = 73
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Ayuda"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.lblAuto)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.lblMinimo)
        Me.GroupBox1.Controls.Add(Me.btnModifArtic)
        Me.GroupBox1.Controls.Add(Me.btnAplicCam)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.lblMax)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.lblMargen)
        Me.GroupBox1.Location = New System.Drawing.Point(680, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 420)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        '
        'lblDatosArticulos
        '
        Me.lblDatosArticulos.AutoSize = True
        Me.lblDatosArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDatosArticulos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDatosArticulos.Location = New System.Drawing.Point(680, 79)
        Me.lblDatosArticulos.Name = "lblDatosArticulos"
        Me.lblDatosArticulos.Size = New System.Drawing.Size(103, 15)
        Me.lblDatosArticulos.TabIndex = 75
        Me.lblDatosArticulos.Text = "Datos Articulos"
        '
        'Administrar_Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(995, 547)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDatosArticulos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.btnArticulosProv)
        Me.Controls.Add(Me.btnMisArticulos)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.lblArticDispon)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Administrar_Articulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Articulos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents lblArticDispon As System.Windows.Forms.Label
    Friend WithEvents btnMisArticulos As System.Windows.Forms.Button
    Friend WithEvents btnArticulosProv As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblMinimo As System.Windows.Forms.Label
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents lblMargen As System.Windows.Forms.Label
    Friend WithEvents lblAuto As System.Windows.Forms.Label
    Friend WithEvents btnModifArtic As System.Windows.Forms.Button
    Friend WithEvents btnAplicCam As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDatosArticulos As System.Windows.Forms.Label
End Class
