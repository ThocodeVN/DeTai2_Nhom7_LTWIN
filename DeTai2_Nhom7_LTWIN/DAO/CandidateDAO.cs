using DeTai2_Nhom7_LTWIN.DTO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DeTai2_Nhom7_LTWIN.DAO
{
    internal class CandidateDAO
    {
        Detai2_DBEntities db = new Detai2_DBEntities(); 
        public List<CandidateDTO> GetListCan()
        {
            List<Candidate> can = db.Candidates.ToList();
            List<CandidateDTO > list = new List<CandidateDTO>();
            foreach(Candidate c in can)
            {
                CandidateDTO cn = GetOneCandi(c.ID);
                list.Add(cn);
            }    
            return list;
        }

        public void Add(CandidateDTO cand)
        {
            try
            {
                Candidate can = new Candidate()
                {
                    Name = cand.Name,
                    Sex = cand.Sex,
                    Birth = cand.Birth,
                    Phone = cand.Phone,
                    Email = cand.Email,
                    Address = cand.Address,
                    LoginName = cand.AccName,
                    Password = cand.Password
                };
                db.Candidates.Add(can);
                db.SaveChanges();
                MessageBox.Show("Đăng kí thành công");
                db.GetValidationErrors();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Đăng kí thất bại \n" + ex.Message);
            }
        }
        public void UpdateInfor(CandidateDTO canDTO)
        {
            try
            {
                Candidate can = new Candidate()
                {
                    Name = canDTO.Name,
                    Sex = canDTO.Sex,
                    Birth = canDTO.Birth,
                    Phone = canDTO.Phone,
                    Email = canDTO.Email,
                    Address = canDTO.Address,
                    LoginName = canDTO.AccName,
                    Password = canDTO.Password,
                    Avatar = canDTO.Avatar
                };
                db.SaveChanges();
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại \n" + ex.Message);
            }
        }

        public CandidateDTO CheckAcc(string accName, string password)
        {
            Candidate can = db.Candidates.FirstOrDefault(e => e.LoginName == accName && e.Password == password);
            if (can != null)
            {
                return GetOneCandi(can.ID);
            }
            else
            {
                return null;
            }
        }

        public CandidateDTO GetOneCandi(int ID)
        {
            Candidate cn = db.Candidates.FirstOrDefault(e => e.ID == ID);
            if (cn == null)
            {
                MessageBox.Show("Ứng viên này không tồn tại");
                return null;
            }
            CandidateDTO Can = new CandidateDTO(cn.Name, cn.Sex, cn.Birth, cn.Phone, cn.Email, cn.Address, cn.LoginName, cn.Password);
            Can.CanID = cn.ID;
            return Can;
        }

    }
}
