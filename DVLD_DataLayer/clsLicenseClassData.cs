using Microsoft.Data.SqlClient;
using System.Data;

namespace DVLD_DataLayer
{
    public class clsLicenseClassData
    {
        public static bool GetLicenseClasseInfoByID(int LicenseClassID, ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool IsFound = false;


            string query = "SELECT  *  From LicenseClasses Where LicenseClassID = @LicenseClassID ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            ClassName = (string)reader["ClassName"];
                            ClassDescription = (string)reader["ClassDescription"];
                            MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                            DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                            ClassFees = (decimal)reader["ClassFees"];

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

        public static bool GetLicenseClasseInfoByClassName(string ClassName , ref int LicenseClassID, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool IsFound = false;


            string query = "SELECT  *  From LicenseClasses Where ClassName = @ClassName ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClassName", ClassName);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            LicenseClassID = (int)reader["LicenseClassID"];
                            ClassDescription = (string)reader["ClassDescription"];
                            MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                            DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                            ClassFees = (decimal)reader["ClassFees"];

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

        public static DataTable GetAllLicenseClasses()
        {
            DataTable dt = new DataTable();


            string query = "SELECT  *  From LicenseClasses";

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



    
    }
}
