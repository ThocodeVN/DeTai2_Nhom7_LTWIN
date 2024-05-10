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

namespace DeTai2_Nhom7_LTWIN
{
    public partial class FCompanySignUp : Form
    {
        EmployerDAO employerDAO = new EmployerDAO();
        MemoryStream image;
        public FCompanySignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string address = txtProvince.Text + ", " + txtDistrict.Text + ", " + txtCommune.Text + ", " + txtStreet.Text + ", " + txtHome.Text;
            EmployerDTO emp = new EmployerDTO(txtName.Text, txtCompanyName.Text, txtPhone.Text, address, txtEmail.Text, txtIndustry.Text, txtLoginName.Text, txtPassword.Text);
            if(image != null)
                emp.Avatar = image.ToArray();
            else
                emp.Avatar = null;
            employerDAO.Add(emp);
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
            Image avatar = Image.FromFile(file);
            ptrbAvatar.Image = avatar;

            MemoryStream stream = new MemoryStream();
            ptrbAvatar.Image.Save(stream, ImageFormat.Jpeg);
            image = stream;
            CheckImage();
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            ptrbAvatar.Image = null;
            image = null;
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

    }
}
