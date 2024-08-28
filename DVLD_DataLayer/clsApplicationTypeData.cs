using Microsoft.Data.SqlClient;
using System.Data;

namespace DVLD_DataLayer
{
    public class clsApplicationTypeData
    {
        public static DataTable GetApplicationTypes()
        {
            DataTable dt = new DataTable();


            string query = "SELECT  *  From ApplicationTypes";

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

        public static bool GetApplicationTypeByID(int ApplicationTypeID, ref string ApplicationTypeTitle, ref decimal ApplicationFees)
        {
            bool IsFound = false;



            string query = "SELECT  *  From ApplicationTypes Where ApplicationTypeID = @ApplicationTypeID ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                            ApplicationFees = (decimal)reader["ApplicationFees"];

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
        public static bool UpdateApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            int rowAffected = -1;



            string query = "UPDATE ApplicationTypes SET ApplicationTypeTitle = @ApplicationTypeTitle, ApplicationFees = @ApplicationFees   WHERE ApplicationTypeID=@ApplicationTypeID ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
                    command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
                    command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

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

    }
}
