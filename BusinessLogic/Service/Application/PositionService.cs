using Common.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace BusinessLogic.Service.Application
{
    public class PositionService : IPositionService
    {
        public PositionService() { }
        private readonly IPositionRepository iPositionRepository;
        public PositionService(IPositionRepository _iPositionRepositoy)
        {
            iPositionRepository = _iPositionRepositoy;
        }
        bool status = false;

        public List<Position> Get()
        {
            return iPositionRepository.Get();
        }

        public List<Position> GetSearch(string values)
        {
            return iPositionRepository.GetSearch(values);
        }

        public Position Get(int id)
        {
            return iPositionRepository.Get(id);
        }

        public bool Insert(PositionVM positionVM)
        {
            if (string.IsNullOrWhiteSpace(positionVM.Position_Name))
            {
                return status;
            }
            else
            {
                return iPositionRepository.Insert(positionVM);
            }
        }

        public bool Update(int id, PositionVM positionVM)
        {
            return iPositionRepository.Update(id, positionVM);
        }

        public bool Delete(int id)
        {
            return iPositionRepository.Delete(id);
        }
    }
}
