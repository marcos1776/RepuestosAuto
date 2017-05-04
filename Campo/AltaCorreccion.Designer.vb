<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaCorreccion
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Condición"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 369)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Perdida / Robo", "Stock Mayor al esperado"})
        Me.ComboBox1.Location = New System.Drawing.Point(106, 13)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(202, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Buscar"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(106, 84)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(202, 20)
        Me.TextBox1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Articulos Disponibles"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(96, 364)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(64, 20)
        Me.txtCantidad.TabIndex = 11
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Chartreuse
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(22, 409)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(91, 45)
        Me.btnAgregar.TabIndex = 46
        Me.btnAgregar.Text = "Agregar Corrección"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightSalmon
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(318, 431)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 45
        Me.Button6.Text = "Cancelar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 129)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(372, 215)
        Me.DataGridView1.TabIndex = 47
        '
        'AltaCorreccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(412, 456)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AltaCorreccion"
        Me.Text = "Nueva correcion de stock"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
