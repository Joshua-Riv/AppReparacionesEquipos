<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="AppReparacionesEquipos.CapaVistas.Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Gestión de Usuarios</title>

    <link rel="stylesheet" type="text/css" href="../css/Estilo.css" />

</head>

<body>

<form id="form1" runat="server">

<div>

<ul>

<li><a href="Default.aspx">Home</a></li>
<li><a class="active" href="Usuarios.aspx">Usuarios</a></li>
<li><a href="Equipos.aspx">Equipos</a></li>
<li><a href="Tecnicos.aspx">Técnicos</a></li>
<li><a href="Reparaciones.aspx">Reparaciones</a></li>
<li><a href="Asignaciones.aspx">Asignaciones</a></li>
<li><a href="DetallesReparacion.aspx">Detalles</a></li>

</ul>

</div>


<div style="padding:20px;">

<h1>Mantenimiento de Usuarios</h1>


<asp:GridView ID="GridView1"
    runat="server"
    AutoGenerateColumns="true">

</asp:GridView>

<br />


<asp:Label ID="lblUsuarioID"
    runat="server"
    Text="Usuario ID (Obligatorio para Consultar, Actualizar y Eliminar)">
</asp:Label>

<br />

<asp:TextBox ID="txtUsuarioID"
    runat="server">
</asp:TextBox>

<br />
<br />


<asp:Label ID="lblNombre"
    runat="server"
    Text="Nombre">
</asp:Label>

<br />

<asp:TextBox ID="txtNombre"
    runat="server">
</asp:TextBox>

<br />
<br />


<asp:Label ID="lblCorreo"
    runat="server"
    Text="Correo Electrónico">
</asp:Label>

<br />

<asp:TextBox ID="txtCorreo"
    runat="server">
</asp:TextBox>

<br />
<br />


<asp:Label ID="lblTelefono"
    runat="server"
    Text="Teléfono">
</asp:Label>

<br />

<asp:TextBox ID="txtTelefono"
    runat="server">
</asp:TextBox>

<br />
<br />


<asp:Button ID="btnGuardar"
    runat="server"
    Text="Guardar"
    OnClick="btnGuardar_Click" />


<asp:Button ID="btnActualizar"
    runat="server"
    Text="Actualizar"
    OnClick="btnActualizar_Click" />


<asp:Button ID="btnEliminar"
    runat="server"
    Text="Eliminar"
    OnClick="btnEliminar_Click" />


<asp:Button ID="btnConsultar"
    runat="server"
    Text="Consultar"
    OnClick="btnConsultar_Click" />

<br />
<br />

<asp:Label ID="lblMensaje"
    runat="server"
    ForeColor="Red">
</asp:Label>


</div>

</form>

</body>
</html>