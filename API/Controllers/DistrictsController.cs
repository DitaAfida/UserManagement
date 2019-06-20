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
    public class DistrictsController : ApiController
    {
        private MyContext db = new MyContext();
        //konstruktor
        public DistrictsController() { }
        //interface
        private readonly IDistrictService iDistrictService;
        //ini kontruktor
        public DistrictsController(IDistrictService _iDistrictService)
        {
            iDistrictService = _iDistrictService;
        }

        // GET: api/Districts
        public List<District> GetDistricts()
        {
            return iDistrictService.Get();
        }

        // GET: api/Districts/5
        public District GetDistrictsType(int id)
        {
            return iDistrictService.Get(id);
        }

        // PUT: api/Districts/5


        // POST: api/Districts
        public void InsertDistrict(DistrictVM districtVM)
        {
            iDistrictService.Insert(districtVM);
        }


        // DELETE: api/Districts/5



    }
}