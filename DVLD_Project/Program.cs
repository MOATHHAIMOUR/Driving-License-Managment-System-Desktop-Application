using DVLD.Forms.PepoleForms;
using DVLD_Project.Forms.ApplicationsForms;
using DVLD_Project.Forms.ApplicationsForms.RenewLocalDrivingLicense;
using DVLD_Project.Forms.License.InternationalLicense;

namespace DVLD_Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmPeopleMangment());
        }
    }
}