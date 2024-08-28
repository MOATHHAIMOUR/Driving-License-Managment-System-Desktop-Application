namespace DVLD_Project.Forms.Drivers
{
    partial class frmListDrivers
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
            gridDrivers = new DataGridView();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showPersonInfoToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)gridDrivers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(201, 234);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(201, 27);
            txtFilterValue.TabIndex = 20;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(364, 181);
            label2.Name = "label2";
            label2.Size = new Size(227, 32);
            label2.TabIndex = 19;
            label2.Text = "Manage Drivers";
            // 
            // comboFilterBy
            // 
            comboFilterBy.AutoCompleteCustomSource.AddRange(new string[] { "None", "Driver ID", "Person ID", "National No.", "Full Name" });
            comboFilterBy.FormattingEnabled = true;
            comboFilterBy.Items.AddRange(new object[] { "None", "UserID", "PersonID", "UserName", "IsActive" });
            comboFilterBy.Location = new Point(12, 234);
            comboFilterBy.Margin = new Padding(3, 4, 3, 4);
            comboFilterBy.Name = "comboFilterBy";
            comboFilterBy.Size = new Size(167, 28);
            comboFilterBy.TabIndex = 18;
            // 
            // gridDrivers
            // 
            gridDrivers.AllowUserToAddRows = false;
            gridDrivers.AllowUserToDeleteRows = false;
            gridDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDrivers.Location = new Point(12, 270);
            gridDrivers.Margin = new Padding(3, 4, 3, 4);
            gridDrivers.Name = "gridDrivers";
            gridDrivers.ReadOnly = true;
            gridDrivers.RowHeadersWidth = 51;
            gridDrivers.RowTemplate.Height = 24;
            gridDrivers.Size = new Size(883, 224);
            gridDrivers.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.license1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(333, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 155);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button1.Location = new Point(780, 501);
            button1.Name = "button1";
            button1.Size = new Size(115, 48);
            button1.TabIndex = 46;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showPersonInfoToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(284, 84);
            // 
            // showPersonInfoToolStripMenuItem
            // 
            showPersonInfoToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            showPersonInfoToolStripMenuItem.Image = Properties.Resources.avatar;
            showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            showPersonInfoToolStripMenuItem.Size = new Size(283, 26);
            showPersonInfoToolStripMenuItem.Text = "Show Person Info ";
            showPersonInfoToolStripMenuItem.Click += showPersonInfoToolStripMenuItem_Click;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            showPersonLicenseHistoryToolStripMenuItem.Image = Properties.Resources.history;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(283, 26);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            // 
            // frmListDrivers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 552);
            Controls.Add(button1);
            Controls.Add(txtFilterValue);
            Controls.Add(label2);
            Controls.Add(comboFilterBy);
            Controls.Add(gridDrivers);
            Controls.Add(pictureBox1);
            Name = "frmListDrivers";
            Text = "frmListDrivers";
            Load += frmListDrivers_Load;
            ((System.ComponentModel.ISupportInitialize)gridDrivers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilterValue;
        private Label label2;
        private ComboBox comboFilterBy;
        private DataGridView gridDrivers;
        private PictureBox pictureBox1;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}