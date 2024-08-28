namespace DVLD_Project.Forms.PepoleForms.Controls
{
    partial class ctrlPersonDetailsWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbFilter = new GroupBox();
            btnAddNewPerson = new Button();
            btnSearch = new Button();
            txtFilterValue = new TextBox();
            cbFilterBy = new ComboBox();
            label1 = new Label();
            ctrlPersonCard1 = new ctrlPersonCard();
            gbFilter.SuspendLayout();
            SuspendLayout();
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btnAddNewPerson);
            gbFilter.Controls.Add(btnSearch);
            gbFilter.Controls.Add(txtFilterValue);
            gbFilter.Controls.Add(cbFilterBy);
            gbFilter.Controls.Add(label1);
            gbFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFilter.Location = new Point(12, 16);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(934, 92);
            gbFilter.TabIndex = 1;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.BackColor = SystemColors.ControlLight;
            btnAddNewPerson.BackgroundImage = Properties.Resources.add_user__2_;
            btnAddNewPerson.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNewPerson.Location = new Point(741, 37);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new Size(44, 41);
            btnAddNewPerson.TabIndex = 4;
            btnAddNewPerson.UseVisualStyleBackColor = false;
            btnAddNewPerson.Click += button2_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlLight;
            btnSearch.BackgroundImage = Properties.Resources.searching;
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.Location = new Point(684, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(51, 41);
            btnSearch.TabIndex = 3;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(365, 40);
            txtFilterValue.Multiline = true;
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(299, 36);
            txtFilterValue.TabIndex = 2;
            // 
            // cbFilterBy
            // 
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "PersonID", "NationalNo" });
            cbFilterBy.Location = new Point(112, 40);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(247, 36);
            cbFilterBy.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(87, 28);
            label1.TabIndex = 0;
            label1.Text = "FindBy :";
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new Point(12, 114);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(934, 237);
            ctrlPersonCard1.TabIndex = 2;
            // 
            // ctrlPersonDetailsWithFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ctrlPersonCard1);
            Controls.Add(gbFilter);
            Name = "ctrlPersonDetailsWithFilter";
            Size = new Size(969, 354);
            Load += ctrlPersonDetailsWithFilter_Load;
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbFilter;
        private Button btnSearch;
        private TextBox txtFilterValue;
        private ComboBox cbFilterBy;
        private Label label1;
        private Button btnAddNewPerson;
        private ctrlPersonCard ctrlPersonCard1;
    }
}
