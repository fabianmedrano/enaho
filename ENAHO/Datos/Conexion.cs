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
         return new  SqlConnection(String.Format(@"Server=localhost ; Database = ENAHO ; user id = sa ; Password = 123;"));
        }
    }
}
