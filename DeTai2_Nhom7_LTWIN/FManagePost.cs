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
    public partial class FManagePost : Form
    {
        CandidateDTO canDTO;
        PostDAO postDAO = new PostDAO();
        public FManagePost(CandidateDTO canDTO)
        {
            InitializeComponent();
            this.canDTO = canDTO;
        }

        private void FManagePost_Load(object sender, EventArgs e)
        {
            fpnlPost.Controls.Clear();
            List<PostDTO> list = postDAO.GetListPost_Can(canDTO);
            foreach (var item in list)
            {
                UCPost uc = new UCPost(item);
                fpnlPost.Controls.Add(uc);
            }
        }
    }
}
