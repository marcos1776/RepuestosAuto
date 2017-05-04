Imports Excel = Microsoft.Office.Interop.Excel

Public Class Proveedor
    Private _idProveedor As Integer
    Private _nombre_empresa As String
    Private _nombre_contacto As String
    Private _apellido_contacto As String
    Private _email As String


    Public Property idProveedor() As Integer
        Get
            Return _idProveedor
        End Get
        Set(ByVal value As Integer)
            _idProveedor = value
        End Set
    End Property


    Public Property nombre_empresa() As String
        Get
            Return _nombre_empresa
        End Get
        Set(ByVal value As String)
            _nombre_empresa = value
        End Set
    End Property

    Public Property nombre_contacto() As String
        Get
            Return _nombre_contacto
        End Get
        Set(ByVal value As String)
            _nombre_contacto = value
        End Set
    End Property

    Public Property apellido_contacto() As String
        Get
            Return _apellido_contacto
        End Get
        Set(ByVal value As String)
            _apellido_contacto = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Public Sub New(ne As String, nc As String, ac As String, em As String)
        Me.nombre_empresa = ne
        Me.nombre_contacto = nc
        Me.apellido_contacto = ac
        Me.email = em
    End Sub

    Public Sub New()

    End Sub


    Public Sub EliminarTelefonos(id As Integer)
        Dim adm As New DAL.Proveedor()
        adm.EliminarTelefonos(id)
    End Sub

    Public Sub EliminarDirecciones(id As Integer)
        Dim adm As New DAL.Proveedor()
        adm.EliminarDirecciones(id)
    End Sub

    Sub AgregarTelefono(listaTelefonos As List(Of String), Id As Integer)
        Dim usuario As New DAL.Proveedor()
        Dim seguridad As New Seguridad("Password")

        If listaTelefonos.Count > 0 Then
            For Each tel As String In listaTelefonos
                usuario.agregarTelefono(Id, tel.ToString)
            Next
        End If
    End Sub


    'Doy de alta un proveedor
    Public Function altaProveedor(p As Proveedor) As Integer
        Dim idProveedor As New Integer
        Dim proveedor As New DAL.Proveedor
        idProveedor = proveedor.altaProveedor(p.nombre_empresa, p.nombre_empresa, p.apellido_contacto, p.email)

        Return idProveedor
    End Function

    'Agregar Telefono con ID de usuario, esto lo hago cuando modifico
    Sub AgregarTelefono(idProveedor As Integer, listaTelefonos As List(Of String))
        Dim prov As New DAL.Proveedor()

        For Each tel As String In listaTelefonos
            prov.agregarTelefono(idProveedor, tel.ToString)
        Next

    End Sub

    'Agrego direcciones
    Sub agregarDirecciones(idProveedor As Integer, listaDirecciones As List(Of String))
        Dim prov As New DAL.Proveedor()

        For Each dir As String In listaDirecciones
            prov.agregarDirecciones(idProveedor, dir.ToString)
        Next

    End Sub

    'Modificar Estado Proovedor
    Public Sub ModificarEstadoProveedor(Proveedor As String, c As Char)
        Dim prov As New DAL.Proveedor()
        prov.ModificarEstadoProveedor(Proveedor, c)
    End Sub

    'Busco un proveedor
    Public Function buscarProveedor(pr As String) As DataSet
        Dim prov As New DAL.Proveedor()
        Dim ds As New DataSet
        Dim seguridad As New BLL.Seguridad("Password")

        ds = prov.buscarProveedor(pr)

        For Each row As DataRow In ds.Tables("DatosProveedor").Rows
            row.Item(1) = seguridad.Desencriptar(row.Item(1).ToString)
            row.Item(2) = seguridad.Desencriptar(row.Item(2).ToString)
            row.Item(3) = seguridad.Desencriptar(row.Item(3).ToString)
            row.Item(4) = seguridad.Desencriptar(row.Item(4).ToString)
        Next

        For Each row As DataRow In ds.Tables("DatosTelefono").Rows
            row.Item(0) = seguridad.Desencriptar(row.Item(0).ToString)
        Next


        For Each row As DataRow In ds.Tables("DatosDirecciones").Rows
            row.Item(0) = seguridad.Desencriptar(row.Item(0).ToString)
        Next

        Return ds
    End Function



    Public Function BuscarProveedorEncriptado(id As Integer) As DataSet
        Dim pr As New DAL.Proveedor()
        Return pr.BuscarProveedorEncriptado(id)
    End Function










    'Modifico un Proveedor
    Public Sub ModificarProveedor(prov As BLL.Proveedor, idProv As Integer)
        Dim pr As New DAL.Proveedor()
        pr.ModificarProveedor(idProv, prov.nombre_empresa, prov.nombre_contacto, prov.apellido_contacto, prov.email)
        pr.BorrarTelefonosProveedor(idProv)
        pr.BorrarDireccionProveedor(idProv)
    End Sub


    Public Function cargarArticuloProveedor(path As String)
        Dim listaArticulos As New List(Of BLL.Articulo)
        Dim app As New Excel.Application
        Dim worksheet As Excel.Worksheet
        Dim workbook As Excel.Workbook

        workbook = app.Workbooks.Open(path)
        worksheet = workbook.Worksheets("Sheet1")

        Dim proveedor As String = worksheet.Cells(1, 2).Value

        ''''''''''''''''''''''''''''''''''''''''''''''''
        Dim i As Integer = 2
        'Dim cell As String



        While worksheet.Range("A1").Offset(i, 0).Value <> "" 'stop when there is a blank cell
            i += 1

            Dim cellIdArticulo As String = String.Concat("A", i)
            Dim DimcellDescripcion As String = String.Concat("B", i)
            Dim cellStock As String = String.Concat("C", i)
            Dim cellMarcaAuto As String = String.Concat("D", i)
            Dim cellModelo As String = String.Concat("E", i)
            Dim cellAño As String = String.Concat("F", i)
            Dim cellPrecio As String = String.Concat("G", i)

            Dim art As New BLL.Articulo()

            art._idArticulo = worksheet.Range(cellIdArticulo).Value
            art._Descripcion = worksheet.Range(DimcellDescripcion).Value
            art._Stock = worksheet.Range(cellStock).Value
            art._MarcaAuto = worksheet.Range(cellMarcaAuto).Value
            art._ModeloAuto = worksheet.Range(cellModelo).Value
            art._Año = worksheet.Range(cellAño).Value
            art._Precio = worksheet.Range(cellPrecio).Value

            listaArticulos.Add(art)
        End While

        'Antes de insertar verificar si esta .


        'Si no esta inserta


        'Si esta update de los campos










        'Llamo al metodo que inserte en la base de datos
        'Primero deberia eliminar todo lo referido al proveedor , y insertar esta nueva lista.
        Dim arti As New BLL.Articulo
        Dim seguridad As New BLL.Seguridad("Password")
        'arti.EliminarArticuloProveedor(seguridad.Encriptar(proveedor))

        Dim prove As New BLL.Proveedor()
        Dim datasetProveedor As DataSet
        datasetProveedor = Me.buscarProveedor(seguridad.Encriptar(proveedor))

        Dim idProveedor As Integer
        idProveedor = datasetProveedor.Tables("DatosProveedor").Rows(0).Item(0).ToString

        Dim dvh As Integer
        For Each articulo As BLL.Articulo In listaArticulos

            '' Actualizo DVH
            Dim CadenaDVH As String = Trim(articulo._idArticulo) & Trim(idProveedor) & Trim(articulo._Stock) & Trim(articulo._Descripcion) & "000Y" & Trim(articulo._Precio)
            articulo.CargarArticuloProveedor(seguridad.Encriptar(proveedor), articulo)

            dvh = seguridad.calcularDVH(CadenaDVH)
            seguridad.ModificarDVH(articulo._idArticulo, dvh, "articulo", "idArticulo")

            ''Actualizo DVV
            seguridad.ActualizarDVV("Articulo")
        Next

        '''''''''''''''''''''''''''''''''''''''''''''''
        workbook.Save()
        workbook.Close()
        app.Quit()

        Return 0
    End Function

End Class
