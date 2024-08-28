using Microsoft.Data.SqlClient;
using System.Data;


namespace DVLD_DataLayer
{
    public class clsDetainLicenseData
    {

        public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            int insertedID = -1;



            string query = "INSERT INTO DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID) VALUES (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID);Select SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);
                    command.Parameters.AddWithValue("@DetainDate", DetainDate);
                    command.Parameters.AddWithValue("@FineFees", FineFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    command.Parameters.AddWithValue("@IsReleased", IsReleased);

                    command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate == null ? DBNull.Value : ReleaseDate);
                    command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID == null ? DBNull.Value : ReleasedByUserID);
                    command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID == null ? DBNull.Value : ReleaseApplicationID);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                        {
                            insertedID = ID;
                        }


                    }
                    catch (Exception ex)
                    {  //your logic to handle errors
                       //Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return insertedID;
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            bool isFound = false;

            string query = "SELECT IsDetained=1 FROM DetainedLicenses WHERE LicenseID = @LicenseID and IsReleased=0;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            isFound = true;
                        }

                    }
                    catch (Exception ex)
                    {  //your logic to handle errors
                       //Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return isFound;
        }

        public static bool GetDetainedLicenseInfoByLicenseIDID(int LicenseID, ref int DetainID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime? ReleaseDate, ref int? ReleasedByUserID, ref int? ReleaseApplicationID)
        {
            bool IsFound = false;



            string query = "SELECT  *  From DetainedLicenses Where LicenseID = @LicenseID ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            DetainID = (int)reader["DetainID"];
                            DetainDate = (DateTime)reader["DetainDate"];
                            FineFees = (decimal)reader["FineFees"];
                            CreatedByUserID = (int)reader["CreatedByUserID"];
                            IsReleased = (bool)reader["IsReleased"];
                            ReleaseDate = reader["ReleaseDate"] == DBNull.Value ? null : (DateTime)reader["ReleaseDate"];
                            ReleasedByUserID = reader["ReleasedByUserID"] == DBNull.Value ? null : (int)reader["ReleasedByUserID"];
                            ReleaseApplicationID = reader["ReleaseApplicationID"] == DBNull.Value ? null : (int)reader["ReleaseApplicationID"];

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

        public static bool GetDetainedLicenseInfoByID(int DetainID, ref int LicenseID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime? ReleaseDate, ref int? ReleasedByUserID, ref int? ReleaseApplicationID)
        {
            bool IsFound = false;



            string query = "SELECT  *  From DetainedLicenses Where DetainID = @DetainID ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DetainID", DetainID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            LicenseID = (int)reader["LicenseID"];
                            DetainDate = (DateTime)reader["DetainDate"];
                            FineFees = (decimal)reader["FineFees"];
                            CreatedByUserID = (int)reader["CreatedByUserID"];
                            IsReleased = (bool)reader["IsReleased"];
                            ReleaseDate = reader["ReleaseDate"] == DBNull.Value ? null : (DateTime)reader["ReleaseDate"];
                            ReleasedByUserID = reader["ReleasedByUserID"] == DBNull.Value ? null : (int)reader["ReleasedByUserID"];
                            ReleaseApplicationID = reader["ReleaseApplicationID"] == DBNull.Value ? null : (int)reader["ReleaseApplicationID"];

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

        public static DataTable GetDetainedLicenses_View()
        {
            DataTable dt = new DataTable();

            string query = "SELECT  *  From DetainedLicenses_View";

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

        public static bool ReleaseDetainedLicense(int DetainID, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int rowAffected = -1;


            string query = "UPDATE DetainedLicenses SET IsReleased = 1, ReleaseDate = @ReleaseDate, ReleasedByUserID = @ReleasedByUserID, ReleaseApplicationID = @ReleaseApplicationID   WHERE DetainID=@DetainID ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DetainID", DetainID);
                    command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate == null ? DBNull.Value : ReleaseDate);
                    command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID == null ? DBNull.Value : ReleasedByUserID);
                    command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID == null ? DBNull.Value : ReleaseApplicationID);

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



        public static bool UpdateDetainedLicenses(bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int rowAffected = -1;


            string query = "UPDATE DetainedLicenses SET IsReleased = @IsReleased, ReleaseDate = @ReleaseDate, ReleasedByUserID = @ReleasedByUserID, ReleaseApplicationID = @ReleaseApplicationID   ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IsReleased", IsReleased);
                    command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate == null ? DBNull.Value : ReleaseDate);
                    command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID == null ? DBNull.Value : ReleasedByUserID);
                    command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID == null ? DBNull.Value : ReleaseApplicationID);

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

        public static bool ReleaseDetainLicense(bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int rowAffected = -1;


            string query = "UPDATE DetainedLicenses SET IsReleased = 1, ReleaseDate = @ReleaseDate, ReleasedByUserID = @ReleasedByUserID, ReleaseApplicationID = @ReleaseApplicationID   ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate == null ? DBNull.Value : ReleaseDate);
                    command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID == null ? DBNull.Value : ReleasedByUserID);
                    command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID == null ? DBNull.Value : ReleaseApplicationID);

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
