Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Listas

    'Obtengo listado Patentes
    Public Function obtenerListadoPatentes() As DataTable
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = "select Nombre from patente"

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandType = CommandType.Text
        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        com.ExecuteNonQuery()


        sqlCon.Close()
        Return t
    End Function


    Public Function obtenerListadoPatentesRestantes2(pat As String) As DataTable
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = "select pat.* from Patente pat " +
                              " where " +
                              "pat.nombre Not In (Select pp.nombre from familia ff " +
                              "Join FamiliaPatente fp on fp.IdFamilia = ff.IdFamilia " +
                              "Join Patente pp on pp.IdPatente = fp.IdPatente " +
                              "where ff.Nombre = '" + pat + "')"

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandType = CommandType.Text
        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        com.ExecuteNonQuery()


        sqlCon.Close()
        Return t
    End Function

    'Obtengo listado Patentes de las familias la familia
    Public Function obtenerListadoPatentesDeFamilia(fam As String) As DataTable
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = "Select pat.Nombre from FamiliaPatente f " +
        "join Patente pat On pat.idPatente = f.idPatente " +
        "join Familia fam On fam.idFamilia = f.idFamilia " +
        "where fam.Nombre ='" + fam + "'"

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandType = CommandType.Text
        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        com.ExecuteNonQuery()


        sqlCon.Close()
        Return t
    End Function

    'Obtengo listado Familias
    Public Function obtenerListadoFamilias() As DataTable
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = "select Nombre from Familia"

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandType = CommandType.Text
        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        com.ExecuteNonQuery()

        sqlCon.Close()
        Return t
    End Function

    'Obtengo Movimientos Bitacora para llenado de grilla
    Public Function obtenerListadoMovimientos() As DataTable
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = "select u.Nick, b1.Criticidad, b1.Fecha, b1.Descripcion from Bitacora b1 Join usuario u on u.idUsuario = b1.IdUsuario"
        Dim com As New SqlCommand(query, sqlCon)

        com.CommandType = CommandType.Text
        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        com.ExecuteNonQuery()
        sqlCon.Close()
        Return t
    End Function

    'Obtengo Movimientos Bitacora segun los datos insertados.
    'Public Function obtenerListadoMovimientos(desde As DateTime, hasta As DateTime, user As String, criticidad As String) As DataTable

    Public Function obtenerListadoMovimientos(user As String, criticidad As String, desde As String, hasta As String) As DataTable
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = "select b1.* from bitacora b1 " +
        "join usuario u1 on b1.idUsuario = u1.IdUsuario " +
        "where (1=1) "

        If user <> "" Then
            query = query + " AND  u1.Nick = '" & user & "'"
        End If

        If criticidad <> "" Then
            query = query + " AND  b1.Criticidad = '" & criticidad & "'"
        End If

        If desde <> Nothing Then
            query = query + " AND  convert(date,b1.Fecha,106) >= '" & desde & "'"
        End If

        If hasta <> Nothing Then
            query = query + " AND  convert(date,b1.Fecha,106) <= '" & hasta & "'"
        End If

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandType = CommandType.Text
        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        com.ExecuteNonQuery()

        sqlCon.Close()
        Return t
    End Function

    Public Function ObtenerRegistrosTabla(tabla As String) As DataTable
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()
        Dim query As String = "Select * from " & tabla

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandType = CommandType.Text
        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        com.ExecuteNonQuery()


        sqlCon.Close()
        Return t
    End Function

    Public Function obtenerListadoTablasConDVV() As DataTable
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()
        Dim query As String = "Select * from DVV"

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandType = CommandType.Text
        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        com.ExecuteNonQuery()


        sqlCon.Close()
        Return t
    End Function

    'Obtengo patentes segun el usuario
    Function obtenerListadoPatentesUsuario(user As String) As DataSet
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = "select p.Nombre from usuarioPatente up " +
            "JOIN patente p on p.IdPatente = up.IdPatente " +
            "JOIN usuario u on u.idUsuario = up.idUsuario " +
            "Where u.Nick = '" & user & "' " +
            "UNION ALL " +
            " select p.Nombre from patente p                                     " +
            " where idPatente in (                                               " +
            " select IdPatente from FamiliaPatente fp                            " +
            " where fp.IdFamilia in (select idFamilia from UsuarioFamilia uf     " +
            " join usuario u on u.IdUsuario = uf.IdUsuario " +
            " where u.Nick = '" & user & "'))  "


        Dim query2 As String =
            " select p.nombre from patente p" +
            " join usuarioPatente up on up.IdPatente = p.IdPatente" +
            " join usuario u on up.IdUsuario = u.IdUsuario" +
            " where up.EsNegada = 'Y'" +
            " and  u.Nick = '" & user & "'"


        Dim Datos As New DataSet()

        Dim adapterPatentes As SqlDataAdapter = New SqlDataAdapter(query, sqlCon)
        Dim adapterPatentesNegadas As SqlDataAdapter = New SqlDataAdapter(query2, sqlCon)


        adapterPatentes.Fill(Datos, "DatosPatentes")
        adapterPatentesNegadas.Fill(Datos, "DatosPatentesNegadas")

        sqlCon.Close()
        Return Datos

    End Function

    'Obtengo familias segun el usuario
    Function obtenerListadoFamiliasUsuario(user As String) As DataSet
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim listadoFamilias As String = "select fam.nombre from UsuarioFamilia f " +
            "Join Usuario u on u.IdUsuario = f.IdUsuario " +
            "join Familia fam on fam.IdFamilia = f.IdFamilia " +
            "Where u.Nick = '" & user & "'"

        Dim PatentesDeFamilia As String = "select p.Nombre from UsuarioFamilia u " +
            "join FamiliaPatente F on f.IdFamilia = u.IdFamilia " +
            "join patente p on p.IdPatente = f.IdPatente " +
            "join usuario usu on usu.IdUsuario = U.IdUsuario " +
            "where usu.Nick = '" & user & "'"

        Dim Datos As New DataSet()

        Dim adapterFamilias As SqlDataAdapter = New SqlDataAdapter(listadoFamilias, sqlCon)
        Dim adapterPatentesDeFamilia As SqlDataAdapter = New SqlDataAdapter(PatentesDeFamilia, sqlCon)


        adapterFamilias.Fill(Datos, "DatosFamilias")
        adapterPatentesDeFamilia.Fill(Datos, "DatosPatentes")

        sqlCon.Close()
        Return Datos

    End Function


    Public Function obtenerListadoClientes(tipo As Char) As DataTable
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()
        Dim query As String

        If tipo = "c" Then
            query = "select Nombre,Apellido,Dni from cliente"
        Else
            query = "select Razon_Social, Cuit from Empresa"
        End If


        Dim com As New SqlCommand(query, sqlCon)

        com.CommandType = CommandType.Text
        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        com.ExecuteNonQuery()


        sqlCon.Close()
        Return t

    End Function

    Public Function obtenerListadoPatentesRestantes(nom As String) As DataTable
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()
        Dim query As String

        query =
