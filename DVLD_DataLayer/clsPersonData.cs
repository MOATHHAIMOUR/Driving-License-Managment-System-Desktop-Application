using Microsoft.Data.SqlClient;
using System.Data;

namespace DVLD_DataLayer
{
    public static class clsPersonData
    {
        public static bool GetPersonInfoByID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThiredName, ref string LastName, ref DateTime DateOfBirth, ref bool Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFound = false;

            string query = "SELECT  *  From People Where PersonID = @PersonID ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            NationalNo = (string)reader["NationalNo"];
                            FirstName = (string)reader["FirstName"];
                            SecondName = (string)reader["SecondName"];
                            ThiredName = (string)reader["ThiredName"];
                            LastName = (string)reader["LastName"];
                            DateOfBirth = (DateTime)reader["DateOfBirth"];
                            Gender = (bool)reader["Gender"];
                            Address = (string)reader["Address"];
                            Phone = (string)reader["Phone"];
                            NationalityCountryID = (int)reader["NationalityCountryID"];


                            //Email is null in database so we should handle null
                            if (reader["Email"] != DBNull.Value)
                                Email = (string)reader["Email"];
                            else
                                Email = "";

                            //Image is null in database so we should handle null
                            if (reader["ImagePath"] != DBNull.Value)
                                ImagePath = (string)reader["ImagePath"];
                            else
                                ImagePath = "";

                            IsFound = true;
                        }

                    }
                    catch (Exception ex)
                    {

                        IsFound = false;
                        //your logic to handle errors
                        //Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return IsFound;
        }

        public static bool GetPersonInfoByNationalNO(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName, ref string ThiredName, ref string LastName, ref DateTime DateOfBirth, ref bool Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFound = false;



            string query = "SELECT  *  From People Where NationalNo = @NationalNo ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            PersonID = (int)reader["PersonID"];
                            FirstName = (string)reader["FirstName"];
                            SecondName = (string)reader["SecondName"];
                            ThiredName = (string)reader["ThiredName"];
                            LastName = (string)reader["LastName"];
                            DateOfBirth = (DateTime)reader["DateOfBirth"];
                            Gender = (bool)reader["Gender"];
                            Address = (string)reader["Address"];
                            Phone = (string)reader["Phone"];
                            NationalityCountryID = (int)reader["NationalityCountryID"];


                            //Email is null in database so we should handle null
                            if (reader["Email"] != DBNull.Value)
                                Email = (string)reader["Email"];
                            else
                                Email = "";

                            //Image is null in database so we should handle null
                            if (reader["ImagePath"] != DBNull.Value)
                                ImagePath = (string)reader["ImagePath"];
                            else
                                ImagePath = "";

                            IsFound = true;
                        }

                    }
                    catch (Exception ex)
                    {

                        IsFound = false;
                        //your logic to handle errors
                        //Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return IsFound;
        }

        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThiredName, string LastName, DateTime DateOfBirth, bool Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            //this function will return th new PersonID if succeeded, if not -1
            int PersonID = -1;



            string query = "INSERT INTO People (NationalNo, FirstName, SecondName, ThiredName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath) VALUES (@NationalNo, @FirstName, @SecondName, @ThiredName, @LastName, @DateOfBirth, @Gender, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath); SELECT SCOPE_IDENTITY()";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@ThiredName", ThiredName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);


                    if (!string.IsNullOrEmpty(Email))
                        command.Parameters.AddWithValue("@Email", Email);
                    else
                        command.Parameters.AddWithValue("@Email", DBNull.Value);

                    command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

                    if (!string.IsNullOrEmpty(Email))
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    else
                        command.Parameters.AddWithValue("@ImagePath", DBNull.Value);


                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                        {
                            PersonID = ID;
                        }


                    }
                    catch (Exception ex)
                    {  //your logic to handle errors
                       //Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            return PersonID;
        }

        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThiredName, string LastName, DateTime DateOfBirth, bool Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int rowAffected = -1;



            string query = "UPDATE People SET NationalNo = @NationalNo, FirstName = @FirstName, SecondName = @SecondName, ThiredName = @ThiredName, LastName = @LastName, DateOfBirth = @DateOfBirth, Gender = @Gender, Address = @Address, Phone = @Phone, Email = @Email, NationalityCountryID = @NationalityCountryID, ImagePath = @ImagePath   WHERE PersonID=@PersonID ;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    //in code gen not out the conditiond!!
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@ThiredName", ThiredName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

                    if (!string.IsNullOrEmpty(Email))
                        command.Parameters.AddWithValue("@Email", Email);
                    else
                        command.Parameters.AddWithValue("@Email", DBNull.Value);

                    command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

                    if (!string.IsNullOrEmpty(Email))
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    else
                        command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

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

        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();



            string query = "SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThiredName, People.LastName, People.DateOfBirth, case People.Gender when 1 then 'Male' else 'Female' END AS GenderCaption ,People.Address, People.Phone, People.Email, Countries.CountryName FROM     People INNER JOIN               Countries ON People.NationalityCountryID = Countries.CountryID";

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

        public static bool DeletePerson(int PersonID)
        {
            int rowAffected = -1;



            string query = "DELETE FROM People  WHERE PersonID = @PersonID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool IsPersonExist(string NationalNo)
        {
            bool isFound = false;



            string query = "SELECT 1 FROM People WHERE NationalNo = @NationalNo;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);

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

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;


            string query = "SELECT 1 FROM People WHERE PersonID = @PersonID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

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
    }
}
