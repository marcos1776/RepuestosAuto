Public Class ReporteArticuloMasVendidos
    Private Sub ReporteArticuloMasVendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ReportViewer1.ZoomPercent = 100
        Me.DateTimePicker1.Value = Today.Date.AddYears(-1)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub



End Class