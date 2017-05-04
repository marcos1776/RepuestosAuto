Public Class ConsultarBitacora



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub


    Private Sub ConsultarBitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"

        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"


        Dim seguridad As New BLL.Seguridad("Password")
        Dim dtMensajes As New DataTable()
        dtMensajes = seguridad.ObtenerMensajes(Login.ID_IDIOMA, 9)


        lblDesde.Text = dtMensajes.Rows(0).Item(5).ToString
        lblHasta.Text = dtMensajes.Rows(1).Item(5).ToString
        lblUsuario.Text = dtMensajes.Rows(2).Item(5).ToString
        lblCriticidad.Text = dtMensajes.Rows(3).Item(5).ToString
        btnBuscar.Text = dtMensajes.Rows(4).Item(5).ToString
        btnCancelar.Text = dtMensajes.Rows(5).Item(5).ToString
        lblMovimientos.Text = dtMensajes.Rows(6).Item(5).ToString








        CargarDataGrid()
    End Sub

    Public Sub CargarDataGrid()
        ComboBox1.Items.Clear()

        Dim usuarios As New DataSet
        Dim listadoUsuarios As New BLL.Listas

        usuarios = listadoUsuarios.obtenerUsuarios()

        For Each usu As DataRow In usuarios.Tables("DatosUsuario").Rows
            ComboBox1.Items.Add(usu(2).ToString)
        Next

        Dim Movimientos As New DataTable
        Dim listadoMovimientos As New BLL.Listas
        Movimientos = listadoMovimientos.obtenerListadoMovimientos()

        DataGridView1.DataSource = Movimientos
    End Sub

    'Realizar consulta de bitacora.
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click


        Dim Movimientos As New DataTable
        Dim listadoMovimientos As New BLL.Listas
        'Movimientos = listadoMovimientos.obtenerListadoMovimientos(DateTimePicker1.Value, DateTimePicker2.Value, ComboBox1.Text, ComboBox2.Text)

        Movimientos = listadoMovimientos.obtenerListadoMovimientos(ComboBox1.Text, ComboBox2.Text, DateTimePicker1.Value.ToString("yyyy-MM-dd"), DateTimePicker2.Value.ToString("yyyy-MM-dd"))


        DataGridView1.DataSource = Movimientos
    End Sub
End Class