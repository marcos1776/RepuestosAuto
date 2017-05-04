<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuarioFamilia
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(219, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(229, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(12, 89)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(237, 286)
        Me.TreeView1.TabIndex = 2
        '
        'TreeView2
        '
        Me.TreeView2.Location = New System.Drawing.Point(381, 89)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(237, 286)
        Me.TreeView2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Familias Asignadas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(378, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Listado Familias"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Chartreuse
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(527, 407)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 45)
        Me.Button4.TabIndex = 70
        Me.Button4.Text = "Volver al menu"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(294, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 39)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "--->"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(294, 210)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 39)
        Me.Button2.TabIndex = 72
        Me.Button2.Text = "<---"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'UsuarioFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 464)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "UsuarioFamilia"
        Me.Text = "UsuarioFamilia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents TreeView2 As System.Windows.Forms.TreeView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
