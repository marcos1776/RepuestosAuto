Imports Microsoft.Reporting.WinForms

Public Class ReporteVentaEspecifica

    Private idVenta As Integer

    Private Sub ReporteVentaEspecifica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VentaEspecifica.SP_VentaEspecifica' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombreUsuario = Login.NombreUsuario

        Dim usuario As New ReportParameter("Usuario", nombreUsuario)
        ReportViewer1.LocalReport.SetParameters(usuario)

        idVenta = TextBox1.Text

        Dim seg As New BLL.Seguridad("Password")
        Me.SP_VentaEspecificaTableAdapter.Fill(Me.VentaEspecifica.SP_VentaEspecifica, idVenta)

        For Each row As DataRow In Me.VentaEspecifica.SP_VentaEspecifica.Rows
            row.Item(1) = seg.Desencriptar(row.Item(1).ToString)
        Next

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class