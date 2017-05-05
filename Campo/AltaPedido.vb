Imports System.ComponentModel
Imports Microsoft.Office.Interop

Public Class AltaPedido

    Dim listadoProveedores As List(Of BLL.Proveedor)
    Dim dt As New DataTable
    Dim articulos As DataTable
    Private Property ArticulosDeProveedores As DataTable
    Dim Carrito As New DataTable



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles lblCancel.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub

    'Cargo los grids
    Private Sub AltaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Login.ID_IDIOMA = 1) Then
            Me.Text = "Nuevo Pedido"
        Else
            Me.Text = "New Order"
        End If

        DataGridView2.DataSource = Nothing


        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        cargarDataGrid()


        Dim seguridad As New BLL.Seguridad("Password")
        Dim dtMensajes As New DataTable()
        dtMensajes = seguridad.ObtenerMensajes(Login.ID_IDIOMA, 8)


        lblProved.Text = dtMensajes.Rows(0).Item(5).ToString
        lblBusc.Text = dtMensajes.Rows(1).Item(5).ToString
        lblCant.Text = dtMensajes.Rows(2).Item(5).ToString
        lblCarro.Text = dtMensajes.Rows(3).Item(5).ToString
        lblTotal.Text = dtMensajes.Rows(4).Item(5).ToString
        lblEnviar.Text = dtMensajes.Rows(5).Item(5).ToString
        lblCancel.Text = dtMensajes.Rows(6).Item(5).ToString





        Carrito.Columns.Add("idArticulo", GetType(String))
        Carrito.Columns.Add("Descripcion", GetType(String))
        Carrito.Columns.Add("Cantidad", GetType(Integer))
        Carrito.Columns.Add("Precio", GetType(Double))
        Carrito.Columns.Add("Subtotal", GetType(Double))
    End Sub

    'Cargo los proveedores
    Public Sub cargarDataGrid()
        ComboBox1.Items.Clear()

        Dim ds As New DataSet
        Dim listadoProveedores As New BLL.Listas
        ds = listadoProveedores.obtenerProveedores()

        Dim habilitados As DataTable = ds.Tables("DatosProveedores").Select().CopyToDataTable

        If ds.Tables("DatosProveedores").Select("esActivo = 'Y'").Count > 0 Then
            For Each h As DataRow In habilitados.Rows
                ComboBox1.Items.Add(h.Item("Nombre_Empresa"))
            Next
        End If


    End Sub

    'Que se carguen los articulos cuando cambie el proveedor.
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()

        Dim Proveedor As String = ComboBox1.Text
        Dim Seguridad As New BLL.Seguridad("Password")

        'Obtener articulos de proveedor
        Dim p As New BLL.Listas

        ArticulosDeProveedores = p.obtenerListadoArticulosProveedores(Seguridad.Encriptar(Proveedor))


        Dim btn As New DataGridViewButtonColumn
        btn.HeaderText = "Click Data"
        btn.Text = "Añadir"
        btn.Name = "btn"
        btn.UseColumnTextForButtonValue = True



        If ArticulosDeProveedores.Rows.Count > 0 Then
            For Each row As DataRow In ArticulosDeProveedores.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3), btn.Text)
            Next
            'DataGridView1.DataSource = dt3
        End If
    End Sub

    'Alta Pedido - Genero excel y lo envio
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles lblEnviar.Click

        If validarConsistencia() Then

            Dim Proveedor As String = ComboBox1.Text
            Dim idPedido As Integer
            Dim datosPedido As DataSet
            'Inserto en la tabla Pedido y detalles Pedido
            Dim pedido As New BLL.Pedido
            Dim seguridad As New BLL.Seguridad("Password")


            Dim resul As Double = DataGridView2.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDouble(x.Cells("SubTotal").Value))
            'Dim rowtotal As DataGridViewRow = DataGridView2.Rows(DataGridView1.Rows.Count - 1)
            Dim i As Integer = 0

            For i = 0 To DataGridView2.Rows.Count - 1 Step 1

                Dim row As DataRow
                row = Carrito.NewRow
                row(0) = DataGridView2.Item(0, i).Value
                row(1) = DataGridView2.Item(1, i).Value
                row(2) = DataGridView2.Item(2, i).Value
                row(3) = DataGridView2.Item(3, i).Value
                row(4) = DataGridView2.Item(4, i).Value

                Carrito.Rows.Add(row)
            Next

            'Que me traiga el Id del pedido
            idPedido = pedido.nuevoPedido(Carrito, resul.ToString, seguridad.Encriptar(Proveedor), Login.ID_USUARIO)


            ''''''''''''''''''''''''' DVH  TABLA PEDIDO ''''''''''''''''''''''''
            datosPedido = pedido.obtenerDatosPedidos(idPedido)
            Dim dvh As Integer
            Dim str As String


            str = datosPedido.Tables("cabeceraPedido").Rows(0).Item("IdPedido") & "" &
                datosPedido.Tables("cabeceraPedido").Rows(0).Item("IdProveedor") & "" &
                datosPedido.Tables("cabeceraPedido").Rows(0).Item("IdUsuario") & "" &
                datosPedido.Tables("cabeceraPedido").Rows(0).Item("Fecha") & "" &
                datosPedido.Tables("cabeceraPedido").Rows(0).Item("Total") & "" &
                datosPedido.Tables("cabeceraPedido").Rows(0).Item("Estado") & ""

            dvh = seguridad.calcularDVH(str)
            seguridad.ModificarDVH(idPedido, dvh, "Pedido", "idPedido")

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '' Calculo DVV
            seguridad.ActualizarDVV("Pedido")

            ''''''''''''''''''''''''' DVH  TABLA DETALLE_PEDIDO '''''''''''''''''''''''


            For Each ped As DataRow In datosPedido.Tables("detallePedido").Rows
                str = idPedido & "" & ped.Item("idArticulo") & "" & ped.Item("MontoArticulo") & "" & ped.Item("Cantidad")
                dvh = seguridad.calcularDVH(str)

                seguridad.ModificarDVH2(ped.Item("idArticulo"), idPedido, dvh, "detalle_pedido", "idArticulo", "idPedido")

                '' Calculo DVV
                seguridad.ActualizarDVV("Detalle_Pedido")
            Next



            'seguridad.registrarBitacora(Login.ID_USUARIO, "BAJA", DateTime.Now, "Nuevo pedido", 0)


            'Genero el Excel
            GenerarExcel(Proveedor)
            'Envio de mail.

            If (Login.ID_IDIOMA = 1) Then
                MessageBox.Show("Pedido Realizado Correctamente")
            Else
                MessageBox.Show("File created succesfully.")
            End If


            Me.Close()


            '''''''''''''''''''''''
        Else
            If (Login.ID_IDIOMA = 1) Then
                MessageBox.Show("Por favor valide que el carro de compras no este vacio")
            Else
                MessageBox.Show("Cart is empty. Please add at least an item.")
            End If

        End If

    End Sub

    Public Function validarConsistencia() As Boolean
        If (DataGridView2.Rows.Count = 0) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub GenerarExcel(prov As String)
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
        style.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Green)


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
        For i = 0 To Carrito.Columns.Count - 1
            excelworksheet.Cells(4, (i + 1)) = Carrito.Columns(i).ColumnName
        Next

        'Agrego las rows

        For i = 0 To Carrito.Rows.Count - 1

            For j = 0 To Carrito.Columns.Count - 1
                excelworksheet.Cells((i + 5), (j + 1)) = Carrito.Rows(i)(j)
            Next

        Next

        'Genero el excel
        If (ExcelFileDestino IsNot Nothing And ExcelFileDestino IsNot "") Then
            Try
                excelworksheet.SaveAs(ExcelFileDestino)
                excelApp.Quit()
                MessageBox.Show("Archivo generado con exito!")
            Catch ex As Exception
                Throw New Exception("Archivo no generado, verificar la ruta \n" + ex.Message)
            End Try
        Else
            excelApp.Visible = True
        End If


    End Sub

    'Añadir al carro
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            'if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)

            Dim seguridad As New BLL.Seguridad("Password")
            Dim Proveedor As String = seguridad.Encriptar(ComboBox1.Text)
            Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
            Dim rows As DataGridViewRow = DataGridView1.Rows(rowIndex)

            Dim nombreArticulo As String = rows.Cells(1).Value
            Dim idArticulo As String = rows.Cells(0).Value

            'Dim NombreArticulo As String = DataGridView1.SelectedCells(1).RowIndex.ToString
            Dim cantidad = TextBox1.Text

            'Verificar stock proveedor
            Dim pedido As New BLL.Pedido()



            If (pedido.VerificarStockProveedor(Proveedor, nombreArticulo, cantidad)) Then
                'Verificar stock maximo

                If (pedido.VerificarStockMaximo(idArticulo, cantidad)) Then

                    Dim Articulo As New BLL.Articulo(Proveedor, nombreArticulo, cantidad)
                    dt = Articulo.mapearArticulosAobjeto(Proveedor, nombreArticulo, cantidad)


                    Dim btn As New DataGridViewButtonColumn
                    btn.HeaderText = "Click Data"
                    btn.Text = "Quitar"
                    btn.Name = "btn"
                    btn.UseColumnTextForButtonValue = True

                    For Each row As DataRow In dt.Rows
                        DataGridView2.Rows.Add(row.Item(0).ToString, row.Item(1).ToString, row.Item(2).ToString, row.Item(3).ToString, row.Item(4).ToString, btn.Text)
                    Next

                    'DataGridView2.DataSource = Carrito
                Else
                    If Login.ID_IDIOMA = 1 Then
                        MessageBox.Show("Se ha superado el Stock Maximo permitido")
                    Else
                        MessageBox.Show("You have exceed the maximum quantity for this item")
                    End If

                End If
            Else
                MessageBox.Show("El Proveedor no posee el Stock suficiente para este articulo")
            End If

                'TextBox1.Text = ""
                Label6.Text = DataGridView2.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDouble(x.Cells("SubTotal").Value))
            End If
    End Sub

    'Quitar del carro
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            Dim art As New BLL.Articulo
            Dim rowIndex As Integer = DataGridView2.CurrentCell.RowIndex
            Dim rows As DataGridViewRow = DataGridView2.Rows(rowIndex)
            'DataGridView1.Rows.Insert(rowIndex)


            DataGridView2.Rows.RemoveAt(rowIndex)
            Label6.Text = DataGridView2.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDouble(x.Cells("SubTotal").Value))
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim dataview As New DataView(ArticulosDeProveedores)

        dataview.RowFilter = "IdArticulo like '%" + TextBox3.Text + "%' " +
        "OR Descripcion like '%" + TextBox3.Text + "%'"

        DataGridView1.DataSource = dataview
    End Sub
End Class