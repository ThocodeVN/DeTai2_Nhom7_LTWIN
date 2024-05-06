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
    public partial class UCJob : UserControl
    {
        public UCJob()
        {
            InitializeComponent();
        }

        private void UCJob_Load(object sender, EventArgs e)
        {

        }

        private void UCJob_MouseClick(object sender, MouseEventArgs e)
        {
            FInforJob fJob = new FInforJob();
            fJob.Show();
        }
    }
}
