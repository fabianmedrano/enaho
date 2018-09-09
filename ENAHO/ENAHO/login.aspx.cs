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
            try {
                if (string.IsNullOrEmpty(tb_usuario.Text) || string.IsNullOrEmpty(tb_pass.Text)) {
                    l_login.Text = "Debe ingresar todos datos";
                    l_login.Visible = true;
                }
                else {
                    if (ValidarUsuario(tb_usuario.Text.ToString(), tb_pass.Text.ToString())) {
                        Session["Login"] = tb_usuario.Text.ToString();
                        Response.Redirect("menu.aspx");
                    } else {
                        l_login.Text = "Error en los datos";
                        l_login.Visible = true;
                    }
                }
            }catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }


        public Boolean ValidarUsuario(string usuario, string pass)
        {

            Boolean encontrado = false;
            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
            try {
                command.CommandText = "p_login";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@user", usuario));
                command.Parameters.Add(new SqlParameter("@pass", pass));
                command.Connection.Open();
                SqlDataReader RESULTADO = ((SqlDataReader)command.ExecuteReader());
                if (RESULTADO.Read()) {
                    encontrado = true;
//
                }
            }
            catch (Exception ex){
                throw ex;
            } finally {
                if (command.Connection.State ==  System.Data.ConnectionState.Open) {
                    command.Connection.Close();
                }
                command.Dispose();
            }
            return encontrado;
        }
    }
}