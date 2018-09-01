using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Datos;

namespace ENAHO
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            l_login.Visible = false;
        }

        protected void bt_login_Click(object sender, EventArgs e)
        {

            if (true) {

            }
            else {
                /// l_login.Visible = true;
            }
            l_login.Visible = true;
        }


        public void ValidarUsuario(string clave, string nombre)
        {
            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
            try
            {
                command.CommandText = "p_login";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@nombreEmpleado", nombre)
                );
                command.Parameters.Add(new SqlParameter("@Clave", clave));
                command.Connection.Open();
                SqlDataReader RESULTADO = ((SqlDataReader)command.ExecuteReader());
                if (RESULTADO.Read())
                {
                   
                   Convert.ToInt16(RESULTADO["IdEmpleado"]);
          RESULTADO["NombreEmpleado "].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (command.Connection.State ==
                System.Data.ConnectionState.Open)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        }
    }
}