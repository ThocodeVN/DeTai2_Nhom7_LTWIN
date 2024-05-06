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
    public partial class FJob : Form
    {
        EmployerDTO empDTO;
        JobDAO jobDAO = new JobDAO();
        public FJob(EmployerDTO emp)
        {
            InitializeComponent();
            this.empDTO = emp;
        }

        private void FJob_Load(object sender, EventArgs e)
        {
            fpnlJob.Controls.Clear();
            List<JobDTO> listJob = new List<JobDTO>();
            listJob = jobDAO.GetListJob_Emp(empDTO);
            foreach (JobDTO job in listJob)
            {
                UCJob uCJob = new UCJob(job, null, empDTO);
                fpnlJob.Controls.Add(uCJob);
            }
        }

        private void btnCreateJob_Click(object sender, EventArgs e)
        {
            FCreateJob fCreateJob = new FCreateJob(empDTO);
            this.Hide();
            this.Show();
            fCreateJob.ShowDialog();
        }
    }
}
