using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeTai2_Nhom7_LTWIN.DTO
{
    public class EmployerDTO
    {
        string id;
        string name;
        string companyName;
        string phone;
        string address;
        string email;
        string industry;
        string loginName;
        string password;

        public EmployerDTO(string id, string name, string companyName, string phone, string address, string email, string industry, string loginName, string password)
        {
            Id = id; 
            Name = name;
            CompanyName = companyName;
            Phone = phone;
            Address = address;
            Email = email;
            Industry = industry;
            LoginName = loginName;
            Password = password;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Industry { get => industry; set => industry = value; }
        public string LoginName { get => loginName; set => loginName = value; }
        public string Password { get => password; set => password = value; }
    }
}
