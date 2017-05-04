Public Class AsignacionUsuarioPatentes

    Dim dtPatentes As New DataTable

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    'Cargo las patentes
    Private Sub AsignacionUsuarioPatentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dsUsuarios As New DataSet
        Dim listadoUsuarios As New BLL.Listas

        Dim habilitados As New DataTable

        dsUsuarios = listadoUsuarios.obtenerUsuarios()

        If dsUsuarios.Tables(0).Select("esActivo = 'Y'").Count > 0 Then
            habilitados = dsUsuarios.Tables(0).Select("esActivo = 'Y'").CopyToDataTable

            For Each row As DataRow In habilitados.Rows
                ComboBox1.Items.Add(row(2).ToString)
            Next
        End If


        CargarDataGrid()

    End Sub

    'Buscar Patentes
    'Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)
    '    Dim dataview As New DataView(dtPatentes)

    '    dataview.RowFilter = "Nombre like '%" + TextBox1.Text + "%'"

    '    'CheckedListBox1.DataSource = dataview
    'End Sub

    'Cuando cambio de usuario que se me carguen las patentes, patentes negadas , y familias de los usuarios
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        TreeView1.Nodes.Clear()
        TreeView2.Nodes.Clear()

        CargarDataGrid()

        Dim seguridad As New BLL.Seguridad("Password")
        Dim listadoFamiliaUsuario As New DataSet

        Dim listadoPatentesUsuario As New DataTable

        Dim listadoPatentesNegadasUsuario As New DataTable
        Dim listadoPatentesHabilitadasUsuario As New DataTable
        Dim listas As New BLL.Listas
        Dim nombreUsuario As String

        nombreUsuario = seguridad.Encriptar(ComboBox1.Text)


        'listadoPatentesUsuario = listas.obtenerListadoPatentesUsuario(nombreUsuario)
        listadoPatentesUsuario = listas.obtenerPatentes(nombreUsuario)
        listadoFamiliaUsuario = listas.obtenerListadoFamiliasUsuario(nombreUsuario)

        'PONER LA CONDICION DEL COUNT > 0
        If listadoPatentesUsuario.Select("EsNegada = 'N'").Count > 0 Then
            listadoPatentesHabilitadasUsuario = listadoPatentesUsuario.Select("EsNegada = 'N'").CopyToDataTable
        End If

        If listadoPatentesUsuario.Select("EsNegada = 'Y'").Count > 0 Then
            listadoPatentesNegadasUsuario = listadoPatentesUsuario.Select("EsNegada = 'Y'").CopyToDataTable
        End If

        'Llenado de patentes
        For Each pat As DataRow In listadoPatentesHabilitadasUsuario.Rows
            ListBox2.Items.Add(pat(0).ToString)
            'CheckedListBox3.Items.Add(pat(0).ToString)
        Next


        'Llenado de patentes negadas
        For Each pat As DataRow In listadoPatentesNegadasUsuario.Rows
            ListBox3.Items.Add(pat(0).ToString)
            'CheckedListBox3.Items.Add(pat(0).ToString)
        Next

        'Llenado de familias
        'For Each fam As DataRow In listadoFamiliaUsuario.Tables("DatosFamilias").Rows
        '    'ListBox2.Items.Add(fam(0).ToString)
        '    TreeView2.Nodes.Add(fam(0).ToString)
        'Next

        Dim dtPatentesDeFamilia As New DataTable
        Dim listado As New BLL.Listas

        For Each fam As DataRow In listadoFamiliaUsuario.Tables("DatosFamilias").Rows
            Dim nodo As TreeNode
            nodo = TreeView2.Nodes.Add(fam(0).ToString)

            dtPatentesDeFamilia = listado.ObtenerListadoPatentesDeFamilia(seguridad.Encriptar(fam(0).ToString))

            For Each pat As DataRow In dtPatentesDeFamilia.Rows
                nodo.Nodes.Add(pat(0).ToString)
            Next
        Next



        listadoPatentesUsuario = listas.obtenerPatentesAsignablesActualizada(nombreUsuario)

        For Each pat As DataRow In listadoPatentesUsuario.Rows
            ListBox1.Items.Add(pat(1).ToString)
            'CheckedListBox3.Items.Add(pat(0).ToString)
        Next
        ''''''''''''''''''''''''' Llenado de familias -- Filtra las patentes negadas --- las patentes repetidas '''''''''''''''''''''''''''''''

        'Dim encontrado As Boolean = False

        ''Por cada familia que se listen las patentes , si ya estan en el listbox , que la omita.
        'For Each patente As DataRow In listadoFamiliaUsuario.Tables("DatosPatentes").Rows
        '    ' Meter el IF y que valide que no exista la patente en el listbox y que no este negada
        '    'For Each item In ListBox1.Items
        '    For Each item In CheckedListBox3.Items
        '        If item = patente(0).ToString Then
        '            encontrado = True
        '        End If
        '    Next

        '    ' Agregar la condicion que no sea negada
        '    For Each PatenteNegada In listadoPatentesNegadasUsuario.Rows
        '        If patente(0).ToString = PatenteNegada.Item(0).ToString Then
        '            encontrado = True
        '        End If
        '    Next

        '    If Not (encontrado) Then
        '        'ListBox1.Items.Add(patente(0).ToString)
        '        CheckedListBox3.Items.Add(patente(0).ToString)
        '    End If
        '    encontrado = False
        'Next

        ''Llenado de patentes negadas
        'For Each pat As DataRow In listadoPatentesNegadasUsuario.Rows
        '    'ListBox3.Items.Add(pat(0).ToString)
        '    CheckedListBox4.Items.Add(pat(0).ToString)
        'Next


        'For Each patente In CheckedListBox3.Items
        '    CheckedListBox1.Items.Remove(patente)
        'Next


        'CheckedListBox1.Enabled = True
        'CheckedListBox2.Enabled = True
        'CheckedListBox3.Enabled = True
        'CheckedListBox4.Enabled = True
        'ListBox2.Enabled = True
        TreeView1.Enabled = True
    End Sub

    ''Boton ASIGNAR
    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    'Por cada patente check que no esten duplicadas
    '    checkPatentesDuplicadas()
    '    '

    '    'Por cada fam check que no esten duplicadas
    '    checkFamiliasDuplicadas()

    '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '    If CheckedListBox4.Items.Count > 0 Then
    '        For Each patente In CheckedListBox4.Items
    '            CheckedListBox3.Items.Remove(patente)
    '        Next
    '    End If
    'End Sub

    ''Boton Negar Patente
    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    'Por cada pat negada
    '    checkPatentesNegadas()
    '    '
    '    For Each patente In CheckedListBox4.Items
    '        CheckedListBox1.Items.Remove(patente)
    '    Next

    'End Sub

    'CargarData Grid
    Public Sub CargarDataGrid()
        ListBox1.Items.Clear()
        'CheckedListBox1.Items.Clear()
        'CheckedListBox2.Items.Clear()
        'CheckedListBox3.Items.Clear()
        'CheckedListBox4.Items.Clear()
        'ComboBox1.Items.Clear()
        'ListBox1.Items.Clear()
        'ListBox2.Items.Clear()
        TreeView1.Nodes.Clear()
        TreeView2.Nodes.Clear()
        'ListBox3.Items.Clear()

        Dim listadoPatentes As New BLL.Listas
        dtPatentes = listadoPatentes.obtenerListadoPatentes()

        'For Each row As DataRow In dtPatentes.Rows
        '    'CheckedListBox1.Items.Add(row(0).ToString)
        '    ListBox1.Items.Add(row(0).ToString)
        'Next

        'DataGridView1.DataSource = dtPatentes
        'Dim dtFamilias As New DataTable
        'Dim listadoFamilias As New BLL.Listas

        'dtFamilias = listadoFamilias.obtenerListadoFamilias()




        'Obtengo las familias.
        Dim listadoFamiliaUsuario As New DataSet
        Dim listado As New BLL.Listas
        Dim listadoFamilias As New DataTable
        Dim seguridad As New BLL.Seguridad("Password")
        Dim dtPatentesDeFamilia As New DataTable

        listadoFamilias = listado.obtenerListadoFamilias()


        For Each fam As DataRow In listadoFamilias.Rows
            Dim nodo As TreeNode
            nodo = TreeView1.Nodes.Add(fam(0).ToString)

            dtPatentesDeFamilia = listado.ObtenerListadoPatentesDeFamilia(seguridad.Encriptar(fam(0).ToString))

            For Each pat As DataRow In dtPatentesDeFamilia.Rows
                nodo.Nodes.Add(pat(0).ToString)
            Next
        Next














        'For Each row As DataRow In dtFamilias.Rows
        '    CheckedListBox2.Items.Add(row(0).ToString)
        'Next


        'CheckedListBox1.Enabled = False
        'CheckedListBox2.Enabled = False
        'CheckedListBox3.Enabled = False
        'CheckedListBox4.Enabled = False
        'ListBox1.Enabled = False
        'ListBox2.Enabled = False
        'TreeView1.Enabled = False
        'ListBox3.Enabled = False
    End Sub

    'Check si hay patentes duplicadas
    Public Sub checkPatentesDuplicadas()
        Dim encontrado As Boolean = False
        Dim patente As String = Nothing


        'For i As Integer = 0 To CheckedListBox1.CheckedItems.Count - 1
        '    encontrado = False
        '    If CheckedListBox3.Items.Count > 0 Then
        '        For j As Integer = 0 To CheckedListBox3.Items.Count - 1
        '            If CheckedListBox1.CheckedItems(i).ToString = CheckedListBox3.Items(j).ToString Then
        '                encontrado = True
        '                Exit For
        '            End If
        '        Next
        '    End If

        '    If Not (encontrado) Then
        '        CheckedListBox3.Items.Add(CheckedListBox1.CheckedItems(i).ToString)
        '        'Lo borro del checked Listbox 1
        '    End If
        'Next

        'While CheckedListBox1.CheckedItems.Count > 0
        '    CheckedListBox1.Items.Remove(CheckedListBox1.CheckedItems(0))
        'End While

    End Sub

    'Check si hay familias duplicadas
    'Public Sub checkFamiliasDuplicadas()
    '    Dim encontrado As Boolean

    '    For i As Integer = 0 To CheckedListBox2.CheckedItems.Count - 1
    '        encontrado = False
    '        For j As Integer = 0 To ListBox2.Items.Count - 1
    '            If CheckedListBox2.CheckedItems(i).ToString = ListBox2.Items(j).ToString Then
    '                encontrado = True
    '                Exit For
    '            End If
    '        Next

    '        'Si no esta encontrado , la añado al listbox y le cargo las patentes de las familias
    '        If Not (encontrado) Then
    '            Dim seguridad As New BLL.Seguridad("Password")
    '            Dim listadoPatentes As New BLL.Listas

    '            'ListBox2.Items.Add(CheckedListBox2.CheckedItems(i).ToString)


    '            Dim node As New TreeNode
    '            node = TreeView1.Nodes.Add(CheckedListBox2.CheckedItems(i).ToString)

    '            'Por cada una de las familias.
    '            'ObtenerListadoDePatentesDeFamilia
    '            Dim dt As New DataTable
    '            dt = listadoPatentes.ObtenerListadoPatentesDeFamilia(seguridad.Encriptar(CheckedListBox2.CheckedItems(i).ToString))

    '            For Each pat As DataRow In dt.Rows
    '                encontrado = False
    '                For j As Integer = 0 To CheckedListBox3.Items.Count - 1
    '                    If pat.Item(0) = CheckedListBox3.Items(j).ToString Then
    '                        encontrado = True
    '                        Exit For
    '                    End If
    '                Next

    '                If Not (encontrado) Then
    '                    CheckedListBox1.Items.Remove(pat(0).ToString)
    '                    'CheckedListBox3.Items.Add(pat(0).ToString)
    '                    node.Nodes.Add(pat(0).ToString)
    '                End If
    '            Next
    '        End If
    '    Next
    'End Sub

    'Si encuentra patente negada , la borra del listbox de patentes
    Public Sub checkPatentesNegadas()
        'Dim encontrado As Boolean
        'For i As Integer = 0 To CheckedListBox1.CheckedItems.Count - 1
        '    encontrado = False
        '    For j As Integer = 0 To CheckedListBox3.Items.Count - 1
        '        If CheckedListBox1.CheckedItems(i).ToString = CheckedListBox3.Items(j).ToString Then
        '            encontrado = True
        '            Exit For
        '        End If
        '    Next

        '    'Si lo encuentra lo borra
        '    If (encontrado) Then
        '        CheckedListBox3.Items.Remove(CheckedListBox1.CheckedItems(i).ToString)
        '    End If
        'Next

        'Si esta negada , meto una familia o patente , me duplica la patente negada
        'VERIFICAR ESTO
        'For k As Integer = 0 To CheckedListBox1.CheckedItems.Count - 1
        '    encontrado = False
        '    For l As Integer = 0 To CheckedListBox4.Items.Count - 1
        '        If CheckedListBox1.CheckedItems(k).ToString = CheckedListBox4.Items(l).ToString Then
        '            encontrado = True
        '            Exit For
        '        End If
        '    Next
        '    If Not (encontrado) Then
        '        CheckedListBox4.Items.Add(CheckedListBox1.CheckedItems(k).ToString)
        '    End If
        'Next
    End Sub

    'Desasignar patentes y familias
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim pate As New List(Of String)
    '    For i As Integer = 0 To CheckedListBox3.CheckedItems.Count - 1
    '        pate.Add(CheckedListBox3.CheckedItems(i).ToString)
    '    Next

    '    For Each p In pate
    '        CheckedListBox1.Items.Add(p)
    '        CheckedListBox3.Items.Remove(p)
    '    Next


    '    'If ListBox2.SelectedItems.Count > 0 Then
    '    'CheckedListBox1.Items.Add(ListBox1.SelectedItem)

    '    Dim dt As New DataTable
    '    Dim listadoPatentes As New BLL.Listas
    '    Dim seguridad As New BLL.Seguridad("Password")
    '    'Dim encontrado As Boolean

    '    dt = listadoPatentes.ObtenerListadoPatentesDeFamilia(seguridad.Encriptar(ListBox2.SelectedItem.ToString))

    '    For Each pat As DataRow In dt.Rows
    '        'encontrado = False
    '        For j As Integer = 0 To CheckedListBox4.Items.Count - 1
    '            If pat.Item(0) = CheckedListBox4.Items(j).ToString Then
    '                CheckedListBox4.Items.Remove(pat(0).ToString)
    '                CheckedListBox1.Items.Add(pat(0).ToString)
    '                Exit For
    '            End If
    '        Next
    '    Next


    '    'Borro el item
    '    ListBox2.Items.Remove(ListBox2.SelectedItem)
    '    End If


    'End Sub

    'Denego patentes
    Private Sub Button5_Click(sender As Object, e As EventArgs)
        'CheckedListBox1.Items.Add(CheckedListBox4.SelectedItem)
        ''Borro el item
        'CheckedListBox4.Items.Remove(CheckedListBox4.SelectedItem)
    End Sub


    'Cuando se apliquen los cambios
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MenuPrincipal.Show()
        Me.Close()

        ''Se borran los usuariosPatentes
        ''Se borran las familiasPatentes

        'Dim permisos As New BLL.Seguridad("Password")

        'Dim listadoPatentes As New List(Of String)
        'Dim listadoFamilias As New List(Of String)
        'Dim listadoPatNegada As New List(Of String)

        ''For Each item In CheckedListBox3.Items
        ''    listadoPatentes.Add(item)
        ''Next

        ''For Each item In ListBox2.Items
        ''    listadoFamilias.Add(item)
        ''Next

        ''For Each item In CheckedListBox4.CheckedItems
        ''    listadoPatNegada.Add(item)
        ''Next

        ''Se validan que las patentes esten en otro usuario
        ''permisos.
        'permisos.ValidarPatentesAsignadas(listadoPatentes, ComboBox1.SelectedItem)

    End Sub

    'Cuando tildo una familia me muestre las Patentes de esta
    'Private Sub MostrarPatentes(sender As Object, e As ItemCheckEventArgs)
    '    If CheckedListBox2.GetItemCheckState(CheckedListBox2.SelectedIndex) = CheckState.Unchecked Then

    '        Dim dt As New DataTable
    '        Dim listadoPatentes As New BLL.Listas
    '        Dim seguridad As New BLL.Seguridad("Password")

    '        dt = listadoPatentes.ObtenerListadoPatentesDeFamilia(seguridad.Encriptar(CheckedListBox2.SelectedItem().ToString))
    '        Dim patentes As String

    '        For Each pat As DataRow In dt.Rows
    '            patentes += pat(0).ToString + vbNewLine
    '        Next

    '        MessageBox.Show("La familia contiene las siguientes patentes:" + vbNewLine & patentes)
    '    End If
    'End Sub


    'Denegar Patente
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim seguridad As New BLL.Seguridad("Password")
        Dim patente As String
        patente = Trim(ListBox3.SelectedItem.ToString)

        seguridad.DenegarPatente(seguridad.Encriptar(ComboBox1.Text), patente)

        ComboBox1_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    'Insertar Patente
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim seguridad As New BLL.Seguridad("Password")
        Dim patente As String
        patente = Trim(ListBox1.SelectedItem.ToString)
        seguridad.asignarPatenteUsuario(seguridad.Encriptar(ComboBox1.Text), patente)

        ComboBox1_SelectedIndexChanged(Nothing, Nothing)

        Dim idBitacora As Integer = seguridad.registrarBitacora(Login.ID_USUARIO, "Media", DateTime.Now, "Se asigno la patente " & patente & " al usuario " & ComboBox1.Text, 0)

    End Sub

    'Niego
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim seguridad As New BLL.Seguridad("Password")
        Dim patente As String
        patente = Trim(ListBox1.SelectedItem.ToString)

        Dim valid As Boolean = seguridad.NegarPatenteUsuario(seguridad.Encriptar(ComboBox1.Text), patente)

        If (valid) Then
            MessageBox.Show("La patente ha sido negada")
        Else
            MessageBox.Show("No se pudo negar patente. Asigne a patente a otro usuario para poder negar")
        End If

        ComboBox1_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim seguridad As New BLL.Seguridad("Password")
        Dim patente As String
        patente = Trim(ListBox2.SelectedItem.ToString)

        ' Dim valid As Boolean = seguridad.NegarPatenteUsuario(seguridad.Encriptar(ComboBox1.Text), patente)
        Dim valid As Boolean = seguridad.DesasignarPatenteUsuario(seguridad.Encriptar(ComboBox1.Text), patente)

        If (valid) Then
            MessageBox.Show("La patente ha sido desasignada")
        Else
            MessageBox.Show("No se pudo desasignar la patente. Asigne a patente a otro usuario para poder desasignar")
        End If

        ComboBox1_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim seguridad As New BLL.Seguridad("Password")
        Dim familia As String
        familia = Trim(TreeView1.SelectedNode.Text)
        seguridad.AsignarFamiliaUsuario(seguridad.Encriptar(ComboBox1.Text), seguridad.Encriptar(familia))

        ComboBox1_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    ' Desasigno Familia
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim seguridad As New BLL.Seguridad("Password")
        Dim familia As String
        Dim user As String = seguridad.Encriptar(ComboBox1.Text)
        'familia = Trim(TreeView1.SelectedNode.Text)
        Dim listas As New BLL.Listas()

        familia = seguridad.Encriptar(Trim(TreeView2.SelectedNode.Text))
        'Obtengo las patentes de la familia
        Dim dt As New DataTable
        dt = listas.ObtenerListadoPatentesDeFamilia(familia)


        Dim eliminable As Boolean = True

        'While (eliminable)


        'End While


        For Each pat As DataRow In dt.Rows
            eliminable = seguridad.validarPatenteEliminar(familia, Trim(pat(0).ToString))

            If (eliminable = False) Then
                Exit For
            End If

        Next

        If (eliminable = False) Then
            If (Login.ID_IDIOMA = 1) Then
                MessageBox.Show("Por favor valida que las patentes esten asignadas")
            Else
                MessageBox.Show("Please verify, the roles must be assigned to other user.")
            End If
        Else
            seguridad.desasignarFamiliaUsuario(user, familia)
        End If

        'seguridad.AsignarFamiliaUsuario(seguridad.Encriptar(ComboBox1.Text), seguridad.Encriptar(familia))

        ComboBox1_SelectedIndexChanged(Nothing, Nothing)

    End Sub
End Class