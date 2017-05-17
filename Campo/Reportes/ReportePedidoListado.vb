Imports Microsoft.Reporting.WinForms

Public Class ReportePedidoListado

    Private _desde As DateTime
    Private _hasta As DateTime
    Private _user As String
    Private _montoMin As Double
    Private _montoMax As Double


    Public Property desde() As DateTime
        Get
            Return _desde
        End Get
        Set(ByVal value As DateTime)
            _desde = value
        End Set
    End Property

    Public Property hasta() As DateTime
        Get
            Return _hasta
        End Get
        Set(ByVal value As DateTime)
            _hasta = value
        End Set
    End Property
    Public Property user() As String
        Get
            Return _user
        End Get
        Set(ByVal value As String)
            _user = value
        End Set
    End Property
    Public Property montoMin() As Double
        Get
            Return _montoMin
        End Get
        Set(ByVal value As Double)
            _montoMin = value
        End Set
    End Property
    Public Property montoMax() As Double
        Get
            Return _montoMax
        End Get
        Set(ByVal value As Double)
            _montoMax = value
        End Set
    End Property

    Private Sub ReportePedidoListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cargo los usuarios
        Dim ds As New DataSet
        Dim usuarios As New DataTable
        Dim listadoUsuarios As New BLL.Listas
        ds = listadoUsuarios.obtenerUsuarios()


        If ds.Tables("DatosUsuario").Select().Count > 0 Then
            usuarios = ds.Tables("DatosUsuario").Select().CopyToDataTable
            ComboBox1.DataSource = usuarios
            ComboBox1.DisplayMember = "Nick"
        End If






        'TODO: esta línea de código carga datos en la tabla 'ListadoVentas.SP_ListadoVentas' Puede moverla o quitarla según sea necesario.
        ' Me.SP_ListadoVentasTableAdapter.Fill(Me.ListadoVentas.SP_ListadoVentas)
        DateTimePicker1.Value = Today.Date.AddYears(-1)
        Me.ReportViewer1.RefreshReport()

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.desde = DateTimePicker1.Value.Date

        Me.hasta = DateTimePicker2.Value.Date

        If (TextBox1.Text = "") Then
            Me._montoMin = 0
        Else
            Me._montoMin = Convert.ToDouble(TextBox1.Text)
        End If

        If (TextBox2.Text = "") Then
            Me._montoMax = 999999999
        Else
            Me._montoMax = Convert.ToDouble(TextBox2.Text)
        End If

        If (ComboBox1.Text = "") Then
            Me.user = ""
        Else
            Me.user = ComboBox1.Text
        End If


        'Me._montoMax = Convert.ToDouble(TextBox2.Text)
        'Me.ReportePedidoListado_Load(Nothing, Nothing)
        Me.CargarReporte()
    End Sub

    Private Sub CargarReporte()
        Try
            Me.SP_ListadoComprasTableAdapter.Fill(Me.ComprasListado.SP_ListadoCompras, desde, hasta, user, montoMin, montoMax)
        Catch ex As Exception
            Me.SP_ListadoComprasTableAdapter.Fill(Me.ComprasListado.SP_ListadoCompras, desde, hasta, user, montoMin, montoMax)
        End Try

        'Dim reportParam As New ReportParameter("Textbox8", desde)
        'Me.ReportViewer1.LocalReport.SetParameters(reportParam)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class