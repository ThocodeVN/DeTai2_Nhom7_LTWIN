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
            string education = txtSchool.Text + ", " + txtStudyIndus.Text + ", " + dtpEduStart.Value.ToShortDateString() + " - " + dtpEduEnd.Value.ToShortDateString();
            string exp = txtCompany.Text + ", " + txtWorkIndus.Text + ", " + dtpWorkStart.Value.ToShortDateString() + " - " + dtpWorkEnd.Value.ToShortDateString();
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
    }
}
