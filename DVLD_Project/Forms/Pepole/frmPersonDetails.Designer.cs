namespace DVLD_Project.Forms.PepoleForms
{
    partial class frmPersonDetails
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
            lbHeader = new Label();
            ctrlPersonDetail1 = new Controls.ctrlPersonCard();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.Brown;
            lbHeader.Location = new Point(386, 20);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(360, 50);
            lbHeader.TabIndex = 1;
            lbHeader.Text = "Person Information";
            // 
            // ctrlPersonDetail1
            // 
            ctrlPersonDetail1.Location = new Point(12, 84);
            ctrlPersonDetail1.Name = "ctrlPersonDetail1";
            ctrlPersonDetail1.Size = new Size(1089, 238);
            ctrlPersonDetail1.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(979, 317);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 45);
            btnClose.TabIndex = 30;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmPersonDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 374);
            Controls.Add(btnClose);
            Controls.Add(ctrlPersonDetail1);
            Controls.Add(lbHeader);
            Name = "frmPersonDetails";
            Text = "frmPersonDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHeader;
        private Controls.ctrlPersonCard ctrlPersonDetail1;
        private Button btnClose;
    }
}