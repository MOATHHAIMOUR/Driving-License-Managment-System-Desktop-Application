using DVLD_DataLayer;
namespace DVLD_BusinessLayer
{
    public class clsDetainLicense
    {

        private enum enMode { AddNew , Update}

        private enMode Mode = enMode.AddNew;

        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo;
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? ReleasedByUserID { get; set; }
        public clsUser? ReleasedUserInfo;
        public int? ReleaseApplicationID { get; set; }
      
        public clsDetainLicense()
        {
            LicenseID = 0;
            DetainDate = DateTime.Now;
            FineFees = 0;
            CreatedByUserID = 0;
            IsReleased = false;
            ReleaseDate = null;
            ReleasedByUserID = null;
            ReleaseApplicationID = null;
            Mode = enMode.AddNew;
        }

        public clsDetainLicense(int detainID, int licenseID, DateTime detainDate, decimal fineFees, int createdByUserID, bool isReleased, DateTime? releaseDate, int? releasedByUserID, int? releaseApplicationID)
        {
            DetainID = detainID;
            LicenseID = licenseID;
            DetainDate = detainDate;
            FineFees = fineFees;
            CreatedByUserID = createdByUserID;
            CreatedByUserInfo = clsUser.FindByUserID(createdByUserID)!;
            IsReleased = isReleased;
            ReleaseDate = releaseDate;
            ReleasedByUserID = releasedByUserID;
            ReleasedUserInfo = clsUser.FindByUserID(releasedByUserID!.Value);
            ReleaseApplicationID = releaseApplicationID;
            Mode = enMode.Update;
        }


        public static bool IsLicenseDetain(int LicenseID)
        {
            return clsDetainLicenseData.IsLicenseDetained(LicenseID);
        }


        private bool _AddNewDetainLicense()
        {
            DetainID = clsDetainLicenseData.AddNewDetainedLicense(LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);

            return DetainID > 0;
        }

        private bool _UpdateDetainLicense()
        {
            return clsDetainLicenseData.UpdateDetainedLicenses(IsReleased, ReleaseDate!.Value, ReleasedByUserID!.Value, ReleaseApplicationID!.Value);   
        }

        public bool ReleaseDetainedLicense(int ReleasedByUserID, int ReleaseApplicationID)
        {
            return clsDetainLicenseData.ReleaseDetainedLicense(this.DetainID,DateTime.Now,
                   ReleasedByUserID, ReleaseApplicationID);
        }



        public static clsDetainLicense? Find(int LicenseID)
        {
            int detainID = -1;
            DateTime detainDate = DateTime.MinValue;
            decimal fineFees = -1;
            int createdByUserID = -1;
            bool isReleased = false;
            DateTime? releaseDate = null;
            int? releasedByUserID = null;
            int? releaseApplicationID = null;

            if (clsDetainLicenseData.GetDetainedLicenseInfoByID(LicenseID, ref detainID, ref detainDate, ref fineFees, ref createdByUserID, ref isReleased, ref releaseDate, ref releasedByUserID, ref releaseApplicationID))
            {
                return new clsDetainLicense
                {
                    DetainID = detainID,
                    LicenseID = LicenseID,
                    DetainDate = detainDate,
                    FineFees = fineFees,
                    CreatedByUserID = createdByUserID,
                    IsReleased = isReleased,
                    ReleaseDate = releaseDate,
                    ReleasedByUserID = releasedByUserID,
                    ReleaseApplicationID = releaseApplicationID
                };
            }

            return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewDetainLicense()){
                        Mode = enMode.Update; 
                        return true;    
                    }
                    return false; 
                case enMode.Update:
                    return _UpdateDetainLicense(); 

            }

            return false; 
        }

    }
}
