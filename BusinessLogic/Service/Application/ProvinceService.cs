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
    public class ProvinceService : IProvinceService
    {
        public ProvinceService() { }
        private readonly IProvinceRepository iProvinceRepository;
        public ProvinceService(IProvinceRepository _iProvinceRepositoy)
        {
            iProvinceRepository = _iProvinceRepositoy;
        }
        bool status = false;

        public List<Province> Get()
        {
            return iProvinceRepository.Get();
        }

        public List<Province> GetSearch(string values)
        {
            return iProvinceRepository.GetSearch(values);
        }

        public Province Get(int id)
        {
            return iProvinceRepository.Get(id);
        }

        public bool Insert(ProvinceVM provinceVM)
        {
            if (string.IsNullOrWhiteSpace(provinceVM.Province_Name))
            {
                return status;
            }
            else
            {
                return iProvinceRepository.Insert(provinceVM);
            }
        }

        public bool Update(int id, ProvinceVM provinceVM)
        {
            return iProvinceRepository.Update(id, provinceVM);
        }

        public bool Delete(int id)
        {
            return iProvinceRepository.Delete(id);
        }
    }
}
