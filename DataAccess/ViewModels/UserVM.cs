using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class UserVM
    {
        public int Id { get; set; }
        public string Password { get; set; }

        public int Employee_Id { get; set; }

        public UserVM() { }

        public UserVM( string password, int employee_id)
        {
            this.Password = password;
            this.Employee_Id = employee_id;

        }

        public void Update(int id, string password, int employee_id)
        {
            this.Id = id;
            this.Password = password;
            this.Employee_Id = employee_id;
        }
    }

}
