Public Class ReporteListadoUsuarios

    Private _estaHabilitado As Char

    Public Property estaHabilitado() As Char
        Get
            Return _estaHabilitado
        End Get
        Set(ByVal value As Char)
            _estaHabilitado = value
        End Set
    End Property

    Private Sub ReporteListadoUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim seg As New BLL.Seguridad("Password")


        If ComboBox1.Text = "Habilitados" Then
            estaHabilitado = "Y"
        Else
            estaHabilitado = "N"
        End If

        Me.SP_ReporteUsuariosTableAdapter.Fill(Me.ReporteUsuarios.SP_ReporteUsuarios, estaHabilitado)


        For Each row As DataRow In Me.ReporteUsuarios.SP_ReporteUsuarios.Rows
            row.Item(1) = seg.Desencriptar(row.Item(1).ToString)
            row.Item(2) = seg.Desencriptar(row.Item(2).ToString)
            row.Item(3) = seg.Desencriptar(row.Item(3).ToString)
            row.Item(4) = seg.Desencriptar(row.Item(4).ToString)
            row.Item(5) = seg.Desencriptar(row.Item(5).ToString)
        Next

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class