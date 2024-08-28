namespace DVLD_Project.Forms.ApplicationsForms
{
    partial class frmAddUpdateLocalDrivingLicesnseApplication
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
            tbApplication = new TabControl();
            tabPage1 = new TabPage();
            btnNext = new Button();
            button3 = new Button();
            ctrlPersonDetailsWithFilter1 = new PepoleForms.Controls.ctrlPersonDetailsWithFilter();
            tabPage2 = new TabPage();
            cbLicenseClases = new ComboBox();
            lbApplicationDate = new Label();
            lbApplicationFees = new Label();
            lbCreatedBy = new Label();
            label5 = new Label();
            lbLocalDrivingApplicationApplicationID = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbHeader = new Label();
            btnClose = new Button();
            btnSave = new Button();
            tbApplication.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tbApplication
            // 
            tbApplication.Controls.Add(tabPage1);
            tbApplication.Controls.Add(tabPage2);
            tbApplication.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbApplication.Location = new Point(17, 104);
            tbApplication.Name = "tbApplication";
            tbApplication.SelectedIndex = 0;
            tbApplication.Size = new Size(981, 476);
            tbApplication.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(btnNext);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(ctrlPersonDetailsWithFilter1);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(973, 435);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Perosn Info";
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.ControlLight;
            btnNext.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(834, 374);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(104, 47);
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
            // ctrlPersonDetailsWithFilter1
            // 
            ctrlPersonDetailsWithFilter1.FilterEnabeld = true;
            ctrlPersonDetailsWithFilter1.Location = new Point(3, 15);
            ctrlPersonDetailsWithFilter1.Name = "ctrlPersonDetailsWithFilter1";
            ctrlPersonDetailsWithFilter1.ShowAddPerson = true;
            ctrlPersonDetailsWithFilter1.Size = new Size(962, 353);
            ctrlPersonDetailsWithFilter1.TabIndex = 9;
            ctrlPersonDetailsWithFilter1.OnPersonSelected += ctrlPersonDetailsWithFilter1_OnPersonSelected;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(cbLicenseClases);
            tabPage2.Controls.Add(lbApplicationDate);
            tabPage2.Controls.Add(lbApplicationFees);
            tabPage2.Controls.Add(lbCreatedBy);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(lbLocalDrivingApplicationApplicationID);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(973, 435);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Application Info";
            // 
            // cbLicenseClases
            // 
            cbLicenseClases.FormattingEnabled = true;
            cbLicenseClases.Location = new Point(304, 220);
            cbLicenseClases.Name = "cbLicenseClases";
            cbLicenseClases.Size = new Size(374, 36);
            cbLicenseClases.TabIndex = 13;
            cbLicenseClases.SelectedIndexChanged += comboLicenseClases_SelectedIndexChanged;
            // 
            // lbApplicationDate
            // 
            lbApplicationDate.AutoSize = true;
            lbApplicationDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lbApplicationDate.Location = new Point(304, 100);
            lbApplicationDate.Name = "lbApplicationDate";
            lbApplicationDate.Size = new Size(28, 25);
            lbApplicationDate.TabIndex = 12;
            lbApplicationDate.Text = "??";
            // 
            // lbApplicationFees
            // 
            lbApplicationFees.AutoSize = true;
            lbApplicationFees.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lbApplicationFees.Location = new Point(304, 160);
            lbApplicationFees.Name = "lbApplicationFees";
            lbApplicationFees.Size = new Size(28, 25);
            lbApplicationFees.TabIndex = 11;
            lbApplicationFees.Text = "??";
            // 
            // lbCreatedBy
            // 
            lbCreatedBy.AutoSize = true;
            lbCreatedBy.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lbCreatedBy.Location = new Point(304, 283);
            lbCreatedBy.Name = "lbCreatedBy";
            lbCreatedBy.Size = new Size(28, 25);
            lbCreatedBy.TabIndex = 10;
            lbCreatedBy.Text = "??";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(27, 160);
            label5.Name = "label5";
            label5.Size = new Size(141, 28);
            label5.TabIndex = 9;
            label5.Text = "license Class :";
            // 
            // lbLocalDrivingApplicationApplicationID
            // 
            lbLocalDrivingApplicationApplicationID.AutoSize = true;
            lbLocalDrivingApplicationApplicationID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lbLocalDrivingApplicationApplicationID.Location = new Point(304, 43);
            lbLocalDrivingApplicationApplicationID.Name = "lbLocalDrivingApplicationApplicationID";
            lbLocalDrivingApplicationApplicationID.Size = new Size(28, 25);
            lbLocalDrivingApplicationApplicationID.TabIndex = 4;
            lbLocalDrivingApplicationApplicationID.Text = "??";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(27, 40);
            label4.Name = "label4";
            label4.Size = new Size(194, 28);
            label4.TabIndex = 3;
            label4.Text = "D.L Application ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(27, 280);
            label3.Name = "label3";
            label3.Size = new Size(126, 28);
            label3.TabIndex = 2;
            label3.Text = "Created By :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(27, 220);
            label2.Name = "label2";
            label2.Size = new Size(185, 28);
            label2.TabIndex = 1;
            label2.Text = "Application Fees : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(27, 100);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 0;
            label1.Text = "Application Date";
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.Brown;
            lbHeader.Location = new Point(212, 26);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(629, 46);
            lbHeader.TabIndex = 5;
            lbHeader.Text = "New Local Driving License Application";
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ControlLight;
            btnClose.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold);
            btnClose.Location = new Point(775, 586);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(110, 49);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlLight;
            btnSave.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold);
            btnSave.Location = new Point(891, 586);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 49);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmAddUpdateLocalDrivingApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 647);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(lbHeader);
            Controls.Add(tbApplication);
            Name = "frmAddUpdateLocalDrivingApplication";
            Text = "frmNewLocalDrivingApplication";
            Load += frmNewLocalDrivingApplication_Load;
            tbApplication.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tbApplication;
        private TabPage tabPage1;
        private PepoleForms.Controls.ctrlPersonDetailsWithFilter ctrlPersonDetailsWithFilter1;
        private Button btnNext;
        private Button button3;
        private TabPage tabPage2;
        private Label lbLocalDrivingApplicationApplicationID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbHeader;
        private Label label9;
        private Label lbApplicationDate;
        private Label lbApplicationFees;
        private Label lbCreatedBy;
        private Label label5;
        private Button btnClose;
        private Button btnSave;
        private ComboBox cbLicenseClases;
    }
}