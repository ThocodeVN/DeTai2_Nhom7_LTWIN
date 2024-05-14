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
    public partial class FViewPost : Form
    {
        PostDAO postDAO = new PostDAO();
        public FViewPost()
        {
            InitializeComponent();
        }

        private void FViewPost_Load(object sender, EventArgs e)
        {
            fpnlPost.Controls.Clear();
            List<PostDTO> list = postDAO.GetListPost();
            foreach (PostDTO post in list)
            {
                UCPost uc = new UCPost(post);
                fpnlPost.Controls.Add(uc);
            }
        }

        private void fpnlPost_ControlAdded(object sender, ControlEventArgs e)
        {
            fpnlPost_Resize();
        }

        private void fpnlPost_Resize()
        {
            if (fpnlPost.Controls.Count == 1)
            {
                fpnlPost.Size = new Size(fpnlPost.Controls[0].Size.Width + 5, 555);

            }

            if (fpnlPost.Controls.Count > 1 && fpnlPost.Controls.Count < 3)
            {
                fpnlPost.Size = new Size(fpnlPost.Controls[0].Size.Width * 2 + 30, 555);
            }

            if (fpnlPost.Controls.Count >= 3)
            {
                fpnlPost.Size = new Size(fpnlPost.Controls[0].Size.Width * 3 + 50, 555);
            }

            int x = (this.Size.Width - fpnlPost.Size.Width) / 2;
            fpnlPost.Location = new Point(x, fpnlPost.Location.Y);
        }
    }
}
