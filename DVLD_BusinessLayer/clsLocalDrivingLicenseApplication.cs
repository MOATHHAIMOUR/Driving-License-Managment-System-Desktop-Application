using CoreDVLD;
using DVLD_DataLayer;
using System.Data;


namespace DVLD_BusinessLayer
{
    public class clsLocalDrivingLicenseApplication : clsApplication
    {
        public enum enMode { AddNew, Update }
        public enMode Mode { set; get; }

        public int LocalDrivingLicenseApplicationID { set; get; }
        public int LicenseClassID { set; get; }
        //Composition
        public clsLicenseClass LicenseClassInfo; 

        public string FullName
        {
            get
            {
                return base.PersonInfo.FullName;
            }
        }

        public clsLocalDrivingLicenseApplication()
        {
            LocalDrivingLicenseApplicationID = -1;
            LicenseClassID = -1;
            Mode = enMode.AddNew;
        }

        private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int ApplicantPersonID,
             DateTime ApplicationDate, int ApplicationTypeID,
              enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
              decimal PaidFees, int CreatedByUserID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = (int)ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassInfo = clsLicenseClass.Find(LicenseClassID)!;
            Mode = enMode.Update;
        }


        private bool _AddNewLocalDrivingLicenseApplication()
        {
            LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplications(ApplicationID, LicenseClassID);

            return ApplicationID > 0;
        }

        public static clsLocalDrivingLicenseApplication? FindLocalDrivingApplicationByID(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1;
            int LicenseClassID = -1;

            bool IsFound = clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByID
                (LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID);

            if (IsFound)
            {
                //now we find the base Class 
                clsApplication Application =
                    clsApplication.FindBaseApplication(ApplicationID)!;

                //we return new object of that person with the right data
                return new clsLocalDrivingLicenseApplication(
                    LocalDrivingLicenseApplicationID, Application.ApplicationID,
                    Application.ApplicantPersonID,
                                     Application.ApplicationDate, Application.ApplicationTypeID,
                                   (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                                     Application.PaidFees, Application.CreatedByUserID, LicenseClassID);
            }

            return null;
        }

        public static DataTable GetLocalDrivingLicense()
        {
            return clsApplicationData.GetLocalDrivingLicenseApplications_View();
        }

        public bool DoesAttendTestType(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.DoesAttendTestType(LocalDrivingLicenseApplicationID,(int)TestTypeID);
        }

        public static bool IsThereAnActiveScheduledTest(int LocalDrivingApplication,clsTestType.enTestType TestType)
        {
            return clsLocalDrivingLicenseApplicationData.IsThereAnActiveScheduledTest(LocalDrivingApplication, (int)TestType); 
        }

        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.DosePassTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public static int NumberOfPassedOrFaildTests(int LocalDrivingLicenseApplicationID, int TestResult)
        {
            return clsLocalDrivingLicenseApplicationData.numberOfPassedOrFailedTestsPerApplication (LocalDrivingLicenseApplicationID, TestResult);
        } 


        //return the issues Licnses ID
        public int IssueLicenseForTheFirtTime(string Notes, int CreatedByUserID)
        {

            clsDriver? Driver = clsDriver.FindDriverByPersonID(this.ApplicantPersonID);
            int DriverID = -1; 
            if (Driver == null)
            {
                // Add a new Driver to system
                Driver = new clsDriver();
                Driver.PersonID = this.ApplicantPersonID;
                Driver.CreatedDate = DateTime.Now;
                Driver.CreatedByUserID = clsUserSettings.CurrentUser.UserID;

                if (Driver.Save())
                {
                    DriverID = Driver.DriverID;
                }
                else
                {
                    return -1; 
                }
            }
            // we have a Driver in system now create the License
          
            clsLicense License = new clsLicense();
            License.ApplicationID = this.ApplicationID;
            License.DriverID = DriverID; 
            License.LicenseClassID = this.LicenseClassID;
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = DateTime.Now.AddYears(this.LicenseClassInfo.DefaultValidityLength);
            License.Notes = Notes;
            License.PaidFees = this.LicenseClassInfo.ClassFees;
            License.IssueReason = clsLicense.enIssueReason.FirstTime; 
            License.CreatedByUserID = CreatedByUserID;
            License.IsActive = true;
            
            if(License.Save()){
            
                this.SetComplete();
                return License.LicenseID; 
            }
            else
            {
                return -1; 
            }
        }

        public bool Save()
        {
            base.Mode = (clsApplication.enMode)Mode;
            
            if(!base.Save())
                return false;

            //After we save the main application now we save the sub application.
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return false; 

            }

            return false; 

        }
    }
}
