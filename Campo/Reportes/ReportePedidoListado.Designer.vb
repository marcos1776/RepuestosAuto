<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportePedidoListado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SP_ListadoComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprasListado = New Campo.ComprasListado()
        Me.SP_ListadoComprasTableAdapter = New Campo.ComprasListadoTableAdapters.SP_ListadoComprasTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListadoVentas = New Campo.ListadoVentas()
        Me.SP_ListadoVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ListadoVentasTableAdapter = New Campo.ListadoVentasTableAdapters.SP_ListadoVentasTableAdapter()
        Me.CompraUnitaria = New Campo.CompraUnitaria()
        Me.SP_CompraEspecificaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CompraEspecificaTableAdapter = New Campo.CompraUnitariaTableAdapters.SP_CompraEspecificaTableAdapter()
        CType(Me.SP_ListadoComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ListadoVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ListadoVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraUnitaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CompraEspecificaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(104, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(118, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(104, 55)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(118, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(388, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(64, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(602, 54)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(64, 20)
        Me.TextBox2.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(388, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(278, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(262, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(262, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Monto Minimo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(472, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Monto Máximo"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LimeGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(703, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 42)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Generar Reporte"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(855, 314)
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSize = True
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_CompraEspecificaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Campo.Rpt_PedidoEspecifico.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(27, 122)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1182, 553)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage
        '
        'SP_ListadoComprasBindingSource
        '
        Me.SP_ListadoComprasBindingSource.DataMember = "SP_ListadoCompras"
        Me.SP_ListadoComprasBindingSource.DataSource = Me.ComprasListado
        '
        'ComprasListado
        '
        Me.ComprasListado.DataSetName = "ComprasListado"
        Me.ComprasListado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_ListadoComprasTableAdapter
        '
        Me.SP_ListadoComprasTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(182, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(849, 100)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSalmon
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(703, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 43)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ListadoVentas
        '
        Me.ListadoVentas.DataSetName = "ListadoVentas"
        Me.ListadoVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_ListadoVentasBindingSource
        '
        Me.SP_ListadoVentasBindingSource.DataMember = "SP_ListadoVentas"
        Me.SP_ListadoVentasBindingSource.DataSource = Me.ListadoVentas
        '
        'SP_ListadoVentasTableAdapter
        '
        Me.SP_ListadoVentasTableAdapter.ClearBeforeFill = True
        '
        'CompraUnitaria
        '
        Me.CompraUnitaria.DataSetName = "CompraUnitaria"
        Me.CompraUnitaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_CompraEspecificaBindingSource
        '
        Me.SP_CompraEspecificaBindingSource.DataMember = "SP_CompraEspecifica"
        Me.SP_CompraEspecificaBindingSource.DataSource = Me.CompraUnitaria
        '
        'SP_CompraEspecificaTableAdapter
        '
        Me.SP_CompraEspecificaTableAdapter.ClearBeforeFill = True
        '
        'ReportePedidoListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1232, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReportePedidoListado"
        Me.Text = "Listado de Pedidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SP_ListadoComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ListadoVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ListadoVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraUnitaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CompraEspecificaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents SP_ListadoComprasBindingSource As BindingSource
    Friend WithEvents ComprasListado As ComprasListado
    Friend WithEvents SP_ListadoComprasTableAdapter As ComprasListadoTableAdapters.SP_ListadoComprasTableAdapter
    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents SP_ListadoVentasBindingSource As BindingSource
    Friend WithEvents ListadoVentas As ListadoVentas
    Friend WithEvents SP_ListadoVentasTableAdapter As ListadoVentasTableAdapters.SP_ListadoVentasTableAdapter
    Friend WithEvents SP_CompraEspecificaBindingSource As BindingSource
    Friend WithEvents CompraUnitaria As CompraUnitaria
    Friend WithEvents SP_CompraEspecificaTableAdapter As CompraUnitariaTableAdapters.SP_CompraEspecificaTableAdapter
End Class
