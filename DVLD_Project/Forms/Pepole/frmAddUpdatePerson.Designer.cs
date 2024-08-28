namespace DVLD_Project.Forms.PepoleForms
{
    partial class frmAddUpdatePerson
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            lbID = new Label();
            label15 = new Label();
            txtFirstName = new TextBox();
            txtSecondName = new TextBox();
            txtThirdName = new TextBox();
            txtLastName = new TextBox();
            txtNO = new TextBox();
            rdMale = new RadioButton();
            rdFemale = new RadioButton();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            dtBirth = new DateTimePicker();
            txtPhone = new TextBox();
            comboCountry = new ComboBox();
            picPerson = new PictureBox();
            linkImage = new LinkLabel();
            btnClose = new Button();
            btnSavePerson = new Button();
            linkRemove = new LinkLabel();
            epPerson = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)picPerson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epPerson).BeginInit();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.Brown;
            lbHeader.Location = new Point(429, 18);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(311, 50);
            lbHeader.TabIndex = 0;
            lbHeader.Text = "Add New Person";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(10, 88);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 1;
            label2.Text = "PersonID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(198, 135);
            label3.Name = "label3";
            label3.Size = new Size(53, 28);
            label3.TabIndex = 2;
            label3.Text = "First";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(389, 135);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 3;
            label4.Text = "Second";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(827, 135);
            label5.Name = "label5";
            label5.Size = new Size(50, 28);
            label5.TabIndex = 4;
            label5.Text = "Last";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(611, 135);
            label6.Name = "label6";
            label6.Size = new Size(62, 28);
            label6.TabIndex = 5;
            label6.Text = "Third";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(8, 214);
            label7.Name = "label7";
            label7.Size = new Size(145, 28);
            label7.TabIndex = 6;
            label7.Text = "National No : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(12, 264);
            label8.Name = "label8";
            label8.Size = new Size(97, 28);
            label8.TabIndex = 7;
            label8.Text = "Gender : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(12, 311);
            label9.Name = "label9";
            label9.Size = new Size(75, 28);
            label9.TabIndex = 8;
            label9.Text = "Email :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(12, 359);
            label10.Name = "label10";
            label10.Size = new Size(98, 28);
            label10.TabIndex = 9;
            label10.Text = "Address :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label11.Location = new Point(532, 220);
            label11.Name = "label11";
            label11.Size = new Size(141, 25);
            label11.TabIndex = 10;
            label11.Text = "Date Of Birth : ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label12.Location = new Point(538, 267);
            label12.Name = "label12";
            label12.Size = new Size(81, 25);
            label12.TabIndex = 11;
            label12.Text = "phone : ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label13.Location = new Point(532, 314);
            label13.Name = "label13";
            label13.Size = new Size(96, 25);
            label13.TabIndex = 12;
            label13.Text = "Country : ";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbID.Location = new Point(139, 88);
            lbID.Name = "lbID";
            lbID.Size = new Size(42, 28);
            lbID.TabIndex = 13;
            lbID.Text = "NA";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label15.Location = new Point(10, 166);
            label15.Name = "label15";
            label15.Size = new Size(85, 28);
            label15.TabIndex = 14;
            label15.Text = "Name : ";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(146, 166);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(171, 27);
            txtFirstName.TabIndex = 15;
            txtFirstName.Validating += txtFirstName_Validating;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(352, 166);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(171, 27);
            txtSecondName.TabIndex = 16;
            txtSecondName.Validating += txtSecondName_Validating;
            // 
            // txtThirdName
            // 
            txtThirdName.Location = new Point(569, 166);
            txtThirdName.Name = "txtThirdName";
            txtThirdName.Size = new Size(171, 27);
            txtThirdName.TabIndex = 17;
            txtThirdName.Validating += txtThirdName_Validating;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(775, 166);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(171, 27);
            txtLastName.TabIndex = 18;
            txtLastName.Validating += txtLastName_Validating;
            // 
            // txtNO
            // 
            txtNO.Location = new Point(164, 218);
            txtNO.Name = "txtNO";
            txtNO.Size = new Size(233, 27);
            txtNO.TabIndex = 19;
            txtNO.Validating += txtNO_Validating;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            rdMale.Location = new Point(139, 264);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(70, 27);
            rdMale.TabIndex = 20;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            rdMale.MouseClick += rdGender_MouseClick;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            rdFemale.Location = new Point(227, 264);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(88, 27);
            rdFemale.TabIndex = 21;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            rdFemale.MouseClick += rdGender_MouseClick;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(107, 312);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(257, 27);
            txtEmail.TabIndex = 22;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(107, 363);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(535, 74);
            txtAddress.TabIndex = 23;
            // 
            // dtBirth
            // 
            dtBirth.Location = new Point(679, 220);
            dtBirth.Name = "dtBirth";
            dtBirth.Size = new Size(250, 27);
            dtBirth.TabIndex = 24;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(625, 268);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(279, 27);
            txtPhone.TabIndex = 25;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // comboCountry
            // 
            comboCountry.FormattingEnabled = true;
            comboCountry.Location = new Point(636, 314);
            comboCountry.Name = "comboCountry";
            comboCountry.Size = new Size(241, 28);
            comboCountry.TabIndex = 26;
            // 
            // picPerson
            // 
            picPerson.BackgroundImage = Properties.Resources.female;
            picPerson.BackgroundImageLayout = ImageLayout.Zoom;
            picPerson.Location = new Point(968, 68);
            picPerson.Name = "picPerson";
            picPerson.Size = new Size(154, 194);
            picPerson.TabIndex = 27;
            picPerson.TabStop = false;
            // 
            // linkImage
            // 
            linkImage.AutoSize = true;
            linkImage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkImage.Location = new Point(1003, 268);
            linkImage.Name = "linkImage";
            linkImage.Size = new Size(93, 28);
            linkImage.TabIndex = 28;
            linkImage.TabStop = true;
            linkImage.Text = "setImage";
            linkImage.LinkClicked += linkImage_LinkClicked;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(904, 423);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 45);
            btnClose.TabIndex = 29;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSavePerson
            // 
            btnSavePerson.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSavePerson.Location = new Point(1022, 423);
            btnSavePerson.Name = "btnSavePerson";
            btnSavePerson.Size = new Size(105, 45);
            btnSavePerson.TabIndex = 30;
            btnSavePerson.Text = "Save";
            btnSavePerson.UseVisualStyleBackColor = true;
            btnSavePerson.Click += btnSavePerson_Click;
            // 
            // linkRemove
            // 
            linkRemove.AutoSize = true;
            linkRemove.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkRemove.LinkColor = Color.FromArgb(192, 0, 0);
            linkRemove.Location = new Point(977, 296);
            linkRemove.Name = "linkRemove";
            linkRemove.Size = new Size(135, 28);
            linkRemove.TabIndex = 31;
            linkRemove.TabStop = true;
            linkRemove.Text = "removeImage";
            linkRemove.LinkClicked += linkRemove_LinkClicked;
            // 
            // epPerson
            // 
            epPerson.ContainerControl = this;
            // 
            // frmAddUpdatePerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 480);
            Controls.Add(linkRemove);
            Controls.Add(btnSavePerson);
            Controls.Add(btnClose);
            Controls.Add(linkImage);
            Controls.Add(picPerson);
            Controls.Add(comboCountry);
            Controls.Add(txtPhone);
            Controls.Add(dtBirth);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(rdFemale);
            Controls.Add(rdMale);
            Controls.Add(txtNO);
            Controls.Add(txtLastName);
            Controls.Add(txtThirdName);
            Controls.Add(txtSecondName);
            Controls.Add(txtFirstName);
            Controls.Add(label15);
            Controls.Add(lbID);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbHeader);
            Name = "frmAddUpdatePerson";
            Text = "frmAddNewPerson";
            Load += frmSavePerson_Load;
            ((System.ComponentModel.ISupportInitialize)picPerson).EndInit();
            ((System.ComponentModel.ISupportInitialize)epPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHeader;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label lbID;
        private Label label15;
        private TextBox txtFirstName;
        private TextBox txtSecondName;
        private TextBox txtThirdName;
        private TextBox txtLastName;
        private TextBox txtNO;
        private RadioButton rdMale;
        private RadioButton rdFemale;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private DateTimePicker dtBirth;
        private TextBox txtPhone;
        private ComboBox comboCountry;
        private PictureBox picPerson;
        private LinkLabel linkImage;
        private Button btnClose;
        private Button btnSavePerson;
        private LinkLabel linkRemove;
        private ErrorProvider epPerson;
    }
}