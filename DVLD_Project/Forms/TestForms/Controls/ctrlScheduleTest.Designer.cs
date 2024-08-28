namespace DVLD_Project.Forms.TestForms.Controls
{
    partial class ctrlScheduleTest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbMessage = new Label();
            gbRetakeTest = new GroupBox();
            lbRetakeTestID = new Label();
            lbTotalFees = new Label();
            label24 = new Label();
            label26 = new Label();
            lbRetakeApplicationFees = new Label();
            label30 = new Label();
            label31 = new Label();
            btnSave = new Button();
            gbApplicationInfo = new GroupBox();
            label4 = new Label();
            dateTest = new DateTimePicker();
            lbPersonName = new Label();
            lbLocalDrivingAppClass = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            lbNumberOfTries = new Label();
            lbTestFees = new Label();
            lbLocalDrivingAppID = new Label();
            label3 = new Label();
            label2 = new Label();
            label8 = new Label();
            lbHeader = new Label();
            picTest = new PictureBox();
            gbRetakeTest.SuspendLayout();
            gbApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTest).BeginInit();
            SuspendLayout();
            // 
            // lbMessage
            // 
            lbMessage.AutoSize = true;
            lbMessage.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMessage.ForeColor = Color.Firebrick;
            lbMessage.Location = new Point(17, 168);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(598, 31);
            lbMessage.TabIndex = 35;
            lbMessage.Text = "Person is already sat for this test, appoitment is locked";
            // 
            // gbRetakeTest
            // 
            gbRetakeTest.Controls.Add(lbRetakeTestID);
            gbRetakeTest.Controls.Add(lbTotalFees);
            gbRetakeTest.Controls.Add(label24);
            gbRetakeTest.Controls.Add(label26);
            gbRetakeTest.Controls.Add(lbRetakeApplicationFees);
            gbRetakeTest.Controls.Add(label30);
            gbRetakeTest.Controls.Add(label31);
            gbRetakeTest.Enabled = false;
            gbRetakeTest.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbRetakeTest.Location = new Point(21, 482);
            gbRetakeTest.Name = "gbRetakeTest";
            gbRetakeTest.Size = new Size(585, 128);
            gbRetakeTest.TabIndex = 34;
            gbRetakeTest.TabStop = false;
            gbRetakeTest.Text = "Retake Test Info";
            // 
            // lbRetakeTestID
            // 
            lbRetakeTestID.AutoSize = true;
            lbRetakeTestID.Location = new Point(162, 83);
            lbRetakeTestID.Name = "lbRetakeTestID";
            lbRetakeTestID.Size = new Size(24, 23);
            lbRetakeTestID.TabIndex = 11;
            lbRetakeTestID.Text = "??";
            // 
            // lbTotalFees
            // 
            lbTotalFees.AutoSize = true;
            lbTotalFees.Location = new Point(359, 39);
            lbTotalFees.Name = "lbTotalFees";
            lbTotalFees.Size = new Size(24, 23);
            lbTotalFees.TabIndex = 10;
            lbTotalFees.Text = "??";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(21, 83);
            label24.Name = "label24";
            label24.Size = new Size(129, 23);
            label24.TabIndex = 7;
            label24.Text = "R.Test.App.ID :";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(102, 83);
            label26.Name = "label26";
            label26.Size = new Size(24, 23);
            label26.TabIndex = 5;
            label26.Text = "??";
            // 
            // lbRetakeApplicationFees
            // 
            lbRetakeApplicationFees.AutoSize = true;
            lbRetakeApplicationFees.Location = new Point(153, 39);
            lbRetakeApplicationFees.Name = "lbRetakeApplicationFees";
            lbRetakeApplicationFees.Size = new Size(24, 23);
            lbRetakeApplicationFees.TabIndex = 3;
            lbRetakeApplicationFees.Text = "??";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(261, 39);
            label30.Name = "label30";
            label30.Size = new Size(83, 23);
            label30.TabIndex = 1;
            label30.Text = "TotalFees";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(20, 39);
            label31.Name = "label31";
            label31.Size = new Size(109, 23);
            label31.TabIndex = 0;
            label31.Text = "R App Fees :";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlLight;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSave.Location = new Point(503, 626);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 39);
            btnSave.TabIndex = 33;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // gbApplicationInfo
            // 
            gbApplicationInfo.Controls.Add(label4);
            gbApplicationInfo.Controls.Add(dateTest);
            gbApplicationInfo.Controls.Add(lbPersonName);
            gbApplicationInfo.Controls.Add(lbLocalDrivingAppClass);
            gbApplicationInfo.Controls.Add(label10);
            gbApplicationInfo.Controls.Add(label9);
            gbApplicationInfo.Controls.Add(label7);
            gbApplicationInfo.Controls.Add(lbNumberOfTries);
            gbApplicationInfo.Controls.Add(lbTestFees);
            gbApplicationInfo.Controls.Add(lbLocalDrivingAppID);
            gbApplicationInfo.Controls.Add(label3);
            gbApplicationInfo.Controls.Add(label2);
            gbApplicationInfo.Controls.Add(label8);
            gbApplicationInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbApplicationInfo.Location = new Point(21, 215);
            gbApplicationInfo.Name = "gbApplicationInfo";
            gbApplicationInfo.Size = new Size(585, 252);
            gbApplicationInfo.TabIndex = 32;
            gbApplicationInfo.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(90, -35);
            label4.Name = "label4";
            label4.Size = new Size(228, 41);
            label4.TabIndex = 28;
            label4.Text = "Scheduled Test";
            // 
            // dateTest
            // 
            dateTest.CustomFormat = "yyyy/MM/d";
            dateTest.Format = DateTimePickerFormat.Short;
            dateTest.Location = new Point(170, 165);
            dateTest.Name = "dateTest";
            dateTest.Size = new Size(158, 30);
            dateTest.TabIndex = 14;
            // 
            // lbPersonName
            // 
            lbPersonName.AutoSize = true;
            lbPersonName.Location = new Point(170, 105);
            lbPersonName.Name = "lbPersonName";
            lbPersonName.Size = new Size(24, 23);
            lbPersonName.TabIndex = 12;
            lbPersonName.Text = "??";
            // 
            // lbLocalDrivingAppClass
            // 
            lbLocalDrivingAppClass.AutoSize = true;
            lbLocalDrivingAppClass.Location = new Point(170, 72);
            lbLocalDrivingAppClass.Name = "lbLocalDrivingAppClass";
            lbLocalDrivingAppClass.Size = new Size(24, 23);
            lbLocalDrivingAppClass.TabIndex = 10;
            lbLocalDrivingAppClass.Text = "??";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 204);
            label10.Name = "label10";
            label10.Size = new Size(54, 23);
            label10.TabIndex = 8;
            label10.Text = "Fees :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 105);
            label9.Name = "label9";
            label9.Size = new Size(57, 23);
            label9.TabIndex = 7;
            label9.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 138);
            label7.Name = "label7";
            label7.Size = new Size(45, 23);
            label7.TabIndex = 6;
            label7.Text = "Trial";
            // 
            // lbNumberOfTries
            // 
            lbNumberOfTries.AutoSize = true;
            lbNumberOfTries.Location = new Point(170, 138);
            lbNumberOfTries.Name = "lbNumberOfTries";
            lbNumberOfTries.Size = new Size(24, 23);
            lbNumberOfTries.TabIndex = 5;
            lbNumberOfTries.Text = "??";
            // 
            // lbTestFees
            // 
            lbTestFees.AutoSize = true;
            lbTestFees.Location = new Point(169, 204);
            lbTestFees.Name = "lbTestFees";
            lbTestFees.Size = new Size(24, 23);
            lbTestFees.TabIndex = 4;
            lbTestFees.Text = "??";
            // 
            // lbLocalDrivingAppID
            // 
            lbLocalDrivingAppID.AutoSize = true;
            lbLocalDrivingAppID.Location = new Point(170, 39);
            lbLocalDrivingAppID.Name = "lbLocalDrivingAppID";
            lbLocalDrivingAppID.Size = new Size(24, 23);
            lbLocalDrivingAppID.TabIndex = 3;
            lbLocalDrivingAppID.Text = "??";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 171);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 2;
            label3.Text = "Date : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 72);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 1;
            label2.Text = "D Class :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 39);
            label8.Name = "label8";
            label8.Size = new Size(108, 23);
            label8.TabIndex = 0;
            label8.Text = "D.L App ID :";
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.Firebrick;
            lbHeader.Location = new Point(219, 127);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(228, 41);
            lbHeader.TabIndex = 31;
            lbHeader.Text = "Scheduled Test";
            // 
            // picTest
            // 
            picTest.BackgroundImage = Properties.Resources.eye_scan;
            picTest.BackgroundImageLayout = ImageLayout.Zoom;
            picTest.Location = new Point(160, 13);
            picTest.Name = "picTest";
            picTest.Size = new Size(332, 111);
            picTest.TabIndex = 30;
            picTest.TabStop = false;
            // 
            // ctrlScheduleTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbMessage);
            Controls.Add(gbRetakeTest);
            Controls.Add(btnSave);
            Controls.Add(gbApplicationInfo);
            Controls.Add(lbHeader);
            Controls.Add(picTest);
            Name = "ctrlScheduleTest";
            Size = new Size(630, 680);
            Load += ctrlScheduleTest_Load;
            gbRetakeTest.ResumeLayout(false);
            gbRetakeTest.PerformLayout();
            gbApplicationInfo.ResumeLayout(false);
            gbApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMessage;
        private GroupBox gbRetakeTest;
        private Label lbRetakeTestID;
        private Label lbTotalFees;
        private Label label24;
        private Label label26;
        private Label lbRetakeApplicationFees;
        private Label label30;
        private Label label31;
        private Button btnSave;
        private GroupBox gbApplicationInfo;
        private Label label4;
        private DateTimePicker dateTest;
        private Label lbPersonName;
        private Label lbLocalDrivingAppClass;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label lbNumberOfTries;
        private Label lbTestFees;
        private Label lbLocalDrivingAppID;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label lbHeader;
        private PictureBox picTest;
    }
}
