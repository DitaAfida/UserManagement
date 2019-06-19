using Common.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace BusinessLogic.Service.Application
{
    public class DepartmentService : IDepartementService
    {
        public DepartmentService() { }
        private readonly IDepartmentRepository iDepartmentRepository;
        public DepartmentService(IDepartmentRepository _iDepartmentRepositoy)
        {
            iDepartmentRepository = _iDepartmentRepositoy;
        }
        bool status = false;

        public List<Department> Get()
        {
            return iDepartmentRepository.Get();
        }

        public List<Department> GetSearch(string values)
        {
            return iDepartmentRepository.GetSearch(values);
        }

        public Department Get(int id)
        {
            return iDepartmentRepository.Get(id);
        }

        public bool Insert(DepartmentVM departmentVM)
        {
            if (string.IsNullOrWhiteSpace(departmentVM.Department_Name))
            {
                return status;
            }
            else
            {
                return iDepartmentRepository.Insert(departmentVM);
            }
        }

        public bool Update(int id, DepartmentVM departmentVM)
        {
            return iDepartmentRepository.Update(id, departmentVM);
        }

        public bool Delete(int id)
        {
            return iDepartmentRepository.Delete(id);
        }
    }
}
