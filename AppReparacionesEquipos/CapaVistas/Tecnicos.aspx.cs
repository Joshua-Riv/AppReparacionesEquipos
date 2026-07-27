using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace AppReparacionesEquipos.CapaVistas
{
    public partial class Tecnicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        protected void LlenarGrid()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand("SELECT TecnicoID AS ID, Nombre, Especialidad FROM Tecnico", con))
            {
                con.Open();

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    GridView1.DataSource = rdr;
                    GridView1.DataBind();
                }
            }
        }

        protected void consultarconfiltro()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand("SELECT TecnicoID AS ID, Nombre, Especialidad FROM Tecnico WHERE TecnicoID=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", txtTecnicoID.Text);

                con.Open();

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    GridView1.DataSource = rdr;
                    GridView1.DataBind();
                }
            }
        }

        protected void IngresarTecnico()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Tecnico (Nombre, Especialidad) VALUES (@nombre,@especialidad)", con))
            {
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@especialidad", txtEspecialidad.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        protected void ActualizarTecnico()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand("UPDATE Tecnico SET Nombre=@nombre, Especialidad=@especialidad WHERE TecnicoID=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", txtTecnicoID.Text);
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@especialidad", txtEspecialidad.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        protected void BorrarTecnico()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Tecnico WHERE TecnicoID=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", txtTecnicoID.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            IngresarTecnico();
            LlenarGrid();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarTecnico();
            LlenarGrid();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            BorrarTecnico();
            LlenarGrid();
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            consultarconfiltro();
        }
    }
}