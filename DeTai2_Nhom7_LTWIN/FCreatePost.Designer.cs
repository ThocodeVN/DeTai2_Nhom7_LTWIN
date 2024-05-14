namespace DeTai2_Nhom7_LTWIN
{
    partial class FCreatePost
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
            this.lbDateCreate = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.ptrbAvt = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCV = new System.Windows.Forms.Button();
            this.btnDelImagePost = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ptrbPost = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ofdOpenImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbAvt)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbPost)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDateCreate
            // 
            this.lbDateCreate.AutoSize = true;
            this.lbDateCreate.Location = new System.Drawing.Point(110, 114);
            this.lbDateCreate.Name = "lbDateCreate";
            this.lbDateCreate.Size = new System.Drawing.Size(44, 16);
            this.lbDateCreate.TabIndex = 7;
            this.lbDateCreate.Text = "label1";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(110, 76);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(50, 18);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "label1";
            // 
            // ptrbAvt
            // 
            this.ptrbAvt.BaseColor = System.Drawing.Color.White;
            this.ptrbAvt.Location = new System.Drawing.Point(12, 76);
            this.ptrbAvt.Name = "ptrbAvt";
            this.ptrbAvt.Size = new System.Drawing.Size(78, 75);
            this.ptrbAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrbAvt.TabIndex = 5;
            this.ptrbAvt.TabStop = false;
            this.ptrbAvt.UseTransfarantBackground = false;
            // 
            // rtxtContent
            // 
            this.rtxtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtContent.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtContent.ForeColor = System.Drawing.Color.DarkGray;
            this.rtxtContent.Location = new System.Drawing.Point(12, 173);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(659, 247);
            this.rtxtContent.TabIndex = 8;
            this.rtxtContent.Text = " ơi, bạn đang nghĩ gì thế?";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAddCV);
            this.panel1.Controls.Add(this.btnDelImagePost);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ptrbPost);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 57);
            this.panel1.TabIndex = 9;
            // 
            // btnAddCV
            // 
            this.btnAddCV.AutoEllipsis = true;
            this.btnAddCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(195)))), ((int)(((byte)(41)))));
            this.btnAddCV.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCV.ForeColor = System.Drawing.Color.White;
            this.btnAddCV.Location = new System.Drawing.Point(430, -1);
            this.btnAddCV.Name = "btnAddCV";
            this.btnAddCV.Size = new System.Drawing.Size(228, 57);
            this.btnAddCV.TabIndex = 17;
            this.btnAddCV.Text = "+ CV";
            this.btnAddCV.UseVisualStyleBackColor = false;
            this.btnAddCV.Click += new System.EventHandler(this.btnAddCV_Click);
            // 
            // btnDelImagePost
            // 
            this.btnDelImagePost.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelImagePost.Location = new System.Drawing.Point(405, -1);
            this.btnDelImagePost.Name = "btnDelImagePost";
            this.btnDelImagePost.Size = new System.Drawing.Size(27, 23);
            this.btnDelImagePost.TabIndex = 17;
            this.btnDelImagePost.Text = "X";
            this.btnDelImagePost.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(318, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "+ Ảnh";
            // 
            // ptrbPost
            // 
            this.ptrbPost.Location = new System.Drawing.Point(269, 3);
            this.ptrbPost.Name = "ptrbPost";
            this.ptrbPost.Size = new System.Drawing.Size(152, 50);
            this.ptrbPost.TabIndex = 1;
            this.ptrbPost.TabStop = false;
            this.ptrbPost.Click += new System.EventHandler(this.ptrbPost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm vào bài viết của bạn";
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(195)))), ((int)(((byte)(41)))));
            this.btnPost.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.ForeColor = System.Drawing.Color.White;
            this.btnPost.Location = new System.Drawing.Point(12, 515);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(659, 45);
            this.btnPost.TabIndex = 15;
            this.btnPost.Text = "Đăng";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 57);
            this.panel2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tạo bài viết";
            // 
            // ofdOpenImage
            // 
            this.ofdOpenImage.FileName = "openFileDialog1";
            // 
            // FCreatePost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtxtContent);
            this.Controls.Add(this.lbDateCreate);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.ptrbAvt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FCreatePost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCreatePost";
            this.Load += new System.EventHandler(this.FCreatePost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrbAvt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbPost)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDateCreate;
        private System.Windows.Forms.Label lbName;
        private Guna.UI.WinForms.GunaCirclePictureBox ptrbAvt;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.PictureBox ptrbPost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
        private System.Windows.Forms.Button btnDelImagePost;
        private System.Windows.Forms.Button btnAddCV;
    }
}