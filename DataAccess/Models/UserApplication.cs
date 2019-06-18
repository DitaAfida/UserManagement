using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_T_UserApplication")]
    public class UserApplication
    {
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public User User { get; set; }
        [ForeignKey("Application")]
        public int Application_Id { get; set; }
        public Application Application { get; set; }
    }
}
