using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using Entidad;

namespace ENAHO
{
    public partial class listvivienda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Application["vivienda"] = new Vivienda();
            RefrescarGrid(new DataVivienda().ListadoVivienda());
           // ToDataTable(new DataVivienda().ListadoVivienda());
        }

        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
           /* foreach (PropertyInfo prop in Props)
            {*/
                //Setting column names as Property names
                dataTable.Columns.Add("Vivienda");
                dataTable.Columns.Add("Distrito");
                dataTable.Columns.Add("Direccion");
                dataTable.Columns.Add("Telefono");

                dataTable.Columns.Add("Modulo de gasto");
                dataTable.Columns.Add("Personas en la vivienda");

                dataTable.Columns.Add("hogares en la vivienda");

                dataTable.Columns.Add("Tipo de vivienda");

            //   }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return
             dataTable;
        }
        private void RefrescarGrid(List<viviendamuestra> listaVivienda)
        {
            DataTable table = ToDataTable(listaVivienda);
            gb_list_viviendas.DataSource = table;
            gb_list_viviendas.DataBind();
            table = null;
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            
 
          
             DataTable dt = (DataTable)Session["data"];
            dt.Rows.RemoveAt(e.RowIndex);
            //new Da
            

          //  (gb_list_viviendas.DataSource  )= dt;
            //  gb_list_viviendas.DataBind();
        }

        protected void gb_list_viviendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = gb_list_viviendas.SelectedRow.Cells[2].Text;


            Application["vivienda"] =  new DataVivienda().getVivienda( Convert.ToInt32(gb_list_viviendas.SelectedRow.Cells[2].Text));
            Response.Redirect("modificarvivienda.aspx");
            Console.WriteLine(valor);

            string script = "alert('"+ valor + "')"; 
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
        }
        
        protected void gb_list_viviendas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            int index = Convert.ToInt32(e.RowIndex);
            string valor = gb_list_viviendas.Rows[index].Cells[2].Text;
            new DataVivienda().eliminar(Convert.ToInt32(gb_list_viviendas.Rows[index].Cells[2].Text));
            Console.WriteLine(valor);
            string script = "alert('eliminando " + valor + "')";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            Response.Redirect("listvivienda.aspx");
        }

  
    }
}