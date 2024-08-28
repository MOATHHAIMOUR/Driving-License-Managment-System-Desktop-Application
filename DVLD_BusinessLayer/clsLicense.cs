using DVLD_DataLayer;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsLicense
    {
        public enum enIssueReason { FirstTime = 1, Renew = 2, DamagedReplacement = 3, LostReplacement = 4 };

        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        //Composition
        public clsDriver DriverInfo; 

        public int LicenseClassID { get; set; }
        public clsLicenseClass LicenseClassInfo; 

        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public enIssueReason IssueReason { get; set; }
        public string IssueReasonText
        {
            get
            {
                return GetIssueReasonText(this.IssueReason);
            }
        }

  
        public int CreatedByUserID { get; set; }

        public bool IsDetained
        {
            get { return clsDetainLicense.IsLicenseDetain(this.LicenseID); }
        }

        public clsDetainLicense DetainedInfo;


        public static string GetIssueReasonText(enIssueReason IssueReason)
        {

            switch (IssueReason)
            {
                case enIssueReason.FirstTime:
                    return "First Time";
                case enIssueReason.Renew:
                    return "Renew";
                case enIssueReason.DamagedReplacement:
                    return "Replacement for Damaged";
                case enIssueReason.LostReplacement:
                    return "Replacement for Lost";
                default:
                    return "First Time";
            }
        }



        public clsLicense()
        {
            ApplicationID = -1;
            DriverID = -1;
            LicenseClassID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = string.Empty;
            PaidFees = 0.0m;
            IsActive = true;
            IssueReason = 0;
            CreatedByUserID = -1;
        }

        public clsLicense(int licenseID, int applicationID, int driverID, int licenseClass, DateTime issueDate, DateTime expirationDate, string notes, decimal paidFees, bool isActive, clsLicense.enIssueReason issueReason, int createdByUserID)
        {
            LicenseID = licenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseClassID = licenseClass;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;

            this.DriverInfo = clsDriver.FindDriverByPersonID(this.DriverID)!;
            this.LicenseClassInfo = clsLicenseClass.Find(this.LicenseClassID);
            this.DetainedInfo = clsDetainLicense.Find(this.LicenseID)!;

        }

        private bool InsertNewLicense()
        {
            // Assuming clsApplicationDataLayer.InsertApplication() is a method that inserts a new application
            // and returns the ApplicationID.
            LicenseID = clsLicenseData.AddNewLicense(ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, (byte)IssueReason, CreatedByUserID);
            return LicenseID > 0;
        }

        public static clsLicense? Find(int LicenseID)
        {
            int ApplicationID = 0, DriverID = 0, LicenseClass = 0, CreatedByUserID = 0;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 0;


            if (clsLicenseData.GetLicenseByID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive,(clsLicense.enIssueReason) IssueReason, CreatedByUserID);
            }

            return null;

        }


        public static bool UpdateLicenseActiveStatus(int LicenseID, bool isActive)
        {
            return clsLicenseData.UpdateLicenseActiveStatus(LicenseID, isActive);
        }


        public bool Save()
        {
            return InsertNewLicense();
        }

        public static bool IsLicenseExistByPersonID(int PersonID, int LicenseClassID)
        {
            return GetActiveLicenseIDByPersonID(PersonID, LicenseClassID) != -1;
        }

        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
        {

            return clsLicenseData.GetActiveLicenseIDByPersonID(PersonID, LicenseClassID);

        }

        public clsLicense? RenewLicense()
        {
            //First Create Applicaiton 
            clsApplication Application = new clsApplication();

            Application.ApplicantPersonID = this.DriverInfo.PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = (int)clsApplication.enApplicationType.RenewDrivingLicense;
            Application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationType.Find(clsApplication.enApplicationType.RenewDrivingLicense)!.ApplicationFees;
            Application.CreatedByUserID = CreatedByUserID;

            if (!Application.Save())
            {
                return null;
            }

            clsLicense NewLicense = new clsLicense();

            NewLicense.ApplicationID = Application.ApplicationID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.LicenseClassID = this.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;

            int DefaultValidityLength = this.LicenseClassInfo.DefaultValidityLength;

            NewLicense.ExpirationDate = DateTime.Now.AddYears(DefaultValidityLength);
            NewLicense.Notes = Notes;
            NewLicense.PaidFees = this.LicenseClassInfo.ClassFees;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = clsLicense.enIssueReason.Renew;
            NewLicense.CreatedByUserID = CreatedByUserID;


            if (!NewLicense.Save())
            {
                return null;
            }

            //we need to deactivate the old License.
            this.DeactivateCurrentLicense();

            return NewLicense;


        }

        public clsLicense? Replace(enIssueReason IssueReason ,int CreatedByUser)
        {

            //First Create Applicaiton 
            clsApplication Application = new clsApplication();

            Application.ApplicantPersonID = this.DriverInfo.PersonID;
            Application.ApplicationDate = DateTime.Now;

            Application.ApplicationTypeID = (IssueReason == enIssueReason.DamagedReplacement) ?
                (int)clsApplication.enApplicationType.ReplacementDamagedDrivingLicense :
                (int)clsApplication.enApplicationType.ReplacementLostDrivingLicense;

            Application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationType.Find((clsApplication.enApplicationType)Application.ApplicationTypeID).ApplicationFees;
            Application.CreatedByUserID = CreatedByUserID;

            if (!Application.Save())
            {
                return null;
            }

            clsLicense NewLicense = new clsLicense();

            NewLicense.ApplicationID = Application.ApplicationID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.LicenseClassID = this.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = this.ExpirationDate;
            NewLicense.Notes = this.Notes;
            NewLicense.PaidFees = 0;// no fees for the license because it's a replacement.
            NewLicense.IsActive = true;
            NewLicense.IssueReason = IssueReason;
            NewLicense.CreatedByUserID = CreatedByUserID;



            if (!NewLicense.Save())
            {
                return null;
            }

            //we need to deactivate the old License.
            DeactivateCurrentLicense();

            return NewLicense;
        }

        public clsDetainLicense? DetainLicense(decimal FineFees,int CreatedByUserID)
        {
             
            clsDetainLicense DetainLicense = new clsDetainLicense();

            DetainLicense.DetainDate = DateTime.Now;
            DetainLicense.FineFees = FineFees;
            DetainLicense.CreatedByUserID= CreatedByUserID;
            DetainLicense.IsReleased = false;
            DetainLicense.ReleasedUserInfo = null;
            DetainLicense.ReleaseDate = null;
            DetainLicense.ReleaseApplicationID = null;

            if (!DetainLicense.Save())
                return null;

           return DetainLicense; 
        }

        public clsDetainLicense? ReleaseDetainLicense(int CreatedBy)
        {

            clsDetainLicense? DetainLicense = clsDetainLicense.Find(this.LicenseID);
            
            if (DetainLicense == null)
                return null;

            clsApplication Application = new clsApplication();

            Application.ApplicantPersonID = this.DriverInfo.PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = (int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicense;
            Application.LastStatusDate= DateTime.Now;
            Application.PaidFees = clsApplicationType.Find(clsApplication.enApplicationType.ReleaseDetainedDrivingLicense)!.ApplicationFees;
            Application.CreatedByUserID = CreatedBy;

            if (!Application.Save())
                return null;


            bool IsReleased = this.DetainedInfo.ReleaseDetainedLicense(CreatedBy, Application.ApplicationID);

            if (!IsReleased)
                return null;

            return DetainLicense; 
        }

        public bool  DeactivateCurrentLicense()
        {
            return clsLicenseData.DeActivateLicense(LicenseID);
        }

        public bool IsLicenseExpired()
        {
            return (this.ExpirationDate < DateTime.Now); 
        }
        public static DataTable GetLocalLicenseView(int PersonID)
        {
            return clsLicenseData.GetLocalLicensesViewByPersonID(PersonID);
        }
    }
}
