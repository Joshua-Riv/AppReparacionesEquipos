using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace AppReparacionesEquipos.CapaVistas
{
    public partial class Equipos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        protected void LlenarGrid()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand("SELECT EquipoID AS ID, TipoEquipo AS [Tipo Equipo], Modelo, UsuarioID AS [Usuario ID] FROM Equipo", con))
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
            using (SqlCommand cmd = new SqlCommand("SELECT EquipoID AS ID, TipoEquipo AS [Tipo Equipo], Modelo, UsuarioID AS [Usuario ID] FROM Equipo WHERE EquipoID=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", txtEquipoID.Text);

                con.Open();

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    GridView1.DataSource = rdr;
                    GridView1.DataBind();
                }
            }
        }

        protected void IngresarEquipo()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Equipo (TipoEquipo, Modelo, UsuarioID) VALUES (@tipo,@modelo,@usuario)", con))
            {
                cmd.Parameters.AddWithValue("@tipo", txtTipoEquipo.Text);
                cmd.Parameters.AddWithValue("@modelo", txtModelo.Text);
                cmd.Parameters.AddWithValue("@usuario", txtUsuarioID.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        protected void ActualizarEquipo()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand("UPDATE Equipo SET TipoEquipo=@tipo, Modelo=@modelo, UsuarioID=@usuario WHERE EquipoID=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", txtEquipoID.Text);
                cmd.Parameters.AddWithValue("@tipo", txtTipoEquipo.Text);
                cmd.Parameters.AddWithValue("@modelo", txtModelo.Text);
                cmd.Parameters.AddWithValue("@usuario", txtUsuarioID.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        protected void BorrarEquipo()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Equipo WHERE EquipoID=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", txtEquipoID.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            IngresarEquipo();
            LlenarGrid();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarEquipo();
            LlenarGrid();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            BorrarEquipo();
            LlenarGrid();
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            consultarconfiltro();
        }
    }
}