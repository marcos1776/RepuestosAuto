Public Class AltaCliente
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idCliente As Integer
        Dim seguridad As New BLL.Seguridad("Password")
        Dim ds As New DataTable

        Dim cliente As New BLL.Cliente()
        idCliente = cliente.altaCliente(TextBox1.Text, TextBox2.Text, TextBox3.Text)

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

        If (Login.ID_IDIOMA = 1) Then
            MessageBox.Show("Usuario añadido correctamente")
        Else
            MessageBox.Show("User added correctly")
        End If

        Me.Close()
    End Sub

    Private Sub AltaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class