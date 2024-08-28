namespace DVLD_Project.Forms.ApplicationsForms
{
    partial class frmEditApplicationType
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbID = new Label();
            txtTitle = new TextBox();
            txtFees = new TextBox();
            btnClose = new Button();
            btnSaveApplicationType = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(65, 24);
            label1.Name = "label1";
            label1.Size = new Size(341, 38);
            label1.TabIndex = 3;
            label1.Text = "Update Application Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(33, 102);
            label2.Name = "label2";
            label2.Size = new Size(50, 28);
            label2.TabIndex = 4;
            label2.Text = "ID : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(33, 165);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 5;
            label3.Text = "Title : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(33, 230);
            label4.Name = "label4";
            label4.Size = new Size(70, 28);
            label4.TabIndex = 6;
            label4.Text = "Fees : ";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbID.Location = new Point(89, 102);
            lbID.Name = "lbID";
            lbID.Size = new Size(50, 28);
            lbID.TabIndex = 7;
            lbID.Text = "ID : ";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(111, 169);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(246, 27);
            txtTitle.TabIndex = 8;
            // 
            // txtFees
            // 
            txtFees.Location = new Point(111, 231);
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(246, 27);
            txtFees.TabIndex = 9;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ControlLight;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnClose.Location = new Point(249, 289);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(103, 39);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSaveApplicationType
            // 
            btnSaveApplicationType.BackColor = SystemColors.ControlLight;
            btnSaveApplicationType.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSaveApplicationType.Location = new Point(358, 289);
            btnSaveApplicationType.Name = "btnSaveApplicationType";
            btnSaveApplicationType.Size = new Size(103, 39);
            btnSaveApplicationType.TabIndex = 10;
            btnSaveApplicationType.Text = "Save";
            btnSaveApplicationType.UseVisualStyleBackColor = false;
            btnSaveApplicationType.Click += btnSaveApplicationType_Click;
            // 
            // frmEditApplicationType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 340);
            Controls.Add(btnClose);
            Controls.Add(btnSaveApplicationType);
            Controls.Add(txtFees);
            Controls.Add(txtTitle);
            Controls.Add(lbID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEditApplicationType";
            Text = "frmEditApplicationType";
            Load += frmEditApplicationType_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbID;
        private TextBox txtTitle;
        private TextBox txtFees;
        private Button btnClose;
        private Button btnSaveApplicationType;
    }
}