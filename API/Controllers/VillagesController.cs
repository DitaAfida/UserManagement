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
    public class VillagesController : ApiController
    {
        private MyContext db = new MyContext();
        public VillagesController() { }
        //interface
        private readonly IVillageService iVillageService;
        //ini kontruktor
        public VillagesController(IVillageService _iVillageService)
        {
            iVillageService = _iVillageService;
        }

        // GET: api/Villages
        public List<Village> GetVillages()
        {
            return iVillageService.Get();
        }

        // GET: api/Villages/5
        public Village GetVillagesType(int id)
        {
            return iVillageService.Get(id);
        }


        // PUT: api/Villages/5


        // POST: api/Villages
        public void InsertVillage(VillageVM villageVM)
        {
            iVillageService.Insert(villageVM);
        }


        // DELETE: api/Villages/5




    }
}