namespace DVLD_Project.Forms.TestForms.Controls
{
    partial class frmTakeTest
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
            btnSave = new Button();
            rdFail = new RadioButton();
            rdPass = new RadioButton();
            label16 = new Label();
            txtNotes = new TextBox();
            label5 = new Label();
            button1 = new Button();
            ctrlScheduledTest1 = new ctrlScheduledTest();
            lbEditMessage = new Label();
            SuspendLayout();
            // 
            // btnTakeTest
            // 
            btnSave.BackColor = SystemColors.ControlLight;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSave.Location = new Point(399, 615);
            btnSave.Name = "btnTakeTest";
            btnSave.Size = new Size(103, 39);
            btnSave.TabIndex = 36;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnTakeTest_Click;
            // 
            // rdFail
            // 
            rdFail.AutoSize = true;
            rdFail.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            rdFail.Location = new Point(190, 468);
            rdFail.Name = "rdFail";
            rdFail.Size = new Size(61, 29);
            rdFail.TabIndex = 33;
            rdFail.TabStop = true;
            rdFail.Text = "Fail";
            rdFail.UseVisualStyleBackColor = true;
            // 
            // rdPass
            // 
            rdPass.AutoSize = true;
            rdPass.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            rdPass.Location = new Point(112, 468);
            rdPass.Name = "rdPass";
            rdPass.Size = new Size(70, 29);
            rdPass.TabIndex = 32;
            rdPass.TabStop = true;
            rdPass.Text = "Pass";
            rdPass.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label16.Location = new Point(26, 468);
            label16.Name = "label16";
            label16.Size = new Size(80, 25);
            label16.TabIndex = 31;
            label16.Text = "Result : ";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(26, 530);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(476, 69);
            txtNotes.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(26, 502);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 32;
            label5.Text = "Notes : ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button1.Location = new Point(284, 615);
            button1.Name = "button1";
            button1.Size = new Size(103, 39);
            button1.TabIndex = 40;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ctrlScheduledTest1
            // 
            ctrlScheduledTest1.Location = new Point(12, 12);
            ctrlScheduledTest1.Name = "ctrlScheduledTest1";
            ctrlScheduledTest1.Size = new Size(497, 450);
            ctrlScheduledTest1.TabIndex = 41;
            // 
            // lbEditMessage
            // 
            lbEditMessage.AutoSize = true;
            lbEditMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEditMessage.ForeColor = Color.Firebrick;
            lbEditMessage.Location = new Point(257, 469);
            lbEditMessage.Name = "lbEditMessage";
            lbEditMessage.Size = new Size(166, 28);
            lbEditMessage.TabIndex = 42;
            lbEditMessage.Text = "can't Edit Result";
            // 
            // frmTakeTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 668);
            Controls.Add(lbEditMessage);
            Controls.Add(ctrlScheduledTest1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(txtNotes);
            Controls.Add(btnSave);
            Controls.Add(rdFail);
            Controls.Add(rdPass);
            Controls.Add(label16);
            Name = "frmTakeTest";
            Text = "frmTakeTest";
            Load += frmTakeTest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Label label18;
        private Label label21;
        private Label label24;
        private Label label26;
        private Label label28;
        private Label label30;
        private Label label31;
        private Button btnSave;
        private RadioButton rdFail;
        private RadioButton rdPass;
        private Label label16;
        private Label lbPersonName;
        private Label label1;
        private Label label4;
        private TextBox txtNotes;
        private Label label5;
        private Button button1;
        private ctrlScheduledTest ctrlScheduledTest1;
        private Label lbEditMessage;
    }
}