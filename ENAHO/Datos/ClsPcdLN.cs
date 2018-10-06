using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClsPcdLN
    {
        #region ListaProvinciaLN
        public List<Provincia> ListaProvinciaLN()
        {
            try
            {
                return new PCD().ListadoProvincia();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region ListaCantonLN
        public List<Canton> ListaCantonLN(Int16 IdProvincia)
        {
            try
            {
                return new PCD().ListadoCanton(IdProvincia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region ListaDistritoLN
        public List<Distrito> ListaDistritoLN(Int16 IdCanton)
        {
            try
            {
                return new PCD().ListadoDistrito(IdCanton);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region ProvinciaConIDLN
        public Byte ProvinciaConIDLN(Int16 idDistrito)
        {
            try
            {
                return new PCD().ProvinciaConIdDistrito(idDistrito);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region CantonConIDLN
        public Byte CantonConIDLN(Int16 idDistrito)
        {
            try
            {
                return new PCD().CantonConIdDistrito(idDistrito);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region DistritoConIDLN
        public Int16 DistritoConIDLN(Int16 idDistrito)
        {
            try
            {
                return new PCD().DistritoConIdDistrito(idDistrito);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
    
}
