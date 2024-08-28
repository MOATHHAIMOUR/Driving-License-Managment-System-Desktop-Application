using Microsoft.Data.SqlClient;
using System.Data;


namespace DVLD_DataLayer
{
    public class clsLocalDrivingLicenseApplicationData
    {
        public static bool GetLocalDrivingLicenseApplicationInfoByID(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool IsFound = false;



            string query = "SELECT  *  From LocalDrivingLicenseApplications Where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            ApplicationID = (int)reader["ApplicationID"];
                            LicenseClassID = (int)reader["LicenseClassID"];

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

        public static bool GetLocalDrivingLicenseApplicationByApplicationID(int ApplicationID , ref int LocalDrivingLicenseApplicationID , ref int LicenseClassID)
        {
            bool IsFound = false;

            string query = "SELECT  *  From LocalDrivingLicenseApplications Where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ;";

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
                            LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                            LicenseClassID = (int)reader["LicenseClassID"];
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

        public static DataTable GetLocalDrivingLicenseApplications()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * From LocalDrivingLicenseApplications";

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

        public static int AddNewLocalDrivingLicenseApplications(int ApplicationID, int LicenseClassID)
        {
            int insertedID = -1;



            string query = "INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID) VALUES (@ApplicationID, @LicenseClassID);Select SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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

        public static bool DeleteLocalDrivingLicenseApplicationByID(int LocalDrivingLicenseApplicationID)
        {
            int rowAffected = -1;


            string query = "DELETE FROM LocalDrivingLicenseApplications  WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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

        public static bool DosePassTestType(int LocalDrivingLicenseApplicationID,int TestTypeID)
        {
            bool isFound = false;


            string query = "SELECT DoesAttendTestType=1 FROM     TestAppointments where TestAppointments.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and TestTypeID=@TestTypeID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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

        public static bool DoesAttendTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool isFound = false;


            string query = "SELECT DoesAttendTestType=1 FROM     TestAppointments where TestAppointments.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and TestTypeID=@TestTypeID and TestResult=1";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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

        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool isFound = false;

            string query = "SELECT Found = 1 FROM     TestAppointments where TestAppointments.IsLocked = 0 and TestAppointments.LocalDrivingLicenseApplicationID = 8 and TestAppointments.TestTypeID = 1;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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



        public static int numberOfPassedOrFailedTestsPerApplication(int LocalDrivingLicenseApplicationID,int TestResult)
        {
            int Tests = -1;


            string query = "SELECT Count(*) AsNummberOfPassedTests FROM     TestAppointments INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID  and TestResult = @TestResult";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@TestResult", TestResult);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            Tests = Convert.ToInt32(result);
                        }


                    }
                    catch (Exception ex)
                    {  //your logic to handle errors
                       //Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return Tests;
        }
    }
}
