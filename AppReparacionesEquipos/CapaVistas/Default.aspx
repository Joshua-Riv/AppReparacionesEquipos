<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AppReparacionesEquipos.CapaVistas.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio - Sistema de Reparaciones</title>

    <link rel="stylesheet" type="text/css" href="../css/Estilo.css" />
</head>

<body>

    <form id="form1" runat="server">

        <div>

            <ul>

                <li><a class="active" href="Default.aspx">Home</a></li>

                <li><a href="Usuarios.aspx">Usuarios</a></li>

                <li><a href="Equipos.aspx">Equipos</a></li>

                <li><a href="Tecnicos.aspx">Técnicos</a></li>

                <li><a href="Reparaciones.aspx">Reparaciones</a></li>

                <li><a href="Asignaciones.aspx">Asignaciones</a></li>

                <li><a href="DetallesReparacion.aspx">Detalles</a></li>

            </ul>

        </div>


        <div style="text-align:center; margin-top:50px; padding:20px;">

            <img src="../logo.png"
                 alt="Logo Sistema Reparaciones"
                 style="max-width:380px; height:auto;" />


            <h1 style="border-bottom:none; margin-top:25px;">
                Bienvenido al Sistema de Reparaciones
            </h1>


            <p style="color:#7f8c8d; font-size:16px;">

                Utilice el menú superior para navegar entre los módulos disponibles.

            </p>

        </div>


    </form>

</body>
</html>
