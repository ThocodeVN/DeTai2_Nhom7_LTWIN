namespace DeTai2_Nhom7_LTWIN
{
    partial class UCCompanyInfor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCompanyInfor));
            this.pnlFunc = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnDeleteImage = new Guna.UI.WinForms.GunaButton();
            this.btnUpImage = new Guna.UI.WinForms.GunaButton();
            this.txtCompanyName = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtLoginName = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtIndustry = new Guna.UI.WinForms.GunaTextBox();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.txtAddress = new Guna.UI.WinForms.GunaTextBox();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptrbAvatar = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.ofdOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.pnlFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFunc
            // 
            this.pnlFunc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFunc.BackgroundImage")));
            this.pnlFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFunc.Controls.Add(this.btnDeleteImage);
            this.pnlFunc.Controls.Add(this.btnUpImage);
            this.pnlFunc.Controls.Add(this.txtCompanyName);
            this.pnlFunc.Controls.Add(this.label6);
            this.pnlFunc.Controls.Add(this.txtPassword);
            this.pnlFunc.Controls.Add(this.txtLoginName);
            this.pnlFunc.Controls.Add(this.label8);
            this.pnlFunc.Controls.Add(this.label7);
            this.pnlFunc.Controls.Add(this.btnUpdate);
            this.pnlFunc.Controls.Add(this.txtIndustry);
            this.pnlFunc.Controls.Add(this.txtEmail);
            this.pnlFunc.Controls.Add(this.txtAddress);
            this.pnlFunc.Controls.Add(this.txtPhone);
            this.pnlFunc.Controls.Add(this.txtName);
            this.pnlFunc.Controls.Add(this.label5);
            this.pnlFunc.Controls.Add(this.label4);
            this.pnlFunc.Controls.Add(this.label3);
            this.pnlFunc.Controls.Add(this.label2);
            this.pnlFunc.Controls.Add(this.label1);
            this.pnlFunc.Controls.Add(this.ptrbAvatar);
            this.pnlFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFunc.GradientColor1 = System.Drawing.Color.White;
            this.pnlFunc.GradientColor2 = System.Drawing.Color.White;
            this.pnlFunc.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(250)))), ((int)(((byte)(178)))));
            this.pnlFunc.GradientColor4 = System.Drawing.Color.White;
            this.pnlFunc.Location = new System.Drawing.Point(0, 0);
            this.pnlFunc.Name = "pnlFunc";
            this.pnlFunc.Size = new System.Drawing.Size(812, 741);
            this.pnlFunc.TabIndex = 6;
            this.pnlFunc.Text = "gunaGradientPanel3";
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.AnimationHoverSpeed = 0.07F;
            this.btnDeleteImage.AnimationSpeed = 0.03F;
            this.btnDeleteImage.BaseColor = System.Drawing.Color.Orange;
            this.btnDeleteImage.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteImage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteImage.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteImage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteImage.ForeColor = System.Drawing.Color.White;
            this.btnDeleteImage.Image = null;
            this.btnDeleteImage.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteImage.Location = new System.Drawing.Point(151, 258);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDeleteImage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeleteImage.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteImage.OnHoverImage = null;
            this.btnDeleteImage.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteImage.Size = new System.Drawing.Size(108, 42);
            this.btnDeleteImage.TabIndex = 52;
            this.btnDeleteImage.Text = "Xóa ảnh";
            this.btnDeleteImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // btnUpImage
            // 
            this.btnUpImage.AnimationHoverSpeed = 0.07F;
            this.btnUpImage.AnimationSpeed = 0.03F;
            this.btnUpImage.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpImage.BaseColor = System.Drawing.Color.LimeGreen;
            this.btnUpImage.BorderColor = System.Drawing.Color.Black;
            this.btnUpImage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpImage.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpImage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpImage.ForeColor = System.Drawing.Color.White;
            this.btnUpImage.Image = null;
            this.btnUpImage.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpImage.Location = new System.Drawing.Point(35, 258);
            this.btnUpImage.Name = "btnUpImage";
            this.btnUpImage.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpImage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpImage.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpImage.OnHoverImage = null;
            this.btnUpImage.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpImage.Size = new System.Drawing.Size(110, 42);
            this.btnUpImage.TabIndex = 51;
            this.btnUpImage.Text = "Thêm ảnh";
            this.btnUpImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpImage.Click += new System.EventHandler(this.btnUpImage_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BaseColor = System.Drawing.Color.White;
            this.txtCompanyName.BorderColor = System.Drawing.Color.Silver;
            this.txtCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompanyName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCompanyName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCompanyName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCompanyName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCompanyName.Location = new System.Drawing.Point(441, 40);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.PasswordChar = '\0';
            this.txtCompanyName.SelectedText = "";
            this.txtCompanyName.Size = new System.Drawing.Size(288, 30);
            this.txtCompanyName.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(294, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 49;
            this.label6.Text = "Tên công ti";
            // 
            // txtPassword
            // 
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(441, 459);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(262, 30);
            this.txtPassword.TabIndex = 42;
            // 
            // txtLoginName
            // 
            this.txtLoginName.BaseColor = System.Drawing.Color.White;
            this.txtLoginName.BorderColor = System.Drawing.Color.Silver;
            this.txtLoginName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLoginName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLoginName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLoginName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoginName.Location = new System.Drawing.Point(441, 400);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.PasswordChar = '\0';
            this.txtLoginName.SelectedText = "";
            this.txtLoginName.Size = new System.Drawing.Size(262, 30);
            this.txtLoginName.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(299, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 40;
            this.label8.Text = "Mật khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "Tên đăng nhập";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(195)))), ((int)(((byte)(41)))));
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(377, 522);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(178, 49);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtIndustry
            // 
            this.txtIndustry.BaseColor = System.Drawing.Color.White;
            this.txtIndustry.BorderColor = System.Drawing.Color.Silver;
            this.txtIndustry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIndustry.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIndustry.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIndustry.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIndustry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIndustry.Location = new System.Drawing.Point(441, 338);
            this.txtIndustry.Name = "txtIndustry";
            this.txtIndustry.PasswordChar = '\0';
            this.txtIndustry.SelectedText = "";
            this.txtIndustry.Size = new System.Drawing.Size(288, 30);
            this.txtIndustry.TabIndex = 22;
            // 
            // txtEmail
            // 
            this.txtEmail.BaseColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(441, 277);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(288, 30);
            this.txtEmail.TabIndex = 21;
            // 
            // txtAddress
            // 
            this.txtAddress.BaseColor = System.Drawing.Color.White;
            this.txtAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.Location = new System.Drawing.Point(441, 219);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(288, 30);
            this.txtAddress.TabIndex = 20;
            // 
            // txtPhone
            // 
            this.txtPhone.BaseColor = System.Drawing.Color.White;
            this.txtPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.Location = new System.Drawing.Point(441, 161);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(288, 30);
            this.txtPhone.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.BaseColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.Location = new System.Drawing.Point(441, 101);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(288, 30);
            this.txtName.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "Lĩnh vực\r\n kinh doanh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "Số điện thoại \r\ncông ti\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Họ và tên \r\nngười đứng đầu\r\n";
            // 
            // ptrbAvatar
            // 
            this.ptrbAvatar.BackColor = System.Drawing.Color.Transparent;
            this.ptrbAvatar.BaseColor = System.Drawing.Color.White;
            this.ptrbAvatar.Location = new System.Drawing.Point(18, 17);
            this.ptrbAvatar.Name = "ptrbAvatar";
            this.ptrbAvatar.Size = new System.Drawing.Size(250, 235);
            this.ptrbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrbAvatar.TabIndex = 12;
            this.ptrbAvatar.TabStop = false;
            this.ptrbAvatar.UseTransfarantBackground = false;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this.btnUpImage;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 10;
            this.gunaElipse2.TargetControl = this.btnDeleteImage;
            // 
            // ofdOpenImage
            // 
            this.ofdOpenImage.FileName = "openFileDialog1";
            // 
            // UCCompanyInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlFunc);
            this.Name = "UCCompanyInfor";
            this.Size = new System.Drawing.Size(812, 741);
            this.Load += new System.EventHandler(this.UCCompanyInfor_Load);
            this.pnlFunc.ResumeLayout(false);
            this.pnlFunc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel pnlFunc;
        private System.Windows.Forms.Button btnUpdate;
        private Guna.UI.WinForms.GunaTextBox txtIndustry;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Guna.UI.WinForms.GunaTextBox txtAddress;
        private Guna.UI.WinForms.GunaTextBox txtPhone;
        private Guna.UI.WinForms.GunaTextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCirclePictureBox ptrbAvatar;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtLoginName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox txtCompanyName;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaButton btnDeleteImage;
        private Guna.UI.WinForms.GunaButton btnUpImage;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
    }
}
