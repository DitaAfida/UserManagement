using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_User")]
    public class User
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public int Employee_Id { get; set; }
    }
}
