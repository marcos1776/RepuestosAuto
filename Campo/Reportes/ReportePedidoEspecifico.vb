Public Class Reporte

    Private _idPedido As Integer
    Public Property idPedido() As Integer
        Get
            Return _idPedido
        End Get
        Set(ByVal value As Integer)
            _idPedido = value
        End Set
    End Property

    Private Sub ReportePedidoEspecifico(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CompraUnitaria.SP_CompraEspecifica' Puede moverla o quitarla según sea necesario.

        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        idPedido = Me.TextBox1.Text

        Dim seg As New BLL.Seguridad("Password")

        Me.SP_CompraEspecificaTableAdapter.Fill(Me.CompraUnitaria.SP_CompraEspecifica, idPedido)

        For Each row As DataRow In Me.CompraUnitaria.SP_CompraEspecifica.Rows
            row.Item(1) = seg.Desencriptar(row.Item(1).ToString)
            row.Item(8) = seg.Desencriptar(row.Item(8).ToString)
        Next

        Me.ReportViewer1.RefreshReport()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class