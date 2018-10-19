using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DataVivienda
    {
        #region InsertarEmpleado

        public void InsertarVivienda(Vivienda vivienda)// areglar
        {
            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
            try
            {
                command.CommandText = "paInsertVivienda";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();

                command.Parameters.Add(new SqlParameter("@id", vivienda.DisIDDistrito1));
                command.Parameters.Add(new SqlParameter("@direccion", vivienda.Direccion));
                command.Parameters.Add(new SqlParameter("@telefono", vivienda.Telefono));
                command.Parameters.Add(new SqlParameter("@modulo", vivienda.Modulo_GCH1));

                command.Parameters.Add(new SqlParameter("@numeropersonas", vivienda.Numero_personas_vivienda));
                command.Parameters.Add(new SqlParameter("@numerohogares", vivienda.Numero_hogares_vivienda));
                command.Parameters.Add(new SqlParameter("@tipovivienda", vivienda.Tipo_vivienda));
             //   command.Parameters.Add(new SqlParameter("@otrotipovivienda", vivienda.Otro_tipo_vivienda));

                command.Parameters.Add(new SqlParameter("@mensualidad", vivienda.Mesulaidad_vivienda));
                command.Parameters.Add(new SqlParameter("@pagariamensualidad", vivienda.Pagaria_mesulaidad));
                command.Parameters.Add(new SqlParameter("@esta", vivienda.Esta_vivienda));
                command.Parameters.Add(new SqlParameter("@materialperedes", vivienda.Material_paredes));

                command.Parameters.Add(new SqlParameter("@otromaterialparedes", vivienda.Otro_material_paredes));
                command.Parameters.Add(new SqlParameter("@materialtecho", vivienda.Material_techos));
                command.Parameters.Add(new SqlParameter("@otromaterialtecho", vivienda.Otro_material_techo));
                command.Parameters.Add(new SqlParameter("@cieloraso", vivienda.Cielo_raso));

                command.Parameters.Add(new SqlParameter("@materialpiso", vivienda.Material_piso));
                command.Parameters.Add(new SqlParameter("@otromaterialpiso", vivienda.Otro_material_piso));
                command.Parameters.Add(new SqlParameter("@sobrepilotes", vivienda.Sobre_pilotes));
                command.Parameters.Add(new SqlParameter("@estadoparedes", vivienda.Estado_paredes));

                command.Parameters.Add(new SqlParameter("@estadotecho", vivienda.Estado_techo));
                command.Parameters.Add(new SqlParameter("@estadopiso", vivienda.Estado_piso));
                command.Parameters.Add(new SqlParameter("@cuartosdormir", vivienda.Cuartos_exclusivos_dormir));
                command.Parameters.Add(new SqlParameter("@cantidadaposentos", vivienda.Cantidad_aposentos));

                command.Parameters.Add(new SqlParameter("@metroscuadrados", vivienda.Metros_cuadrados));
                command.Parameters.Add(new SqlParameter("@abastecimientoagua", vivienda.Abastecimiento_agua));
                command.Parameters.Add(new SqlParameter("@origenaguaconsumo", vivienda.Origen_agua_consumo));
                command.Parameters.Add(new SqlParameter("@otroorigenaguaconsumo", vivienda.Otro_origen_agua_consumo));

                command.Parameters.Add(new SqlParameter("@serviciosanitario", vivienda.Servicio_sanitario));
                command.Parameters.Add(new SqlParameter("@otroserviciosanitario", vivienda.Otro_servicio_sanitario));
                command.Parameters.Add(new SqlParameter("@serviciosanitaioes", vivienda.Servicio_sanitario_es));
                command.Parameters.Add(new SqlParameter("@viviendabono", vivienda.Bano));

                command.Parameters.Add(new SqlParameter("@cantidadbanos", vivienda.Cantidad_banos));
                command.Parameters.Add(new SqlParameter("@usobano", vivienda.Uso_bano));
                command.Parameters.Add(new SqlParameter("@fuenteelectricidad", vivienda.Fuente_electricidad));
                command.Parameters.Add(new SqlParameter("@otrofuenteelectricidad", vivienda.Otro_fuente_eletricidad));

                command.Parameters.Add(new SqlParameter("@enegiacosina", vivienda.Energia_cosina));
                command.Parameters.Add(new SqlParameter("@otroenergiacosina", vivienda.Otro_energia_cosina));
                /*basura*/
                command.Parameters.Add(new SqlParameter("@eliminacionbasura", vivienda.Eliminacion_basura));
                command.Parameters.Add(new SqlParameter("@otroeliminacionbasura", vivienda.Otro_eliminacion_basura));
                
                /*separacion*/
                command.Parameters.Add(new SqlParameter("@separacionorganica", vivienda.Separacion_organica));
                command.Parameters.Add(new SqlParameter("@separacionplastico", vivienda.Separacion_plastico));
                command.Parameters.Add(new SqlParameter("@separacionvidrio", vivienda.Separacion_vidrio));
                command.Parameters.Add(new SqlParameter("@separacionaluminio", vivienda.Separacion_alumino));
                command.Parameters.Add(new SqlParameter("@separacionpapel", vivienda.Separacion_papel));
                /*hay en la vivienda*/
                command.Parameters.Add(new SqlParameter("@cantidadtelefonocelular", vivienda.Cantidad_telefono_celular));
                command.Parameters.Add(new SqlParameter("@cantidadtelefonorecidencial", vivienda.Cantidad_telefono_recidencial));
                command.Parameters.Add(new SqlParameter("@cantidadportatil", vivienda.Cantidad_portatil));


                command.Parameters.Add(new SqlParameter("@cantidadpcescritorio", vivienda.Cantidad_pc_escritorio));
                command.Parameters.Add(new SqlParameter("@table", vivienda.Cantidad_tablet));
                command.Parameters.Add(new SqlParameter("@cantidadfax", vivienda.Cantidad_fax));
                command.Parameters.Add(new SqlParameter("@cantidadradio", vivienda.Cantidad_radio));

                command.Parameters.Add(new SqlParameter("@cantidadcarro", vivienda.Cantidad_carro));
                command.Parameters.Add(new SqlParameter("@cantidadmoto", vivienda.Cantidad_moto));
                command.Parameters.Add(new SqlParameter("@cantidadtvplasma", vivienda.Cantidad_tv_plasma));
                command.Parameters.Add(new SqlParameter("@cantidadtvconvencional", vivienda.Cantidad_tv_convencional));

                command.Parameters.Add(new SqlParameter("@regrigeradora", vivienda.Refrigeradora));
                command.Parameters.Add(new SqlParameter("@aguacaliente", vivienda.Agua_caliente));
                command.Parameters.Add(new SqlParameter("@aguatanque", vivienda.Agua_tanque));
                command.Parameters.Add(new SqlParameter("@cable", vivienda.Cable));

                command.Parameters.Add(new SqlParameter("@viviendasatelital", vivienda.Satelital));
                command.Parameters.Add(new SqlParameter("@otrotvpaga", vivienda.Otro_tv_paga));
                command.Parameters.Add(new SqlParameter("@internet", vivienda.Internet));
                command.Parameters.Add(new SqlParameter("@tipoconeccion", vivienda.Tipo_coneccion));

                command.Parameters.Add(new SqlParameter("@otrotipoconeccion", vivienda.Otro_tipo_coneccion));
                command.Parameters.Add(new SqlParameter("@router", vivienda.Router));
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (command.Connection.State == System.Data.ConnectionState.Open)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        }
        #endregion
    

    }
}
