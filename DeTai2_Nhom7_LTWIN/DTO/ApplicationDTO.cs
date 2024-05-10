using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeTai2_Nhom7_LTWIN.DTO
{
    public class ApplicationDTO
    {
        private int appID;
        private DateTime createDate;
        private int jobID;
        private int cvID;
        private bool state;

        public ApplicationDTO(DateTime createDate, int jobID, int cvID)
        {
            JobID = jobID;
            CreateDate = createDate;
            CvID = cvID;
            State = false;
        }

        public DateTime CreateDate { get => createDate; set => createDate = value; }
        public int JobID { get => jobID; set => jobID = value; }
        public int CvID { get => cvID; set => cvID = value; }
        public int AppID { get => appID; set => appID = value; }
        public bool State { get => state; set => state = value; }
    }
}
