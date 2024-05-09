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
    public partial class UCCV : UserControl
    {
        ApplicationDAO app = new ApplicationDAO();
        JobDTO JobDTO;
        CvDTO cvDTO;
        public UCCV(CvDTO cv, JobDTO job = null)
        {
            InitializeComponent();
            this.JobDTO = job;
            this.cvDTO = cv;
        }

        private void UCCV_Load(object sender, EventArgs e)
        {
            lbTitle.Text = cvDTO.Title;
            lbCreateDate.Text = cvDTO.CreateDate.ToString();
            if(JobDTO == null)
            {
                btnSubmit.Hide();
            }
            else
            {
                btnSubmit.Show();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ApplicationDTO appDTO = new ApplicationDTO(DateTime.Now, JobDTO.JobID, cvDTO.Id);
            app.Add(appDTO);
            MessageBox.Show("Đã nộp CV thành công");
        }

        private void btnViewCV_Click(object sender, EventArgs e)
        {
            FCV fCV = new FCV(cvDTO);
            DialogResult result = fCV.ShowDialog();
            this.Hide();
            if(result == DialogResult.Cancel)
            {
                this.Show();
            }

        }
    }
}
