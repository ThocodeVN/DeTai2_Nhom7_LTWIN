using DeTai2_Nhom7_LTWIN.DTO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Data.Entity.Core;

namespace DeTai2_Nhom7_LTWIN.DAO
{
    internal class ApplicationDAO
    {
        Detai2_DBEntities db = new Detai2_DBEntities();

        public List<ApplicationDTO> GetListApp(int jobID = 0, int CvID = 0)
        {
            List<Application> app = db.Applications.ToList();
            if (CvID == 0 && jobID != 0)
            {
                app = app.Where(e => e.JobID == jobID).ToList();
            }
            
            if (jobID == 0 && CvID != 0)
            {
                app = app.Where(e => e.CvID == CvID).ToList();
            }

            List<ApplicationDTO> list = new List<ApplicationDTO>();
            foreach (Application a in app)
            {
                ApplicationDTO appDTO = GetOneApp(a.AppID);
                list.Add(appDTO);
            }
            return list;
        }

        public void Add(ApplicationDTO ap)
        {
            try
            {
                Application app = new Application()
                {
                    JobID = ap.JobID,
                    CreateDate = ap.CreateDate,
                    CvID = ap.CvID
                };
                db.Applications.Add(app);
                db.SaveChanges();
                MessageBox.Show("Ứng tuyển thành công");
            }
            catch (Exception ex)
            {
                if (ex.InnerException is UpdateException update)
                {
                    // Xử lý lỗi ràng buộc unique ở đây
                    MessageBox.Show("Ứng tuyển thất bại \n Công việc này bạn đã nộp CV rồi!");
                }
                else
                {
                    MessageBox.Show("Ứng tuyển thất bại \n");
                }    
            }
        }

        public ApplicationDTO GetOneApp(int AppID = 0, int JobID = 0, int CvID = 0)
        {
            Application app;

            if (JobID != 0 && CvID != 0)
            {
                app = db.Applications.FirstOrDefault(e => e.JobID == JobID && e.CvID == CvID);
            }
            else
            {
                app = db.Applications.FirstOrDefault(e => e.AppID == AppID);
            }

            if (app == null)
            {
                MessageBox.Show("Ứng tuyển này không tồn tại");
                return null;
            }
            ApplicationDTO appDTO = new ApplicationDTO(app.CreateDate, app.JobID, app.CvID);
            appDTO.AppID = app.AppID;
            appDTO.State = (bool)app.State;
            return appDTO;
        }

        public void Browse(ApplicationDTO applicationDTO)
        {
            try
            {
                Application app = db.Applications.FirstOrDefault(e => e.AppID == applicationDTO.AppID);
                if (app == null)
                {
                    MessageBox.Show("Ứng tuyển này không tồn tại");
                    return;
                }
                app.State = applicationDTO.State;
                db.SaveChanges();
                MessageBox.Show("Duyệt thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Duyệt thất bại \n" + ex.Message);
            }
        }
    }
}
