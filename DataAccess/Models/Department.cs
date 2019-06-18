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
    [Table("TB_M_Department")]
    public class Department : BaseModel
    {
        public string Department_Name { get; set; }

        public Department() { }

        public Department(DepartmentVM departmentVM)
        {
            this.Department_Name = departmentVM.Department_Name;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update (DepartmentVM departmentVM)
        {
            this.Id = departmentVM.Id;
            this.Department_Name = departmentVM.Department_Name;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }

    }
}
