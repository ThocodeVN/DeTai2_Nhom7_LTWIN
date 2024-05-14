namespace DeTai2_Nhom7_LTWIN
{
    partial class FManagePost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FManagePost));
            this.pnlFunc = new Guna.UI.WinForms.GunaGradientPanel();
            this.fpnlPost = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFunc
            // 
            this.pnlFunc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFunc.BackgroundImage")));
            this.pnlFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFunc.Controls.Add(this.fpnlPost);
            this.pnlFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFunc.GradientColor1 = System.Drawing.Color.White;
            this.pnlFunc.GradientColor2 = System.Drawing.Color.White;
            this.pnlFunc.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(250)))), ((int)(((byte)(178)))));
            this.pnlFunc.GradientColor4 = System.Drawing.Color.White;
            this.pnlFunc.Location = new System.Drawing.Point(0, 0);
            this.pnlFunc.Name = "pnlFunc";
            this.pnlFunc.Size = new System.Drawing.Size(692, 660);
            this.pnlFunc.TabIndex = 5;
            this.pnlFunc.Text = "gunaGradientPanel2";
            // 
            // fpnlPost
            // 
            this.fpnlPost.AutoScroll = true;
            this.fpnlPost.BackColor = System.Drawing.Color.Transparent;
            this.fpnlPost.Location = new System.Drawing.Point(41, 3);
            this.fpnlPost.Name = "fpnlPost";
            this.fpnlPost.Size = new System.Drawing.Size(613, 654);
            this.fpnlPost.TabIndex = 0;
            // 
            // FManagePost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 660);
            this.Controls.Add(this.pnlFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FManagePost";
            this.Text = "FManagePost";
            this.Load += new System.EventHandler(this.FManagePost_Load);
            this.pnlFunc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel pnlFunc;
        private System.Windows.Forms.FlowLayoutPanel fpnlPost;
    }
}