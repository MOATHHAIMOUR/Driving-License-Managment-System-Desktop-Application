using Microsoft.Data.SqlClient;
using System.Data;

namespace DVLD_DataLayer
{
    public class clsTestTypeData
    {
        public static bool UpdateTestTypeID(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            int rowAffected = -1;

            string query = "UPDATE TestTypes SET TestTypeTitle = @TestTypeTitle, TestTypeDescription = @TestTypeDescription, TestTypeFees = @TestTypeFees   WHERE TestTypeID=@TestTypeID ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
                    command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
                    command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);

                    try
                    {
                        connection.Open();

                        rowAffected = command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {  //your logic to handle errors
                       //Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return rowAffected > 0;
        }

        public static DataTable GetTestTypes()
        {
            DataTable dt = new DataTable();

            string query = "SELECT  *  From TestTypes";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }

                    }
                    catch (Exception ex)
                    {  //your logic to handle errors
                       //Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return dt;
        }

        public static bool GetTestTypeByInfoID(int TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref decimal TestTypeFees)
        {
            bool IsFound = false;

            string query = "SELECT  *  From TestTypes Where TestTypeID = @TestTypeID ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            TestTypeTitle = (string)reader["TestTypeTitle"];
                            TestTypeDescription = (string)reader["TestTypeDescription"];
                            TestTypeFees = (decimal)reader["TestTypeFees"];

                            IsFound = true;
                        }

                    }
                    catch (Exception ex)
                    {  //your logic to handle errors
                       //Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }

            return IsFound;
        }

    }
}
