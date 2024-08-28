namespace DVLD_Project.Forms.TestForms
{
    partial class frmScheduleTest
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
            ctrlScheduleTest1 = new Controls.ctrlScheduleTest();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ControlLight;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnClose.Location = new Point(405, 639);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(103, 34);
            btnClose.TabIndex = 29;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // ctrlScheduleTest1
            // 
            ctrlScheduleTest1.Location = new Point(12, 12);
            ctrlScheduleTest1.Name = "ctrlScheduleTest1";
            ctrlScheduleTest1.Size = new Size(628, 671);
            ctrlScheduleTest1.TabIndex = 30;
            // 
            // frmScheduleTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 695);
            Controls.Add(btnClose);
            Controls.Add(ctrlScheduleTest1);
            Name = "frmScheduleTest";
            Text = "frmScheduleTest";
            Load += frmScheduleTest_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnClose;
        private Controls.ctrlScheduleTest ctrlScheduleTest1;
    }
}