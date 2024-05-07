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
    public partial class FUserUI : Form
    {
        JobDAO jobDAO = new JobDAO();
        CandidateDTO can;
        List<UCJob> listUc;

        List<string> local = new List<string>();
        List<string> type = new List<string>();
        public FUserUI(CandidateDTO can)
        {
            InitializeComponent();
            this.can = can;
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            FUserInfor fUser = new FUserInfor(can);
            fUser.Show();
        }

        private void FUserUI_Load(object sender, EventArgs e)
        {
            fpnlJob.Controls.Clear();
            List<JobDTO> listJob = new List<JobDTO>();
            listJob = jobDAO.GetListJob();
            foreach (JobDTO job in listJob)
            {
                UCJob uCJob = new UCJob(job, can);
                fpnlJob.Controls.Add(uCJob);
            }
        }
    }
}
