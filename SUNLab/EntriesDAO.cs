using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUNLab
{
    internal class EntriesDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=sun_lab;";

        public List<Entry> getAllEntries()
        {
            List<Entry> entries = new List<Entry>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("select entries.id, entries.timestamp, users.name, users.role from entries join users on entries.id=users.id", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entry e = new Entry
                    {
                        id = reader.GetInt32(0),
                        timestamp = reader.GetDateTime(1),
                        name = reader.GetString(2),
                        role = reader.GetString(3)
                    };
                    entries.Add(e);
                }
            }

            connection.Close();
            return entries;
        }

        public List<User> getAllUsers()
        {
            List<User> entries = new List<User>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("select * from users", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    User e = new User
                    {
                        id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        role = reader.GetString(2),
                        has_access = reader.GetBoolean(3),
                        password = reader.GetString(4)
                    };
                    entries.Add(e);
                }
            }

            connection.Close();
            return entries;
        }

        public List<Entry> searchEntriesByDate(string start, string end)
        {
            List<Entry> entries = new List<Entry>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string commandString = "select entries.id, entries.timestamp, users.name, users.role from entries join users on entries.id=users.id where entries.timestamp between \'" + start + "\' and \'" + end + "\'";
            MySqlCommand command = new MySqlCommand(commandString, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entry e = new Entry
                    {
                        id = reader.GetInt32(0),
                        timestamp = reader.GetDateTime(1),
                        name = reader.GetString(2),
                        role = reader.GetString(3)
                    };
                    entries.Add(e);
                }
            }

            connection.Close();
            return entries;
        }

        public List<Entry> searchEntriesByID(int id)
        {
            List<Entry> entries = new List<Entry>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string commandString = "select entries.id, entries.timestamp, users.name, users.role from entries join users on entries.id=users.id where entries.id=" + id;
            MySqlCommand command = new MySqlCommand(commandString, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Entry e = new Entry
                    {
                        id = reader.GetInt32(0),
                        timestamp = reader.GetDateTime(1),
                        name = reader.GetString(2),
                        role = reader.GetString(3)
                    };
                    entries.Add(e);
                }
            }

            connection.Close();
            return entries;
        }
    }
}
