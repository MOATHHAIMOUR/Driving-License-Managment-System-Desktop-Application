using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class clsTest
    {

        public enum en_mode { AddNew, Update }

        public en_mode mode { set; get; }

        public int TestID { set; get; }
        public int TestAppointmentID { get; set; }
        // Composition
        public clsTestAppointment TestAppointmentInfo; 

        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }


        public clsTest(int TestID,int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            this.TestID = TestID;   
            TestAppointmentID = testAppointmentID;
            TestResult = testResult;
            Notes = notes;
            CreatedByUserID = createdByUserID;
            mode = en_mode.Update;
        }
        public clsTest()
        {
            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = "";
            CreatedByUserID = 1;
            mode = en_mode.AddNew;
        }

        private bool _addNewTestResutl()
        {
            TestID = clsTestData.AddNewTest(TestAppointmentID, TestResult, Notes, CreatedByUserID);
            return TestID > 0;
        }

        public static clsTest? Find(int TestID)
        {
            int TestAppointmentID = -1, CreatedByUserID=-1;
            bool TestResult = false;
            string Notes = "";

            bool isFound = clsTestData.GetTestByTestID(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID);

            if (isFound)
            {
                return new clsTest(TestID,TestAppointmentID, TestResult,Notes, CreatedByUserID);
            }

            return null; 
        }


        public bool Save()
        {
            switch (mode)
            {
                case en_mode.AddNew:
                    return _addNewTestResutl();
                case en_mode.Update:
                    return false;
            }
            return false;
        }

    }
}
