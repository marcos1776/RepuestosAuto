<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignarUsuarioPatente
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
        Me.btnEliminarNeg = New System.Windows.Forms.Button()
        Me.btnAgregarNeg = New System.Windows.Forms.Button()
        Me.treePatNeg = New System.Windows.Forms.TreeView()
        Me.treePatentes = New System.Windows.Forms.TreeView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminarPat = New System.Windows.Forms.Button()
        Me.btnAgregarPat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.treePatUsu = New System.Windows.Forms.TreeView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEliminarNeg
        '
        Me.btnEliminarNeg.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEliminarNeg.Location = New System.Drawing.Point(562, 209)
        Me.btnEliminarNeg.Name = "btnEliminarNeg"
        Me.btnEliminarNeg.Size = New System.Drawing.Size(66, 23)
        Me.btnEliminarNeg.TabIndex = 39
        Me.btnEliminarNeg.Text = "Denegar"
        Me.btnEliminarNeg.UseVisualStyleBackColor = True
        '
        'btnAgregarNeg
        '
        Me.btnAgregarNeg.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgregarNeg.Location = New System.Drawing.Point(562, 142)
        Me.btnAgregarNeg.Name = "btnAgregarNeg"
        Me.btnAgregarNeg.Size = New System.Drawing.Size(66, 23)
        Me.btnAgregarNeg.TabIndex = 38
        Me.btnAgregarNeg.Text = "Negar"
        Me.btnAgregarNeg.UseVisualStyleBackColor = True
        '
        'treePatNeg
        '
        Me.treePatNeg.Location = New System.Drawing.Point(644, 69)
        Me.treePatNeg.Name = "treePatNeg"
        Me.treePatNeg.Size = New System.Drawing.Size(202, 355)
        Me.treePatNeg.TabIndex = 30
        '
        'treePatentes
        '
        Me.treePatentes.Location = New System.Drawing.Point(333, 69)
        Me.treePatentes.Name = "treePatentes"
        Me.treePatentes.Size = New System.Drawing.Size(202, 355)
        Me.treePatentes.TabIndex = 29
        '
        'btnSalir
        '
        Me.btnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSalir.Location = New System.Drawing.Point(771, 445)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminarPat
        '
        Me.btnEliminarPat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEliminarPat.Location = New System.Drawing.Point(251, 209)
        Me.btnEliminarPat.Name = "btnEliminarPat"
        Me.btnEliminarPat.Size = New System.Drawing.Size(62, 23)
        Me.btnEliminarPat.TabIndex = 30
        Me.btnEliminarPat.Text = "Quitar"
        Me.btnEliminarPat.UseVisualStyleBackColor = True
        '
        'btnAgregarPat
        '
        Me.btnAgregarPat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgregarPat.Location = New System.Drawing.Point(251, 142)
        Me.btnAgregarPat.Name = "btnAgregarPat"
        Me.btnAgregarPat.Size = New System.Drawing.Size(62, 23)
        Me.btnAgregarPat.TabIndex = 29
        Me.btnAgregarPat.Text = "Añadir"
        Me.btnAgregarPat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(22, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Usuario"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(92, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(130, 21)
        Me.ComboBox1.TabIndex = 40
        '
        'treePatUsu
        '
        Me.treePatUsu.Location = New System.Drawing.Point(26, 69)
        Me.treePatUsu.Name = "treePatUsu"
        Me.treePatUsu.Size = New System.Drawing.Size(196, 355)
        Me.treePatUsu.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Listado Patentes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(330, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Asignadas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(641, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Negadas"
        '
        'AsignarUsuarioPatente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 480)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.treePatNeg)
        Me.Controls.Add(Me.treePatentes)
        Me.Controls.Add(Me.treePatUsu)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnEliminarNeg)
        Me.Controls.Add(Me.btnAgregarNeg)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminarPat)
        Me.Controls.Add(Me.btnAgregarPat)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AsignarUsuarioPatente"
        Me.Text = "AsignarUsuarioPatente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEliminarNeg As Button
    Friend WithEvents btnAgregarNeg As Button
    Friend WithEvents treePatNeg As TreeView
    Friend WithEvents treePatentes As TreeView
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminarPat As Button
    Friend WithEvents btnAgregarPat As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents treePatUsu As TreeView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
