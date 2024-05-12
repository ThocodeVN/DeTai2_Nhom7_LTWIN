using DeTai2_Nhom7_LTWIN.DAO;
using DeTai2_Nhom7_LTWIN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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

            cbxExp.SelectedItem = cbxExp.Items[0];
            cbxLocation.SelectedItem = cbxLocation.Items[0];
            cbxSalary.SelectedItem = cbxSalary.Items[0];
            cbxTypeJob.SelectedItem = cbxTypeJob.Items[0];
        }

        private void btnFind_Click(object sender, EventArgs e)
        {   
            string find = "";
            string exp = "";
            string salary = "";
            string type = "";
            string location = "";

            if (txtFind.Text != "Tìm kiếm" && txtFind.Text != "")
            {
                find = txtFind.Text;
            }
            else
                find = "";

            if (cbxExp.Text != "Tất cả kinh nghiệm" && cbxExp.Text != "")
            {
                exp = cbxExp.Text;
            }
            else
                exp = "";

            if (cbxSalary.Text != "Tất cả mức lương" && cbxSalary.Text != "")
            {
                salary = cbxSalary.Text;
            }
            else
                salary = "";

            if (cbxTypeJob.Text != "Tất cả ngành nghề" && cbxTypeJob.Text != "")
            {
                type = cbxTypeJob.Text;
            }
            else
                type = "";

            if (cbxLocation.Text != "Tất cả tỉnh/ thành phố" && cbxLocation.Text != "")
            {
                location = cbxLocation.Text;
            }
            else
                location = "";

            fpnlJob.Controls.Clear();
            if(find == "" && salary == "" && location == "" && exp == "" && type == "")
                FUserUI_Load(sender, e);    
            else
                FindJob(find, exp, salary, type, location);
            fpnlJob_Resize();
        }

        private void FindJob(string find, string salary, string type, string exp, string location)
        {
            fpnlJob.Controls.Clear();
            List<JobDTO> listJob = new List<JobDTO>();
            listJob = jobDAO.GetListJob_Find(find, salary, type, exp, location);
            foreach (JobDTO job in listJob)
            {
                UCJob uCJob = new UCJob(job, can);
                fpnlJob.Controls.Add(uCJob);
            }
        }

        private void fpnlJob_Resize()
        {
            if (fpnlJob.Controls.Count == 1)
            {
                fpnlJob.Size = new Size(fpnlJob.Controls[0].Size.Width + 5, 555);
              
            }

            if (fpnlJob.Controls.Count > 1 && fpnlJob.Controls.Count < 3)
            {
                fpnlJob.Size = new Size(fpnlJob.Controls[0].Size.Width * 2 + 30, 555);
            }

            if (fpnlJob.Controls.Count >= 3)
            {
                fpnlJob.Size = new Size(fpnlJob.Controls[0].Size.Width * 3 + 50, 555);
            }

            int x = (this.Size.Width - fpnlJob.Size.Width) / 2;
            fpnlJob.Location = new Point(x, fpnlJob.Location.Y);
        }

        private void fpnlJob_ControlAdded(object sender, ControlEventArgs e)
        {
            fpnlJob_Resize();
        }

        private void cbxLocation_TextChanged(object sender, EventArgs e)
        {
            if(cbxLocation.SelectedItem.ToString() == "Tất cả tỉnh/ thành phố")
            {
                cbxLocation.ForeColor = Color.Gray;
            }    
            else
            {
                cbxLocation.ForeColor = Color.Black;
            }    
        }

        private void cbxExp_TextChanged(object sender, EventArgs e)
        {
            if (cbxExp.SelectedItem.ToString() == "Tất cả kinh nghiệm")
            {
                cbxExp.ForeColor = Color.Gray;
            }
            else
            {
                cbxExp.ForeColor = Color.Black;
            }
        }

        private void cbxSalary_TextChanged(object sender, EventArgs e)
        {
            if (cbxSalary.SelectedItem.ToString() == "Tất cả mức lương")
            {
                cbxSalary.ForeColor = Color.Gray;
            }
            else
            {
                cbxSalary.ForeColor = Color.Black;
            }
        }

        private void cbxTypeJob_TextChanged(object sender, EventArgs e)
        {
            if (cbxTypeJob.SelectedItem.ToString() == "Tất cả ngành nghề")
            {
                cbxTypeJob.ForeColor = Color.Gray;
            }
            else
            {
                cbxTypeJob.ForeColor = Color.Black;
            }

        }
    }
}
