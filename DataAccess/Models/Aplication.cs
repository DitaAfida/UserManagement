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
    [Table("TB_M_Application")]
    public class Aplication : BaseModel
    {
        public ICollection<User> ListUser { get; set; }
        public string Application_Name { get; set; }

        public Aplication() { }

        public Aplication(AplicationVM aplicationVM)
        {
            this.Application_Name = aplicationVM.Application_Name;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(AplicationVM aplicationVM)
        {
            this.Id = aplicationVM.Id;
            this.Application_Name = aplicationVM.Application_Name;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
