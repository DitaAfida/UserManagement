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
    [Table("TB_T_UserApplication")]
    public class UserApplication : BaseModel
    {
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public User User { get; set; }
        [ForeignKey("Application")]
        public int Application_Id { get; set; }
        public Aplication Application { get; set; }

        public UserApplication() { }

        public UserApplication(UserApplicationVM userApplicationVM)
        {
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(UserApplicationVM userApplicationVM)
        {
            this.Id = userApplicationVM.Id;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
