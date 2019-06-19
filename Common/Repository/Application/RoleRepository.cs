using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using DataAccess.Context;
using System.Data.Entity;

namespace Common.Repository.Application
{
    public class RoleRepository : IRoleRepository
    {
        MyContext myContext = new MyContext();
        bool status = false;
        public bool Delete(int id)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Delete();
                myContext.Entry(get).State = EntityState.Modified;
                var result = myContext.SaveChanges();
                return result > 0;
            }
            else
            {
                return false;
            }
        }

        public List<Role> Get()
        {
            var get = myContext.Roles.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Role Get(int id)
        {
            var get = myContext.Roles.Find(id);
            return get;
        }

        public List<Role> GetSearch(string values)
        {
            var get = myContext.Roles.Where(x => (x.Role_Name.Contains(values) ||
                x.Id.ToString().Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(RoleVM roleVM)
        {
            var push = new Role(roleVM);
            myContext.Roles.Add(push);
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }

        public bool Update(int id, RoleVM roleVM)
        {
            var put = Get(id);
            put.Update(roleVM);
            myContext.Entry(put).State = EntityState.Modified;
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }
    }
}
