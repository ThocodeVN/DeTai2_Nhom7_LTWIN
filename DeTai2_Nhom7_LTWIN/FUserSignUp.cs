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
    public partial class FUserSignUp : Form
    {
        CandidateDAO canDAO = new CandidateDAO();
        public FUserSignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string address = txtProvince.Text + ", " + txtDistrict.Text + ", " + txtCommune.Text + ", " + txtStreet.Text + ", " + txtHome.Text;
            CandidateDTO canDTO = new CandidateDTO(txtName.Text, cbxSex.Text, dtpBirth.Value, txtPhone.Text, txtEmail.Text, address, txtLoginName.Text, txtPassword.Text);
            canDAO.Add(canDTO);
        }
    }
}
