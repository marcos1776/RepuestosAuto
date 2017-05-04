<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteListadoVentas
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(399, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Monto Máximo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Monto Minimo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Desde"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(317, 20)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(238, 21)
        Me.ComboBox1.TabIndex = 15
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(491, 60)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(64, 20)
        Me.TextBox2.TabIndex = 14
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(317, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(64, 20)
        Me.TextBox1.TabIndex = 13
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(81, 57)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(118, 20)
        Me.DateTimePicker2.TabIndex = 12
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(81, 21)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(118, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(609, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Generar Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 105)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(735, 352)
        Me.ReportViewer1.TabIndex = 22
        '
        'ReporteListadoVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 469)
        Me.Controls.Add(Me.ReportViewer1)
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
        Me.Name = "ReporteListadoVentas"
        Me.Text = "ReporteListadoVentas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
