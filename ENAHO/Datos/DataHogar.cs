using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class DataHogar
    {

        public void InsertarVivienda(Hogar hogar)// areglar
        {

            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
            try
            {
                command.CommandText = "paInsertHogar";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();

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


                command.Parameters.Add(new SqlParameter("@Otro_razon_no_recibir", hogar.Otro_razon_no_recibir));
                command.Parameters.Add(new SqlParameter("@Razon_no_solicitar", hogar.Razon_no_solicitar));

                command.Parameters.Add(new SqlParameter("@Otro_razon_no_solicitar", hogar.Otro_razon_no_solicitar));

                command.Connection.Open();
                // command.ExecuteNonQuery();
                SqlDataReader RESULTADO = command.ExecuteReader();
                /////////////////////////////////

                while (RESULTADO.Read())
                {
                    //     id = Convert.ToInt32(RESULTADO["idvivienda"].ToString());

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

            //  return idVivienda;
        }

    }
}    
