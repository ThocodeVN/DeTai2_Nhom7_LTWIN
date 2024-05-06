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
    public partial class FUserUI : Form
    {
        public FUserUI()
        {
            InitializeComponent();
        }

        private void btnInfor_MouseEnter(object sender, EventArgs e)
        {
            btnInfor.BackColor = ColorTranslator.FromHtml("#21c329");
            btnInfor.ForeColor = Color.White;
        }

        private void btnInfor_MouseLeave(object sender, EventArgs e)
        {
            btnInfor.BackColor = Color.White;
            btnInfor.ForeColor = Color.Black;
        }
    }
}
