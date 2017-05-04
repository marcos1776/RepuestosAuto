Public Class RealizarRestore


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    'Realizar Restore
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim seg As New BLL.Seguridad("Password")

            'seg.RealizarRestore(Path)
            seg.RealizarRestore("aasd")

            'seg.registrarBitacora()
        Catch ex As Exception
            MessageBox.Show("Error al realizar restore")

            'seg.registrarBitacora()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OFD As New OpenFileDialog()

        Dim dialogo As DialogResult, m_PrimerNO As Boolean = True

        'Busco la primera parte
        Dim Partes As List(Of String)
        'dialogo = MsgBox(oIdioma.Cargar(Variables.ID_Idioma, "msg_UnaParte"), MsgBoxStyle.YesNo, "Mensaje")



        'MessageBox.Show("Desea cargar un archivo de origen ?", MsgBoxStyle.YesNo, "Consulta")
        'MessageBox.Show("Show", MsgBoxStyle.YesNo, "asd")

        OFD.Filter = "Archivo BAK (*.Bak)|*.bak"

        'Voy agregando las partes
        While dialogo = Windows.Forms.DialogResult.Yes
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                Partes.Add(OFD.FileName.ToString)
            End If
            'dialogo = MsgBox(oIdioma.Cargar(Variables.ID_Idioma, "msg_MasPartes"), MsgBoxStyle.YesNo, "Mensaje")

            m_PrimerNO = False
        End While

        If dialogo = Windows.Forms.DialogResult.No And m_PrimerNO = True Then
            Exit Sub
        End If
        'Si hay mas de una parte, creo el path para la query SQL
        'If Not Partes Is Nothing Then
        '    For Each origen As String In Partes
        '        Path = Path & "DISK = ''" & origen.ToString & "'', "
        '    Next
        '    Path = Path.Remove(Path.Length - 2, 2)
        'End If
        'txtOrigen.Text = Path
    End Sub
End Class