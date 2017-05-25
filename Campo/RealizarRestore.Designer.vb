<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RealizarRestore
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
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.btnExam = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnRealizar = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOrigen
        '
        Me.lblOrigen.AutoSize = True
        Me.lblOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrigen.Location = New System.Drawing.Point(12, 24)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(100, 15)
        Me.lblOrigen.TabIndex = 58
        Me.lblOrigen.Text = "Origen archivo"
        '
        'btnExam
        '
        Me.btnExam.Location = New System.Drawing.Point(468, 16)
        Me.btnExam.Name = "btnExam"
        Me.btnExam.Size = New System.Drawing.Size(75, 23)
        Me.btnExam.TabIndex = 57
        Me.btnExam.Text = "Examinar..."
        Me.btnExam.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(138, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(324, 20)
        Me.TextBox2.TabIndex = 56
        '
        'btnRealizar
        '
        Me.btnRealizar.BackColor = System.Drawing.Color.Chartreuse
        Me.btnRealizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRealizar.Location = New System.Drawing.Point(117, 70)
        Me.btnRealizar.Name = "btnRealizar"
        Me.btnRealizar.Size = New System.Drawing.Size(91, 45)
        Me.btnRealizar.TabIndex = 60
        Me.btnRealizar.Text = "Realizar Restore"
        Me.btnRealizar.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(387, 92)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 59
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'RealizarRestore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(564, 127)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRealizar)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblOrigen)
        Me.Controls.Add(Me.btnExam)
        Me.Controls.Add(Me.TextBox2)
        Me.Name = "RealizarRestore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Realizar Restore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOrigen As System.Windows.Forms.Label
    Friend WithEvents btnExam As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnRealizar As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
