Public Class AdministrarVentas

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub AdministrarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim seg As New BLL.Seguridad("Password")
        Dim dtMensajes As New DataTable

        dtMensajes = seg.ObtenerMensajes(Login.ID_IDIOMA, 13)
        If (Login.ID_IDIOMA = 1) Then
            Me.Text = "Menu Ventas"
        Else
            Me.Text = "Sales Menu"
        End If

        lblBuscarDesde.Text = dtMensajes.Rows(0).Item(5).ToString
        lblBuscarHasta.Text = dtMensajes.Rows(1).Item(5).ToString
        lblCliente.Text = dtMensajes.Rows(2).Item(5).ToString
        btnBuscar.Text = dtMensajes.Rows(3).Item(5).ToString
        lblVentasRealizadas.Text = dtMensajes.Rows(4).Item(5).ToString
        lblVentasCancel.Text = dtMensajes.Rows(5).Item(5).ToString
        btnNueva.Text = dtMensajes.Rows(6).Item(5).ToString
        btnModif.Text = dtMensajes.Rows(7).Item(5).ToString
        btnConsul.Text = dtMensajes.Rows(8).Item(5).ToString
        btnCancelVenta.Text = dtMensajes.Rows(9).Item(5).ToString
        btnCancel.Text = dtMensajes.Rows(10).Item(5).ToString
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    'Nueva Venta
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNueva.Click
        Dim venta As New AltaVenta
        venta.Show()
    End Sub


    'Modificar Venta
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnModif.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnConsul.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnCancelVenta.Click
        Dim seguridad As New BLL.Seguridad("Password")
        ' Añadir Logica




        '
        If (Login.ID_IDIOMA = 1) Then
            MessageBox.Show("Venta cancelada correctamente")
        Else
            MessageBox.Show("Sale canceled succesully")
        End If

        'seguridad.registrarBitacora(Login.ID_USUARIO, "MEDIA", DateTime.Now, "Venta cancelada", 0)

    End Sub
End Class