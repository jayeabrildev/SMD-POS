using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace SMD_Water_Station.Classes
{
    class User
    {
        //Fields
        public static string userID;
        public static string fullName;
        public static string password;

        public static string newUserID;
        public static string newPassword;
        public static string newFirstname;
        public static string newSurname;

        //Methods
        public static string GetAccountDetails()
        {
            string firstname = null;
            string surname = null;

            string Query = "SELECT `firstname`, `surname` FROM accounts WHERE `userid` = '" + userID + "'";
            Database.OpenConnection();
            MySqlDataReader reader = Database.Data_Reader(Query);

            if (reader.Read())
            {
                firstname = reader.GetString(0);
                surname = reader.GetString(1);
            }
            Database.CloseConnection();

            fullName = firstname + " " + surname;

            return fullName;
        }

        public static bool SignIn()
        {
            string Query = "SELECT `userid`, `password` FROM `accounts` WHERE `userID` = '" + userID + "' AND `password` = '" + password + "'";
            Database.OpenConnection();
            MySqlDataAdapter Adapter = Database.Data_Adapter(Query);
            DataTable Table = new DataTable();
            Adapter.Fill(Table);
            Database.CloseConnection();
            if (Table.Rows.Count <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static void Register()
        {
            string query = "INSERT INTO `accounts`(userid, password, firstname, surname) VALUES" +
                        "('" + newUserID + "', '" + newPassword + "', '" + newFirstname + "', '" + newSurname + "')";

            MySqlCommand register = Database.ExecuteQuery(query);
            Database.OpenConnection();
            register.ExecuteNonQuery();
            Database.CloseConnection();

        }

        public string NewUserID()
        {
            string query = "Select `userID` FROM `accounts` WHERE userID = (SELECT MAX(userID) FROM `accounts`)";

            Database.OpenConnection();
            MySqlDataReader reader = Database.Data_Reader(query);

            if (reader.Read())
            {
                int maxID = Convert.ToInt32(reader.GetInt32(0));
                maxID++;
                newUserID = maxID.ToString();
            }
            else
            {
                newUserID = "1000000001";
            }
            Database.CloseConnection();
            return newUserID;
        }

        public static void ChangePassword(string newPassword)
        {
            string query = "UPDATE `accounts` SET `password` = '" + newPassword + "' WHERE `userid` = '" + User.userID + "'";

            Database.OpenConnection();
            MySqlCommand command = Database.ExecuteQuery(query);

            command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public static void UpdateInformation(string newFirstname, string newSurname)
        {
            string query = "UPDATE `accounts` SET `firstname` = '" + newFirstname + "', `surname` = '" + newSurname + "' " +
                "WHERE `userid` = '" + User.userID + "'";

            Database.OpenConnection();
            MySqlCommand command = Database.ExecuteQuery(query);
            command.ExecuteNonQuery();
            Database.CloseConnection();

            GetAccountDetails();
        }
    }
}
