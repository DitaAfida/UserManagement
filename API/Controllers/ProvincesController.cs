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
    public class ProvincesController : ApiController
    {
        private MyContext db = new MyContext();
        //konstruktor
        public ProvincesController() { }
        //interface
        private readonly IProvinceService iProvinceService;
        //ini kontruktor
        public ProvincesController(IProvinceService _iProvinceService)
        {
            iProvinceService = _iProvinceService;
        }

        // GET: api/Provinces
        public List<Province> GetProvinces()
        {
            return iProvinceService.Get();
        }

        // GET: api/Provinces/5
        public Province GetProvincesType(int id)
        {
            return iProvinceService.Get(id);
        }

        // PUT: api/Provinces/5


        // POST: api/Provinces
        public void InsertProvince(ProvinceVM provinceVM)
        {
            iProvinceService.Insert(provinceVM);
        }

        // DELETE: api/Provinces/5

    }
}