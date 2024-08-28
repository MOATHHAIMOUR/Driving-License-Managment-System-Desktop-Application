using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class clsTestAppoinmentData
    {

        public static DataTable GetTestAppointments(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            DataTable dt = new DataTable();



            string query = @"SELECT TestAppointmentID, AppointmentDate, PaidFees, IsLocked From TestAppointments where TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID  and TestTypeID=@TestTypeID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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

        public static int AddNewTestAppointments(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, int RetakenTestApplicationID, bool IsLocked)
        {
            int insertedID = -1;



            string query = "INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, RetakenTestApplicationID, IsLocked) VALUES (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @RetakenTestApplicationID, @IsLocked);Select SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                    command.Parameters.AddWithValue("@PaidFees", PaidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    if (RetakenTestApplicationID == 0)
                        command.Parameters.AddWithValue("@RetakenTestApplicationID", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@RetakenTestApplicationID", RetakenTestApplicationID);

                    command.Parameters.AddWithValue("@IsLocked", IsLocked);

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

        public static bool GetTestAppointmentByTestAppointmentID(int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID, ref int RetakenTestApplicationID, ref bool IsLocked)
        {
            bool IsFound = false;



            string query = "SELECT  *  From TestAppointments Where TestAppointmentID = @TestAppointmentID ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            TestTypeID = (int)reader["TestTypeID"];
                            LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                            AppointmentDate = (DateTime)reader["AppointmentDate"];
                            PaidFees = (decimal)reader["PaidFees"];
                            CreatedByUserID = (int)reader["CreatedByUserID"];
                            if (reader["RetakenTestApplicationID"] != DBNull.Value)
                                RetakenTestApplicationID = (int)reader["RetakenTestApplicationID"];
                            else
                                RetakenTestApplicationID = 0;
                            IsLocked = (bool)reader["IsLocked"];

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

        public static bool UpdateTestAppointmentByTestAppointmentID(int TestAppointmentID, DateTime AppointmentDate)
        {
            int rowAffected = -1;



            string query = "UPDATE TestAppointments SET AppointmentDate = @AppointmentDate   WHERE TestAppointmentID=@TestAppointmentID ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


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

        public static bool UpdateTestAppoinmetnsToLockedStatus(int TestAppointmentID, bool IsLocked)
        {
            int rowAffected = -1;



            string query = "UPDATE TestAppointments SET IsLocked = @IsLocked   WHERE TestAppointmentID=@TestAppointmentID ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IsLocked", IsLocked);
                    //Error code gen
                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


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

        public static bool IsAppointmentLocked(int TestAppointmentID)
        {
            bool isLocked = false;

            string query = @"Select IsLocked from TestAppointments where  TestAppointments.TestAppointmentID = @TestAppointmentID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            isLocked = Convert.ToBoolean(result);
                        }


                    }
                    catch (Exception ex)
                    {  //your logic to handle errors
                       //Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return isLocked;
        }

        public static bool IsApplicantPassTestPerTestYpe(int LocalDrivingApplicationID, int TestTypeID)
        {
            bool isPass = false;



            string query = "Select IsFaildwithLastTest=1 from TestAppointments inner join Tests on Tests.TestAppointmentID = TestAppointments.TestAppointmentID where TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingApplicationID  and TestTypeID = @TestTypeID and TestAppointments.IsLocked = 1 and Tests.TestResult = 1";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingApplicationID", LocalDrivingApplicationID);


                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            isPass = true;
                        }


                    }
                    catch (Exception ex)
                    {  //your logic to handle errors
                       //Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return isPass;
        }

        public static int GetTestID(int TestAppointmentID)
        {
            int TestID = -1;
            string connectionString = clsDataAccessSettings.ConnectionString;
            string query = @"SELECT TestID FROM Tests WHERE TestAppointmentID=@TestAppointmentID;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            TestID = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log or handle the exception as needed
                        // Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return TestID;
        }
      
        public static bool CheckIfApplicantHasAnActiveTest(int LocalDrivingApplication, int TestType)
        {
            bool IsApplicantHasAnActiveTest = false;



            string query = @"   Select IsApplicantHanAnActiveTest = 1 from TestAppointments 
   where LocalDrivingLicenseApplicationID = @LocalDrivingApplication  and TestTypeID = @TestType and IsLocked = 0";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestType", TestType);
                    command.Parameters.AddWithValue("@LocalDrivingApplication", LocalDrivingApplication);


                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            IsApplicantHasAnActiveTest = true;
                        }


                    }
                    catch (Exception ex)
                    {  //your logic to handle errors
                       //Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return IsApplicantHasAnActiveTest;
        }

        public static bool IsApplicantFirstTimeDoingTest(int LocalDrivingApplicationID, int TestTypeID)
        {
            bool isFirsTime = true;



            string query = "Select top 1 IsfirstTime=1 from TestAppointments where TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingApplicationID and TestAppointments.TestTypeID = @TestTypeID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingApplicationID", LocalDrivingApplicationID);
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            isFirsTime = false;
                        }


                    }
                    catch (Exception ex)
                    {  //your logic to handle errors
                       //Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return isFirsTime;
        }

        public static int HowManyTriesForTestType(int LocalDrivingApplicationID, int TestTypeID)
        {
            int Tries = 0;

            string query = @"select Count(*) AsNumberOfTries from TestAppointments where LocalDrivingLicenseApplicationID = @LocalDrivingApplicationID and  TestTypeID= @TestTypeID and IsLocked = 1";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingApplicationID", LocalDrivingApplicationID);
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            Tries = Convert.ToInt32(result);
                        }


                    }
                    catch (Exception ex)
                    {  //your logic to handle errors
                       //Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return Tries;
        }
    }
}
