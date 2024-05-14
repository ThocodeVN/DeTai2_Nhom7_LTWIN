using DeTai2_Nhom7_LTWIN.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai2_Nhom7_LTWIN.DAO
{
    internal class PostDAO
    {
        Detai2_DBEntities db = new Detai2_DBEntities();

        public void Add(PostDTO postDTO)
        {
            try
            {
                Post post = new Post()
                {
                    CanID = postDTO.CanID,
                    CvID = postDTO.CvID,
                    CreateDate = postDTO.CreateDate,
                    Picture = postDTO.Picture,
                    Content = postDTO.Content
                };
                db.Posts.Add(post);
                db.SaveChanges();
                MessageBox.Show("Đăng thành công");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Đăng thất bại \n" + ex.InnerException.Message);
            }
        }

        public List<PostDTO> GetListPost()
        {
            List<Post> list = db.Posts.ToList();
            List<PostDTO> listDTO = new List<PostDTO>();
            foreach (var c in list)
            {
                PostDTO post = GetOnePost(c.ID);
                listDTO.Add(post);
            }
            return listDTO;
        }

        public List<PostDTO> GetListPost_Can(CandidateDTO can)
        {
            List<PostDTO> listDTO = new List<PostDTO>();
            var query = from q in db.Posts select q;
            query = query.Where(e => e.CanID == can.CanID);
            foreach (var c in query)
            {
                PostDTO post = GetOnePost(c.ID);
                listDTO.Add(post);
            }
            return listDTO;
        }

        public PostDTO GetOnePost(int ID)
        {
            Post post = db.Posts.FirstOrDefault(e => e.ID == ID);
            if (post == null)
            {
                MessageBox.Show("Bài đăng này không tồn tại");
                return null;
            }
            PostDTO postDTO = new PostDTO(Convert.ToInt32(post.CanID), Convert.ToInt32(post.CvID), post.Content, Convert.ToDateTime(post.CreateDate));
            postDTO.Picture = post.Picture;
            return postDTO;
        }
    }
}
