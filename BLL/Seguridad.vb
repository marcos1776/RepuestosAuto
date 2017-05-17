Imports System.Security.Cryptography
Imports System.Text.RegularExpressions
Imports System
Imports System.IO
Imports System.Text
Imports System.Windows.Forms

Public Class Seguridad
    Public listaDVH As New List(Of String)
    Public listaString As New List(Of String)
    Public listaIDFila As New List(Of String)


    Private TripleDes As New TripleDESCryptoServiceProvider

    Sub New(ByVal key As String)
        ' Initialize the crypto provider.
        TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
    End Sub

    Public Function aceptaLetras(c As String) As Boolean
        Dim re As New Regex("[^A-ZÑ\b ]", RegexOptions.IgnoreCase)
        If re.IsMatch(c) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function aceptaNumeros(c As String) As Boolean
        Dim re As New Regex("[^0-9\b ]", RegexOptions.IgnoreCase)
        If re.IsMatch(c) Then
            Return True
        Else
            Return False
        End If

    End Function


    Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()

        Dim sha1 As New SHA1CryptoServiceProvider

        ' Hash the key.
        Dim keyBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)

        ' Truncate or pad the hash.
        ReDim Preserve hash(length - 1)
        Return hash
    End Function

    Public Function Encriptar(ByVal plaintext As String) As String

        ' Convert the plaintext string to a byte array.
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        ' Create the stream.
        Dim ms As New System.IO.MemoryStream
        ' Create the encoder to write to the stream.
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        ' Convert the encrypted stream to a printable string.
        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function registrarBitacora(ID_USUARIO As Integer, tipo As String, hoy As DateTime, desc As String, dvh As Integer) As Integer
        Dim dal As New DAL.Seguridad
        Return dal.RegitrarBitacora(ID_USUARIO, tipo, DateTime.Now, desc, 0)
    End Function


    Public Function buscarRegistroBitacora(id As Integer) As DataTable
        Dim dal As New DAL.Seguridad
        Return dal.buscarRegistroBitacora(id)
    End Function

    Public Sub DenegarPatente(user As String, pat As String)
        Dim dal As New DAL.Seguridad
        dal.DenegarPatente(user, pat)
    End Sub

    Public Sub AsignarPatenteUsuario(user As String, pat As String)
        Dim dal As New DAL.Seguridad
        dal.AsignarPatenteUsuario(user, pat)
    End Sub

    Public Sub AsignarPatenteFamilia(nombre As String, patente As String)
        Dim dal As New DAL.Familia
        dal.AsignarPatentes(nombre, patente)
    End Sub

    Public Function Desencriptar(ByVal encryptedtext As String) As String

        ' Convert the encrypted text string to a byte array.
        Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

        ' Create the stream.
        Dim ms As New System.IO.MemoryStream
        ' Create the decoder to write to the stream.
        Dim decStream As New CryptoStream(ms, TripleDes.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()

        ' Convert the plaintext stream to a string.
        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
    End Function

    Public Function generarContraseñaAleatoria(nombre As String, apellido As String, usuario As String) As String
        Dim password As String
        Dim user As New DAL.Usuario()

        password = nombre.Substring(0, 3) + apellido.Substring(0, 3) + "123"
        crearFilePassword(usuario, password)

        ' Hacer ---> Generar password con MD5

        password = EncriptarPassword(password)

        'Actualizarla en la base de datos

        user.actualizarContraseña(usuario, password)

        Return password
    End Function

    Public Sub crearFilePassword(user As String, pass As String)
        Dim path As String = My.Resources.PathUserPasswords + "" & user & ".txt"

        ' Create or overwrite the file.
        Dim fs As FileStream = File.Create(path)

        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(pass)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub

    Public Function EncriptarPassword(pass As String) As String
        Dim md5 As MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim strPassOutput As String
        Dim i As Integer
        strPassOutput = ""

        md5 = New MD5CryptoServiceProvider

        bytValue = System.Text.Encoding.UTF8.GetBytes(pass)

        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            strPassOutput &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next

        Return strPassOutput
    End Function

    Public Function ValidarPatentesAsignadas(patentes As List(Of String), user As String) As Boolean
        Dim DalSeguridad As New DAL.Seguridad
        Dim seguridad As New BLL.Seguridad("Password")
        user = seguridad.Encriptar(user)

        'Dim cantidadPatentes As Integer
        'cantidadPatentes = DalSeguridad.
        ValidarPatentes(patentes, user)


        Return True
    End Function

    Public Sub ValidarPatentes(patentes As List(Of String), user As String)
        Dim seguridad As New DAL.Seguridad
        'Creo tabla temporal
        seguridad.CreartablaTemporal()

        For Each pat In patentes
            seguridad.InsertarPatenteTemporal(pat, user)
        Next

        Dim cantidadPatentes As New DataSet
        cantidadPatentes = seguridad.cantidadPatentesAsignadas(user)
        Dim patentesAasignar As New List(Of String)
        Dim encontrado As Boolean = False

        For i As Integer = 0 To cantidadPatentes.Tables("todasPatentes").Rows.Count - 1
            For j As Integer = 0 To cantidadPatentes.Tables("patentesAsignadas").Rows.Count - 1
                If cantidadPatentes.Tables("todasPatentes").Rows(i).Item(0).ToString = cantidadPatentes.Tables("patentesAsignadas").Rows(j).Item(0).ToString Then
                    encontrado = True
                    Exit For
                End If
            Next
            If Not (encontrado) Then
                patentesAasignar.Add(cantidadPatentes.Tables("todasPatentes").Rows(i).Item(1).ToString)
            End If
            encontrado = False

        Next

        If patentesAasignar.Count > 0 Then
            Dim mensaje As String
            mensaje = String.Join(Environment.NewLine, patentesAasignar.ToArray())
            MsgBox("Debera asignar las siguientes patentes: " + mensaje)
        Else
            '
            ' Borro las patentes del usuario
            seguridad.borrarPatentesUsuario(user)

            'Inserto las patentes y familias
            '
            For j As Integer = 0 To cantidadPatentes.Tables("patentesAsignadas").Rows.Count - 1
                seguridad.InsertarPatente(user, cantidadPatentes.Tables("patentesAsignadas").Rows(j).Item(0))
            Next

            MsgBox("Patentes cargadas correctamente")
        End If

        seguridad.BorrartablaTemporal()

    End Sub

    Public Function ValidarContraseña(IdUsuario As Integer, contraseña As String) As Boolean
        Dim dt As New DataTable
        Dim seg As New DAL.Seguridad()
        dt = seg.ValidarContraseña(IdUsuario, contraseña)

        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ModificarContraseña(idUsuario As Integer, password As String) As Boolean
        Dim seguridad As New DAL.Seguridad
        seguridad.ModificarContraseña(idUsuario, password)

        Return True
    End Function


    Public Sub ModificarDVH(id As String, dvh As Integer, tabla As String, tipoId As String)
        Dim seguridad As New DAL.Seguridad
        seguridad.ModificarDVH(id, dvh, tabla, tipoId)
    End Sub


    Public Sub ActualizarDVV(tabla As String)
        Dim seguridad As New DAL.Seguridad
        seguridad.ActualizarDVV(tabla)
    End Sub

    Public Sub ModificarDVH2(id As String, id2 As String, dvh As Integer, tabla As String, tipoId As String, tipoId2 As String)
        Dim seguridad As New DAL.Seguridad
        seguridad.ModificarDVH2(id, id2, dvh, tabla, tipoId, tipoId2)
    End Sub




    Public Function validarPatente(user As String, pat As String) As Boolean
        Dim dal As New DAL.Seguridad()
        Dim cantidadPatentes As Integer
        cantidadPatentes = dal.ValidarPatente(user, pat)

        If cantidadPatentes = 31 Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function AsignarFamiliaUsuario(usuario As String, fam As String)
        Dim dal As New DAL.Seguridad()
        dal.AsignarFamiliaUsuario(usuario, fam)

        Return 0
    End Function

    Public Function ObtenerMensajes(Idioma As Integer, Form As Integer) As DataTable
        Dim segu As New DAL.Seguridad()

        Return segu.ObtenerMensajes(Idioma, Form)
    End Function


    Public Function validarConsistencia(ByVal frm As Form) As Boolean

        Dim validado As Boolean = True

        For Each c As TextBox In frm.Controls.OfType(Of TextBox)()
            If c.Text = String.Empty Then
                MsgBox("Por favor complete los campos", MsgBoxStyle.OkOnly, "Advertencia")
                Return False
            End If
        Next
        Return True
    End Function


    ' Nuevo
    Public Function asignarPatente(user As String, pat As String) As DataSet
        Dim dal As New DAL.Seguridad
        Dim idUsuarioPatente As Integer
        idUsuarioPatente = dal.InsertarPatente(user, pat)


        Return dal.ObtenerIdUsuarioPatente(idUsuarioPatente)
    End Function

    Public Function NegarPatenteUsuario(user As String, pat As String) As Boolean
        Dim dal As New DAL.Seguridad
        Dim dt As New DataTable
        'Dim idUsuarioPatente As Integer
        'idUsuarioPatente = 
        dt = dal.PatenteValidacion(user, pat)

        If dt.Rows.Count > 1 Then
            dal.NegarPatente(user, pat)
            Return True
        Else
            Return False
        End If

        Return True

    End Function

    Public Function DesasignarPatenteUsuario(user As String, pat As String) As Boolean
        Dim dal As New DAL.Seguridad
        Dim dt As New DataTable
        'Dim idUsuarioPatente As Integer
        'idUsuarioPatente = 
        dt = dal.PatenteValidacion(user, pat)

        If dt.Rows.Count > 1 Then
            dal.desasignarPatente(user, pat)
            Return True
        Else
            Return False
        End If

        Return True

    End Function


    Public Sub desasignarFamiliaUsuario(user As String, fam As String)
        Dim dal As New DAL.Seguridad
        dal.desasignarFamiliaUsuario(user, fam)
    End Sub

    Public Function validarPatenteEliminar(fam As String, pat As String) As Boolean
        Dim dal As New DAL.Seguridad
        Dim dt As New DataTable
        'Dim idUsuarioPatente As Integer
        'idUsuarioPatente = 
        dt = dal.FamiliaPatenteValidacion(fam, pat)

        If dt.Rows.Count >= 1 Then
            Return True
        Else
            Return False
        End If

        Return True

    End Function


    Public Function ObtenerPatentesDeUsuario(idUser As Integer) As DataTable
        Dim dal As New DAL.Seguridad
        Return dal.ObtenerPatentesDeUsuario(idUser)

    End Function



    Public Function ValidarPatentesUsuario(user As String) As Boolean
        Dim dal As New DAL.Seguridad
        Dim dt As New DataTable
        'Dim idUsuarioPatente As Integer
        'idUsuarioPatente = 
        dt = dal.UsuarioPatenteValidacion(user)

        If dt.Rows.Count <> 31 Then
            Return False
        Else
            Return True
        End If

        Return True

    End Function

    Public Function DesasignarPatenteFamilia(fam As String, pat As String) As Boolean
        Dim dal As New DAL.Seguridad
        Dim dt As New DataTable
        'Dim idUsuarioPatente As Integer
        'idUsuarioPatente = 
        dt = dal.DesasignarPatenteFamiliaValidacion(fam, pat)

        If dt.Rows.Count >= 1 Then
            dal.desasignarPatenteFamilia(fam, pat)
            Return True
        Else
            Return False
        End If

        Return True

    End Function



    Public Sub ModificarDatosFamilia(nombreOriginal As String, nombreNuevo As String)
        Dim dal As New DAL.Seguridad
        dal.ModificarDatosFamilia(nombreOriginal, nombreNuevo)
    End Sub

    Public Function validarDVV() As Boolean
        Dim respuesta As String
        respuesta = validarDVV_Tabla("Usuario")
        If respuesta = "OK" Then
            respuesta = validarDVV_Tabla("Telefono_Usuario")
            If respuesta = "OK" Then
                respuesta = validarDVV_Tabla("Proveedor")
                If respuesta = "OK" Then
                    respuesta = validarDVV_Tabla("Telefono_Proveedor")
                    If respuesta = "OK" Then
                        respuesta = validarDVV_Tabla("DireccionProveedores")
                        If respuesta = "OK" Then
                            respuesta = validarDVV_Tabla("Articulo")
                            If respuesta = "OK" Then
                                respuesta = validarDVV_Tabla("Pedido")
                                If respuesta = "OK" Then
                                    respuesta = validarDVV_Tabla("Detalle_Pedido")
                                    If respuesta = "OK" Then
                                        respuesta = validarDVV_Tabla("Cliente")
                                        If respuesta = "OK" Then
                                            respuesta = validarDVV_Tabla("Empresa")
                                            If respuesta = "OK" Then
                                                respuesta = validarDVV_Tabla("Venta")
                                                If respuesta = "OK" Then
                                                    respuesta = validarDVV_Tabla("Detalle_Venta")
                                                    If respuesta = "OK" Then
                                                        Return True
                                                    Else
                                                        MsgBox("ERROR DE DVV " + respuesta + ". Contactar al Administrador", MsgBoxStyle.Critical)
                                                        Return False
                                                    End If
                                                Else
                                                    MsgBox("ERROR DE DVV " + respuesta + ". Contactar al Administrador", MsgBoxStyle.Critical)
                                                    Return False
                                                End If
                                            Else
                                                MsgBox("ERROR DE DVV " + respuesta + ". Contactar al Administrador", MsgBoxStyle.Critical)
                                                Return False
                                            End If
                                        Else
                                            MsgBox("ERROR DE DVV " + respuesta + ". Contactar al Administrador", MsgBoxStyle.Critical)
                                            Return False
                                        End If
                                    Else
                                        MsgBox("ERROR DE DVV " + respuesta + ". Contactar al Administrador", MsgBoxStyle.Critical)
                                        Return False
                                    End If
                                Else
                                    MsgBox("ERROR DE DVV " + respuesta + ". Contactar al Administrador", MsgBoxStyle.Critical)
                                    Return False
                                End If
                            Else
                                MsgBox("ERROR DE DVV " + respuesta + ". Contactar al Administrador", MsgBoxStyle.Critical)
                                Return False
                            End If
                        Else
                            MsgBox("ERROR DE DVV " + respuesta + ". Contactar al Administrador", MsgBoxStyle.Critical)
                            Return False
                        End If
                    Else
                        MsgBox("ERROR DE DVV " + respuesta + ". Contactar al Administrador", MsgBoxStyle.Critical)
                        Return False
                    End If
                Else
                    MsgBox("ERROR DE DVV " + respuesta + ". Contactar al Administrador", MsgBoxStyle.Critical)
                    Return False
                End If
            Else
                MsgBox("ERROR DE DVV " + respuesta + ". Contactar al Administrador", MsgBoxStyle.Critical)
                Return False
            End If
        Else
            MsgBox("ERROR DE DVV " + respuesta + ". Contactar al Administrador", MsgBoxStyle.Critical)
            Return False
        End If


    End Function



    Public Function validarDVH() As Boolean
        Dim respuesta As String
        respuesta = validarDVH_Usuario()
        If respuesta = "OK" Then
            respuesta = VerificarDVH_Proveedor()
            If respuesta = "OK" Then
                respuesta = VerificarDVH_TelefonosUsuario()
                If respuesta = "OK" Then
                    respuesta = VerificarDVH_TelefonosProveedor()
                    If respuesta = "OK" Then
                        respuesta = VerificarDVH_DireccionProveedor()
                        If respuesta = "OK" Then
                            respuesta = VerificarDVH_Pedido()
                            If respuesta = "OK" Then
                                respuesta = verificarDVH_DetallePedido()
                                If respuesta = "OK" Then
                                    respuesta = verificarDVH_Venta()
                                    If respuesta = "OK" Then
                                        respuesta = verificarDVH_DetalleVenta()
                                        If respuesta = "OK" Then
                                            respuesta = verificarDVH_Articulos()
                                            If respuesta = "OK" Then
                                                respuesta = verificarDVH_Empresa()
                                                If respuesta = "OK" Then
                                                    respuesta = verificarDVH_Cliente()
                                                    If respuesta = "OK" Then
                                                        Return True
                                                    Else
                                                        MsgBox("Error en la integridad de los datos de la tabla Cliente, en la fila " & respuesta & ". Contactar al Administrador", MsgBoxStyle.Critical)
                                                        Return False
                                                    End If
                                                Else
                                                    MsgBox("Error en la integridad de los datos de la tabla Empresa, en la fila " & respuesta & ". Contactar al Administrador", MsgBoxStyle.Critical)
                                                    Return False
                                                End If
                                            Else
                                                MsgBox("Error en la integridad de los datos de la tabla Articulos, en la fila " & respuesta & ". Contactar al Administrador", MsgBoxStyle.Critical)
                                                Return False
                                            End If
                                        Else
                                            MsgBox("Error en la integridad de los datos de la tabla Detalle_Venta, en la fila " & respuesta & ". Contactar al Administrador", MsgBoxStyle.Critical)
                                            Return False
                                        End If
                                    Else
                                        MsgBox("Error en la integridad de los datos de la tabla Venta, en la fila " & respuesta & ". Contactar al Administrador", MsgBoxStyle.Critical)
                                        Return False
                                    End If
                                Else
                                    MsgBox("Error en la integridad de los datos de la tabla detalle_Pedido, en la fila " & respuesta & ". Contactar al Administrador", MsgBoxStyle.Critical)
                                    Return False
                                End If
                            Else
                                MsgBox("Error en la integridad de los datos de la tabla Pedido, en la fila " & respuesta & ". Contactar al Administrador", MsgBoxStyle.Critical)
                                Return False
                            End If
                        Else
                            MsgBox("Error en la integridad de los datos de la tabla Direccion_Proveedor, en la fila " & respuesta & ". Contactar al Administrador", MsgBoxStyle.Critical)
                            Return False
                        End If
                    Else
                        MsgBox("Error en la integridad de los datos de la tabla Telefono_Proveedor, en la fila " & respuesta & ". Contactar al Administrador", MsgBoxStyle.Critical)
                        Return False
                    End If
                Else
                    MsgBox("Error en la integridad de los datos de la tabla Telefono_Usuario, en la fila " & respuesta & ". Contactar al Administrador", MsgBoxStyle.Critical)
                    Return False
                End If
            Else
                MsgBox("Error en la integridad de los datos de la tabla Proveedor, en la fila " & respuesta & ". Contactar al Administrador", MsgBoxStyle.Critical)
                Return False
            End If
        Else
            MsgBox("Error en la integridad de los datos de la tabla Usuarios, en la fila " & respuesta & ". Contactar al Administrador", MsgBoxStyle.Critical)
            Return False
        End If
    End Function


    '' DVH
    Public Function calcularDVH(str As String) As Integer
        Dim dvh As Integer
        Dim sumador As Integer
        sumador = 0
        'Dim asci As Byte() = System.Text.Encoding.ASCII.GetBytes

        For i As Integer = 0 To str.Length - 1
            dvh = Asc(str(i)) * (i + 1)
            sumador = sumador + dvh
        Next

        Return sumador
    End Function



    Public Function validarDVV_Tabla(tabla As String) As String
        Dim dt As New DataTable
        Dim DAL As New DAL.Seguridad()

        dt = DAL.validarDVV_Tabla(tabla)

        Return dt(0).Item(0).ToString()

    End Function

    ' Valida DVH Tabla Usuario
    Private Function validarDVH_Usuario() As String
        Dim cad As String
        Dim dal As New DAL.Seguridad
        Dim i As Integer = 0
        Dim ds As New DataTable

        listaDVH.Clear()
        listaIDFila.Clear()
        listaString.Clear()

        ds = dal.obtenerTabla("Usuario")


        For Each row As DataRow In ds.Rows
            cad = Trim(row.Item("IdUsuario").ToString)
            cad = cad & Trim(row.Item("Nombre").ToString)
            cad = cad & Trim(row.Item("Apellido").ToString)
            cad = cad & Trim(row.Item("Nick").ToString)
            cad = cad & Trim(row.Item("Contraseña").ToString)
            cad = cad & Trim(row.Item("Domicilio").ToString)
            cad = cad & Trim(row.Item("Mail").ToString)
            cad = cad & Trim(row.Item("Dni").ToString)
            cad = cad & Trim(row.Item("EsActivo").ToString)
            cad = cad & Trim(row.Item("LoginFallos").ToString)
            'cad = cad & row.Item("DVH").ToString

            listaString.Add(cad)
            listaDVH.Add(row.Item("DVH").ToString)
            listaIDFila.Add(row.Item("IdUsuario").ToString)
        Next

        For Each cadena As String In listaString
            If calcularDVH(cadena) = listaDVH(i) Then
                i = i + 1
            Else
                Return listaIDFila(i).ToString
            End If
        Next
        listaDVH.Clear()
        listaIDFila.Clear()
        listaString.Clear()
        Return "OK"
    End Function

    ' Valida DVH Tabla Proveedor
    Private Function VerificarDVH_Proveedor() As String
        Dim cad As String
        Dim dal As New DAL.Seguridad
        Dim i As Integer = 0
        Dim ds As New DataTable

        ds = dal.obtenerTabla("Proveedor")


        For Each row As DataRow In ds.Rows
            cad = Trim(row.Item("idProveedor").ToString)
            cad = cad & Trim(row.Item("Nombre_Empresa").ToString)
            cad = cad & Trim(row.Item("Nombre_Contacto").ToString)
            cad = cad & Trim(row.Item("Apellido_Contacto").ToString)
            cad = cad & Trim(row.Item("Mail").ToString)
            cad = cad & Trim(row.Item("EsActivo").ToString)


            listaString.Add(cad)
            listaDVH.Add(row.Item("DVH").ToString)
            listaIDFila.Add(row.Item("IdProveedor").ToString)
        Next

        For Each cadena As String In listaString
            If calcularDVH(cadena) = listaDVH(i) Then
                i = i + 1
            Else
                Return listaIDFila(i).ToString
            End If
        Next
        Return "OK"
    End Function

    ' Valida DVH Tabla Telefono Usuario
    Private Function VerificarDVH_TelefonosUsuario() As String
        Dim cad As String
        Dim dal As New DAL.Seguridad
        Dim i As Integer = 0
        Dim ds As New DataTable

        ds = dal.obtenerTabla("Telefono_Usuario")


        For Each row As DataRow In ds.Rows
            cad = Trim(row.Item("idUsuario").ToString)
            cad = cad & Trim(row.Item("Telefono").ToString)
            cad = cad & Trim(row.Item("EsActivo").ToString)

            listaString.Add(cad)
            listaDVH.Add(row.Item("DVH").ToString)
            listaIDFila.Add(row.Item("idUsuario").ToString)
        Next

        For Each cadena As String In listaString
            If calcularDVH(cadena) = listaDVH(i) Then
                i = i + 1
            Else
                Return listaIDFila(i).ToString
            End If
        Next
        Return "OK"
    End Function

    ' Valida DVH Tabla TelefonosProveedor
    Private Function VerificarDVH_TelefonosProveedor() As String
        Dim cad As String
        Dim dal As New DAL.Seguridad
        Dim i As Integer = 0
        Dim ds As New DataTable

        ds = dal.obtenerTabla("Telefono_Proveedor")


        For Each row As DataRow In ds.Rows
            cad = Trim(row.Item("idProveedor").ToString)
            cad = cad & Trim(row.Item("Telefono").ToString)
            cad = cad & Trim(row.Item("EsActivo").ToString)

            listaString.Add(cad)
            listaDVH.Add(row.Item("DVH").ToString)
            listaIDFila.Add(row.Item("idProveedor").ToString)
        Next

        For Each cadena As String In listaString
            If calcularDVH(cadena) = listaDVH(i) Then
                i = i + 1
            Else
                Return listaIDFila(i).ToString
            End If
        Next
        Return "OK"
    End Function

    ' Valida DVH Tabla Direccion Proveedor
    Private Function VerificarDVH_DireccionProveedor() As String
        Dim cad As String
        Dim dal As New DAL.Seguridad
        Dim i As Integer = 0
        Dim ds As New DataTable

        ds = dal.obtenerTabla("DireccionProveedores")


        For Each row As DataRow In ds.Rows
            cad = Trim(row.Item("idProveedor").ToString)
            cad = cad & Trim(row.Item("Direccion").ToString)

            listaString.Add(cad)
            listaDVH.Add(row.Item("DVH").ToString)
            listaIDFila.Add(row.Item("idProveedor").ToString)
        Next

        For Each cadena As String In listaString
            If calcularDVH(cadena) = listaDVH(i) Then
                i = i + 1
            Else
                Return listaIDFila(i).ToString
            End If
        Next
        Return "OK"
    End Function


    ' Valida DVH Tabla Pedido
    Private Function VerificarDVH_Pedido() As String
        Dim cad As String
        Dim dal As New DAL.Seguridad
        Dim i As Integer = 0
        Dim ds As New DataTable

        ds = dal.obtenerTabla("Pedido")


        For Each row As DataRow In ds.Rows
            cad = Trim(row.Item("idPedido").ToString)
            cad = cad & Trim(row.Item("idProveedor").ToString)
            cad = cad & Trim(row.Item("idUsuario").ToString)
            cad = cad & Trim(row.Item("Fecha").ToString)
            cad = cad & Trim(row.Item("Total").ToString)
            cad = cad & Trim(row.Item("Estado").ToString)

            listaString.Add(cad)
            listaDVH.Add(row.Item("DVH").ToString)
            listaIDFila.Add(row.Item("idPedido").ToString)
        Next

        For Each cadena As String In listaString
            If calcularDVH(cadena) = listaDVH(i) Then
                i = i + 1
            Else
                Return listaIDFila(i).ToString
            End If
        Next
        Return "OK"
    End Function

    ' Valida DVH Tabla Detalle_Pedido
    Private Function verificarDVH_DetallePedido() As String
        Dim cad As String
        Dim dal As New DAL.Seguridad
        Dim i As Integer = 0
        Dim ds As New DataTable

        ds = dal.obtenerTabla("Detalle_Pedido")


        For Each row As DataRow In ds.Rows
            cad = Trim(row.Item("idPedido").ToString)
            cad = cad & Trim(row.Item("idArticulo").ToString)
            cad = cad & Trim(row.Item("MontoArticulo").ToString)
            cad = cad & Trim(row.Item("Cantidad").ToString)

            listaString.Add(cad)
            listaDVH.Add(row.Item("DVH").ToString)
            listaIDFila.Add(row.Item("idPedido").ToString)
        Next

        For Each cadena As String In listaString
            If calcularDVH(cadena) = listaDVH(i) Then
                i = i + 1
            Else
                Return listaIDFila(i).ToString
            End If
        Next
        Return "OK"
    End Function

    ' Valida DVH Tabla Venta
    Private Function verificarDVH_Venta() As String
        Dim cad As String
        Dim dal As New DAL.Seguridad
        Dim i As Integer = 0
        Dim ds As New DataTable

        ds = dal.obtenerTabla("Venta")


        For Each row As DataRow In ds.Rows
            cad = Trim(row.Item("idVenta").ToString)
            cad = cad & Trim(row.Item("idCliente").ToString)
            cad = cad & Trim(row.Item("idUsuario").ToString)
            cad = cad & Trim(row.Item("Fecha").ToString)
            cad = cad & Trim(row.Item("Total").ToString)
            cad = cad & Trim(row.Item("esCancelada").ToString)

            listaString.Add(cad)
            listaDVH.Add(row.Item("DVH").ToString)
            listaIDFila.Add(row.Item("idVenta").ToString)
        Next

        For Each cadena As String In listaString
            If calcularDVH(cadena) = listaDVH(i) Then
                i = i + 1
            Else
                Return listaIDFila(i).ToString
            End If
        Next
        Return "OK"
    End Function


    ' Valida DVH Tabla Detalle_Venta
    Private Function verificarDVH_DetalleVenta() As String
        Dim cad As String
        Dim dal As New DAL.Seguridad
        Dim i As Integer = 0
        Dim ds As New DataTable

        ds = dal.obtenerTabla("Detalle_Venta")


        For Each row As DataRow In ds.Rows
            cad = Trim(row.Item("idVenta").ToString)
            cad = cad & Trim(row.Item("idArticulo").ToString)
            cad = cad & Trim(row.Item("precioVenta").ToString)
            cad = cad & Trim(row.Item("Cantidad").ToString)

            listaString.Add(cad)
            listaDVH.Add(row.Item("DVH").ToString)
            listaIDFila.Add(row.Item("idVenta").ToString)
        Next

        For Each cadena As String In listaString
            If calcularDVH(cadena) = listaDVH(i) Then
                i = i + 1
            Else
                Return listaIDFila(i).ToString
            End If
        Next
        Return "OK"
    End Function

    ' Verificar Usuario Patentes ??
    Private Function verificarDVH_UsuarioPatente() As String
        Dim cad As String
        Dim dal As New DAL.Seguridad
        Dim i As Integer = 0
        Dim ds As New DataTable

        ds = dal.obtenerTabla("UsuarioPatente")


        For Each row As DataRow In ds.Rows
            cad = Trim(row.Item("idUsuarioPatente").ToString)
            cad = cad & Trim(row.Item("idUsuario").ToString)
            cad = cad & Trim(row.Item("idUsuario").ToString)
            cad = cad & Trim(row.Item("idPatente").ToString)
            cad = cad & Trim(row.Item("esNegada").ToString)

            listaString.Add(cad)
            listaDVH.Add(row.Item("DVH").ToString)
            listaIDFila.Add(row.Item("idUsuarioPatente").ToString)
        Next

        For Each cadena As String In listaString
            If calcularDVH(cadena) = listaDVH(i) Then
                i = i + 1
            Else
                Return listaIDFila(i).ToString
            End If
        Next
        Return "OK"
    End Function

    ' Verificar Usuario Articulos 
    Private Function verificarDVH_Articulos() As String
        listaString.Clear()
        listaDVH.Clear()
        listaIDFila.Clear()

        Dim cad As String
        Dim dal As New DAL.Seguridad
        Dim i As Integer = 0
        Dim ds As New DataTable

        ds = dal.obtenerTabla("Articulo")


        For Each row As DataRow In ds.Rows
            cad = Trim(row.Item("idArticulo").ToString)
            cad = cad & Trim(row.Item("idProveedor").ToString)
            cad = cad & Trim(row.Item("StockProveedor").ToString)
            cad = cad & Trim(row.Item("Descripcion").ToString)
            cad = cad & Trim(row.Item("StockMinimo").ToString)
            cad = cad & Trim(row.Item("StockMaximo").ToString)
            cad = cad & Trim(row.Item("Margen_ganancia").ToString)
            cad = cad & Trim(row.Item("esActivo").ToString)
            cad = cad & Trim(row.Item("Precio").ToString)

            listaString.Add(cad)
            listaDVH.Add(row.Item("DVH").ToString)
            listaIDFila.Add(row.Item("idArticulo").ToString)
        Next

        For Each cadena As String In listaString
            If calcularDVH(cadena) = listaDVH(i) Then
                i = i + 1
            Else
                Return listaIDFila(i).ToString
            End If
        Next
        Return "OK"
    End Function

    ' Verificar Usuario Empresa
    Private Function verificarDVH_Empresa() As String
        Dim cad As String
        Dim dal As New DAL.Seguridad
        Dim i As Integer = 0
        Dim ds As New DataTable

        ds = dal.obtenerTabla("Empresa")


        For Each row As DataRow In ds.Rows
            cad = Trim(row.Item("idCliente").ToString)
            cad = cad & Trim(row.Item("Razon_Social").ToString)
            cad = cad & Trim(row.Item("Cuit").ToString)

            listaString.Add(cad)
            listaDVH.Add(row.Item("DVH").ToString)
            listaIDFila.Add(row.Item("idCliente").ToString)
        Next

        For Each cadena As String In listaString
            If calcularDVH(cadena) = listaDVH(i) Then
                i = i + 1
            Else
                Return listaIDFila(i).ToString
            End If
        Next
        Return "OK"
    End Function

    ' Verificar Usuario Cliente
    Private Function verificarDVH_Cliente() As String
        listaString.Clear()
        listaDVH.Clear()
        listaIDFila.Clear()
        Dim cad As String
        Dim dal As New DAL.Seguridad
        Dim i As Integer = 0
        Dim ds As New DataTable

        ds = dal.obtenerTabla("Cliente")


        For Each row As DataRow In ds.Rows
            cad = Trim(row.Item("idCliente").ToString)
            cad = cad & Trim(row.Item("Nombre").ToString)
            cad = cad & Trim(row.Item("Apellido").ToString)
            cad = cad & Trim(row.Item("Dni").ToString)

            listaString.Add(cad)
            listaDVH.Add(row.Item("DVH").ToString)
            listaIDFila.Add(row.Item("idCliente").ToString)
        Next

        For Each cadena As String In listaString
            If calcularDVH(cadena) = listaDVH(i) Then
                i = i + 1
            Else
                Return listaIDFila(i).ToString
            End If
        Next
        Return "OK"
    End Function

    Public Function RealizarBackUpPorPartes(ByVal cantPartes As Integer, ByVal destino As String, ByVal nombre As String) As Boolean
        Dim seguridad As New DAL.Seguridad

        Dim consulta As String = ""
        Dim cArmado As String = ""
        Dim cadena As String = ""

        For i = 1 To CInt(cantPartes)
            If i = 1 And i < (cantPartes) Then
                cArmado = cArmado & " DISK = ''" & destino.ToString & "\" & nombre.ToString & i.ToString & " " & Format(Now(), "dd-MM-yyyy hh_mm_ss") & "hs.bak'' ,"
            ElseIf i < (cantPartes) And i > 1 Then
                cArmado = cArmado & " DISK = ''" & destino.ToString & "\" & nombre.ToString & i.ToString & " " & Format(Now(), "dd-MM-yyyy hh_mm_ss") & "hs.bak'' ,"
            ElseIf i = cantPartes Then
                cArmado = cArmado & " DISK = ''" & destino.ToString & "\" & nombre.ToString & i.ToString & " " & Format(Now(), "dd-MM-yyyy hh_mm_ss") & "hs.bak''"
            End If

        Next

        cadena = "BACKUP DATABASE Campo TO" & cArmado
        consulta = "exec SP_BackUp_X_Partes '" & cadena & "'"

        If seguridad.EjecutarStoreProcedure(consulta) Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function RealizarBackUp(ByVal destino As String, ByVal nombre As String) As Boolean
        Dim seguridad As New DAL.Seguridad
        Dim consulta As String
        Dim cArmado As String = ""
        cArmado = destino.ToString & "\" & nombre.ToString & " " & Format(Now(), "dd-MM-yyy HH_mm_ss") & "hs.bak"
        consulta = " exec SP_BackUp '" & cArmado & "'"

        If seguridad.EjecutarStoreProcedure(consulta) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function RealizarRestore(path) As Boolean
        Dim seg As New DAL.Seguridad

        Dim SP As String

        SP = "Alter database campo set offline with rollback immediate"
        seg.EjecutarConsultaRestore(SP)


        SP = "exec SP_Restore '" & path & "'"

        If seg.EjecutarStoreProcedure(SP) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
