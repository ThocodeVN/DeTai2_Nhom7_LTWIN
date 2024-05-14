namespace DeTai2_Nhom7_LTWIN
{
    partial class FViewPost
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
            this.fpnlPost = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // fpnlPost
            // 
            this.fpnlPost.Location = new System.Drawing.Point(0, 0);
            this.fpnlPost.Name = "fpnlPost";
            this.fpnlPost.Size = new System.Drawing.Size(1282, 830);
            this.fpnlPost.TabIndex = 0;
            this.fpnlPost.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.fpnlPost_ControlAdded);
            // 
            // FViewPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1282, 830);
            this.Controls.Add(this.fpnlPost);
            this.Name = "FViewPost";
            this.Text = "FViewPost";
            this.Load += new System.EventHandler(this.FViewPost_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnlPost;
    }
}