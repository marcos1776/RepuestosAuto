Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Seguridad
    Public Sub CreartablaTemporal()
        Dim query As String = "CREATE TABLE UsuarioPatenteLocal( " +
        "[IdUsuarioPatente] [int] IDENTITY(1,1) NOT NULL, " +
        "[IdUsuario] [int] NULL, " +
        "[IdPatente] [int] NULL, " +
        "[EsNegada] [char](1) NULL, " +
        "[DVH] [int] NULL)"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub

    Public Sub InsertarPatenteTemporal(pat As String, user As String)
        Dim queryInsert As String = "Insert  into UsuarioPatenteLocal ( IdUsuario, IdPatente, EsNegada, DVH) values " +
        "((select idUsuario from usuario where Nick='" + user + "') " +
        ",(select idPatente from patente where Nombre='" + pat + "') " +
        ",'N', null)"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryInsert, sqlCon)

        com.CommandText = queryInsert
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub

    Public Function ObtenerPatentesDeUsuario(idUser As Integer) As DataTable
        Dim query As String = "select * from vistaPatentes where idUsuario = " & idUser
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()
        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        sqlCon.Close()
        Return t
    End Function


    Public Function obtenerTabla(tab As String) As DataTable
        Dim query As String = "select * from " + tab
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()
        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        sqlCon.Close()
        Return t
    End Function

    Public Sub AsignarPatenteUsuario(user As String, pat As String)
        Dim queryInsert As String = "Insert  into UsuarioPatente ( IdUsuario, IdPatente, EsNegada, DVH) values " +
        "((select idUsuario from usuario where Nick='" + user + "') " +
        ",(select idPatente from patente where Nombre='" + pat + "') " +
        ",'N', null)"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryInsert, sqlCon)

        com.CommandText = queryInsert
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub

    Public Function cantidadPatentesAsignadas(user As String) As DataSet
        Dim datos As New DataSet

        Dim queryPatentesAsignadas As String = "select distinct(upp.IdPatente) from UsuarioPatente upp " +
        "where idPatente not in ( select idPatente from UsuarioPatente up join usuario u on u.IdUsuario = up.IdUsuario where Nick ='" & user & "') " +
        "UNION ALL select idPatente from UsuarioPatenteLocal"

        Dim queryPatentes As String = "select * from Patente"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryPatentesAsignadas, sqlCon)
        Dim com2 As New SqlCommand(queryPatentes, sqlCon)

        Dim patentesAsignadas As SqlDataAdapter = New SqlDataAdapter(queryPatentesAsignadas, sqlCon)
        Dim todasPatentes As SqlDataAdapter = New SqlDataAdapter(queryPatentes, sqlCon)


        patentesAsignadas.Fill(datos, "patentesAsignadas")
        todasPatentes.Fill(datos, "todasPatentes")

        sqlCon.Close()

        Return datos
    End Function

    Public Function RegitrarBitacora(ID_USUARIO As Integer, tipo As String, hoy As DateTime, desc As String, dvh As Integer) As Integer
        Dim idBitacora As Integer
        Dim queryInsert As String = "Insert  into Bitacora ( IdUsuario, Criticidad, Fecha, descripcion, DVH) values (" & ID_USUARIO & ",'" + tipo + "','" + hoy.ToString("MM/dd/yyyy HH:mm") + "','" + desc + "'" + ",0)"
        Dim query2 As String = "Select @@Identity"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryInsert, sqlCon)

        com.CommandText = queryInsert
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()

        com.CommandText = query2
        idBitacora = com.ExecuteScalar()

        sqlCon.Close()

        Return idBitacora
    End Function

    Public Sub borrarPatentesUsuario(user As String)
        Dim queryInsert As String = "Delete from usuarioPatente where idUsuario = (select IdUsuario from usuario where Nick = '" & user & "')"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryInsert, sqlCon)

        com.CommandText = queryInsert
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub

    Public Function InsertarPatente(user As String, pat As String) As Integer
        Dim idUsuarioPatente

        Dim queryInsert As String = "Insert  into UsuarioPatente ( IdUsuario, IdPatente, EsNegada, DVH) values " +
        "((select idUsuario from usuario where Nick='" + user + "') " +
        ",(select idPatente from patente where nombre = '" & pat & "')" +
        ",'N', null)"

        Dim query2 As String = "Select @@Identity"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryInsert, sqlCon)

        com.CommandText = queryInsert
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()

        com.CommandText = query2
        idUsuarioPatente = com.ExecuteScalar()

        sqlCon.Close()

        Return idUsuarioPatente

    End Function

    Public Sub BorrartablaTemporal()
        Dim queryInsert As String = "Drop table UsuarioPatenteLocal"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryInsert, sqlCon)

        com.CommandText = queryInsert
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub

    Public Function ValidarContraseña(IdUsuario As Integer, contraseña As String) As DataTable
        Dim query As String = "select idUsuario from usuario where idUsuario = " & IdUsuario & " and contraseña = '" & contraseña & "'"
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()
        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        sqlCon.Close()
        Return t

    End Function

    Public Sub ModificarContraseña(idUsuario As Integer, password As String)
        Dim queryInsert As String = "Update usuario set contraseña ='" & password & "' where idUsuario =" & idUsuario & ""
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryInsert, sqlCon)

        com.CommandText = queryInsert
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()
        sqlCon.Close()

    End Sub


    Public Sub ModificarDVH(id As String, dvh As Integer, tabla As String, idName As String)
        Dim queryInsert As String = "Update " & tabla & " set dvh =" & dvh & " where " & idName & " = '" & id & "'"
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryInsert, sqlCon)

        com.CommandText = queryInsert
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub

    Public Sub ModificarDVH2(id As String, id2 As String, dvh As Integer, tabla As String, idName As String, idName2 As String)
        Dim queryInsert As String = "Update " & tabla & " set dvh =" & dvh & " where " & idName & " = '" & id & "' and " & idName2 & " = '" & id2 & "'"
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryInsert, sqlCon)

        com.CommandText = queryInsert
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub

    Public Function ObtenerIdUsuarioPatente(id As Integer) As DataSet
        Dim dat As New DataSet
        Dim queryUP As String = "select * from UsuarioPatente where idUsuarioPatente = " & id

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryUP, sqlCon)

        Dim patentesAsignadas As SqlDataAdapter = New SqlDataAdapter(queryUP, sqlCon)

        patentesAsignadas.Fill(dat, "UsuarioPatente")

        sqlCon.Close()

        Return dat
    End Function

    Public Function ValidarPatente(user As String, pat As String) As Integer
        Dim cantPat As Integer
        Dim queryPat As String =
