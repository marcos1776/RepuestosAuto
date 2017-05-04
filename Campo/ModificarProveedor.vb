Public Class ModificarProveedor

    Public idProveedor As Integer

    Dim listaTelefonos As New List(Of String)
    Dim listaDirecciones As New List(Of String)


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub ModificarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Modificar Proovedor
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim prov As New BLL.Proveedor(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
        prov.ModificarProveedor(prov, idProveedor)

        ' Añadir Telefonos
        For Each tel As String In ListBox1.Items
            listaTelefonos.Add(tel)
        Next

        prov.AgregarTelefono(idProveedor, listaTelefonos)
        listaTelefonos.Clear()


        For Each dir As String In ListBox2.Items
            listaDirecciones.Add(dir)
        Next


        Dim form As New AdministracionProveedores
        Me.Close()
        form.Show()
    End Sub
End Class