using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using MySql.Data.MySqlClient;

namespace C969PA
{
    class AppDatabase
    {
        private static Dictionary<int, Hashtable> _appointmentDict = new Dictionary<int, Hashtable>();
        private static int _userId;
        private static string _userName;
        public static string dbConnection = "server=wgudb.ucertify.com;database=U07ueI;uid=U07ueI;pwd=53689136346;";

        public static int GetUserId()
        {
            return _userId;
        }

        public static void SetUserId(int userId)
        {
            _userId = userId;
        }

        public static string GetUserName()
        {
            return _userName;
        }

        public static void SetUserName(string userName)
        {
            _userName = userName;
        }

        public static Dictionary<int, Hashtable> GetAppointments()
        {
            return _appointmentDict;
        }

        public static void SetAppointments(Dictionary<int, Hashtable> appointments)
        {
            _appointmentDict = appointments;
        }

        public static int NewUserId(List<int> idList)
        {
            int firstId = 0;

            foreach (int id in idList)
            {
                if (id > firstId)
                {
                    firstId = id;
                }
            }
            return firstId + 1;
        }

        public static string LogTimeStamp()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static int MakeId(string idtable) //This will create a new, unique ID for new entries.
        {
            MySqlConnection s = new MySqlConnection(dbConnection);
            s.Open();
            MySqlCommand command = new MySqlCommand($"SELECT {idtable + "Id"} FROM {idtable}", s);
            MySqlDataReader reader = command.ExecuteReader();
            List<int> idList = new List<int>();
            while (reader.Read())
            {
                idList.Add(Convert.ToInt32(reader[0]));
            }
            reader.Close();
            s.Close();
            return NewUserId(idList);
        }

        public static int NewLog(string timestamp, string userName, string table, string poq, int userId = 0) //This gather the information needed when making a new entry into the datatables
        {
            int logId = MakeId(table);
            string defaultName = "not needed";
            string logInsert;
            if (userId == 0)
            {
                logInsert = $"INSERT INTO {table}" +
                            $" VALUES ('{logId}', {poq}, '{timestamp}', '{userName}', '{timestamp}', '{userName}')";
            }
            else
            {
                logInsert =

                    //I had to use this code before in order to properly save entries since the "not needed" columns weren't nulled. I have dropped the "not needed" columns from the database in order to clean up my code and prevent issues.

                    //$"INSERT INTO {table} (appointmentId, customerId, start, end, type, userId, createDate, createdBy, lastUpdate, lastUpdateBy, title, description, location, contact, url)" +
                    //$" VALUES ('{logId}', {poq}, '{userId}', '{timestamp}', '{userName}', '{timestamp}', '{userName}', '{defaultName}', '{defaultName}', '{defaultName}', '{defaultName}', '{defaultName}')";

                $"INSERT INTO {table} (appointmentId, customerId, start, end, type, userId, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                    $" VALUES ('{logId}', {poq}, '{userId}', '{timestamp}', '{userName}', '{timestamp}', '{userName}')";
            }

            MySqlConnection s = new MySqlConnection(dbConnection);
            s.Open();
            MySqlCommand command = new MySqlCommand(logInsert, s);
            command.ExecuteNonQuery();
            s.Close();

            return logId;
        }

        public static int LookupCustomer(string enterCust) //This allows users to look up customers in search bars using the customerId.
        {
            int custId;
            string query;
            if (int.TryParse(enterCust, out custId))
            {
                query = $"SELECT customerId FROM customer WHERE customerId = '{enterCust.ToString()}'";
            }
            else
            {
                query = $"SELECT customerId FROM customer WHERE customerName LIKE '{enterCust}'";
            }

            MySqlConnection s = new MySqlConnection(AppDatabase.dbConnection);
            s.Open();
            MySqlCommand command = new MySqlCommand(query, s);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                custId = Convert.ToInt32(reader[0]);
                reader.Close();
                s.Close();
                return custId;
            }

            return 0;
        }

        public static Dictionary<string, string> GetCustInfo(int custId) //This retrieves customer information when called.
        {
            string query = $"SELECT * FROM customer WHERE customerId = '{custId.ToString()}'";
            MySqlConnection s = new MySqlConnection(AppDatabase.dbConnection);
            s.Open();
            MySqlCommand command = new MySqlCommand(query, s);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            //Basic customer information

            Dictionary<string, string> customerDict = new Dictionary<string, string>();
            customerDict.Add("customerName", reader[1].ToString());
            customerDict.Add("addressId", reader[2].ToString());
            customerDict.Add("active", reader[3].ToString());
            reader.Close();

            query = $"SELECT * FROM address WHERE addressId = '{customerDict["addressId"]}'";
            command = new MySqlCommand(query, s);
            reader = command.ExecuteReader();
            reader.Read();

            //Customer address information

            customerDict.Add("address", reader[1].ToString());
            customerDict.Add("cityId", reader[3].ToString());
            customerDict.Add("postalCode", reader[4].ToString());
            customerDict.Add("phone", reader[5].ToString());
            reader.Close();

            query = $"SELECT * FROM city WHERE cityId = '{customerDict["cityId"]}'";
            command = new MySqlCommand(query, s);
            reader = command.ExecuteReader();
            reader.Read();

            //Customer city information

            customerDict.Add("city", reader[1].ToString());
            customerDict.Add("countryId", reader[2].ToString());
            reader.Close();

            query = $"SELECT * FROM country WHERE countryId = '{customerDict["countryId"]}'";
            command = new MySqlCommand(query, s);
            reader = command.ExecuteReader();
            reader.Read();

            //Customer country information

            customerDict.Add("country", reader[1].ToString());
            reader.Close();
            s.Close();

            return customerDict;
        }

        public static Dictionary<string, string> GetAppInfo(string appId) //Retrieves appointment information when called.
        {
            string query = $"SELECT * FROM appointment WHERE appointmentId = '{appId}'";
            MySqlConnection s = new MySqlConnection(AppDatabase.dbConnection);
            s.Open();
            MySqlCommand command = new MySqlCommand(query, s);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            //Customer appointment information

            Dictionary<string, string> appointmentDict = new Dictionary<string, string>();
            appointmentDict.Add("appointmentId", appId);
            appointmentDict.Add("customerId", reader[1].ToString());
            appointmentDict.Add("type", reader[3].ToString());
            appointmentDict.Add("start", reader[7].ToString());
            appointmentDict.Add("end", reader[8].ToString());
            reader.Close();

            return appointmentDict;
        }

        public static string TimezoneConversion(string dateTime) //This converts time based on timezone of user.
        {
            DateTime utcDateTime = DateTime.Parse(dateTime);
            DateTime localDateTime = utcDateTime.ToLocalTime();

            return localDateTime.ToString("MM/dd/yyyy hh:mm tt");
        }
    }
}
