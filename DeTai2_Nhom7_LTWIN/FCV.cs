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
    public partial class FCV : Form
    {
        CandidateDTO canDTO;
        JobDTO jobDTO;
        public FCV(CandidateDTO canDTO, JobDTO jobDTO)
        {
            InitializeComponent();
            this.canDTO = canDTO;
            this.jobDTO = jobDTO;
        }
    }
}
