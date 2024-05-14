using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeTai2_Nhom7_LTWIN.DTO
{
    public class PostDTO
    {
        int id;
        int canID;
        int cvID;
        string content;
        DateTime createDate;
        byte[] picture;

        public PostDTO(int canID, int cvID, string content, DateTime createDate)
        {
            CanID = canID;
            CvID = cvID;
            Content = content;
            CreateDate = createDate;
        }

        public int Id { get => id; set => id = value; }
        public int CanID { get => canID; set => canID = value; }
        public int CvID { get => cvID; set => cvID = value; }
        public string Content { get => content; set => content = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        public byte[] Picture { get => picture; set => picture = value; }
    }
}
