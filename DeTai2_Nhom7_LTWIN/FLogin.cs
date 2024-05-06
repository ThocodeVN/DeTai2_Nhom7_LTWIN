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
    public partial class FLogin : Form
    {     
        EmployerDAO empDAO = new EmployerDAO();
        CandidateDAO canDAO = new CandidateDAO();
        EmployerDTO empDTO;
        CandidateDTO canDTO;

        public FLogin()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form dk;
            if (rbtnFirm.Checked)
            {
                dk = new FCompanySignUp();
            }
            else if (rbtnUser.Checked)
                dk = new FUserSignUp();
            else
                return;
            this.Hide();
            dk.ShowDialog();
            this.Show();
        }
   
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form lg;
            if (rbtnFirm.Checked)
            {
                empDTO = empDAO.CheckAcc(txtLoginName.Text, txtPassword.Text);

                if (empDTO == null)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                    return;
                }
                else
                {
                    lg = new FCompanyUI(empDTO);
                    this.Hide();
                    lg.ShowDialog();
                    this.Show();
                }
            }

            if (rbtnUser.Checked)
            {
                canDTO = canDAO.CheckAcc(txtLoginName.Text, txtPassword.Text);
                if (canDTO == null)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                    return;
                }
                else
                {
                    lg = new FUserUI(canDTO);
                    this.Hide();
                    lg.ShowDialog();
                    this.Show();
                }
            }

            if (!rbtnFirm.Checked && !rbtnUser.Checked)
            {
                MessageBox.Show("Hãy chọn đối tượng đăng nhập");
                return;
            }
        }
    }
}
