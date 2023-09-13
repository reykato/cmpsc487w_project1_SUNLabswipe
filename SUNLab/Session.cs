using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNLab
{
    internal class Session
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=sun_lab;";

        public bool isUser(int id)
        {
            if (!(id.ToString().Length == 9)) return false;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string commandString = "select role from users where id=" + id;
            MySqlCommand command = new MySqlCommand(commandString, connection);

            if (id.ToString().Length != 9)
            {
                return false;
            }

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (!reader.Read())
                {
                    return false;
                }
            }

            return true;
        }

        public string isAdmin(int id, string password)
        {
            if (id.ToString().Length != 9)
            {
                return "invalidid";
            }

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            Session session = new Session();
            User user = session.getUser(id);
            if (user == null)
            {
                return "invalidid";
            } 
            else {
                if (user.role == "admin" && user.password.Equals(password))
                {
                    return "accessgranted";
                }
            }
            
            connection.Close();

            return "accessdenied";
        }

        public void addEntry(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string commandString = "insert into entries (id) values(" + id + ")";
            MySqlCommand command = new MySqlCommand(commandString, connection);

            int result = command.ExecuteNonQuery();
            connection.Close();
        }

        public int addUser(int id, string name, string role, bool has_access, string password)
        {
            List<Entry> entries = new List<Entry>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string commandString = "insert into users values (" + id + ", \'" + name + "\', \'" + role + "\', " + has_access + ", \'" + password + "\')";
            MySqlCommand command = new MySqlCommand(commandString, connection);

            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public int editUser(int id, string name, string role, bool has_access)
        {
            List<Entry> entries = new List<Entry>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            if (!isUser(id))
            {
                return -1;
            }

            string commandString = "update users set name=\'" + name + "\', role=\'" + role + "\', has_access=" + has_access + " where id=" + id;
            MySqlCommand command = new MySqlCommand(commandString, connection);

            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public User getUser(int id)
        {
            if (!isUser(id))
            {
                return null;
            }

            User user = new User();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("select * from users where id=" + id, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    user.id = reader.GetInt32(0);
                    user.name = reader.GetString(1);
                    user.role = reader.GetString(2);
                    user.has_access = reader.GetBoolean(3);
                    user.password = reader.GetString(4);
                }
            }

            connection.Close();
            return user;
        }
    }
}
