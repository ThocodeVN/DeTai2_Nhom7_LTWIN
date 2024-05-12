using DeTai2_Nhom7_LTWIN.DAO;
using DeTai2_Nhom7_LTWIN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DeTai2_Nhom7_LTWIN
{
    public partial class UCCompanyInfor : UserControl
    {
        EmployerDTO emp;
        EmployerDAO empDAO = new EmployerDAO();
        public UCCompanyInfor(EmployerDTO emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        private void UCCompanyInfor_Load(object sender, EventArgs e)
        {
            txtName.Text = emp.Name;
            txtCompanyName.Text = emp.CompanyName;
            txtEmail.Text = emp.Email;
            txtPhone.Text = emp.Phone;
            txtIndustry.Text = emp.Industry;
            txtLoginName.Text = emp.LoginName;
            txtPassword.Text = emp.Password;
            txtAddress.Text = emp.Address;

            if (emp.Avatar != null)
            {
                MemoryStream stream = new MemoryStream(emp.Avatar.ToArray());
                System.Drawing.Image img = System.Drawing.Image.FromStream(stream);
                ptrbAvatar.Image = img;
            }
        }

        private void btnUpImage_Click(object sender, EventArgs e)
        {
            ofdOpenImage.ShowDialog();
            string file = "";
            file = ofdOpenImage.FileName;
            if (file == "" || file == "openFileDialog1")
            {
                return;
            }
            System.Drawing.Image avatar = System.Drawing.Image.FromFile(file);
            ptrbAvatar.Image = avatar;
            MemoryStream stream = new MemoryStream();
            ptrbAvatar.Image.Save(stream, ImageFormat.Jpeg);
            emp.Avatar = stream.ToArray();
            CheckImage();
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            ptrbAvatar.Image = null;
            emp.Avatar = null;
            CheckImage();
        }

        private void CheckImage()
        {
            if (ptrbAvatar.Image == null)
            {
                btnUpImage.Text = "Thêm ảnh";
                btnDeleteImage.Hide();
            }
            else
            {
                btnUpImage.Text = "Sửa ảnh";
                btnDeleteImage.Show();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            emp.Name = txtName.Text;
            emp.CompanyName = txtCompanyName.Text;
            emp.Email = txtEmail.Text;
            emp.Phone = txtPhone.Text;
            emp.Industry = txtIndustry.Text;
            emp.LoginName = txtLoginName.Text;
            emp.Password = txtPassword.Text;
            emp.Address = txtAddress.Text;
            empDAO.Update(emp);
        }
    }
}
