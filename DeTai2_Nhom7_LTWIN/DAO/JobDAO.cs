using DeTai2_Nhom7_LTWIN.DTO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace DeTai2_Nhom7_LTWIN.DAO
{
    internal class JobDAO
    {
        Detai2_DBEntities db = new Detai2_DBEntities();

        public List<JobDTO> GetListJob()
        {
            List<Job> listJob = db.Jobs.ToList();
            List<JobDTO> listJobDTO = new List<JobDTO>();   
            foreach (Job job in listJob)
            {
                JobDTO j = getOneJob(job.JobID);
                listJobDTO.Add(j);
            }
            return listJobDTO;
        }

        public void Create(JobDTO job)
        {
            try
            {
                Job jb = new Job()
                {
                    EmpID = job.EmpID,
                    Title = job.Title,
                    Description = job.Description,
                    Require = job.Require,
                    Salary = job.Salary,
                    Location = job.Locaton,
                    LastDate = job.LastDate,
                    TimeWork = job.TimeWork,
                    Benefit = job.Benefit,
                    HowApply = job.HowApply,
                    ReqExperience = job.Experience,
                    Type = job.Type,
                    Education = job.Education
                };
                db.Jobs.Add(jb);
                db.SaveChanges();
                MessageBox.Show("Tạo công việc thành công");
            }
            catch (Exception e)
            {
                MessageBox.Show("Tạo công việc thất bại \n " + e.Message);
            }
        }

        public void Update(JobDTO job)
        {
            try
            {
                Job jb = db.Jobs.FirstOrDefault(e => e.JobID == job.JobID);
                jb.EmpID = job.EmpID;
                jb.Title = job.Title;
                jb.Description = job.Description;
                jb.Require = job.Require;
                jb.Salary = job.Salary;
                jb.Location = job.Locaton;
                jb.LastDate = job.LastDate;
                jb.TimeWork = job.TimeWork;
                jb.Benefit = job.Benefit;
                jb.HowApply = job.HowApply;
                jb.ReqExperience = job.Experience;
                jb.Type = job.Type;
                jb.Education = job.Education;
                db.SaveChanges();
                MessageBox.Show("Cập nhật thành công");
            }
            catch(Exception e)
            {
                MessageBox.Show("Cập nhật thất bại \n " + e.Message);
            }
        }

        public void Delete(JobDTO job)
        {
            try
            {
                Job jb = db.Jobs.FirstOrDefault(e => e.JobID == job.JobID);
                if(jb == null)
                {
                    MessageBox.Show("Không tìm thấy công việc này");
                    return;
                }
                db.Jobs.Remove(jb);
                db.SaveChanges();
                MessageBox.Show("Xóa thành công");
            }
            catch
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        public JobDTO getOneJob(int ID)
        {
            Job jb = db.Jobs.FirstOrDefault(e => e.JobID == ID);
            if (jb != null)
            {
                JobDTO job = new JobDTO(jb.Title, jb.Description, jb.Require, Convert.ToInt32(jb.Salary), jb.Location, jb.EmpID, jb.LastDate, jb.TimeWork, jb.Benefit, jb.HowApply, jb.ReqExperience, jb.Type, jb.Education);
                job.JobID = jb.JobID;
                return job;
            }
            else
            { return null; }
        }

    }
}
