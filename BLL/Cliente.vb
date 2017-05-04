Public Class Cliente

    Public Function altaCliente(nom As String, ape As String, dni As String) As Integer
        Dim dal As New DAL.Cliente()
        Return dal.AltaCliente(nom, ape, dni)
    End Function

    Public Sub altaEmpresa(idCliente As Integer, razonSocial As String, cuit As String)
        Dim dal As New DAL.Cliente()
        dal.altaEmpresa(idCliente, razonSocial, cuit)
    End Sub

    Public Function ObtenerCliente(id As Integer) As DataTable
        Dim dal As New DAL.Cliente()
        Return dal.obtenerCliente(id)
    End Function

    Public Function ObtenerEmpresa(id As Integer) As DataTable
        Dim dal As New DAL.Cliente()
        Return dal.ObtenerEmpresa(id)
    End Function

End Class
