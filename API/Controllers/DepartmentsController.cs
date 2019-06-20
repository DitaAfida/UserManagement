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
    public class DepartmentsController : ApiController
    {
        private MyContext db = new MyContext();
        //konstruktor
        public DepartmentsController() { }
        //interface
        private readonly IDepartmentService iDepartmentService;
        //ini kontruktor
        public DepartmentsController(IDepartmentService _iDepartmentService)
        {
            iDepartmentService = _iDepartmentService;
        }

        // GET: api/Departments
        public List<Department> GetDepartments()
        {
            return iDepartmentService.Get();
        }

        // GET: api/Departments/5
        //get data berdasarkan id 
        public Department GetDepartmentsType(int id)
        {
            return iDepartmentService.Get(id);
        }

        // PUT: api/Departments/5

        // POST: api/Departments
        //untuk insert 
        public void InsertDepartment(DepartmentVM departmentVM)
        {
            iDepartmentService.Insert(departmentVM);
        }

        // DELETE: api/Departments/5


    }
}