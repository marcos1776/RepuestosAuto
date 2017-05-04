Public Class Listas


    Public Function obtenerUsuarios() As DataSet
        Dim ds As New DataSet
        Dim seguridad As New Seguridad("Password")
        Dim listadoUsuarios As New DAL.Usuario

        ds = listadoUsuarios.obtenerUsuarios

        For Each row As DataRow In ds.Tables("DatosUsuario").Rows
            row.Item(0) = seguridad.Desencriptar(row.Item(0).ToString)
            row.Item(1) = seguridad.Desencriptar(row.Item(1).ToString)
            row.Item(2) = seguridad.Desencriptar(row.Item(2).ToString)
            row.Item(3) = seguridad.Desencriptar(row.Item(3).ToString)
            row.Item(4) = seguridad.Desencriptar(row.Item(4).ToString)
            row.Item(5) = seguridad.Desencriptar(row.Item(5).ToString)
        Next

        Return ds
    End Function

    Public Function obtenerProveedores() As DataSet
        Dim ds As New DataSet
        Dim seguridad As New Seguridad("Password")
        Dim listadoProveedores As New DAL.Proveedor
        ds = listadoProveedores.ObtenerProveedores


        For Each row As DataRow In ds.Tables("DatosProveedores").Rows
            row.Item(0) = seguridad.Desencriptar(row.Item(0).ToString)
            row.Item(1) = seguridad.Desencriptar(row.Item(1).ToString)
            row.Item(2) = seguridad.Desencriptar(row.Item(2).ToString)
            row.Item(3) = seguridad.Desencriptar(row.Item(3).ToString)
        Next



        Return ds
    End Function

    Public Function obtenerListadoArticulos() As DataSet
        Dim seguridad As New BLL.Seguridad("Password")

        Dim listadoArticulos As New DAL.Articulo
        Dim ds As New DataSet
        ds = listadoArticulos.obtenerListadoArticulos()

        For Each row As DataRow In ds.Tables("ArticulosProveedores").Rows
            row.Item(0) = seguridad.Desencriptar(row.Item(0).ToString)
        Next

        Return ds
    End Function

    Public Function obtenerListadoArticulosProveedores(s As String) As DataTable
        Dim dt As New DataTable
        Dim listadoArticulos As New DAL.Articulo
        dt = listadoArticulos.obtenerListadoArticulosProveedores(s)

        Return dt
    End Function

    Public Function obtenerListadoPatentes() As DataTable
        Dim dt As New DataTable
        Dim ListadoPatentes As New DAL.Listas
        dt = ListadoPatentes.obtenerListadoPatentes()

        Return dt
    End Function

    Public Function obtenerListadoPatentesRestantes2(fam As String) As DataTable
        Dim dt As New DataTable
        Dim ListadoPatentes As New DAL.Listas
        dt = ListadoPatentes.obtenerListadoPatentesRestantes2(fam)

        Return dt
    End Function



    Public Function obtenerListadoFamilias() As DataTable
        Dim dt As New DataTable
        Dim seguridad As New BLL.Seguridad("Password")
        Dim ListadoFamilias As New DAL.Listas
        dt = ListadoFamilias.obtenerListadoFamilias()

        For Each fam As DataRow In dt.Rows
            fam.Item(0) = seguridad.Desencriptar(fam.Item(0).ToString)
        Next

        Return dt
    End Function


    Public Function obtenerListadoMovimientos() As DataTable
        Dim dt As New DataTable
        Dim seguridad As New BLL.Seguridad("Password")
        Dim listadoMovimientos As New DAL.Listas
        dt = listadoMovimientos.obtenerListadoMovimientos()

        For Each us As DataRow In dt.Rows
            us.Item(0) = Seguridad.Desencriptar(us.Item(0).ToString)
        Next



        Return dt
    End Function

    'Movimientos Bitacora
    'Public Function obtenerListadoMovimientos(desde As DateTime, hasta As DateTime, user As String, criticidad As String) As DataTable

    Public Function obtenerListadoMovimientos(user As String, criticidad As String, desde As String, hasta As String) As DataTable
        Dim dt As New DataTable
        Dim listadoMovimientos As New DAL.Listas


        'Dim listadoParametros As New List(Of String)


        'If (user IsNot Nothing) Then
        '    Dim s As String = "u1.nick = '" & user & "'"
        'End If

        'If (criticidad IsNot Nothing) Then
        '    Dim s As String = "b1.Criticidad = '" & criticidad & "'"
        'End If

        ''If (desde IsNot Nothing) Then
        ''    Dim s As String = "u1.nick = '" & user & "'"
        ''End If



        'Dim listado As New List(Of String)
        'listado.Add(user)
        'listado.Add(criticidad)
        'listado.Add(desde)
        'listado.Add(hasta)







        'dt = listadoMovimientos.obtenerListadoMovimientos(desde, hasta, user, criticidad)
        dt = listadoMovimientos.obtenerListadoMovimientos(user, criticidad, desde, hasta)

        Return dt
    End Function

    'Obtengo las patentes correspondientes a una familia
    Public Function ObtenerListadoPatentesDeFamilia(familia As String) As DataTable
        Dim dt As New DataTable
        Dim listadoPatentesDeFamlia As New DAL.Listas
        dt = listadoPatentesDeFamlia.obtenerListadoPatentesDeFamilia(familia)

        Return dt
    End Function

    'Obtengo patentes para un usuario particular
    Public Function obtenerListadoPatentesUsuario(user As String) As DataSet
        Dim listado As New DAL.Listas

        Return listado.obtenerListadoPatentesUsuario(user)
    End Function

    'Obtengo Familias para un usuario particular
    Public Function obtenerListadoFamiliasUsuario(user As String) As DataSet
        Dim listado As New DAL.Listas
        Dim ds As DataSet
        Dim seguridad As New BLL.Seguridad("Password")

        ds = listado.obtenerListadoFamiliasUsuario(user)

        For Each fam As DataRow In ds.Tables("DatosFamilias").Rows
            fam.Item(0) = Seguridad.Desencriptar(fam.Item(0).ToString)
        Next

        Return ds
    End Function

    Public Function obtenerPatentes(user As String) As DataTable
        Dim dal As New DAL.Listas
        Return dal.obtenerPatentes(user)
    End Function

    Public Function obtenerPatentesAsignablesActualizada(user As String) As DataTable
        Dim dal As New DAL.Listas
        Return dal.obtenerPatentesActualizadas(user)
    End Function




    Public Function obtenerListadoClientes(tipo As Char) As DataTable
        Dim listas As New DAL.Listas
        Return listas.obtenerListadoClientes(tipo)
    End Function



    'Obtengo patentes restantes al usuario seleccionado
    Public Function obtenerListadoPatentesRestantes(nom As String) As DataTable
        Dim dal As New DAL.Listas
        Return dal.obtenerListadoPatentesRestantes(nom)
    End Function


End Class
