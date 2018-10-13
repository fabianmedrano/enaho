using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ENAHO
{
    public partial class principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((Session["login"] as Usuario).Pass) && string.IsNullOrEmpty((Session["login"] as Usuario).User))
            {
                Response.Redirect("login.aspx");
            }
            else
            {
               // usuario.InnerText = (Session["login"] as Usuario).User.ToString();
                //  usuario.ToString((Session["login"] as Usuario).User.ToString()  );
            }

            if (this.IsPostBack == false)
            {
                LlenarComboProvincia();
                LlenarComboCanton();
                LlenarComboDistrito();
            }
        }

        private void LlenarComboTipoVivienda()
        {

            List<Provincia> list = new List<Provincia>();
            list.Add(new Provincia(0, "k"));
            list.Add(new Provincia(1, ""));


            rb_tipo_vivienda.DataSource = list;
            rb_tipo_vivienda.DataValueField = "Id";
            rb_tipo_vivienda.DataTextField = "Nombre";
            rb_tipo_vivienda.DataBind();
        }
        private void LlenarComboProvincia()
            {
                ddl_provincia.DataSource = new ClsPcdLN().ListaProvinciaLN();
                ddl_provincia.DataValueField = "Id";
                ddl_provincia.DataTextField = "Nombre";
                ddl_provincia.DataBind();
            }
            private void LlenarComboDistrito()
            {
            // ddl es el dropdownList
                ddl_distrito.DataSource = new ClsPcdLN().ListaDistritoLN(Convert.ToInt16(ddl_canton.SelectedValue));
                ddl_distrito.DataValueField = "DisIDDistrito";
                ddl_distrito.DataTextField = "DisNomDistrito";
                ddl_distrito.DataBind();
            }
            private void LlenarComboCanton()
            {
            // ddl es el dropdownList
                ddl_canton.DataSource = new ClsPcdLN().ListaCantonLN(Convert.ToInt16(ddl_provincia.SelectedValue));
                ddl_canton.DataValueField = "CanIDCanton";
                ddl_canton.DataTextField = "CanNomCanton";
                ddl_canton.DataBind();
            }
            protected void ddl_Provincia_SelectedIndexChanged(object sender, EventArgs e)
            {
            LlenarComboCanton();
        }
            protected void ddl_canton_SelectedIndexChanged(object sender, EventArgs e)
          {
            LlenarComboDistrito();
        }

        protected void btn_Guardar_vivienda(object sender, EventArgs e)
        {


        }
        public bool ValidarCampos()

        {
            bool validos = true;
            
            if (tb_direccion.Text.ToString().Trim().Equals("")||
                tb_telefono.Text.ToString().Trim().Equals("") ||
                tb_cantidad_personas_vivienda.Text.ToString().Trim().Equals("") ||
                tb_cuartos_dormir.Text.ToString().Trim().Equals("") ||
                tb_aposentos.Text.ToString().Trim().Equals("")
                )
            {
                Console.WriteLine("faltan campos de texto que llenar");
            }

            return validos;

        }
    }
}