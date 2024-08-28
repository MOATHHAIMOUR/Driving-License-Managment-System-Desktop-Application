namespace DVLD
{
    partial class frmDashboard
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
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btnPeopleMangment = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            btnPeopleMangment.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnPeopleMangment);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1258, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = DVLD_Project.Properties.Resources.group;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(268, 15);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 91);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnPeopleMangment
            // 
            btnPeopleMangment.Controls.Add(label1);
            btnPeopleMangment.Cursor = Cursors.Hand;
            btnPeopleMangment.Location = new Point(268, 15);
            btnPeopleMangment.Margin = new Padding(3, 4, 3, 4);
            btnPeopleMangment.Name = "btnPeopleMangment";
            btnPeopleMangment.Size = new Size(207, 91);
            btnPeopleMangment.TabIndex = 1;
            btnPeopleMangment.MouseClick += btnPeopleMangment_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 29);
            label1.Name = "label1";
            label1.Size = new Size(97, 29);
            label1.TabIndex = 0;
            label1.Text = "People";
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 566);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDashboard";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            btnPeopleMangment.ResumeLayout(false);
            btnPeopleMangment.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel btnPeopleMangment;
        private System.Windows.Forms.Label label1;
    }
}

