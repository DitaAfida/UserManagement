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
    public class RolesController : ApiController
    {
        private MyContext db = new MyContext();
        //ini kontruktor
        public RolesController() { }
        //interface
        private readonly IRoleService iRoleService;
        //ini kontruktor
        public RolesController(IRoleService _iRoleService)
        {
            iRoleService = _iRoleService;
        }

        // GET: api/Roles
        public List<Role> GetRoles()
        {
            return iRoleService.Get();
        }

        // GET: api/Roles/5
        //get by id 
        public Role GetRolesType(int id)
        {
            return iRoleService.Get(id);
        }
        

        // PUT: api/Roles/5
        

        // POST: api/Roles
        //untuk menginput data
        public void InsertRole(RoleVM roleVM)
        {
            iRoleService.Insert(roleVM);
        }
        

        // DELETE: api/Roles/5
        
    }
}