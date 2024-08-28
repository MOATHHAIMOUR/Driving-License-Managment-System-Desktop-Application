namespace DVLD_Project.Forms.UsersForms
{
    partial class frmUsersMangments
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
            txtFilterValue = new TextBox();
            btnAddUser = new Panel();
            label2 = new Label();
            comboFilterBy = new ComboBox();
            label1 = new Label();
            gridUsers = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addNewUserToolStripMenuItem = new ToolStripMenuItem();
            addNewUserToolStripMenuItem1 = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            chToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            comboIsActive = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)gridUsers).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(308, 326);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(243, 27);
            txtFilterValue.TabIndex = 14;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // btnAddUser
            // 
            btnAddUser.BackgroundImage = Properties.Resources.add_user__2_1;
            btnAddUser.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddUser.Cursor = Cursors.Hand;
            btnAddUser.Location = new Point(1097, 280);
            btnAddUser.Margin = new Padding(3, 4, 3, 4);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(98, 92);
            btnAddUser.TabIndex = 13;
            btnAddUser.MouseClick += btnAddUser_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(474, 214);
            label2.Name = "label2";
            label2.Size = new Size(339, 39);
            label2.TabIndex = 12;
            label2.Text = "Users Management ";
            // 
            // comboFilterBy
            // 
            comboFilterBy.FormattingEnabled = true;
            comboFilterBy.Items.AddRange(new object[] { "None", "UserID", "PersonID", "UserName", "IsActive" });
            comboFilterBy.Location = new Point(109, 325);
            comboFilterBy.Margin = new Padding(3, 4, 3, 4);
            comboFilterBy.Name = "comboFilterBy";
            comboFilterBy.Size = new Size(193, 28);
            comboFilterBy.TabIndex = 11;
            comboFilterBy.SelectedIndexChanged += comboFilterBy_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 325);
            label1.Name = "label1";
            label1.Size = new Size(85, 22);
            label1.TabIndex = 10;
            label1.Text = "Filter By";
            // 
            // gridUsers
            // 
            gridUsers.AllowUserToAddRows = false;
            gridUsers.AllowUserToDeleteRows = false;
            gridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUsers.ContextMenuStrip = contextMenuStrip1;
            gridUsers.Location = new Point(12, 380);
            gridUsers.Margin = new Padding(3, 4, 3, 4);
            gridUsers.Name = "gridUsers";
            gridUsers.ReadOnly = true;
            gridUsers.RowHeadersWidth = 51;
            gridUsers.RowTemplate.Height = 24;
            gridUsers.Size = new Size(1183, 300);
            gridUsers.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addNewUserToolStripMenuItem, addNewUserToolStripMenuItem1, editToolStripMenuItem, deleteToolStripMenuItem, chToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(206, 134);
            // 
            // addNewUserToolStripMenuItem
            // 
            addNewUserToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addNewUserToolStripMenuItem.Image = Properties.Resources.business_card;
            addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            addNewUserToolStripMenuItem.Size = new Size(205, 26);
            addNewUserToolStripMenuItem.Text = "User Details";
            addNewUserToolStripMenuItem.Click += addNewUserToolStripMenuItem_Click;
            // 
            // addNewUserToolStripMenuItem1
            // 
            addNewUserToolStripMenuItem1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addNewUserToolStripMenuItem1.Image = Properties.Resources.add_user__2_1;
            addNewUserToolStripMenuItem1.Name = "addNewUserToolStripMenuItem1";
            addNewUserToolStripMenuItem1.Size = new Size(205, 26);
            addNewUserToolStripMenuItem1.Text = "Add New User";
            addNewUserToolStripMenuItem1.Click += addNewUserToolStripMenuItem1_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            editToolStripMenuItem.Image = Properties.Resources.user;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(205, 26);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteToolStripMenuItem.Image = Properties.Resources.garbage;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(205, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // chToolStripMenuItem
            // 
            chToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chToolStripMenuItem.Image = Properties.Resources.reset_password;
            chToolStripMenuItem.Name = "chToolStripMenuItem";
            chToolStripMenuItem.Size = new Size(205, 26);
            chToolStripMenuItem.Text = "Change Password";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.management1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(388, 11);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(464, 178);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // comboIsActive
            // 
            comboIsActive.FormattingEnabled = true;
            comboIsActive.ImeMode = ImeMode.NoControl;
            comboIsActive.Items.AddRange(new object[] { "All", "Yes", "No" });
            comboIsActive.Location = new Point(308, 326);
            comboIsActive.Name = "comboIsActive";
            comboIsActive.Size = new Size(146, 28);
            comboIsActive.TabIndex = 15;
            comboIsActive.SelectedIndexChanged += comboIsActive_SelectedIndexChanged;
            // 
            // frmUsersMangments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 693);
            Controls.Add(comboIsActive);
            Controls.Add(txtFilterValue);
            Controls.Add(btnAddUser);
            Controls.Add(label2);
            Controls.Add(comboFilterBy);
            Controls.Add(label1);
            Controls.Add(gridUsers);
            Controls.Add(pictureBox1);
            Name = "frmUsersMangments";
            Text = "frmUsersMangments";
            Load += frmUsersMangments_Load;
            ((System.ComponentModel.ISupportInitialize)gridUsers).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilterValue;
        private Panel btnAddUser;
        private Label label2;
        private ComboBox comboFilterBy;
        private Label label1;
        private DataGridView gridUsers;
        private PictureBox pictureBox1;
        private ComboBox comboIsActive;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem addNewUserToolStripMenuItem;
        private ToolStripMenuItem addNewUserToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem chToolStripMenuItem;
    }
}