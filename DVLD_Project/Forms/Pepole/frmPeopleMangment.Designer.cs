namespace DVLD.Forms.PepoleForms
{
    partial class frmPeopleMangment
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
            gridPeople = new DataGridView();
            contextPeople = new ContextMenuStrip(components);
            showDetialsToolStripMenuItem = new ToolStripMenuItem();
            addPersonToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnAddPerson = new Panel();
            txtFilterValue = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridPeople).BeginInit();
            contextPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gridPeople
            // 
            gridPeople.AllowUserToAddRows = false;
            gridPeople.AllowUserToDeleteRows = false;
            gridPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPeople.ContextMenuStrip = contextPeople;
            gridPeople.Location = new Point(12, 384);
            gridPeople.Margin = new Padding(3, 4, 3, 4);
            gridPeople.Name = "gridPeople";
            gridPeople.ReadOnly = true;
            gridPeople.RowHeadersWidth = 51;
            gridPeople.RowTemplate.Height = 24;
            gridPeople.Size = new Size(1183, 300);
            gridPeople.TabIndex = 1;
            // 
            // contextPeople
            // 
            contextPeople.ImageScalingSize = new Size(20, 20);
            contextPeople.Items.AddRange(new ToolStripItem[] { showDetialsToolStripMenuItem, addPersonToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            contextPeople.Name = "contextPeople";
            contextPeople.Size = new Size(173, 108);
            // 
            // showDetialsToolStripMenuItem
            // 
            showDetialsToolStripMenuItem.BackgroundImageLayout = ImageLayout.Zoom;
            showDetialsToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            showDetialsToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            showDetialsToolStripMenuItem.Image = DVLD_Project.Properties.Resources.meticulous__3_;
            showDetialsToolStripMenuItem.Name = "showDetialsToolStripMenuItem";
            showDetialsToolStripMenuItem.Size = new Size(172, 26);
            showDetialsToolStripMenuItem.Text = "Show Detials";
            showDetialsToolStripMenuItem.Click += showDetialsToolStripMenuItem_Click;
            // 
            // addPersonToolStripMenuItem
            // 
            addPersonToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addPersonToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            addPersonToolStripMenuItem.Image = DVLD_Project.Properties.Resources.add_friend;
            addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            addPersonToolStripMenuItem.Size = new Size(172, 26);
            addPersonToolStripMenuItem.Text = "Add Person";
            addPersonToolStripMenuItem.Click += addPersonToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            editToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            editToolStripMenuItem.Image = DVLD_Project.Properties.Resources.edit;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(172, 26);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            deleteToolStripMenuItem.Image = DVLD_Project.Properties.Resources.bin;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(172, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 329);
            label1.Name = "label1";
            label1.Size = new Size(85, 22);
            label1.TabIndex = 2;
            label1.Text = "Filter By";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "PersonID", "NationalNO", "FirstName", "SecondName", "ThirdName", "LastName", "DataOfBirth", "Gender", "Address", "Phone", "Email", "Country" });
            comboBox1.Location = new Point(109, 329);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(193, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(458, 219);
            label2.Name = "label2";
            label2.Size = new Size(358, 39);
            label2.TabIndex = 4;
            label2.Text = "People Management ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = DVLD_Project.Properties.Resources.group;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(388, 15);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(464, 178);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnAddPerson
            // 
            btnAddPerson.BackgroundImage = DVLD_Project.Properties.Resources.add_user__2_;
            btnAddPerson.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddPerson.Cursor = Cursors.Hand;
            btnAddPerson.Location = new Point(1097, 284);
            btnAddPerson.Margin = new Padding(3, 4, 3, 4);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(98, 92);
            btnAddPerson.TabIndex = 6;
            btnAddPerson.Click += btnAddPerson_Click;
            btnAddPerson.Paint += btnAddPerson_Paint;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(308, 330);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(243, 27);
            txtFilterValue.TabIndex = 7;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // frmPeopleMangment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 699);
            Controls.Add(txtFilterValue);
            Controls.Add(btnAddPerson);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(gridPeople);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPeopleMangment";
            Text = "PeopleMangment";
            Load += PeopleMangment_Load;
            ((System.ComponentModel.ISupportInitialize)gridPeople).EndInit();
            contextPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView gridPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel btnAddPerson;
        private TextBox txtFilterValue;
        private ContextMenuStrip contextPeople;
        private ToolStripMenuItem showDetialsToolStripMenuItem;
        private ToolStripMenuItem addPersonToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}