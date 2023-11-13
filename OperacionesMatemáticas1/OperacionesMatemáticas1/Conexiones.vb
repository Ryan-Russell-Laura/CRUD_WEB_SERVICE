Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Conexiones
    Public Shared adaptador As MySqlDataAdapter
    Public Shared comando As MySqlCommand
    Public Shared Cnn As MySqlConnection

    Public Shared Sub AbrirConexion()
        Dim connectionString As String = "Server=localhost;Port=3306;Database=nomina;Uid=root;Pwd=123456789;"
        Cnn = New MySqlConnection(connectionString)
    End Sub
End Class
