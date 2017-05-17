Public Class RealizarRestore
    Dim consulta As String = ""
    Dim fd As OpenFileDialog = New OpenFileDialog()
    Dim Partes As List(Of String)

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    'Realizar Restore
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim seg As New BLL.Seguridad("Password")

            'seg.RealizarRestore(Path)
            seg.RealizarRestore(consulta)

            'seg.registrarBitacora()
        Catch ex As Exception
            MessageBox.Show("Error al realizar restore")

            'seg.registrarBitacora()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim seg As New BLL.Seguridad("Password")
        Dim OFD As New OpenFileDialog()

        Dim mensaje As DialogResult, m_PrimerNO As Boolean = True

        'Busco la primera parte
        Partes = New List(Of String)

        If Login.ID_IDIOMA = 1 Then
            mensaje = MsgBox("Desea elegir el archivo de origen? ", MsgBoxStyle.YesNo, "Mensaje")
        Else
            mensaje = MsgBox("Would you Like to select a source file ? ", MsgBoxStyle.YesNo, "Mensaje")
        End If



        'Voy agregando las partes
        While mensaje = Windows.Forms.DialogResult.Yes
            If fd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Partes.Add(fd.FileName.ToString)
            End If

            If Login.ID_IDIOMA = 1 Then
                mensaje = MsgBox("¿ Desea añadir otra parte ? ", MsgBoxStyle.YesNo, "Mensaje")
            Else
                mensaje = MsgBox("Would you Like to add another part ? ", MsgBoxStyle.YesNo, "Mensaje")
            End If

            m_PrimerNO = False
        End While

        If mensaje = Windows.Forms.DialogResult.No And m_PrimerNO = True Then
            Exit Sub
        End If
        'Si hay mas de una parte, creo el path para la query SQL
        If Not Partes Is Nothing Then
            For Each origen As String In Partes
                consulta = consulta & "DISK = ''" & origen.ToString & "'', "
            Next
            consulta = consulta.Remove(consulta.Length - 2, 2)
        End If
        TextBox2.Text = consulta

        'Dim idBitacora As Integer = seg.registrarBitacora(Login.ID_USUARIO, "Alto", DateTime.Now, "Backup", 0)
    End Sub

    Private Sub RealizarRestore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    End Sub
End Class