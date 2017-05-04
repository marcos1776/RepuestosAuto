Public Class Familia

    Public _Nombre As String
    Public _listadoPatentes As List(Of String)

    Public Sub New(n As String, l As List(Of String))
        Me._Nombre = n
        Me._listadoPatentes = l
    End Sub

    Public Sub New()

    End Sub

    'Alta familia + asignacion patentes
    Public Sub altaFamilia(Fam As Familia)
        'Inserto la familia
        Dim fami As New DAL.Familia()
        Dim idFamilia As Integer
        Dim seguridad As New BLL.Seguridad("Password")
        Dim nombreFamilia As String
        Dim famDt As DataTable
        Dim dvh As Integer
        nombreFamilia = seguridad.Encriptar(Fam._Nombre)

        idFamilia = fami.altaFamilia(nombreFamilia)

        '''''''''''''' Calculo de DVH ''''''''''''''''''''''
        famDt = fami.obtenerFamiliaXid(idFamilia)

        Dim str As String
        str = famDt.Rows(0).Item(0) & "" & famDt.Rows(0).Item(1)

        dvh = seguridad.calcularDVH(str)
        seguridad.ModificarDVH(idFamilia, dvh, "Familia", "idFamilia")

        '''''''''''''''''''''''''''''''''''''''''''''''


        ' Registro en Bitacora

        'seguridad.registrarBitacora(Login.ID_USUARIO, "BAJA", DateTime.Now, "Alta Familia", 0)


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''


        'Inserto la relacion familia y patentes.
        For Each pat As String In Fam._listadoPatentes
            fami.AsignarPatentes(nombreFamilia, pat)
        Next

    End Sub


    Public Function buscarFamilia(nombre As String) As DataTable
        Dim familia As New DAL.Familia
        Return familia.buscarFamilia(nombre)
    End Function


    Public Function EliminarFamilia(nombre As String) As Boolean
        Dim familia As New DAL.Familia
        Dim dt As New DataTable

        dt = familia.validarFamilia(nombre)

        If dt.Rows.Count <> 31 Then
            Return False
        Else
            familia.eliminarFamilia(nombre)
            Return True
        End If

        Return True
    End Function


End Class
