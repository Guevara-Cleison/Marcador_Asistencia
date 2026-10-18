using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class Conexion
    {

        public SqlConnection ConexionSql()
        {
            string cadena;

            cadena = "Server = CLEISON; Database = TALLER_TEXTIL; User Id = Taller_textil; Password = Desarrollo$$";

            return new SqlConnection(cadena);
        }

    }
}
