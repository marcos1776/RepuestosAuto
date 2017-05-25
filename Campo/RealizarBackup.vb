Imports System.IO

Public Class RealizarBackup

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        'MenuPrincipal.Show()
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        lblParte.Visible = True
        'Label2.Visible = True
        TextBox3.Visible = True
        'ComboBox1.Visible = True

    End Sub

    Private Sub RealizarBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        lblParte.Visible = False
        'Label2.Visible = False
        TextBox3.Visible = False
        'ComboBox1.Visible = False

        Dim seguridad As New BLL.Seguridad("Password")
        Dim dtMensajes As New DataTable()
        dtMensajes = seguridad.ObtenerMensajes(Login.ID_IDIOMA, 20)


        lblDestino.Text = dtMensajes.Rows(0).Item(5).ToString
        lblNombre.Text = dtMensajes.Rows(1).Item(5).ToString
        lblParticion.Text = dtMensajes.Rows(2).Item(5).ToString
        RadioButton1.Text = dtMensajes.Rows(3).Item(5).ToString
        RadioButton2.Text = dtMensajes.Rows(4).Item(5).ToString
        btnExamin.Text = dtMensajes.Rows(5).Item(5).ToString
        btnReali.Text = dtMensajes.Rows(6).Item(5).ToString
        btnCancel.Text = dtMensajes.Rows(7).Item(5).ToString
        lblParte.Text = dtMensajes.Rows(8).Item(5).ToString

        If Login.ID_IDIOMA <> 1 Then
            Me.Text = "Generate Backup"
        End If



    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        lblParte.Visible = False
        'Label2.Visible = False
        TextBox3.Visible = False
        'ComboBox1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExamin.Click
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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnReali.Click
        Dim seg As New BLL.Seguridad("Password")

        'Poner acà la direccion de la base
        Dim fichero As New FileInfo("ASDA")
        Dim tamañoFile As Double
        Dim cantPartes As Integer

        'tamañoFile = fichero.Length

        Dim idBitacora As Integer = seg.registrarBitacora(Login.ID_USUARIO, "Media", DateTime.Now, "Backup realizado correctamente", 0)


        ' Backup por partes
        If RadioButton1.Checked Then
            cantPartes = TextBox3.Text
            If seg.RealizarBackUpPorPartes(cantPartes, TextBox1.Text, TextBox2.Text & " ") Then
                If Login.ID_IDIOMA = 1 Then
                    MessageBox.Show("Backup realizado correctamente")
                Else
                    MessageBox.Show("Backup done succesfully")
                End If
            Else
                If Login.ID_IDIOMA = 1 Then
                    MessageBox.Show("Error al realizar backup")
                Else
                    MessageBox.Show("Error doing the backup. Please retry")
                End If


            End If
        Else
            'Back up completo
            If seg.RealizarBackUp(TextBox1.Text, TextBox2.Text & " ") Then

            End If
        End If


    End Sub

    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        lblParte.Visible = False
        TextBox3.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        lblParte.Visible = True
        TextBox3.Visible = True
    End Sub
End Class