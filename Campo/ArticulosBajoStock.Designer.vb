<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticulosBajoStock
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Articulos"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(24, 57)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(452, 95)
        Me.ListBox1.TabIndex = 58
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(497, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 23)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "Realizar Pedido"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightSalmon
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(565, 129)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 61
        Me.Button6.Text = "Cancelar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'ArticulosBajoStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 188)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ArticulosBajoStock"
        Me.Text = "Articulos con bajo stock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
