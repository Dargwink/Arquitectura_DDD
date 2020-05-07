using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Infra.DataAccess.Repository
{
    public class ConnectionSQL
    {
        protected SqlConnection conexion = new SqlConnection(
            "Server=LOCALHOST;DataBase=Practica_Patrones;Integrated Security=true");
    }
}
