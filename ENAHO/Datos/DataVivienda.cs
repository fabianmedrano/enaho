using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DataVivienda
    {
       

        public int InsertarVivienda(Vivienda vivienda, int entre)// areglar
        {
            int idVivienda = 0;
            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
            try
            {
                command.CommandText = "paInsertVivienda";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();

                command.Parameters.Add(new SqlParameter("@id", vivienda.DisIDDistrito1));
                command.Parameters.Add(new SqlParameter("@distrito", vivienda.DisIDDistrito1));
                command.Parameters.Add(new SqlParameter("@direccion", vivienda.Direccion));
                command.Parameters.Add(new SqlParameter("@telefono", vivienda.Telefono));
                command.Parameters.Add(new SqlParameter("@modulo", vivienda.Modulo_GCH1));

                command.Parameters.Add(new SqlParameter("@numeropersonas", vivienda.Numero_personas_vivienda));
                command.Parameters.Add(new SqlParameter("@numerohogares", vivienda.Numero_hogares_vivienda));
                command.Parameters.Add(new SqlParameter("@tipovivienda", vivienda.Tipo_vivienda));
                command.Parameters.Add(new SqlParameter("@otrotipovivienda", vivienda.Otro_tipo_vivienda));

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


                command.Parameters.Add(new SqlParameter("@entrevistador", entre));
                


                command.Connection.Open();
                // command.ExecuteNonQuery();
                SqlDataReader RESULTADO = command.ExecuteReader();
                /////////////////////////////////

                while (RESULTADO.Read())
                {
                     idVivienda = Convert.ToInt32(RESULTADO["idvivienda"].ToString());

                }
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
                  
            return idVivienda ;
        }



        public List<viviendamuestra> ListadoVivienda()
        {
            List<viviendamuestra> LISTA = new List<viviendamuestra>();
            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
            command.CommandText = "paSeleccionaViviendaMuestra";
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                command.Connection.Open();
                SqlDataReader RESULTADO = command.ExecuteReader();

                while (RESULTADO.Read())
                {
                    viviendamuestra c = new viviendamuestra();
            
                    c.Id_vivienda = Convert.ToInt16(RESULTADO["id"]);
                    c.DisIDDistrito1 = (RESULTADO["idDistrito"]).ToString();
                    c.Direccion =(RESULTADO["direccion"]).ToString();
                    c.Telefono = (RESULTADO["telefono"]).ToString();
                    c.Modulo_GCH1 = Convert.ToBoolean (RESULTADO["modulo"]);
                    c.Numero_personas_vivienda = Convert.ToInt16(RESULTADO["numeropersonas"]);
                    c.Numero_hogares_vivienda = Convert.ToInt16(RESULTADO["numerohogares"]);
                    c.Tipo_vivienda = (RESULTADO["tipo"]).ToString();
                    LISTA.Add(c);
                }
              
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
            return LISTA;
        }

        public Boolean eliminar(int idVivienda) {
            List<viviendamuestra> LISTA = new List<viviendamuestra>();
            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
            command.CommandText = "paEliminarVivienda";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@idVivienda", idVivienda));
            try
            {
                command.Connection.Open();
                command.ExecuteReader();

            }
            catch  (Exception ex)
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
            return true;
        }


        public Vivienda getVivienda( int idVivienda)
        {

            Vivienda vivienda = new Vivienda();

            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
            command.CommandText = "paGetVivienda";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@idVivienda", idVivienda));
            
            try
            {
                command.Connection.Open();
                SqlDataReader RESULTADO = command.ExecuteReader();


                while (RESULTADO.Read())
                {
                    
                    vivienda.Id_vivienda = Convert.ToInt16(RESULTADO["id"]);
                    vivienda.DisIDDistrito1 = Convert.ToInt32((RESULTADO["idDistrito"]).ToString());
                    vivienda.Direccion = (RESULTADO["direccion"]).ToString();
                    /**/
                    vivienda.Telefono = RESULTADO["telefono"].ToString();
                    vivienda.Modulo_GCH1 = Convert.ToBoolean(RESULTADO["modulo"]);
                    vivienda.Numero_personas_vivienda = Convert.ToInt16(RESULTADO["numeropersonas"]);
                    /**/
                    vivienda.Numero_hogares_vivienda = Convert.ToInt16(RESULTADO["numerohogares"]);
                    vivienda.Tipo_vivienda = Convert.ToInt16(RESULTADO["tipovivienda"]);
               //     vivienda.Otro_tipo_vivienda = RESULTADO["otrotipovivienda"].ToString();/**/
                    /**/
                    vivienda.Mesulaidad_vivienda = float.Parse(RESULTADO["mensualidad"].ToString());
                    vivienda.Pagaria_mesulaidad = float.Parse(RESULTADO["pagariamensualidad"].ToString());
                    vivienda.Esta_vivienda = Convert.ToInt16(RESULTADO["esta"]);
                    /**/
                    vivienda.Material_paredes = Convert.ToInt16(RESULTADO["materialperedes"]);
               //     vivienda.Otro_material_paredes = (RESULTADO["[materialtecho]"]).ToString();/**/
                    vivienda.Material_techos = Convert.ToInt16(RESULTADO["materialtecho"]);
                    /**/
               //     vivienda.Otro_material_techo =(RESULTADO["id"]).ToString();/**/
                    vivienda.Cielo_raso = Convert.ToBoolean(RESULTADO["cieloraso"]);
                    vivienda.Material_piso = Convert.ToInt16(RESULTADO["materialpiso"]);
                    /**/
               //     vivienda.Otro_material_piso = (RESULTADO["[id]"]).ToString();/**/
                    vivienda.Sobre_pilotes = Convert.ToBoolean(RESULTADO["sobrepilotes"]);
                    vivienda.Estado_paredes = Convert.ToInt16(RESULTADO["estadoparedes"]);
                    /**/
                    vivienda.Estado_techo = Convert.ToInt16(RESULTADO["estadotecho"]);
                    vivienda.Estado_piso = Convert.ToInt16(RESULTADO["estadopiso"]);
                    vivienda.Cuartos_exclusivos_dormir = Convert.ToInt16(RESULTADO["estadopiso"]);
                    /**/
                    vivienda.Cantidad_aposentos = Convert.ToInt16(RESULTADO["cantidadaposentos"]);
                    vivienda.Metros_cuadrados = Convert.ToInt16(RESULTADO["metroscuadrados"]);
                    vivienda.Abastecimiento_agua = Convert.ToInt16(RESULTADO["abastecimientoagua"]);
                    /**/
                    vivienda.Origen_agua_consumo = Convert.ToInt16(RESULTADO["origenaguaconsumo"]);
               //     vivienda.Otro_origen_agua_consumo = (RESULTADO["id"]).ToString(); /**/
                    vivienda.Servicio_sanitario = Convert.ToInt16(RESULTADO["serviciosanitario"]);
                    /**/
             //       vivienda.Otro_servicio_sanitario = (RESULTADO["id"]).ToString(); /**/
                    vivienda.Servicio_sanitario_es = Convert.ToInt16(RESULTADO["serviciosanitaioes"]);
                    vivienda.Bano = Convert.ToBoolean(RESULTADO["viviendabano"]);
                    /**/
                    vivienda.Cantidad_banos = Convert.ToInt16(RESULTADO["cantidadbanos"]);
                    vivienda.Uso_bano = Convert.ToBoolean(RESULTADO["usobano"]);
                    vivienda.Fuente_electricidad = Convert.ToInt16(RESULTADO["fuenteelectricidad"]);
                    /**/
                 //   vivienda.Otro_fuente_eletricidad = (RESULTADO["id"]).ToString();   /**/
                    vivienda.Energia_cosina = Convert.ToInt16(RESULTADO["enegiacosina"]);
                  //  vivienda.Otro_energia_cosina = (RESULTADO["id"]).ToString(); /**/
                    /*basura*/
                  //  vivienda.Eliminacion_basura = Convert.ToInt16(RESULTADO["id"]);
                   // vivienda.Otro_eliminacion_basura =(RESULTADO["id"]).ToString();


                }

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
            return vivienda;
        }

        public void modificarVivienda(Vivienda vivienda, int v, int entre)
        {
            int idVivienda = 0;
            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
            try
            {
                command.CommandText = "paEditVivienda";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();

                command.Parameters.Add(new SqlParameter("@id", v));
                command.Parameters.Add(new SqlParameter("@distrito", vivienda.DisIDDistrito1));
                command.Parameters.Add(new SqlParameter("@direccion", vivienda.Direccion));
                command.Parameters.Add(new SqlParameter("@telefono", vivienda.Telefono));
                command.Parameters.Add(new SqlParameter("@modulo", vivienda.Modulo_GCH1));

                command.Parameters.Add(new SqlParameter("@numeropersonas", vivienda.Numero_personas_vivienda));
                command.Parameters.Add(new SqlParameter("@numerohogares", vivienda.Numero_hogares_vivienda));
                command.Parameters.Add(new SqlParameter("@tipovivienda", vivienda.Tipo_vivienda));
                command.Parameters.Add(new SqlParameter("@otrotipovivienda", vivienda.Otro_tipo_vivienda));

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

                



                command.Connection.Open();
                // command.ExecuteNonQuery();
                SqlDataReader RESULTADO = command.ExecuteReader();
                /////////////////////////////////

                while (RESULTADO.Read())
                {
                    idVivienda = Convert.ToInt32(RESULTADO["idvivienda"].ToString());

                }
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
    }
}
