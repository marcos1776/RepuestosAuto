<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaVenta
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
        Me.lblArt = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblCarro = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNuev = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.btnBusc = New System.Windows.Forms.Button()
        Me.rbPersona = New System.Windows.Forms.RadioButton()
        Me.rbEmpresa = New System.Windows.Forms.RadioButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblArt
        '
        Me.lblArt.AutoSize = True
        Me.lblArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArt.Location = New System.Drawing.Point(221, 73)
        Me.lblArt.Name = "lblArt"
        Me.lblArt.Size = New System.Drawing.Size(62, 15)
        Me.lblArt.TabIndex = 43
        Me.lblArt.Text = "Articulos"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Precio, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 120)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(451, 149)
        Me.DataGridView1.TabIndex = 42
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Descripcion"
        Me.Column2.Name = "Column2"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Accion"
        Me.Column3.Name = "Column3"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(102, 94)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(303, 20)
        Me.TextBox3.TabIndex = 49
        '
        'lblCarro
        '
        Me.lblCarro.AutoSize = True
        Me.lblCarro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarro.Location = New System.Drawing.Point(6, 288)
        Me.lblCarro.Name = "lblCarro"
        Me.lblCarro.Size = New System.Drawing.Size(102, 15)
        Me.lblCarro.TabIndex = 51
        Me.lblCarro.Text = "Carro de Venta"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.a, Me.Column4, Me.Column5, Me.Column6, Me.Subtotal, Me.Column8})
        Me.DataGridView2.Location = New System.Drawing.Point(9, 318)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(451, 135)
        Me.DataGridView2.TabIndex = 50
        '
        'a
        '
        Me.a.HeaderText = "Código"
        Me.a.Name = "a"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Descripcion"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Precio"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Cantidad"
        Me.Column6.Name = "Column6"
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Accion"
        Me.Column8.Name = "Column8"
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant.Location = New System.Drawing.Point(9, 73)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(64, 15)
        Me.lblCant.TabIndex = 52
        Me.lblCant.Text = "Cantidad"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(385, 495)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 28)
        Me.btnCancel.TabIndex = 57
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnNuev
        '
        Me.btnNuev.BackColor = System.Drawing.Color.Chartreuse
        Me.btnNuev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuev.Location = New System.Drawing.Point(9, 478)
        Me.btnNuev.Name = "btnNuev"
        Me.btnNuev.Size = New System.Drawing.Size(91, 45)
        Me.btnNuev.TabIndex = 58
        Me.btnNuev.Text = "Nueva Venta"
        Me.btnNuev.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(294, 464)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(79, 25)
        Me.lblTotal.TabIndex = 59
        Me.lblTotal.Text = "Total: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1277, 430)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 25)
        Me.Label7.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1271, 442)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 61
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(9, 15)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(52, 15)
        Me.lblCliente.TabIndex = 76
        Me.lblCliente.Text = "Cliente"
        '
        'btnBusc
        '
        Me.btnBusc.Location = New System.Drawing.Point(299, 10)
        Me.btnBusc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBusc.Name = "btnBusc"
        Me.btnBusc.Size = New System.Drawing.Size(61, 25)
        Me.btnBusc.TabIndex = 78
        Me.btnBusc.Text = "Buscar"
        Me.btnBusc.UseVisualStyleBackColor = True
        '
        'rbPersona
        '
        Me.rbPersona.AutoSize = True
        Me.rbPersona.Location = New System.Drawing.Point(105, 14)
        Me.rbPersona.Margin = New System.Windows.Forms.Padding(2)
        Me.rbPersona.Name = "rbPersona"
        Me.rbPersona.Size = New System.Drawing.Size(64, 17)
        Me.rbPersona.TabIndex = 79
        Me.rbPersona.TabStop = True
        Me.rbPersona.Text = "Persona"
        Me.rbPersona.UseVisualStyleBackColor = True
        '
        'rbEmpresa
        '
        Me.rbEmpresa.AutoSize = True
        Me.rbEmpresa.Location = New System.Drawing.Point(211, 12)
        Me.rbEmpresa.Margin = New System.Windows.Forms.Padding(2)
        Me.rbEmpresa.Name = "rbEmpresa"
        Me.rbEmpresa.Size = New System.Drawing.Size(66, 17)
        Me.rbEmpresa.TabIndex = 80
        Me.rbEmpresa.TabStop = True
        Me.rbEmpresa.Text = "Empresa"
        Me.rbEmpresa.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(9, 94)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(79, 20)
        Me.TextBox2.TabIndex = 81
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(363, 464)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 25)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = " "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(105, 38)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(172, 20)
        Me.TextBox1.TabIndex = 77
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(385, 11)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(61, 23)
        Me.btnNuevo.TabIndex = 83
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'AltaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(469, 533)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.rbEmpresa)
        Me.Controls.Add(Me.rbPersona)
        Me.Controls.Add(Me.btnBusc)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnNuev)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblCant)
        Me.Controls.Add(Me.lblCarro)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.lblArt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AltaVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Venta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblArt As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblCarro As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents lblCant As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnNuev As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents btnBusc As System.Windows.Forms.Button
    Friend WithEvents rbPersona As System.Windows.Forms.RadioButton
    Friend WithEvents rbEmpresa As System.Windows.Forms.RadioButton
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents a As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
End Class
