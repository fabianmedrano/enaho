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
            if (IsPostBack)
            {
              /*  row_especificar_tipo_vivienda.Visible = false;
                row_numero_hogares_vivienda.Visible = false;*/
            }

        }

        protected void rb_mismo_prespuesto_CheckedChanged(object sender, EventArgs e)
        {
        }

        protected void rb_tipo_vivienda_SelectedIndexChanged(object sender, EventArgs e)
        {   
        }
    }
}