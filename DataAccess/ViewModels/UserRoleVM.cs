using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class UserRoleVM
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int Role_Id { get; set; }

        public UserRoleVM() { }

        public UserRoleVM(int user_id, int role_id)
        {
            this.User_Id = user_id;
            this.Role_Id = role_id;
        }

        public void Update(int id, int user_id, int role_id)
        {
            this.Id = id;
            this.User_Id = user_id;
            this.Role_Id = role_id;
        }
    }
}
