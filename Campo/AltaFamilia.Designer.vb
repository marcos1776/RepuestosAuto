<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaFamilia
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAgre = New System.Windows.Forms.Button()
        Me.lblPat = New System.Windows.Forms.Label()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(109, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(233, 21)
        Me.TextBox1.TabIndex = 0
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(19, 17)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 15)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(267, 287)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnAgre
        '
        Me.btnAgre.BackColor = System.Drawing.Color.Chartreuse
        Me.btnAgre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgre.Location = New System.Drawing.Point(22, 265)
        Me.btnAgre.Name = "btnAgre"
        Me.btnAgre.Size = New System.Drawing.Size(91, 45)
        Me.btnAgre.TabIndex = 43
        Me.btnAgre.Text = "Agregar Familia"
        Me.btnAgre.UseVisualStyleBackColor = False
        '
        'lblPat
        '
        Me.lblPat.AutoSize = True
        Me.lblPat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPat.Location = New System.Drawing.Point(19, 46)
        Me.lblPat.Name = "lblPat"
        Me.lblPat.Size = New System.Drawing.Size(63, 15)
        Me.lblPat.TabIndex = 46
        Me.lblPat.Text = "Patentes"
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Location = New System.Drawing.Point(22, 75)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(320, 184)
        Me.CheckedListBox2.TabIndex = 45
        '
        'AltaFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(364, 334)
        Me.Controls.Add(Me.lblPat)
        Me.Controls.Add(Me.CheckedListBox2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAgre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "AltaFamilia"
        Me.Text = "Nueva Familia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAgre As System.Windows.Forms.Button
    Friend WithEvents lblPat As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox2 As System.Windows.Forms.CheckedListBox
End Class
