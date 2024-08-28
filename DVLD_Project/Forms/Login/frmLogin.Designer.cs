namespace DVLD_Project.Forms.UsersForms
{
    partial class frmLogin
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            chRememberMe = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 551);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 327);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(374, 215);
            label1.TabIndex = 1;
            label1.Text = "WELCOM TO DRIVING & VEHICLE LICENSE DEPARTMENT MANGMENT (DVLD) SYSTEM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.license1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(32, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(374, 264);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(471, 62);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(374, 106);
            label2.TabIndex = 2;
            label2.Text = "Login to your account";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(471, 215);
            label3.Name = "label3";
            label3.Size = new Size(161, 38);
            label3.TabIndex = 3;
            label3.Text = "username :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(471, 281);
            label4.Name = "label4";
            label4.Size = new Size(156, 38);
            label4.TabIndex = 4;
            label4.Text = "password :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(638, 226);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(257, 27);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(638, 292);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(257, 27);
            txtPassword.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.WhiteSmoke;
            btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Image = Properties.Resources.password;
            btnLogin.ImageAlign = ContentAlignment.MiddleRight;
            btnLogin.Location = new Point(742, 406);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(153, 63);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login   ";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chRememberMe
            // 
            chRememberMe.AutoSize = true;
            chRememberMe.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chRememberMe.Location = new Point(638, 341);
            chRememberMe.Name = "chRememberMe";
            chRememberMe.Size = new Size(146, 27);
            chRememberMe.TabIndex = 8;
            chRememberMe.Text = "remember me";
            chRememberMe.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 551);
            Controls.Add(chRememberMe);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private CheckBox chRememberMe;
    }
}