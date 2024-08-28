namespace DVLD_Project.Forms.UsersForms
{
    partial class frmChangePassword
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btnClose = new Button();
            btnSaveChangePassword = new Button();
            label3 = new Label();
            txtConfirmPassword = new TextBox();
            label2 = new Label();
            txtNewPassword = new TextBox();
            label1 = new Label();
            txtCurrentPassword = new TextBox();
            ctrlUserCard1 = new ctrlUserCard();
            label4 = new Label();
            ebChangePassword = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ebChangePassword).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(btnSaveChangePassword);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtConfirmPassword);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNewPassword);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCurrentPassword);
            groupBox1.Controls.Add(ctrlUserCard1);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(961, 566);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Info";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gainsboro;
            btnClose.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnClose.ForeColor = SystemColors.ControlText;
            btnClose.Location = new Point(712, 508);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 45);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSaveChangePassword
            // 
            btnSaveChangePassword.BackColor = SystemColors.ControlLight;
            btnSaveChangePassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSaveChangePassword.Location = new Point(828, 508);
            btnSaveChangePassword.Name = "btnSaveChangePassword";
            btnSaveChangePassword.Size = new Size(126, 45);
            btnSaveChangePassword.TabIndex = 9;
            btnSaveChangePassword.Text = "Save";
            btnSaveChangePassword.UseVisualStyleBackColor = false;
            btnSaveChangePassword.Click += btnSaveChangePassword_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 480);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 6;
            label3.Text = "Confirm Password :";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(224, 475);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(289, 31);
            txtConfirmPassword.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 428);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 4;
            label2.Text = "New Password :";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(224, 422);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(289, 31);
            txtNewPassword.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 377);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 2;
            label1.Text = "Current Password :";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(224, 372);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(289, 31);
            txtCurrentPassword.TabIndex = 1;
            txtCurrentPassword.Validating += txtCurrentPassword_Validating;
            // 
            // ctrlUserCard1
            // 
            ctrlUserCard1.Location = new Point(7, 31);
            ctrlUserCard1.Margin = new Padding(4);
            ctrlUserCard1.Name = "ctrlUserCard1";
            ctrlUserCard1.Size = new Size(947, 343);
            ctrlUserCard1.TabIndex = 0;
            ctrlUserCard1.User = null;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(352, 19);
            label4.Name = "label4";
            label4.Size = new Size(327, 50);
            label4.TabIndex = 7;
            label4.Text = "Change Password";
            // 
            // ebChangePassword
            // 
            ebChangePassword.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 656);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "frmChangePassword";
            Text = "frmChangePassword";
            Load += frmChangePassword_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ebChangePassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private ctrlUserCard ctrlUserCard1;
        private TextBox txtCurrentPassword;
        private Label label3;
        private TextBox txtConfirmPassword;
        private Label label2;
        private TextBox txtNewPassword;
        private Label label1;
        private Label label4;
        private Button btnClose;
        private Button btnSaveChangePassword;
        private ErrorProvider ebChangePassword;
    }
}