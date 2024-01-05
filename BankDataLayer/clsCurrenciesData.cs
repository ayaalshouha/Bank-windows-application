using System;
using System.Data.SqlClient;
using System.Data;

namespace BankDataLayer
{
    public class clsCurrenciesData
    {
        public static DataTable GetAllCurrencies()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);

            try
            {
                string query = "SELECT * FROM Currencies;";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool GetCurrencyInfo_Code(string Code, ref stCurrencies Currency)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);

            try
            {
                string query = "SELECT * FROM Currencies WHERE Code = @Code;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Code", Code);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Currency.ID = (int)reader["ID"];
                    Currency.Country = (string)reader["Country"];
                    Currency.Code = (string)reader["Code"];
                    Currency.Name = (string)reader["Name"];
                    Currency.Rate = (decimal)reader["Rate"];

                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetCurrencyInfo_Country(string Country, ref stCurrencies Currency)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            try
            {
                string query = "SELECT * FROM Currencies WHERE Country = @Country;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Country", Country);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Currency.ID = (int)reader["ID"];
                    Currency.Country = (string)reader["Country"];
                    Currency.Code = (string)reader["Code"];
                    Currency.Name = (string)reader["Name"];
                    Currency.Rate = (decimal)reader["Rate"];

                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }


        public static bool UpdateRate(int ID, decimal NewRate)
        {
            int RowAffected = 0; 
            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);
            
            try
            {
                string query = "UPDATE Currencies SET Rate = @Rate WHERE ID = @ID;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Rate", NewRate);
                command.Parameters.AddWithValue("@ID", ID);

                connection.Open();
                RowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return (RowAffected > 0);
        }

    }


}

