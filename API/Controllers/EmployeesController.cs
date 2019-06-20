using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DataAccess.Context;
using DataAccess.Models;
using BusinessLogic.Service;
using DataAccess.ViewModels;

namespace API.Controllers
{
    public class EmployeesController : ApiController
    {
        private MyContext db = new MyContext();
        //konstruktor
        public EmployeesController() { }
        //interface
        private readonly IEmployeeService iEmployeeService;
        //ini kontruktor
        public EmployeesController(IEmployeeService _iEmployeeService)
        {
            iEmployeeService = _iEmployeeService;
        }


        // GET: api/Employees
        public List<Employee> GetEmployees()
        {
            return iEmployeeService.Get();
        }

        // GET: api/Employees/5
        public Employee GetEmployeesType(int id)
        {
            return iEmployeeService.Get(id);
        }


        // PUT: api/Employees/5


        // POST: api/Employees
        //untuk insert
        public void InsertEmployee(EmployeeVM employeeVM)
        {
            iEmployeeService.Insert(employeeVM);
        }


        // DELETE: api/Employees/5

    }
}