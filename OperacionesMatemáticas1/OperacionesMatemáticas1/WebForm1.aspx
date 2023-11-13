<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="OperacionesMatemáticas1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> CRUD WEB SERVICE </title>
    <style>
        h1{
            text-align: right;
            font-size: 25px;
            font-family: Arial, Arial, Helvetica, sans-serif, sans-serif;
            font-weight: Helvetica;
        }
        h2{
            font-size: 35px;
            font-family: 'Verdana';
            font-weight:Verdana;
            height: 27px;
        }
        h3{
            font-size:20px;
            font-family: 'Verdana';
            font-weight:Verdana;
        }
        h4{
            font-size:10px;
            font-family: 'Verdana';
            font-weight:Verdana;
        }
        header,section,footer,aside,nav,article,hgroup{
            border: 1px solid rgb(0,0,0);
            display:block;
        }
        body{
            text-align:center;
        }
        .agrupar{
            background:rgb(235,238,240);
            width:900px;
            margin:auto;
            margin-top:15px;
            margin-bottom:15px;
            padding:10px;
        }
        .cabeza{
            text-align:left;
            background:#31373d;
            border:solid rgb(0,0,0);
            padding:15px;
        }
        .cabeza h1{
            text-align:center;            
            color:skyblue;
            float:center;
            width: 621px;
            margin-left: 157px;
        }
        .seccion{
            margin: 20px;
            width: 80%;
            border: 1px solid rgb(0,0,0);
            float: left;
            background: lightblue;
        }
        .columna{
            background:lightblue;
            width:35%;
            float:left;
            margin: 20px 0px;
        }
        .columna blockquote{
            padding: 10px;
            background:lightblue;
            margin-bottom:10px;
        }
        .pie{
            color:rgb(0,0,0);
            clear:both;
            padding:15px;
            background:#ffffff;
        }
        article{
            background: rgb(192,205,216);
            border: 1px solid gray;
            padding: 10px;
            margin-bottom:0px;
            font-size:18px;
            font-weight:Helvetica;
            height: 980px;
            width: 834px;
        }
        .left-image {
            float: left;
            margin-right: 10px; /* Espacio entre la imagen izquierda y el contenido del artículo */
            width: 190px;
        }

        .right-image {
            float: right;
            margin-left: 10px; /* Espacio entre la imagen derecha y el contenido del artículo */
            width: 320px;
        }
    </style>
</head>

<body>
    <form id="WebForm1" runat="server">
    <div class="agrupar">
    <header class ="cabeza">        
        <h1><b> CRUD CON WEB SERVICE </b><br/>
            Elaborado por: Ryan Russell Laura Chambilla
        </h1>
    &nbsp;</header>
    <section class="seccion">
        <article>
            <hgroup>
                <h2>Bienvenidos a mi CRUD WEB SERVICE</h2>
               <p>Este CRUD Web Service ha sido implementado con Visual Studio, ASP.NET y con el gestor de Base de Datos MySql WorkBench.   
               </p>
        <img class="left-image" src="img/logo_sistemas.png" alt="logo_sistemas">
        <img class="right-image" src="img/der.png" alt="der.png">
        <div>
            </hgroup>
            <br />
            <b>
            <br />
            Ingrese datos del profesional:</b><br />
            <br />
            Nombre: 
            <asp:TextBox ID="txtNombre" runat="server" style="margin-left: 9px" Width="147px"></asp:TextBox>
            <br />
            Telefono:
            <asp:TextBox ID="txtTelefono" runat="server" style="margin-left: 5px" Width="148px"></asp:TextBox>
            <br />
            Profesión:
            <asp:TextBox ID="txtProfesion" runat="server" style="margin-left: 5px" Width="148px"></asp:TextBox>
            <br />
            Dirección:
            <asp:TextBox ID="txtDireccion" runat="server" style="margin-left: 5px" Width="148px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" BackColor="#000066" ForeColor="White" Height="27px" style="margin-left: 0px" Width="76px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;<asp:Button ID="btnActualizar" runat="server" Text="Actualizar" BackColor="#000066" ForeColor="White" Height="27px" style="margin-left: 0px" Width="76px"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp; &nbsp;<asp:Button ID="btnEliminar" runat="server" Text="Eliminar" BackColor="#000066" ForeColor="White" Height="27px" style="margin-left: 0px" Width="76px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnNuevo" runat="server" Text="Limpiar" BackColor="#000066" ForeColor="White" Height="27px" style="margin-left: 0px" Width="76px" />
&nbsp;&nbsp;
            <br />
            <br />     
              <b>Ingrese el ID de la persona a buscar y/o eliminar:</b>
             <asp:TextBox ID="txtId" runat="server" style="margin-left: 9px" Width="61px"></asp:TextBox>
            &nbsp; 
             <asp:Button ID="btnBuscar" runat="server" Text="Buscar" BackColor="#000066" ForeColor="White" Height="27px" Width="76px" />
            <br /> 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />                  
             <br />
               <asp:GridView ID="GridView1" runat="server" Width="803px" BackColor="#CCCCCC" ForeColor="Black">
            </asp:GridView>
               <br />                  
             <br /> 
             <br />                  
             <br />
             <br />                  
             <br />
             <br />                  
             <br />                             
             <br />
    <hgroup>
        <h3>Instrucciones</h3>
        <p> La base de datos "nomina" ubicado en el archivo sql que se adjunta, ha sido creado con el gestor de base de datos MySql WorkBench, porfavor utilizar su contraseña y/o usuario para una correcta conexión.            
        </p>
        <center>©2023 RyanRussell369</center>
    </hgroup>
    </div>  
    </article>
     </section>   
    </div>
    </form>
</body>
</html>
