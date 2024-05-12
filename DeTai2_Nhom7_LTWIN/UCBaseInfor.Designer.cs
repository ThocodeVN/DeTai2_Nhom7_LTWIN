namespace DeTai2_Nhom7_LTWIN
{
    partial class UCBaseInfor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBaseInfor));
            this.cbxSex = new Guna.UI.WinForms.GunaComboBox();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnDeleteImage = new Guna.UI.WinForms.GunaButton();
            this.btnUpImage = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.txtAddress = new Guna.UI.WinForms.GunaTextBox();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptrbAvatar = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.ofdOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.gunaGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxSex
            // 
            this.cbxSex.AllowDrop = true;
            this.cbxSex.BackColor = System.Drawing.Color.Transparent;
            this.cbxSex.BaseColor = System.Drawing.Color.White;
            this.cbxSex.BorderColor = System.Drawing.Color.Silver;
            this.cbxSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSex.FocusedColor = System.Drawing.Color.Empty;
            this.cbxSex.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxSex.ForeColor = System.Drawing.Color.Black;
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbxSex.Location = new System.Drawing.Point(257, 102);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxSex.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxSex.Size = new System.Drawing.Size(121, 31);
            this.cbxSex.TabIndex = 10;
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.btnDeleteImage);
            this.gunaGradientPanel1.Controls.Add(this.btnUpImage);
            this.gunaGradientPanel1.Controls.Add(this.btnUpdate);
            this.gunaGradientPanel1.Controls.Add(this.txtEmail);
            this.gunaGradientPanel1.Controls.Add(this.txtAddress);
            this.gunaGradientPanel1.Controls.Add(this.txtPhone);
            this.gunaGradientPanel1.Controls.Add(this.cbxSex);
            this.gunaGradientPanel1.Controls.Add(this.txtName);
            this.gunaGradientPanel1.Controls.Add(this.label7);
            this.gunaGradientPanel1.Controls.Add(this.label5);
            this.gunaGradientPanel1.Controls.Add(this.label3);
            this.gunaGradientPanel1.Controls.Add(this.label2);
            this.gunaGradientPanel1.Controls.Add(this.label1);
            this.gunaGradientPanel1.Controls.Add(this.ptrbAvatar);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.White;
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.White;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(250)))), ((int)(((byte)(178)))));
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.White;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(701, 707);
            this.gunaGradientPanel1.TabIndex = 5;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
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
            this.btnDeleteImage.Location = new System.Drawing.Point(125, 211);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDeleteImage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeleteImage.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteImage.OnHoverImage = null;
            this.btnDeleteImage.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteImage.Size = new System.Drawing.Size(98, 42);
            this.btnDeleteImage.TabIndex = 54;
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
            this.btnUpImage.Location = new System.Drawing.Point(12, 211);
            this.btnUpImage.Name = "btnUpImage";
            this.btnUpImage.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpImage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpImage.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpImage.OnHoverImage = null;
            this.btnUpImage.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpImage.Size = new System.Drawing.Size(98, 42);
            this.btnUpImage.TabIndex = 53;
            this.btnUpImage.Text = "Thêm ảnh";
            this.btnUpImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpImage.Click += new System.EventHandler(this.btnUpImage_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(195)))), ((int)(((byte)(41)))));
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(280, 464);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 73);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.txtEmail.Location = new System.Drawing.Point(257, 335);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(380, 32);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Text = "gunaTextBox4";
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
            this.txtAddress.Location = new System.Drawing.Point(257, 256);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(380, 32);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.Text = "gunaTextBox3";
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
            this.txtPhone.Location = new System.Drawing.Point(257, 177);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(380, 32);
            this.txtPhone.TabIndex = 11;
            this.txtPhone.Text = "gunaTextBox2";
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
            this.txtName.Location = new System.Drawing.Point(257, 31);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(380, 32);
            this.txtName.TabIndex = 9;
            this.txtName.Text = "gunaTextBox1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(254, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(254, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(254, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(254, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ và tên";
            // 
            // ptrbAvatar
            // 
            this.ptrbAvatar.BackColor = System.Drawing.Color.Transparent;
            this.ptrbAvatar.BaseColor = System.Drawing.Color.Transparent;
            this.ptrbAvatar.InitialImage = null;
            this.ptrbAvatar.Location = new System.Drawing.Point(12, 12);
            this.ptrbAvatar.Name = "ptrbAvatar";
            this.ptrbAvatar.Size = new System.Drawing.Size(211, 192);
            this.ptrbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrbAvatar.TabIndex = 1;
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
            // UCBaseInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaGradientPanel1);
            this.Name = "UCBaseInfor";
            this.Size = new System.Drawing.Size(701, 707);
            this.Load += new System.EventHandler(this.UCBaseInfor_Load);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox cbxSex;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private System.Windows.Forms.Button btnUpdate;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Guna.UI.WinForms.GunaTextBox txtAddress;
        private Guna.UI.WinForms.GunaTextBox txtPhone;
        private Guna.UI.WinForms.GunaTextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCirclePictureBox ptrbAvatar;
        private Guna.UI.WinForms.GunaButton btnDeleteImage;
        private Guna.UI.WinForms.GunaButton btnUpImage;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
    }
}
