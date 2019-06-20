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
    public class RegenciesController : ApiController
    {
        private MyContext db = new MyContext();
        //konstruktor
        public RegenciesController() { }
        //interface
        private readonly IRegencyService iRegencyService;
        //ini kontruktor
        public RegenciesController(IRegencyService _iRegencyService)
        {
            iRegencyService = _iRegencyService;
        }

        // GET: api/Regencies
        public List<Regency> GetRegencys()
        {
            return iRegencyService.Get();
        }

        // GET: api/Regencies/5
        public Regency GetRegenciesType(int id)
        {
            return iRegencyService.Get(id);
        }


        // PUT: api/Regencies/5


        // POST: api/Regencies
        public void Insertregency(RegencyVM regencyVM)
        {
            iRegencyService.Insert(regencyVM);
        }


        // DELETE: api/Regencies/5



    }
}