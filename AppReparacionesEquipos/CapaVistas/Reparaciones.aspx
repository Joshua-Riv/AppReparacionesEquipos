<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reparaciones.aspx.cs" Inherits="AppReparacionesEquipos.CapaVistas.Reparaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Gestión de Reparaciones</title>

    <link rel="stylesheet" type="text/css" href="../css/Estilo.css" />

</head>

<body>

<form id="form1" runat="server">

<div>

<ul>

<li><a href="Default.aspx">Home</a></li>

<li><a href="Usuarios.aspx">Usuarios</a></li>

<li><a href="Equipos.aspx">Equipos</a></li>

<li><a href="Tecnicos.aspx">Técnicos</a></li>

<li><a class="active" href="Reparaciones.aspx">Reparaciones</a></li>

<li><a href="Asignaciones.aspx">Asignaciones</a></li>

<li><a href="DetallesReparacion.aspx">Detalles</a></li>

</ul>

</div>

<div style="padding:20px;">

<h1>Mantenimiento de Reparaciones</h1>

<asp:GridView
ID="GridView1"
runat="server"
AutoGenerateColumns="true">
</asp:GridView>

<br />

<asp:Label
ID="Label1"
runat="server"
Text="Reparación ID (solo para Consultar, Actualizar y Eliminar. Déjelo vacío para Guardar)">
</asp:Label>

<br />

<asp:TextBox
ID="txtReparacionID"
runat="server">
</asp:TextBox>

<br /><br />

<asp:Label
ID="Label2"
runat="server"
Text="Equipo ID">
</asp:Label>

<br />

<asp:TextBox
ID="txtEquipoID"
runat="server">
</asp:TextBox>

<br /><br />

<asp:Label
ID="Label3"
runat="server"
Text="Fecha Solicitud">
</asp:Label>

<br />

<asp:TextBox
ID="txtFechaSolicitud"
runat="server"
TextMode="Date">
</asp:TextBox>

<br /><br />

<asp:Label
ID="Label4"
runat="server"
Text="Estado">
</asp:Label>

<br />

<asp:TextBox
ID="txtEstado"
runat="server">
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
