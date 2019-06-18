using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class ProvinceVM
    {
        public int Id { get; set; }
        public string Province_Name { get; set; }

        public ProvinceVM() { }

        public ProvinceVM(string province_name)
        {
            this.Province_Name = province_name;
        }

        public void Update(int id, string province_name)
        {
            this.Id = id;
            this.Province_Name = province_name;
        }
    }
}