" SELECT PAT.NOMBRE from patente PAT where PAT.nombre NOT IN(        " +
" select p.Nombre from UsuarioPatente up                             " +
" join patente p on up.IdPatente = p.IdPatente                       " +
" join usuario u on u.IdUsuario = up.IdUsuario                       " +
" where u.Nick = '" & nom & "' " +
" and up.EsNegada = 'N'                                             " +
"                                                                    " +
" UNION ALL                                                          " +
" select p.Nombre from patente p                                     " +
" where idPatente in (                                               " +
" select IdPatente from FamiliaPatente fp                            " +
" where fp.IdFamilia in (select idFamilia from UsuarioFamilia uf     " +
" 						join usuario u on u.IdUsuario = uf.IdUsuario " +
" 						where u.Nick = '" & nom & "'))  " +
" )                                                                  "



        Dim com As New SqlCommand(query, sqlCon)

        com.CommandType = CommandType.Text
        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        com.ExecuteNonQuery()
        Return t

        sqlCon.Close()
    End Function







    Public Function obtenerPatentes(user As String) As DataTable
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = "select pat.nombre, t.* FROM vistaPatentes t " +
                                "join patente pat On t.IdPatente = pat.IdPatente " +
                                "join usuario usu On usu.IdUsuario = t.IdUsuario " +
                                "where usu.nick = '" + user + "' " +
                                "and idFamilia = 0 "


        '"delete from patenteTemporal " +
        '"INSERT INTO patenteTemporal (nombre,idUsuario,idFamilia,idPatente,esNegada)" +
        '"( " +
        '    "Select pat.Nombre, uf.idUsuario, fp.IdFamilia As IdFamilia , fp.IdPatente, 'N' as EsNegada  from FamiliaPatente fp " +
        '    "Join UsuarioFamilia uf On fp.IdFamilia = uf.idFamilia " +
        '    " join patente pat on pat.idPatente = fp.IdPatente " +
        '    "UNION ALL Select pat.Nombre, up.idUsuario, '' as IdFamilia, up.idPatente, EsNegada from UsuarioPatente up " +
        '    " join patente pat on pat.idPatente = up.IdPatente " +
        '")" +
        '"Select pat.nombre,t.* FROM patenteTemporal t " +
        '     "join patente pat On t.IdPatente = pat.IdPatente " +
        '"join usuario usu On usu.IdUsuario = t.IdUsuario " +
        '"where usu.nick = '" + user + "' " +
        '"and idFamilia = 0 "


        Dim com As New SqlCommand(query, sqlCon)

        com.CommandType = CommandType.Text
        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        com.ExecuteNonQuery()

        sqlCon.Close()
        Return t
    End Function


    Public Function obtenerPatentesActualizadas(user As String) As DataTable
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String =
        " select * from patente pat " +
        " where pat.nombre Not In " +
        "(select distinct(pat.nombre) from vistaPatentes t " +
        " Join Patente pat on t.IdPatente = pat.IdPatente " +
        " Join Usuario usu on usu.IdUsuario = t.IdUsuario " +
        " where " +
        " usu.nick = '" + user + "' " +
        " and idFamilia = 0 )"


        Dim com As New SqlCommand(query, sqlCon)

        com.CommandType = CommandType.Text
        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        com.ExecuteNonQuery()

        sqlCon.Close()
        Return t
    End Function







End Class
