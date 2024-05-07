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
    public partial class FUserInfor : Form
    {
        CandidateDTO canDTO;
        public FUserInfor(CandidateDTO canDTO)
        {
            InitializeComponent();
            this.canDTO = canDTO;
        }
        
        private void FUserInfor_Load(object sender, EventArgs e)
        {
            btnInfor_Click(sender, e);
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            pnlFunc.Controls.Clear();
            UCBaseInfor ucBase = new UCBaseInfor(canDTO);
            pnlFunc.Controls.Add(ucBase);
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            pnlFunc.Controls.Clear();
            FManageCV fManageCV = new FManageCV(canDTO);
            fManageCV.TopLevel = false;
            pnlFunc.Controls.Add(fManageCV);
            fManageCV.Show();
        }

        private void btnHistoryCV_Click(object sender, EventArgs e)
        {
            pnlFunc.Controls.Clear();
            FHistory fHistory = new FHistory(canDTO);
            fHistory.TopLevel = false;
            pnlFunc.Controls.Add(fHistory);
            fHistory.Show();
        }
    }
}
