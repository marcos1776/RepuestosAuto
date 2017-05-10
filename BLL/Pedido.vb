Imports System.ComponentModel
Imports Microsoft.Office.Interop
Imports System.Drawing

Public Class Pedido

    Public Sub New()
    End Sub

    Public Function VerificarStockProveedor(prov As String, art As String, cant As Integer) As Boolean
        Dim ped As New DAL.Pedido()
        Dim stockProvedor As Integer = ped.VerificarStockProveedor(prov, art)

        If stockProvedor < cant Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub GenerarExcel(prov As String, carrito As DataTable)
        Dim ExcelFilePath As String
        Dim ExcelFileDestino As String
        Dim fecha As New DateTime
        fecha = DateTime.Now

        ExcelFileDestino = "C:\Users\LampaPc\Desktop\Campo\PedidosProveedores\" + prov + fecha.ToString("dd.MM.yyyy hh.mm") + ".xlsx"
        'ExcelFilePath = "C:\Users\marcos.lampacrescia\Desktop\Diploma\Campo\Campo\PedidosProveedores\excelMarcos.xlsx"

        'My.Computer.FileSystem.CopyFile(ExcelFilePath, ExcelFileDestino, True)

        Dim excelApp As New Excel.Application
        excelApp.Workbooks.Add()

        Dim excelworksheet As New Excel.Worksheet
        excelworksheet = excelApp.ActiveSheet

        Dim i As Integer
        Dim j As Integer

        ' -------------- Estilos
        Dim style As Excel.Style = excelworksheet.Application.ActiveWorkbook.Styles.Add("NewStyle")
        style.Font.Bold = True
        'style.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Green)


        ' -------------- Titulo
        excelworksheet.Range("A1:E2").Merge()
        excelworksheet.Cells(1, 1) = "Solicitud de Articulos a Proveedor"
        'excelworksheet.Cells(1, 1).style = "NewStyle"
        excelworksheet.Range("A1:E2").VerticalAlignment = Excel.Constants.xlCenter
        excelworksheet.Range("A1:E2").HorizontalAlignment = Excel.Constants.xlCenter


        excelworksheet.Range("A1").EntireColumn.ColumnWidth = 14
        excelworksheet.Range("B1").EntireColumn.ColumnWidth = 28
        excelworksheet.Range("C1").EntireColumn.ColumnWidth = 12
        excelworksheet.Range("D1").EntireColumn.ColumnWidth = 12
        excelworksheet.Range("E1").EntireColumn.ColumnWidth = 12

        ' -------------- Agrego el Proveedor
        excelworksheet.Range("A3:B3").Merge()
        excelworksheet.Range("A3").Value = prov

        '-------------- Agrego la fecha
        excelworksheet.Range("C3:E3").Merge()
        excelworksheet.Range("C3").Value = fecha
        excelworksheet.Range("C3").HorizontalAlignment = Excel.Constants.xlRight


        '--------------
        'Agrego las columnas
        For i = 0 To carrito.Columns.Count - 1
            excelworksheet.Cells(4, (i + 1)) = carrito.Columns(i).ColumnName
        Next

        'Agrego las rows

        For i = 0 To carrito.Rows.Count - 1

            For j = 0 To carrito.Columns.Count - 1
                excelworksheet.Cells((i + 5), (j + 1)) = carrito.Rows(i)(j)
            Next

        Next

        'Genero el excel
        If (ExcelFileDestino IsNot Nothing And ExcelFileDestino IsNot "") Then
            Try
                excelworksheet.SaveAs(ExcelFileDestino)
                excelApp.Quit()
                Windows.Forms.MessageBox.Show("Archivo generado con exito!")
            Catch ex As Exception
                Throw New Exception("Archivo no generado, verificar la ruta \n" + ex.Message)
            End Try
        Else
            excelApp.Visible = True
        End If


    End Sub

    Public Function VerificarStockMaximo(art As String, cant As Integer) As Boolean
        Dim ped As New DAL.Pedido()
        Dim articulo As New DAL.Articulo()

        'Me traigo el maximo permitido ' Validarlo
        Dim artDs As New DataSet()
        artDs = articulo.BuscarArticulo(art)

        Dim maxPermitido = Convert.ToInt32(artDs.Tables("DatosArticulo").Rows(0).Item("StockMaximo"))
        'Me traigo el stock actual
        Dim stockActual As Integer = ped.obtenerStockActual(art)

        If (stockActual + cant) <= maxPermitido Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function obtenerPedidos() As DataTable
        Dim dt As New DataTable
        Dim seg As New BLL.Seguridad("Password")

        Dim ped As New DAL.Pedido()
        dt = ped.obtenerPedidos()

        ''
        For Each row As DataRow In dt.Rows
            row.Item(1) = seg.Desencriptar(row.Item(1).ToString)
            row.Item(2) = seg.Desencriptar(row.Item(2).ToString)
        Next


        ''

        Return dt
    End Function

    Public Function nuevoPedido(carrito As DataTable, total As Double, proveedor As String, idUsuario As Integer) As Integer
        Dim pedido As New DAL.Pedido
        Dim idPedido As Integer = pedido.nuevoPedido(total, proveedor, idUsuario)

        For Each row As DataRow In carrito.Rows
            pedido.AgregarArticulosAPedido(row, idPedido)
        Next

        'Agrego al detalle Pedido
        Return idPedido

    End Function

    'Buscar Pedido
    Public Function BuscarPedido(prov As String, idPedido As String) As DataSet
        Dim pedido As New DAL.Pedido

        Return pedido.BuscarPedido(prov, idPedido)
    End Function

    'Confirmar Pedido
    Public Sub ConfirmarPedido(pedido As Integer)
        Dim ped As New DAL.Pedido
        ped.ConfirmarPedido(pedido)
    End Sub

    Public Function obtenerDatosPedidos(idPedido) As DataSet
        Dim pedido As New DAL.Pedido
        Return pedido.obtenerDatosPedido(idPedido)
    End Function

    Public Sub eliminarPedido(idPedido As Integer)
        Dim pedido As New DAL.Pedido
        pedido.eliminarPedido(idPedido)
    End Sub
End Class

