Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Proveedor

    Public Sub EliminarTelefonos(id As Integer)

        Dim query As String = "delete from Telefono_Proveedor where idProveedor = " & id
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()
        sqlCon.Close()


    End Sub

    Public Sub EliminarDirecciones(id As Integer)

        Dim query As String = "delete from DireccionProveedores where idProveedor = " & id
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()
        sqlCon.Close()


    End Sub
    Public Function ObtenerProveedores() As DataSet
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = "select Nombre_Empresa, Nombre_Contacto , Apellido_Contacto,Mail, EsActivo from Proveedor"
        Dim queryTelefonos As String = "select IdProveedor, Telefono, EsActivo from Telefono_Proveedor"
        Dim queryDirecciones As String = "Select idProveedor, Direccion from DireccionProveedores"

        Dim Datos As New DataSet()

        Dim adapterProveedor As SqlDataAdapter = New SqlDataAdapter(query, sqlCon)
        Dim adapterTelefonos As SqlDataAdapter = New SqlDataAdapter(queryTelefonos, sqlCon)
        Dim adapterDirecciones As SqlDataAdapter = New SqlDataAdapter(queryDirecciones, sqlCon)

        adapterProveedor.Fill(Datos, "DatosProveedores")
        adapterTelefonos.Fill(Datos, "DatosTelefono")
        adapterDirecciones.Fill(Datos, "DatosDirecciones")

        sqlCon.Close()
        Return Datos
    End Function


    Public Function altaProveedor(nom_em As String, nom_con As String, ape_con As String, mail As String) As Integer
        Dim idProveedor As New Integer

        Dim query As String = "Insert into proveedor (nombre_empresa , nombre_contacto, apellido_contacto , mail, esActivo)Values('" & nom_em & "','" & nom_con & "','" & ape_con & "','" & mail & "','Y')"
        Dim query2 As String = "Select @@Identity"


        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon


        com.ExecuteNonQuery()

        com.CommandText = query2
        idProveedor = com.ExecuteScalar()


        sqlCon.Close()

        Return idProveedor
    End Function

    Public Sub agregarTelefono(id As Integer, telefono As String)

        Dim query As String = "Insert into Telefono_Proveedor (idProveedor , Telefono, esActivo)Values( " & id & ",'" & telefono & "','Y')"


        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon


        com.ExecuteNonQuery()
        sqlCon.Close()

    End Sub

    Public Sub agregarDirecciones(id As Integer, dir As String)
        Dim query As String = "Insert into DireccionProveedores (idProveedor , Direccion)Values( " & id & ",'" & dir & "')"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon


        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub

    Public Sub ModificarEstadoProveedor(proveedor As String, tipo As Char)
        Dim query As String = "Update Proveedor set esActivo ='" & tipo & "'" & "where nombre_empresa = '" & proveedor & "'"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon


        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub

    Public Function buscarProveedor(proveedor As String) As DataSet
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim queryProveedor As String = "Select IdProveedor,Nombre_Empresa, Nombre_Contacto , Apellido_Contacto , Mail , EsActivo from Proveedor where Nombre_Empresa = '" & proveedor & "'"


        Dim queryTelefono As String = "Select t1.Telefono, t1.esActivo from Telefono_Proveedor t1 " +
            "join Proveedor p1 on p1.IdProveedor = t1.IdProveedor " +
            "where p1.Nombre_Empresa= '" & proveedor & "'"

        Dim queryDirecciones As String = "Select d1.Direccion from DireccionProveedores d1 " +
        "join Proveedor p1 on p1.IdProveedor = d1.IdProveedor " +
        "where p1.Nombre_Empresa= '" & proveedor & "'"

        Dim Datos As New DataSet()

        Dim adapterProveedor As SqlDataAdapter = New SqlDataAdapter(queryProveedor, sqlCon)
        Dim adapterTelefonos As SqlDataAdapter = New SqlDataAdapter(queryTelefono, sqlCon)
        Dim adapterDirecciones As SqlDataAdapter = New SqlDataAdapter(queryDirecciones, sqlCon)

        adapterProveedor.Fill(Datos, "DatosProveedor")
        adapterTelefonos.Fill(Datos, "DatosTelefono")
        adapterDirecciones.Fill(Datos, "DatosDirecciones")

        sqlCon.Close()


        Return Datos
    End Function


    Public Function BuscarProveedorEncriptado(id As Integer) As DataSet
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim queryProv As String = " select IdProveedor,Nombre_Empresa, Nombre_Contacto , Apellido_Contacto , Mail , EsActivo from Proveedor where idProveedor = " & id
        Dim queryTelefono As String = "Select IdProveedor , Telefono , EsActivo from telefono_proveedor where idProveedor =" & id
        Dim queryDir As String = "Select IdProveedor , Direccion from direccionProveedores where idProveedor =" & id
        Dim Datos As New DataSet()

        Dim adapterProv As SqlDataAdapter = New SqlDataAdapter(queryProv, sqlCon)
        Dim adapterTelefonos As SqlDataAdapter = New SqlDataAdapter(queryTelefono, sqlCon)
        Dim adapterDirecciones As SqlDataAdapter = New SqlDataAdapter(queryDir, sqlCon)

        adapterProv.Fill(Datos, "DatosProveedor")
        adapterTelefonos.Fill(Datos, "DatosTelefono")
        adapterDirecciones.Fill(Datos, "DatosDireccion")


        sqlCon.Close()
        Return Datos

    End Function








    Public Sub ModificarProveedor(idProv As Integer, nombre_empresa As String, nombre_contacto As String, apellido_contacto As String, email As String)
        Dim query As String = "Update Proveedor set Nombre_Empresa ='" & nombre_empresa & "', " +
        "nombre_contacto = '" & nombre_contacto & "', " +
        "apellido_contacto= '" & apellido_contacto & "', " +
        "Mail= '" & email & "', " +
        "Where idUsuario =" & idProv


        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon


        com.ExecuteNonQuery()
        sqlCon.Close()

    End Sub

    Public Sub BorrarTelefonosProveedor(idProv As Integer)
        Dim query As String = "Delete from Telefono_Proveedor where idProveedor =" & idProv

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon


        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub

    Public Sub BorrarDireccionProveedor(idProv As Integer)
        Dim query As String = "Delete from DireccionProveedores where idProveedor =" & idProv

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon


        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub
End Class
