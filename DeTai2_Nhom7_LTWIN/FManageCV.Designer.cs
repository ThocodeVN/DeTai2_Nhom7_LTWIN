﻿namespace DeTai2_Nhom7_LTWIN.DTO
{
    partial class FManageCV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FManageCV));
            this.pnlFunc = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnCreateCV = new System.Windows.Forms.Button();
            this.fpnlCV = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFunc
            // 
            this.pnlFunc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFunc.BackgroundImage")));
            this.pnlFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFunc.Controls.Add(this.btnCreateCV);
            this.pnlFunc.Controls.Add(this.fpnlCV);
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
            // btnCreateCV
            // 
            this.btnCreateCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(195)))), ((int)(((byte)(41)))));
            this.btnCreateCV.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCV.ForeColor = System.Drawing.Color.White;
            this.btnCreateCV.Location = new System.Drawing.Point(529, 3);
            this.btnCreateCV.Name = "btnCreateCV";
            this.btnCreateCV.Size = new System.Drawing.Size(160, 41);
            this.btnCreateCV.TabIndex = 35;
            this.btnCreateCV.Text = "Tạo CV mới!";
            this.btnCreateCV.UseVisualStyleBackColor = false;
            this.btnCreateCV.Click += new System.EventHandler(this.btnCreateCV_Click);
            // 
            // fpnlCV
            // 
            this.fpnlCV.AutoScroll = true;
            this.fpnlCV.BackColor = System.Drawing.Color.Transparent;
            this.fpnlCV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fpnlCV.Location = new System.Drawing.Point(0, 50);
            this.fpnlCV.Name = "fpnlCV";
            this.fpnlCV.Size = new System.Drawing.Size(692, 610);
            this.fpnlCV.TabIndex = 0;
            // 
            // FManageCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 660);
            this.Controls.Add(this.pnlFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FManageCV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FManageCV";
            this.Load += new System.EventHandler(this.FManageCV_Load);
            this.pnlFunc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel pnlFunc;
        private System.Windows.Forms.FlowLayoutPanel fpnlCV;
        private System.Windows.Forms.Button btnCreateCV;
    }
}