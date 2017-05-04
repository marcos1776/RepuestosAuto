<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarBitacora
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
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblCriticidad = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblMovimientos = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesde.Location = New System.Drawing.Point(34, 17)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(48, 15)
        Me.lblDesde.TabIndex = 8
        Me.lblDesde.Text = "Desde"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.Location = New System.Drawing.Point(38, 55)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(44, 15)
        Me.lblHasta.TabIndex = 9
        Me.lblHasta.Text = "Hasta"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(233, 18)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(57, 15)
        Me.lblUsuario.TabIndex = 10
        Me.lblUsuario.Text = "Usuario"
        '
        'lblCriticidad
        '
        Me.lblCriticidad.AutoSize = True
        Me.lblCriticidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriticidad.Location = New System.Drawing.Point(222, 55)
        Me.lblCriticidad.Name = "lblCriticidad"
        Me.lblCriticidad.Size = New System.Drawing.Size(68, 15)
        Me.lblCriticidad.TabIndex = 11
        Me.lblCriticidad.Text = "Criticidad"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(318, 11)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(166, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Alta", "Media", "Baja"})
        Me.ComboBox2.Location = New System.Drawing.Point(318, 49)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(166, 21)
        Me.ComboBox2.TabIndex = 13
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Chartreuse
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(532, 25)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(91, 45)
        Me.btnBuscar.TabIndex = 43
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 139)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(586, 280)
        Me.DataGridView1.TabIndex = 44
        '
        'lblMovimientos
        '
        Me.lblMovimientos.AutoSize = True
        Me.lblMovimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovimientos.Location = New System.Drawing.Point(38, 109)
        Me.lblMovimientos.Name = "lblMovimientos"
        Me.lblMovimientos.Size = New System.Drawing.Size(88, 15)
        Me.lblMovimientos.TabIndex = 45
        Me.lblMovimientos.Text = "Movimientos"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(548, 447)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 60
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(99, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePicker1.TabIndex = 61
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(99, 51)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePicker2.TabIndex = 62
        '
        'ConsultarBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(653, 504)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblMovimientos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblCriticidad)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblHasta)
        Me.Controls.Add(Me.lblDesde)
        Me.Name = "ConsultarBitacora"
        Me.Text = "Bitácora"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblCriticidad As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblMovimientos As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
End Class
