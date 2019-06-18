using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class UserApplicationVM
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int Application_Id { get; set; }

        public UserApplicationVM() { }

        public UserApplicationVM(int user_id, int application_id)
        {
            this.User_Id = user_id;
            this.Application_Id = application_id;
        }

        public void Update(int id, int user_id, int application_id)
        {
            this.Id = id;
            this.User_Id = user_id;
            this.Application_Id = application_id;
        }
    }
}
