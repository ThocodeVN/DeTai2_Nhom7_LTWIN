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
    public partial class FCompanySignUp : Form
    {
        EmployerDAO employerDAO = new EmployerDAO();

        public FCompanySignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string address = txtProvince.Text + ", " + txtDistrict.Text + ", " + txtCommune.Text + ", " + txtStreet.Text + ", " + txtHome.Text;
            EmployerDTO emp = new EmployerDTO(txtName.Text, txtCompanyName.Text, txtPhone.Text, address, txtEmail.Text, txtIndustry.Text, txtLoginName.Text, txtPassword.Text);
            employerDAO.Add(emp);
        }
    }
}
