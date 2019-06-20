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
    public class AplicationsController : ApiController
    {
        private MyContext db = new MyContext();
        //konstruktor
        public AplicationsController() { }
        //interface
        private readonly IAplicationService iAplicationService;
        //ini kontruktor
        public AplicationsController(IAplicationService _iAplicationService)
        {
            iAplicationService = _iAplicationService;
        }

        // GET: api/Aplications
        public List<Aplication> GetAplications()
        {
            return iAplicationService.Get();
        }

        // GET: api/Aplications/5
        public Aplication GetAplicationsType(int id)
        {
            return iAplicationService.Get(id);
        }

        // PUT: api/Aplications/5


        // POST: api/Aplications
        //untuk insert data
        public void InsertAplication(AplicationVM aplicationVM)
        {
            iAplicationService.Insert(aplicationVM);
        }

        // DELETE: api/Aplications/5


    }
}