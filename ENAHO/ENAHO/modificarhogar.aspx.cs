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
    public partial class modificarhogar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) {

                llenarCampos(Application["hogar"] as Hogar);
            }
        }
        protected void btn_siguiente_hogares(object sender, EventArgs e)
        {

        }
        protected void btn_terminar(object sender, EventArgs e)
        {

           new DataHogar().modificarHogar(guardarHogar(), Convert.ToInt32(Application["idhogar"] as String));
             Response.Redirect("listhogares.aspx");
        

        }



        private void llenarCampos(Hogar hogar)
        {
          rb_6_aqui_vivienda.SelectedValue = hogar.Personas_mas_seis_meses.ToString();

            rb_personas_otro_lugar_vivir.SelectedValue = hogar.Personas_otro_lugar_donde_vivir.ToString();
            tb_numero_personas_otra_vivienda.Text = hogar.Cantidad_personas_otro_lugar.ToString();


            rb_alguna_personas_viviendo_otra_parte.Text = hogar.Personas_otra_partes.ToString();

            rb_personas_ausentes_menos_6_meses.Text = hogar.Personas_asentes_menos_seis_meses.ToString();
            tb_personas_ausentes_menos_6_meses.Text = hogar.Numero_personas_asentes_menos_seis_meses.ToString();
            rb_servicio_domestico.Text = hogar.Servicio_domestico_en_casa.ToString();


            rb_alquilan_carto.Text = hogar.Alquila_cuarto.ToString();

            rb_resibido_bono.Text = hogar.Recibio_bono.ToString();
            tb_ano_bono.Text =hogar.Ano_recibir.ToString();
            rb_tipo_bono.Text = hogar.Tipo_bono.ToString();

            rb_solicitud_bono.Text = hogar.Solocitud_bono.ToString();
            rb_razon_no_recibir.Text = hogar.Razon_no_recibir.ToString();
            tb_especifique_no_resibir.Text = hogar.Otro_razon_no_recibir.ToString();
            rb_razon_no_solicitar.Text = hogar.Razon_no_solicitar.ToString();
            tb_razon_no_solicitar.Text = hogar.Otro_razon_no_solicitar.ToString();
            }
            
        private Hogar guardarHogar()
        {
            Hogar hogar = new Hogar();
            hogar.Personas_mas_seis_meses = Convert.ToBoolean(rb_6_aqui_vivienda.SelectedValue.ToString());/* se salta todo*/
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
                    }
                }
            }
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
                    if (hogar.Razon_no_recibir.Equals("OTRO"))
                    {
                        hogar.Otro_razon_no_recibir = tb_especifique_no_resibir.Text.ToString();
                    }
                }
                else
                {

                    hogar.Razon_no_solicitar = Convert.ToInt32(rb_razon_no_solicitar.Text.ToString());
                    if (hogar.Razon_no_solicitar.Equals("OTRO"))
                    {
                        hogar.Otro_razon_no_solicitar = tb_razon_no_solicitar.Text.ToString();
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
                    catch (Exception e)
                    {
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
                        catch (Exception e)
                        {
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
                            catch (Exception e)
                            {
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
                                else
                                {
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