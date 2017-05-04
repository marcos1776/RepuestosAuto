Public Class AdministracionFamilias
    Dim dtFamilia As New DataTable
    Dim dtPatentes As New DataTable

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        MenuPrincipal.Show()

        '(MsgBox("La familia ha sido habilitada", MsgBoxStyle.OkOnly, "Advertencia"))
    End Sub

    'Alta familia.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevaFam.Click
        Me.Close()
        Dim altaFamilia As New AltaFamilia
        altaFamilia.Show()
    End Sub

    'Load
    Private Sub AdministracionFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtMensajes As New DataTable()
        Dim seguridad As New BLL.Seguridad("Password")
        dtMensajes = seguridad.ObtenerMensajes(Login.ID_IDIOMA, 10)

        If (Login.ID_IDIOMA = 1) Then
            Me.Text = "Menu Familia de Patentes"
        Else
            Me.Text = "Family Roles Menu"
        End If

        lblFamiHabi.Text = dtMensajes.Rows(0).Item(5).ToString
        lblBusc.Text = dtMensajes.Rows(1).Item(5).ToString
        lblBusc2.Text = dtMensajes.Rows(1).Item(5).ToString
        lblPat.Text = dtMensajes.Rows(2).Item(5).ToString
        'btnAcept.Text = dtMensajes.Rows(3).Item(5).ToString
        btnCancel.Text = dtMensajes.Rows(4).Item(5).ToString
        btnNuevaFam.Text = dtMensajes.Rows(5).Item(5).ToString
        btnModifFam.Text = dtMensajes.Rows(6).Item(5).ToString
        btnElimFam.Text = dtMensajes.Rows(7).Item(5).ToString

        CheckedListBox2.SelectionMode = SelectionMode.None
        CargarDatagrid()
    End Sub

    'Cargo Grid
    Public Sub CargarDatagrid()
        ListBox1.Items.Clear()

        Dim fam As New BLL.Listas
        dtFamilia = fam.obtenerListadoFamilias

        For Each row As DataRow In dtFamilia.Rows
            ListBox1.Items.Add(row(0).ToString)
        Next

        Dim pat As New BLL.Listas
        dtPatentes = pat.obtenerListadoPatentes

        For Each row As DataRow In dtPatentes.Rows
            CheckedListBox2.Items.Add(row(0).ToString)
        Next
    End Sub

    'Cuando seleccione una familia se marquen las patentes
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If (DirectCast(sender, ListBox).Text = "") Then
            If (Login.ID_IDIOMA = 1) Then
                MessageBox.Show("Por favor seleccione una familia")
            Else
                MessageBox.Show("Please select a family")
            End If




        Else
            Dim seg As New BLL.Seguridad("Password")

            Dim nombreFamilia As String
            nombreFamilia = seg.Encriptar(ListBox1.SelectedItem)

            For i As Integer = 0 To CheckedListBox2.Items.Count - 1
                CheckedListBox2.SetItemCheckState(i, CheckState.Unchecked)
            Next

            Dim dt As New DataTable
            Dim listadoPatentes As New BLL.Listas

            dt = listadoPatentes.ObtenerListadoPatentesDeFamilia(nombreFamilia)
            'Dim i As Integer = 1

            For Each rowPatente As DataRow In dt.Rows
                For i As Integer = 0 To CheckedListBox2.Items.Count - 1
                    If (rowPatente(0).ToString = CheckedListBox2.Items(i).ToString) Then
                        'MessageBox.Show(pat)
                        CheckedListBox2.SetItemCheckState(i, CheckState.Checked)
                    End If
                Next
            Next


        End If

    End Sub

    'Modificar Familia
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnModifFam.Click
        Dim seguridad As New BLL.Seguridad("Password")

        Dim nombreOriginal As String = ListBox1.SelectedItem.ToString
        Dim NombreFamilia As String = seguridad.Encriptar(ListBox1.SelectedItem)


        Dim modificar As New ModificarFamilia
        modificar.cargarDatos(NombreFamilia, nombreOriginal)
        Me.Close()
    End Sub

    'Eliminar familia
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnElimFam.Click
        'Haga una transaccion , y valide si la asignacion es correcta
        Dim seguridad As New BLL.Seguridad("Password")
        Dim familia As New BLL.Familia

        Dim NombreFamilia As String = seguridad.Encriptar(ListBox1.SelectedItem)

        Dim validacion As Boolean = familia.EliminarFamilia(NombreFamilia)

        If (validacion) Then
            If (Login.ID_IDIOMA = 1) Then
                MessageBox.Show("La familia ha sido eliminada correctamente")
            Else
                MessageBox.Show("The group of roles has been deleted correctly")
            End If
            'seguridad.registrarBitacora(ID_USUARIO, "MEDIA", DateTime.Now, "Eliminar Familia", 0)
        Else

            If (Login.ID_IDIOMA = 1) Then
                MessageBox.Show("La familia no pudo eliminarse. Validar Patentes Asignadas.")
            Else
                MessageBox.Show("the group of roles could not be deleted. Please verify the assign of the roles.")
            End If
        End If

        CargarDatagrid()
    End Sub


End Class