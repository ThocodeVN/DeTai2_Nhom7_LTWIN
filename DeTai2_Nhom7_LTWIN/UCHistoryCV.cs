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
    public partial class UCHistoryCV : UserControl
    {
        JobDTO jobDTO;
        ApplicationDTO appDTO;
        CvDTO cvDTO;
        public UCHistoryCV(JobDTO job, CvDTO cv, ApplicationDTO app)
        {
            InitializeComponent();
            this.jobDTO = job;
            this.appDTO = app;
            this.cvDTO = cv;
        }
    }
}
