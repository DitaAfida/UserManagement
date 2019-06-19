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
    public class AplicationService : IAplicationService
    {
        public AplicationService() { }
        private readonly IAplicationRepository iAplicationRepository;
        public AplicationService(IAplicationRepository _iAplicationRepositoy)
        {
            iAplicationRepository = _iAplicationRepositoy;
        }
        bool status = false;

        public List<Aplication> Get()
        {
            return iAplicationRepository.Get();
        }

        public List<Aplication> GetSearch(string values)
        {
            return iAplicationRepository.GetSearch(values);
        }

        public Aplication Get(int id)
        {
            return iAplicationRepository.Get(id);
        }

        public bool Insert(AplicationVM aplicationVM)
        {
            if (string.IsNullOrWhiteSpace(aplicationVM.Application_Name))
            {
                return status;
            }
            else
            {
                return iAplicationRepository.Insert(aplicationVM);
            }
        }

        public bool Update(int id, AplicationVM aplicationVM)
        {
            return iAplicationRepository.Update(id, aplicationVM);
        }

        public bool Delete(int id)
        {
            return iAplicationRepository.Delete(id);
        }
    }
}
