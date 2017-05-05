Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text


Public Class Articulo
    Public Sub CargarArticuloProveedor(prov As String, id As String, desc As String, sto As Integer, marc As String, mode As String, añ As Integer, pr As Double)
        'Faltaria agregar la query que borre los articulos anteriores correspondientes al proveedor
        Dim idArticulo As Integer

        Dim query As String = "Declare @idArticulo as varchar " +
        "declare @prov as integer " +
        "SELECT @idArticulo = idArticulo FROM Articulo a join proveedor p on a.IdProveedor = p.IdProveedor WHERE idArticulo = '" & id & "' and p.Nombre_Empresa ='" & prov & "'" +
        " IF @idArticulo IS NULL " +
        "BEGIN " +
            "INSERT INTO Articulo ([IdArticulo],[IdProveedor],[StockProveedor],[Descripcion],[StockMinimo],[StockMaximo],[Margen_Ganancia],[EsActivo],[Precio],[DVH]) Select '" + id + "',(Select idProveedor from proveedor where nombre_empresa = '" + prov + "')," + sto.ToString + ",'" + desc + "',0 , 0 , 0 , 'Y'," + pr.ToString + " ,0 " +
        "END " +
        "ELSE " +
        "BEGIN " +
            "Update articulo set precio =" & pr & ",stockProveedor =" & sto & " where idArticulo ='" & id & "' and idProveedor = (select idProveedor from proveedor where Nombre_Empresa ='" & prov & "') " +
        "END"



        'Agrega articulos a la tabla articulos
        'Dim query As String = ("INSERT INTO Articulo ([IdArticulo],[IdProveedor],[StockProveedor],[IdAuto],[Descripcion],[StockMinimo],[StockMaximo],[Margen_Ganancia],[EsActivo],[Precio],[DVH]) Select '" + id + "',(Select idProveedor from proveedor where nombre_empresa = '" + prov + "')," + sto.ToString + ",(Select idAuto from auto where Marca = '" + marc + "' and modelo = '" + mode + "' and año =" + añ.ToString + ") ,'" + desc + "',0 , 0 , 0 , 'Y'," + pr.ToString + " ,0")

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon


        com.ExecuteNonQuery()


        ' -------------------- Inserto los autos -----------------------

        Dim query2 As String = "Declare @IdAuto as Integer " +
            "select @IdAuto = idAuto  from auto where Marca = '" & marc & "' and modelo = '" & mode & "' and año ='" & añ.ToString & "' " +
                    "IF @IdAuto IS NULL " +
            "BEGIN " +
            "Insert into auto (Marca, Modelo , año) select '" & marc & "','" & mode & "'," & añ & " " +
            "END"


        Dim com2 As New SqlCommand(query2, sqlCon)

        com2.CommandText = query2
        com2.CommandType = CommandType.Text
        com2.Connection = sqlCon

        com2.ExecuteNonQuery()

        ' -------------- Inserto la relacion Auto - Repuesto ----------------


        Dim query3 As String = "Declare @IdAuto as Integer " +
        "select @IdAuto = idAuto from AutoArticulo where idAuto = (select idAuto from auto where Marca = '" & marc & "' and modelo = '" & mode & "' and año ='" & añ.ToString & "') " +
        "and idArticulo = '" & id.ToString & "'" +
        "IF @IdAuto IS NULL " +
            "BEGIN " +
        "Insert into autoArticulo (IdArticulo, IdAuto ) values ( '" & id.ToString & "' , (select idAuto from auto where Marca = '" & marc & "' and modelo = '" & mode & "' and año ='" & añ.ToString & "')) " +
        "END"




        Dim com3 As New SqlCommand(query3, sqlCon)

        com3.CommandText = query3
        com3.CommandType = CommandType.Text
        com3.Connection = sqlCon

        com3.ExecuteNonQuery()


        ' -----------------------------------------------------------
        sqlCon.Close()

    End Sub

    Public Function obtenerListadoArticulos() As DataSet
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim articulosProveedores As String = "select p.Nombre_Empresa ,a1.idArticulo, Descripcion, Precio from Articulo a1 " +
        "join proveedor p on a1.Idproveedor = p.IdProveedor "
        '     Dim articulosComprados As String = "select d1.idArticulo, a1.Descripcion, a1.stockMinimo, a1.StockMaximo,1 " +
        '     "." +
        '"( " +
        '         "select sum(cantidad*-1) from Detalle_Venta  UNION ALL " +
        '         "select sum(cantidad) from detalle_Pedido UNION ALL " +
        '         "select sum(cantidad) from Correccion_Stock " +
        '     ")" +
        '     "AGREGAR LA CANTIDAD DE STOCK CORREGIDO PARA LA SUMA Y PARA SALIDA" +
        '     "." +
        '     "(100 + a1.Margen_Ganancia)*AVG(a1.Precio) / 100  as Precio from Detalle_Pedido d1 " +
        '     "join articulo a1 on d1.IdArticulo = a1.IdArticulo " +
        '     "group by d1.IdArticulo , a1.stockMinimo, a1.stockMaximo, a1.Descripcion, a1.Margen_Ganancia "


        Dim articulosComprados As String = "select d1.idArticulo, a1.Descripcion, a1.stockMinimo, a1.StockMaximo, " +
        "(100 + a1.Margen_Ganancia)*AVG(a1.Precio) / 100  as Precio from Detalle_Pedido d1 " +
        "join articulo a1 on d1.IdArticulo = a1.IdArticulo " +
        "group by d1.IdArticulo , a1.stockMinimo, a1.stockMaximo, a1.Descripcion, a1.Margen_Ganancia "

        Dim autosArticulos As String = "Select aa.idArticulo, au.Marca , au.Modelo , au.año from auto au " +
        "join autoarticulo aa On aa.IdAuto = au.IdAuto " +
        "join articulo art On art.IdArticulo = aa.IdArticulo"

        Dim Datos As New DataSet()

        Dim adapterArticulosProveedores As SqlDataAdapter = New SqlDataAdapter(articulosProveedores, sqlCon)
        Dim adapterArticulosComprados As SqlDataAdapter = New SqlDataAdapter(articulosComprados, sqlCon)
        Dim adapterAutosArticulos As SqlDataAdapter = New SqlDataAdapter(autosArticulos, sqlCon)

        adapterArticulosProveedores.Fill(Datos, "ArticulosProveedores")
        adapterArticulosComprados.Fill(Datos, "ArticulosComprados")
        adapterAutosArticulos.Fill(Datos, "AutosArticulos")

        sqlCon.Close()
        Return Datos
    End Function

    Public Function obtenerListadoArticulosProveedores(s As String) As DataTable
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = "Select IdArticulo, Descripcion , StockProveedor, (100 + Margen_Ganancia)* Precio / 100  as Precio  from Articulo a1 join Proveedor p1 On p1.IdProveedor = a1.IdProveedor where p1.Nombre_Empresa ='" + s + "'"
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

    Public Function mapearArticulosAobjeto(prov As String, nombreArt As String, cant As Integer) As DataTable
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = "select a1.IdArticulo, a1.Descripcion, '" + cant.ToString + "' as Cantidad, a1.Precio , (a1.precio * " + cant.ToString + ") as Subtotal " +
        "from articulo a1 " +
        "join proveedor p1 on a1.IdProveedor = p1.IdProveedor " +
        "where p1.Nombre_Empresa ='" + prov + "' " +
        "and a1.descripcion = '" + nombreArt + "' "


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

    Public Function obtenerListadoArticulosAdquiridos() As DataTable
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = "select distinct(a1.idArticulo), Descripcion, IdAuto , StockMInimo, StockMaximo , EsActivo, Precio from Articulo a1 "

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

    Public Function BuscarArticulo(IdArticulo As String) As DataSet
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim queryArticulo As String = "Select idArticulo, Descripcion, StockMinimo,StockMaximo, Margen_Ganancia from Articulo where idArticulo = '" & IdArticulo & "'"

        Dim queryAutos As String = "select au.* from autoarticulo a " +
        "join articulo art on art.IdArticulo = a.IdArticulo " +
        "join auto au on au.idAuto = a.IdAuto " +
        "where art.IdArticulo = '" & IdArticulo & "'"

        Dim queryTodos As String = "select IdArticulo,IdProveedor,StockProveedor,Descripcion,StockMinimo,StockMaximo,Margen_Ganancia,EsActivo,Precio from articulo where idArticulo = '" & IdArticulo & "'"

        Dim queryListadoAutos As String = "Select Marca, Modelo ,Año from Auto"

        Dim Datos As New DataSet()

        Dim adapterArticulos As SqlDataAdapter = New SqlDataAdapter(queryArticulo, sqlCon)
        Dim adapterAutos As SqlDataAdapter = New SqlDataAdapter(queryAutos, sqlCon)
        Dim adapterListadoAutos As SqlDataAdapter = New SqlDataAdapter(queryListadoAutos, sqlCon)
        Dim adapterTablaCompleta As SqlDataAdapter = New SqlDataAdapter(queryTodos, sqlCon)

        adapterArticulos.Fill(Datos, "DatosArticulo")
        adapterAutos.Fill(Datos, "DatosAutos")
        adapterListadoAutos.Fill(Datos, "ListadoAutos")
        adapterTablaCompleta.Fill(Datos, "TablaCompleta")

        sqlCon.Close()

        Return Datos
    End Function

    Public Sub EliminarArticuloProveedor(prov As String)
        Dim query As String = ("Delete from articulo where idProveedor = (Select idProveedor from proveedor where Nombre_Empresa = '" & prov & "')")

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon


        com.ExecuteNonQuery()
        sqlCon.Close()
    End Sub

    Public Sub ActualizarArticulo(articuloNombre As String, stockMin As Integer, stockMax As Integer, margenGan As Integer)
        Dim query As String = "update articulo set stockMinimo = " & stockMin & ", stockMaximo = " & stockMax & ", Margen_Ganancia = " & margenGan & " where idArticulo ='" & articuloNombre & "'"

        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon


        com.ExecuteNonQuery()
        sqlCon.Close()

    End Sub


    Public Sub CorregirStock(idArt As String, cant As Integer, cond As String)
        Dim sqlCon As New SqlConnection(My.Resources.con)
        sqlCon.Open()

        Dim query As String = ""
        Dim com As New SqlCommand(query, sqlCon)

        com.CommandText = query
        com.CommandType = CommandType.Text
        com.Connection = sqlCon

        com.ExecuteNonQuery()

        ' -----------------------------------------------------------
        sqlCon.Close()

    End Sub
End Class
