using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace SCMB
{
    public class Conexion
    {
        public MySqlConnection GetConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1;database=bdmb;Uid=root;pwd=;");
            conexion.Open();
            return conexion;
        }
    }
}
