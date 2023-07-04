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
    public partial class modificarvi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarCampos(Application["vivienda"] as Vivienda);


            if (this.IsPostBack == false)
            {
                llenarCampos(Application["vivienda"] as Vivienda);
                LlenarComboProvincia();
                LlenarComboCanton();
                LlenarComboDistrito();
            }
        }


        public void llenarCampos(Vivienda vivienda)

        {

            //    string script = "alert('";

            Application["idVivienda"] = vivienda.Id_vivienda;

            tb_direccion.Text = vivienda.Direccion;
            tb_telefono.Text = vivienda.Telefono;
            tb_cantidad_personas_vivienda.Text = (vivienda.Numero_personas_vivienda).ToString();
            tb_cuartos_dormir.Text = vivienda.Cuartos_exclusivos_dormir.ToString();
            tb_aposentos.Text = vivienda.Cantidad_aposentos.ToString();



            rb_mgch.SelectedValue = vivienda.Modulo_GCH1.ToString();

            rb_cielo_raso.SelectedValue = vivienda.Cielo_raso.ToString();
            rb_sobre_pilotes.SelectedValue = vivienda.Sobre_pilotes.ToString();
            rb_estado_paredes.SelectedValue = vivienda.Estado_paredes.ToString();
            rb_estado_techo.SelectedValue = vivienda.Estado_techo.ToString();
            rb_estado_piso.SelectedValue = vivienda.Estado_piso.ToString();
            rb_abastecimiento_agua.SelectedValue = vivienda.Abastecimiento_agua.ToString();
            rb_cantidad_metros.SelectedValue = vivienda.Metros_cuadrados.ToString();


            
            
       
            rb_servicio_sanitario_es.SelectedValue = vivienda.Servicio_sanitario_es.ToString();
            rb_uso_bano.SelectedValue = vivienda.Uso_bano.ToString();


        



            tb_numero_hogares_vivienda.Text = vivienda.Numero_hogares_vivienda.ToString();


                    rb_tipo_vivienda.SelectedValue = vivienda.Tipo_vivienda.ToString();

                    tb_espeficar_tipo_vivienda.Text = vivienda.Otro_tipo_vivienda.ToString();

                    /////////////////////////////////////////////////
                    ///
            
                    rb_esta_vivienda.SelectedValue = vivienda.Esta_vivienda.ToString();
                    
            
                   
                    tb_mensualidad.Text = vivienda.Mesulaidad_vivienda.ToString();
              
                    

                    rb_material_predominante_vivienda.SelectedValue = vivienda.Material_paredes.ToString();
                    tb_material__predominante_vivienda.Text = vivienda.Otro_material_paredes.ToString();


                    rb_material__predominante_techo.SelectedValue = vivienda.Material_techos.ToString();
          
                    tb_material__predominante_techo.Text = vivienda.Otro_material_techo.ToString();
          



                    rb_material__predominante_piso.SelectedValue = vivienda.Material_piso.ToString();
                    tb_material__predominante_piso.Text = vivienda.Otro_material_piso.ToString();
           

                    rb_origen_agua_consumo.SelectedValue = vivienda.Origen_agua_consumo.ToString();
                    tb_origen_agua_consumo.Text = vivienda.Otro_origen_agua_consumo.ToString();
           


                    rb_servicio_sanitario.SelectedValue = vivienda.Servicio_sanitario.ToString();
                    tb_servicio_sanitario.Text = vivienda.Otro_servicio_sanitario.ToString();
           

                     

                       rb_luz_electrica.SelectedValue = vivienda.Fuente_electricidad.ToString();
           tb_luz_electrica.Text = vivienda.Otro_fuente_eletricidad.ToString();
             
                       rb_energia_cosinar.SelectedValue = vivienda.Energia_cosina.ToString();
         tb_energia_cosinar.Text = vivienda.Otro_energia_cosina.ToString();
            
     

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

        protected void rb_tipo_vivienda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
        protected void btn_Guardar_vivienda(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Guardar_datos();
                string script = "alert('Datos guardados exitosamente')"; ;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                Response.Redirect("listvivienda.aspx");
            }
            else
            {
                string script = "alert('faltan campos que llenar')"; ;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            }
            // Response.Redirect("principalhogares.aspx");

        }

        public bool Guardar_datos()
        {

            Vivienda vivienda = new Vivienda();

            if (Page.IsValid)
            {
                Console.WriteLine("Your reservation has been processed.");
            }
            else
            {
                Console.WriteLine("Your reservation has been as.");
            }
            vivienda.DisIDDistrito1 = Convert.ToInt32(ddl_distrito.SelectedValue.ToString());
            vivienda.Direccion = tb_direccion.Text.ToString().Trim();
            vivienda.Telefono = tb_telefono.Text.ToString().Trim();
            vivienda.Modulo_GCH1 = Convert.ToBoolean(rb_mgch.SelectedValue.ToString());

            vivienda.Numero_personas_vivienda = Convert.ToInt16(tb_cantidad_personas_vivienda.Text.ToString().Trim());
            if (rb_mismo_prespuesto.SelectedValue.Equals("false"))
            {

                vivienda.Numero_hogares_vivienda = Convert.ToInt16(tb_numero_hogares_vivienda.Text.ToString().Trim());
            }


            try
            {
                vivienda.Tipo_vivienda = Convert.ToInt16(rb_tipo_vivienda.SelectedValue.ToString());//rb_tipo_vivienda
            }
            catch (FormatException ex)
            {
                vivienda.Otro_tipo_vivienda = tb_espeficar_tipo_vivienda.Text.ToString().Trim();
                Console.WriteLine(ex.Message);
            }
            try
            {
                vivienda.Esta_vivienda = Convert.ToInt16(rb_esta_vivienda.SelectedValue.ToString());
                if (vivienda.Esta_vivienda == 2 || vivienda.Esta_vivienda == 3)
                {
                    vivienda.Mesulaidad_vivienda = float.Parse(tb_mensualidad.Text.ToString().Trim());
                }
                if (vivienda.Esta_vivienda == 2 || vivienda.Esta_vivienda == 1)
                {
                    vivienda.Pagaria_mesulaidad = float.Parse(tb_pagaria_mesualidad.Text.ToString().Trim());
                    //  vivienda.Pagaria_mesulaidad = tb_pagaria_mesualidad.Text.ToString().Trim();
                }
            }
            catch (FormatException ex)
            {
                //    vivienda.Pagaria_mesulaidad = float.Parse(tb_pagaria_mesualidad.Text.ToString().Trim());
                Console.WriteLine(ex.Message);
            }

            try
            {
                vivienda.Material_paredes = Convert.ToInt16(rb_material_predominante_vivienda.SelectedValue.ToString());
            }
            catch (FormatException ex)
            {
                vivienda.Otro_material_paredes = tb_material__predominante_vivienda.Text.ToString().Trim();
                Console.WriteLine(ex.Message);
            }

            try
            {

                vivienda.Material_techos = Convert.ToInt16(rb_material__predominante_techo.SelectedValue.ToString());
            }
            catch (FormatException ex)
            {

                vivienda.Otro_material_techo = tb_material__predominante_techo.Text.ToString().Trim();
                Console.WriteLine(ex.Message);
            }


            vivienda.Cielo_raso = Convert.ToBoolean(rb_cielo_raso.SelectedValue.ToString());//cielo_razo

            try
            {

                vivienda.Material_piso = Convert.ToInt16(rb_material__predominante_piso.SelectedValue.ToString());
            }
            catch (FormatException ex)
            {

                vivienda.Otro_origen_agua_consumo = tb_material__predominante_piso.Text.ToString().Trim();
                Console.WriteLine(ex.Message);
            }

            vivienda.Sobre_pilotes = Convert.ToBoolean(rb_sobre_pilotes.SelectedValue.ToString());//sobre_pilotes


            vivienda.Estado_paredes = Convert.ToInt16(rb_estado_paredes.SelectedValue.ToString());

            vivienda.Estado_techo = Convert.ToInt16(rb_estado_techo.SelectedValue.ToString());
            vivienda.Estado_piso = Convert.ToInt16(rb_estado_piso.SelectedValue.ToString());



            vivienda.Cuartos_exclusivos_dormir = Convert.ToInt16(tb_cuartos_dormir.Text.ToString().Trim());
            vivienda.Cantidad_aposentos = Convert.ToInt16(tb_aposentos.Text.ToString().Trim());

            vivienda.Metros_cuadrados = Convert.ToInt16(rb_cantidad_metros.SelectedValue.ToString());
            vivienda.Abastecimiento_agua = Convert.ToInt16(rb_abastecimiento_agua.SelectedValue.ToString());

            try
            {
                vivienda.Origen_agua_consumo = Convert.ToInt16(rb_origen_agua_consumo.SelectedValue.ToString());
            }
            catch (FormatException ex)
            {
                vivienda.Otro_origen_agua_consumo = tb_origen_agua_consumo.Text.ToString().Trim();
                Console.WriteLine(ex.Message);
            }

            try
            {
                vivienda.Servicio_sanitario = Convert.ToInt16(rb_servicio_sanitario.SelectedValue.ToString());
            }
            catch (FormatException ex)
            {

                vivienda.Otro_servicio_sanitario = tb_servicio_sanitario.Text.ToString().Trim();
                Console.WriteLine(ex.Message);
            }

            vivienda.Servicio_sanitario_es = Convert.ToInt16(rb_servicio_sanitario.SelectedValue.ToString());
            vivienda.Bano = Convert.ToBoolean(rb_tiene_banos.SelectedValue.ToString());//bano
            if (vivienda.Bano == true)
            {

                vivienda.Cantidad_banos = Convert.ToInt16(tb_tiene_banos.Text.ToString().Trim());
                vivienda.Uso_bano = Convert.ToBoolean(rb_uso_bano.SelectedValue.ToString());
            }
            try
            {
                vivienda.Fuente_electricidad = Convert.ToInt16(rb_luz_electrica.SelectedValue.ToString());
            }
            catch (FormatException ex)
            {
                vivienda.Otro_fuente_eletricidad = tb_luz_electrica.Text.ToString().Trim();
                Console.WriteLine(ex.Message);
            }

            try
            {
                vivienda.Energia_cosina = Convert.ToInt16(rb_energia_cosinar.SelectedValue.ToString());
            }
            catch (FormatException ex)
            {
                vivienda.Otro_energia_cosina = tb_energia_cosinar.Text.ToString().Trim();
                Console.WriteLine(ex.Message);
            }


            new DataVivienda().modificarVivienda(vivienda, Convert.ToInt32(Application["idVivienda"] as string) , (Session["Login"] as Usuario).Id) ;
            return true;
        }




        public bool ValidarCampos()

        {

            //    string script = "alert('";


            bool validos = true;

            if (tb_direccion.Text.ToString().Trim().Equals("") ||
                tb_telefono.Text.ToString().Trim().Equals("") ||
                tb_telefono.Text.ToString().Trim().Length == 8 ||

                tb_cantidad_personas_vivienda.Text.ToString().Trim().Equals("") ||
                tb_cuartos_dormir.Text.ToString().Trim().Equals("") ||
                tb_aposentos.Text.ToString().Trim().Equals("")
                )
            {
                //  Response.Write("<script>window.alert('Bienvenido');</script>");
                // script += "faltan campos de texto que llenar";
                Console.WriteLine("faltan campos de texto que llenar");
                validos = false;
                return validos;
            }

            if (rb_mgch.SelectedValue.ToString().Equals("") ||
                rb_cielo_raso.SelectedValue.ToString().Equals("") ||
                rb_sobre_pilotes.SelectedValue.ToString().Equals("") ||
                rb_estado_paredes.SelectedValue.ToString().Equals("") ||
                rb_estado_techo.SelectedValue.ToString().Equals("") ||
                rb_estado_piso.SelectedValue.ToString().Equals("") ||
                rb_abastecimiento_agua.SelectedValue.ToString().Equals("") ||
                rb_cantidad_metros.SelectedValue.ToString().Equals("")

                )
            {
                validos = false;
                return validos;

            }


            /*
            rb_mgch;

            rb_cielo_raso;
                 rb_sobre_pilotes
                 rb_estado_paredes
                 rb_estado_techo
                 rb_estado_piso
                 rb_abastecimiento_agua
                 rb_cantidad_metros
                 rb_servicio_sanitario_es
                 rb_uso_bano


                 rb_separacion_organica
                 rb_separacion_plastico
                 rb_separacion_vidrio
                 rb_separacion_alminio
                 rb_separacion_papel
                 rb_separacion_otro
                 rb_refrigeradora
                 agua_caliente
                 rb_tanque_agua
W
*/


            if (rb_mismo_prespuesto.SelectedValue.ToString().Equals("false"))
            {
                if (tb_numero_hogares_vivienda.Text.ToString().Trim().Equals(""))
                {
                    //         script += "faltan llenar lacantidad de hogares en la vivienda";
                    Console.WriteLine("faltan Numero de hogares en la vivienda");
                    validos = false;
                    return validos;
                }
            }

            if (rb_tipo_vivienda.SelectedValue.ToString().Equals("OTRO"))
            {
                if (tb_espeficar_tipo_vivienda.Text.ToString().Trim().Equals(""))
                {
                    //       script += "especificar el tipo de viviendas";
                    Console.WriteLine("faltan Numero de hogares en la vivienda");
                    validos = false;
                    return validos;
                }
            }

            if (rb_esta_vivienda.SelectedValue.ToString().Equals("OTRO") ||
                rb_esta_vivienda.SelectedValue.ToString().Equals("1") ||
                rb_esta_vivienda.SelectedValue.ToString().Equals("2")
                )
            {
                if (tb_pagaria_mesualidad.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta cuanto pagaria de mensualidad");
                    validos = false;
                    return validos;
                }
            }

            if (rb_esta_vivienda.SelectedValue.ToString().Equals("3") ||
           rb_esta_vivienda.SelectedValue.ToString().Equals("2")
           )
            {
                if (tb_mensualidad.Text.ToString().Trim().Equals(""))
                {

                    Console.WriteLine("falta cuanto pagaria de mensualidad");
                    validos = false;
                    return validos;
                }
            }
            /* materiales vivienda*/


            if (rb_material_predominante_vivienda.SelectedValue.ToString().Equals("OTRO"))
            {
                if (tb_material__predominante_vivienda.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta cuanto pagaria de mensualidad");
                    validos = false;
                    return validos;

                }
            }

            if (rb_material__predominante_techo.SelectedValue.ToString().Equals("OTRO"))
            {
                if (tb_material__predominante_techo.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta material techo");
                    validos = false;
                    return validos;
                }
            }



            if (rb_material__predominante_piso.SelectedValue.ToString().Equals("OTRO"))
            {
                if (tb_material__predominante_piso.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta material techo");
                    validos = false;
                    return validos;
                }
            }
            /*agua consumo*/

            if (rb_origen_agua_consumo.SelectedValue.ToString().Equals("OTRO"))
            {
                if (tb_origen_agua_consumo.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta origen agua");
                    validos = false;
                    return validos;
                }
            }


            if (rb_servicio_sanitario.SelectedValue.ToString().Equals("OTRO"))
            {
                if (tb_servicio_sanitario.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta origen agua");
                    validos = false;
                    return validos;
                }
            }

            if (rb_servicio_sanitario.SelectedValue.ToString().Equals("true"))
            {
                if (tb_tiene_banos.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta origen agua");
                    validos = false;
                    return validos;
                }
            }

            if (rb_luz_electrica.SelectedValue.ToString().Equals("true"))
            {
                if (tb_luz_electrica.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta origen agua");
                    validos = false;
                    return validos;
                }
            }

            if (rb_energia_cosinar.SelectedValue.ToString().Equals("true"))
            {
                if (tb_energia_cosinar.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta energia cosinar");
                    validos = false;
                    return validos;
                }
            }

            //script+="');";
            //       ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            return validos;

        }



    }
}