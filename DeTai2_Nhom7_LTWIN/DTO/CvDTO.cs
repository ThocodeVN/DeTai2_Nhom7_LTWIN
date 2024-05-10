using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeTai2_Nhom7_LTWIN.DTO
{
    public class CvDTO
    {
        int id;
        int canId;
        string title;
        string introduce;
        string education;
        string skill;
        string exp;
        string certificate;
        DateTime createDate;
        byte[] avatar;

        public CvDTO(int canId, string title, string introduce, string education, string skill, string exp, string certificate, DateTime createDate)
        {
            CanId = canId;
            Title = title;
            Introduce = introduce;
            Education = education;
            Skill = skill;
            Exp = exp;
            Certificate = certificate;
            CreateDate = createDate;
        }

        public int Id { get => id; set => id = value; }
        public int CanId { get => canId; set => canId = value; }
        public string Title { get => title; set => title = value; }
        public string Introduce { get => introduce; set => introduce = value; }
        public string Skill { get => skill; set => skill = value; }
        public string Certificate { get => certificate; set => certificate = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        public string Education { get => education; set => education = value; }
        public string Exp { get => exp; set => exp = value; }
        public byte[] Avatar { get => avatar; set => avatar = value; }
    }
}
