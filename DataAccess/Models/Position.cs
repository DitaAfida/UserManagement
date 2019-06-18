using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Position")]
    public class Position
    {
        public int Id { get; set; }
        public string Position_Name { get; set; }
    }
}
