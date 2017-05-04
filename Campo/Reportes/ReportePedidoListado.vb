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

End Class