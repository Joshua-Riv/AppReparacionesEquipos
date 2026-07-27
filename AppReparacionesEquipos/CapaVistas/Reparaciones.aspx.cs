using System;
using System.Configuration;
using System.Data.SqlClient;

namespace AppReparacionesEquipos.CapaVistas
{
    public partial class Reparaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        protected void LlenarGrid()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            SqlConnection con = new SqlConnection(bd);

            SqlCommand cmd = new SqlCommand(
                "SELECT ReparacionID AS ID, EquipoID AS Equipo, FechaSolicitud AS [Fecha Solicitud], Estado FROM Reparacion",
                con);

            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            GridView1.DataSource = rdr;
            GridView1.DataBind();

            con.Close();
        }

        protected void consultarconfiltro()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            SqlConnection con = new SqlConnection(bd);

            SqlCommand cmd = new SqlCommand(
                "SELECT ReparacionID AS ID, EquipoID, FechaSolicitud, Estado FROM Reparacion WHERE ReparacionID=@id",
                con);

            cmd.Parameters.AddWithValue("@id", txtReparacionID.Text);

            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            GridView1.DataSource = rdr;
            GridView1.DataBind();

            con.Close();
        }

        protected void IngresarReparacion()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            SqlConnection con = new SqlConnection(bd);

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Reparacion (EquipoID, FechaSolicitud, Estado) VALUES (@equipo,@fecha,@estado)",
                con);

            cmd.Parameters.AddWithValue("@equipo", txtEquipoID.Text);
            cmd.Parameters.AddWithValue("@fecha", txtFechaSolicitud.Text);
            cmd.Parameters.AddWithValue("@estado", txtEstado.Text);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        protected void ActualizarReparacion()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            SqlConnection con = new SqlConnection(bd);

            SqlCommand cmd = new SqlCommand(
                "UPDATE Reparacion SET EquipoID=@equipo, FechaSolicitud=@fecha, Estado=@estado WHERE ReparacionID=@id",
                con);

            cmd.Parameters.AddWithValue("@id", txtReparacionID.Text);
            cmd.Parameters.AddWithValue("@equipo", txtEquipoID.Text);
            cmd.Parameters.AddWithValue("@fecha", txtFechaSolicitud.Text);
            cmd.Parameters.AddWithValue("@estado", txtEstado.Text);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        protected void BorrarReparacion()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            SqlConnection con = new SqlConnection(bd);

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Reparacion WHERE ReparacionID=@id",
                con);

            cmd.Parameters.AddWithValue("@id", txtReparacionID.Text);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            IngresarReparacion();
            LlenarGrid();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarReparacion();
            LlenarGrid();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            BorrarReparacion();
            LlenarGrid();
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            consultarconfiltro();
        }
    }
}