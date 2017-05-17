<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdministracionPedidos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.btnCancelPedido = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblPedReal = New System.Windows.Forms.Label()
        Me.lblPedConfir = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btnConsul = New System.Windows.Forms.Button()
        Me.lblProv = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblBuscarDesde = New System.Windows.Forms.Label()
        Me.btnConfi = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd - mm - yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(148, 60)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(91, 20)
        Me.DateTimePicker2.TabIndex = 67
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.Location = New System.Drawing.Point(25, 65)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(90, 15)
        Me.lblHasta.TabIndex = 66
        Me.lblHasta.Text = "Buscar hasta"
        '
        'btnCancelPedido
        '
        Me.btnCancelPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPedido.Location = New System.Drawing.Point(752, 252)
        Me.btnCancelPedido.Name = "btnCancelPedido"
        Me.btnCancelPedido.Size = New System.Drawing.Size(162, 23)
        Me.btnCancelPedido.TabIndex = 64
        Me.btnCancelPedido.Text = "Cancelar Pedido"
        Me.btnCancelPedido.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(839, 544)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 33)
        Me.btnCancelar.TabIndex = 63
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnModif
        '
        Me.btnModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModif.Location = New System.Drawing.Point(752, 151)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(162, 23)
        Me.btnModif.TabIndex = 62
        Me.btnModif.Text = "Modificar Pedido"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 125)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(713, 176)
        Me.DataGridView1.TabIndex = 57
        '
        'lblPedReal
        '
        Me.lblPedReal.AutoSize = True
        Me.lblPedReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPedReal.Location = New System.Drawing.Point(12, 107)
        Me.lblPedReal.Name = "lblPedReal"
        Me.lblPedReal.Size = New System.Drawing.Size(135, 15)
        Me.lblPedReal.TabIndex = 70
        Me.lblPedReal.Text = "Pedidos Realizados"
        '
        'lblPedConfir
        '
        Me.lblPedConfir.AutoSize = True
        Me.lblPedConfir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPedConfir.Location = New System.Drawing.Point(12, 322)
        Me.lblPedConfir.Name = "lblPedConfir"
        Me.lblPedConfir.Size = New System.Drawing.Size(144, 15)
        Me.lblPedConfir.TabIndex = 72
        Me.lblPedConfir.Text = "Pedidos Confirmados"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 340)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(713, 214)
        Me.DataGridView2.TabIndex = 71
        '
        'btnConsul
        '
        Me.btnConsul.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsul.Location = New System.Drawing.Point(752, 200)
        Me.btnConsul.Name = "btnConsul"
        Me.btnConsul.Size = New System.Drawing.Size(162, 23)
        Me.btnConsul.TabIndex = 76
        Me.btnConsul.Text = "Consultar Pedido"
        Me.btnConsul.UseVisualStyleBackColor = True
        '
        'lblProv
        '
        Me.lblProv.AutoSize = True
        Me.lblProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProv.Location = New System.Drawing.Point(272, 20)
        Me.lblProv.Name = "lblProv"
        Me.lblProv.Size = New System.Drawing.Size(72, 15)
        Me.lblProv.TabIndex = 80
        Me.lblProv.Text = "Proveedor"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(350, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(153, 20)
        Me.TextBox1.TabIndex = 79
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd - mm - yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(148, 20)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(91, 20)
        Me.DateTimePicker1.TabIndex = 78
        '
        'lblBuscarDesde
        '
        Me.lblBuscarDesde.AutoSize = True
        Me.lblBuscarDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarDesde.Location = New System.Drawing.Point(25, 25)
        Me.lblBuscarDesde.Name = "lblBuscarDesde"
        Me.lblBuscarDesde.Size = New System.Drawing.Size(94, 15)
        Me.lblBuscarDesde.TabIndex = 77
        Me.lblBuscarDesde.Text = "Buscar desde"
        '
        'btnConfi
        '
        Me.btnConfi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfi.Location = New System.Drawing.Point(752, 99)
        Me.btnConfi.Name = "btnConfi"
        Me.btnConfi.Size = New System.Drawing.Size(162, 23)
        Me.btnConfi.TabIndex = 81
        Me.btnConfi.Text = "Confirmar Pedido"
        Me.btnConfi.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(428, 57)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 82
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.lblBuscarDesde)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.lblHasta)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.lblProv)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(710, 100)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        '
        'AdministracionPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(926, 573)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnConfi)
        Me.Controls.Add(Me.btnConsul)
        Me.Controls.Add(Me.lblPedConfir)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.lblPedReal)
        Me.Controls.Add(Me.btnCancelPedido)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AdministracionPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administracion Pedidos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents btnCancelPedido As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnModif As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblPedReal As System.Windows.Forms.Label
    Friend WithEvents lblPedConfir As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnConsul As System.Windows.Forms.Button
    Friend WithEvents lblProv As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBuscarDesde As System.Windows.Forms.Label
    Friend WithEvents btnConfi As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
