using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ENAHO
{
    public partial class principalpersonas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddl_Provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LlenarComboCanton();
        }
        protected void ddl_canton_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LlenarComboDistrito();
        }
    }
}