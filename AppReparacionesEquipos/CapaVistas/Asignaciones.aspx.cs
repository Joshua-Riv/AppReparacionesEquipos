using System;
using System.Configuration;
using System.Data.SqlClient;

namespace AppReparacionesEquipos.CapaVistas
{
    public partial class Asignaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        protected void LlenarGrid()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            SqlConnection con = new SqlConnection(bd);

            SqlCommand cmd = new SqlCommand("SELECT * FROM Asignacion", con);

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

            SqlCommand cmd = new SqlCommand("SELECT * FROM Asignacion WHERE AsignacionID=@id", con);

            cmd.Parameters.AddWithValue("@id", txtAsignacionID.Text);

            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            GridView1.DataSource = rdr;
            GridView1.DataBind();

            con.Close();
        }

        protected void IngresarAsignacion()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            SqlConnection con = new SqlConnection(bd);

            SqlCommand cmd = new SqlCommand("INSERT INTO Asignacion(ReparacionID,TecnicoID,FechaAsignacion) VALUES(@rep,@tec,@fecha)", con);

            cmd.Parameters.AddWithValue("@rep", txtReparacionID.Text);
            cmd.Parameters.AddWithValue("@tec", txtTecnicoID.Text);
            cmd.Parameters.AddWithValue("@fecha", txtFechaAsignacion.Text);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        protected void ActualizarAsignacion()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            SqlConnection con = new SqlConnection(bd);

            SqlCommand cmd = new SqlCommand("UPDATE Asignacion SET ReparacionID=@rep,TecnicoID=@tec,FechaAsignacion=@fecha WHERE AsignacionID=@id", con);

            cmd.Parameters.AddWithValue("@id", txtAsignacionID.Text);
            cmd.Parameters.AddWithValue("@rep", txtReparacionID.Text);
            cmd.Parameters.AddWithValue("@tec", txtTecnicoID.Text);
            cmd.Parameters.AddWithValue("@fecha", txtFechaAsignacion.Text);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        protected void BorrarAsignacion()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            SqlConnection con = new SqlConnection(bd);

            SqlCommand cmd = new SqlCommand("DELETE FROM Asignacion WHERE AsignacionID=@id", con);

            cmd.Parameters.AddWithValue("@id", txtAsignacionID.Text);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            IngresarAsignacion();
            LlenarGrid();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarAsignacion();
            LlenarGrid();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            BorrarAsignacion();
            LlenarGrid();
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            consultarconfiltro();
        }
    }
}