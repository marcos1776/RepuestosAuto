Public Class ReporteVentaEspecifica

    Private idVenta As Integer

    Private Sub ReporteVentaEspecifica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VentaEspecifica.SP_VentaEspecifica' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        idVenta = TextBox1.Text

        Me.SP_VentaEspecificaTableAdapter.Fill(Me.VentaEspecifica.SP_VentaEspecifica, idVenta)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class