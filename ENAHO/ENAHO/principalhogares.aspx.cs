using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidad;
using Datos;
using System.Data;
using System.Reflection;

namespace ENAHO
{
    public partial class principalhogares : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
             //   if(Session["HogaresVivienda"] != null ) {
                  
                   // Application["HogaresVivienda"] = new List<Hogar>();
                //    RefrescarGrid(Application["HogaresVivienda"] as List<Hogar>);
                 }
  
            }
        
    /*    public static DataTable  ToDataTable<T>( List<T> items)
        {
            DataTable dataTable =   new DataTable  ( typeof (T).Name);
            //Get all the properties
            PropertyInfo [] Props = typeof (T).GetProperties(  BindingFlags.Public | BindingFlags.Instance);
            foreach( PropertyInfo   prop   in    Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values =  new object [Props.Length];
                for (  int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item,  null );
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return
             dataTable;
        }
        private  void  RefrescarGrid(List   < Hogar> listaDetalle) {
            DataTable table = ToDataTable(listaDetalle);
            gb_hogares.DataSource = table;
            gb_hogares.DataBind();
            table =  null  ;
        }
      
    */
        protected void btn_siguiente_hogares(object sender, EventArgs e)
        {


            /*
                        if (new DataHogar().insertarHogar(guardarHogar(), Convert.ToInt32(Application["idVivienda"] as String)))
                        {
                            string script = "alert('Datos guardados exitosamente')"; ;
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);

                            Response.Redirect("principalpersonas.aspx");


                        }
                        else {
                            string script = "alert('Error al guardar los datos')"; ;
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                        }
                         */
            //   (Application["HogaresVivienda"] as List<Hogar>).Add(guardarHogar());
            //  RefrescarGrid((Application["HogaresVivienda"] as List<Hogar>));
            // Response.Redirect("/principalhogares.aspx");
            //  int id = Application["idVivienda"] as int32;

            //   DataHogar dh = new DataHogar();
            //dh.insertarHogares
        }
        protected void btn_terminar(object sender, EventArgs e)
        {

            Application["idhogar"] = "" + new DataHogar().insertarHogar(guardarHogar(),20/* Convert.ToInt32(Application["idVivienda"] as String)*/);


            if (!(Application["idhogar"] as string).Equals("0"))
            {
                string script = "alert('Datos guardados exitosamente')"; ;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                Response.Redirect("principalpersonas.aspx");
            }
            else
            {
                string script = "alert('Error al guardar los datos')"; ;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
            //   new DataHogar().insertarHogares(Application["HogaresVivienda"] as List<Hogar>,4);
            //  new DataHogar().insertarHogares(Application["HogaresVivienda"] as List<Hogar>, Convert.ToInt32(Application["idVivienda"] as String));

        }
        private Hogar guardarHogar()
        {
            Hogar hogar = new Hogar();
            hogar.Personas_mas_seis_meses = Convert.ToBoolean(rb_6_aqui_vivienda.SelectedValue.ToString());
            if (!hogar.Personas_mas_seis_meses)
            {
                hogar.Personas_otro_lugar_donde_vivir = Convert.ToBoolean(rb_personas_otro_lugar_vivir.SelectedValue.ToString());
                if (hogar.Personas_otro_lugar_donde_vivir)
                {
                    hogar.Cantidad_personas_otro_lugar = Convert.ToInt32(tb_numero_personas_otra_vivienda.Text.ToString());
                }
                hogar.Personas_otra_partes = Convert.ToBoolean(rb_alguna_personas_viviendo_otra_parte.Text.ToString());
                if (hogar.Personas_otra_partes)
                {
                    hogar.Personas_asentes_menos_seis_meses = Convert.ToBoolean(rb_personas_ausentes_menos_6_meses.Text.ToString());
                    if (hogar.Personas_asentes_menos_seis_meses)
                    {
                        hogar.Numero_personas_asentes_menos_seis_meses = Convert.ToInt32(tb_personas_ausentes_menos_6_meses.Text.ToString());
                    }
                    else
                    {
                        hogar.Servicio_domestico_en_casa = Convert.ToBoolean(rb_servicio_domestico.Text.ToString());
                        if (hogar.Servicio_domestico_en_casa)
                        {
                            // falta cunto servivio domestico
                        }
                        hogar.Alquila_cuarto = Convert.ToBoolean(rb_alquilan_carto.Text.ToString());
                        if (hogar.Alquila_cuarto)
                        {
                            hogar.Numero_personas_alquila_cuarto = Convert.ToInt32(tb_cuartos_alquila.Text.ToString());
                        }
                    }
                    //----------<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                    //boono de vivienda

                    hogar.Recibio_bono = Convert.ToBoolean(rb_resibido_bono.Text.ToString());
                    if (hogar.Recibio_bono)
                    {

                        hogar.Ano_recibir = Convert.ToInt32(tb_ano_bono.Text.ToString());
                        hogar.Tipo_bono = Convert.ToInt32(rb_tipo_bono.Text.ToString());
              
                    }
                    else
                    {
                        hogar.Solocitud_bono = Convert.ToBoolean(rb_solicitud_bono.Text.ToString());
                        if (hogar.Solocitud_bono)
                        {
                            hogar.Razon_no_recibir = Convert.ToInt32(rb_razon_no_recibir.Text.ToString());
                            if (hogar.Razon_no_recibir.Equals("OTRO")) {
                                hogar.Otro_razon_no_recibir = tb_especifique_no_resibir.Text.ToString();
                            }
                        }
                        else
                        {

                            hogar.Razon_no_solicitar = Convert.ToInt32(rb_razon_no_solicitar.Text.ToString());
                            if (hogar.Razon_no_solicitar.Equals("OTRO")) {
                                hogar.Otro_razon_no_solicitar = tb_razon_no_solicitar.Text.ToString();
                            }
                        }
                    }
                }
            }

            return hogar;
        }

        private bool validar()
        {
            bool validos = false;

            if (!Convert.ToBoolean(rb_6_aqui_vivienda.SelectedValue.ToString()))
            {
                if (Convert.ToBoolean(rb_personas_otro_lugar_vivir.SelectedValue.ToString()))
                {
                    try
                    {
                        Convert.ToInt32(tb_numero_personas_otra_vivienda.Text.ToString().Trim());
                    }
                    catch (Exception e) {
                        return false;
                    }
                }

                if (Convert.ToBoolean(rb_alguna_personas_viviendo_otra_parte.Text.ToString()))
                {
                    if (Convert.ToBoolean(rb_personas_ausentes_menos_6_meses.Text.ToString()))
                    {
                        try
                        {
                            Convert.ToInt32(tb_personas_ausentes_menos_6_meses.Text.ToString());
                        }
                        catch (Exception e) {
                            return false;
                        }

                    }
                    else
                    {
                        if (Convert.ToBoolean(rb_servicio_domestico.Text.ToString()))
                        {
                            // falta cunto servivio domestico
                        }
                        if (Convert.ToBoolean(rb_alquilan_carto.Text.ToString()))
                        {
                            try
                            {
                                Convert.ToInt32(tb_cuartos_alquila.Text.ToString().Trim());
                            }
                            catch (Exception e) {
                                return false;
                            }

                        }
                    }
                    //----------<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                    //boono de vivienda
                    if (Convert.ToBoolean(rb_resibido_bono.Text.ToString()))
                    {
                        try
                        {
                            Convert.ToInt32(tb_ano_bono.Text.ToString());

                            try
                            {
                                Convert.ToInt32(rb_tipo_bono.Text.ToString());
                                return true;
                            }
                            catch (Exception e)
                            {
                                return false;
                            }

                        }
                        catch (Exception e)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (Convert.ToBoolean(rb_solicitud_bono.Text.ToString()))
                        {
                            try
                            {
                                Convert.ToInt32(rb_razon_no_recibir.Text.ToString());
                                return true;
                            }
                            catch (Exception e)
                            {
                                if (tb_especifique_no_resibir.Text.ToString().Trim().Equals(""))
                                {
                                    return false;
                                }
                            }
                        }
                        else
                        {
                            try
                            {
                                Convert.ToInt32(rb_razon_no_solicitar.Text.ToString());
                                return true;
                            }
                            catch (Exception e)
                            {
                                if (tb_razon_no_solicitar.Text.ToString().Trim().Equals(""))
                                {
                                    return false;
                                }
                                else {
                                    return true;
                                }
                            }
                        }

                    }
                }
            }
            return validos;
        }


    

    }
}