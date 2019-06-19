using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public interface IDepartmentRepository
    {
        List<Department> Get();
        List<Department> GetSearch(string values);
        Department Get(int id);
        bool Insert(DepartmentVM departmentVM);
        bool Update(int id, DepartmentVM departmentVM);
        bool Delete(int id);
    }
}
