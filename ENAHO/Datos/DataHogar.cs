﻿using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DataHogar
    {

        public int insertarHogar(Hogar hogar, int idvivienda)// areglar
        {
            int idHogar = 0;
            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
            try
            {
                command.CommandText = "paInsertHogar";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
            
                command.Parameters.Add(new SqlParameter("@id_vivienda", idvivienda));

                command.Parameters.Add(new SqlParameter("@Personas_mas_seis_meses", hogar.Personas_mas_seis_meses));
                command.Parameters.Add(new SqlParameter("@Personas_otro_lugar_donde_vivir", hogar.Personas_otro_lugar_donde_vivir));

                command.Parameters.Add(new SqlParameter("@Cantidad_personas_otro_lugar", hogar.Cantidad_personas_otro_lugar));
                command.Parameters.Add(new SqlParameter("@Personas_otra_partes", hogar.Personas_otra_partes));

                command.Parameters.Add(new SqlParameter("@Personas_asentes_menos_seis_meses", hogar.Personas_asentes_menos_seis_meses));
                command.Parameters.Add(new SqlParameter("@numero_personas_asentes_menos_seis_meses", hogar.Numero_personas_asentes_menos_seis_meses));

                command.Parameters.Add(new SqlParameter("@Servicio_domestico_en_casa", hogar.Servicio_domestico_en_casa));

                command.Parameters.Add(new SqlParameter("@Alquila_cuarto", hogar.Alquila_cuarto));
                command.Parameters.Add(new SqlParameter("@Numero_personas_alquila_cuarto", hogar.Numero_personas_alquila_cuarto));
                command.Parameters.Add(new SqlParameter("@Recibio_bono", hogar.Recibio_bono));
                command.Parameters.Add(new SqlParameter("@Ano_recibir", hogar.Ano_recibir));
                command.Parameters.Add(new SqlParameter("@Tipo_bono", hogar.Tipo_bono));
                command.Parameters.Add(new SqlParameter("@Solocitud_bono", hogar.Solocitud_bono));
                command.Parameters.Add(new SqlParameter("@Razon_no_recibir", hogar.Razon_no_recibir));
                command.Parameters.Add(new SqlParameter("@Otro_razon_no_recibir ", hogar.Otro_razon_no_recibir));
                command.Parameters.Add(new SqlParameter("@Razon_no_solicitar", hogar.Razon_no_solicitar));
                command.Parameters.Add(new SqlParameter("@Otro_razon_no_solicitar", hogar.Otro_razon_no_solicitar));

                command.Connection.Open();
                SqlDataReader RESULTADO = command.ExecuteReader();
                while (RESULTADO.Read())
                {
                    idHogar = Convert.ToInt32(RESULTADO["id"].ToString());
                }
            }
            catch (Exception ex)
            {
               // return false;
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
            return idHogar;
        }

        public void modificarHogar(Hogar hogar, int id)
        {
            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
            try
            {
                command.CommandText = "paEditHogar";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@id", id));

                command.Parameters.Add(new SqlParameter("@Personas_mas_seis_meses", hogar.Personas_mas_seis_meses));
                command.Parameters.Add(new SqlParameter("@Personas_otro_lugar_donde_vivir", hogar.Personas_otro_lugar_donde_vivir));

                command.Parameters.Add(new SqlParameter("@Cantidad_personas_otro_lugar", hogar.Cantidad_personas_otro_lugar));
                command.Parameters.Add(new SqlParameter("@Personas_otra_partes", hogar.Personas_otra_partes));

                command.Parameters.Add(new SqlParameter("@Personas_asentes_menos_seis_meses", hogar.Personas_asentes_menos_seis_meses));
                command.Parameters.Add(new SqlParameter("@numero_personas_asentes_menos_seis_meses", hogar.Numero_personas_asentes_menos_seis_meses));

                command.Parameters.Add(new SqlParameter("@Servicio_domestico_en_casa", hogar.Servicio_domestico_en_casa));

                command.Parameters.Add(new SqlParameter("@Alquila_cuarto", hogar.Alquila_cuarto));
                command.Parameters.Add(new SqlParameter("@Numero_personas_alquila_cuarto", hogar.Numero_personas_alquila_cuarto));
                command.Parameters.Add(new SqlParameter("@Recibio_bono", hogar.Recibio_bono));
                command.Parameters.Add(new SqlParameter("@Ano_recibir", hogar.Ano_recibir));
                command.Parameters.Add(new SqlParameter("@Tipo_bono", hogar.Tipo_bono));
                command.Parameters.Add(new SqlParameter("@Solocitud_bono", hogar.Solocitud_bono));
                command.Parameters.Add(new SqlParameter("@Razon_no_recibir", hogar.Razon_no_recibir));
                command.Parameters.Add(new SqlParameter("@Otro_razon_no_recibir ", hogar.Otro_razon_no_recibir));
                command.Parameters.Add(new SqlParameter("@Razon_no_solicitar", hogar.Razon_no_solicitar));
                command.Parameters.Add(new SqlParameter("@Otro_razon_no_solicitar", hogar.Otro_razon_no_solicitar));

                command.Connection.Open();
                SqlDataReader RESULTADO = command.ExecuteReader();
              
            }
            catch (Exception ex)
            {
                // return false;
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

        public Boolean eliminar(int id)
        {
            List<viviendamuestra> LISTA = new List<viviendamuestra>();
            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
            command.CommandText = "paEliminarHogar";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@id", id));
            try
            {
                command.Connection.Open();
                command.ExecuteReader();

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
            return true;
        }


        public List<hogarmuestra> ListadoHogar(int idvivienda)
        {
            
                List<hogarmuestra> LISTA = new List<hogarmuestra>();
                SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
                command.CommandText = "paSeleccionahogar";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();

                command.Parameters.Add(new SqlParameter("@id", idvivienda));

            try
            {
                    command.Connection.Open();
                    SqlDataReader RESULTADO = command.ExecuteReader();

                    while (RESULTADO.Read())
                    {
                    hogarmuestra c = new hogarmuestra();

                        c.Id = Convert.ToInt16(RESULTADO["id"]);
                        c.Personas_mas_seis_meses = Convert.ToBoolean(RESULTADO["Personas_mas_seis_meses"]);
                        c.Cantidad_personas_otro_lugar = Convert.ToInt32(RESULTADO["Cantidad_personas_otro_lugar"]);
                        c.Numero_personas_asentes_menos_seis_meses = Convert.ToInt32(RESULTADO["numero_personas_asentes_menos_seis_meses"]);
                      
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

        public  Boolean insertarHogares(List<Hogar> hogares, int idvivienda  )
        {
            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();

            command.CommandText = "paInsertarhogares";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            
            try
            {
                command.Parameters.Clear();

                DataTable tipo_hogar = new DataTable();

                tipo_hogar.Columns.Add("id", typeof(int)); 

                tipo_hogar.Columns.Add("id_vivienda", typeof(int)); 

                tipo_hogar.Columns.Add("Personas_mas_seis_meses", typeof(Boolean));
                tipo_hogar.Columns.Add("Personas_otro_lugar_donde_vivir", typeof(Boolean)); 
                tipo_hogar.Columns.Add("Cantidad_personas_otro_lugar", typeof(int));
                tipo_hogar.Columns.Add("Personas_otra_partes", typeof(Boolean));
                tipo_hogar.Columns.Add("Personas_asentes_menos_seis_meses", typeof(Boolean)); 
                tipo_hogar.Columns.Add("numero_personas_asentes_menos_seis_meses", typeof(int)); 
                tipo_hogar.Columns.Add("Servicio_domestico_en_casa", typeof(Boolean)); 
                tipo_hogar.Columns.Add("Alquila_cuarto", typeof(Boolean)); 
                tipo_hogar.Columns.Add("Numero_personas_alquila_cuarto", typeof(int)); 
                tipo_hogar.Columns.Add("Recibio_bono", typeof(Boolean)); 
                tipo_hogar.Columns.Add("Ano_recibir", typeof(int)); 
                tipo_hogar.Columns.Add("Tipo_bono", typeof(int)); 
                tipo_hogar.Columns.Add("Solocitud_bono", typeof(Boolean)); 
                tipo_hogar.Columns.Add("Razon_no_recibir", typeof(int));
                tipo_hogar.Columns.Add("Razon_no_solicitar", typeof(int)); 
                
                foreach (Hogar hogar in hogares)
                {
                    DataRow dr = tipo_hogar.NewRow();
             
                    dr["id"] =0;
                    dr["id_vivienda"] = 0;
                    dr["Personas_mas_seis_meses"] = hogar.Personas_mas_seis_meses;
                    dr["Personas_otro_lugar_donde_vivir"] = hogar.Personas_otro_lugar_donde_vivir;
                    dr["Cantidad_personas_otro_lugar"] = hogar.Cantidad_personas_otro_lugar;
                    dr["Personas_otra_partes"] = hogar.Personas_otra_partes;
                    dr["Personas_asentes_menos_seis_meses"] = hogar.Personas_asentes_menos_seis_meses;
                    dr["numero_personas_asentes_menos_seis_meses"] = hogar.Numero_personas_asentes_menos_seis_meses;
                    dr["Servicio_domestico_en_casa"] = hogar.Servicio_domestico_en_casa;
                    dr["Alquila_cuarto"] = hogar.Alquila_cuarto;
                    dr["Numero_personas_alquila_cuarto"] = hogar.Numero_personas_alquila_cuarto;
                    dr["Recibio_bono"] = hogar.Recibio_bono;
                    dr["Ano_recibir"] = hogar.Ano_recibir;
                    dr["Tipo_bono"] = hogar.Tipo_bono;
                    dr["Solocitud_bono"] = hogar.Solocitud_bono;
                    dr["Razon_no_recibir"] = hogar.Razon_no_recibir;
                    dr["Razon_no_solicitar"] = hogar.Razon_no_solicitar;
                    
                    tipo_hogar.Rows.Add(dr);
                }
                command.Parameters.Add(new SqlParameter("@idvivienda", idvivienda));
                command.Parameters.Add(new SqlParameter("@listahogares", tipo_hogar));

                command.Connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {
                //Cerrar conexión
                if (command.Connection.State == System.Data.ConnectionState.Open)
                {
                    command.Connection.Close();
                }
               
                command = null;
            }
        }

       
        public Hogar getHogar(int id)
        {

        Hogar hogar = new Hogar();
            

            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
            command.CommandText = "paGetHogar";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@id", id));

            try
            {
                command.Connection.Open();
                SqlDataReader RESULTADO = command.ExecuteReader();


                while (RESULTADO.Read())
                {
                    hogar.Id =Convert.ToInt32((RESULTADO["id"]).ToString());
                    hogar.Personas_mas_seis_meses = Convert.ToBoolean((RESULTADO["Personas_mas_seis_meses"]).ToString());
                    hogar.Personas_otro_lugar_donde_vivir = Convert.ToBoolean((RESULTADO["Personas_otro_lugar_donde_vivir"]).ToString());
                    hogar.Cantidad_personas_otro_lugar = Convert.ToInt32((RESULTADO["Cantidad_personas_otro_lugar"]).ToString());

                    hogar.Personas_otra_partes = Convert.ToBoolean((RESULTADO["Personas_otra_partes"]).ToString());
                    hogar.Personas_asentes_menos_seis_meses = Convert.ToBoolean((RESULTADO["Personas_asentes_menos_seis_meses"]).ToString());
                    hogar.Numero_personas_asentes_menos_seis_meses = Convert.ToInt32((RESULTADO["numero_personas_asentes_menos_seis_meses"]).ToString());


                    hogar.Servicio_domestico_en_casa = Convert.ToBoolean((RESULTADO["Servicio_domestico_en_casa"]).ToString());
                    hogar.Alquila_cuarto = Convert.ToBoolean((RESULTADO["Alquila_cuarto"]).ToString());
                    hogar.Numero_personas_alquila_cuarto = Convert.ToInt32((RESULTADO["Numero_personas_alquila_cuarto"]).ToString());

                    //boono de vivienda

                    hogar.Recibio_bono = Convert.ToBoolean((RESULTADO["Recibio_bono"]).ToString());
                    hogar.Ano_recibir = Convert.ToInt32((RESULTADO["Ano_recibir"]).ToString());
                    hogar.Tipo_bono = Convert.ToInt32((RESULTADO["Tipo_bono"]).ToString());

                    hogar.Solocitud_bono = Convert.ToBoolean((RESULTADO["Solocitud_bono"]).ToString());
                    hogar.Razon_no_recibir = Convert.ToInt32((RESULTADO["Razon_no_recibir"]).ToString());
                  //  hogar.Otro_razon_no_recibir = ((RESULTADO["idDistrito"]).ToString());

                    hogar.Razon_no_solicitar = Convert.ToInt32((RESULTADO["Razon_no_solicitar"]).ToString());
                   // hogar.Otro_razon_no_solicitar = ((RESULTADO["idDistrito"]).ToString());


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

            return hogar;
        }
        
    }
}    
