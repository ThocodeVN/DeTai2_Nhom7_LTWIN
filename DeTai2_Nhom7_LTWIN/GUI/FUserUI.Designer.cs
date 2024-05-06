namespace DeTai2_Nhom7_LTWIN
{
    partial class FUserUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUserUI));
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnFind = new System.Windows.Forms.Button();
            this.cbxExp = new Guna.UI.WinForms.GunaComboBox();
            this.cbxTypeJob = new Guna.UI.WinForms.GunaComboBox();
            this.cbxLocation = new Guna.UI.WinForms.GunaComboBox();
            this.cbxSalary = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new Guna.UI.WinForms.GunaTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInfor = new System.Windows.Forms.Button();
            this.ucJob1 = new DeTai2_Nhom7_LTWIN.UCJob();
            this.gunaGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.btnFind);
            this.gunaGradientPanel1.Controls.Add(this.cbxExp);
            this.gunaGradientPanel1.Controls.Add(this.cbxTypeJob);
            this.gunaGradientPanel1.Controls.Add(this.cbxLocation);
            this.gunaGradientPanel1.Controls.Add(this.cbxSalary);
            this.gunaGradientPanel1.Controls.Add(this.label2);
            this.gunaGradientPanel1.Controls.Add(this.label1);
            this.gunaGradientPanel1.Controls.Add(this.txtFind);
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.White;
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.White;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(250)))), ((int)(((byte)(178)))));
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.White;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 66);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(1342, 220);
            this.gunaGradientPanel1.TabIndex = 2;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(195)))), ((int)(((byte)(41)))));
            this.btnFind.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(1180, 114);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(132, 73);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // cbxExp
            // 
            this.cbxExp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxExp.BackColor = System.Drawing.Color.Transparent;
            this.cbxExp.BaseColor = System.Drawing.Color.White;
            this.cbxExp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(193)))), ((int)(((byte)(85)))));
            this.cbxExp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExp.FocusedColor = System.Drawing.Color.Empty;
            this.cbxExp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxExp.ForeColor = System.Drawing.Color.Black;
            this.cbxExp.FormattingEnabled = true;
            this.cbxExp.Items.AddRange(new object[] {
            "Tất cả kinh nghiệm",
            "Chưa có kinh nghiệm",
            "Dưới 1 năm",
            "1 năm",
            "2 năm",
            "3 năm",
            "4 năm",
            "5 năm",
            "Trên 5 năm"});
            this.cbxExp.Location = new System.Drawing.Point(858, 103);
            this.cbxExp.Name = "cbxExp";
            this.cbxExp.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxExp.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxExp.Size = new System.Drawing.Size(270, 31);
            this.cbxExp.TabIndex = 6;
            // 
            // cbxTypeJob
            // 
            this.cbxTypeJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxTypeJob.BackColor = System.Drawing.Color.Transparent;
            this.cbxTypeJob.BaseColor = System.Drawing.Color.White;
            this.cbxTypeJob.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(193)))), ((int)(((byte)(85)))));
            this.cbxTypeJob.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTypeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeJob.FocusedColor = System.Drawing.Color.Empty;
            this.cbxTypeJob.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxTypeJob.ForeColor = System.Drawing.Color.Black;
            this.cbxTypeJob.FormattingEnabled = true;
            this.cbxTypeJob.Items.AddRange(new object[] {
            "Lập trình viên",
            "Kỹ sư phần mềm",
            "Nhân viên kinh doanh",
            "Quản lý dự án",
            "Chuyên viên tài chính",
            "Kế toán viên",
            "Nhân viên bán hàng",
            "Marketing",
            "Nhân viên hỗ trợ khách hàng",
            "Chuyên viên tuyển dụng",
            "Nhân viên quản lý sản phẩm",
            "Giáo viên/Giảng viên",
            "Y tá/Bác sĩ",
            "Chuyên viên tiếp thị số",
            "Nhà thiết kế đồ họa",
            "Kiến trúc sư",
            "Bác sĩ răng",
            "Kỹ sư điện",
            "Kỹ sư cơ khí",
            "Kỹ sư xây dựng",
            "Chuyên viên tư vấn",
            "Luật sư",
            "Chuyên gia tài chính cá nhân",
            "Quản lý nhân sự",
            "Kỹ thuật viên điện tử",
            "Kỹ thuật viên mạng",
            "Dược sĩ",
            "Chuyên gia bảo mật thông tin",
            "Kỹ sư robot",
            "Nhà khoa học dữ liệu",
            "Chuyên viên phân tích dữ liệu",
            "Nhà sản xuất video",
            "Chuyên viên SEO",
            "Chuyên viên UX/UI",
            "Chuyên gia truyền thông xã hội",
            "Chuyên viên quảng cáo trực tuyến",
            "Chuyên viên tài nguyên loài",
            "Chuyên viên điều tra tội phạm",
            "Chuyên viên truyền thông",
            "Kiểm toán viên",
            "Thợ làm tóc/Thợ làm nail",
            "Dịch vụ vận chuyển và giao hàng",
            "Chuyên viên du lịch",
            "Nhân viên phục vụ nhà hàng",
            "Nghệ sĩ biểu diễn",
            "Nhà hàng cao cấp",
            "Thợ sửa chữa ô tô",
            "Thợ làm bánh",
            "Thợ may",
            "Chuyên viên bảo trì hệ thống",
            "Chuyên viên bán lẻ",
            "Chuyên viên quản lý tài sản",
            "Chuyên viên về sức khỏe và thể dục",
            "Chuyên viên quản trị mạng xã hội",
            "Chuyên viên truyền thông số",
            "Chuyên viên hỗ trợ kỹ thuật",
            "Chuyên viên về phát triển cá nhân",
            "Chuyên viên hỗ trợ hợp đồng",
            "Chuyên viên tài chính cá nhân",
            "Chuyên viên về nghiên cứu và phát triển",
            "Chuyên viên bảo dưỡng",
            "Chuyên viên về quan hệ công chúng",
            "Chuyên viên phát triển kỹ năng",
            "Chuyên viên hỗ trợ bán hàng",
            "Chuyên viên về quan hệ cộng đồng",
            "Chuyên viên hỗ trợ khách hàng trực tuyến",
            "Chuyên viên về phát triển doanh nghiệp",
            "Chuyên viên tư vấn nghề nghiệp",
            "Chuyên viên bảo hiểm",
            "Chuyên viên về phát triển nguồn nhân lực",
            "Chuyên viên hỗ trợ kỹ thuật số",
            "Chuyên viên tài chính cá nhân",
            "Chuyên viên hỗ trợ quảng cáo",
            "Chuyên viên về phát triển thương hiệu",
            "Chuyên viên hỗ trợ hội nhập xã hội",
            "Chuyên viên phát triển sản phẩm",
            "Chuyên viên hỗ trợ đối tác",
            "Chuyên viên về phát triển nhân lực",
            "Chuyên viên quan hệ doanh nghiệp",
            "Chuyên viên về quản lý dự án",
            "Chuyên viên hỗ trợ văn phòng",
            "Chuyên viên tài chính cá nhân",
            "Chuyên viên hỗ trợ kỹ thuật số",
            "Chuyên viên về phát triển doanh nghiệp",
            "Chuyên viên tư vấn nghề nghiệp",
            "Chuyên viên bảo hiểm",
            "Chuyên viên về phát triển nguồn nhân lực",
            "Chuyên viên hỗ trợ kỹ thuật số",
            "Chuyên viên tài chính cá nhân",
            "Chuyên viên hỗ trợ quảng cáo",
            "Chuyên viên về phát triển thương hiệu",
            "Chuyên viên hỗ trợ hội nhập xã hội",
            "Chuyên viên phát triển sản phẩm",
            "Chuyên viên hỗ trợ đối tác",
            "Chuyên viên về phát triển nhân lực",
            "Chuyên viên quan hệ doanh nghiệp",
            "Chuyên viên về quản lý dự án",
            "Chuyên viên hỗ trợ văn phòng",
            "Chuyên viên hỗ trợ kỹ thuật số",
            "Chuyên viên về phát triển doanh nghiệp"});
            this.cbxTypeJob.Location = new System.Drawing.Point(858, 166);
            this.cbxTypeJob.Name = "cbxTypeJob";
            this.cbxTypeJob.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxTypeJob.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxTypeJob.Size = new System.Drawing.Size(270, 31);
            this.cbxTypeJob.TabIndex = 5;
            // 
            // cbxLocation
            // 
            this.cbxLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxLocation.BackColor = System.Drawing.Color.Transparent;
            this.cbxLocation.BaseColor = System.Drawing.Color.White;
            this.cbxLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(193)))), ((int)(((byte)(85)))));
            this.cbxLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocation.FocusedColor = System.Drawing.Color.Empty;
            this.cbxLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxLocation.ForeColor = System.Drawing.Color.Black;
            this.cbxLocation.FormattingEnabled = true;
            this.cbxLocation.Items.AddRange(new object[] {
            "Tất cả tỉnh/ thành phố",
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cao Bằng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Tĩnh",
            "Hải Dương",
            "Hậu Giang",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái",
            "Phú Yên",
            "Cần Thơ",
            "Đà Nẵng",
            "Hải Phòng",
            "Hà Nội",
            "TP. Hồ Chí Minh"});
            this.cbxLocation.Location = new System.Drawing.Point(518, 103);
            this.cbxLocation.Name = "cbxLocation";
            this.cbxLocation.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxLocation.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxLocation.Size = new System.Drawing.Size(270, 31);
            this.cbxLocation.TabIndex = 4;
            // 
            // cbxSalary
            // 
            this.cbxSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxSalary.BackColor = System.Drawing.Color.Transparent;
            this.cbxSalary.BaseColor = System.Drawing.Color.White;
            this.cbxSalary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(193)))), ((int)(((byte)(85)))));
            this.cbxSalary.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxSalary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSalary.FocusedColor = System.Drawing.Color.Empty;
            this.cbxSalary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxSalary.ForeColor = System.Drawing.Color.Black;
            this.cbxSalary.FormattingEnabled = true;
            this.cbxSalary.Items.AddRange(new object[] {
            "Tất cả mức lương",
            "Dưới 10 triệu",
            "10 - 15 triệu",
            "15 - 20 triệu",
            "20 - 25 triệu",
            "25 - 30 triệu",
            "30 - 50 triệu ",
            "Trên 50 triệu",
            "Thỏa thuận"});
            this.cbxSalary.Location = new System.Drawing.Point(518, 166);
            this.cbxSalary.Name = "cbxSalary";
            this.cbxSalary.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxSalary.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxSalary.Size = new System.Drawing.Size(270, 31);
            this.cbxSalary.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(416, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(529, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiếp cận tin tuyển dụng việc làm mỗi ngày từ hàng nghìn doanh nghiệp uy tín tại V" +
    "iệt Nam";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(841, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm việc làm nhanh 24h, việc làm mới nhất trên toàn quốc.";
            // 
            // txtFind
            // 
            this.txtFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFind.BaseColor = System.Drawing.Color.White;
            this.txtFind.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(193)))), ((int)(((byte)(85)))));
            this.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFind.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFind.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFind.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtFind.Location = new System.Drawing.Point(46, 128);
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.SelectedText = "";
            this.txtFind.Size = new System.Drawing.Size(411, 39);
            this.txtFind.TabIndex = 0;
            this.txtFind.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 60);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1155, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1155, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tài khoản";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(452, 952);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 52);
            this.panel2.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.Controls.Add(this.ucJob1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-28, 292);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1378, 660);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnInfor
            // 
            this.btnInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfor.Location = new System.Drawing.Point(325, 3);
            this.btnInfor.Name = "btnInfor";
            this.btnInfor.Size = new System.Drawing.Size(119, 57);
            this.btnInfor.TabIndex = 4;
            this.btnInfor.Text = "Hồ sơ - CV";
            this.btnInfor.UseVisualStyleBackColor = true;
            this.btnInfor.MouseEnter += new System.EventHandler(this.btnInfor_MouseEnter);
            this.btnInfor.MouseLeave += new System.EventHandler(this.btnInfor_MouseLeave);
            // 
            // ucJob1
            // 
            this.ucJob1.BackColor = System.Drawing.Color.White;
            this.ucJob1.Location = new System.Drawing.Point(50, 20);
            this.ucJob1.Margin = new System.Windows.Forms.Padding(10, 20, 10, 3);
            this.ucJob1.Name = "ucJob1";
            this.ucJob1.Size = new System.Drawing.Size(410, 119);
            this.ucJob1.TabIndex = 0;
            // 
            // FUserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1474, 817);
            this.Controls.Add(this.btnInfor);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Name = "FUserUI";
            this.Text = "FUserUI";
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtFind;
        private Guna.UI.WinForms.GunaComboBox cbxSalary;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox cbxExp;
        private Guna.UI.WinForms.GunaComboBox cbxLocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnFind;
        private Guna.UI.WinForms.GunaComboBox cbxTypeJob;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UCJob ucJob1;
        private System.Windows.Forms.Button btnInfor;
    }
}