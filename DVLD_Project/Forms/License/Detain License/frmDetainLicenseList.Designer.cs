namespace DVLD_Project.Forms.License.Detain_License
{
    partial class frmDetainLicenseList
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
            label2 = new Label();
            comboFilterBy = new ComboBox();
            gridUsers = new DataGridView();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            contexDetaainApplication = new ContextMenuStrip(components);
            showApplicationDetialsToolStripMenuItem = new ToolStripMenuItem();
            editApplicationToolStripMenuItem = new ToolStripMenuItem();
            deleteApplicationToolStripMenuItem = new ToolStripMenuItem();
            cancelApplicationToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)gridUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contexDetaainApplication.SuspendLayout();
            SuspendLayout();
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(211, 245);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(243, 27);
            txtFilterValue.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(283, 151);
            label2.Name = "label2";
            label2.Size = new Size(424, 36);
            label2.TabIndex = 19;
            label2.Text = "Detain License Management ";
            // 
            // comboFilterBy
            // 
            comboFilterBy.FormattingEnabled = true;
            comboFilterBy.Items.AddRange(new object[] { "None", "UserID", "PersonID", "UserName", "IsActive" });
            comboFilterBy.Location = new Point(12, 244);
            comboFilterBy.Margin = new Padding(3, 4, 3, 4);
            comboFilterBy.Name = "comboFilterBy";
            comboFilterBy.Size = new Size(193, 28);
            comboFilterBy.TabIndex = 18;
            // 
            // gridUsers
            // 
            gridUsers.AllowUserToAddRows = false;
            gridUsers.AllowUserToDeleteRows = false;
            gridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUsers.ContextMenuStrip = contexDetaainApplication;
            gridUsers.Location = new Point(12, 280);
            gridUsers.Margin = new Padding(3, 4, 3, 4);
            gridUsers.Name = "gridUsers";
            gridUsers.ReadOnly = true;
            gridUsers.RowHeadersWidth = 51;
            gridUsers.RowTemplate.Height = 24;
            gridUsers.Size = new Size(917, 300);
            gridUsers.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.police_badge;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(364, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 134);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button1.Location = new Point(826, 587);
            button1.Name = "button1";
            button1.Size = new Size(103, 39);
            button1.TabIndex = 54;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            // 
            // contexDetaainApplication
            // 
            contexDetaainApplication.ImageScalingSize = new Size(20, 20);
            contexDetaainApplication.Items.AddRange(new ToolStripItem[] { showApplicationDetialsToolStripMenuItem, editApplicationToolStripMenuItem, deleteApplicationToolStripMenuItem, cancelApplicationToolStripMenuItem });
            contexDetaainApplication.Name = "contextMenuStrip1";
            contexDetaainApplication.Size = new Size(284, 108);
            // 
            // showApplicationDetialsToolStripMenuItem
            // 
            showApplicationDetialsToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            showApplicationDetialsToolStripMenuItem.Image = Properties.Resources.avatar;
            showApplicationDetialsToolStripMenuItem.Name = "showApplicationDetialsToolStripMenuItem";
            showApplicationDetialsToolStripMenuItem.Size = new Size(283, 26);
            showApplicationDetialsToolStripMenuItem.Text = "Show Person Detials";
            // 
            // editApplicationToolStripMenuItem
            // 
            editApplicationToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            editApplicationToolStripMenuItem.Image = Properties.Resources.license1;
            editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            editApplicationToolStripMenuItem.Size = new Size(283, 26);
            editApplicationToolStripMenuItem.Text = "Show License Details";
            // 
            // deleteApplicationToolStripMenuItem
            // 
            deleteApplicationToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteApplicationToolStripMenuItem.Image = Properties.Resources.history;
            deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            deleteApplicationToolStripMenuItem.Size = new Size(283, 26);
            deleteApplicationToolStripMenuItem.Text = "Show Person License History";
            // 
            // cancelApplicationToolStripMenuItem
            // 
            cancelApplicationToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cancelApplicationToolStripMenuItem.Image = Properties.Resources.police_badge;
            cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            cancelApplicationToolStripMenuItem.Size = new Size(283, 26);
            cancelApplicationToolStripMenuItem.Text = "Release Detain License";
            // 
            // frmDetainLicenseList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 631);
            Controls.Add(button1);
            Controls.Add(txtFilterValue);
            Controls.Add(label2);
            Controls.Add(comboFilterBy);
            Controls.Add(gridUsers);
            Controls.Add(pictureBox1);
            Name = "frmDetainLicenseList";
            Text = "frmDetainLicenseList";
            ((System.ComponentModel.ISupportInitialize)gridUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contexDetaainApplication.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilterValue;
        private Label label2;
        private ComboBox comboFilterBy;
        private DataGridView gridUsers;
        private PictureBox pictureBox1;
        private Button button1;
        private ContextMenuStrip contexDetaainApplication;
        private ToolStripMenuItem showApplicationDetialsToolStripMenuItem;
        private ToolStripMenuItem editApplicationToolStripMenuItem;
        private ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private ToolStripMenuItem cancelApplicationToolStripMenuItem;
    }
}