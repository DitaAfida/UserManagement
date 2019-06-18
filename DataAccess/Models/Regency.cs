using Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Regency")]
    public class Regency : BaseModel
    {
        public string Regency_Name { get; set; }

        [ForeignKey("Province")]
        public int Province_Id { get; set; }
        public Province Province { get; set; }

    }
}
