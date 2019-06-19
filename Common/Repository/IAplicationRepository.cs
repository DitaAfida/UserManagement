using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public interface IAplicationRepository
    {
        List<Aplication> Get();
        List<Aplication> GetSearch(string values);
        Aplication Get(int id);
        bool Insert(AplicationVM aplicationVM);
        bool Update(int id, AplicationVM aplicationVM);
        bool Delete(int id);
    }
}
