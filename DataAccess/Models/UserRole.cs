using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_R_UserRole")]
    public class UserRole
    {
        public int User_Id { get; set; }
        public int Role_Id { get; set; }
    }
}
