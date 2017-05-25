Imports System.IO
Public Class Inicio
    Private Async Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        'Me.MdiParent = MenuPrincipal

        Dim i As Integer

        For i = 0 To 100
            Label1.Text = i & " %"
            ProgressBar1.Value = i

            If i > 0 And i < 19 Then
                Label2.Text = "Cargando Aplicación"
            End If

            If i = 20 Then
                Label2.Text = "Estableciendo conexión con la Base de Datos"

                'Agregar  el codigo

                validarConectionString()



                '



            End If

            If i = 40 Then
                Label2.Text = "Cargando Idiomas"
            End If

            If i = 60 Then
                Label2.Text = "Cargando Perfiles"
            End If

            If i = 100 Then
                Button1.Enabled = True
            End If

            Await Task.Delay(10)
        Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'Dim men As New MenuPrincipal
        'men.Show()

        Dim log As New Login()
        log.Show()

        Me.Hide()

        'Log.MdiParent = men
        'Log.Show()

    End Sub


    Public Sub validarConectionString()
        Dim bd As New BLL.BaseDeDatos()
        Dim seg As New BLL.Seguridad("Password")

        If Directory.Exists("C:\ConnectionString") Then

            Dim connection As String = File.ReadAllText("C:\ConnectionString\\Cadena.txt")

            bd.ConnectionString = seg.Desencriptar(connection)

        Else
            MessageBox.Show("Configuración de base de datos no encontrada")
            Dim config As New ConfigurarConnectionString()
            config.Show()
            Me.Hide()
        End If
    End Sub



End Class