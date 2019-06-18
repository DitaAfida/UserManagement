using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Employee")]
    public class Employee : BaseModel
    {
        public string Employee_Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Marital_Status { get; set; }
        public string Phone_Number { get; set; }
        public DateTimeOffset Joindate { get; set; }
        public string Employment_status { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }

        [ForeignKey("Department")]
        public int Department_Id { get; set; }
        public Department Department { get; set; }

        [ForeignKey("Village")]
        public int Village_Id { get; set; }
        public Village Village { get; set; }

        [ForeignKey("Position")]
        public int Position_Id { get; set; }
        public Position Position { get; set; }

        [ForeignKey("Religion")]
        public int Religion_Id { get; set; }
        public Religion Religion { get; set; }

        public Employee() { }

        public Employee(EmployeeVM employeeVM)
        {
            this.Employee_Name = employeeVM.Employee_Name;
            this.Address = employeeVM.Address;
            this.Gender = employeeVM.Gender;
            this.Marital_Status = employeeVM.Marital_Status;
            this.Phone_Number = employeeVM.Phone_Number;
            this.Joindate = employeeVM.Joindate;
            this.Employment_status = employeeVM.Employment_status;
            this.Email = employeeVM.Email;
            this.Salary = employeeVM.Salary;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(EmployeeVM employeeVM)
        {
            this.Id = employeeVM.Id;
            this.Employee_Name = employeeVM.Employee_Name;
            this.Address = employeeVM.Address;
            this.Gender = employeeVM.Gender;
            this.Marital_Status = employeeVM.Marital_Status;
            this.Phone_Number = employeeVM.Phone_Number;
            this.Joindate = employeeVM.Joindate;
            this.Employment_status = employeeVM.Employment_status;
            this.Email = employeeVM.Email;
            this.Salary = employeeVM.Salary;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
