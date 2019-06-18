using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_District")]
    public class District
    {
        public int Id { get; set; }
        public string District_Name { get; set; }

        [ForeignKey("Regency")]
        public int Regency_Id { get; set; }
    }
}
