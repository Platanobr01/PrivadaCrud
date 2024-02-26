using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivadaCrud.Config
{
    internal class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-EGQTOPQ; database=privada; Trusted_Connection=true;");
            conexion.Open();

            return conexion;
        }
    }
}