" select Count(distinct(idPatente)) from patente where idPatente in(" +
" select idPatente from usuarioPatente " +
" where IdUsuarioPatente not in " +
" (select IdUsuarioPatente from usuarioPatente where  idUsuario = " +
" (select idUsuario from usuario where nick = '" & user & " ')" +
"  and  idPatente = (select idPatente from patente where nombre = '" & pat & "'))" +
"  UNION ALL" +
" select fp.IdPatente from UsuarioFamilia uf " +
" join familiaPatente fp on fp.IdFamilia = uf.IdFamilia" +
" where fp.idFamiliaPatente not in  (" +
" select pf.IdFamiliaPatente from patente p" +
" join FamiliaPatente pf on pf.idPatente = p.IdPatente" +
" join UsuarioFamilia uf on uf.IdFamilia = pf.idFamilia" +
" where p.nombre  = '" & pat & "')" +
" and uf.IdUsuario = (select idUsuario from usuario where nick = '" & user & " ')" +
" )"

        '"  select p.IdPatente from patente p                                    " +
        '"  where idPatente in (                                               " +
        '"  select IdPatente from FamiliaPatente fp                            " +
        '"  where fp.IdFamilia in (select idFamilia from UsuarioFamilia uf     " +
        '"  join usuario u on u.IdUsuario = uf.IdUsuario " +
        '"  ))" +

        '+
        '"  where u.Nick = '" & user & "'" +




        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryPat, sqlCon)

        com.CommandText = queryPat
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        cantPat = com.ExecuteScalar()

        sqlCon.Close()

        Return cantPat
    End Function

    Public Function AsignarFamiliaUsuario(nick As String, fam As String)

        Dim queryFam As String = "Insert into UsuarioFamilia (IdUsuario,IdFamilia,DVH) VALUES (" &
            "(select idUsuario from usuario where nick = '" + nick + "'),(Select idFamilia from Familia where nombre = '" + fam + "') , 0)"


        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryFam, sqlCon)

        com.CommandText = queryFam
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()



        sqlCon.Close()

        Return 0
    End Function


    Public Function ObtenerMensajes(Idioma As Integer, Form As Integer) As DataTable
        Dim queryUP As String = "select * from mensajes where id_idioma = " & Idioma & " and ID_FORM =  " & Form & "Order by id_campo asc "

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryUP, sqlCon)

        Dim mensaje As SqlDataAdapter = New SqlDataAdapter(queryUP, sqlCon)

        Dim dr As SqlDataReader
        dr = com.ExecuteReader


        Dim t As DataTable = New DataTable
        t.Load(dr)

        sqlCon.Close()
        Return t
    End Function


    Public Sub DenegarPatente(user As String, pat As String)

        Dim queryFam As String = "Update usuarioPatente set esNegada = 'N' where idUsuario " +
        "= (select idUsuario from usuario where nick = '" + user + "')" +
        " and idPatente = (select idPatente from patente where nombre = '" + pat + "')"


        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryFam, sqlCon)

        com.CommandText = queryFam
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()



        sqlCon.Close()
    End Sub

    Public Function PatenteValidacion(user As String, pat As String) As DataTable

        'Dim queryFam As String = "select * from vistaPatentes where idPatente = " +
        '"(select idPatente from patente where nombre = '" + pat + "') and " +
        '"idUsuario <> (select idUsuario from usuario where nick = '" + user + "')" +
        '"and esNegada = 'N'"

        Dim queryFam As String = "select * from vistaPatentes where idPatente = " +
        "(select idPatente from patente where nombre = '" + pat + "') " +
        "and esNegada = 'N'"



        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryFam, sqlCon)

        com.CommandText = queryFam
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        Dim dr As SqlDataReader
        dr = com.ExecuteReader


        Dim t As DataTable = New DataTable
        t.Load(dr)

        sqlCon.Close()
        Return t
    End Function


    Public Function FamiliaPatenteValidacion(fam As String, pat As String) As DataTable

        'Dim queryFam As String = "select * from vistaPatentes where idPatente = " +
        '"(select idPatente from patente where nombre = '" + pat + "') and " +
        '"idUsuario <> (select idUsuario from usuario where nick = '" + user + "')" +
        '"and esNegada = 'N'"

        Dim queryFam As String = "select * from VistaPatentes " +
                                "where idPatente = (select idPatente from patente where nombre = '" + pat + "')" +
                                " And idFamilia <> (select idFamilia from familia where nombre = '" + fam + "')"




        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryFam, sqlCon)

        com.CommandText = queryFam
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        Dim dr As SqlDataReader
        dr = com.ExecuteReader


        Dim t As DataTable = New DataTable
        t.Load(dr)

        sqlCon.Close()
        Return t
    End Function


    Public Function UsuarioPatenteValidacion(user As String) As DataTable

        Dim queryFam As String = "Select distinct(nombre) from vistaPatentes where " +
        "idUsuario <> (Select idUsuario from usuario where nick = '" + user + "')"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryFam, sqlCon)

        com.CommandText = queryFam
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        Dim dr As SqlDataReader
        dr = com.ExecuteReader


        Dim t As DataTable = New DataTable
        t.Load(dr)

        sqlCon.Close()
        Return t
    End Function



    Public Sub NegarPatente(user As String, pat As String)

        Dim queryInsert As String = "Insert  into UsuarioPatente ( IdUsuario, IdPatente, EsNegada, DVH) values " +
        "((select idUsuario from usuario where Nick='" + user + "') " +
        ",(select idPatente from patente where nombre = '" & pat & "')" +
        ",'Y', null)"


        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryInsert, sqlCon)

        com.CommandText = queryInsert
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub


    Public Sub desasignarPatente(user As String, pat As String)

        Dim queryInsert As String = "delete from usuarioPatente where idUsuario = " +
        "(select idUsuario from usuario where Nick='" + user + "') " +
        "and idPatente = (select idPatente from patente where nombre = '" & pat & "')"


        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryInsert, sqlCon)

        com.CommandText = queryInsert
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub



    Public Sub desasignarFamiliaUsuario(user As String, fam As String)

        Dim queryInsert As String = "delete from FamiliaPatente where " +
        "idFamilia= (select idFamilia from Familia where nombre = '" & fam & "')" +
        "and (select idUsuario from usuarios where nick='" + user + "') "



        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryInsert, sqlCon)

        com.CommandText = queryInsert
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()
        sqlCon.Close()

    End Sub

    Public Sub desasignarPatenteFamilia(fam As String, pat As String)

        Dim queryInsert As String = "delete from FamiliaPatente where idPatente = " +
        "(select idPatente from patente where nombre='" + pat + "') " +
        "and idFamilia= (select idFamilia from Familia where nombre = '" & fam & "')"


        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryInsert, sqlCon)

        com.CommandText = queryInsert
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub


    Public Function DesasignarPatenteFamiliaValidacion(fam As String, pat As String) As DataTable

        Dim queryFam As String = "select * from VistaPatentes where " +
        " idFamilia <> (select idFamilia from familia where nombre = '" + fam + "') AND " +
        "idPatente = (select idPatente from patente where nombre = '" + pat + "')"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryFam, sqlCon)

        com.CommandText = queryFam
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        Dim dr As SqlDataReader
        dr = com.ExecuteReader


        Dim t As DataTable = New DataTable
        t.Load(dr)

        sqlCon.Close()
        Return t
    End Function


    Public Sub ModificarDatosFamilia(nombreOriginal As String, nombreNuevo As String)

        Dim queryInsert As String = "update familia set " +
        "nombre = '" + nombreNuevo + "' " +
        "where nombre = '" + nombreOriginal + "'"


        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryInsert, sqlCon)

        com.CommandText = queryInsert
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub

    Public Function buscarRegistroBitacora(id As Integer) As DataTable
        Dim queryFam As String = "select * from Bitacora where idBitacora = " & id


        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryFam, sqlCon)

        com.CommandText = queryFam
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        Dim dr As SqlDataReader
        dr = com.ExecuteReader


        Dim t As DataTable = New DataTable
        t.Load(dr)

        sqlCon.Close()
        Return t
    End Function

    Public Sub ActualizarDVV(tabla As String)
        Dim queryInsert As String = "Update dvv set valor = (select isnull(sum(DVH),0) from " + tabla + ") where Tabla ='" + tabla + "'"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryInsert, sqlCon)

        com.CommandText = queryInsert
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub


    Public Function EjecutarStoreProcedure(ByRef query As String) As Boolean
        Try
            Dim da As New SqlDataAdapter
            Dim ds As New DataSet

            Dim sqlCon As New SqlConnection(My.Resources.con)
            sqlCon.Open()


            da = New SqlDataAdapter(query, sqlCon)
            da.Fill(ds)

            sqlCon.Close()


            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function validarDVV_Tabla(tabla As String) As DataTable
        Dim queryFam As String = "IF (SELECT ISNULL(SUM(dvh),0) FROM " & tabla & ") " +
        " = (Select valor FROM DVV WHERE TABLA =  '" & tabla & "')" +
        " Select 'OK' AS Estado ELSE SELECT 'ERROR EN LA TABLA " & tabla & "' AS Estado "


        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(queryFam, sqlCon)

        com.CommandText = queryFam
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        Dim dr As SqlDataReader
        dr = com.ExecuteReader

        Dim t As DataTable = New DataTable
        t.Load(dr)

        sqlCon.Close()
        Return t
    End Function

End Class
