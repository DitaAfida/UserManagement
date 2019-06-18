using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Department")]
    public class Department
    {
        public int Id { get; set; }
        public string Department_Name { get; set; }
    }
}
