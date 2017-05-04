Public Class ModificarFamilia

    Public nombre As String
    Public nombreOriginal As String

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub

    Private Sub CheckedListBox2_ItemCheck(sender As Object, e As ItemCheckEventArgs)
        If (e.NewValue = CheckState.Checked) Then
            MessageBox.Show("Check")
        Else
            MessageBox.Show("UnCheck")
        End If

    End Sub


    Public Sub cargarDatos(nombre As String, nombreOriginal As String)
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Me.nombre = nombre
        Me.nombreOriginal = nombreOriginal


        Dim seg As New BLL.Seguridad("Password")
        Dim familia As New BLL.Familia
        Dim dt As New DataTable

        Dim dt2 As New DataTable

        dt = familia.buscarFamilia(nombre)



        For Each pat As DataRow In dt.Rows
            'modificar.CheckedListBox2.Items.Add(pat.Item(0))
            ListBox2.Items.Add(pat.Item(0))
        Next


        Dim listas As New BLL.Listas
        dt = listas.obtenerListadoPatentesRestantes2(nombre)

        For Each pat As DataRow In dt.Rows
            'modificar.CheckedListBox2.Items.Add(pat.Item(0))
            ListBox1.Items.Add(pat.Item(1))
        Next

        Me.Show()
        Me.TextBox1.Text = nombreOriginal
    End Sub


    ' Que valide que haya otro usuario con esa patente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim seguridad As New BLL.Seguridad("Password")
        Dim patente As String
        patente = Trim(ListBox2.SelectedItem.ToString)

        'Dim valid As Boolean = seguridad.NegarPatenteUsuario(seguridad.Encriptar(ComboBox1.Text), patente)

        Dim valid As Boolean = seguridad.DesasignarPatenteFamilia(nombre, patente)

        If (valid) Then
            If (Login.ID_IDIOMA = 1) Then
                MessageBox.Show("La patente ha sido desasignada de la familia")
            Else
                MessageBox.Show("Role unassigned succesfully")
            End If

        Else
            If (Login.ID_IDIOMA = 1) Then
                MessageBox.Show("No se pudo desasignar la patente de la familia. Asigne a patente a otro usuario para poder desasignar")
            Else
                MessageBox.Show("Role could not be unassigned. Please check if the role is assigned to other user.")
            End If
        End If

        cargarDatos(nombre, nombreOriginal)
    End Sub

    'Asignar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fami As New BLL.Familia
        Dim seguridad As New BLL.Seguridad("Password")
        Dim patente As String
        patente = Trim(ListBox1.SelectedItem.ToString)

        seguridad.AsignarPatenteFamilia(Me.nombre, patente)

        If (Login.ID_IDIOMA = 1) Then
            MessageBox.Show("Patente cargada correctamente !")
        Else
            MessageBox.Show("Role assigned succesfully !")
        End If


        cargarDatos(nombre, nombreOriginal)
    End Sub

    Private Sub ModificarFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Login.ID_IDIOMA = 1) Then
            Me.Text = "Modificar Familia"
        Else
            Me.Text = "Modify Group of Roles"
        End If

        Dim dtMensajes As New DataTable()
        Dim seguridad As New BLL.Seguridad("Password")
        dtMensajes = seguridad.ObtenerMensajes(Login.ID_IDIOMA, 12)

        lblNombre.Text = dtMensajes.Rows(0).Item(5).ToString
        lblDesc.Text = dtMensajes.Rows(1).Item(5).ToString
        lblPat.Text = dtMensajes.Rows(2).Item(5).ToString
        lblPatAsi.Text = dtMensajes.Rows(3).Item(5).ToString
        btnModif.Text = dtMensajes.Rows(4).Item(5).ToString
        btnCancel.Text = dtMensajes.Rows(5).Item(5).ToString


    End Sub

    'Modifica Nombre y Descripcion
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        If (validarConsistencia()) Then
            Dim seg As New BLL.Seguridad("Password")

            seg.ModificarDatosFamilia(Me.nombre, seg.Encriptar(TextBox1.Text))

            If (Login.ID_IDIOMA = 1) Then
                MessageBox.Show("Familia modificada correctamente")
            Else
                MessageBox.Show("Group of roles modified correctly")
            End If

            'seg.registrarBitacora(Login.ID_USUARIO, "MEDIA", DateTime.Now, "Familia modificada correctamente", 0)

            Me.Close()
            Dim administrarFamilias As New AdministracionFamilias
            administrarFamilias.Show()
        Else
            If (Login.ID_IDIOMA = 1) Then
                MessageBox.Show("Por favor valide los campos")
            Else
                MessageBox.Show("Please check blanck fields")
            End If
        End If
    End Sub

    Public Function validarConsistencia() As Boolean
        If (TextBox1.Text = "") Then
            Return False
        Else
            Return True
        End If
    End Function
End Class