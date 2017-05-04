Public Class UsuarioFamilia

    Private Sub UsuarioFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
    End Sub

    Private Sub CargarGrid()
        'Obtengo los usuarios
        Dim dsUsuarios As New DataSet
        Dim listadoUsuarios As New BLL.Listas

        dsUsuarios = listadoUsuarios.obtenerUsuarios()

        For Each row As DataRow In dsUsuarios.Tables("DatosUsuario").Rows
            ComboBox1.Items.Add(row(2).ToString)
        Next

        'Obtengo las familias.
        Dim listadoFamiliaUsuario As New DataSet
        Dim listado As New BLL.Listas
        Dim listadoFamilias As New DataTable
        Dim seguridad As New BLL.Seguridad("Password")
        Dim dtPatentesDeFamilia As New DataTable

        listadoFamilias = listado.obtenerListadoFamilias()


        For Each fam As DataRow In listadoFamilias.Rows
            Dim nodo As TreeNode
            nodo = TreeView2.Nodes.Add(fam(0).ToString)

            dtPatentesDeFamilia = listado.ObtenerListadoPatentesDeFamilia(seguridad.Encriptar(fam(0).ToString))

            For Each pat As DataRow In dtPatentesDeFamilia.Rows
                nodo.Nodes.Add(pat(0).ToString)
            Next
        Next
    End Sub




    'Cargo las Familias del usuario
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim usuario As String
        Dim listas As New BLL.Listas
        Dim listadoFamiliaUsuario As New DataSet
        Dim seguridad As New BLL.Seguridad("Password")
        Dim dtPatentesDeFamilia As New DataTable

        usuario = seguridad.Encriptar(ComboBox1.SelectedItem)

        listadoFamiliaUsuario = listas.obtenerListadoFamiliasUsuario(usuario)


        For Each fam As DataRow In listadoFamiliaUsuario.Tables("DatosFamilias").Rows
            Dim nodo As TreeNode
            nodo = TreeView1.Nodes.Add(fam(0).ToString)

            dtPatentesDeFamilia = listas.ObtenerListadoPatentesDeFamilia(seguridad.Encriptar(fam(0).ToString))

            For Each pat As DataRow In dtPatentesDeFamilia.Rows
                nodo.Nodes.Add(pat(0).ToString)
            Next
        Next


    End Sub

    'Le asigno patente.
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim seguridad As New BLL.Seguridad("Password")
        Dim dsUsuario As New DataSet
        Dim user As New BLL.Administrador

        Dim familia As String
        familia = seguridad.Encriptar(TreeView2.SelectedNode.Text)
        TreeView2.SelectedNode.Remove()


        Dim usuario As String

        usuario = seguridad.Encriptar(ComboBox1.SelectedItem)

        dsUsuario = user.BuscarUsuario(usuario)


        seguridad.AsignarFamiliaUsuario(dsUsuario.Tables("DatosUsuario").Rows(0).Item("IdUsuario"), familia)



    End Sub


End Class