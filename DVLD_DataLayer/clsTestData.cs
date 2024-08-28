using Microsoft.Data.SqlClient;
namespace DVLD_DataLayer
{
    public class clsTestData
    {
        public static int AddNewTest(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int insertedID = -1;



            string query = "INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID) VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);Select SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                    command.Parameters.AddWithValue("@TestResult", TestResult);
                    command.Parameters.AddWithValue("@Notes", Notes);
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


        public static bool GetTestByTestID(int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool IsFound = false;


            string query = "SELECT  *  From Tests Where TestID = @TestID ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestID", TestID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            TestAppointmentID = (int)reader["TestAppointmentID"];
                            TestResult = (bool)reader["TestResult"];
                            Notes = reader["Notes"] == DBNull.Value ? null : (string)reader["Notes"];
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
    }
}
