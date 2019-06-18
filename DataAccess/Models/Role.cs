using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Role")]
    public class Role
    {
        public int Id { get; set; }
        public int Role_Name { get; set; }
    }
}
