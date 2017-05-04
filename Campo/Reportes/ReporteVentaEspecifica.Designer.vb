<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteVentaEspecifica
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.VentaEspecifica = New Campo.VentaEspecifica()
        Me.SP_VentaEspecificaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_VentaEspecificaTableAdapter = New Campo.VentaEspecificaTableAdapters.SP_VentaEspecificaTableAdapter()
        CType(Me.VentaEspecifica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_VentaEspecificaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(334, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Id Venta"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(468, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Generar Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SP_VentaEspecificaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Campo.Rpt_VentaEspecifica.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 97)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(865, 364)
        Me.ReportViewer1.TabIndex = 10
        '
        'VentaEspecifica
        '
        Me.VentaEspecifica.DataSetName = "VentaEspecifica"
        Me.VentaEspecifica.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_VentaEspecificaBindingSource
        '
        Me.SP_VentaEspecificaBindingSource.DataMember = "SP_VentaEspecifica"
        Me.SP_VentaEspecificaBindingSource.DataSource = Me.VentaEspecifica
        '
        'SP_VentaEspecificaTableAdapter
        '
        Me.SP_VentaEspecificaTableAdapter.ClearBeforeFill = True
        '
        'ReporteVentaEspecifica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 473)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReporteVentaEspecifica"
        Me.Text = "ReporteVentaEspecifica"
        CType(Me.VentaEspecifica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_VentaEspecificaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_VentaEspecificaBindingSource As BindingSource
    Friend WithEvents VentaEspecifica As VentaEspecifica
    Friend WithEvents SP_VentaEspecificaTableAdapter As VentaEspecificaTableAdapters.SP_VentaEspecificaTableAdapter
End Class
