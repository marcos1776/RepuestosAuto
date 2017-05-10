<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.rbEmpresa = New System.Windows.Forms.RadioButton()
        Me.rbPersona = New System.Windows.Forms.RadioButton()
        Me.btnBusc = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnNuev = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.lblCarro = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblArt = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(402, 15)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(61, 23)
        Me.btnNuevo.TabIndex = 100
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(380, 476)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 25)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = " "
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(26, 98)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(79, 20)
        Me.TextBox2.TabIndex = 98
        '
        'rbEmpresa
        '
        Me.rbEmpresa.AutoSize = True
        Me.rbEmpresa.Location = New System.Drawing.Point(228, 16)
        Me.rbEmpresa.Margin = New System.Windows.Forms.Padding(2)
        Me.rbEmpresa.Name = "rbEmpresa"
        Me.rbEmpresa.Size = New System.Drawing.Size(66, 17)
        Me.rbEmpresa.TabIndex = 97
        Me.rbEmpresa.TabStop = True
        Me.rbEmpresa.Text = "Empresa"
        Me.rbEmpresa.UseVisualStyleBackColor = True
        '
        'rbPersona
        '
        Me.rbPersona.AutoSize = True
        Me.rbPersona.Location = New System.Drawing.Point(122, 18)
        Me.rbPersona.Margin = New System.Windows.Forms.Padding(2)
        Me.rbPersona.Name = "rbPersona"
        Me.rbPersona.Size = New System.Drawing.Size(64, 17)
        Me.rbPersona.TabIndex = 96
        Me.rbPersona.TabStop = True
        Me.rbPersona.Text = "Persona"
        Me.rbPersona.UseVisualStyleBackColor = True
        '
        'btnBusc
        '
        Me.btnBusc.Location = New System.Drawing.Point(316, 14)
        Me.btnBusc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBusc.Name = "btnBusc"
        Me.btnBusc.Size = New System.Drawing.Size(61, 25)
        Me.btnBusc.TabIndex = 95
        Me.btnBusc.Text = "Buscar"
        Me.btnBusc.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(122, 42)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(172, 20)
        Me.TextBox1.TabIndex = 94
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(26, 19)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(52, 15)
        Me.lblCliente.TabIndex = 93
        Me.lblCliente.Text = "Cliente"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(319, 476)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(79, 25)
        Me.lblTotal.TabIndex = 92
        Me.lblTotal.Text = "Total: "
        '
        'btnNuev
        '
        Me.btnNuev.BackColor = System.Drawing.Color.Chartreuse
        Me.btnNuev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuev.Location = New System.Drawing.Point(26, 490)
        Me.btnNuev.Name = "btnNuev"
        Me.btnNuev.Size = New System.Drawing.Size(91, 45)
        Me.btnNuev.TabIndex = 91
        Me.btnNuev.Text = "Modificar Venta"
        Me.btnNuev.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(402, 507)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 28)
        Me.btnCancel.TabIndex = 90
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant.Location = New System.Drawing.Point(26, 77)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(64, 15)
        Me.lblCant.TabIndex = 89
        Me.lblCant.Text = "Cantidad"
        '
        'lblCarro
        '
        Me.lblCarro.AutoSize = True
        Me.lblCarro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarro.Location = New System.Drawing.Point(23, 292)
        Me.lblCarro.Name = "lblCarro"
        Me.lblCarro.Size = New System.Drawing.Size(102, 15)
        Me.lblCarro.TabIndex = 88
        Me.lblCarro.Text = "Carro de Venta"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.a, Me.Column4, Me.Column5, Me.Column6, Me.Subtotal, Me.Column8})
        Me.DataGridView2.Location = New System.Drawing.Point(26, 322)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(451, 135)
        Me.DataGridView2.TabIndex = 87
        '
        'a
        '
        Me.a.HeaderText = "Código"
        Me.a.Name = "a"
        Me.a.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Descripcion"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Precio"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Cantidad"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Accion"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(119, 98)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(303, 20)
        Me.TextBox3.TabIndex = 86
        '
        'lblArt
        '
        Me.lblArt.AutoSize = True
        Me.lblArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArt.Location = New System.Drawing.Point(238, 77)
        Me.lblArt.Name = "lblArt"
        Me.lblArt.Size = New System.Drawing.Size(62, 15)
        Me.lblArt.TabIndex = 85
        Me.lblArt.Text = "Articulos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Precio, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(26, 124)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(451, 149)
        Me.DataGridView1.TabIndex = 84
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Descripcion"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Accion"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'ModificarVenta
        '
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(499, 547)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.rbEmpresa)
        Me.Controls.Add(Me.rbPersona)
        Me.Controls.Add(Me.btnBusc)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnNuev)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblCant)
        Me.Controls.Add(Me.lblCarro)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.lblArt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ModificarVenta"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents rbEmpresa As RadioButton
    Friend WithEvents rbPersona As RadioButton
    Friend WithEvents btnBusc As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnNuev As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblCant As Label
    Friend WithEvents lblCarro As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents a As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewButtonColumn
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblArt As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewButtonColumn
End Class
