using DVLD_DataLayer;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsInternationalLicense :  clsApplication
    {
        public int InternationalLicenseID { set; get; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        //composition
        public clsDriver DriverInfo;
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }



        private bool AddNewInternationalLicense()
        {
            int ApplicationID = 1, DriverID = 1, IssuedUsingLocalLicenseID = -1, CreatedByUserID = 1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            IsActive = false;

            //this.InternationalLicenseID = clsInternationalApplicationDataLayer.InsertInternationalLicenses(ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);

            return 1 > 0;
        }

        public clsInternationalLicense()
        {
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            IsActive = false;
            CreatedByUserID = -1;
        }

        public clsInternationalLicense(int ApplicationID, int ApplicantPersonID,
          DateTime ApplicationDate,
           enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
           decimal PaidFees, int CreatedByUserID,
           int InternationalLicenseID, int DriverID, int IssuedUsingLocalLicenseID,
          DateTime IssueDate, DateTime ExpirationDate, bool IsActive)

        {
            //this is for the base clase
            base.ApplicationID = ApplicationID;
            base.ApplicantPersonID = ApplicantPersonID;
            base.ApplicationDate = ApplicationDate;
            base.ApplicationTypeID = (int)clsApplication.enApplicationType.NewInternationalLicense;
            base.ApplicationStatus = ApplicationStatus;
            base.LastStatusDate = LastStatusDate;
            base.PaidFees = PaidFees;
            base.CreatedByUserID = CreatedByUserID;

            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;

            this.DriverInfo = clsDriver.FindDriver(this.DriverID)!;
        }



        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        { 
            return clsInternationalLicenseData.GetActiveInternationalLicenseID(DriverID);
        }

        public static DataTable GetInternationalLiceses()
        {
            return clsInternationalLicenseData.GetInternationalLicenses();
        }


        public bool Save()
        {
            return AddNewInternationalLicense();
        }
    }
}
