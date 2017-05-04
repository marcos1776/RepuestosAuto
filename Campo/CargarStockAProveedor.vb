Imports Excel = Microsoft.Office.Interop.Excel

Public Class CargarStockAProveedor

    Dim listaArticulos As New List(Of BLL.Articulo)

    Dim app As New Excel.Application
    Dim worksheet As Excel.Worksheet
    Dim workbook As Excel.Workbook
    Dim nombreProveedor As String

    Dim fd As OpenFileDialog = New OpenFileDialog()


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    ' Seleccion de archivo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim strFileName As String

        fd.Title = "Seleccione el archivo del Provedor..."

        'fd.InitialDirectory = "C:\Users\marcos.lampacrescia\Desktop\Marcos\Marce"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            TextBox1.Text = strFileName
        End If
    End Sub

    'Carga archivo y inserta en la base de datos
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If (cargarArticuloProveedor()) Then
            MsgBox("Articulos cargados correctamente")
            Me.Close()
        End If
      
    End Sub


    Private Function cargarArticuloProveedor() As Boolean
        workbook = app.Workbooks.Open(TextBox1.Text)
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


        'Llamo al metodo que inserte en la base de datos
        'Primero deberia eliminar todo lo referido al proveedor , y insertar esta nueva lista.
        Dim arti As New BLL.Articulo
        Dim seguridad As New BLL.Seguridad("Password")
        arti.EliminarArticuloProveedor(seguridad.Encriptar(proveedor))

        For Each articulo As BLL.Articulo In listaArticulos
            articulo.CargarArticuloProveedor(seguridad.Encriptar(proveedor), articulo)
        Next

        '''''''''''''''''''''''''''''''''''''''''''''''
        workbook.Save()
        workbook.Close()
        app.Quit()

        Return True
    End Function


    'Cuando cambio el combobox
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        fd.InitialDirectory = My.Resources.PathArticulosProveedores + "" + ComboBox1.Text
    End Sub

    'Que se llene el listbox
    Private Sub CargarStockAProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim prov As New BLL.Listas
        Dim dt As New DataTable

        'dt = prov.obtenerProveedores

        For Each proveedor As DataRow In dt.Rows
            ComboBox1.Items.Add(proveedor(0).ToString)
        Next

    End Sub
End Class