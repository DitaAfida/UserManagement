using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using DataAccess.Context;
using System.Data.Entity;

namespace Common.Repository.Application
{
    public class EmployeeRepository : IEmployeeRepository
    {
        MyContext myContext = new MyContext();
        bool status = false;
        public bool Delete(int id)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Delete();
                myContext.Entry(get).State = EntityState.Modified;
                var result = myContext.SaveChanges();
                return result > 0;
            }
            else
            {
                return false;
            }
        }

        public List<Employee> Get()
        {
            var get = myContext.Employees.Include("Village").Include("Village.District").Include("Village.District.Regency").Include("Village.District.Regency.Province").Include("Position").Include("Department").Include("Religion").Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Employee Get(int id)
        {
            var get = myContext.Employees.Find(id);
            return get;
        }

        public List<Employee> GetSearch(string values)
        {
            var get = myContext.Employees.Include("Village").Include("Village.District").Include("Village.District.Regency").Include("Village.District.Regency.Province").Include("Position").Include("Department").Include("Religion").Where(x => (x.Employee_Name.Contains(values) ||
                   x.Id.ToString().Contains(values) || x.Village.Village_Name.Contains(values) ||x.Village.District.District_Name.Contains(values) || x.Village.District.Regency.Regency_Name.Contains(values) || 
                   x.Village.District.Regency.Province.Province_Name.Contains(values) || x.Position.Position_Name.Contains(values) || x.Department.Department_Name.Contains(values) || x.Religion.Name.Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(EmployeeVM employeeVM)
        {
            var push = new Employee(employeeVM);
            var getDepartmentId = myContext.Departments.Find(employeeVM.Department_Id);
            push.Department = getDepartmentId;
            var getPositionId = myContext.Positions.Find(employeeVM.Position_Id);
            push.Position = getPositionId;
            var getVillageId = myContext.Villages.Find(employeeVM.Village_Id);
            push.Village = getVillageId;
            var getReligionId = myContext.Religions.Find(employeeVM.Religion_Id);
            push.Religion = getReligionId;
            myContext.Employees.Add(push);
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }

        public bool Update(int id, EmployeeVM employeeVM)
        {
            var put = Get(id);
            var getDepartmentId = myContext.Departments.Find(employeeVM.Department_Id);
            put.Department = getDepartmentId;
            var getPositionId = myContext.Positions.Find(employeeVM.Position_Id);
            put.Position = getPositionId;
            var getVillageId = myContext.Villages.Find(employeeVM.Village_Id);
            put.Village = getVillageId;
            put.Update(employeeVM);
            myContext.Entry(put).State = EntityState.Modified;
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }
    }
}
