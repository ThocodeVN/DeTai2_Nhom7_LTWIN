using DeTai2_Nhom7_LTWIN.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai2_Nhom7_LTWIN.DTO
{
    public partial class FManageCV : Form
    {
        CandidateDTO canDTO;
        JobDTO jobDTO;
        CvDAO cvDAO = new CvDAO();
        
        public FManageCV(CandidateDTO canDTO, JobDTO jobDTO = null)
        {
            InitializeComponent();
            this.canDTO = canDTO;
            this.jobDTO = jobDTO;
            if(jobDTO != null )
            {
                FormBorderStyle = FormBorderStyle.FixedSingle;
                btnCreateCV.Hide();
            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
                btnCreateCV.Show();
            }    
        }

        private void btnCreateCV_Click(object sender, EventArgs e)
        {
            FCreateCV fCreateCV = new FCreateCV(canDTO);
            this.Hide();
            this.Show();
            fCreateCV.ShowDialog();
        }

        private void FManageCV_Load(object sender, EventArgs e)
        {
            fpnlCV.Controls.Clear();
            List<CvDTO> listCV = cvDAO.GetListCV_Can(canDTO);
            foreach (CvDTO cv in listCV)
            {
                UCCV ucv = new UCCV(cv, jobDTO);
                fpnlCV.Controls.Add(ucv);
            }
        }

        
    }
}
