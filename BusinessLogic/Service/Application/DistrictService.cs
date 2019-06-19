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
    public class DistrictService: IDistrictService
    {
        public DistrictService() { }
        private readonly IDistrictRepository iDistrictRepository;
        public DistrictService(IDistrictRepository _iDistrictRepositoy)
        {
            iDistrictRepository = _iDistrictRepositoy;
        }
        bool status = false;

        public List<District> Get()
        {
            return iDistrictRepository.Get();
        }

        public List<District> GetSearch(string values)
        {
            return iDistrictRepository.GetSearch(values);
        }

        public District Get(int id)
        {
            return iDistrictRepository.Get(id);
        }

        public bool Insert(DistrictVM districtVM)
        {
            if (string.IsNullOrWhiteSpace(districtVM.District_Name))
            {
                return status;
            }
            else
            {
                return iDistrictRepository.Insert(districtVM);
            }
        }

        public bool Update(int id, DistrictVM districtVM)
        {
            return iDistrictRepository.Update(id, districtVM);
        }

        public bool Delete(int id)
        {
            return iDistrictRepository.Delete(id);
        }
    }
}
