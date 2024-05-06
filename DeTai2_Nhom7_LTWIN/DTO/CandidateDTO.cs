using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeTai2_Nhom7_LTWIN.DTO
{
    public class CandidateDTO
    {
        private int canID;
        private string name;
        private string sex;
        private DateTime birth;
        private string email;
        private string phone;
        private string address;
        private string accName;
        private string password;

        public CandidateDTO(string name, string sex, DateTime birth, string phone, string email, string address, string loginName, string password)
        {
            Name = name;
            Sex = sex;
            Birth = birth;
            Phone = phone;
            Email = email;
            Address = address;
            accName = loginName;
            Password = password;
        }

        public int CanID { get => canID; set => canID = value; }
        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string AccName { get => accName; set => accName = value; }
        public string Password { get => password; set => password = value; }
    }
}