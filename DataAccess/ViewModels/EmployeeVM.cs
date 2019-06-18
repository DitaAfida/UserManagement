using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string Employee_Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Marital_Status { get; set; }
        public string Phone_Number { get; set; }
        public DateTimeOffset Joindate { get; set; }
        public string Employment_status { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }

        public int Department_Id { get; set; }
        public int Village_Id { get; set; }
        public int Position_Id { get; set; }
        public int Religion_Id { get; set; }

        public EmployeeVM() { }

        public EmployeeVM(string employee_name, string address, string gender,string marital_status, string phone_number, 
            DateTimeOffset joindate, string employment_status, string email, decimal salary, int department_id, int village_id, int position_id, int religion_id)
        {
            this.Employee_Name = employee_name;
            this.Address = address;
            this.Gender = gender;
            this.Marital_Status = marital_status;
            this.Phone_Number = phone_number;
            this.Joindate = joindate;
            this.Employment_status = employment_status;
            this.Email = email;
            this.Salary = salary;
            this.Department_Id = department_id;
            this.Village_Id = village_id;
            this.Position_Id = position_id;
            this.Religion_Id = religion_id;
        }

        public void Update (string employee_name, string address, string gender, string marital_status, string phone_number,
            DateTimeOffset joindate, string employment_status, string email, decimal salary, int department_id, int village_id, int position_id, int religion_id)
        {
            this.Employee_Name = employee_name;
            this.Address = address;
            this.Gender = gender;
            this.Marital_Status = marital_status;
            this.Phone_Number = phone_number;
            this.Joindate = joindate;
            this.Employment_status = employment_status;
            this.Email = email;
            this.Salary = salary;
            this.Department_Id = department_id;
            this.Village_Id = village_id;
            this.Position_Id = position_id;
            this.Religion_Id = religion_id;
        }
    }
}
