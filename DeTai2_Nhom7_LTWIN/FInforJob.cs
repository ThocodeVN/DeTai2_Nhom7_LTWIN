using DeTai2_Nhom7_LTWIN.DAO;
using DeTai2_Nhom7_LTWIN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai2_Nhom7_LTWIN
{
    public partial class FInforJob : Form
    {
        JobDTO jobD;
        CandidateDTO canDTO;
        EmployerDAO employerDAO = new EmployerDAO();

        public FInforJob(JobDTO jobDTO, CandidateDTO can)
        {
            InitializeComponent();
            this.jobD = jobDTO;
            this.canDTO = can;
        }

        public void LoadInfoJob()
        {

            lbNameJob.Text = jobD.Title;
            lbSalary.Text = jobD.Salary.ToString();
            lbExp.Text = jobD.Experience.ToString();
            lbAddress.Text = jobD.Location;
            lbDescr.Text = jobD.Description;
            lbRequire.Text = jobD.Require;
            lbLocation.Text = jobD.Location;
            lbBenefit.Text = jobD.Benefit;
            lbHowApply.Text = jobD.HowApply;
            lbTimeWork.Text = jobD.TimeWork;

            lbTExp.Text = jobD.Experience;
            lbTypeJob.Text = jobD.Type;
            lbEducation.Text = jobD.Education; 

            lbLoca.Text = jobD.Location.Substring(0, jobD.Location.IndexOf(','));
            EmployerDTO empDTO = employerDAO.GetOneEmp(jobD.EmpID);
            lbCompanyName.Text = empDTO.CompanyName;

            if (empDTO.Avatar != null)
            {
                MemoryStream stream = new MemoryStream(empDTO.Avatar.ToArray());
                Image img = Image.FromStream(stream);
                ptrAvatar.Image = img;
            }

            DateTime Now = DateTime.Now;
            DateTime Last = jobD.LastDate;
            if (Last < Now)
            {
                lbLastDate.Text = "đã quá hạn ứng tuyển";
            }
            else
            {
                lbLastDate.Text = "Còn " + (Last - Now).Days.ToString() + " ngày";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FManageCV myCV = new FManageCV(canDTO, jobD);
            this.Hide();
            myCV.ShowDialog();
            this.Show();
        }

        private void FInforJob_Load(object sender, EventArgs e)
        {
            LoadInfoJob();
        }

        private void btnSubmit2_Click(object sender, EventArgs e)
        {
            btnSubmit_Click(sender, e);
        }
    }
}
