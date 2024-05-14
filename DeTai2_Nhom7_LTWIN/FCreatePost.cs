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
    public partial class FCreatePost : Form
    {
        MemoryStream image;
        CandidateDTO canDTO;
        CvDTO cvDTO;
        PostDAO postDAO = new PostDAO();
        public FCreatePost(CandidateDTO candidateDTO, CvDTO cvDTO)
        {
            InitializeComponent();
            canDTO = candidateDTO;
            this.cvDTO = cvDTO;
            btnDelImagePost.Hide();
        }
        private void FCreatePost_Load(object sender, EventArgs e)
        {
            lbName.Text = canDTO.Name;
            lbDateCreate.Text = DateTime.Now.ToString();
            btnAddCV.Text = cvDTO.Title;
            rtxtContent.Text = canDTO.Name + rtxtContent.Text;
            if (canDTO.Avatar != null)
            {
                MemoryStream stream = new MemoryStream(canDTO.Avatar.ToArray());
                System.Drawing.Image img = System.Drawing.Image.FromStream(stream);
                ptrbAvt.Image = img;
            }
        }

        private void ptrbPost_Click(object sender, EventArgs e)
        {
            ofdOpenImage.ShowDialog();
            string file = "";
            file = ofdOpenImage.FileName;
            if (file == "" || file == "openFileDialog1")
            {
                return;
            }
            System.Drawing.Image avatar = System.Drawing.Image.FromFile(file);
            ptrbPost.Image = avatar;

            MemoryStream stream = new MemoryStream();
            ptrbPost.Image.Save(stream, ImageFormat.Jpeg);
            image = stream;
            CheckImage();
        }

        private void CheckImage()
        {
            if (ptrbPost.Image == null)
            {
                btnDelImagePost.Hide();
            }
            else
            {
                btnDelImagePost.Show();
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            PostDTO post = new PostDTO(canDTO.CanID, cvDTO.Id, rtxtContent.Text, DateTime.Now);
            post.Picture = image.ToArray();
            postDAO.Add(post);
        }



        private void btnAddCV_Click(object sender, EventArgs e)
        {
            FCV fcv = new FCV(cvDTO);
            this.Hide();
            DialogResult re = fcv.ShowDialog();
            if(re == DialogResult.Cancel)
            {
                this.Show();
            }
        }
    }
}
