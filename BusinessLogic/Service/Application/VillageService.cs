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
    public class VillageService : IVillageService
    {
        public VillageService() { }
        private readonly IVillageRepository iVillageRepository;
        public VillageService(IVillageRepository _iVillageRepositoy)
        {
            iVillageRepository = _iVillageRepositoy;
        }
        bool status = false;

        public List<Village> Get()
        {
            return iVillageRepository.Get();
        }

        public List<Village> GetSearch(string values)
        {
            return iVillageRepository.GetSearch(values);
        }

        public Village Get(int id)
        {
            return iVillageRepository.Get(id);
        }

        public bool Insert(VillageVM villageVM)
        {
            if (string.IsNullOrWhiteSpace(villageVM.Village_Name))
            {
                return status;
            }
            else
            {
                return iVillageRepository.Insert(villageVM);
            }
        }

        public bool Update(int id, VillageVM villageVM)
        {
            return iVillageRepository.Update(id, villageVM);
        }

        public bool Delete(int id)
        {
            return iVillageRepository.Delete(id);
        }
    }
}
