namespace DeTai2_Nhom7_LTWIN
{
    partial class UCHistoryCV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHistoryCV));
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.lbSubmitDate = new System.Windows.Forms.Label();
            this.lbCVname = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.lbJobName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHistory
            // 
            this.pnlHistory.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlHistory.Controls.Add(this.lbSubmitDate);
            this.pnlHistory.Controls.Add(this.lbCVname);
            this.pnlHistory.Controls.Add(this.pictureBox2);
            this.pnlHistory.Controls.Add(this.lbLocation);
            this.pnlHistory.Controls.Add(this.lbSalary);
            this.pnlHistory.Controls.Add(this.lbCompanyName);
            this.pnlHistory.Controls.Add(this.lbJobName);
            this.pnlHistory.Controls.Add(this.pictureBox1);
            this.pnlHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHistory.Location = new System.Drawing.Point(0, 0);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(844, 104);
            this.pnlHistory.TabIndex = 0;
            // 
            // lbSubmitDate
            // 
            this.lbSubmitDate.AutoSize = true;
            this.lbSubmitDate.BackColor = System.Drawing.Color.Transparent;
            this.lbSubmitDate.Location = new System.Drawing.Point(517, 76);
            this.lbSubmitDate.Name = "lbSubmitDate";
            this.lbSubmitDate.Size = new System.Drawing.Size(75, 16);
            this.lbSubmitDate.TabIndex = 30;
            this.lbSubmitDate.Text = "Ngày Nộp: ";
            // 
            // lbCVname
            // 
            this.lbCVname.AutoSize = true;
            this.lbCVname.BackColor = System.Drawing.Color.Transparent;
            this.lbCVname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCVname.Location = new System.Drawing.Point(516, 5);
            this.lbCVname.Name = "lbCVname";
            this.lbCVname.Size = new System.Drawing.Size(75, 24);
            this.lbCVname.TabIndex = 29;
            this.lbCVname.Text = "Tên CV";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(383, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.BackColor = System.Drawing.Color.Transparent;
            this.lbLocation.Location = new System.Drawing.Point(255, 73);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(60, 16);
            this.lbLocation.TabIndex = 27;
            this.lbLocation.Text = "Địa điểm";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.BackColor = System.Drawing.Color.Transparent;
            this.lbSalary.Location = new System.Drawing.Point(124, 73);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(68, 16);
            this.lbSalary.TabIndex = 26;
            this.lbSalary.Text = "Mức lương";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lbCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanyName.ForeColor = System.Drawing.Color.Gray;
            this.lbCompanyName.Location = new System.Drawing.Point(124, 37);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(79, 17);
            this.lbCompanyName.TabIndex = 25;
            this.lbCompanyName.Text = "Tên công ti";
            // 
            // lbJobName
            // 
            this.lbJobName.AutoSize = true;
            this.lbJobName.BackColor = System.Drawing.Color.Transparent;
            this.lbJobName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJobName.Location = new System.Drawing.Point(124, 5);
            this.lbJobName.Name = "lbJobName";
            this.lbJobName.Size = new System.Drawing.Size(113, 18);
            this.lbJobName.TabIndex = 24;
            this.lbJobName.Text = "Tên công việc";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // UCHistoryCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHistory);
            this.Name = "UCHistoryCV";
            this.Size = new System.Drawing.Size(844, 104);
            this.Load += new System.EventHandler(this.UCHistoryCV_Load);
            this.pnlHistory.ResumeLayout(false);
            this.pnlHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.Label lbSubmitDate;
        private System.Windows.Forms.Label lbCVname;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.Label lbJobName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
