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
    public partial class FViewCV : Form
    {
        JobDTO jobDTO;
        ApplicationDAO appDAO = new ApplicationDAO();
        CvDAO cvDAO = new CvDAO();
        public FViewCV(JobDTO jobDTO)
        {
            InitializeComponent();
            this.jobDTO = jobDTO;
        }

        private void FViewCV_Load(object sender, EventArgs e)
        {
            List<ApplicationDTO> listApp = appDAO.GetListApp(jobDTO.JobID);
            foreach (ApplicationDTO app in listApp)
            {
                CvDTO cvDTO = cvDAO.GetOneCVFollowCvID(app.CvID);
                UCCV ucv = new UCCV(cvDTO,true, jobDTO);
                fpnlCV.Controls.Add(ucv);
            }
        }
    }
}
