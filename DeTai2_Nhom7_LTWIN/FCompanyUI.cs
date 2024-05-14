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
    public partial class FCompanyUI : Form
    {
        EmployerDTO empDTO;
        JobDAO job = new JobDAO();
        public FCompanyUI(EmployerDTO employerDTO)
        {
            InitializeComponent();
            this.empDTO = employerDTO;
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            pnlFunc.Controls.Clear();
            FJob fjob = new FJob(empDTO);
            fjob.TopLevel = false;
            pnlFunc.Controls.Add(fjob);
            fjob.Show();
        }

        private void btnComInfor_Click(object sender, EventArgs e)
        {
            pnlFunc.Controls.Clear();
            UCCompanyInfor uCCompanyInfor = new UCCompanyInfor(empDTO);
            pnlFunc.Controls.Add(uCCompanyInfor);
        }

        private void FCompanyUI_Load(object sender, EventArgs e)
        {
            btnComInfor_Click(sender, e);
        }

        private void btnViewPost_Click(object sender, EventArgs e)
        {
            FViewPost fView = new FViewPost();
            fView.Show();
        }
    }
}
