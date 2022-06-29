using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project2
{
    internal class DBAccess
    {
        private const string server = "127.0.0.1";
        private const string port = "3306";
        private const string username = "root";
        private const string password = "1234";
        private const string database = "mydb";
        private const string table = "user2";

        private static DBAccess instance = new DBAccess();
        public static DBAccess Instance { get { return instance; } }
        private DBAccess() { }

        public MySqlConnection Connect()
        {
            string strConn = $"server={server};";
            strConn += $"port={port};";
            strConn += $"username={username};";
            strConn += $"password={password};";
            strConn += $"database={database};";
            
            MySqlConnection conn = new MySqlConnection(strConn);
            return conn;
        }

        public void InsertUser(string uid, string name, string hp, decimal age)
        {
            MySqlConnection conn = Connect();

            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"INSERT INTO `{table}` VALUES('{uid}', '{name}', '{hp}', {age})";

                cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                conn.Close();
            }

            MessageBox.Show("추가 완료", "데이터가 저장 되었습니다.");

        }

        public User SelectUser()
        {
            User user = new User();

            return user;
        }
        
        public List<User> SelectUsers()
        {
            MySqlConnection conn = Connect();

            List<User> users = new List<User>();

            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM `{table}`";

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User();
                    user.Uid = reader[0].ToString();
                    user.Name = reader[1].ToString();
                    user.Hp = reader[2].ToString();
                    user.Age = Convert.ToInt32(reader[3]);

                    users.Add(user);
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                conn.Close();
            }

            return users;
        }

        public void UpdateUser(string uid, string name, string hp, decimal age)
        {
            MySqlConnection conn = Connect();

            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"UPDATE `{table}` SET `name` = '{name}', `hp` = '{hp}', `age` = {age} WHERE `uid` = '{uid}'";

                cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                conn.Close();
            }

            MessageBox.Show("업데이트 완료", "데이터가 저장 되었습니다.");
        }

        public void DeleteUser(int row)
        {
            MySqlConnection conn = Connect();

            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"DELETE FROM `{table}` WHERE ROW_NUMBER() = {row}";

                cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                conn.Close();
            }

            MessageBox.Show("업데이트 완료", "데이터가 저장 되었습니다.");
        }
    }
}
