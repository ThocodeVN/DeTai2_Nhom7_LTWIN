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
    public partial class FCompanyUI : Form
    {
        EmployerDTO empDTO;
        JobDAO job = new JobDAO();
        public FCompanyUI(EmployerDTO employerDTO)
        {
            InitializeComponent();
            this.empDTO = employerDTO;
        }
    }
}
