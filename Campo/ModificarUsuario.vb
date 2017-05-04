Public Class ModificarUsuario

    Dim listaTelefonos As New List(Of String)
    Public idUsuario As Integer

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        'Dim menuUsuarios As New AdministracionUsuarios
        'menuUsuarios.Show()
    End Sub

    'Modificar Usuario
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim seguridad As New BLL.Seguridad("Password")
        Dim usuario As New BLL.Administrador(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)

        usuario._nombre = seguridad.Encriptar(TextBox1.Text)
        usuario._apellido = seguridad.Encriptar(TextBox2.Text)
        usuario._dni = seguridad.Encriptar(TextBox3.Text)
        'usuario._nick = seguridad.Encriptar(TextBox4.Text)
        usuario._mail = seguridad.Encriptar(TextBox4.Text)
        usuario._domicilio = seguridad.Encriptar(TextBox5.Text)

        'Modifico el Usuario
        usuario.modificarUsuario(usuario, idUsuario)

        ' Añadir Telefonos
        For Each tel As String In ListBox1.Items
            listaTelefonos.Add(seguridad.Encriptar(tel))
        Next

        'Añado los telefonos
        usuario.AgregarTelefono(listaTelefonos, idUsuario)

        'listaTelefonos.Clear()

        'Busco usuario y Calculo DVH Usuarios
        Dim us As DataSet
        Dim str As String
        ''''''''''''''''''''''''''''''' Calculo el DVH ''''''''''''''''''''''''''''''' 
        us = usuario.BuscarUsuarioEncriptado(idUsuario)
        str = idUsuario.ToString + Trim(us.Tables("DatosUsuario").Rows(0).Item("Nombre").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Apellido").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Nick").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Contraseña").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Domicilio").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Mail").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("Dni").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("EsActivo").ToString) + Trim(us.Tables("DatosUsuario").Rows(0).Item("LoginFallos").ToString)
        Dim dvh As Integer
        dvh = seguridad.calcularDVH(Str)

        usuario.ModificarDVH(idUsuario, dvh, "Usuario", 0)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        For Each tel As DataRow In us.Tables("DatosTelefono").Rows
            str = Trim(idUsuario.ToString) + tel.Item("Telefono").ToString + tel.Item("EsActivo").ToString
            dvh = seguridad.calcularDVH(str)
            usuario.ModificarDVH(idUsuario, dvh, "Telefono", tel.Item("Telefono").ToString)
        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim form As New AdministracionUsuarios
        Me.Close()
        form.Show()
    End Sub

    'Borrar Telefono
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    'Añadir Telefono
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'listaTelefonos.Add(TextBox6.Text)
        'actualizarListBox()

        'For Each numero As Integer In listaTelefonos
        ListBox1.Items.Add(TextBox6.Text)
        'Next
    End Sub

    Private Sub ModificarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
    End Sub
End Class