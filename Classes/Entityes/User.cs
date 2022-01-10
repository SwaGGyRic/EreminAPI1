using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EreminAPI1.Classes.Entityes
{
    public class User
    {
        public int UserId { get; set; }
        public string login { get; set; }
        public string Password { get; set; }
        public int Rol { get; set; }


        public User(DataRow row)
        {
            UserId = Convert.ToInt32(row["UserId"]);
            login = Convert.ToString(row["login"]);
            Password = Convert.ToString(row["Password"]);
            Rol = Convert.ToInt32(row["Rol"]);
        }
        public static List<User> Select()
        { List<User> users = new List<User>();
            DataTable table = DbConnection.Select("select * from User");
            foreach(DataRow row in table.Rows)
            {
                users.Add(new User(row));
            }
            return users;
        }
    }
}
