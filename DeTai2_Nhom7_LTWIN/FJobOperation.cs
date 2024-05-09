using DeTai2_Nhom7_LTWIN.DAO;
using DeTai2_Nhom7_LTWIN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai2_Nhom7_LTWIN
{
    public partial class FJobOperation : Form
    {
        private JobDTO jobD;
        private EmployerDTO employer;
        private ApplicationDAO appDAO = new ApplicationDAO();  
        public FJobOperation(JobDTO job, EmployerDTO employer)
        {
            InitializeComponent();
            this.jobD = job;
            this.employer = employer;
        }

        private void btnCand_Click(object sender, EventArgs e)
        {
            FViewCV fcv = new FViewCV(jobD);
            this.Hide();
            this.Show();
            fcv.ShowDialog();
        }

        public void LoadInfoJob()
        {

            lbNameJob.Text = jobD.Title;
            lbSalary.Text = jobD.Salary.ToString();
            lbExp.Text = jobD.Experience.ToString();
            lbDescr.Text = jobD.Description;
            lbRequire.Text = jobD.Require;
            lbLocation.Text = jobD.Location;
            lbBenefit.Text = jobD.Benefit;
            lbHowApply.Text = jobD.HowApply;
            lbTimeWork.Text = jobD.TimeWork;

            lbLoca.Text = jobD.Location.Substring(0, jobD.Location.IndexOf(','));
            lbNumCV.Text = (appDAO.GetListApp(jobD.JobID) == null)? "0" : appDAO.GetListApp(jobD.JobID).Count.ToString();

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

        private void FJobOperation_Load(object sender, EventArgs e)
        {
            LoadInfoJob();
        }
    }
}
