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
                // Application["PersonasHogar"] = new List<Hogar>();
                RefrescarGrid(Application["PersonasHogar"] as List<Persona>);
            }

            if (this.IsPostBack == false)
            {
                LlenarComboProvincia();
                LlenarComboCanton();
                LlenarComboDistrito();
            }
        }



        public static DataTable  ToDataTable<T>( List<T> items){
            DataTable dataTable =   new DataTable  ( typeof (T).Name);
          PropertyInfo [] Props = typeof (T).GetProperties(  BindingFlags.Public | BindingFlags.Instance);
            /*   foreach( PropertyInfo   prop   in    Props)
             {*/
            dataTable.Columns.Add("Nombre");
            dataTable.Columns.Add("6 meses");
            dataTable.Columns.Add("continuara");
            dataTable.Columns.Add("parentesco");
            dataTable.Columns.Add("sexo");
            dataTable.Columns.Add("edad");
            dataTable.Columns.Add("distrito");
            dataTable.Columns.Add("conyugal");
            dataTable.Columns.Add("seguro");
            //}
            foreach (T item in items)
            {
                var values =  new object [Props.Length];
                for (  int i = 0; i < Props.Length; i++)
                {
                    if (i == 4 ) {
                        if (Props[i].GetValue(item, null).Equals("false"))
                        {
                            values[i] = "Hombre";
                        }
                        else {
                            values[i] = "Mujer";
                        }
                    }
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

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
     
            (Application["PersonasHogar"] as List<Persona>).Add(guardarPersona());
            RefrescarGrid((Application["PersonasHogar"] as List<Persona>));
             
        }

        private Persona guardarPersona()
        {
            Persona persona = new Persona();
            persona.Nombre = tb_nombre.Text.ToString().Trim();

            persona.Mas_6_meses = Convert.ToBoolean(rb_mas_6_meses_viviendo.SelectedValue.ToString());

            persona.Continuara_viviendo = Convert.ToBoolean(rb_continuara_viviendo.SelectedValue.ToString());
            persona.Parentesco_jefe_hogar = Convert.ToInt32(ddl_parentesco.SelectedValue.ToString());
            persona.Sexo = Convert.ToBoolean(rb_sexo.SelectedValue.ToString());
            persona.Edad = Convert.ToInt32(tb_años_cumplidos.Text.ToString().Trim());
            persona.IdDistrito = Convert.ToInt32(ddl_distrito.SelectedValue.ToString());
            persona.Estado_conyugal = Convert.ToInt32(ddl_estadoConyugal.SelectedValue.ToString());
            persona.Tipo_seguro = Convert.ToInt32(ddl_tipo_seguro.SelectedValue.ToString());


            return persona;
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            new DataPersona().insertarPersonas(Application["PersonasHogar"] as List<Persona>, Convert.ToInt32(Application["idHogar"] as String));
        }

       

        protected void ddl_Provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarComboCanton();
        }
        protected void ddl_canton_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarComboDistrito();
        }

   



        private bool validar()
        {
            bool validos = false;
            
            return validos;
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

  
    }
}