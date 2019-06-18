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
    [Table("TB_M_User")]
    public class User : BaseModel
    {
        public string Password { get; set; }

        [ForeignKey("Employee")]
        public int Employee_Id { get; set; }
        public Employee Employee { get; set; }

        public User() { }
        
        public User(UserVM userVM)
        {
            this.Password = userVM.Password;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update (UserVM userVM)
        {
            this.Id = userVM.Id;
            this.Password = userVM.Password;
            this.UpdateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete ()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime ()
        }
    }


   
}
