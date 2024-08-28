using DVLD_DataLayer;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsTestAppointment
    {

        public enum enMode { AddNew, Update }
        public enMode Mode { set; get; }

       
        public int TestAppoinmentsID { set; get; }
        public clsTestType.enTestType TestTypeID { get; set; }
        
        public int LocalDrivingLicenseApplicationID { get; set; }


        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        public int TestID
        {
            get { return _GetTestID(TestAppoinmentsID);  }
        }

        public int RetakenTestApplicationID { get; set; }
        //composition
        public clsApplication? RetakeTestApplicationInfo { set; get; } 

        public bool IsLocked { get; set; }

        private clsTestAppointment(int testAppoinmentsID, clsTestType.enTestType testTypeID, int localDrivingLicenseApplicationID, DateTime appointmentDate, decimal paidFees, int createdByUserID, int retakenTestApplicationID, bool isLocked)
        {
            TestAppoinmentsID = testAppoinmentsID;
            TestTypeID = testTypeID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            RetakenTestApplicationID = retakenTestApplicationID;
            this.RetakeTestApplicationInfo = clsApplication.FindBaseApplication(retakenTestApplicationID);
            IsLocked = isLocked;
            Mode = enMode.Update;
        }


        public clsTestAppointment()
        {
            TestAppoinmentsID = -1;
            TestTypeID = clsTestType.enTestType.VisionTest;
            LocalDrivingLicenseApplicationID = -1;
            AppointmentDate = DateTime.Now;
            PaidFees = 1;
            CreatedByUserID = 1;
            RetakenTestApplicationID = 0;
            IsLocked = false;
            Mode = enMode.AddNew;
        }


        private bool _addNewTestApplication()
        {
            TestAppoinmentsID = clsTestAppoinmentData.AddNewTestAppointments(
                (int)TestTypeID,
                LocalDrivingLicenseApplicationID,
                AppointmentDate,
                PaidFees,
                CreatedByUserID,
                RetakenTestApplicationID,
                IsLocked
            );

            return TestAppoinmentsID > 0;
        }

        private bool UpdateTestAppoinments()
        {
            return clsTestAppoinmentData.UpdateTestAppointmentByTestAppointmentID(TestAppoinmentsID, AppointmentDate);
        }


        private int _GetTestID(int TestAppointmentID)
        {
            return clsTestAppoinmentData.GetTestID(TestAppointmentID);   
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    return _addNewTestApplication();

                case enMode.Update:
                    return UpdateTestAppoinments();

            }

            return false;
        }


        public static DataTable GetTestAppoinments(int LocalDrivingApplication, clsTestType.enTestType TestTypeID)
        {
            return clsTestAppoinmentData.GetTestAppointments(LocalDrivingApplication,(int) TestTypeID);
        }


        public static clsTestAppointment? Find(int TestAppoinmentsID)
        {

            DateTime AppointmentDate = DateTime.Now;
            int TestTypeID = 0, LocalDrivingLicenseApplicationID = 0, RetakenTestApplicationID = 0, CreatedByUserID = 0;
            decimal PaidFees = 0;
            bool IsLocked = false;

            if (clsTestAppoinmentData.GetTestAppointmentByTestAppointmentID(TestAppoinmentsID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref RetakenTestApplicationID, ref IsLocked))
            {
                // I need only know the date from Appoitment
                return new clsTestAppointment(TestAppoinmentsID, (clsTestType.enTestType)TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, RetakenTestApplicationID, IsLocked);
            }
            return null;
        }


        public bool UpdateTestAppoinmentToLockedStatus()
        {
            return clsTestAppoinmentData.UpdateTestAppoinmetnsToLockedStatus(TestAppoinmentsID, true);
        }

        public static bool IsTestAppoinmentLocked(int AppointmenID)
        {
            return clsTestAppoinmentData.IsAppointmentLocked(AppointmenID);
        }

        public static bool IsApplicantPassTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
        {
            return clsTestAppoinmentData.IsApplicantPassTestPerTestYpe(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public static bool checkIfApplicantHasAnActiveTest(int LocalDrivingLicneseApplication, int TestTypeID)
        {
            return clsTestAppoinmentData.CheckIfApplicantHasAnActiveTest(LocalDrivingLicneseApplication, TestTypeID);
        }

        public static bool IsFirstTimeDoingTest(int LocalDrivingLicneseApplication, int TestTypeID)
        {
            return clsTestAppoinmentData.IsApplicantFirstTimeDoingTest(LocalDrivingLicneseApplication, TestTypeID);
        }

        public static int HowManyTimeUserdoingTest(int LocalDrivingLicneseApplication, clsTestType.enTestType TestTypeID)
        {
            return clsTestAppoinmentData.HowManyTriesForTestType(LocalDrivingLicneseApplication, (int)TestTypeID);
        }
    }

}
