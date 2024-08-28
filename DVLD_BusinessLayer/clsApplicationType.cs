using DVLD_DataLayer;
using System.Data;


namespace DVLD_BusinessLayer
{
    public class clsApplicationType
    {

        public int ApplicationTypeID { set; get; }

        public string ApplicationTitle { set; get; }

        public decimal ApplicationFees { set; get; }


        public clsApplicationType(int applicationID, string applicationTitle, decimal applicationFees)
        {
            ApplicationTypeID = applicationID;
            ApplicationTitle = applicationTitle;
            ApplicationFees = applicationFees;
        }


        public static DataTable GetApplicationTypes()
        {
            return clsApplicationType.GetApplicationTypes();
        }


        public static clsApplicationType? Find(clsApplication.enApplicationType ApplicationTypeID)
        {
            string ApplicationTitle = "";
            decimal applicationFees = 0;
            if (clsApplicationTypeData.GetApplicationTypeByID((int)ApplicationTypeID,ref ApplicationTitle, ref applicationFees))
            {
                return new clsApplicationType((int)ApplicationTypeID, ApplicationTitle, applicationFees);
            }

            return null;
        }


        private bool UpdateApplicaitonTypeByID()
        {
            return clsApplicationTypeData.UpdateApplicationType(ApplicationTypeID, ApplicationTitle, ApplicationFees);
        }


        public bool Save()
        {
            return UpdateApplicaitonTypeByID();
        }

    }
}
