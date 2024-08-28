using Microsoft.Data.SqlClient;
using System.Data;


namespace DVLD_DataLayer
{
    public class clsApplicationData
    {
        public static bool GetApplicationInfoByID(int ApplicationID, ref int ApplicantPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID, ref byte ApplicationStatus, ref DateTime LastStatusDate, ref decimal PaidFees, ref int CreatedByUserID)
        {
            bool IsFound = false;



            string query = "SELECT  *  From Applications Where ApplicationID = @ApplicationID ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            ApplicantPersonID = (int)reader["ApplicantPersonID"];
                            ApplicationDate = (DateTime)reader["ApplicationDate"];
                            ApplicationTypeID = (int)reader["ApplicationTypeID"];
                            ApplicationStatus = (byte)reader["ApplicationStatus"];
                            LastStatusDate = (DateTime)reader["LastStatusDate"];
                            PaidFees = (decimal)reader["PaidFees"];
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

        public static int AddNewApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            int insertedID = -1;



            string query = "INSERT INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID) VALUES (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID);Select SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                    command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
                    command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                    command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                    command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
                    command.Parameters.AddWithValue("@PaidFees", PaidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        public static DataTable GetLocalDrivingLicenseApplications_View()
        {
            DataTable dt = new DataTable();



            string query = "SELECT  *  From LocalDrivingLicenseApplications_View";

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

        public static bool UpdateStatus(int ApplicationID, byte NewStatus)
        {
            int rowAffected = -1;



            string query = "UPDATE Applications SET ApplicationStatus = @ApplicationStatus   WHERE ApplicationID=@ApplicationID ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    command.Parameters.AddWithValue("@ApplicationStatus", NewStatus);


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

        public static int GetActiveApplicationIDForLicenseClass(int ApplicantPersonID, int ApplicationTypeID, int LicenseClassID)
        {
            int ActiveApplicationID = -1;


            string query = @"SELECT ActiveApplicationID=Applications.ApplicationID  
                            From
                            Applications INNER JOIN
                            LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                            WHERE ApplicantPersonID = @ApplicantPersonID 
                            and ApplicationTypeID=@ApplicationTypeID 
							and LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                            and ApplicationStatus=1";


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                    command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                    command.Parameters.AddWithValue("@LocalLicenseID", LicenseClassID);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            ActiveApplicationID = (int)result;
                        }


                    }
                    catch (Exception ex)
                    {  //your logic to handle errors
                       //Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return ActiveApplicationID;
        }

    }
}
