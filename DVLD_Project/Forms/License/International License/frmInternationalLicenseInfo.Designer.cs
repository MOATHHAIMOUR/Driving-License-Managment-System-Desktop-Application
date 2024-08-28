namespace DVLD_Project.Forms.License.InternationalLicense
{
    partial class frmInternationalLicenseInfo
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ctrInternationalLicenseInfo1 = new Controls.ctrInternationalLicenseInfo();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.license1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(369, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 117);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(245, 158);
            label1.Name = "label1";
            label1.Size = new Size(490, 41);
            label1.TabIndex = 4;
            label1.Text = "Driving International License Info";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.global_network1;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(572, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 46);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // ctrInternationalLicenseInfo1
            // 
            ctrInternationalLicenseInfo1.InternationalLicense = null;
            ctrInternationalLicenseInfo1.Location = new Point(12, 212);
            ctrInternationalLicenseInfo1.Name = "ctrInternationalLicenseInfo1";
            ctrInternationalLicenseInfo1.Person = null;
            ctrInternationalLicenseInfo1.Size = new Size(948, 241);
            ctrInternationalLicenseInfo1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button1.Location = new Point(845, 459);
            button1.Name = "button1";
            button1.Size = new Size(103, 39);
            button1.TabIndex = 44;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmInternationalLicenseInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 505);
            Controls.Add(button1);
            Controls.Add(ctrInternationalLicenseInfo1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmInternationalLicenseInfo";
            Text = "frmInternationalLicenseInfo";
            Load += frmInternationalLicenseInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Controls.ctrInternationalLicenseInfo ctrInternationalLicenseInfo1;
        private Button button1;
    }
}