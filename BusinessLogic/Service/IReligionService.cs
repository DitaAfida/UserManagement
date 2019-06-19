using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public interface IReligionService
    {
        List<Religion> Get();
        List<Religion> GetSearch(string values);
        Religion Get(int id);
        bool Insert(ReligionVM religionVM);
        bool Update(int id, ReligionVM religionVM);
        bool Delete(int id);
    }
}
