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
    [Table("TB_M_Role")]
    public class Role : BaseModel
    {
        public string Role_Name { get; set; }

        public Role() { }

        public Role(RoleVM roleVM)
        {
            this.Role_Name = roleVM.Role_Name;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(RoleVM roleVM)
        {
            this.Id = roleVM.Id;
            this.Role_Name = roleVM.Role_Name;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
