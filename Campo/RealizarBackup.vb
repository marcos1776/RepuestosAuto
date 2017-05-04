Imports System.IO

Public Class RealizarBackup

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Visible = True
        'Label2.Visible = True
        TextBox3.Visible = True
        'ComboBox1.Visible = True

    End Sub

    Private Sub RealizarBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        'Label2.Visible = False
        TextBox3.Visible = False
        'ComboBox1.Visible = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Visible = False
        'Label2.Visible = False
        TextBox3.Visible = False
        'ComboBox1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim fd As OpenFileDialog = New OpenFileDialog()

        Dim fd As New FolderBrowserDialog
        fd.Description = "Seleccione el directorio a generar el archivo"


        Dim strFileName As String

            'fd.Title = "Seleccione el directorio a generar el archivo"
            'fd.InitialDirectory = "C:\Users\marcos.lampacrescia\Desktop\Marcos\Marce"
            'fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
            'fd.FilterIndex = 2
            'fd.RestoreDirectory = True

            If fd.ShowDialog() = DialogResult.OK Then
            'strFileName = fd.FileName
            strFileName = fd.SelectedPath.ToString
            'TextBox1.Text = strFileName
            'Dim prov As New BLL.Proveedor
            'prov.cargarArticuloProveedor(strFileName)


            TextBox1.Text = strFileName


        End If


    End Sub

    'Realizar Back UP
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim seg As New BLL.Seguridad("Password")

        'Poner acà la direccion de la base
        Dim fichero As New FileInfo("ASDA")
        Dim tamañoFile As Double
        Dim cantPartes As Integer

        tamañoFile = fichero.Length


        ' Backup por partes
        If RadioButton1.Checked Then
            cantPartes = TextBox3.Text
            If seg.RealizarBackUpPorPartes(cantPartes, TextBox1.Text, TextBox2.Text & " ") Then
                MessageBox.Show("Back up realizado correctamente")
                'seg.registrarBitacora()

            Else
                MessageBox.Show("Error al realizar backup")
                'seg.registrarBitacora()
            End If
        Else
            'Back up completo
            'If seg.RealizarBackUp(txtDestino.Text, txtNombre.Text & " ") Then

            'End If
        End If



    End Sub
End Class