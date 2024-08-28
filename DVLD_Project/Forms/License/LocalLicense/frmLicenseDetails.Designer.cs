namespace DVLD_Project.Forms.License
{
    partial class frmLicenseDetails
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
            button1 = new Button();
            label21 = new Label();
            ctrlLicenseInformation1 = new Controls.ctrlLicenseInformation();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.license1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(373, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 117);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button1.Location = new Point(845, 506);
            button1.Name = "button1";
            button1.Size = new Size(103, 39);
            button1.TabIndex = 43;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.Firebrick;
            label21.Location = new Point(352, 157);
            label21.Name = "label21";
            label21.Size = new Size(278, 38);
            label21.TabIndex = 44;
            label21.Text = "Driving License Info";
            // 
            // ctrlLicenseInformation1
            // 
            ctrlLicenseInformation1.Location = new Point(12, 188);
            ctrlLicenseInformation1.Name = "ctrlLicenseInformation1";
            ctrlLicenseInformation1.Size = new Size(948, 322);
            ctrlLicenseInformation1.TabIndex = 45;
            // 
            // frmLicenseDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 557);
            Controls.Add(ctrlLicenseInformation1);
            Controls.Add(label21);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "frmLicenseDetails";
            Text = "frmLicenseDetails";
            Load += frmLicenseDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button button1;
        private Label label21;
        private Controls.ctrlLicenseInformation ctrlLicenseInformation1;
    }
}