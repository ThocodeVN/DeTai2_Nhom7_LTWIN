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
    public partial class UCBaseInfor : UserControl
    {
        CandidateDTO canDTO;
        public UCBaseInfor(CandidateDTO canDTO)
        {
            InitializeComponent();
            this.canDTO = canDTO;
        }

        private void UCBaseInfor_Load(object sender, EventArgs e)
        {
            txtName.Text = canDTO.Name;
            txtEmail.Text = canDTO.Email;
            txtPhone.Text = canDTO.Phone;
            txtAddress.Text = canDTO.Address;
            cbxSex.Text = canDTO.Sex;
        }
    }
}
