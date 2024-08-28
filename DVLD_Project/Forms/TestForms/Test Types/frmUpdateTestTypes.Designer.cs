namespace DVLD_Project.Forms.TestForms
{
    partial class frmUpdateTestTypes
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
            txtFees = new TextBox();
            txtTitle = new TextBox();
            lbID = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDescription = new TextBox();
            label5 = new Label();
            button1 = new Button();
            btnTestTypeSave = new Button();
            SuspendLayout();
            // 
            // txtFees
            // 
            txtFees.Location = new Point(183, 281);
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(246, 27);
            txtFees.TabIndex = 18;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(183, 171);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(246, 27);
            txtTitle.TabIndex = 17;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lbID.Location = new Point(76, 104);
            lbID.Name = "lbID";
            lbID.Size = new Size(34, 31);
            lbID.TabIndex = 16;
            lbID.Text = "??";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(20, 277);
            label4.Name = "label4";
            label4.Size = new Size(78, 31);
            label4.TabIndex = 15;
            label4.Text = "Fees : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(20, 167);
            label3.Name = "label3";
            label3.Size = new Size(80, 31);
            label3.TabIndex = 14;
            label3.Text = "Title : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(20, 104);
            label2.Name = "label2";
            label2.Size = new Size(56, 31);
            label2.TabIndex = 13;
            label2.Text = "ID : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(151, 21);
            label1.Name = "label1";
            label1.Size = new Size(197, 38);
            label1.TabIndex = 12;
            label1.Text = "Edit Test Type";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(183, 224);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(246, 27);
            txtDescription.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.Location = new Point(20, 220);
            label5.Name = "label5";
            label5.Size = new Size(147, 31);
            label5.TabIndex = 21;
            label5.Text = "description :";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button1.Location = new Point(261, 337);
            button1.Name = "button1";
            button1.Size = new Size(103, 39);
            button1.TabIndex = 24;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnTestTypeSave
            // 
            btnTestTypeSave.BackColor = SystemColors.ControlLight;
            btnTestTypeSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnTestTypeSave.Location = new Point(370, 337);
            btnTestTypeSave.Name = "btnTestTypeSave";
            btnTestTypeSave.Size = new Size(103, 39);
            btnTestTypeSave.TabIndex = 23;
            btnTestTypeSave.Text = "Save";
            btnTestTypeSave.UseVisualStyleBackColor = false;
            btnTestTypeSave.Click += btnTestTypeSave_Click;
            // 
            // frmUpdateTestTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 392);
            Controls.Add(button1);
            Controls.Add(btnTestTypeSave);
            Controls.Add(txtDescription);
            Controls.Add(label5);
            Controls.Add(txtFees);
            Controls.Add(txtTitle);
            Controls.Add(lbID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUpdateTestTypes";
            Text = "frmUpdateTestTypes";
            Load += frmUpdateTestTypes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtFees;
        private TextBox txtTitle;
        private Label lbID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDescription;
        private Label label5;
        private Button button1;
        private Button btnTestTypeSave;
    }
}