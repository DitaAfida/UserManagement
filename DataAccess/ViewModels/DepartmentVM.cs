using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class DepartmentVM
    {
        public int Id { get; set; }
        public string Department_Name { get; set; }

        public DepartmentVM() { }

        public DepartmentVM ( string department_name)
        {
            this.Department_Name = department_name;
        }

        public void Update ( int id, string department_name)
        {
            this.Id = id;
            this.Department_Name = department_name;
        }
    }
}
