namespace DeTai2_Nhom7_LTWIN
{
    partial class FViewCV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FViewCV));
            this.pnlFunc = new Guna.UI.WinForms.GunaGradientPanel();
            this.fpnlCV = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFunc
            // 
            this.pnlFunc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFunc.BackgroundImage")));
            this.pnlFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFunc.Controls.Add(this.fpnlCV);
            this.pnlFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFunc.GradientColor1 = System.Drawing.Color.White;
            this.pnlFunc.GradientColor2 = System.Drawing.Color.White;
            this.pnlFunc.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(250)))), ((int)(((byte)(178)))));
            this.pnlFunc.GradientColor4 = System.Drawing.Color.White;
            this.pnlFunc.Location = new System.Drawing.Point(0, 0);
            this.pnlFunc.Name = "pnlFunc";
            this.pnlFunc.Size = new System.Drawing.Size(800, 712);
            this.pnlFunc.TabIndex = 6;
            this.pnlFunc.Text = "gunaGradientPanel2";
            // 
            // fpnlCV
            // 
            this.fpnlCV.BackColor = System.Drawing.Color.Transparent;
            this.fpnlCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlCV.Location = new System.Drawing.Point(0, 0);
            this.fpnlCV.Name = "fpnlCV";
            this.fpnlCV.Size = new System.Drawing.Size(800, 712);
            this.fpnlCV.TabIndex = 0;
            // 
            // FViewCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 712);
            this.Controls.Add(this.pnlFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FViewCV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FViewCV";
            this.Load += new System.EventHandler(this.FViewCV_Load);
            this.pnlFunc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaGradientPanel pnlFunc;
        private System.Windows.Forms.FlowLayoutPanel fpnlCV;
    }
}