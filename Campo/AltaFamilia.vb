Public Class AltaFamilia

    Dim dtPatentes As New DataTable
    Dim listadoPatentes As New List(Of String)

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    'Agrego las patentes al grid
    Private Sub AltaFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim dtMensajes As New DataTable()
        Dim seguridad As New BLL.Seguridad("Password")
        dtMensajes = seguridad.ObtenerMensajes(Login.ID_IDIOMA, 11)

        If (Login.ID_IDIOMA = 1) Then
            Me.Text = "Alta Familia"
        Else
            Me.Text = "Add Family Roles"
        End If

        lblNombre.Text = dtMensajes.Rows(0).Item(5).ToString
        lblPat.Text = dtMensajes.Rows(1).Item(5).ToString
        btnAgre.Text = dtMensajes.Rows(2).Item(5).ToString
        btnCancel.Text = dtMensajes.Rows(3).Item(5).ToString


        Me.CheckedListBox2.Items.Clear()
        Dim listadoPatentes As New BLL.Listas
        dtPatentes = listadoPatentes.obtenerListadoPatentes()

        For Each row As DataRow In dtPatentes.Rows
            Me.CheckedListBox2.Items.Add(row(0).ToString)
        Next
    End Sub

    'Añado la  familia.
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAgre.Click
        Dim seguridad As New BLL.Seguridad("Password")

        If (validarConsistencia) Then


            For i As Integer = 0 To CheckedListBox2.CheckedItems.Count - 1
                listadoPatentes.Add(CheckedListBox2.CheckedItems(i).ToString)
            Next

            Dim bllFamilia As New BLL.Familia(TextBox1.Text, listadoPatentes)
            bllFamilia.altaFamilia(bllFamilia)

            listadoPatentes = Nothing

            If (Login.ID_IDIOMA = 1) Then
                MessageBox.Show("Familia creada correctamente !")
            Else
                MessageBox.Show("Group of roles created succesfully !")
            End If

            'seguridad.registrarBitacora(Login.ID_USUARIO, "MEDIA", DateTime.Now, "Familia creada correctamente", 0)


            Me.Close()
            Dim fam As New AdministracionFamilias
            fam.Show()
        Else
            If (Login.ID_IDIOMA = 1) Then
                MessageBox.Show("Por favor valide los campos")
            Else
                MessageBox.Show("Please check blanck fields")
            End If

        End If

    End Sub


    Public Function validarConsistencia() As Boolean
        If TextBox1.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

End Class