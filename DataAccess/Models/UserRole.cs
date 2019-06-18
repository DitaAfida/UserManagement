using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_R_UserRole")]
    public class UserRole
    {
        [ForeignKey("Role")]
        public int User_Id { get; set; }
        public Role Role { get; set; }

        [ForeignKey("User")]
        public int Role_Id { get; set; }
        public User User { get; set; }
    }
}
