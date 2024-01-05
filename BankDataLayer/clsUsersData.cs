using System;
using System.Data.SqlClient;
using System.Data;

namespace BankDataLayer
{
    public class clsUsersData
    {
        public static bool GetUserInfo(string username, ref stUsers User)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(DataSettings.ConnectionString);

            try
            {
                string Query = "SELECT * FROM Users WHERE UserName = @username;";
                SqlCommand command = new SqlCommand(Query, Connection);
                command.Parameters.AddWithValue("@username", username);

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

        public static bool GetUserInfo(int UserID, ref stUsers User)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(DataSettings.ConnectionString);

            try
            {
                string Query = "SELECT * FROM Users WHERE ID = @UserID;";
                SqlCommand command = new SqlCommand(Query, Connection);
                command.Parameters.AddWithValue("@UserID", UserID);

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

        public static int AddNew(string FirstName, string LastName, string UserName,
             string Email, string PhoneNumber, string password, int permissions)
        {
            int UserID = 0;
            SqlConnection Connection = new SqlConnection(DataSettings.ConnectionString);

            try
            {
                string Query = @"INSERT INTO Users 
                      VALUES (@UserName,@FirstName, @LastName,@PhoneNumber,@Email,  
                          @password, @permissions); 
                          SELECT SCOPE_IDENTITY();";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@FirstName", FirstName);
                Command.Parameters.AddWithValue("@LastName", LastName);
                Command.Parameters.AddWithValue("@Email", Email);
                Command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                Command.Parameters.AddWithValue("@UserName", UserName);
                Command.Parameters.AddWithValue("@password", password);
                Command.Parameters.AddWithValue("@permissions", permissions);

                Connection.Open();
                object result = Command.ExecuteScalar();

                if (result != null && Int32.TryParse(result.ToString(), out int LastID))
                {
                    UserID = LastID;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Connection.Close();
            }
            return UserID;
        }

        public static bool UpdateUser(int UserID, string FirstName, string LastName, string UserName,
             string Email, string PhoneNumber, string password, int permissions)
        {
            int RowAffected = 0;
            SqlConnection Connection = new SqlConnection(DataSettings.ConnectionString);

            try
            {
                string Query = @"Update Users 
                      SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Phone = @PhoneNumber, 
                          UserName = @UserName, Password = @password, permissions = @permissions 
                          WHERE ID = @UserID;";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@UserID", UserID);
                Command.Parameters.AddWithValue("@FirstName", FirstName);
                Command.Parameters.AddWithValue("@LastName", LastName);
                Command.Parameters.AddWithValue("@Email", Email);
                Command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                Command.Parameters.AddWithValue("@UserName", UserName);
                Command.Parameters.AddWithValue("@password", password);
                Command.Parameters.AddWithValue("@permissions", permissions);

                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Connection.Close();
            }
            return (RowAffected > 0);
        }

        public static bool DeleteUser(int UserID)
        {
            int RowAffected = 0;
            SqlConnection Connection = new SqlConnection(DataSettings.ConnectionString);

            try
            {
                string Query = "DELETE  FROM Users where ID = @UserID;";
                SqlCommand command = new SqlCommand(Query, Connection);
                command.Parameters.AddWithValue("UserID", UserID);

                Connection.Open();
                RowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { Connection.Close(); }

            return (RowAffected > 0);

        }

        public static bool DeleteUser(string username)
        {
            int RowAffected = 0;
            SqlConnection Connection = new SqlConnection(DataSettings.ConnectionString);

            try
            {
                string Query = "DELETE  FROM Users WHERE UserName = @username;";
                SqlCommand command = new SqlCommand(Query, Connection);
                command.Parameters.AddWithValue("username", username);

                Connection.Open();
                RowAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { Connection.Close(); }

            return (RowAffected > 0);

        }

        public static bool isUserExist(int UserID)
        {
            bool isExist = false;
            SqlConnection Connection = new SqlConnection(DataSettings.ConnectionString);
            try
            {
                string Query = "Select FirstName From Users where ID = @UserID;";
                SqlCommand command = new SqlCommand(Query, Connection);
                command.Parameters.AddWithValue("@UserID", UserID);

                Connection.Open();
                object result = command.ExecuteScalar();

                isExist = (result != null) ? true : false;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { Connection.Close(); }

            return isExist;
        }

        public static bool isUserExist(string username)
        {
            bool isExist = false;
            SqlConnection Connection = new SqlConnection(DataSettings.ConnectionString);
            try
            {
                string Query = "Select FirstName From Users where UserName = @username;";
                SqlCommand command = new SqlCommand(Query, Connection);
                command.Parameters.AddWithValue("@username", username);

                Connection.Open();
                object result = command.ExecuteScalar();

                isExist = (result != null) ? true : false;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { Connection.Close(); }

            return isExist;
        }

        public static DataTable UsersList()
        {
            DataTable UsersTable = new DataTable();

            SqlConnection Connection = new SqlConnection(DataSettings.ConnectionString);
            try
            {
                string Query = "Select * From Users;";
                SqlCommand command = new SqlCommand(Query, Connection);

                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    UsersTable.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { Connection.Close(); }


            return UsersTable;
        }

     }
}
