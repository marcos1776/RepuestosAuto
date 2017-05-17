<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministrarVentas
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
        Me.btnCancelVenta = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnNueva = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.lblVentasCancel = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblBuscarDesde = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lblBuscarHasta = New System.Windows.Forms.Label()
        Me.lblVentasRealizadas = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnConsul = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelVenta
        '
        Me.btnCancelVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelVenta.Location = New System.Drawing.Point(652, 151)
        Me.btnCancelVenta.Name = "btnCancelVenta"
        Me.btnCancelVenta.Size = New System.Drawing.Size(162, 23)
        Me.btnCancelVenta.TabIndex = 52
        Me.btnCancelVenta.Text = "Cancelar Venta"
        Me.btnCancelVenta.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(739, 496)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 51
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnModif
        '
        Me.btnModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModif.Location = New System.Drawing.Point(652, 66)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(162, 23)
        Me.btnModif.TabIndex = 50
        Me.btnModif.Text = "Modificar Venta"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'btnNueva
        '
        Me.btnNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNueva.Location = New System.Drawing.Point(652, 27)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(162, 23)
        Me.btnNueva.TabIndex = 49
        Me.btnNueva.Text = "Nueva Venta"
        Me.btnNueva.UseVisualStyleBackColor = True
        Me.btnNueva.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Enabled = False
        Me.DataGridView2.Location = New System.Drawing.Point(7, 384)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(629, 135)
        Me.DataGridView2.TabIndex = 47
        '
        'lblVentasCancel
        '
        Me.lblVentasCancel.AutoSize = True
        Me.lblVentasCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentasCancel.Location = New System.Drawing.Point(7, 347)
        Me.lblVentasCancel.Name = "lblVentasCancel"
        Me.lblVentasCancel.Size = New System.Drawing.Size(129, 15)
        Me.lblVentasCancel.TabIndex = 46
        Me.lblVentasCancel.Text = "Ventas Canceladas"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 146)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(629, 198)
        Me.DataGridView1.TabIndex = 44
        '
        'lblBuscarDesde
        '
        Me.lblBuscarDesde.AutoSize = True
        Me.lblBuscarDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarDesde.Location = New System.Drawing.Point(6, 24)
        Me.lblBuscarDesde.Name = "lblBuscarDesde"
        Me.lblBuscarDesde.Size = New System.Drawing.Size(94, 15)
        Me.lblBuscarDesde.TabIndex = 42
        Me.lblBuscarDesde.Text = "Buscar desde"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(125, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 53
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(125, 56)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 55
        '
        'lblBuscarHasta
        '
        Me.lblBuscarHasta.AutoSize = True
        Me.lblBuscarHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarHasta.Location = New System.Drawing.Point(5, 56)
        Me.lblBuscarHasta.Name = "lblBuscarHasta"
        Me.lblBuscarHasta.Size = New System.Drawing.Size(90, 15)
        Me.lblBuscarHasta.TabIndex = 54
        Me.lblBuscarHasta.Text = "Buscar hasta"
        '
        'lblVentasRealizadas
        '
        Me.lblVentasRealizadas.AutoSize = True
        Me.lblVentasRealizadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentasRealizadas.Location = New System.Drawing.Point(7, 113)
        Me.lblVentasRealizadas.Name = "lblVentasRealizadas"
        Me.lblVentasRealizadas.Size = New System.Drawing.Size(126, 15)
        Me.lblVentasRealizadas.TabIndex = 56
        Me.lblVentasRealizadas.Text = "Ventas Realizadas"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(548, 56)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 57
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnConsul
        '
        Me.btnConsul.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsul.Location = New System.Drawing.Point(652, 110)
        Me.btnConsul.Name = "btnConsul"
        Me.btnConsul.Size = New System.Drawing.Size(162, 23)
        Me.btnConsul.TabIndex = 58
        Me.btnConsul.Text = "Consultar Venta"
        Me.btnConsul.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(63, 471)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 15)
        Me.Label5.TabIndex = 59
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(357, 23)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(52, 15)
        Me.lblCliente.TabIndex = 60
        Me.lblCliente.Text = "Cliente"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(425, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(198, 20)
        Me.TextBox1.TabIndex = 61
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.lblBuscarDesde)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.lblCliente)
        Me.GroupBox1.Controls.Add(Me.lblBuscarHasta)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(629, 92)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        '
        'AdministrarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(814, 531)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnConsul)
        Me.Controls.Add(Me.lblVentasRealizadas)
        Me.Controls.Add(Me.btnCancelVenta)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.lblVentasCancel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AdministrarVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Ventas"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelVenta As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnModif As System.Windows.Forms.Button
    Friend WithEvents btnNueva As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents lblVentasCancel As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblBuscarDesde As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBuscarHasta As System.Windows.Forms.Label
    Friend WithEvents lblVentasRealizadas As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnConsul As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
