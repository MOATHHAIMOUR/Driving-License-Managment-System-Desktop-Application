namespace DVLD_Project.Forms.License.Controls
{
    partial class ctrlDriverLicenses
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            gridLocalLicenses = new DataGridView();
            contextLicenseInfo = new ContextMenuStrip(components);
            showLicenseInfoToolStripMenuItem = new ToolStripMenuItem();
            tabPage2 = new TabPage();
            lbLicenseHistorey = new Label();
            gridInternationalLicenses = new DataGridView();
            groupBox1 = new GroupBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridLocalLicenses).BeginInit();
            contextLicenseInfo.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridInternationalLicenses).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(6, 29);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(902, 181);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(gridLocalLicenses);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(894, 145);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Local";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 8);
            label1.Name = "label1";
            label1.Size = new Size(192, 23);
            label1.TabIndex = 1;
            label1.Text = "Local License History : ";
            // 
            // gridLocalLicenses
            // 
            gridLocalLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridLocalLicenses.ContextMenuStrip = contextLicenseInfo;
            gridLocalLicenses.Location = new Point(6, 34);
            gridLocalLicenses.Name = "gridLocalLicenses";
            gridLocalLicenses.RowHeadersWidth = 51;
            gridLocalLicenses.Size = new Size(882, 107);
            gridLocalLicenses.TabIndex = 0;
            // 
            // contextLicenseInfo
            // 
            contextLicenseInfo.ImageScalingSize = new Size(20, 20);
            contextLicenseInfo.Items.AddRange(new ToolStripItem[] { showLicenseInfoToolStripMenuItem });
            contextLicenseInfo.Name = "contextLicenseInfo";
            contextLicenseInfo.Size = new Size(209, 30);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            showLicenseInfoToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showLicenseInfoToolStripMenuItem.Image = Properties.Resources.license1;
            showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            showLicenseInfoToolStripMenuItem.Size = new Size(208, 26);
            showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ButtonFace;
            tabPage2.Controls.Add(lbLicenseHistorey);
            tabPage2.Controls.Add(gridInternationalLicenses);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(777, 145);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "International";
            // 
            // lbLicenseHistorey
            // 
            lbLicenseHistorey.AutoSize = true;
            lbLicenseHistorey.Location = new Point(6, 14);
            lbLicenseHistorey.Name = "lbLicenseHistorey";
            lbLicenseHistorey.Size = new Size(249, 23);
            lbLicenseHistorey.TabIndex = 1;
            lbLicenseHistorey.Text = "International License History :";
            // 
            // gridInternationalLicenses
            // 
            gridInternationalLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridInternationalLicenses.Location = new Point(6, 40);
            gridInternationalLicenses.Name = "gridInternationalLicenses";
            gridInternationalLicenses.RowHeadersWidth = 51;
            gridInternationalLicenses.Size = new Size(940, 101);
            gridInternationalLicenses.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(914, 223);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Driver Licenses";
            // 
            // ctrlDriverLicenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ctrlDriverLicenses";
            Size = new Size(925, 232);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridLocalLicenses).EndInit();
            contextLicenseInfo.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridInternationalLicenses).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Label lbLicenseHistorey;
        private DataGridView gridInternationalLicenses;
        private DataGridView gridLocalLicenses;
        private Label label1;
        private ContextMenuStrip contextLicenseInfo;
        private ToolStripMenuItem showLicenseInfoToolStripMenuItem;
    }
}
