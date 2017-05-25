<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AsignacionUsuarioPatentes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblPat = New System.Windows.Forms.Label()
        Me.lblFam = New System.Windows.Forms.Label()
        Me.lblPatAs = New System.Windows.Forms.Label()
        Me.lblFamAsig = New System.Windows.Forms.Label()
        Me.lblPatNeg = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'lblPat
        '
        Me.lblPat.AutoSize = True
        Me.lblPat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPat.Location = New System.Drawing.Point(12, 42)
        Me.lblPat.Name = "lblPat"
        Me.lblPat.Size = New System.Drawing.Size(63, 15)
        Me.lblPat.TabIndex = 51
        Me.lblPat.Text = "Patentes"
        '
        'lblFam
        '
        Me.lblFam.AutoSize = True
        Me.lblFam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFam.Location = New System.Drawing.Point(543, 51)
        Me.lblFam.Name = "lblFam"
        Me.lblFam.Size = New System.Drawing.Size(62, 15)
        Me.lblFam.TabIndex = 55
        Me.lblFam.Text = "Familias"
        '
        'lblPatAs
        '
        Me.lblPatAs.AutoSize = True
        Me.lblPatAs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatAs.Location = New System.Drawing.Point(291, 42)
        Me.lblPatAs.Name = "lblPatAs"
        Me.lblPatAs.Size = New System.Drawing.Size(133, 15)
        Me.lblPatAs.TabIndex = 62
        Me.lblPatAs.Text = "Patentes Asignadas"
        '
        'lblFamAsig
        '
        Me.lblFamAsig.AutoSize = True
        Me.lblFamAsig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFamAsig.Location = New System.Drawing.Point(835, 54)
        Me.lblFamAsig.Name = "lblFamAsig"
        Me.lblFamAsig.Size = New System.Drawing.Size(132, 15)
        Me.lblFamAsig.TabIndex = 64
        Me.lblFamAsig.Text = "Familias Asignadas"
        '
        'lblPatNeg
        '
        Me.lblPatNeg.AutoSize = True
        Me.lblPatNeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatNeg.Location = New System.Drawing.Point(291, 275)
        Me.lblPatNeg.Name = "lblPatNeg"
        Me.lblPatNeg.Size = New System.Drawing.Size(122, 15)
        Me.lblPatNeg.TabIndex = 66
        Me.lblPatNeg.Text = "Patentes negadas"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(342, 18)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(57, 15)
        Me.lblUsuario.TabIndex = 67
        Me.lblUsuario.Text = "Usuario"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(410, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(150, 21)
        Me.ComboBox1.TabIndex = 68
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Chartreuse
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(957, 504)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(91, 45)
        Me.btnVolver.TabIndex = 69
        Me.btnVolver.Text = "Volver al Menu"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(231, 123)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(47, 23)
        Me.Button7.TabIndex = 81
        Me.Button7.Text = ">"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(231, 164)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(47, 23)
        Me.Button8.TabIndex = 82
        Me.Button8.Text = "<"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(231, 334)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(47, 23)
        Me.Button9.TabIndex = 83
        Me.Button9.Text = ">"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(231, 374)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(47, 23)
        Me.Button10.TabIndex = 84
        Me.Button10.Text = "<"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(775, 219)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(47, 23)
        Me.Button11.TabIndex = 85
        Me.Button11.Text = ">"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(775, 279)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(47, 23)
        Me.Button12.TabIndex = 86
        Me.Button12.Text = "<"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(9, 74)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(213, 420)
        Me.ListBox1.TabIndex = 87
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(294, 74)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(213, 186)
        Me.ListBox2.TabIndex = 88
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(294, 308)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(213, 186)
        Me.ListBox3.TabIndex = 89
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(546, 74)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(210, 420)
        Me.TreeView1.TabIndex = 90
        '
        'TreeView2
        '
        Me.TreeView2.Location = New System.Drawing.Point(838, 74)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(210, 420)
        Me.TreeView2.TabIndex = 91
        '
        'AsignacionUsuarioPatentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1071, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblPatNeg)
        Me.Controls.Add(Me.lblFamAsig)
        Me.Controls.Add(Me.lblPatAs)
        Me.Controls.Add(Me.lblFam)
        Me.Controls.Add(Me.lblPat)
        Me.Name = "AsignacionUsuarioPatentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignación Usuario - Familia - Patentes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPat As System.Windows.Forms.Label
    Friend WithEvents lblFam As System.Windows.Forms.Label
    Friend WithEvents lblPatAs As System.Windows.Forms.Label
    Friend WithEvents lblFamAsig As System.Windows.Forms.Label
    Friend WithEvents lblPatNeg As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents TreeView2 As TreeView
End Class
