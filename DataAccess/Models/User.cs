using Core.Base;
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
    }
}
