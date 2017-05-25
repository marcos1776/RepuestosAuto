<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarContraseña
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
        Me.lblConfir = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblNuev = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblAnt = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblConfir
        '
        Me.lblConfir.AutoSize = True
        Me.lblConfir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfir.Location = New System.Drawing.Point(23, 83)
        Me.lblConfir.Name = "lblConfir"
        Me.lblConfir.Size = New System.Drawing.Size(145, 15)
        Me.lblConfir.TabIndex = 12
        Me.lblConfir.Text = "Confirmar contraseña"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(173, 78)
        Me.TextBox3.MaxLength = 40
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox3.Size = New System.Drawing.Size(202, 20)
        Me.TextBox3.TabIndex = 11
        '
        'lblNuev
        '
        Me.lblNuev.AutoSize = True
        Me.lblNuev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuev.Location = New System.Drawing.Point(23, 50)
        Me.lblNuev.Name = "lblNuev"
        Me.lblNuev.Size = New System.Drawing.Size(122, 15)
        Me.lblNuev.TabIndex = 14
        Me.lblNuev.Text = "Nueva contraseña"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(173, 45)
        Me.TextBox2.MaxLength = 40
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(202, 20)
        Me.TextBox2.TabIndex = 13
        '
        'btnModif
        '
        Me.btnModif.BackColor = System.Drawing.Color.Chartreuse
        Me.btnModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModif.Location = New System.Drawing.Point(66, 128)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(91, 45)
        Me.btnModif.TabIndex = 48
        Me.btnModif.Text = "Modificar Contraseña"
        Me.btnModif.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(306, 150)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 47
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblAnt
        '
        Me.lblAnt.AutoSize = True
        Me.lblAnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnt.Location = New System.Drawing.Point(23, 17)
        Me.lblAnt.Name = "lblAnt"
        Me.lblAnt.Size = New System.Drawing.Size(134, 15)
        Me.lblAnt.TabIndex = 50
        Me.lblAnt.Text = "Contraseña Anterior"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(173, 14)
        Me.TextBox1.MaxLength = 40
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(202, 20)
        Me.TextBox1.TabIndex = 49
        '
        'ModificarContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(386, 192)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblAnt)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnModif)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblNuev)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblConfir)
        Me.Controls.Add(Me.TextBox3)
        Me.Name = "ModificarContraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblConfir As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblNuev As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnModif As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblAnt As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
