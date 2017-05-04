Public Class AltaCorreccion

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub AltaCorreccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargo los articulos
        Dim listado As New BLL.Listas()
        Dim art As New DataSet()
        Dim dt As New DataTable
        art = listado.obtenerListadoArticulos()

        dt = art.Tables("ArticulosComprados")

        Dim bindingSource1 As New BindingSource()

        dt.Columns.Remove(3)
        dt.Columns.Remove(4)

        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim art As New BLL.Articulo

        If txtCantidad.Text = "" Then
            If (Login.ID_IDIOMA = 1) Then
                MessageBox.Show("Ingrese una cantidad")
            Else
                MessageBox.Show("Please insert a quantity")
            End If
        Else
            Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
            ' // LAMPA : que valide que haya una row seleccionada

            Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)
            Dim idArt As String = row.Cells(1).Value

            art.CorregirStock(idArt, txtCantidad.Text, ComboBox1.SelectedText)

            If (Login.ID_IDIOMA = 1) Then
                MessageBox.Show("Stock corregido correctamente!")
            Else
                MessageBox.Show("Stock succesfully modified!")
            End If

        End If

    End Sub
End Class