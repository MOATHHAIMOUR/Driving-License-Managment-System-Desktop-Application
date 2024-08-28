namespace DVLD_Project.Forms.License.Controls
{
    partial class ctrlDriverLicenseInfoWithFilter
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
            gbFilter = new GroupBox();
            btnOnSearchForLicense = new PictureBox();
            txtLicenseID = new TextBox();
            label12 = new Label();
            ctrlLicenseInformation1 = new ctrlLicenseInformation();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnOnSearchForLicense).BeginInit();
            SuspendLayout();
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btnOnSearchForLicense);
            gbFilter.Controls.Add(txtLicenseID);
            gbFilter.Controls.Add(label12);
            gbFilter.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFilter.Location = new Point(16, 17);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(896, 75);
            gbFilter.TabIndex = 0;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // btnOnSearchForLicense
            // 
            btnOnSearchForLicense.BackgroundImage = Properties.Resources.loupe;
            btnOnSearchForLicense.BackgroundImageLayout = ImageLayout.Zoom;
            btnOnSearchForLicense.Location = new Point(392, 28);
            btnOnSearchForLicense.Name = "btnOnSearchForLicense";
            btnOnSearchForLicense.Size = new Size(54, 38);
            btnOnSearchForLicense.TabIndex = 16;
            btnOnSearchForLicense.TabStop = false;
            btnOnSearchForLicense.Click += btnOnSearchForLicense_Click;
            btnOnSearchForLicense.MouseClick += btnOnSearch_MouseClick;
            // 
            // txtLicenseID
            // 
            txtLicenseID.Location = new Point(175, 32);
            txtLicenseID.Name = "txtLicenseID";
            txtLicenseID.Size = new Size(201, 30);
            txtLicenseID.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(26, 35);
            label12.Name = "label12";
            label12.Size = new Size(133, 25);
            label12.TabIndex = 14;
            label12.Text = "License ID : ";
            // 
            // ctrlLicenseInformation1
            // 
            ctrlLicenseInformation1.Location = new Point(16, 110);
            ctrlLicenseInformation1.Name = "ctrlLicenseInformation1";
            ctrlLicenseInformation1.Size = new Size(949, 307);
            ctrlLicenseInformation1.TabIndex = 1;
            // 
            // ctrlDriverLicenseInfoWithFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ctrlLicenseInformation1);
            Controls.Add(gbFilter);
            Name = "ctrlDriverLicenseInfoWithFilter";
            Size = new Size(1026, 435);
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnOnSearchForLicense).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbFilter;
        private PictureBox btnOnSearchForLicense;
        private TextBox txtLicenseID;
        private Label label12;
        private ctrlLicenseInformation ctrlLicenseInformation1;
    }
}
