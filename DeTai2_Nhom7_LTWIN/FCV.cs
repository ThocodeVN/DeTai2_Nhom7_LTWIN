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
    public partial class FCV : Form
    {
        CvDTO cvDTO;
        CandidateDAO canDAO = new CandidateDAO();
        public FCV(CvDTO cvDTO)
        {
            InitializeComponent();
            this.cvDTO = cvDTO;
        }

        private void FCV_Load(object sender, EventArgs e)
        {
            lbName.Text = canDAO.GetOneCandi(cvDTO.CanId).Name;
            lbBirth.Text = canDAO.GetOneCandi(cvDTO.CanId).Birth.ToShortDateString();
            lbSex.Text = canDAO.GetOneCandi(cvDTO.CanId).Sex;
            lbIntroduce.Text = cvDTO.Introduce;
            lbSkills.Text = cvDTO.Skill;
            lbAddress.Text = canDAO.GetOneCandi(cvDTO.CanId).Address;
            lbCertificate.Text = cvDTO.Certificate;
            lbEducation.Text = cvDTO.Education;
            lbExp.Text = cvDTO.Exp;
            lbPhone.Text = canDAO.GetOneCandi(cvDTO.CanId).Phone;
            lbEmail.Text = canDAO.GetOneCandi(cvDTO.CanId).Email;

            if (cvDTO.Avatar != null)
            {
                MemoryStream stream = new MemoryStream(cvDTO.Avatar.ToArray());
                Image img = Image.FromStream(stream);
                ptrbAvatar.Image = img;
            }
        }
    }
}
