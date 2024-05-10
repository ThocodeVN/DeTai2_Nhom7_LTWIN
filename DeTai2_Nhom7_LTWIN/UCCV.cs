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
        ApplicationDAO appDAO = new ApplicationDAO();
        ApplicationDTO appDTO;
        JobDTO JobDTO;
        CvDTO cvDTO;
        bool browse;
        public UCCV(CvDTO cv,bool browse = false, JobDTO job = null)
        {
            InitializeComponent();
            this.JobDTO = job;
            this.cvDTO = cv;
            this.browse = browse;
            appDTO = appDAO.GetOneApp(0, JobDTO.JobID, cvDTO.Id);
            if(appDTO.State)
            {
                btnBrowse.Text = "Đã duyệt";
                btnBrowse.BackColor = Color.FromArgb(49, 98, 63);
            }    
            else
            {
                btnBrowse.Text = "Chưa duyệt";
                btnBrowse.BackColor = Color.Yellow;
            }    
            
        }

        private void UCCV_Load(object sender, EventArgs e)
        {
            lbTitle.Text = cvDTO.Title;
            lbCreateDate.Text = cvDTO.CreateDate.ToString();
            if(JobDTO == null && !browse)
            {
                btnSubmit.Hide();
            }
            else
            {
                btnSubmit.Show();
            }

            if(browse)
            {
                btnBrowse.Show();
            }    
            else
            {
                btnBrowse.Hide();
            }    
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ApplicationDTO appDTO = new ApplicationDTO(DateTime.Now, JobDTO.JobID, cvDTO.Id);
            appDAO.Add(appDTO);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if(appDTO.State)
            {
                MessageBox.Show("Bạn đã duyệt qua CV này");
                return;
            }    
            appDTO = appDAO.GetOneApp(0, JobDTO.JobID, cvDTO.Id);  
            appDTO.State = true;
            appDAO.Browse(appDTO);
        }

        private void btnViewCV_Click(object sender, EventArgs e)
        {
            FCV fCV = new FCV(cvDTO);
            DialogResult result = fCV.ShowDialog();
            this.Hide();
            if (result == DialogResult.Cancel)
            {
                this.Show();
            }
        }
    }
}
