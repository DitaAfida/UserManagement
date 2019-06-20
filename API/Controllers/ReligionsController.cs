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
    public class ReligionsController : ApiController
    {
        private MyContext db = new MyContext();
        //konstruktor
        public ReligionsController() { }
        //interface
        private readonly IReligionService iReligionService;
        //ini kontruktor
        public ReligionsController(IReligionService _iReligionService)
        {
            iReligionService = _iReligionService;
        }

        // GET: api/Religions
        public List<Religion> GetReligions()
        {
            return iReligionService.Get();
        }

        // GET: api/Religions/5
        public Religion GetReligionsType(int id)
        {
            return iReligionService.Get(id);
        }


        // PUT: api/Religions/5


        // POST: api/Religions
        public void InsertReligion(ReligionVM religionVM)
        {
            iReligionService.Insert(religionVM);
        }


        // DELETE: api/Religions/5

    }
}