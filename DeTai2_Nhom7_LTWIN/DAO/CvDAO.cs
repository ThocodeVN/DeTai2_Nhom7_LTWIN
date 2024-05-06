using DeTai2_Nhom7_LTWIN.DTO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DeTai2_Nhom7_LTWIN.DAO
{
    internal class CvDAO
    {
        Detai2_DBEntities db = new Detai2_DBEntities();
        public List<CvDTO> GetListCV()
        {
            List<CV> cv = db.CVs.ToList();
            List<CvDTO> listCv = new List<CvDTO>();
            foreach (CV c in cv)
            {
                CvDTO cV = GetOneCVFollowCvID(c.Id);
                listCv.Add(cV);
            }    
            return listCv;
        }

        public List<CvDTO> GetListCV_Can(CandidateDTO can)
        {
            List<CV> cv = db.CVs.ToList();
            List<CvDTO> listCv = new List<CvDTO>();
            var query = from q in db.CVs select q;
            query = query.Where(e => e.CanID == can.CanID);
            foreach (var c in query)
            {
                CvDTO cV = GetOneCVFollowCvID(c.Id);
                listCv.Add(cV);
            }
            return listCv;
        }

        public void Add(CvDTO cvDTO)
        {
            try
            {
                CV cv = new CV()
                {
                    CanID = cvDTO.CanId,
                    Title = cvDTO.Title,
                    Introduce = cvDTO.Introduce,
                    Education = cvDTO.Education,
                    Skills = cvDTO.Skill,
                    Exp = cvDTO.Exp,
                    Certificate = cvDTO.Certificate,
                    CreateDate = cvDTO.CreateDate
                };
                MessageBox.Show("Tạo CV thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tạo CV thất bại \n" + ex.Message);
            }
        }

        public CvDTO GetOneCVFollowCvID(int cvID)
        {
            CV cv = db.CVs.FirstOrDefault(e => e.Id == cvID);
            if (cv == null)
            {
                MessageBox.Show("Ứng viên này không tồn tại");
                return null;
            }
            CvDTO c = new CvDTO(cv.CanID, cv.Title, cv.Introduce, cv.Education, cv.Skills, cv.Exp, cv.Education, cv.CreateDate);
            c.Id = cv.Id;
            return c;
        }
    }
}
