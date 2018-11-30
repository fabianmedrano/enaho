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
    public partial class principalpersonas : System.Web.UI.Page
    {
     

        protected void Page_Load(object sender, EventArgs e){
            if (!IsPostBack)
            {
                //  if(Session["HogaresVivienda"] != null ) {
                // Application["HogaresVivienda"] = new List<Hogar>();
                RefrescarGrid(Application["PersonasHogar"] as List<Persona>);
            }
        }



        public static DataTable  ToDataTable<T>( List<T> items){
            DataTable dataTable =   new DataTable  ( typeof (T).Name);
            PropertyInfo [] Props = typeof (T).GetProperties(  BindingFlags.Public | BindingFlags.Instance);
            foreach( PropertyInfo   prop   in    Props)
            {
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values =  new object [Props.Length];
                for (  int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item,  null );
                }
                dataTable.Rows.Add(values);
            }
            return
                dataTable;
        }



        private  void  RefrescarGrid(List<Persona> lista) {
            DataTable table = ToDataTable(lista);
            gb_personas.DataSource = table;
            gb_personas.DataBind();
            table =  null  ;
        }
        


        protected void btn_siguiente_hogares(object sender, EventArgs e)
        {
            (Application["PersonasHogar"] as List<Persona>).Add(guardarPersona());
        }



        protected void btn_terminar(object sender, EventArgs e)
        {
            new DataPersona().insertarPersonas( Application["PersonasHogar"] as List<Persona> , Convert.ToInt32(Application["idHogar"] as String));
/*
            if (new DataPersona().insertarPersonas(guardarPersona(), Convert.ToInt32(Application["idHogar"] as String)))
            {
                string script = "alert('Datos guardados exitosamente')"; ;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                Response.Redirect("principalpersonas.aspx");
            }
            else
            {
                string script = "alert('Error al guardar los datos')"; ;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            } */
        }


        protected void ddl_Provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LlenarComboCanton();
        }
        protected void ddl_canton_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LlenarComboDistrito();
        }

        private Persona guardarPersona()
        {
            Persona persona = new Persona();
            
            return persona;
        }



        private bool validar()
        {
            bool validos = false;
            
            return validos;
        }


    }
}