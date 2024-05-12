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
    public partial class UCBaseInfor : UserControl
    {
        CandidateDTO canDTO;
        CandidateDAO canDAO = new CandidateDAO();
        public UCBaseInfor(CandidateDTO canDTO)
        {
            InitializeComponent();
            this.canDTO = canDTO;
        }

        private void UCBaseInfor_Load(object sender, EventArgs e)
        {
            txtName.Text = canDTO.Name;
            txtEmail.Text = canDTO.Email;
            txtPhone.Text = canDTO.Phone;
            txtAddress.Text = canDTO.Address;
            cbxSex.SelectedText = canDTO.Sex;

            if (canDTO.Avatar != null)
            {
                MemoryStream stream = new MemoryStream(canDTO.Avatar.ToArray());
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
            canDTO.Avatar = stream.ToArray();
            CheckImage();
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            ptrbAvatar.Image = null;
            canDTO.Avatar = null;
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
            canDTO.Name = txtName.Text;
            canDTO.Email = txtEmail.Text;
            canDTO.Phone = txtPhone.Text;
            canDTO.Address = txtAddress.Text;
            canDTO.Sex = cbxSex.SelectedText;
            canDAO.UpdateInfor(canDTO);
        }
    }
}
