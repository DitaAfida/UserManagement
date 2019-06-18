using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class VillageVM
    {
        public int Id { get; set; }
        public string Village_Name { get; set; }

        public int District_Id { get; set; }

        public VillageVM() { }

        public VillageVM(string village_name, int district_id)
        {
            this.Village_Name = village_name;
            this.District_Id = district_id;
        }

        public void Update(int id, string village_name, int district_id)
        {
            this.Id = id;
            this.Village_Name = village_name;
            this.District_Id = district_id;
        }
    }
}
