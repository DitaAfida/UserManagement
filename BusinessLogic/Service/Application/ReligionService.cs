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
    public class ReligionService : IReligionService
    {
        public ReligionService() { }
        private readonly IReligionRepository iReligionRepository;
        public ReligionService(IReligionRepository _iReligionRepositoy)
        {
            iReligionRepository = _iReligionRepositoy;
        }
        bool status = false;

        public List<Religion> Get()
        {
            return iReligionRepository.Get();
        }

        public List<Religion> GetSearch(string values)
        {
            return iReligionRepository.GetSearch(values);
        }

        public Religion Get(int id)
        {
            return iReligionRepository.Get(id);
        }

        public bool Insert(ReligionVM religionVM)
        {
            if (string.IsNullOrWhiteSpace(religionVM.Name))
            {
                return status;
            }
            else
            {
                return iReligionRepository.Insert(religionVM);
            }
        }

        public bool Update(int id, ReligionVM religionVM)
        {
            return iReligionRepository.Update(id, religionVM);
        }

        public bool Delete(int id)
        {
            return iReligionRepository.Delete(id);
        }
    }
}
