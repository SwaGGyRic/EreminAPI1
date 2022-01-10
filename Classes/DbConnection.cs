using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EreminAPI1.Classes
{
    public class DbConnection
    {
        public static DataTable Select(string sql)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "cfif31.ru";
            builder.Port = 3306;
            builder.UserID = "ISPr22-34_EreminNU";
            builder.Password = "ISPr22-34_EreminNU";
            builder.Database = "ISPr22-34_EreminNU_Api";
            builder.CharacterSet = "utf8";

            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            MySqlCommand command = new MySqlCommand(sql, connection);
            DataTable table = new DataTable();

            connection.Open();
            table.Load(command.ExecuteReader());
            connection.Close();

            return table;
        }
    }
}
