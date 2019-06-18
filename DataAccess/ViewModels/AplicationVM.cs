using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class AplicationVM
    {
        public int Id { get; set; }
        public string Application_Name { get; set; }

        public AplicationVM() { }

        public AplicationVM(string application_name)
        {
            this.Application_Name = application_name;
        }

        public void Update(int id, string application_name)
        {
            this.Id = id;
            this.Application_Name = application_name;
        }

    }
}
