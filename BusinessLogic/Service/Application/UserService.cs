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
    public class UserService : IUserService
    {
        public UserService() { }
        private readonly IUserRepository iUserRepository;
        public UserService(IUserRepository _iUserRepositoy)
        {
            iUserRepository = _iUserRepositoy;
        }
        bool status = false;

        public List<User> Get()
        {
            return iUserRepository.Get();
        }

        public List<User> GetSearch(string values)
        {
            return iUserRepository.GetSearch(values);
        }

        public User Get(int id)
        {
            return iUserRepository.Get(id);
        }

        public bool Insert(UserVM userVM)
        {
            if (string.IsNullOrWhiteSpace(userVM.Password))
            {
                return status;
            }
            else
            {
                return iUserRepository.Insert(userVM);
            }
        }

        public bool Update(int id, UserVM userVM)
        {
            return iUserRepository.Update(id, userVM);
        }

        public bool Delete(int id)
        {
            return iUserRepository.Delete(id);
        }
    }
}
