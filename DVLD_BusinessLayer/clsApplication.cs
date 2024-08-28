using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class clsApplication
    {

        public enum enMode { Update, AddNew }

        public enMode Mode { set; get; }

        public enum enApplicationType
        {
            NewDrivingLicense = 1,
            RenewDrivingLicense = 2,
            ReplacementLostDrivingLicense = 3,
            ReplacementDamagedDrivingLicense = 4,
            ReleaseDetainedDrivingLicense = 5,
            NewInternationalLicense = 6,
            RetakeTest = 7
        }
        public enum enApplicationStatus
        {
            New = 1,
            Cancelled = 2,
            Completed = 3,
        }

        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; } 
        public clsPerson PersonInfo; 
       
        public DateTime ApplicationDate { get; set; }
        
        public int ApplicationTypeID { get; set; }
        //composition
        public clsApplicationType applicationTypeInfo;
        
        public enApplicationStatus ApplicationStatus { get; set; }
        public string StatusText
        {
            get
            {

                switch (ApplicationStatus)
                {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";
                }
            }

        }

       
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }

        //composition
        public int CreatedByUserID { get; set; }

        public clsUser CreatedByUserInfo; 


        private clsApplication(int applicationID, int applicantPersonID, DateTime applicationDate, clsApplication.enApplicationType applicationTypeID, enApplicationStatus applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID)
        {
            ApplicationID = applicationID;
            ApplicantPersonID = applicantPersonID;
            PersonInfo = clsPerson.Find(applicantPersonID)!; 
            ApplicationDate = applicationDate;
            ApplicationTypeID = (int)applicationTypeID;
            applicationTypeInfo = clsApplicationType.Find(applicationTypeID)!;
            ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            CreatedByUserInfo = clsUser.FindByUserID(createdByUserID)!;
            Mode = enMode.Update; 
        }

        public clsApplication()
        {
            ApplicationID = 0;
            ApplicantPersonID = 0;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = -1;
            ApplicationStatus = enApplicationStatus.New;
            LastStatusDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = 0;
            Mode = enMode.AddNew;
        }


        public static clsApplication? FindBaseApplication(int ApplicationID)
        {
            int ApplicationPersonID = 0, ApplicationTypeID = 0, CreatedByUserID = 0;
            byte ApplicationStatus = 0;
            decimal PaidFees = 0;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;


            if (clsApplicationData.GetApplicationInfoByID(ApplicationID, ref ApplicationPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                /*
                                return new clsApplication(ApplicationID, ApplicationPersonID,
                                   ApplicationDate,
                                 ApplicationTypeID,
                                  ApplicationStatus,
                                   LastStatusDate,
                                  PaidFees,
                                    CreatedByUserID
                                );*/
                return null; 
            }
            else
            {
                return null;
            }

        }


        public static bool Cancel(int ApplicationID, byte ApplicationStatus)
        {
            return clsApplicationData.UpdateStatus(ApplicationID, (int)enApplicationStatus.Cancelled);
        }

        public  bool SetComplete()
        {
            return clsApplicationData.UpdateStatus(this.ApplicationID, (int)enApplicationStatus.Completed);
        }


        private bool _addNew()
        {
           // ApplicationID = clsApplicationData.AddNewApplication(ApplicantPersonID, ApplicationDate, ApplicationTypeID, enApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);

            return   true;
        }

        public bool Save()
        {
            if (Mode == enMode.AddNew)
            {
                return _addNew();
            }
            return false;
        }

        public static int CheckPersonIsHaveAnActiveLicense(int PersonId, enApplicationType enApplicationType, int LicenseClassID)
        {
            return GetActiveApplicationIDForLicenseClass(PersonId, enApplicationType, LicenseClassID);
        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, clsApplication.enApplicationType ApplicationTypeID, int LicenseClassID)
        {
            return clsApplicationData.GetActiveApplicationIDForLicenseClass(PersonID, (int)ApplicationTypeID, LicenseClassID);
        }

    }
}
