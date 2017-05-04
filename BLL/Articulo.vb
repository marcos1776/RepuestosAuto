Public Class Articulo

    Public _idArticulo As String
    Public _Descripcion As String
    Public _Stock As Integer
    Public _MarcaAuto As String
    Public _ModeloAuto As String
    Public _Año As Integer
    Public _Precio As Double


    Public Sub New(id As String, desc As String, sto As Integer, marc As String, mode As String, añ As Integer, pr As Double)
        Me._idArticulo = id
        Me._Descripcion = desc
        Me._Stock = sto
        Me._MarcaAuto = marc
        Me._ModeloAuto = mode
        Me._Año = añ
        Me._Precio = pr
    End Sub


    Public Sub New(id As String, desc As String, sto As Integer)
        Me._idArticulo = id
        Me._Descripcion = desc
        Me._Stock = sto
    End Sub

    Public Sub New()
    End Sub

    Public Sub CargarArticuloProveedor(p As String, a As Articulo)
        Dim artic As New DAL.Articulo()
        artic.CargarArticuloProveedor(p, a._idArticulo, a._Descripcion, a._Stock, a._MarcaAuto, a._ModeloAuto, a._Año, a._Precio)
    End Sub

    Public Sub EliminarArticuloProveedor(prov As String)
        Dim art As New DAL.Articulo
        art.EliminarArticuloProveedor(prov)
    End Sub

    Public Function mapearArticulosAobjeto(prov As String, nombreArt As String, cant As Integer) As DataTable
        Dim articulo As New Articulo()
        Dim art As New DAL.Articulo()

        Dim dt As DataTable
        dt = art.mapearArticulosAobjeto(prov, nombreArt, cant)

        Return dt
    End Function


    Public Function buscarArticulo(articulo As String) As DataSet
        Dim art As New DAL.Articulo()
        Return art.BuscarArticulo(articulo)
    End Function


    Public Sub ActualizarArticulo(articuloNombre As String, stockMin As String, stockMax As String, margenGan As String)
        Dim art As New DAL.Articulo()
        art.ActualizarArticulo(articuloNombre, stockMin, stockMax, margenGan)
    End Sub


    Public Sub CorregirStock(idArt As String, cantidad As Integer, condicion As String)
        Dim art As New DAL.Articulo()
        art.CorregirStock(idArt, cantidad, condicion)
    End Sub



End Class
