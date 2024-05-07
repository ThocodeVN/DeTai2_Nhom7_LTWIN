using DeTai2_Nhom7_LTWIN.DAO;
using DeTai2_Nhom7_LTWIN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai2_Nhom7_LTWIN
{
    public partial class FCreateCV : Form
    {
        CandidateDTO canDTO;
        CvDAO cvDAO = new CvDAO();
        public FCreateCV(CandidateDTO can)
        {
            InitializeComponent();
            this.canDTO = can;
        }

        private void btnCreateCV_Click(object sender, EventArgs e)
        {
            string education = txtSchool.Text + ", " + txtStudyIndus.Text + ", " + dtpEduStart.Value.ToString() + " - " + dtpEduEnd.Value.ToString();
            string exp = txtCompany.Text + ", " + txtWorkIndus.Text + ", " + dtpWorkStart.Value.ToString() + " - " + dtpWorkEnd.Value.ToString();
            CvDTO cvDTO = new CvDTO(canDTO.CanID, txtTitle.Text, txtIntroduce.Text, education, rtxtSkills.Text, exp, rtxtCertificate.Text, DateTime.Now);
            cvDAO.Add(cvDTO);
        }

        private void FCreateCV_Load(object sender, EventArgs e)
        {
            txtName.Text = canDTO.Name;
            txtEmail.Text = canDTO.Email;
            txtPhone.Text = canDTO.Phone;
            txtAddress.Text = canDTO.Address;
            cbxSex.Text = canDTO.Sex;
            dtpBirth.Value = canDTO.Birth;
        }
    }
}
