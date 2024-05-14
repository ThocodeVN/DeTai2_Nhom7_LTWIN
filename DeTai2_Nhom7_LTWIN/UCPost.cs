using DeTai2_Nhom7_LTWIN.DAO;
using DeTai2_Nhom7_LTWIN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai2_Nhom7_LTWIN
{
    public partial class UCPost : UserControl
    {
        PostDTO postDTO;
        CvDAO cvDAO = new CvDAO();
        CandidateDAO canDAO = new CandidateDAO();
        public UCPost(PostDTO post)
        {
            InitializeComponent();
            postDTO = post;
        }

        private void UCPost_Load(object sender, EventArgs e)
        {
            CandidateDTO canDTO = canDAO.GetOneCandi(postDTO.CanID);
            lbName.Text = canDTO.Name;
            lbDateCreate.Text = postDTO.CreateDate.ToString();
            rtxtContent.Text = postDTO.Content;

            if (postDTO.Picture != null)
            {
                MemoryStream stream = new MemoryStream(postDTO.Picture.ToArray());
                Image img = Image.FromStream(stream);
                ptrPost.Image = img;
            }

            if (canDTO.Avatar != null)
            {
                MemoryStream stream = new MemoryStream(canDTO.Avatar.ToArray());
                Image img = Image.FromStream(stream);
                ptrbAvt.Image = img;
            }
        }

        private void btnViewCV_Click(object sender, EventArgs e)
        {
            FCV fCV = new FCV(cvDAO.GetOneCVFollowCvID(postDTO.CvID));
            fCV.Show();
        }
    }
}
