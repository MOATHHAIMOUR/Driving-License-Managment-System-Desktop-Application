namespace DVLD_Project.Forms.License
{
    partial class frmShowLicensesHistory
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
            label1 = new Label();
            ctrlPersonDetailsWithFilter1 = new PepoleForms.Controls.ctrlPersonDetailsWithFilter();
            pictureBox1 = new PictureBox();
            ctrlDriverLicenses1 = new Controls.ctrlDriverLicenses();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(291, 109);
            label1.Name = "label1";
            label1.Size = new Size(380, 46);
            label1.TabIndex = 1;
            label1.Text = "Person License History";
            // 
            // ctrlPersonDetailsWithFilter1
            // 
            ctrlPersonDetailsWithFilter1.FilterEnabeld = true;
            ctrlPersonDetailsWithFilter1.Location = new Point(1, 155);
            ctrlPersonDetailsWithFilter1.Name = "ctrlPersonDetailsWithFilter1";
            ctrlPersonDetailsWithFilter1.ShowAddPerson = true;
            ctrlPersonDetailsWithFilter1.Size = new Size(954, 366);
            ctrlPersonDetailsWithFilter1.TabIndex = 2;
            ctrlPersonDetailsWithFilter1.OnPersonSelected += ctrlPersonDetailsWithFilter1_OnPersonSelected;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.history;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(363, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 94);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // ctrlDriverLicenses1
            // 
            ctrlDriverLicenses1.BackColor = SystemColors.Control;
            ctrlDriverLicenses1.Location = new Point(25, 512);
            ctrlDriverLicenses1.Name = "ctrlDriverLicenses1";
            ctrlDriverLicenses1.Size = new Size(930, 230);
            ctrlDriverLicenses1.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ControlLight;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnClose.Location = new Point(830, 748);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(115, 39);
            btnClose.TabIndex = 45;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmShowLicensesHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 797);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(ctrlDriverLicenses1);
            Controls.Add(pictureBox1);
            Controls.Add(ctrlPersonDetailsWithFilter1);
            Name = "frmShowLicensesHistory";
            Text = "frmShowLicensesHistory";
            Load += frmShowLicensesHistory_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PepoleForms.Controls.ctrlPersonDetailsWithFilter ctrlPersonDetailsWithFilter1;
        private PictureBox pictureBox1;
        private Controls.ctrlDriverLicenses ctrlDriverLicenses1;
        private Button btnClose;
    }
}