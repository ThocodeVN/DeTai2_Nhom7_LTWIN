namespace DeTai2_Nhom7_LTWIN
{
    partial class FJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FJob));
            this.pnlFunc = new Guna.UI.WinForms.GunaGradientPanel();
            this.fpnlJob = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateJob = new System.Windows.Forms.Button();
            this.pnlFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFunc
            // 
            this.pnlFunc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFunc.BackgroundImage")));
            this.pnlFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFunc.Controls.Add(this.btnCreateJob);
            this.pnlFunc.Controls.Add(this.fpnlJob);
            this.pnlFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFunc.GradientColor1 = System.Drawing.Color.White;
            this.pnlFunc.GradientColor2 = System.Drawing.Color.White;
            this.pnlFunc.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(250)))), ((int)(((byte)(178)))));
            this.pnlFunc.GradientColor4 = System.Drawing.Color.White;
            this.pnlFunc.Location = new System.Drawing.Point(0, 0);
            this.pnlFunc.Name = "pnlFunc";
            this.pnlFunc.Size = new System.Drawing.Size(794, 694);
            this.pnlFunc.TabIndex = 6;
            this.pnlFunc.Text = "gunaGradientPanel3";
            // 
            // fpnlJob
            // 
            this.fpnlJob.BackColor = System.Drawing.Color.Transparent;
            this.fpnlJob.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fpnlJob.Location = new System.Drawing.Point(0, 83);
            this.fpnlJob.Name = "fpnlJob";
            this.fpnlJob.Padding = new System.Windows.Forms.Padding(10);
            this.fpnlJob.Size = new System.Drawing.Size(794, 611);
            this.fpnlJob.TabIndex = 0;
            // 
            // btnCreateJob
            // 
            this.btnCreateJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(195)))), ((int)(((byte)(41)))));
            this.btnCreateJob.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateJob.ForeColor = System.Drawing.Color.White;
            this.btnCreateJob.Location = new System.Drawing.Point(545, 12);
            this.btnCreateJob.Name = "btnCreateJob";
            this.btnCreateJob.Size = new System.Drawing.Size(195, 55);
            this.btnCreateJob.TabIndex = 9;
            this.btnCreateJob.Text = "Tạo công việc mới!";
            this.btnCreateJob.UseVisualStyleBackColor = false;
            this.btnCreateJob.Click += new System.EventHandler(this.btnCreateJob_Click);
            // 
            // FJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 694);
            this.ControlBox = false;
            this.Controls.Add(this.pnlFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FJob";
            this.Text = "FJob";
            this.Load += new System.EventHandler(this.FJob_Load);
            this.pnlFunc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel pnlFunc;
        private System.Windows.Forms.FlowLayoutPanel fpnlJob;
        private System.Windows.Forms.Button btnCreateJob;
    }
}