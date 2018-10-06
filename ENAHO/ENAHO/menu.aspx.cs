using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ENAHO
{
    public partial class menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((Session["login"] as Usuario).Pass) && string.IsNullOrEmpty((Session["login"] as Usuario).User))
            {
                Response.Redirect("login.aspx");
            }
            else {
                usuario.InnerText = (Session["login"] as Usuario).User.ToString()  ;
              //  usuario.ToString((Session["login"] as Usuario).User.ToString()  );
            }
           // Class1 objClass = (Class1)Session["class"];
          //  Console.WriteLine((Session["login"] as Usuario).Pass);
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Response.Redirect("principalhogares.aspx");
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("principalvivienda.aspx");
         //   Response.Redirect("usuarios.aspx");
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {

        }
    }
}