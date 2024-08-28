namespace DVLD_Project.Forms.TestForms
{
    partial class frmTestAppoinments
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
            pictureImage = new PictureBox();
            lbHeader = new Label();
            ctrlApplicationInfo1 = new ApplicationsForms.Controls.ctrlApplicationInfo();
            gridTests = new DataGridView();
            contextAppoinments = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            takeTistToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            button1 = new Button();
            btnAddTestAppointment = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridTests).BeginInit();
            contextAppoinments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddTestAppointment).BeginInit();
            SuspendLayout();
            // 
            // pictureImage
            // 
            pictureImage.BackgroundImage = Properties.Resources.eye_scan;
            pictureImage.BackgroundImageLayout = ImageLayout.Zoom;
            pictureImage.Location = new Point(251, 12);
            pictureImage.Name = "pictureImage";
            pictureImage.Size = new Size(251, 137);
            pictureImage.TabIndex = 0;
            pictureImage.TabStop = false;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.ForeColor = Color.Firebrick;
            lbHeader.Location = new Point(213, 162);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(349, 41);
            lbHeader.TabIndex = 1;
            lbHeader.Text = "Vision Test Appoinmets";
            // 
            // ctrlApplicationInfo1
            // 
            ctrlApplicationInfo1.Location = new Point(5, 206);
            ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            ctrlApplicationInfo1.Size = new Size(727, 398);
            ctrlApplicationInfo1.TabIndex = 2;
            // 
            // gridTests
            // 
            gridTests.AllowUserToAddRows = false;
            gridTests.AllowUserToDeleteRows = false;
            gridTests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTests.ContextMenuStrip = contextAppoinments;
            gridTests.Location = new Point(23, 669);
            gridTests.Name = "gridTests";
            gridTests.ReadOnly = true;
            gridTests.RowHeadersWidth = 51;
            gridTests.Size = new Size(703, 188);
            gridTests.TabIndex = 3;
            // 
            // contextAppoinments
            // 
            contextAppoinments.ImageScalingSize = new Size(20, 20);
            contextAppoinments.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, takeTistToolStripMenuItem });
            contextAppoinments.Name = "contextAppoinments";
            contextAppoinments.Size = new Size(215, 84);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.BackgroundImageLayout = ImageLayout.Zoom;
            editToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            editToolStripMenuItem.Image = Properties.Resources.calendar1;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(214, 26);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // takeTistToolStripMenuItem
            // 
            takeTistToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            takeTistToolStripMenuItem.Image = Properties.Resources.list;
            takeTistToolStripMenuItem.Name = "takeTistToolStripMenuItem";
            takeTistToolStripMenuItem.Size = new Size(214, 26);
            takeTistToolStripMenuItem.Text = "Take Test";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 616);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 4;
            label2.Text = "Appoitments :";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button1.Location = new Point(599, 863);
            button1.Name = "button1";
            button1.Size = new Size(127, 39);
            button1.TabIndex = 25;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnAddTestAppointment
            // 
            btnAddTestAppointment.BackgroundImage = Properties.Resources.schedule;
            btnAddTestAppointment.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddTestAppointment.Location = new Point(675, 610);
            btnAddTestAppointment.Name = "btnAddTestAppointment";
            btnAddTestAppointment.Size = new Size(51, 44);
            btnAddTestAppointment.TabIndex = 26;
            btnAddTestAppointment.TabStop = false;
            btnAddTestAppointment.Click += btnAddTestAppointment_Click;
            // 
            // frmTestAppoinments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 913);
            Controls.Add(btnAddTestAppointment);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(gridTests);
            Controls.Add(ctrlApplicationInfo1);
            Controls.Add(lbHeader);
            Controls.Add(pictureImage);
            Name = "frmTestAppoinments";
            Text = "frmVisionTestAppoinments";
            Load += frmTestAppoinments_Load;
            ((System.ComponentModel.ISupportInitialize)pictureImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridTests).EndInit();
            contextAppoinments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnAddTestAppointment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureImage;
        private Label lbHeader;
        private ApplicationsForms.Controls.ctrlApplicationInfo ctrlApplicationInfo1;
        private DataGridView gridTests;
        private Label label2;
        private Button button1;
        private PictureBox btnAddTestAppointment;
        private ContextMenuStrip contextAppoinments;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem takeTistToolStripMenuItem;
    }
}