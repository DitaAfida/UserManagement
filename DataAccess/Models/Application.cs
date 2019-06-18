using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Application")]
    public class Application
    {
        public int Id {get; set; }
        public string Application_Name { get; set; }
    }
}
