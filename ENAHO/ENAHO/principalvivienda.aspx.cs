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
            if (ValidarCampos())
            {
                Guardar_datos();
                string script = "alert('faltan campos que llenar')"; ;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                Response.Redirect("principalhogares.aspx");
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
                    vivienda.Mesulaidad_vivienda = Convert.ToInt32( tb_mensualidad.Text.ToString().Trim());
                }
                if (vivienda.Esta_vivienda == 2 || vivienda.Esta_vivienda == 1)
                {
                    vivienda.Pagaria_mesulaidad = Convert.ToInt32(tb_pagaria_mesualidad.Text.ToString().Trim());
                  //  vivienda.Pagaria_mesulaidad = tb_pagaria_mesualidad.Text.ToString().Trim();
                }
            }
            catch (FormatException ex)
            {
                vivienda.Pagaria_mesulaidad = Convert.ToInt32(tb_pagaria_mesualidad.Text.ToString().Trim());
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
            /*basura*/
            try
            {
                vivienda.Eliminacion_basura = Convert.ToInt16(rb_eliminar_basura.SelectedValue.ToString());
            }
            catch (FormatException ex)
            {
                vivienda.Otro_eliminacion_basura = tb_eliminar_basura.Text.ToString().Trim();
                Console.WriteLine(ex.Message);
              
            }
            /*separacion*/
            vivienda.Separacion_organica = Convert.ToBoolean(rb_separacion_organica.SelectedValue.ToString());

            vivienda.Separacion_plastico = Convert.ToBoolean(rb_separacion_plastico.SelectedValue.ToString());
            vivienda.Separacion_vidrio = Convert.ToBoolean(rb_separacion_vidrio.SelectedValue.ToString());
            vivienda.Separacion_alumino = Convert.ToBoolean(rb_separacion_alminio.SelectedValue.ToString());
            vivienda.Separacion_papel = Convert.ToBoolean(rb_separacion_papel.SelectedValue.ToString());
            /*hay en la vivienda*/

            if (rb_telefono_celular.SelectedValue.ToString() == "true")
            {
                vivienda.Cantidad_telefono_celular = Convert.ToInt32( tb_cantidad_telefonos.Text.ToString().Trim());
            }

            if (rb_telefono_recidencia.SelectedValue.ToString() == "true")
            {
                vivienda.Cantidad_telefono_recidencial = Convert.ToInt32(tb_telefono_recidencia_cantidad.Text.ToString().Trim());
            }
            if (rb_pc_portatil.SelectedValue.ToString() == "true")
            {
                vivienda.Cantidad_portatil = Convert.ToInt32( tb_pc_portatil_cantidad.Text.ToString().Trim());
            }

            if (rb_pc_escritorio.SelectedValue.ToString() == "true")
            {
                vivienda.Cantidad_pc_escritorio = Convert.ToInt32(tb_pc_escritorio_cantidad.Text.ToString().Trim());
            }
            if (rb_tableta.SelectedValue.ToString() == "true")
            {
                vivienda.Cantidad_tablet = Convert.ToInt32(tb_tableta_cantidad.Text.ToString().Trim());
            }

            if (rb_fax.SelectedValue.ToString() == "true")
            {
                vivienda.Cantidad_fax = Convert.ToInt32(tb_fax_cantidad.Text.ToString().Trim());
            }
            if (rb_radio.SelectedValue.ToString() == "true")
            {
                vivienda.Cantidad_radio = Convert.ToInt32(tb_radio_cantidad.Text.ToString().Trim());
            }

            if (rb_carro.SelectedValue.ToString() == "true")
            {
                vivienda.Cantidad_carro = Convert.ToInt32(tb_carro_cantidad.Text.ToString().Trim());
            }
            if (rb_moto.SelectedValue.ToString() == "true")
            {
                vivienda.Cantidad_moto = Convert.ToInt32(tb_moto_cantidad.Text.ToString().Trim());
            }

            if (rb_tv.SelectedValue.ToString() == "true")
            {
                vivienda.Cantidad_tv_plasma = Convert.ToInt32(tb_tv_cantidad.Text.ToString().Trim());
            }


            if (rb_tv_convencional.SelectedValue.ToString() == "true")
            {
                vivienda.Cantidad_tv_convencional = Convert.ToInt32(tb_tv_convencional_cantidad.Text.ToString().Trim());
            }

            vivienda.Refrigeradora = Convert.ToBoolean(rb_refrigeradora.SelectedValue.ToString());
            vivienda.Agua_caliente = Convert.ToBoolean(rb_agua_caliente.SelectedValue.ToString());
            vivienda.Agua_tanque = Convert.ToBoolean(rb_tanque_agua.SelectedValue.ToString());
            vivienda.Cable = Convert.ToBoolean(rb_televisor_cable.SelectedValue.ToString());
            vivienda.Satelital = Convert.ToBoolean(rb_satelital.SelectedValue.ToString());

            if (Convert.ToBoolean(rb_otro_tipo_paga.SelectedValue.ToString()))
            {
                vivienda.Otro_tv_paga = tb_otro_tv_paga.Text.ToString().Trim();
            }
            vivienda.Internet = Convert.ToBoolean(rb_internet.SelectedValue.ToString());
            if (vivienda.Internet == true)
            {
                try
                {
                    vivienda.Tipo_coneccion = Convert.ToInt16(rb_tipo_coneccion.SelectedValue.ToString());
                }
                catch (FormatException exe)
                {
                    vivienda.Otro_tipo_coneccion = tb_otro_tipo_coneccion.Text.ToString().Trim();
                    Console.WriteLine(exe.Message);
                }
                vivienda.Router = Convert.ToBoolean(rb_router.SelectedValue.ToString());
            }


            Application["idVivienda"]  = new DataVivienda().InsertarVivienda(vivienda);
            return true;
        }
        public bool ValidarCampos()

        {

        //    string script = "alert('";

            
            bool validos = true;

            if (tb_direccion.Text.ToString().Trim().Equals("") ||
                tb_telefono.Text.ToString().Trim().Equals("") ||
                tb_cantidad_personas_vivienda.Text.ToString().Trim().Equals("") ||
                tb_cuartos_dormir.Text.ToString().Trim().Equals("") ||
                tb_aposentos.Text.ToString().Trim().Equals("")
                )
            {
              //  Response.Write("<script>window.alert('Bienvenido');</script>");
               // script += "faltan campos de texto que llenar";
                Console.WriteLine("faltan campos de texto que llenar");
                validos = false;
                return validos ;
            }

           /* rb_mgch

                rb_cielo_raso
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
                rb_televisor_cable
                rb_satelital
                rb_otro_tipo_paga

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

            if (rb_eliminar_basura.SelectedValue.ToString().Equals("true"))
            {
                if (tb_eliminar_basura.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta energia cosinar");
                    validos = false;
                    return validos;
                }
            }


            if (rb_telefono_celular.SelectedValue.ToString().Equals("true"))
            {
                if (tb_cantidad_telefonos.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta energia cosinar");
                    validos = false;
                    return validos;
                }
            }

            /////////////////////
            if (rb_telefono_recidencia.SelectedValue.ToString().Equals("true"))
            {
                if (tb_telefono_recidencia_cantidad.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta energia cosinar");
                    validos = false;
                    return validos;
                }
            }



            if (rb_pc_portatil.SelectedValue.ToString().Equals("true"))
            {
                if (tb_pc_portatil_cantidad.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta energia cosinar");
                    validos = false;
                    return validos;
                }
            }

            if (rb_pc_escritorio.SelectedValue.ToString().Equals("true"))
            {
                if (tb_cantidad_telefonos.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta energia cosinar");
                    validos = false;
                    return validos;
                }
            }

            if (rb_tableta.SelectedValue.ToString().Equals("true"))
            {
                if (tb_tableta_cantidad.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta energia cosinar");
                    validos = false;
                    return validos;
                }
            }
            if (rb_fax.SelectedValue.ToString().Equals("true"))
            {
                if (tb_fax_cantidad.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta energia cosinar");
                    validos = false;
                    return validos;
                }
            }



            if (rb_radio.SelectedValue.ToString().Equals("true"))
            {
                if (tb_radio_cantidad.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta energia cosinar");
                    validos = false;
                    return validos;
                }
            }

            if (rb_carro.SelectedValue.ToString().Equals("true"))
            {
                if (tb_carro_cantidad.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta energia cosinar");
                    validos = false;
                    return validos;
                }
            }

            if (rb_moto.SelectedValue.ToString().Equals("true"))
            {
                if (tb_moto_cantidad.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta energia cosinar");
                    validos = false;
                    return validos;
                }
            }


            if (rb_tv.SelectedValue.ToString().Equals("true"))
            {
                if (tb_tv_cantidad.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta energia cosinar");
                    validos = false;
                    return validos;
                }
            }



            if (rb_tv_convencional.SelectedValue.ToString().Equals("true"))
            {
                if (tb_tv_convencional_cantidad.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta energia cosinar");
                    validos = false;
                    return validos;
                }
            }



            if (rb_internet.SelectedValue.ToString().Equals("true"))
            {
                if (rb_tipo_coneccion.SelectedValue.ToString().Equals("OTRO"))
                {
                    if (tb_otro_tipo_coneccion.Text.ToString().Trim().Equals(""))
                    {
                        Console.WriteLine("falta energia cosinar");
                        validos = false;
                        return validos;
                    }
                }
                if (tb_empresa_internet.Text.ToString().Trim().Equals(""))
                {
                    Console.WriteLine("falta energia cosinar");
                }
                if (rb_router.SelectedValue.ToString().Equals("true"))
                {
                }
            }
            //script+="');";
     //       ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
            return validos;

        }
    }
}