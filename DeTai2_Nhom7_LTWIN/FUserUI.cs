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

        private void btnFind_Click(object sender, EventArgs e)
        {
            string find = "select * from Job where ";
            if (txtFind.Text != "Tìm kiếm công việc ở đây..." && txtFind.Text != "")
            {
                find += " Title = N'" + txtFind.Text + "' and ";
            }

            if (cbxExp.Text != "Kinh nghiệm" && cbxExp.Text != "")
            {
                find += "ReqExperience = N'" + cbxExp.Text + "' and ";
            }

            if (cbxSalary.Text != "Mức lương" && cbxSalary.Text != "")
            {
                find += "Salary = " + cbxSalary.Text + " and ";
            }

            if (cbxTypeJob.Text != "Loại công việc" && cbxTypeJob.Text != "")
            {
                find += "Type= N'" + cbxTypeJob.Text + "' and ";
            }

            if (cbxLocation.Text != "Tỉnh thành" && cbxLocation.Text != "")
            {
                find += "Location = N'" + cbxLocation.Text + "' and ";
            }

            find = find.Remove(find.Length - 5);
            MessageBox.Show(find);
            fpnlJob.Controls.Clear();
            
        }
    }
}
