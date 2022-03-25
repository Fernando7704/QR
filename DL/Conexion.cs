using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Configuration;

namespace DL
{
    public class Conexion
    {
        public static string Connection()
        {
            string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["FLunaConnection"].ConnectionString;
            return conexion;
        }
    }
}
