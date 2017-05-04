<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargarStockAProveedor
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(128, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(229, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(39, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 15)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Proveedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 15)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Destino archivo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(683, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 81
        Me.Button1.Text = "Examinar..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(128, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(549, 20)
        Me.TextBox1.TabIndex = 80
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Chartreuse
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(201, 95)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 45)
        Me.Button3.TabIndex = 84
        Me.Button3.Text = "Cargar Artículos"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightSalmon
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(476, 116)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 83
        Me.Button6.Text = "Cancelar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'CargarStockAProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(770, 155)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "CargarStockAProveedor"
        Me.Text = "Cargar articulos a Proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
