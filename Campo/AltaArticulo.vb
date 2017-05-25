Public Class AltaArticulo

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'MsgBox("¿Estas seguro que deseas eliminar el artículo?", MsgBoxStyle.OkCancel, "Eliminar Articulo")
        Dim proveedor As String = ComboBox1.Text
        Dim articulo As New BLL.Articulo()
        Dim seguridad As New BLL.Seguridad("Password")

        articulo.CargarArticuloProveedor(seguridad.Encriptar(proveedor), articulo)

        If Login.ID_IDIOMA = 1 Then
            MessageBox.Show("Articulo añadido correctamente!")
        Else
            MessageBox.Show("Article added correctly")
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub AltaArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        ComboBox1.Items.Clear()
        ListBox1.Items.Clear()

        Dim list As New BLL.Listas()
        Dim ds As New DataSet
        ds = list.obtenerProveedores()

        For Each dt As DataRow In ds.Tables("DatosProveedores").Rows
            ComboBox1.Items.Add(dt.Item("Nombre_Empresa"))
        Next

        Dim art As New BLL.Articulo
        ds = list.obtenerListadoArticulos()

        For Each dt As DataRow In ds.Tables("AutosArticulos").Rows
            ListBox1.Items.Add(dt.Item(1).ToString + " - " + dt.Item(2).ToString + " - " + dt.Item(3).ToString + " ")
        Next


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox2.Items.Add(ListBox1.SelectedItem)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
    End Sub
End Class