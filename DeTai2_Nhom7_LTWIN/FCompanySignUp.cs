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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        private void FCompanySignUp_Load(object sender, EventArgs e)
        {
            CheckImage();
        }

        #region CheckInfor
        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            if(txtCompanyName.Text == "")
            {
                txtCompanyName.BorderColor = Color.Red;
            }
            else
            {
                txtCompanyName.BorderColor = Color.FromArgb(33, 195, 41);   
            }
        }
        
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.BorderColor = Color.Red;
            }
            else
            {
                txtName.BorderColor = Color.FromArgb(33, 195, 41);
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length != 10)
            {
                txtPhone.BorderColor = Color.Red;
            }
            else
            {
                txtPhone.BorderColor = Color.FromArgb(33, 195, 41);
            }
        }

        private void txtProvince_TextChanged(object sender, EventArgs e)
        {
            if (txtProvince.Text == "")
            {
                txtProvince.BorderColor = Color.Red;
            }
            else
            {
                txtProvince.BorderColor = Color.FromArgb(33, 195, 41);
            }
        }

        private void txtDistrict_TextChanged(object sender, EventArgs e)
        {
            if (txtDistrict.Text == "")
            {
                txtDistrict.BorderColor = Color.Red;
            }
            else
            {
                txtDistrict.BorderColor = Color.FromArgb(33, 195, 41);
            }
        }

        private void txtCommune_TextChanged(object sender, EventArgs e)
        {
            if (txtCommune.Text == "")
            {
                txtCommune.BorderColor = Color.Red;
            }
            else
            {
                txtCommune.BorderColor = Color.FromArgb(33, 195, 41);
            }
        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {
            if (txtStreet.Text == "")
            {
                txtStreet.BorderColor = Color.Red;
            }
            else
            {
                txtStreet.BorderColor = Color.FromArgb(33, 195, 41);
            }
        }

        private void txtHome_TextChanged(object sender, EventArgs e)
        {
            if (txtHome.Text == "")
            {
                txtHome.BorderColor = Color.Red;
            }
            else
            {
                txtHome.BorderColor = Color.FromArgb(33, 195, 41);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.BorderColor = Color.Red;
            }
            else
            {
                txtEmail.BorderColor = Color.FromArgb(33, 195, 41);
            }

            try
            {
                // Biểu thức chính quy kiểm tra email
                var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
                if (regex.IsMatch(txtEmail.Text))
                {
                    txtEmail.BorderColor = Color.FromArgb(33, 195, 41);
                }
            }
            catch (Exception)
            {
                txtEmail.BorderColor = Color.Red;
            }
        }

        private void txtIndustry_TextChanged(object sender, EventArgs e)
        {
            if (txtIndustry.Text == "")
            {
                txtIndustry.BorderColor = Color.Red;
            }
            else
            {
                txtIndustry.BorderColor = Color.FromArgb(33, 195, 41);
            }
        }

        private void txtLoginName_TextChanged(object sender, EventArgs e)
        {
            if (txtLoginName.Text == "")
            {
                txtLoginName.BorderColor = Color.Red;
            }
            else
            {
                txtLoginName.BorderColor = Color.FromArgb(33, 195, 41);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.BorderColor = Color.Red;
            }
            else
            {
                txtPassword.BorderColor = Color.FromArgb(33, 195, 41);
            }
        }

        private void txtRePassword_TextChanged(object sender, EventArgs e)
        {
            if (txtRePassword.Text == txtPassword.Text)
            {
                txtRePassword.BorderColor = Color.Red;
            }
            else
            {
                txtRePassword.BorderColor = Color.FromArgb(33, 195, 41);
            }
        }

        #endregion



    }
}
