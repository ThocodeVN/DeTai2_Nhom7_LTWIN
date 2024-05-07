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
    public partial class UCJob : UserControl
    {
        private JobDTO job;
        private CandidateDTO can;
        private EmployerDTO empDTO;
        private EmployerDAO empDAO = new EmployerDAO();

        public PictureBox PictureBox1 { get => pictureBox1; set => pictureBox1 = value; }
        public Label LbJobName { get => lbJobName; set => lbJobName = value; }
        public Label LbCompanyName { get => lbCompanyName; set => lbCompanyName = value; }
        public Label LbSalary { get => lbSalary; set => lbSalary = value; }
        public Label LbLocation { get => lbLocation; set => lbLocation = value; }

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
            LbCompanyName.Text = empDTO.CompanyName;
            LbJobName.Text = job.Title;
            LbLocation.Text = job.Location.Substring(0, job.Location.IndexOf(','));
            LbSalary.Text = job.Salary.ToString();
        }

        private void UCJob_MouseClick(object sender, MouseEventArgs e)
        {
            FInforJob fJob = new FInforJob(job, can);
            fJob.Show();
        }
    }
}
