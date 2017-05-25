Public Class BuscarCliente
    Public nombreComprador As String
    'Si hago doble click me llene el textbox del formulario venta con el Nombre - Apellido
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)
        Dim idCli As String

        If DataGridView1.ColumnCount = 2 Then
            idCli = row.Cells(1).Value
        Else
            idCli = row.Cells(2).Value
        End If

        'AltaVenta.texto.Text = idCli
        MenuPrincipal.altaVe.TextBox1.Text = idCli

        'MenuPrincipal.Alta

        Me.Close()
    End Sub

    Private Sub BuscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class