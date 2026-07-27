<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Equipos.aspx.cs" Inherits="AppReparacionesEquipos.CapaVistas.Equipos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Gestión de Equipos</title>

    <link rel="stylesheet" type="text/css" href="../css/Estilo.css" />

</head>

<body>

<form id="form1" runat="server">

<div>

<ul>

<li><a href="Default.aspx">Home</a></li>

<li><a href="Usuarios.aspx">Usuarios</a></li>

<li><a class="active" href="Equipos.aspx">Equipos</a></li>

<li><a href="Tecnicos.aspx">Técnicos</a></li>

<li><a href="Reparaciones.aspx">Reparaciones</a></li>

<li><a href="Asignaciones.aspx">Asignaciones</a></li>

<li><a href="DetallesReparacion.aspx">Detalles</a></li>

</ul>

</div>


<div style="padding:20px;">

<h1>Mantenimiento de Equipos</h1>

<asp:GridView
ID="GridView1"
runat="server"
AutoGenerateColumns="true">
</asp:GridView>

<br />


<asp:Label
ID="lblEquipoID"
runat="server"
Text="Equipo ID (solo para Consultar, Actualizar y Eliminar. Déjelo vacío para Guardar)">
</asp:Label>

<br />

<asp:TextBox
ID="txtEquipoID"
runat="server">
</asp:TextBox>

<br /><br />


<asp:Label
ID="lblTipoEquipo"
runat="server"
Text="Tipo de Equipo">
</asp:Label>

<br />

<asp:TextBox
ID="txtTipoEquipo"
runat="server">
</asp:TextBox>

<br /><br />


<asp:Label
ID="lblModelo"
runat="server"
Text="Modelo">
</asp:Label>

<br />

<asp:TextBox
ID="txtModelo"
runat="server">
</asp:TextBox>

<br /><br />


<asp:Label
ID="lblUsuarioID"
runat="server"
Text="Usuario ID">
</asp:Label>

<br />

<asp:TextBox
ID="txtUsuarioID"
runat="server">
</asp:TextBox>

<br /><br />


<asp:Button
ID="btnGuardar"
runat="server"
Text="Guardar"
OnClick="btnGuardar_Click" />


<asp:Button
ID="btnActualizar"
runat="server"
Text="Actualizar"
OnClick="btnActualizar_Click" />


<asp:Button
ID="btnEliminar"
runat="server"
Text="Eliminar"
OnClick="btnEliminar_Click" />


<asp:Button
ID="btnConsultar"
runat="server"
Text="Consultar"
OnClick="btnConsultar_Click" />

<br /><br />

<asp:Label
ID="lblMensaje"
runat="server"
ForeColor="Red">
</asp:Label>

</div>

</form>

</body>

</html>