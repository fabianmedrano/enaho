using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        public static SqlConnection GET_CONEXION()
        {
         return new  SqlConnection(String.Format(@"Server=FABIÁN-INSPIRON ; Database = ENAHO ; User  Id = sa ; Password = 123;"));
        }
    }
}
