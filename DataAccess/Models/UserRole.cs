using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_T_UserRole")]
    public class UserRole : BaseModel
    {
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public User User { get; set; }

        [ForeignKey("Role")]
        public int Role_Id { get; set; }
        public Role Role { get; set; }

        public UserRole() { }

        public UserRole(UserRoleVM userRoleVM)
        {
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(UserRoleVM userRoleVM)
        {
            this.Id = userRoleVM.Id;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
