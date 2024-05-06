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
    public partial class UCCompanyInfor : UserControl
    {
        EmployerDTO emp;
        public UCCompanyInfor(EmployerDTO emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        private void UCCompanyInfor_Load(object sender, EventArgs e)
        {
            txtName.Text = emp.Name;
            txtCompanyName.Text = emp.CompanyName;
            txtEmail.Text = emp.Email;
            txtPhone.Text = emp.Phone;
            txtIndustry.Text = emp.Industry;
            txtLoginName.Text = emp.LoginName;
            txtPassword.Text = emp.Password;
            txtAddress.Text = emp.Address;
        }
    }
}
