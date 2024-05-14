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
    public partial class FCreateJob : Form
    {
        EmployerDTO empDTO;
        JobDTO jobDTO;
        JobDAO jobDAO = new JobDAO();
        public FCreateJob(EmployerDTO empDTO, JobDTO jobDTO = null)
        {
            InitializeComponent();
            this.empDTO = empDTO;
            this.jobDTO = jobDTO;
        }

        private void btnCreateJob_Click(object sender, EventArgs e)
        {
            string address = txtProvince.Text + ", " + txtDistrict.Text + ", " + txtCommune.Text + ", " + txtStreet.Text + ", " + txtHome.Text;
            JobDTO jobDTO = new JobDTO(txtJobName.Text, rtxtDescr.Text, rtxtRequire.Text,Convert.ToInt32(txtSalary.Text), address, empDTO.Id, dtpLastDate.Value, txtTimeWork.Text, rtxtBenefit.Text, rtxtAppLy.Text, cbxExp.Text, cbxType.Text, cbxEducation.Text);
            jobDAO.Create(jobDTO);
        }

        private void FCreateJob_Load(object sender, EventArgs e)
        {
            if(jobDTO == null)
            {
                btnCreateJob.Show();
                btnUpdate.Hide();
            }    
            else
            {
                btnUpdate.Show();
                btnCreateJob.Hide();
                LoadInforJob();
            }    
        }

        private void LoadInforJob()
        {
            txtJobName.Text = jobDTO.Title;
            txtSalary.Text = jobDTO.Salary.ToString();
            txtTimeWork.Text = jobDTO.TimeWork;
            rtxtAppLy.Text = jobDTO.HowApply;
            rtxtBenefit.Text = jobDTO.Benefit;
            rtxtDescr.Text = jobDTO.Description;
            rtxtRequire.Text = jobDTO.Require;
            dtpLastDate.Value = jobDTO.LastDate;
            cbxEducation.Text = jobDTO.Education;
            cbxExp.Text = jobDTO.Experience;
            cbxType.Text = jobDTO.Type;
            
            string[] address = jobDTO.Location.Split(',');
            txtProvince.Text = address[0];
            txtDistrict.Text = address[1];
            txtCommune.Text = address[2];
            txtHome.Text = address[3];
            txtHome.Text = address[4];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            jobDTO.Title = txtJobName.Text;
            jobDTO.Salary = Convert.ToInt32(txtSalary.Text);
            jobDTO.TimeWork = txtTimeWork.Text;
            jobDTO.HowApply = rtxtAppLy.Text;
            jobDTO.Benefit = rtxtBenefit.Text;
            jobDTO.Description = rtxtDescr.Text;
            jobDTO.Require = rtxtRequire.Text;
            jobDTO.LastDate = dtpLastDate.Value;
            jobDTO.Education = cbxEducation.Text;
            jobDTO.Experience = cbxExp.Text;
            jobDTO.Type = cbxType.Text;
            jobDAO.Update(jobDTO);
        }

        private void cbDefault_CheckedChanged(object sender, EventArgs e)
        {
            string[] address = empDTO.Address.Split(',');
            txtProvince.Text = address[0];
            txtDistrict.Text = address[1];
            txtCommune.Text = address[2];
            txtHome.Text = address[3];
            txtHome.Text = address[4];
        }
    }
}
