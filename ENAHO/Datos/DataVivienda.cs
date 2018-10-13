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
                Vivienda empleado = new Vivienda();
                command.CommandText = "paInsertUsuario";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@NombreEmpleado", vivienda.DisIDDistrito1));
                command.Parameters.Add(new SqlParameter("@Clave", vivienda.Direccion));
                command.Parameters.Add(new SqlParameter("@CorreoEmpleado", vivienda.Telefono));
                command.Parameters.Add(new SqlParameter("@IdEmpleado", vivienda.Modulo_GCH1));

                command.Parameters.Add(new SqlParameter("@NombreEmpleado", vivienda.Numero_personas_vivienda));
                command.Parameters.Add(new SqlParameter("@Clave", vivienda.Numero_hogares_vivienda));
                command.Parameters.Add(new SqlParameter("@CorreoEmpleado", vivienda.Tipo_vivienda));
                command.Parameters.Add(new SqlParameter("@IdEmpleado", vivienda.Otro_tipo_vivienda));

                command.Parameters.Add(new SqlParameter("@NombreEmpleado", vivienda.Mesulaidad_vivienda));
                command.Parameters.Add(new SqlParameter("@Clave", vivienda.Esta_vivienda));
                command.Parameters.Add(new SqlParameter("@CorreoEmpleado", vivienda.Otro_esta_vivienda));
                command.Parameters.Add(new SqlParameter("@IdEmpleado", vivienda.Material_paredes));

                command.Parameters.Add(new SqlParameter("@NombreEmpleado", vivienda.Otro_material_paredes));
                command.Parameters.Add(new SqlParameter("@Clave", vivienda.Material_techos));
                command.Parameters.Add(new SqlParameter("@CorreoEmpleado", vivienda.Otro_material_techo));
                command.Parameters.Add(new SqlParameter("@IdEmpleado", vivienda.Cielo_raso));

                command.Parameters.Add(new SqlParameter("@NombreEmpleado", vivienda.Otro_material_piso));
                command.Parameters.Add(new SqlParameter("@Clave", vivienda.Otro_material_piso));
                command.Parameters.Add(new SqlParameter("@CorreoEmpleado", vivienda.Sobre_pilotes));
                command.Parameters.Add(new SqlParameter("@IdEmpleado", vivienda.Estado_paredes));


                command.Parameters.Add(new SqlParameter("@NombreEmpleado", vivienda.Estado_techo));
                command.Parameters.Add(new SqlParameter("@Clave", vivienda.Estado_piso));
                command.Parameters.Add(new SqlParameter("@CorreoEmpleado", vivienda.Cuartos_exclusivos_dormir));
                command.Parameters.Add(new SqlParameter("@IdEmpleado", vivienda.Cantidad_aposentos));

                command.Parameters.Add(new SqlParameter("@NombreEmpleado", vivienda.Metros_cuadrados));
                command.Parameters.Add(new SqlParameter("@Clave", vivienda.Abastecimiento_agua));
                command.Parameters.Add(new SqlParameter("@CorreoEmpleado", vivienda.Origen_agua_consumo));
                command.Parameters.Add(new SqlParameter("@IdEmpleado", vivienda.Otro_origen_agua_consumo));

                command.Parameters.Add(new SqlParameter("@NombreEmpleado", vivienda.Servicio_sanitario));
                command.Parameters.Add(new SqlParameter("@Clave", vivienda.Otro_servicio_sanitario));
                command.Parameters.Add(new SqlParameter("@CorreoEmpleado", vivienda.Servicio_sanitario_es));
                command.Parameters.Add(new SqlParameter("@IdEmpleado", vivienda.Bano));

                command.Parameters.Add(new SqlParameter("@NombreEmpleado", vivienda.Cantidad_banos));
                command.Parameters.Add(new SqlParameter("@Clave", vivienda.Uso_bano));
                command.Parameters.Add(new SqlParameter("@CorreoEmpleado", vivienda.Fuente_electricidad));
                command.Parameters.Add(new SqlParameter("@IdEmpleado", vivienda.Otro_fuente_eletricidad));

                command.Parameters.Add(new SqlParameter("@NombreEmpleado", vivienda.Energia_cosina));
                command.Parameters.Add(new SqlParameter("@Clave", vivienda.Otro_energia_cosina));
                command.Parameters.Add(new SqlParameter("@CorreoEmpleado", vivienda.Eliminacion_basura));
                command.Parameters.Add(new SqlParameter("@IdEmpleado", vivienda.Otro_eliminacion_basura));
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
        #region ActualizarEmpleado
        public Boolean ActualizarEmpleado(Vivienda vivienda)
        {
            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
            try
            {
                Vivienda empleado = new Vivienda();
                command.CommandText = "paUpdateUsuario";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@NombreEmpleado", vivienda.DisIDDistrito1));
                command.Parameters.Add(new SqlParameter("@Clave", vivienda.Direccion));
                command.Parameters.Add(new SqlParameter("@CorreoEmpleado", vivienda.Telefono));
                command.Parameters.Add(new SqlParameter("@IdEmpleado", vivienda.Modulo_GCH1));
                command.Connection.Open();
                Int16 filas = (Int16)command.ExecuteNonQuery();
                if (filas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
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
        #endregion
        #region BorrarEmpleado
        public Boolean BorrarEmpleado(Vivienda vivienda)
        {
            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
            try
            {
                Vivienda empleado = new Vivienda();
                command.CommandText = "paDeleteUsuario";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@Clave", vivienda.Id_vivienda));
                command.Connection.Open();
                Int16 filas = (Int16)command.ExecuteNonQuery();
                if (filas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
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

        #endregion
    }
}
