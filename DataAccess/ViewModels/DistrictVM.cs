using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class DistrictVM
    {
        public int Id { get; set; }
        public string District_Name { get; set; }

        public int Regency_Id { get; set; }

        public DistrictVM() { }

        public DistrictVM(string district_name, int regency_id)
        {
            this.District_Name = district_name;
            this.Regency_Id = regency_id;
        }

        public void Update (int id, string district_name, int regency_id)
        {
            this.Id = id;
            this.District_Name = district_name;
            this.Regency_Id = regency_id;
        }
    }
}
