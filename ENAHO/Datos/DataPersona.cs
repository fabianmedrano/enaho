using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class DataPersona
    {
        public bool insertarPersonas(List<Persona> personas, int idHogar)
        {

            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();


            command.CommandText = "paInsertpersonas";
            command.CommandType = System.Data.CommandType.StoredProcedure;
           

            
            try
            {
               
                DataTable dtTipoDetalle = new DataTable();
                dtTipoDetalle.Columns.Add("id", typeof(int));
                dtTipoDetalle.Columns.Add("idHogar", typeof(int));
                
                dtTipoDetalle.Columns.Add("nombre", typeof(String));
                dtTipoDetalle.Columns.Add("mas_6_meses", typeof(bool));


                dtTipoDetalle.Columns.Add("continuara_viviendo", typeof(bool));
                dtTipoDetalle.Columns.Add("parentesco_jefe_hogar", typeof(int));
                dtTipoDetalle.Columns.Add("sexo", typeof(bool));

                dtTipoDetalle.Columns.Add("edad", typeof(int));
                dtTipoDetalle.Columns.Add("idDistrito", typeof(int));
                dtTipoDetalle.Columns.Add("estado_conyugal", typeof(int));
                dtTipoDetalle.Columns.Add("tipo_seguro", typeof(int));
      

                foreach (Persona persona in personas)
                {
                    DataRow dr = dtTipoDetalle.NewRow();

                    dr["id"] = 0;

                    dr["idHogar"] = 0;
                    dr["nombre"] = persona.Nombre;
                    dr["mas_6_meses"] = persona.Mas_6_meses;
                    dr["continuara_viviendo"] = persona.Continuara_viviendo;



                    dr["parentesco_jefe_hogar"] = persona.Parentesco_jefe_hogar;
                    dr["sexo"] = persona.Sexo;
                    dr["edad"] = persona.Edad;
                    dr["idDistrito"] = persona.IdDistrito;



                    dr["estado_conyugal"] = persona.Estado_conyugal;
                    dr["tipo_seguro"] = persona.Tipo_seguro;

                    dtTipoDetalle.Rows.Add(dr);
                }
                command.Parameters.Clear();
                command.Connection.Open();

                command.Parameters.Add(new SqlParameter("@hogar", idHogar));
                command.Parameters.Add(new SqlParameter("@lista", dtTipoDetalle));
               
               
                command.ExecuteNonQuery();
                return true;
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
            }

      
        }
    }
}
