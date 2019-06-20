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
    public class UsersController : ApiController
    {
        private MyContext db = new MyContext();
        //konstruktor
        public UsersController() { }
        //interface
        private readonly IUserService iUserService;
        //ini kontruktor
        public UsersController(IUserService _iUserService)
        {
            iUserService = _iUserService;
        }

        // GET: api/Users
        public List<User> GetUsers()
        {
            return iUserService.Get();
        }

        // GET: api/Users/5
        public User GetUsersType(int id)
        {
            return iUserService.Get(id);
        }


        // PUT: api/Users/5


        // POST: api/Users
        public void InsertUser(UserVM userVM)
        {
            iUserService.Insert(userVM);
        }


        // DELETE: api/Users/5

    }
}