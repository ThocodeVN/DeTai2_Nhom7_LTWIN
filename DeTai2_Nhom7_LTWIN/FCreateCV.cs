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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai2_Nhom7_LTWIN
{
    public partial class FCreateCV : Form
    {
        CandidateDTO canDTO;
        CvDTO cvDTO;
        CvDAO cvDAO = new CvDAO();
        MemoryStream image = null;
        public FCreateCV(CandidateDTO can, CvDTO cvDTO = null)
        {
            InitializeComponent();
            this.canDTO = can;
            this.cvDTO = cvDTO;
        }

        private void btnCreateCV_Click(object sender, EventArgs e)
        {
            string education = txtSchool.Text + ", " + txtStudyIndus.Text + ", " + dtpEduStart.Value.ToShortDateString() + " - " + dtpEduEnd.Value.ToShortDateString();
            string exp = txtCompany.Text + ", " + txtWorkIndus.Text + ", " + dtpWorkStart.Value.ToShortDateString() + " - " + dtpWorkEnd.Value.ToShortDateString();
            CvDTO cvDTO = new CvDTO(canDTO.CanID, txtTitle.Text, rtxtIntroduce.Text, education, rtxtSkills.Text, exp, rtxtCertificate.Text, DateTime.Now);
            cvDTO.Avatar = image.ToArray();
            cvDAO.Add(cvDTO);
        }

        private void FCreateCV_Load(object sender, EventArgs e)
        {
            txtName.Text = canDTO.Name;
            txtName.Enabled = false;
            txtEmail.Text = canDTO.Email;
            txtEmail.Enabled = false;
            txtPhone.Text = canDTO.Phone;
            txtPhone.Enabled = false;
            txtAddress.Text = canDTO.Address;
            txtAddress.Enabled = false;
            cbxSex.Items[0] = canDTO.Sex;
            cbxSex.SelectedItem = cbxSex.Items[0];
            cbxSex.Enabled = false;
            dtpBirth.Value = canDTO.Birth;
            dtpBirth.Enabled = false;


            if(cvDTO == null)
            {
                btnUpdate.Hide();
                btnCreateCV.Show();
            }    
            else
            {
                btnUpdate.Show();
                btnCreateCV.Hide();

                txtTitle.Text = cvDTO.Title;
                string[] education = ConvertData(cvDTO.Education);
                txtSchool.Text = education[0];
                txtStudyIndus.Text = education[1];
                dtpEduStart.Value = Convert.ToDateTime(education[2]);
                dtpEduEnd.Value = Convert.ToDateTime(education[3]);

                string[] experience = ConvertData(cvDTO.Exp);
                txtCompany.Text = experience[0];
                txtWorkIndus.Text = experience[1];
                dtpWorkStart.Value = Convert.ToDateTime(experience[2]);
                dtpWorkEnd.Value = Convert.ToDateTime(experience[3]);

                rtxtIntroduce.Text = cvDTO.Introduce;
                rtxtSkills.Text = cvDTO.Skill;
                rtxtCertificate.Text = cvDTO.Certificate;

                if (cvDTO.Avatar != null)
                {
                    MemoryStream stream = new MemoryStream(cvDTO.Avatar.ToArray());
                    Image img = Image.FromStream(stream);
                    ptrbAvatar.Image = img;
                }
            }    

            CheckImage();
        }

        // hàm dùng để chuyển từ dữ liệu trong data sang các control trên FcreateCV
        private string[] ConvertData(string input)
        {
            string[] list = new string[5];

            // Tách chuỗi thành các phần
            string[] parts = input.Split(',');

            // Loại bỏ khoảng trắng ở đầu và cuối của mỗi phần
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i] = parts[i].Trim();
                list[i] = parts[i];
            }

            // Phần tử thứ ba là ngày bắt đầu
            list[2] = parts[2].Split('-')[0].Trim();

            // phần tử thứ ba là ngày kết thúc
            list[3] = parts[2].Split('-')[1].Trim();

            return list;
        }

        private void cbStuding_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStuding.Checked)
            {
                dtpEduEnd.Value = DateTime.Now;
                dtpEduEnd.Enabled = false;
            }
            else
            {
                dtpEduEnd.Enabled = true;
            }    
        }

        private void cbNotWork_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNotWork.Checked)
            {
                txtCompany.Enabled = false;
                txtWorkIndus.Enabled = false;
                dtpWorkEnd.Enabled = false;
                dtpWorkStart.Enabled = false;
                txtCompany.Text = "Chưa đi làm";
                txtWorkIndus.Text = "Chưa đi làm";
            }
            else
            {
                txtCompany.Enabled = true;
                txtWorkIndus.Enabled = true;
                dtpWorkEnd.Enabled = true;
                dtpWorkStart.Enabled = true;
            }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string education = txtSchool.Text + ", " + txtStudyIndus.Text + ", " + dtpEduStart.Value.ToShortDateString() + " - " + dtpEduEnd.Value.ToShortDateString();
            string exp = txtCompany.Text + ", " + txtWorkIndus.Text + ", " + dtpWorkStart.Value.ToShortDateString() + " - " + dtpWorkEnd.Value.ToShortDateString();
            cvDTO.Exp = exp;
            cvDTO.Education = education;
            cvDTO.Skill = rtxtSkills.Text;
            cvDTO.CanId = canDTO.CanID;
            cvDTO.Certificate = rtxtCertificate.Text;
            cvDTO.Title = txtTitle.Text;
            cvDTO.Introduce = rtxtIntroduce.Text;
            cvDAO.Update(cvDTO);
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                txtTitle.BorderColor = Color.Red;
            }
            else
            {
                txtTitle.BorderColor = Color.FromArgb(33, 195, 41);
            }
        }

        private void txtSchool_TextChanged(object sender, EventArgs e)
        {
            if (txtSchool.Text == "")
            {
                txtSchool.BorderColor = Color.Red;
            }
            else
            {
                txtSchool.BorderColor = Color.FromArgb(33, 195, 41);
            }
        }

        private void txtStudyIndus_TextChanged(object sender, EventArgs e)
        {
            if (txtStudyIndus.Text == "")
            {
                txtStudyIndus.BorderColor = Color.Red;
            }
            else
            {
                txtStudyIndus.BorderColor = Color.FromArgb(33, 195, 41);
            }
        }

        private void txtCompany_TextChanged(object sender, EventArgs e)
        {
            if (txtCompany.Text == "")
            {
                txtCompany.BorderColor = Color.Red;
            }
            else
            {
                txtCompany.BorderColor = Color.FromArgb(33, 195, 41);
            }
        }

        private void txtWorkIndus_TextChanged(object sender, EventArgs e)
        {
            if (txtWorkIndus.Text == "")
            {
                txtWorkIndus.BorderColor = Color.Red;
            }
            else
            {
                txtWorkIndus.BorderColor = Color.FromArgb(33, 195, 41);
            }
        }

        private void rtxtIntroduce_TextChanged(object sender, EventArgs e)
        {
            if (rtxtIntroduce.Text == "")
            {
            }
            else
            {
            }
        }

        private void rtxtSkills_TextChanged(object sender, EventArgs e)
        {
            if (rtxtSkills.Text == "")
            {
            }
            else
            {
            }
        }

        private void rtxtCertificate_TextChanged(object sender, EventArgs e)
        {
            if (rtxtCertificate.Text == "")
            {

            }
            else
            {
            }
        }
    }
}
