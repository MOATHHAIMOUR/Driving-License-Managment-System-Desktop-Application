namespace DVLD_Project.Forms.UsersForms
{
    partial class frmUserInfo
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
            btnClose = new Button();
            label1 = new Label();
            ctrlUserCard1 = new ctrlUserCard();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ControlLightLight;
            btnClose.Location = new Point(821, 425);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 56);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(392, 21);
            label1.Name = "label1";
            label1.Size = new Size(210, 46);
            label1.TabIndex = 3;
            label1.Text = "User Details";
            // 
            // ctrlUserCard1
            // 
            ctrlUserCard1.Location = new Point(12, 70);
            ctrlUserCard1.Name = "ctrlUserCard1";
            ctrlUserCard1.Size = new Size(944, 349);
            ctrlUserCard1.TabIndex = 4;
            ctrlUserCard1.User = null;
            // 
            // frmUserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 489);
            Controls.Add(ctrlUserCard1);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Name = "frmUserInfo";
            Text = "frmUserDetails";
            Load += frmUserDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ctrlUserCard ctrlUserDetails1;
        private Button btnClose;
        private Label label1;
        private ctrlUserCard ctrlUserCard1;
    }
}