using DVLD_DataLayer;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsUser
    {
        private enum enMode { AddNew, Update }

        private enMode Mode;

        public int UserID { get; set; }
        
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public clsPerson PersonInfo; 


        public clsUser()
        {
            UserID = -1;
            PersonID = -1;
            UserName = "";
            Password = "";
            IsActive = false;
            Mode = enMode.AddNew;
        }

        private clsUser(int userID, int personID, string userName, string password, bool isActive)
        {
            UserID = userID;
            PersonID = personID;
            PersonInfo = clsPerson.Find(personID)!; 
            UserName = userName;
            Password = password;
            IsActive = isActive;
            Mode = enMode.Update;
        }

        private bool _addNewUser()
        {
            UserID = clsUserData.AddNewUser(PersonID, UserName, Password, IsActive);

            return UserID > 0;
        }

        private bool _updateUser()
        {
            return clsUserData.UpdateUser(UserName, Password, IsActive);
        }

        public static DataTable GetUsers()
        {
            return clsUserData.GetAllUsers();
        }


        public static clsUser? FindByUserID(int UserID)
        {
            string Username = "", Password = "";
            bool IsActive = false;
            int PerosnID = -1;

            if (clsUserData.GetUserInfoByUserID(UserID, ref PerosnID, ref Username, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PerosnID, Username, Password, IsActive);
            }
            else
            {
                return null;
            }
        }

        public static clsUser FindByUserName(string Username)
        {
            int UserID = -1, PerosnID = -1;
            string Password = "";
            bool IsActive = false;
            if (clsUserData.GetUserByUserName(Username, ref UserID, ref PerosnID, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PerosnID, Username, Password, IsActive);
            }

            return null;
        }

        public static clsUser FindByPersonID(int PersonID)
        {
            int UserID = -1;
            string Password = "",Username="";
            bool IsActive = false;
            if (clsUserData.GetUserByPersonID(PersonID, ref UserID, ref Username, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, Username, Password, IsActive);
            }

            return null;
        }


        public static bool IsUserExistByUserName(string username)
        {
            return clsUserData.IsExistUserByUserName(username);
        }


        public static bool IsUserExistByPersonID(int PersonID)
        {
            return clsUserData.IsUserExistByPersonID(PersonID);
        }

    

      

        public static bool DeleteUserByUserID(int UserID)
        {
            return clsUserData.DeleteUserByUserID(UserID);
        }
        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_addNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false; 
                    }

                case enMode.Update:
                    return _updateUser();

                default:
                    throw new Exception("Unkown mode");

            }


        }

    }
}
