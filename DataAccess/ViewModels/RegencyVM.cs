using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class RegencyVM
    {
        public int Id { get; set; }
        public string Regency_Name { get; set; }
        
        public int Province_Id { get; set; }

        public RegencyVM() { }

        public RegencyVM(string regency_name, int province_id)
        {
            this.Regency_Name = regency_name;
            this.Province_Id = province_id;
        }

        public void Update(int id, string regency_name, int province_id)
        {
            this.Id = id;
            this.Regency_Name = regency_name;
            this.Province_Id = province_id;
        }
    }
}
