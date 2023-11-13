Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Decimal
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient


' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://www.webserviceserver.somee.com/")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Public Class WebService1
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function BuscarRegistro(ByVal cadena As String) As DataSet

        Dim ds As New DataSet

        Conexiones.AbrirConexion()

        Conexiones.adaptador = New MySqlClient.MySqlDataAdapter("SELECT * FROM empleado WHERE ID LIKE '%" & cadena & "%'", Conexiones.Cnn)
        Conexiones.adaptador.Fill(ds)

        Return ds

    End Function

    <WebMethod()>
    Public Function NuevoRegistro(ByVal NOMBRE As String, ByVal TELEFONO As String, ByVal PROFESION As String, ByVal DIRECCION As String)
        Conexiones.AbrirConexion()
        Conexiones.Cnn.Open()

        Conexiones.comando = New MySqlClient.MySqlCommand("insert into empleado(nombre,telefono,profesion,direccion) values('" & NOMBRE & "','" & TELEFONO & "','" & PROFESION & "','" & DIRECCION & "')", Conexiones.Cnn)
        Conexiones.comando.ExecuteNonQuery()

        Conexiones.Cnn.Close()
        Return True
    End Function


    <WebMethod()>
    Public Function ActualizarRegistro(ByVal nuevoId As Integer, ByVal nuevoNombre As String, ByVal nuevoTelefono As String, ByVal nuevoProfesion As String, ByVal nuevoDireccion As String)
        Conexiones.AbrirConexion()
        Conexiones.Cnn.Open()
        ' Define la consulta SQL para actualizar el registro
        Conexiones.comando = New MySqlClient.MySqlCommand("UPDATE empleado SET nombre='" & nuevoNombre & "', telefono = '" & nuevoTelefono & "', profesion = '" & nuevoProfesion & "', direccion = '" & nuevoDireccion & "' WHERE id =" & nuevoId, Conexiones.Cnn)
        ' Crea un nuevo comando MySqlCommand
        Conexiones.comando.ExecuteNonQuery()

        Conexiones.Cnn.Close()
        Return True
    End Function

    <WebMethod()>
    Public Function EliminaRegistro(ByVal ID As Integer)
        Conexiones.AbrirConexion()
        Conexiones.Cnn.Open()

        Conexiones.comando = New MySqlClient.MySqlCommand("delete from empleado where ID=" & ID, Conexiones.Cnn)
        Conexiones.comando.ExecuteNonQuery()

        Conexiones.Cnn.Close()
        Return True
    End Function
    Public Function ObtenerTodosLosRegistros() As DataSet
        Dim ds As New DataSet

        ' Abre una conexión a la base de datos
        Conexiones.AbrirConexion()

        ' Define la consulta SQL para seleccionar todos los registros
        Conexiones.adaptador = New MySqlClient.MySqlDataAdapter("SELECT * FROM empleado", Conexiones.Cnn)
        Conexiones.adaptador.Fill(ds)

        ' Cierra la conexión a la base de datos
        Conexiones.Cnn.Close()

        Return ds
    End Function
End Class