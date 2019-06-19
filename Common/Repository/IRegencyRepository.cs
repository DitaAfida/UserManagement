﻿using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public interface IRegencyRepository
    {
        List<Regency> Get();
        List<Regency> GetSearch(string values);
        Regency Get(int id);
        bool Insert(RegencyVM regencyVM);
        bool Update(int id, RegencyVM regencyVM);
        bool Delete(int id);
    }
}
