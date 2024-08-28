namespace DVLD_Project.Forms.ApplicationsForms
{
    partial class frmIssueDriverLicenseForFirstTime
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
            ctrlApplicationInfo1 = new Controls.ctrlApplicationInfo();
            txtNotes = new TextBox();
            label1 = new Label();
            button1 = new Button();
            btnIssueTest = new Button();
            SuspendLayout();
            // 
            // ctrlApplicationInfo1
            // 
            ctrlApplicationInfo1.Location = new Point(2, 12);
            ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            ctrlApplicationInfo1.Size = new Size(743, 395);
            ctrlApplicationInfo1.TabIndex = 0;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(24, 441);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(710, 94);
            txtNotes.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 410);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 2;
            label1.Text = "Notes : ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button1.Location = new Point(516, 548);
            button1.Name = "button1";
            button1.Size = new Size(103, 39);
            button1.TabIndex = 42;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnIssueTest
            // 
            btnIssueTest.BackColor = SystemColors.ControlLight;
            btnIssueTest.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnIssueTest.Location = new Point(631, 548);
            btnIssueTest.Name = "btnIssueTest";
            btnIssueTest.Size = new Size(103, 39);
            btnIssueTest.TabIndex = 41;
            btnIssueTest.Text = "Issue";
            btnIssueTest.UseVisualStyleBackColor = false;
            btnIssueTest.Click += btnIssueTest_Click;
            // 
            // frmIssueDriverLicenseForFirstTime
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 604);
            Controls.Add(button1);
            Controls.Add(btnIssueTest);
            Controls.Add(label1);
            Controls.Add(txtNotes);
            Controls.Add(ctrlApplicationInfo1);
            Name = "frmIssueDriverLicenseForFirstTime";
            Text = "frmIssueDriverLicenseForFirstTime";
            Load += frmIssueDriverLicenseForFirstTime_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlApplicationInfo ctrlApplicationInfo1;
        private TextBox txtNotes;
        private Label label1;
        private Button button1;
        private Button btnIssueTest;
    }
}