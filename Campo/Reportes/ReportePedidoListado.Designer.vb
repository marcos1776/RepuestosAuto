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
        Me.SP_ListadoComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprasListado = New Campo.ComprasListado()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
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
        Me.SP_ListadoComprasTableAdapter = New Campo.ComprasListadoTableAdapters.SP_ListadoComprasTableAdapter()
        CType(Me.SP_ListadoComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ReportViewer1
        '
        ReportDataSource1.Name = "CompraListado"
        ReportDataSource1.Value = Me.SP_ListadoComprasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Campo.PedidoListado.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, 95)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(810, 375)
        Me.ReportViewer1.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(81, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(118, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(81, 48)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(118, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(405, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(64, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(579, 51)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(64, 20)
        Me.TextBox2.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(405, 11)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(238, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(326, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(326, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Monto Minimo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(487, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Monto Máximo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(680, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Generar Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SP_ListadoComprasTableAdapter
        '
        Me.SP_ListadoComprasTableAdapter.ClearBeforeFill = True
        '
        'ReportePedidoListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 469)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReportePedidoListado"
        Me.Text = "PedidoListado"
        CType(Me.SP_ListadoComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
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
End Class
