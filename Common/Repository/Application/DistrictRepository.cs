﻿
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
    public class DistrictRepository : IDistrictRepository
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

        public List<District> Get()
        {
            var get = myContext.Districts.Include("Regency").Include("Regency.Province").Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public District Get(int id)
        {
            var get = myContext.Districts.Find(id);
            return get;
        }

        public List<District> GetSearch(string values)
        {
            var get = myContext.Districts.Include("Regency").Include("Regency.Province").Where(x => (x.District_Name.Contains(values) ||
               x.Id.ToString().Contains(values)||
               x.Regency.Regency_Name.Contains(values) ||
               x.Regency.Province.Province_Name.Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(DistrictVM districtVM)
        {
            var push = new District(districtVM);
            var getRegencyId = myContext.Regencys.Find(districtVM.Regency_Id);
            push.Regency = getRegencyId;
            myContext.Districts.Add(push);
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

        public bool Update(int id, DistrictVM districtVM)
        {
            var put = Get(id);
            var getRegencyId = myContext.Regencys.Find(districtVM.Regency_Id);
            put.Regency = getRegencyId;
            put.Update(districtVM);
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