<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RealizarBackup
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
        Me.btnReali = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblParte = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnExamin = New System.Windows.Forms.Button()
        Me.lblDestino = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.lblParticion = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnReali
        '
        Me.btnReali.BackColor = System.Drawing.Color.Chartreuse
        Me.btnReali.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReali.Location = New System.Drawing.Point(44, 184)
        Me.btnReali.Name = "btnReali"
        Me.btnReali.Size = New System.Drawing.Size(121, 45)
        Me.btnReali.TabIndex = 48
        Me.btnReali.Text = "Realizar Backup"
        Me.btnReali.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(433, 184)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(121, 45)
        Me.btnCancel.TabIndex = 47
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblParte
        '
        Me.lblParte.AutoSize = True
        Me.lblParte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParte.Location = New System.Drawing.Point(40, 139)
        Me.lblParte.Name = "lblParte"
        Me.lblParte.Size = New System.Drawing.Size(85, 20)
        Me.lblParte.TabIndex = 49
        Me.lblParte.Text = "Nº Partes"
        Me.lblParte.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(144, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(410, 20)
        Me.TextBox1.TabIndex = 53
        '
        'btnExamin
        '
        Me.btnExamin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExamin.Location = New System.Drawing.Point(572, 10)
        Me.btnExamin.Name = "btnExamin"
        Me.btnExamin.Size = New System.Drawing.Size(91, 23)
        Me.btnExamin.TabIndex = 54
        Me.btnExamin.Text = "Examinar..."
        Me.btnExamin.UseVisualStyleBackColor = True
        '
        'lblDestino
        '
        Me.lblDestino.AutoSize = True
        Me.lblDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestino.Location = New System.Drawing.Point(5, 12)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(133, 20)
        Me.lblDestino.TabIndex = 55
        Me.lblDestino.Text = "Destino archivo"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(67, 56)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(71, 20)
        Me.lblNombre.TabIndex = 56
        Me.lblNombre.Text = "Nombre"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(144, 56)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(255, 20)
        Me.TextBox2.TabIndex = 57
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(144, 139)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(96, 20)
        Me.TextBox3.TabIndex = 62
        Me.TextBox3.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(230, 98)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(41, 22)
        Me.RadioButton1.TabIndex = 63
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Si"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'lblParticion
        '
        Me.lblParticion.AutoSize = True
        Me.lblParticion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParticion.Location = New System.Drawing.Point(-1, 100)
        Me.lblParticion.Name = "lblParticion"
        Me.lblParticion.Size = New System.Drawing.Size(139, 20)
        Me.lblParticion.TabIndex = 64
        Me.lblParticion.Text = "¿ Particionado ?"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(165, 98)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(48, 22)
        Me.RadioButton2.TabIndex = 65
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RealizarBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(664, 231)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.lblParticion)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblDestino)
        Me.Controls.Add(Me.btnExamin)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblParte)
        Me.Controls.Add(Me.btnReali)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "RealizarBackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Realizar Backup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReali As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblParte As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnExamin As System.Windows.Forms.Button
    Friend WithEvents lblDestino As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents lblParticion As Label
    Friend WithEvents RadioButton2 As RadioButton
End Class
