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
    public partial class FInforJob : Form
    {
        JobDTO jobDTO;
        CandidateDTO canDTO;

        public FInforJob(JobDTO jobDTO, CandidateDTO can)
        {
            InitializeComponent();
            this.jobDTO = jobDTO;
            this.canDTO = can;
        }

        public void LoadInfoJob(JobDTO jobD)
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
            FManageCV myCV = new FManageCV(canDTO);
            this.Hide();
            myCV.ShowDialog();
            this.Show();
        }
    }
}
