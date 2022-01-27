using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConnectionLibrary
{
    public class ConnDB
    {
        public MySqlConnection ConnMysqlClient()
        {
            string ConnStr = "server=caseum.ru;port=33333;user=st_3_5_19;database=st_3_5_19;password=41584500;";
            MySqlConnection conn = new MySqlConnection(ConnStr);
            return conn;
        }
    }
}
