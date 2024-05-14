namespace DeTai2_Nhom7_LTWIN
{
    partial class UCPost
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
            this.components = new System.ComponentModel.Container();
            this.ptrbAvt = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewCV = new System.Windows.Forms.Button();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.ptrPost = new System.Windows.Forms.PictureBox();
            this.lbDateCreate = new System.Windows.Forms.Label();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbAvt)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrPost)).BeginInit();
            this.SuspendLayout();
            // 
            // ptrbAvt
            // 
            this.ptrbAvt.BaseColor = System.Drawing.Color.White;
            this.ptrbAvt.Location = new System.Drawing.Point(13, 12);
            this.ptrbAvt.Name = "ptrbAvt";
            this.ptrbAvt.Size = new System.Drawing.Size(78, 75);
            this.ptrbAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrbAvt.TabIndex = 0;
            this.ptrbAvt.TabStop = false;
            this.ptrbAvt.UseTransfarantBackground = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(111, 12);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(50, 18);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewCV);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 45);
            this.panel1.TabIndex = 2;
            // 
            // btnViewCV
            // 
            this.btnViewCV.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCV.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnViewCV.Location = new System.Drawing.Point(210, 2);
            this.btnViewCV.Name = "btnViewCV";
            this.btnViewCV.Size = new System.Drawing.Size(170, 42);
            this.btnViewCV.TabIndex = 1;
            this.btnViewCV.Text = "Xem CV";
            this.btnViewCV.UseVisualStyleBackColor = true;
            this.btnViewCV.Click += new System.EventHandler(this.btnViewCV_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 7;
            this.gunaElipse1.TargetControl = this;
            // 
            // ptrPost
            // 
            this.ptrPost.Location = new System.Drawing.Point(3, 185);
            this.ptrPost.Name = "ptrPost";
            this.ptrPost.Size = new System.Drawing.Size(607, 273);
            this.ptrPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrPost.TabIndex = 3;
            this.ptrPost.TabStop = false;
            // 
            // lbDateCreate
            // 
            this.lbDateCreate.AutoSize = true;
            this.lbDateCreate.Location = new System.Drawing.Point(111, 43);
            this.lbDateCreate.Name = "lbDateCreate";
            this.lbDateCreate.Size = new System.Drawing.Size(44, 16);
            this.lbDateCreate.TabIndex = 4;
            this.lbDateCreate.Text = "label1";
            // 
            // rtxtContent
            // 
            this.rtxtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtContent.Location = new System.Drawing.Point(3, 93);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(607, 86);
            this.rtxtContent.TabIndex = 6;
            this.rtxtContent.Text = "";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(98)))), ((int)(((byte)(63)))));
            this.panel9.Location = new System.Drawing.Point(3, 25);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(607, 17);
            this.panel9.TabIndex = 7;
            // 
            // UCPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rtxtContent);
            this.Controls.Add(this.lbDateCreate);
            this.Controls.Add(this.ptrPost);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.ptrbAvt);
            this.Name = "UCPost";
            this.Size = new System.Drawing.Size(613, 506);
            this.Load += new System.EventHandler(this.UCPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrbAvt)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrPost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox ptrbAvt;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label lbDateCreate;
        private System.Windows.Forms.PictureBox ptrPost;
        private System.Windows.Forms.Button btnViewCV;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.Panel panel9;
    }
}
