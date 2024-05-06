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
    public partial class FCreateJob : Form
    {
        EmployerDTO empDTO;
        JobDAO jobDAO = new JobDAO();
        public FCreateJob(EmployerDTO empDTO)
        {
            InitializeComponent();
            this.empDTO = empDTO;
        }

        private void btnCreateJob_Click(object sender, EventArgs e)
        {
            string address = txtProvince.Text + ", " + txtDistrict.Text + ", " + txtCommune.Text + ", " + txtStreet.Text + ", " + txtHome.Text;
            JobDTO jobDTO = new JobDTO(txtJobName.Text, rtxtDescr.Text, rtxtRequire.Text,Convert.ToInt32(txtSalary.Text), address, empDTO.Id, dtpLastDate.Value, txtTimeWork.Text, rtxtBenefit.Text, rtxtAppLy.Text, cbxExp.Text, cbxType.Text, cbxEducation.Text);
            jobDAO.Create(jobDTO);
        }

    }
}
