using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataLayer
{
    public class clsClientsData
    {
        public static bool GetClientInfo(int ClientID, ref stClient Client)
        {
            bool isFound = false; 
            SqlConnection Connection = new SqlConnection(DataSettings.ConnectionString);

            try
            {
                string Query = "SELECT * FROM Clients WHERE ID = @ClientID;"; 
                SqlCommand command = new SqlCommand(Query, Connection);
                command.Parameters.AddWithValue("@ClientID", ClientID);

                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;
                    Client.ID = (int)reader["ID"];
                    Client.FirstName = (string)reader["FirstName"];
                    Client.LastName = (string)reader["LastName"];
                    Client.Email = (string)reader["Email"];
                    Client.PhoneNumber = (string)reader["Phone"];
                    Client.AccountNumber = (string)reader["AccountNumber"];
                    Client.Balance = (decimal)reader["Balance"];
                    Client.PINCode = (int)reader["PinCode"];
                }
                reader.Close(); 
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { Connection.Close(); }

            return isFound;
        }

        public static bool GetClientInfo(string AccountNumber, ref stClient Client)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(DataSettings.ConnectionString);

            try
            {
                string Query = "SELECT * FROM Clients where AccountNumber = @AccountNumber;";
                SqlCommand command = new SqlCommand(Query, Connection);
                command.Parameters.AddWithValue("AccountNumber", AccountNumber);

                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    Client.ID = (int)reader["ID"];
                    Client.FirstName = (string)reader["FirstName"];
                    Client.LastName = (string)reader["LastName"];
                    Client.Email = (string)reader["Email"];
                    Client.PhoneNumber = (string)reader["Phone"];
                    Client.AccountNumber = (string)reader["AccountNumber"];
                    Client.Balance = (decimal)reader["Balance"];
                    Client.PINCode = (int)reader["PinCode"];
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

        public static int AddNew(string FirstName, string LastName, string AccountNumber,
             string Email, string PhoneNumber, decimal AccBalance, int PINCode)
        {
            int ClientID = 0; 
            SqlConnection Connection = new SqlConnection(DataSettings.ConnectionString);

            try
            {
                string Query = @"INSERT INTO Clients 
                      VALUES (@AccountNumber,@FirstName, @LastName,@PhoneNumber, @Email, 
                           @PINCode, @AccountBalance); 
                          SELECT SCOPE_IDENTITY();";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@FirstName", FirstName);
                Command.Parameters.AddWithValue("@LastName", LastName);

                if(Email == string.Empty || Email == "")
                {
                    Command.Parameters.AddWithValue("@Email", DBNull.Value);
                } else
                {
                    Command.Parameters.AddWithValue("@Email", Email);
                }

                Command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                Command.Parameters.AddWithValue("@AccountBalance", AccBalance);
                Command.Parameters.AddWithValue("@PINCode", PINCode);

                Connection.Open();

                object result = Command.ExecuteScalar(); 

                if (result != null && Int32.TryParse(result.ToString(), out int LastID))
                {
                    ClientID = LastID; 
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
            return ClientID;
        }

        public static bool UpdateClient(int ClientID, string FirstName, string LastName, string AccountNumber,
             string Email, string PhoneNumber, decimal AccBalance, int PINCode)
        {
            int RowAffected = 0;
            SqlConnection Connection = new SqlConnection(DataSettings.ConnectionString);

            try
            {
                string Query = @"Update Clients 
                      SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Phone = @PhoneNumber, 
                          AccountNumber = @AccountNumber, Balance = @AccountBalance, PinCode = @PINCode 
                          WHERE ID = @ClientID;";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ClientID", ClientID);
                Command.Parameters.AddWithValue("@FirstName", FirstName);
                Command.Parameters.AddWithValue("@LastName", LastName);
                Command.Parameters.AddWithValue("@Email", Email);
                Command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                Command.Parameters.AddWithValue("@AccountBalance", AccBalance);
                Command.Parameters.AddWithValue("@PINCode", PINCode);

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

        public static bool DeleteClient(int ClientID)
        {
            int RowAffected = 0;
            SqlConnection Connection = new SqlConnection(DataSettings.ConnectionString);

            try
            {
                string Query = "DELETE  FROM Clients where ID = @ClientID;";
                SqlCommand command = new SqlCommand(Query, Connection);
                command.Parameters.AddWithValue("ClientID", ClientID);

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

        public static bool DeleteClient(string AccountNumber)
        {
            int RowAffected = 0;
            SqlConnection Connection = new SqlConnection(DataSettings.ConnectionString);

            try
            {
                string Query = "DELETE  FROM Clients where AccountNumber = @AccountNumber;";
                SqlCommand command = new SqlCommand(Query, Connection);
                command.Parameters.AddWithValue("AccountNumber", AccountNumber);

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

        public static bool isClientExist(int ClientID)
        {
            bool isExist = false;
            SqlConnection Connection = new SqlConnection(DataSettings.ConnectionString);
            try
            {
                string Query = "Select FirstName From Clients where ID = @ClientID;";
                SqlCommand command = new SqlCommand(Query, Connection);
                command.Parameters.AddWithValue("@ClientID", ClientID);

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

        public static bool isClientExist(string AccountNumber)
        {
            bool isExist = false;
            SqlConnection Connection = new SqlConnection(DataSettings.ConnectionString);
            try
            {
                string Query = "Select FirstName From Clients where AccountNumber = @AccountNumber;";
                SqlCommand command = new SqlCommand(Query, Connection);
                command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

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

        public static DataTable ClientsList()
        {
            DataTable ClientsTable = new DataTable();
          
            SqlConnection Connection = new SqlConnection(DataSettings.ConnectionString);
            try
            {
                string Query = "Select * From Clients;";
                SqlCommand command = new SqlCommand(Query, Connection);

                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    ClientsTable.Load(reader); 
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { Connection.Close(); }


            return ClientsTable;
        }
    }
}
