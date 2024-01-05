using System;
using System.Data.SqlClient;

namespace BankDataLayer
{
    public struct stClient
    {
        public int ID { get; set; }
        public string AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int PINCode { get; set; }
        public decimal Balance { get; set; }
    }

    public struct stUsers
    {
        public int ID { get; set; }
        public string username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string password { get; set; }
        public int permissions { get; set; }
    }

    public struct stCurrencies
    {
        public int ID { get; set; }
        public string Country { get; set; }
        public string Code { get; set; }
        public decimal Rate { get; set; }
        public string Name { get; set; }
       
    }

    public static class DataSettings
    {
        public static string ConnectionString = "Server=.;Database=BankDatabase;User id=sa; password=sa123456;";

       
        public static bool LoginAuthintication(string username, string Password,ref stUsers User)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(DataSettings.ConnectionString);
            try
            {
                string Query = "SELECT * FROM Users WHERE UserName = @username and Password= @Password;";
                SqlCommand command = new SqlCommand(Query, Connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@Password", Password);

                Connection.Open();
          
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    User.ID = (int)reader["ID"];
                    User.FirstName = (string)reader["FirstName"];
                    User.LastName = (string)reader["LastName"];
                    User.Email = (string)reader["Email"];
                    User.PhoneNumber = (string)reader["Phone"];
                    User.username = (string)reader["UserName"];
                    User.password = (string)reader["Password"];
                    User.permissions = (int)reader["permissions"];
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { Connection.Close(); }

            return isFound;
        }

    }
}
