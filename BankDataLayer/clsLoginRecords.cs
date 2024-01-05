using System;
using System.Data.SqlClient;

namespace BankDataLayer
{
    public static class clsLoginRecords
    {
        public static bool SaveLoginRecord(int UserID)
        {
            int RowAffected = 0; 
            DateTime recordTime = DateTime.Now;

            SqlConnection connection = new SqlConnection(DataSettings.ConnectionString);

            try
            {
                string Query = "INSERT INTO LoginRecords VALUES (@UserID, @DateTime);";
                SqlCommand command = new SqlCommand(Query, connection);

                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@DateTime", recordTime);
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

            return RowAffected > 0; 
        }
    }
}
