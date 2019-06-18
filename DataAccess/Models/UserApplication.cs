using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_T_UserApplication")]
    public class UserApplication
    {
        public int User_Id { get; set; }
        public int Application_Id { get; set; }
    }
}
