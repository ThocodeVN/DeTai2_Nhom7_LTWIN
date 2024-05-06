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
        public FUserInfor()
        {
            InitializeComponent();
        }
        
        private void FUserInfor_Load(object sender, EventArgs e)
        {
            btnInfor_Click(sender, e);
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            pnlFunc.Controls.Clear();
            UCBaseInfor ucBase = new UCBaseInfor();
            pnlFunc.Controls.Add(ucBase);
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            pnlFunc.Controls.Clear();
            UCCV ucCV = new UCCV();
            pnlFunc.Controls.Add(ucCV);
        }

        private void btnHistoryCV_Click(object sender, EventArgs e)
        {
            pnlFunc.Controls.Clear();
            UCHistoryCV uCHistory = new UCHistoryCV();
            pnlFunc.Controls.Add(uCHistory);
        }
    }
}
