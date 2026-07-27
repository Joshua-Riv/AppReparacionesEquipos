<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetallesReparacion.aspx.cs" Inherits="AppReparacionesEquipos.CapaVistas.DetallesReparacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Detalle de Reparaciones</title>

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

<li><a href="Asignaciones.aspx">Asignaciones</a></li>

<li><a class="active" href="DetallesReparacion.aspx">Detalles</a></li>

</ul>

</div>

<div style="padding:20px;">

<h1>Mantenimiento Detalle Reparación</h1>

<asp:GridView
ID="GridView1"
runat="server"
AutoGenerateColumns="True">
</asp:GridView>

<br />

<asp:Label runat="server" Text="Detalle ID"></asp:Label><br />

<asp:TextBox
ID="txtDetalleID"
runat="server">
</asp:TextBox>

<br /><br />

<asp:Label runat="server" Text="Reparación ID"></asp:Label><br />

<asp:TextBox
ID="txtReparacionID"
runat="server">
</asp:TextBox>

<br /><br />

<asp:Label runat="server" Text="Descripción"></asp:Label><br />

<asp:TextBox
ID="txtDescripcion"
runat="server"
Width="400">
</asp:TextBox>

<br /><br />

<asp:Label runat="server" Text="Fecha Inicio"></asp:Label><br />

<asp:TextBox
ID="txtFechaInicio"
runat="server"
TextMode="Date">
</asp:TextBox>

<br /><br />

<asp:Label runat="server" Text="Fecha Fin"></asp:Label><br />

<asp:TextBox
ID="txtFechaFin"
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
