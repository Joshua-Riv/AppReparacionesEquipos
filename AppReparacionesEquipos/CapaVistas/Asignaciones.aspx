<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Asignaciones.aspx.cs" Inherits="AppReparacionesEquipos.CapaVistas.Asignaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Asignaciones</title>
    <link href="../css/Estilo.css" rel="stylesheet" />
</head>

<body>

<form id="form1" runat="server">

<div>

<ul>

<li><a href="Default.aspx">Home</a></li>
<li><a href="Usuarios.aspx">Usuarios</a></li>
<li><a href="Equipos.aspx">Equipos</a></li>
<li><a href="Tecnicos.aspx">Técnicos</a></li>
<li><a href="Reparaciones.aspx">Reparaciones</a></li>
<li><a class="active" href="Asignaciones.aspx">Asignaciones</a></li>
<li><a href="DetallesReparacion.aspx">Detalles</a></li>

</ul>

</div>

<div style="padding:20px;">

<h1>Mantenimiento de Asignaciones</h1>

<asp:GridView
ID="GridView1"
runat="server"
AutoGenerateColumns="True">
</asp:GridView>

<br />

<asp:Label runat="server" Text="Asignación ID (solo para Consultar, Actualizar y Eliminar. Déjelo vacío para Guardar)"></asp:Label><br />

<asp:TextBox
ID="txtAsignacionID"
runat="server">
</asp:TextBox>

<br /><br />

<asp:Label runat="server" Text="Reparación ID"></asp:Label><br />

<asp:TextBox
ID="txtReparacionID"
runat="server">
</asp:TextBox>

<br /><br />

<asp:Label runat="server" Text="Técnico ID"></asp:Label><br />

<asp:TextBox
ID="txtTecnicoID"
runat="server">
</asp:TextBox>

<br /><br />

<asp:Label runat="server" Text="Fecha Asignación"></asp:Label><br />

<asp:TextBox
ID="txtFechaAsignacion"
runat="server"
TextMode="Date">
</asp:TextBox>

<br /><br />

<asp:Button
ID="btnGuardar"
runat="server"
Text="Guardar"
OnClick="btnGuardar_Click"/>

<asp:Button
ID="btnActualizar"
runat="server"
Text="Actualizar"
OnClick="btnActualizar_Click"/>

<asp:Button
ID="btnEliminar"
runat="server"
Text="Eliminar"
OnClick="btnEliminar_Click"/>

<asp:Button
ID="btnConsultar"
runat="server"
Text="Consultar"
OnClick="btnConsultar_Click"/>

</div>

</form>

</body>

</html>
