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

namespace DeTai2_Nhom7_LTWIN.DAO
{
    internal class EmployerDAO
    {
        Detai2_DBEntities db = new Detai2_DBEntities();

        public List<EmployerDTO> GetListEmp()
        {
            List<Employer> emp = db.Employers.ToList();
            List<EmployerDTO> listEmpDTO = new List<EmployerDTO>();
            foreach (Employer e in emp)
            {
                EmployerDTO em = GetOneEmp(e.ID);
                listEmpDTO.Add(em);
            }
            return listEmpDTO;
        }

        public void Add(EmployerDTO employer)
        {
            try
            {
                Employer emp = new Employer
                {
                    Name = employer.Name,
                    CompanyName = employer.CompanyName,
                    Phone = employer.Phone,
                    Address = employer.Address,
                    Email = employer.Email,
                    Industry = employer.Industry,
                    LoginName = employer.LoginName,
                    Password = employer.Password,
                };
                db.Employers.Add(emp);
                db.SaveChanges();
                MessageBox.Show("Đăng kí thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng kí thất bại \n" + ex.Message);
            }
        }

        public void Update(EmployerDTO employer)
        {
            try
            {
                Employer emp = db.Employers.FirstOrDefault(e => e.ID == employer.Id);
                emp.Name = employer.Name;
                emp.CompanyName = employer.CompanyName;
                emp.Phone = employer.Phone;
                emp.Address = employer.Address;
                emp.Email = employer.Email;
                emp.Industry = employer.Industry;
                emp.LoginName = employer.LoginName;
                emp.Password = employer.Password;
                db.SaveChanges();
                MessageBox.Show("Cập nhật thành công thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại \n" + ex.Message);
            }
        }

        public EmployerDTO CheckAcc(string loginName, string password)
        {
            Employer emp = db.Employers.FirstOrDefault(e => e.LoginName == loginName && e.Password == password);
            if (emp != null)
            {
                return GetOneEmp(emp.ID);
            }
            else
            {
                return null;
            }
        }

        public EmployerDTO GetOneEmp(int ID)
        {
            Employer emp = db.Employers.FirstOrDefault(e => e.ID == ID);
            if (emp != null)
            {
                EmployerDTO empDTO = new EmployerDTO(emp.Name, emp.CompanyName, emp.Phone, emp.Address, emp.Email, emp.Industry, emp.LoginName, emp.Password);
                empDTO.Id = emp.ID;
                return empDTO;
            }
            else
            {
                MessageBox.Show("Nhà tuyển dụng này không tồn tại");
                return null;
            }
        }
    }
}
