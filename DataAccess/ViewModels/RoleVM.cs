using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class RoleVM
    {
        public int Id { get; set; }
        public string Role_Name { get; set; }

        public RoleVM() { }

        public RoleVM(string role_name)
        {
            this.Role_Name = role_name;
        }

        public void Update(int id, string role_name)
        {
            this.Id = id;
            this.Role_Name = role_name;
        }
    }
}
