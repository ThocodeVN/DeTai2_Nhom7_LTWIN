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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.ptrPost = new System.Windows.Forms.PictureBox();
            this.lbDateCreate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbAvt)).BeginInit();
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 559);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 45);
            this.panel1.TabIndex = 2;
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
            this.ptrPost.Size = new System.Drawing.Size(653, 375);
            this.ptrPost.TabIndex = 3;
            this.ptrPost.TabStop = false;
            // 
            // lbDateCreate
            // 
            this.lbDateCreate.AutoSize = true;
            this.lbDateCreate.Location = new System.Drawing.Point(111, 50);
            this.lbDateCreate.Name = "lbDateCreate";
            this.lbDateCreate.Size = new System.Drawing.Size(44, 16);
            this.lbDateCreate.TabIndex = 4;
            this.lbDateCreate.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 86);
            this.panel2.TabIndex = 5;
            // 
            // UCPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbDateCreate);
            this.Controls.Add(this.ptrPost);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.ptrbAvt);
            this.Name = "UCPost";
            this.Size = new System.Drawing.Size(659, 604);
            ((System.ComponentModel.ISupportInitialize)(this.ptrbAvt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrPost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox ptrbAvt;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbDateCreate;
        private System.Windows.Forms.PictureBox ptrPost;
    }
}
