Public Class UsuarioPatente

    Private Sub UsuarioPatente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
    End Sub

    Private Sub CargarGrid()

        'Cargo Usuarios

        Dim dsUsuarios As New DataSet
        Dim listadoUsuarios As New BLL.Listas

        dsUsuarios = listadoUsuarios.obtenerUsuarios()

        For Each row As DataRow In dsUsuarios.Tables("DatosUsuario").Rows
            ComboBox1.Items.Add(row(2).ToString)
        Next


        'Cargo listado total de patentes
        Dim listadoPatentes As New BLL.Listas
        Dim dtPatentes As New DataTable
        dtPatentes = listadoPatentes.obtenerListadoPatentes()


        For Each row As DataRow In dtPatentes.Rows
            ListBox2.Items.Add(row(0).ToString)
        Next

    End Sub

    'Cuando cambio el usuario se me carguen las patentes de usuario
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        cargarDatos()
    End Sub


    Public Sub cargarDatos()
        Dim listadoPatentesUsuario As New DataSet
        Dim listadoPatentesRestantes As New DataTable
        Dim seguridad As New BLL.Seguridad("Password")
        Dim nombreUsuario As String
        Dim listas As New BLL.Listas

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()

        nombreUsuario = seguridad.Encriptar(ComboBox1.Text)

        listadoPatentesUsuario = listas.obtenerListadoPatentesUsuario(nombreUsuario)

        '''''''' Cargo mis patentes asignadas
        For Each pat As DataRow In listadoPatentesUsuario.Tables("DatosPatentes").Rows
            ListBox1.Items.Add(pat(0).ToString)
        Next
        ''''''''''''''''''''''''''''''''''''''''

        '''''' cargo las patentes negadas

        Dim negadas As New DataTable
        If listadoPatentesUsuario.Tables("DatosPatentesNegadas").Rows.Count > 0 Then
            For Each pat As DataRow In listadoPatentesUsuario.Tables("DatosPatentesNegadas").Rows
                ListBox3.Items.Add(pat(0).ToString)
            Next
        End If
        ''''''''''''''''''''''''''''''''''
        ''''' en el listado total cargo todas las patentes menos las asignadas por los usuarios

        listadoPatentesRestantes = listas.obtenerListadoPatentesRestantes(nombreUsuario)



        If listadoPatentesRestantes.Rows.Count <> 0 Then
            For Each patRes As DataRow In listadoPatentesRestantes.Rows
                ListBox2.Items.Add(patRes(0).ToString)
            Next
        End If
        ''''''''''''''''
    End Sub










    'Inserto en la usuarios Patentes
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim seg As New BLL.Seguridad("Password")
        Dim idUsuarioPatente As DataSet
        idUsuarioPatente = seg.asignarPatente(seg.Encriptar(Trim(ComboBox1.SelectedItem)), ListBox2.SelectedItem)



        ''''''''''''''''''''' Calculo dvh de la tabla UsuarioPatente
        Dim str As String
        Dim dvh As Integer

        str = idUsuarioPatente.Tables("UsuarioPatente").Rows(0).Item(0) & "" & idUsuarioPatente.Tables("UsuarioPatente").Rows(0).Item(1) & "" & idUsuarioPatente.Tables("UsuarioPatente").Rows(0).Item(2) & "N"
        dvh = seg.calcularDVH(str)

        seg.ModificarDVH(idUsuarioPatente.Tables("UsuarioPatente").Rows(0).Item(0), dvh, "UsuarioPatente", "idUsuarioPatente")

        '''''''''''''''''''''''''''''''''''''''''

        MessageBox.Show("Patente cargada correctamente")
        cargarDatos()

    End Sub


    'Desasigno patente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim seg As New BLL.Seguridad("Password")
        Dim nombreUsuario As String
        nombreUsuario = seg.Encriptar(ComboBox1.Text)


        If seg.ValidarPatente(nombreUsuario, ListBox1.SelectedItem) Then

        Else
            MessageBox.Show("El usuario es el unico que posee esta patente, no se puede negar")
        End If
    End Sub



End Class