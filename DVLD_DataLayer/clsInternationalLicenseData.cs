using Microsoft.Data.SqlClient;
using System.Data;

namespace DVLD_DataLayer
{
    public class clsInternationalLicenseData
    {
        public static bool GetInternationalLicenseByInternationalLicenseID(int InternationalLicenseID, ref int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool IsFound = false;

            string query = "SELECT  *  From InternationalLicenses Where InternationalLicenseID = @InternationalLicenseID ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            ApplicationID = (int)reader["ApplicationID"];
                            DriverID = (int)reader["DriverID"];
                            IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                            IssueDate = (DateTime)reader["IssueDate"];
                            ExpirationDate = (DateTime)reader["ExpirationDate"];
                            IsActive = (bool)reader["IsActive"];
                            CreatedByUserID = (int)reader["CreatedByUserID"];

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


        public static DataTable GetInternationalLicenses()
        {
            DataTable dt = new DataTable();


            string query = "SELECT  *  From InternationalLicenses";

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



        public static int GetActiveInternationalLicenseID(int DriverID)
        {
            int InternationalLicenseID = -1;


            string query = "SELECT DriverID FROM InternationalLicenses WHERE DriverID = @DriverID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DriverID", DriverID);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            InternationalLicenseID = Convert.ToInt32(result);
                        }


                    }
                    catch (Exception ex)
                    {  //your logic to handle errors
                       //Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return InternationalLicenseID;
        }


    }
}
