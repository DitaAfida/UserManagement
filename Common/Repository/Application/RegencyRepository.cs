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
    public class RegencyRepository : IRegencyRepository
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

        public List<Regency> Get()
        {
            var get = myContext.Regencys.Include("Province").Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Regency Get(int id)
        {
            var get = myContext.Regencys.Find(id);
            return get;
        }

        public List<Regency> GetSearch(string values)
        {
            var get = myContext.Regencys.Include("Province").Where(x => (x.Regency_Name.Contains(values) ||
                x.Id.ToString().Contains(values)||
                x.Province.Province_Name.Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(RegencyVM regencyVM)
        {
            var push = new Regency(regencyVM);
            var getProviceId = myContext.Provinces.Find(regencyVM.Province_Id);
            push.Province = getProviceId;
            myContext.Regencys.Add(push);
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

        public bool Update(int id, RegencyVM regencyVM)
        {
            var put = Get(id);
            var getProviceId = myContext.Provinces.Find(regencyVM.Province_Id);
            put.Province = getProviceId;
            put.Update(regencyVM);
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
