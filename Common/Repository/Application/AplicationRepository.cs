using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using System.Data.Entity;
using DataAccess.Context;

namespace Common.Repository.Application
{
    public class AplicationRepository : IAplicationRepository
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

        public List<Aplication> Get()
        {

            var get = myContext.Aplications.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Aplication Get(int id)
        {
            var get = myContext.Aplications.Find(id);
            return get;

        }

        public List<Aplication> GetSearch(string values)
        {
            var get = myContext.Aplications.Where(x => (x.Application_Name.Contains(values) ||x.Id.ToString().Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(AplicationVM aplicationVM)
        {
            var push = new Aplication(aplicationVM);
            myContext.Aplications.Add(push);
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

        public bool Update(int id, AplicationVM aplicationVM)
        {
            var put = Get(id);
            put.Update(aplicationVM);
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
