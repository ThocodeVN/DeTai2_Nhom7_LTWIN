using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeTai2_Nhom7_LTWIN.DTO
{
    public   class JobDTO
    {
        private int jobID;
        private string title;
        private string description;
        private string require;
        private int salary;
        private string locaton;
        private int empID;
        private DateTime lastDate;
        private string timeWork;
        private string benefit;
        private string howApply;
        private string experience;
        private string type;
        private string education;


        public JobDTO(string title, string description, string require, int salary, string locaton, int empID, DateTime date, string timeWork, string benefit, string howApply, string experience, string type, string education)
        {
            Title = title;
            Description = description;
            Require = require;
            Salary = salary;
            Locaton = locaton;
            EmpID = empID;
            LastDate = date;
            TimeWork = timeWork;
            Benefit = benefit;
            HowApply = howApply;
            Experience = experience;
            Type = type;
            Education = education;
        }

        public int JobID { get => jobID; set => jobID = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string Require { get => require; set => require = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Locaton { get => locaton; set => locaton = value; }
        public int EmpID { get => empID; set => empID = value; }
        public DateTime LastDate { get => lastDate; set => lastDate = value; }
        public string TimeWork { get => timeWork; set => timeWork = value; }
        public string Benefit { get => benefit; set => benefit = value; }
        public string HowApply { get => howApply; set => howApply = value; }
        public string Experience { get => experience; set => experience = value; }
        public string Type { get => type; set => type = value; }
        public string Education { get => education; set => education = value; }
    }
}
