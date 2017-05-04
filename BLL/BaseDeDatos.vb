Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class BaseDeDatos

    Dim connection As New SqlConnection
    Dim command As New SqlCommand
    Dim Dr As SqlDataReader

    Private Shared ReadOnly _instancia As New Lazy(Of BaseDeDatos)(Function() New BaseDeDatos(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

    Sub New()

    End Sub


    Public Sub Conexion()
        connection = New SqlConnection(ConnectionString)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        ElseIf connection.State = ConnectionState.Closed Then
            connection.Close()
        End If
    End Sub

    Public Shared ReadOnly Property instancia() As BaseDeDatos
        Get
            Return _instancia.Value
        End Get
    End Property

    Public Property ConnectionString As String


    Public Sub ObtenerServidores(ByVal Combo As ComboBox)
        Dim Server As String = String.Empty
        Dim instance As Sql.SqlDataSourceEnumerator = Sql.SqlDataSourceEnumerator.Instance
        Dim table As System.Data.DataTable = instance.GetDataSources()
        For Each row As System.Data.DataRow In table.Rows
            Server = String.Empty
            Server = row("ServerName")
            If row("InstanceName").ToString.Length > 0 Then
                Server = Server & "\" & row("InstanceName")
            End If
            Combo.Items.Add(Server)
        Next
        Combo.SelectedIndex = Combo.FindStringExact(Environment.MachineName)
    End Sub

    Public Sub PrimeraConexion(ByVal ConString As String)
        Try
            connection.Close()
            ConnectionString = ConString
            connection.ConnectionString = ConString
            connection.Open()
        Catch ex As Exception
            MessageBox.Show("No hay conexion con la base de datos - No connection to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
