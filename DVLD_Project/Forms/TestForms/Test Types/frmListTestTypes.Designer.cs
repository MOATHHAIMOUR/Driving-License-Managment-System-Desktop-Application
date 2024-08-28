namespace DVLD_Project.Forms.TestForms
{
    partial class frmListTestTypes
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
            label1 = new Label();
            gridTestsTypes = new DataGridView();
            contextTextTypes = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)gridTestsTypes).BeginInit();
            contextTextTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(241, 210);
            label1.Name = "label1";
            label1.Size = new Size(335, 46);
            label1.TabIndex = 5;
            label1.Text = "Manage Tests Types";
            // 
            // gridTestsTypes
            // 
            gridTestsTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTestsTypes.ContextMenuStrip = contextTextTypes;
            gridTestsTypes.Location = new Point(12, 269);
            gridTestsTypes.Name = "gridTestsTypes";
            gridTestsTypes.RowHeadersWidth = 51;
            gridTestsTypes.Size = new Size(759, 292);
            gridTestsTypes.TabIndex = 4;
            // 
            // contextTextTypes
            // 
            contextTextTypes.ImageScalingSize = new Size(20, 20);
            contextTextTypes.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            contextTextTypes.Name = "contextTextTypes";
            contextTextTypes.Size = new Size(110, 30);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editToolStripMenuItem.Image = Properties.Resources.testing;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(109, 26);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.test;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(298, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 173);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ControlLight;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnClose.Location = new Point(644, 567);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(127, 39);
            btnClose.TabIndex = 26;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmListTestTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 615);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(gridTestsTypes);
            Controls.Add(pictureBox1);
            Name = "frmListTestTypes";
            Text = "frmTestTypes";
            Load += frmTestTypes_Load;
            ((System.ComponentModel.ISupportInitialize)gridTestsTypes).EndInit();
            contextTextTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView gridTestsTypes;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextTextTypes;
        private ToolStripMenuItem editToolStripMenuItem;
        private Button btnClose;
    }
}