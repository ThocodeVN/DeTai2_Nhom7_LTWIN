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
    public partial class FHistory : Form
    {
        CandidateDTO can;
        CvDAO cvDAO = new CvDAO();
        ApplicationDAO appDAO = new ApplicationDAO();
        JobDAO jobDAO = new JobDAO();
        public FHistory(CandidateDTO canDTO)
        {
            InitializeComponent();
            this.can = canDTO;
        }

        private void LoadHistory()
        {
            fpnlHistory.Controls.Clear();
            List<CvDTO> listCV = cvDAO.GetListCV_Can(can);
            List<ApplicationDTO> history = new List<ApplicationDTO>();
            foreach (CvDTO cv in listCV)
            {
                history.AddRange(appDAO.GetListApp(0, cv.Id));
            }

            foreach (ApplicationDTO app in history)
            {
                UCHistoryCV uch = new UCHistoryCV(jobDAO.getOneJob(app.JobID), cvDAO.GetOneCVFollowCvID(app.CvID), app);
                uch.Dock = DockStyle.None;
                fpnlHistory.Controls.Add(uch);
            }
        }

        private void FHistory_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }
    }
}
