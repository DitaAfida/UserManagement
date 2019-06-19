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
    public class EmployeeService : IEmployeeService
    {
        public EmployeeService() { }
        private readonly IEmployeeRepository iEmployeeRepository;
        public EmployeeService(IEmployeeRepository _iEmployeeRepositoy)
        {
            iEmployeeRepository = _iEmployeeRepositoy;
        }
        bool status = false;

        public List<Employee> Get()
        {
            return iEmployeeRepository.Get();
        }

        public List<Employee> GetSearch(string values)
        {
            return iEmployeeRepository.GetSearch(values);
        }

        public Employee Get(int id)
        {
            return iEmployeeRepository.Get(id);
        }

        public bool Insert(EmployeeVM employeeVM)
        {
            if (string.IsNullOrWhiteSpace(employeeVM.Employee_Name) ||
                string.IsNullOrWhiteSpace(employeeVM.Address.ToString()) ||
                string.IsNullOrWhiteSpace(employeeVM.Gender.ToString()) ||
                string.IsNullOrWhiteSpace(employeeVM.Religion_Id.ToString()) ||
                string.IsNullOrWhiteSpace(employeeVM.Marital_Status.ToString()) ||
                string.IsNullOrWhiteSpace(employeeVM.Phone_Number.ToString())||
                string.IsNullOrWhiteSpace(employeeVM.Joindate.ToString()) ||
                string.IsNullOrWhiteSpace(employeeVM.Employment_status.ToString()) ||
                string.IsNullOrWhiteSpace(employeeVM.Email.ToString()) ||
                string.IsNullOrWhiteSpace(employeeVM.Salary.ToString()) ||
                string.IsNullOrWhiteSpace(employeeVM.Department_Id.ToString())||
                string.IsNullOrWhiteSpace(employeeVM.Village_Id.ToString()) ||
                string.IsNullOrWhiteSpace(employeeVM.Position_Id.ToString()))
            {
                return status;
            }
            else
            {
                return iEmployeeRepository.Insert(employeeVM);
            }
        }

        public bool Update(int id, EmployeeVM employeeVM)
        {
            return iEmployeeRepository.Update(id, employeeVM);
        }

        public bool Delete(int id)
        {
            return iEmployeeRepository.Delete(id);
        }
    }
}
