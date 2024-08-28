namespace DVLD_Project.Forms.UsersForms
{
    partial class ctrlUserCard
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
            gbUserDetials = new GroupBox();
            lbIsActive = new Label();
            lbUsername = new Label();
            lbUserID = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ctrlPersonDetail1 = new PepoleForms.Controls.ctrlPersonCard();
            gbUserDetials.SuspendLayout();
            SuspendLayout();
            // 
            // gbUserDetials
            // 
            gbUserDetials.Controls.Add(lbIsActive);
            gbUserDetials.Controls.Add(lbUsername);
            gbUserDetials.Controls.Add(lbUserID);
            gbUserDetials.Controls.Add(label3);
            gbUserDetials.Controls.Add(label2);
            gbUserDetials.Controls.Add(label1);
            gbUserDetials.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbUserDetials.Location = new Point(28, 255);
            gbUserDetials.Name = "gbUserDetials";
            gbUserDetials.Size = new Size(915, 73);
            gbUserDetials.TabIndex = 0;
            gbUserDetials.TabStop = false;
            gbUserDetials.Text = "UserDetails";
            // 
            // lbIsActive
            // 
            lbIsActive.AutoSize = true;
            lbIsActive.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbIsActive.Location = new Point(641, 37);
            lbIsActive.Name = "lbIsActive";
            lbIsActive.Size = new Size(24, 23);
            lbIsActive.TabIndex = 5;
            lbIsActive.Text = "??";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbUsername.Location = new Point(367, 37);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(24, 23);
            lbUsername.TabIndex = 4;
            lbUsername.Text = "??";
            // 
            // lbUserID
            // 
            lbUserID.AutoSize = true;
            lbUserID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbUserID.Location = new Point(110, 37);
            lbUserID.Name = "lbUserID";
            lbUserID.Size = new Size(24, 23);
            lbUserID.TabIndex = 3;
            lbUserID.Text = "??";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(540, 37);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 2;
            label3.Text = "Is Active :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(254, 37);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(20, 37);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 0;
            label1.Text = "User ID :";
            // 
            // ctrlPersonDetail1
            // 
            ctrlPersonDetail1.Location = new Point(13, 15);
            ctrlPersonDetail1.Name = "ctrlPersonDetail1";
            ctrlPersonDetail1.Size = new Size(930, 241);
            ctrlPersonDetail1.TabIndex = 6;
            // 
            // ctrlUserCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ctrlPersonDetail1);
            Controls.Add(gbUserDetials);
            Name = "ctrlUserCard";
            Size = new Size(952, 355);
            gbUserDetials.ResumeLayout(false);
            gbUserDetials.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbUserDetials;
        private Label lbIsActive;
        private Label lbUsername;
        private Label lbUserID;
        private Label label3;
        private Label label2;
        private Label label1;
        private PepoleForms.Controls.ctrlPersonCard ctrlPersonDetail1;
    }
}
