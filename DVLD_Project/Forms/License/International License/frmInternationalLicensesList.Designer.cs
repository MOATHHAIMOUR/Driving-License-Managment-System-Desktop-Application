namespace DVLD_Project.Forms.License.International_License
{
    partial class frmInternationalLicensesList
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
            button1 = new Button();
            txtFilterValue = new TextBox();
            label2 = new Label();
            comboFilterBy = new ComboBox();
            gridInternationalLicenses = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            contexInternationalApplication = new ContextMenuStrip(components);
            showApplicationDetialsToolStripMenuItem = new ToolStripMenuItem();
            editApplicationToolStripMenuItem = new ToolStripMenuItem();
            deleteApplicationToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)gridInternationalLicenses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            contexInternationalApplication.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button1.Location = new Point(827, 599);
            button1.Name = "button1";
            button1.Size = new Size(103, 39);
            button1.TabIndex = 60;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(212, 257);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(243, 27);
            txtFilterValue.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(325, 168);
            label2.Name = "label2";
            label2.Size = new Size(327, 36);
            label2.TabIndex = 58;
            label2.Text = "International Licenses";
            // 
            // comboFilterBy
            // 
            comboFilterBy.FormattingEnabled = true;
            comboFilterBy.Items.AddRange(new object[] { "None", "UserID", "PersonID", "UserName", "IsActive" });
            comboFilterBy.Location = new Point(13, 256);
            comboFilterBy.Margin = new Padding(3, 4, 3, 4);
            comboFilterBy.Name = "comboFilterBy";
            comboFilterBy.Size = new Size(193, 28);
            comboFilterBy.TabIndex = 57;
            // 
            // gridInternationalLicenses
            // 
            gridInternationalLicenses.AllowUserToAddRows = false;
            gridInternationalLicenses.AllowUserToDeleteRows = false;
            gridInternationalLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridInternationalLicenses.Location = new Point(13, 292);
            gridInternationalLicenses.Margin = new Padding(3, 4, 3, 4);
            gridInternationalLicenses.Name = "gridInternationalLicenses";
            gridInternationalLicenses.ReadOnly = true;
            gridInternationalLicenses.RowHeadersWidth = 51;
            gridInternationalLicenses.RowTemplate.Height = 24;
            gridInternationalLicenses.Size = new Size(917, 300);
            gridInternationalLicenses.TabIndex = 56;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.license1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(353, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 144);
            pictureBox1.TabIndex = 61;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.global_network1;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(579, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(116, 75);
            pictureBox2.TabIndex = 62;
            pictureBox2.TabStop = false;
            // 
            // contexInternationalApplication
            // 
            contexInternationalApplication.ImageScalingSize = new Size(20, 20);
            contexInternationalApplication.Items.AddRange(new ToolStripItem[] { showApplicationDetialsToolStripMenuItem, editApplicationToolStripMenuItem, deleteApplicationToolStripMenuItem });
            contexInternationalApplication.Name = "contextMenuStrip1";
            contexInternationalApplication.Size = new Size(284, 82);
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
            // frmInternationalLicensesList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 649);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(txtFilterValue);
            Controls.Add(label2);
            Controls.Add(comboFilterBy);
            Controls.Add(gridInternationalLicenses);
            Name = "frmInternationalLicensesList";
            Text = "frmInternationalLicensesList";
            Load += frmInternationalLicensesList_Load;
            ((System.ComponentModel.ISupportInitialize)gridInternationalLicenses).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            contexInternationalApplication.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtFilterValue;
        private Label label2;
        private ComboBox comboFilterBy;
        private DataGridView gridInternationalLicenses;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ContextMenuStrip contexInternationalApplication;
        private ToolStripMenuItem showApplicationDetialsToolStripMenuItem;
        private ToolStripMenuItem editApplicationToolStripMenuItem;
        private ToolStripMenuItem deleteApplicationToolStripMenuItem;
    }
}