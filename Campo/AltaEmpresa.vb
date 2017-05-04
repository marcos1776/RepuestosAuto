Public Class AltaEmpresa
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cliente As New BLL.Cliente()
        Dim idCliente As Integer
        idCliente = cliente.altaCliente("", "", "")
        Dim ds As New DataTable
        Dim seguridad As New BLL.Seguridad("Password")


        ''''''''''''''''''''''''''''''' Calculo el DVH ''''''''''''''''''''''''''''''' 
        ds = cliente.ObtenerCliente(idCliente)
        Dim str As String

        str = Trim(ds.Rows(0).Item(0).ToString) + Trim(ds.Rows(0).Item(1).ToString) + Trim(ds.Rows(0).Item(2).ToString) + Trim(ds.Rows(0).Item(3).ToString)
        Dim dvh As Integer
        dvh = seguridad.calcularDVH(str)

        'usuario.ModificarDVH(idUsuario, dvh, "Usuario", 0)
        seguridad.ModificarDVH(idCliente, dvh, "Cliente", "IdCliente")

        'Actualizo DVV
        seguridad.ActualizarDVV("Cliente")

        Dim idEmpresa As Integer
        Dim empresa As New BLL.Cliente()
        empresa.altaEmpresa(idCliente, TextBox1.Text, TextBox2.Text)



        ''''''''''''''''''''''''''''''' Calculo el DVH ''''''''''''''''''''''''''''''' 
        ds = empresa.ObtenerEmpresa(idCliente)
        Dim str2 As String

        str2 = Trim(ds.Rows(0).Item(0).ToString) + Trim(ds.Rows(0).Item(1).ToString) + Trim(ds.Rows(0).Item(2).ToString) + Trim(ds.Rows(0).Item(3).ToString)
        Dim dvh2 As Integer
        dvh2 = seguridad.calcularDVH(str2)

        'usuario.ModificarDVH(idUsuario, dvh, "Usuario", 0)
        seguridad.ModificarDVH(idCliente, dvh2, "Empresa", "IdCliente")

        'Actualizo DVV
        seguridad.ActualizarDVV("Empresa")

        If (Login.ID_IDIOMA = 1) Then
            MessageBox.Show("Cliente añadido correctamente")
        Else
            MessageBox.Show("Client added succesfully")
        End If

        Me.Hide()
    End Sub
End Class