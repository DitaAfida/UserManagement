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
    public class RoleService : IRoleService
    {
        public RoleService() { }
        private readonly IRoleRepository iRoleRepository;
        public RoleService(IRoleRepository _iRoleRepository)
        {
            iRoleRepository = _iRoleRepository;
        }
        bool status = false;

        public List<Role> Get()
        {
            return iRoleRepository.Get();
        }

        public List<Role> GetSearch(string values)
        {
            return iRoleRepository.GetSearch(values);
        }

        public Role Get(int id)
        {
            return iRoleRepository.Get(id);
        }

        public bool Insert(RoleVM roleVM)
        {
            if (string.IsNullOrWhiteSpace(roleVM.Role_Name))
            {
                return status;
            }
            else
            {
                return iRoleRepository.Insert(roleVM);
            }
        }

        public bool Update(int id, RoleVM roleVM)
        {
            return iRoleRepository.Update(id, roleVM);
        }

        public bool Delete(int id)
        {
            return iRoleRepository.Delete(id);
        }
    }
}
