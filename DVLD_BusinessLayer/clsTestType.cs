using DVLD_DataLayer;
using System.Data;


namespace DVLD_BusinessLayer
{
    public class clsTestType
    {
        public enum enTestType
        {
            VisionTest = 1,
            WrittenTest = 2,
            StreetTest = 3,
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Fees { get; set; }

        public clsTestType(int iD, string title, string description, decimal fees)
        {
            ID = iD;
            Title = title;
            Description = description;
            Fees = fees;
        }


        public static DataTable GetTeatsTypes()
        {
            return clsTestTypeData.GetTestTypes();
        }


        public static clsTestType? Find(enTestType ID)
        {
            string title = "", description = "";
            decimal fees = 0;
            if (clsTestTypeData.GetTestTypeByInfoID((int)ID, ref title, ref description, ref fees))
            {
                return new clsTestType((int)ID, title, description, fees);
            }
            return null;
        }

        public bool _updateTestType()
        {
            return clsTestTypeData.UpdateTestTypeID(ID, Title, Description, Fees);
        }


        public bool Save()
        {
            return _updateTestType();
        }
    }
}
