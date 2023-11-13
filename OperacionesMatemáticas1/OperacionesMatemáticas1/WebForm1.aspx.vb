Imports CRUD_WebService

Public Class WebForm1
    Inherits System.Web.UI.Page
    Dim Operaciones = New WebService1

    Private Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ' Carga los datos iniciales en el GridView al cargar la página
            CargarDatosEnGridView()
        End If
    End Sub
    ' Método para cargar los datos en el GridView
    Private Sub CargarDatosEnGridView()
        Dim datos As DataSet = Operaciones.ObtenerTodosLosRegistros()

        ' Asigna el DataSet al GridView
        GridView1.DataSource = datos.Tables(0)
        GridView1.DataBind()
    End Sub
    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Operaciones.NuevoRegistro(txtNombre.Text, txtTelefono.Text, txtProfesion.Text, txtDireccion.Text)
        CargarDatosEnGridView()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Operaciones.EliminaRegistro(txtId.Text)
        CargarDatosEnGridView()
    End Sub

    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.txtNombre.Text = " "
        Me.txtTelefono.Text = " "
        Me.txtProfesion.Text = " "
        Me.txtDireccion.Text = " "
    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim nuevoId As Integer = Integer.Parse(txtId.Text)
        Dim nuevoNombre As String = txtNombre.Text
        Dim nuevoTelefono As String = txtTelefono.Text
        Dim nuevoProfesion As String = txtProfesion.Text
        Dim nuevoDireccion As String = txtDireccion.Text
        If Operaciones.ActualizarRegistro(nuevoId, nuevoNombre, nuevoTelefono, nuevoProfesion, nuevoDireccion) Then
            ' Realiza cualquier otra acción necesaria después de la actualización
            CargarDatosEnGridView()
        End If
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cadenaBusqueda As String = txtId.Text ' Obtener la cadena de búsqueda desde un TextBox

        ' Llamar a la función para buscar registros
        Dim resultado As DataSet = Operaciones.BuscarRegistro(cadenaBusqueda)

        ' Verificar si se encontraron registros
        If resultado.Tables(0).Rows.Count > 0 Then
            ' Obtén datos del primer registro (puedes ajustar esto si se esperan múltiples resultados)
            Dim row As DataRow = resultado.Tables(0).Rows(0)
            txtNombre.Text = row("nombre").ToString()
            txtTelefono.Text = row("telefono").ToString()
            txtProfesion.Text = row("profesion").ToString()
            txtDireccion.Text = row("direccion").ToString()
        Else
            ' Manejar el caso en el que no se encontraron registros
            Me.txtNombre.Text = " "
            Me.txtTelefono.Text = " "
            Me.txtProfesion.Text = " "
            Me.txtDireccion.Text = " "
        End If
    End Sub
End Class
