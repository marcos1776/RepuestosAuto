Imports System.IO

Public Class ConfigurarConnectionString

    Dim db As New BLL.BaseDeDatos
    Private Sub ConfigurarConnectionString_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bll As New BLL.BaseDeDatos

        bll.ObtenerServidores(ComboBox1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim seg As New BLL.Seguridad("Password")

        If TextBox1.Text = "" Then
            MessageBox.Show("Por favor complete los campos", "Conectar con base de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim cadena As String
            cadena = "Data Source=" & ComboBox1.Text & "\SQLEXPRESS;Initial Catalog=" & TextBox1.Text & ";Integrated Security=True"
            db.PrimeraConexion(cadena)
            Directory.CreateDirectory("C:\ConnectionString\")
            Dim file As StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("C:\ConnectionString\\Cadena.txt", True)
            file.WriteLine(seg.Encriptar(cadena))
            file.Close()
            MessageBox.Show("Conexíon generada correctamente" + ".", "Conexión a la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
            Login.Show()

        End If
    End Sub


End Class