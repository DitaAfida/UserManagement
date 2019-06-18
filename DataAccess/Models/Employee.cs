using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Employee")]
    public class Employee
    {
        public int Id { get; set; }
        public string Employee_Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Religion { get; set; }
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
    }
}
