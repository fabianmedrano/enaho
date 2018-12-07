using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ENAHO
{
    public partial class listhogares : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RefrescarGrid(new DataHogar().ListadoHogar((Application["vivienda"] as Vivienda).Id_vivienda ));
            // ToDataTable(new DataVivienda().ListadoVivienda());
        }

        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
           dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Personas mas 6 Meses");
            dataTable.Columns.Add("Personas otro lugar");
            dataTable.Columns.Add("Personas menos 6 meses");
            for (int i = 0; i < Props.Length; i++)
            {
            }
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
        private void RefrescarGrid(List<hogarmuestra>  lista)
        {
       
            DataTable table = ToDataTable(lista);
            gb_list_hogares.DataSource = table;
            gb_list_hogares.DataBind();
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
            string valor = gb_list_hogares.SelectedRow.Cells[2].Text;

            Application["idhogar"]  = gb_list_hogares.SelectedRow.Cells[2].Text;

            Application["hogar"] = new DataHogar().getHogar(Convert.ToInt32(gb_list_hogares.SelectedRow.Cells[2].Text));

            Response.Redirect("modificarhogar.aspx");
            Console.WriteLine(valor);

            string script = "alert('" + valor + "')";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
        }

        protected void gb_list_viviendas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            int index = Convert.ToInt32(e.RowIndex);
            string valor = gb_list_hogares.Rows[index].Cells[2].Text;
            new DataHogar().eliminar(Convert.ToInt32(gb_list_hogares.Rows[index].Cells[2].Text));
            Console.WriteLine(valor);
            string script = "alert('eliminando " + valor + "')";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            Response.Redirect("listhogares.aspx");
        }

    }
}