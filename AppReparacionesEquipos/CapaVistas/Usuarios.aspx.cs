using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace AppReparacionesEquipos.CapaVistas
{
    public partial class Usuarios : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }



        protected void LlenarGrid()
        {
            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand(
                "SELECT UsuarioID AS ID, Nombre, CorreoElectronico AS Correo, Telefono FROM Usuario", con))
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
            using (SqlCommand cmd = new SqlCommand(
                "SELECT UsuarioID AS ID, Nombre, CorreoElectronico AS Correo, Telefono FROM Usuario WHERE UsuarioID = @id", con))
            {

                cmd.Parameters.AddWithValue("@id", txtUsuarioID.Text);

                con.Open();

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {

                    GridView1.DataSource = rdr;
                    GridView1.DataBind();

                }

            }

        }



        protected void IngresarUsuario()
        {

            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;


            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO Usuario (Nombre, CorreoElectronico, Telefono) VALUES (@nombre,@correo,@telefono)", con))
            {

                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);

                con.Open();
                cmd.ExecuteNonQuery();

            }

        }




        protected void BorrarUsuario()
        {

            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;


            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand(
                "DELETE FROM Usuario WHERE UsuarioID = @id", con))
            {

                cmd.Parameters.AddWithValue("@id", txtUsuarioID.Text);

                con.Open();
                cmd.ExecuteNonQuery();

            }

        }




        protected void ActualizarUsuario()
        {

            string bd = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;


            using (SqlConnection con = new SqlConnection(bd))
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE Usuario SET Nombre=@nombre, CorreoElectronico=@correo, Telefono=@telefono WHERE UsuarioID=@id", con))
            {

                cmd.Parameters.AddWithValue("@id", txtUsuarioID.Text);
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);


                con.Open();
                cmd.ExecuteNonQuery();

            }

        }




        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            IngresarUsuario();
            LlenarGrid();

        }



        protected void btnActualizar_Click(object sender, EventArgs e)
        {

            ActualizarUsuario();
            LlenarGrid();

        }



        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            BorrarUsuario();
            LlenarGrid();

        }



        protected void btnConsultar_Click(object sender, EventArgs e)
        {

            consultarconfiltro();

        }


    }
}