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
    public class RegencyService : IRegencyService
    {
        public RegencyService() { }
        private readonly IRegencyRepository iRegencyRepository;
        public RegencyService(IRegencyRepository _iRegencyRepositoy)
        {
            iRegencyRepository = _iRegencyRepositoy;
        }
        bool status = false;

        public List<Regency> Get()
        {
            return iRegencyRepository.Get();
        }

        public List<Regency> GetSearch(string values)
        {
            return iRegencyRepository.GetSearch(values);
        }

        public Regency Get(int id)
        {
            return iRegencyRepository.Get(id);
        }

        public bool Insert(RegencyVM regencyVM)
        {
            if (string.IsNullOrWhiteSpace(regencyVM.Regency_Name))
            {
                return status;
            }
            else
            {
                return iRegencyRepository.Insert(regencyVM);
            }
        }

        public bool Update(int id, RegencyVM regencyVM)
        {
            return iRegencyRepository.Update(id, regencyVM);
        }

        public bool Delete(int id)
        {
            return iRegencyRepository.Delete(id);
        }
    }
}
