namespace DVLD_Project.Forms.UsersForms
{
    partial class frmAddUpdateUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbHeader = new Label();
            tbUser = new TabControl();
            tabPage1 = new TabPage();
            ctrlPersonDetailsWithFilter1 = new PepoleForms.Controls.ctrlPersonDetailsWithFilter();
            btnNext = new Button();
            button3 = new Button();
            tabPage2 = new TabPage();
            chIsActive = new CheckBox();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lbPersonID = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSaveUser = new Button();
            btnClose = new Button();
            epUser = new ErrorProvider(components);
            tbUser.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epUser).BeginInit();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.Brown;
            lbHeader.Location = new Point(401, 15);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(294, 54);
            lbHeader.TabIndex = 2;
            lbHeader.Text = "Add New User";
            // 
            // tbUser
            // 
            tbUser.Controls.Add(tabPage1);
            tbUser.Controls.Add(tabPage2);
            tbUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbUser.Location = new Point(12, 72);
            tbUser.Name = "tbUser";
            tbUser.SelectedIndex = 0;
            tbUser.Size = new Size(972, 465);
            tbUser.TabIndex = 3;
            tbUser.Selecting += tbUser_Selecting;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(ctrlPersonDetailsWithFilter1);
            tabPage1.Controls.Add(btnNext);
            tabPage1.Controls.Add(button3);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(964, 424);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Perosn Info";
            // 
            // ctrlPersonDetailsWithFilter1
            // 
            ctrlPersonDetailsWithFilter1.FilterEnabeld = true;
            ctrlPersonDetailsWithFilter1.Location = new Point(6, 6);
            ctrlPersonDetailsWithFilter1.Name = "ctrlPersonDetailsWithFilter1";
            ctrlPersonDetailsWithFilter1.ShowAddPerson = true;
            ctrlPersonDetailsWithFilter1.Size = new Size(952, 350);
            ctrlPersonDetailsWithFilter1.TabIndex = 9;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.ControlLight;
            btnNext.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(838, 362);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 54);
            btnNext.TabIndex = 8;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1044, 718);
            button3.Name = "button3";
            button3.Size = new Size(180, 68);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(chIsActive);
            tabPage2.Controls.Add(txtConfirmPassword);
            tabPage2.Controls.Add(txtPassword);
            tabPage2.Controls.Add(txtUsername);
            tabPage2.Controls.Add(lbPersonID);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(964, 424);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Login Info";
            // 
            // chIsActive
            // 
            chIsActive.AutoSize = true;
            chIsActive.Location = new Point(340, 446);
            chIsActive.Name = "chIsActive";
            chIsActive.Size = new Size(115, 32);
            chIsActive.TabIndex = 8;
            chIsActive.Text = "Is Active";
            chIsActive.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(340, 223);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(276, 40);
            txtConfirmPassword.TabIndex = 7;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(340, 158);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(276, 40);
            txtPassword.TabIndex = 6;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(340, 100);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(276, 40);
            txtUsername.TabIndex = 5;
            txtUsername.Validating += txtUsername_Validating;
            // 
            // lbPersonID
            // 
            lbPersonID.AutoSize = true;
            lbPersonID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbPersonID.Location = new Point(182, 40);
            lbPersonID.Name = "lbPersonID";
            lbPersonID.Size = new Size(30, 28);
            lbPersonID.TabIndex = 4;
            lbPersonID.Text = "??";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(43, 40);
            label4.Name = "label4";
            label4.Size = new Size(107, 28);
            label4.TabIndex = 3;
            label4.Text = "PersonID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(43, 225);
            label3.Name = "label3";
            label3.Size = new Size(194, 28);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(43, 158);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 1;
            label2.Text = "Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(43, 96);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // btnSaveUser
            // 
            btnSaveUser.BackColor = SystemColors.ControlLight;
            btnSaveUser.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold);
            btnSaveUser.Location = new Point(854, 543);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new Size(124, 51);
            btnSaveUser.TabIndex = 4;
            btnSaveUser.Text = "Save";
            btnSaveUser.UseVisualStyleBackColor = false;
            btnSaveUser.Click += btnSaveUser_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ControlLight;
            btnClose.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold);
            btnClose.Location = new Point(736, 543);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 51);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // epUser
            // 
            epUser.ContainerControl = this;
            // 
            // frmAddUpdateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 608);
            Controls.Add(btnClose);
            Controls.Add(btnSaveUser);
            Controls.Add(tbUser);
            Controls.Add(lbHeader);
            Name = "frmAddUpdateUser";
            Text = "frmAddNewUser";
            Load += frmAddUpdateUserUser_Load;
            tbUser.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHeader;
        private TabControl tbUser;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox chIsActive;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lbPersonID;
        private Button btnSaveUser;
        private Button button3;
        private Button btnClose;
        private Button btnNext;
        private PepoleForms.Controls.ctrlPersonDetailsWithFilter ctrlPersonDetailsWithFilter1;
        private ErrorProvider epUser;
    }
}