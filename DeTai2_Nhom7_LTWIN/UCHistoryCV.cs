using DeTai2_Nhom7_LTWIN.DAO;
using DeTai2_Nhom7_LTWIN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai2_Nhom7_LTWIN
{
    public partial class UCHistoryCV : UserControl
    {
        JobDTO jobDTO;
        ApplicationDTO appDTO;
        CvDTO cvDTO;
        EmployerDAO employerDAO = new EmployerDAO();
        public UCHistoryCV(JobDTO job, CvDTO cv, ApplicationDTO app)
        {
            InitializeComponent();
            this.jobDTO = job;
            this.appDTO = app;
            this.cvDTO = cv;
        }

        private void UCHistoryCV_Load(object sender, EventArgs e)
        {
            EmployerDTO empDTO = employerDAO.GetOneEmp(jobDTO.EmpID);
            lbCompanyName.Text = empDTO.CompanyName;
            lbCVname.Text = cvDTO.Title;
            lbJobName.Text = jobDTO.Title;
            lbLocation.Text = jobDTO.Location.Substring(0, jobDTO.Location.IndexOf(','));
            lbSalary.Text = jobDTO.Salary.ToString();
            lbSubmitDate.Text = appDTO.CreateDate.ToString();

            if (cvDTO.Avatar != null)
            {
                MemoryStream stream = new MemoryStream(cvDTO.Avatar.ToArray());
                Image img = Image.FromStream(stream);
                ptrbAvtCV.Image = img;
            }

            if (empDTO.Avatar != null)
            {
                MemoryStream stream = new MemoryStream(empDTO.Avatar.ToArray());
                Image img = Image.FromStream(stream);
                ptrAvtJob.Image = img;
            }

            if (!appDTO.State)
            {
                pnlHistory.BackColor = Color.Yellow;
                pnlHistory.ForeColor = Color.Black;
            }
            else
            {
                pnlHistory.BackColor = Color.LimeGreen;
                pnlHistory.ForeColor = Color.White;
            }
        }
    }
}
