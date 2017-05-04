Public Class InhabilitacionUsuario

    'Inhabilitar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim rowIndex As Integer = AdministracionUsuarios.DataGridView1.CurrentCell.RowIndex
        Dim row As DataGridViewRow = AdministracionUsuarios.DataGridView1.Rows(rowIndex)
        Dim seg As New BLL.Seguridad("Password")
        Dim user As String = seg.Encriptar(row.Cells(2).Value)

        'Validar Patentes

        '

        'Agregar que inserte en la tabla Usuario_Estado
        Dim usuario As New BLL.Administrador
        usuario.ModificarEstadoUsuario(user, "N")


        Me.Hide()
        AdministracionUsuarios.cargarDataGrid()
        'CalcularDVH
        '
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub InhabilitacionUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class