namespace DeTai2_Nhom7_LTWIN
{
    partial class UCJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCJob));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbJobName = new System.Windows.Forms.Label();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbJobName
            // 
            this.lbJobName.AutoSize = true;
            this.lbJobName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJobName.Location = new System.Drawing.Point(142, 23);
            this.lbJobName.Name = "lbJobName";
            this.lbJobName.Size = new System.Drawing.Size(113, 18);
            this.lbJobName.TabIndex = 1;
            this.lbJobName.Text = "Tên công việc";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanyName.ForeColor = System.Drawing.Color.Gray;
            this.lbCompanyName.Location = new System.Drawing.Point(142, 55);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(79, 17);
            this.lbCompanyName.TabIndex = 2;
            this.lbCompanyName.Text = "Tên công ti";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbSalary.Location = new System.Drawing.Point(142, 91);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(68, 16);
            this.lbSalary.TabIndex = 3;
            this.lbSalary.Text = "Mức lương";
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbLocation.Location = new System.Drawing.Point(273, 91);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(60, 16);
            this.lbLocation.TabIndex = 4;
            this.lbLocation.Text = "Địa điểm";
            // 
            // UCJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.lbJobName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCJob";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(410, 119);
            this.Load += new System.EventHandler(this.UCJob_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UCJob_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbJobName;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Label lbLocation;
    }
}
