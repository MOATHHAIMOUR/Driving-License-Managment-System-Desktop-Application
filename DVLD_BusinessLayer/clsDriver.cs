using DVLD_DataLayer;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsDriver
    {
        public int DriverID { set; get; }
        public int PersonID { get; set; }
        //composition
        public clsPerson PersonInfo;
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsDriver()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedByUserID = -1;
            CreatedDate = DateTime.Now;
        }

        public clsDriver(int driverID, int personID, int createdByUserID, DateTime createdDate)
        {
            DriverID = driverID;
            PersonID = personID;
            CreatedByUserID = createdByUserID;
            CreatedDate = createdDate;
            PersonInfo = clsPerson.Find(personID)!;
        }


        public static clsDriver? FindDriverByPersonID(int PersonID)
        {
            int DriverID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;
            bool Found = clsDriverData.GetDriverByPersonID(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate);

            if (Found)
            {
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else
                return null; 
        }

        public static clsDriver? FindDriver(int DriverID)
        {
            int PersonID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;
            bool Found = clsDriverData.GetDriverByDriverID(DriverID,ref PersonID, ref CreatedByUserID, ref CreatedDate);

            if (Found)
            {
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else
                return null;
        }

        public static DataTable GetAllDrivers()
        {
            return clsDriverData.GetDrivers();
        }

        private bool _AddNewDriver()
        {
            DriverID = clsDriverData.AddNewDriver(PersonID, CreatedByUserID, CreatedDate);
            return DriverID > 0;
        }

        public bool Save()
        {
            return _AddNewDriver();
        }
    }
}
