using DVLD_DataLayer;
 using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsPerson
    {
        public enum enMode { AddNew, Update }
        public enMode Mode = enMode.AddNew;

        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        
        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }

        }
        
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        private string _ImagePath { set; get; }
        public string ImagePath { get { return _ImagePath; } set { _ImagePath = value; } }

        public clsCountry ContryInfo;


        public clsPerson()
        {
            PersonID = -1;
            NationalNo = "";
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            DateOfBirth = DateTime.Now;
            Gender = false;
            Address = "";
            Phone = "";
            Email = "";
            NationalityCountryID = -1;
            ImagePath = "";
            Mode = enMode.AddNew;
        }

        private clsPerson(int personID, string nationalNo, string firstName, string secondName, string thiredName, string lastName, DateTime dateOfBirth, bool gender, string address, string phone, string email, string countryName, int nationalityCountryID, string imagePath)
        {
            PersonID = personID;
            NationalNo = nationalNo;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thiredName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            Phone = phone;
            Email = email;
            ImagePath = imagePath;
            NationalityCountryID = nationalityCountryID;
            //Composition
            ContryInfo = clsCountry.Find(nationalityCountryID);
            Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            PersonID = clsPersonData.AddNewPerson(NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);

            return PersonID != -1;
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
        }

        public static clsPerson? Find(int personID)
        {
            string NationalNo = "", FirstName = "", SecondName = "", ThiredName = "", LastName = "", Email = "", Address = "", Phone = "", CountryName = "", ImagePath = "";
            bool Gender = false;
            int NationalityCountryID = 0;
            DateTime DateOfBirth = DateTime.Now;

            bool IsFound = clsPersonData.GetPersonInfoByID(personID, ref NationalNo, ref FirstName, ref SecondName, ref ThiredName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);
            if (IsFound)
            {
                return new clsPerson(personID, NationalNo, FirstName, SecondName, ThiredName, LastName, DateOfBirth, Gender, Address, Phone, Email, CountryName, NationalityCountryID, ImagePath);
            }
            return null;
        }

        public static clsPerson? Find(string NationalNo)
        {
            string FirstName = "", SecondName = "", ThiredName = "", LastName = "", Email = "", Address = "", Phone = "", CountryName = "", ImagePath = "";
            bool Gender = false;
            int personID = -1, NationalityCountryID = -1;
            DateTime DateOfBirth = DateTime.Now;

            if (clsPersonData.GetPersonInfoByNationalNO(NationalNo, ref personID, ref FirstName, ref SecondName, ref ThiredName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(personID, NationalNo, FirstName, SecondName, ThiredName, LastName, DateOfBirth, Gender, Address, Phone, Email, CountryName, NationalityCountryID, ImagePath);
            }
            return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdatePerson();

                default:
                    throw new Exception("Unkown mode");
            }
        }

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

        public static bool DeletePerson(int ID)
        {
            return clsPersonData.DeletePerson(ID);
        }

        public static bool IsPersonExistByNO(string NationalNo)
        {
            return clsPersonData.IsPersonExist(NationalNo);
        }

    }
}
