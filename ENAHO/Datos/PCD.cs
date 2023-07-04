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
    public class PCD
    {
        #region Provincias
        public List<Provincia> ListadoProvincia()
        {
            List<Provincia> listOfP = new List<Provincia>();
            listOfP.Add(new Provincia(0, "Seleccione"));
            listOfP.Add(new Provincia(1, "1- San José"));
            listOfP.Add(new Provincia(2, "2- Alajuela"));
            listOfP.Add(new Provincia(3, "3- Cartago"));
            listOfP.Add(new Provincia(4, "4- Heredia"));
            listOfP.Add(new Provincia(5, "5- Guanacaste"));
            listOfP.Add(new Provincia(6, "6- Puntarenas"));
            listOfP.Add(new Provincia(7, "7- Limón"));
            listOfP.Add(new Provincia(9, "9- Ignorado"));
            return listOfP;
        }
        #endregion
        #region Cantones
        public List<Canton> ListadoCanton(Int16 ID_P) 
        {
            List<Canton> LISTA = new List<Canton>();
            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
            command.CommandText = "paSeleccionaCanton";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@IdProvincia", ID_P));
            try
            {
                command.Connection.Open();
                SqlDataReader RESULTADO = command.ExecuteReader();
                Canton p = new Canton();
                p.CanIDCanton = 0;
                p.CanNomCanton = "Seleccione";
                LISTA.Add(p);
                while (RESULTADO.Read())
                {
                    Canton C = new Canton(); C.CanIDCanton = Convert.ToInt16(RESULTADO["IdCanton"]);
                    C.CanNomCanton = RESULTADO["NombreCanton"].ToString();
                    LISTA.Add(C);
                }
                return LISTA;
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
        #region Distritos
        public List<Distrito> ListadoDistrito(Int32 ID_C)
        {
            List<Distrito> LISTA = new List<Distrito>(); SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
            command.CommandText = "paSeleccionaDistrito";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@IdCanton", ID_C));
            try
            {
                command.Connection.Open();
                SqlDataReader RESULTADO = command.ExecuteReader();
                Distrito p = new Distrito();
                p.DisIDDistrito = 0;
                p.DisNomDistrito = "Seleccione";
                LISTA.Add(p);
                while (RESULTADO.Read())
                {
                    Distrito C = new Distrito();
                    C.DisIDDistrito = Convert.ToInt32(RESULTADO["IdDistrito"]);
                    C.DisNomDistrito = RESULTADO["NombreDistrito"].ToString();
                    LISTA.Add(C);
                }
                return LISTA;
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
        #region ProvinciaConIdDistrito
        public Byte ProvinciaConIdDistrito(Int32 IdDistrito)
        {
            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
            command.CommandText = "paSeleccionarProvinciaConIdDistrito";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@idDistrito", IdDistrito));
            try
            {
                command.Connection.Open();
                Byte P = 0; //Inicial
                SqlDataReader RESULTADO = command.ExecuteReader();
                if (RESULTADO.Read())
                {
                    P = Convert.ToByte(RESULTADO["ProNUMProvincia"]);
                }
                return P;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        }
        #endregion
        #region CantonConIdDistrito
        public Byte CantonConIdDistrito(Int32 IdDistrito)
        {
            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
            command.CommandText = "paSeleccionarCantonConIdDistrito";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@idDistrito", IdDistrito));
            try
            {
                command.Connection.Open();
                Byte P = 0; //Inicial
                SqlDataReader RESULTADO = command.ExecuteReader(); if (RESULTADO.Read())
                {
                    P = Convert.ToByte(RESULTADO["CanNumCanton"]);
                }
                return P;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        }
        #endregion
        #region DistritoConIdDistrito
        public Int16 DistritoConIdDistrito(Int32 IdDistrito)
        {
            SqlCommand command = Conexion.GET_CONEXION().CreateCommand();
            command.CommandText = "paSeleccionarDistritoConIdDistrito";
            command.CommandType = CommandType.StoredProcedure; command.Parameters.Add(new SqlParameter("@idDistrito", IdDistrito));
            try
            {
                command.Connection.Open();
                Int16 P = 0; //Inicial
                SqlDataReader RESULTADO = command.ExecuteReader();
                if (RESULTADO.Read())
                {
                    P = Convert.ToInt16(RESULTADO["DisNUMDistrito"]);
                }
                return P;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (command.Connection.State == ConnectionState.Open)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        }
        #endregion
    }
    }
