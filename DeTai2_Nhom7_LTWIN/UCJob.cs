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
    public partial class UCJob : UserControl
    {
        private JobDTO job;
        private CandidateDTO can;
        private EmployerDTO empDTO;
        private EmployerDAO empDAO = new EmployerDAO();

        public UCJob() { }

        public UCJob(JobDTO job, CandidateDTO can = null, EmployerDTO emp = null)
        {
            InitializeComponent();
            this.job = job;
            this.can = can;
            if (emp == null)
            {
                this.empDTO = empDAO.GetOneEmp(job.EmpID);
            }
            else
            {
                this.empDTO = emp;
            }
        }

        private void UCJob_Load(object sender, EventArgs e)
        {
            lbCompanyName.Text = empDTO.CompanyName;
            lbJobName.Text = job.Title;
            lbLocation.Text = job.Location.Substring(0, job.Location.IndexOf(','));
            lbSalary.Text = job.Salary.ToString();

            if (empDTO.Avatar != null)
            {
                MemoryStream stream = new MemoryStream(empDTO.Avatar.ToArray());
                System.Drawing.Image img = System.Drawing.Image.FromStream(stream);
                ptrbAvatar.Image = img;
            }
        }

        private void UCJob_MouseClick(object sender, MouseEventArgs e)
        {
            Form fJob;
            if (can == null)
                fJob = new FJobOperation(job, empDTO);
            else
                fJob = new FInforJob(job, can);
            fJob.Show();
        }
    }
}
