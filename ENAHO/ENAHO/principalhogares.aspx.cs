using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidad;

namespace ENAHO
{
    public partial class principalhogares : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btn_siguiente_hogares(object sender, EventArgs e)
        {


          //  Response.Redirect("principalpersonas.aspx");
        }

        private void guardarHogar() {
            Hogar hogar = new Hogar();


            hogar.Personas_mas_seis_meses = Convert.ToBoolean(rb_6_aqui_vivienda.SelectedValue.ToString()); 
            hogar.Personas_otro_lugar_donde_vivir = Convert.ToBoolean(rb_personas_otro_lugar_vivir.SelectedValue.ToString()); 
            hogar.Cantidad_personas_otro_lugar = Convert.ToInt32(tb_numero_personas_otra_vivienda.Text.ToString());

            hogar.Personas_otra_partes = Convert.ToBoolean(rb_alguna_personas_viviendo_otra_parte.Text.ToString());
            hogar.Personas_asentes_menos_seis_meses = Convert.ToBoolean(rb_personas_ausentes_menos_6_meses.Text.ToString());
            hogar.Numero_personas_asentes_menos_seis_meses = Convert.ToInt32(tb_personas_ausentes_menos_6_meses.Text.ToString());


            hogar.Servicio_domestico_en_casa = Convert.ToBoolean(rb_servicio_domestico.Text.ToString());
            hogar.Alquila_cuarto = Convert.ToBoolean(rb_alquilan_carto.Text.ToString());
            hogar.Numero_personas_alquila_cuarto = Convert.ToInt32(tb_cuartos_alquila.Text.ToString());
            //----------<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            //boono de vivienda

            hogar.Recibio_bono = Convert.ToBoolean(rb_resibido_bono.Text.ToString());
            hogar.Ano_recibir = Convert.ToInt32(tb_ano_bono.Text.ToString());
            hogar.Tipo_bono = Convert.ToInt32(rb_tipo_bono.Text.ToString());

            hogar.Solocitud_bono = Convert.ToBoolean(rb_solicitud_bono.Text.ToString());
            hogar.Razon_no_recibir = Convert.ToInt32(rb_razon_no_recibir.Text.ToString());
            hogar.Otro_razon_no_recibir = tb_especifique_no_resibir.Text.ToString();

            hogar.Razon_no_solicitar = Convert.ToInt32(rb_razon_no_solicitar.Text.ToString());
            hogar.Otro_razon_no_solicitar =tb_razon_no_solicitar.Text.ToString();
        }
    }




}