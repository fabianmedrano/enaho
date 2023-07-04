using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Provincia
    {

        #region Atributos
        public Int16 Id { get; set; } //ID
        public String Nombre { get; set; } //Nombre
        #endregion
        #region Constructor
        public Provincia() { }
        public Provincia(Int16 Idp, String Nombrep)
        {
            Id = Idp;
            Nombre = Nombrep;
        }
        #endregion
    }
}
