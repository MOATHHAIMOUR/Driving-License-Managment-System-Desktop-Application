using CoreDVLD;
using DVLD;
using DVLD_BusinessLayer;

namespace DVLD_Project.Forms.UsersForms
{
    public partial class frmLogin : Form
    {
      
        public string UserFile => "C:\\Users\\moath\\Desktop\\new-Programes C#\\DVLD\\LoggedUserInfo.txt";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void SaveUserInfoToInFile(clsUser user)
        {
            string foramtedUser = FormatUser(user);
            WriteToFile(UserFile, foramtedUser);
        }

        private void DeleteUserInfoFromFile()
        {
            ClearFileContetn();
        }

        private void ClearFileContetn()
        {
            using (FileStream fs = new FileStream(UserFile, FileMode.Open, FileAccess.Write))
            {
                fs.SetLength(0);
            }
        }


        private void WriteToFile(string FilePath, string text)
        {
            // Create a new file and write to it
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                writer.WriteLine(text);
            }
        }

        private string FormatUser(clsUser user)
        {
            return string.Join("#//#", [user.UserName, user.Password]);
        }


        private string? ReadUserDataFromFile()
        {
            try
            {
                string[] lines = File.ReadAllLines(UserFile);
                return lines[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }

        private void getUserData(ref string username, ref string password)
        {
            string? line = ReadUserDataFromFile();

            string[]? data = line?.Split("#//#");

            username = data[0] ?? "";
            password = data[1] ?? "";
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {


            if (clsUser.IsUserExistByUserName(txtUsername.Text))
            {
                clsUser user = clsUser.FindByUserName(txtUsername.Text);

                if (user.UserName == txtUsername.Text && user.Password == txtPassword.Text)
                {
                    if (!user.IsActive)
                    {
                        MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (chRememberMe.Checked)
                        SaveUserInfoToInFile(user);
                    else
                        DeleteUserInfoFromFile();

                    clsUserSettings.CurrentUser = user;

                    frmDashboard frmDashboard = new frmDashboard();
                    this.Hide(); // Hide the login form
                    frmDashboard.ShowDialog();
                    this.Close(); // Close the login form
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect");
                }
            }
            else
            {
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string username = "", password = "";
            getUserData(ref username, ref password);
            txtUsername.Text = username;
            txtPassword.Text = password; 
        }
    }
}
