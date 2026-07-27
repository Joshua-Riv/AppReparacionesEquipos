using System;
using System.Configuration;
using System.Data.SqlClient;

namespace AppReparacionesEquipos.CapaVistas
{
    public partial class DetallesReparacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        protected void LlenarGrid()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            SqlConnection con = new SqlConnection(bd);

            SqlCommand cmd = new SqlCommand("SELECT * FROM DetalleReparacion", con);

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

            SqlCommand cmd = new SqlCommand("SELECT * FROM DetalleReparacion WHERE DetalleID=@id", con);

            cmd.Parameters.AddWithValue("@id", txtDetalleID.Text);

            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            GridView1.DataSource = rdr;
            GridView1.DataBind();

            con.Close();
        }

        protected void IngresarDetalle()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            SqlConnection con = new SqlConnection(bd);

            SqlCommand cmd = new SqlCommand("INSERT INTO DetalleReparacion(ReparacionID,Descripcion,FechaInicio,FechaFin) VALUES(@rep,@des,@inicio,@fin)", con);

            cmd.Parameters.AddWithValue("@rep", txtReparacionID.Text);
            cmd.Parameters.AddWithValue("@des", txtDescripcion.Text);
            cmd.Parameters.AddWithValue("@inicio", txtFechaInicio.Text);
            cmd.Parameters.AddWithValue("@fin", txtFechaFin.Text);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        protected void ActualizarDetalle()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            SqlConnection con = new SqlConnection(bd);

            SqlCommand cmd = new SqlCommand("UPDATE DetalleReparacion SET ReparacionID=@rep,Descripcion=@des,FechaInicio=@inicio,FechaFin=@fin WHERE DetalleID=@id", con);

            cmd.Parameters.AddWithValue("@id", txtDetalleID.Text);
            cmd.Parameters.AddWithValue("@rep", txtReparacionID.Text);
            cmd.Parameters.AddWithValue("@des", txtDescripcion.Text);
            cmd.Parameters.AddWithValue("@inicio", txtFechaInicio.Text);
            cmd.Parameters.AddWithValue("@fin", txtFechaFin.Text);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        protected void BorrarDetalle()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            SqlConnection con = new SqlConnection(bd);

            SqlCommand cmd = new SqlCommand("DELETE FROM DetalleReparacion WHERE DetalleID=@id", con);

            cmd.Parameters.AddWithValue("@id", txtDetalleID.Text);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            IngresarDetalle();
            LlenarGrid();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDetalle();
            LlenarGrid();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            BorrarDetalle();
            LlenarGrid();
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            consultarconfiltro();
        }
    }
}