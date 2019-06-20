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
    public class PositionsController : ApiController
    {
        private MyContext db = new MyContext();
        //konstruktor
        public PositionsController() { }
        //interface
        private readonly IPositionService iPositionService;
        //ini kontruktor
        public PositionsController(IPositionService _iPositionService)
        {
            iPositionService = _iPositionService;
        }

        // GET: api/Positions
        public List<Position> GetPositions()
        {
            return iPositionService.Get();
        }

        // GET: api/Positions/5
        public Position GetPositionsType(int id)
        {
            return iPositionService.Get(id);
        }

        // PUT: api/Positions/5


        // POST: api/Positions
        //untuk insert
        public void InsertPosotion(PositionVM positionVM)
        {
            iPositionService.Insert(positionVM);
        }


        // DELETE: api/Positions/5

    }
}