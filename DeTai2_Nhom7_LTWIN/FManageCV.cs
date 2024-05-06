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
        
        public FManageCV(CandidateDTO canDTO)
        {
            InitializeComponent();
            this.canDTO = canDTO;
        }

        private void btnCreateCV_Click(object sender, EventArgs e)
        {
            FCreateCV fCreateCV = new FCreateCV();
            this.Hide();
            this.Show();
            fCreateCV.ShowDialog();
        }
    }
}
